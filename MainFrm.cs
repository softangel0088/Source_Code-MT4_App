using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MTClientAPI;

namespace FXFellowDashboard
{
    public partial class MainFrm : Form
    {
        bool client_expand = true;
        int dashboard_setting = -1;
        int label1_order_id;
        int label2_order_id;

        bool margin_call_on;
        bool money_shift_on;
        bool phone_notify_on;

        static ControlPage g_page_client = new ControlPage();
        static ControlPage g_page_dashboard = new ControlPage();
        static ControlPage g_page_orders = new ControlPage();
        static ControlPage g_page_pamm = new ControlPage();

        static SQLiteWrapper g_sql = new SQLiteWrapper();
        static ClientLogin g_client = new ClientLogin();
        static MT4APIWrapper g_API = new MT4APIWrapper();
        static PriceAlert g_price_alert = new PriceAlert();

        private System.Timers.Timer auto_login_timer = null;
        private System.Timers.Timer update_panels_timer = null;
        private System.Timers.Timer check_reopen_timer = null;
        private System.Timers.Timer login_timer = null;
        private System.Timers.Timer save_pdf_timer = null;
        private System.Timers.Timer download_quote_timer = null;

        private int account_login_request = 0;

        private DateTime check_reopen_last_time;
        private DateTime save_pdf_last_time;
        private DateTime save_commission_last_time;

        private bool is_quote_updated;
        private bool show_client_flag;

        public static MainFrm mainFrm;

        private double chart_custom_ratio;
        private double chart_custom_price;

        private TradingDeskState tradingdesk_state;
        private ShowOrderState showorder_state;
        private ShowOrderState showorder_state_new;
        private ManageAlertState manage_alert_state;
        private ControlPendingState control_pending_state;

        private int selected_pending_order;
        private bool is_moneyshift_processing;
        private bool close_trades_enabled;

        List<string> list_server_info;

        public MainFrm()
        {
            mainFrm = this;
            InitializeComponent();
            this.FormClosing += FormClosing_Event;
            this.StartPosition = FormStartPosition.CenterScreen;
            Settings.Log.Info("Start FXFellow Dashboard...");
        }

        void FormClosing_Event(object sender, FormClosingEventArgs e)
        {
            auto_login_timer.Close();
            update_panels_timer.Close();
            check_reopen_timer.Close();

            g_client.isExit = true;

            if (Settings.broker_mode)
            {
                save_license();
                //g_sql.save_encrypt_account();
            }

            save_swap_start_date();

            int moneyshit = money_shift_on ? 1 : 0;
            int margincall = margin_call_on? 1 : 0;
            int phonenotify  = phone_notify_on ? 1 : 0;
            g_sql.save_settings(moneyshit, margincall, phonenotify);

            g_sql.save_SLTP(g_client.dict_SLTP);
            g_client.unsubscribe_all_clients();
            g_client.disconnect_all_clients();

            Settings.Log.Info("Exit FXFellow Dashboard...");
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                init();
                read_client_from_db();
                login_initial_client();
                nav_login_Click(sender, e);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Loading main form failed: " + ex.ToString());
            }
        }

        private void init()
        {
            try
            {
                Settings.Init();
                change_symbol_num();

                g_page_client.Init();
                g_page_dashboard.Init();
                g_page_orders.Init();
                g_page_pamm.Init();

                g_client.Init();
                g_sql.Init();
                g_API.Init();
                g_price_alert.Init();

                read_server_info();

                g_API.set_client_class(g_client);
                g_API.initial_login_finished_handle += login_initial_finished;
                g_API.new_login_finished_handle += login_new_finished;
                g_API.connection_changed_handle += login_connection_changed;
                g_API.currency_changed_handle += login_currency_changed;
                g_API.OnQuote_handle += OnQuote_called;
                g_API.OnOrderUpdate_handle += OnOrderUpdate_called;
                g_API.draw_chart_handle_R3 += draw_chart_called_R3;
                g_API.draw_chart_handle_R8 += draw_chart_called_R8;

                td_buysell_ctrl.Init(g_API);
                td_buysell_ctrl.m_buysell_click_handle += btn_tradingdesk_buysell_Click;
                td_buysell_ctrl.m_buy_click_handle += btn_tradingdesk_buy_Click;
                td_buysell_ctrl.m_sell_click_handle += btn_tradingdesk_sell_Click;
                td_buysell_ctrl.m_symbol_change_handle += td_symbol_changed;

                pamm_buysell_ctrl.Init(g_API);
                pamm_buysell_ctrl.m_buysell_click_handle += btn_pamm_buysell_Click;
                pamm_buysell_ctrl.m_buy_click_handle += btn_pamm_buy_Click;
                pamm_buysell_ctrl.m_sell_click_handle += btn_pamm_sell_Click;
                pamm_buysell_ctrl.m_symbol_change_handle += pamm_symbol_changed;

                init_ui();
                init_number_format();
                //check_font_installed();

                List<int> settingList = g_sql.read_settings();
                money_shift_on = (settingList[0] == 1);
                margin_call_on = (settingList[1] == 1);
                phone_notify_on = (settingList[2] == 1);
                update_setting_labels();

                g_client.dict_SLTP = g_sql.read_SLTP();          

                auto_login_timer = new System.Timers.Timer();
                auto_login_timer.Interval = 1000;
                auto_login_timer.Elapsed += new System.Timers.ElapsedEventHandler(auto_login_timer_tick);
                auto_login_timer.Enabled = true;

                update_panels_timer = new System.Timers.Timer();
                update_panels_timer.Interval = Settings.update_time_limit;
                update_panels_timer.Elapsed += new System.Timers.ElapsedEventHandler(update_panels_timer_tick);
                update_panels_timer.Enabled = true;

                check_reopen_timer = new System.Timers.Timer();
                check_reopen_timer.Interval = 1000;
                check_reopen_timer.Elapsed += new System.Timers.ElapsedEventHandler(check_reopen_timer_tick);
                check_reopen_timer.Enabled = true;

                save_pdf_timer = new System.Timers.Timer();
                save_pdf_timer.Interval = 1000;
                save_pdf_timer.Elapsed += new System.Timers.ElapsedEventHandler(save_statement_commission_timer_tick);
                save_pdf_timer.Enabled = true;

                check_reopen_last_time = DateTime.MinValue;
                save_pdf_last_time = DateTime.MinValue;
                save_commission_last_time = DateTime.MinValue;

                login_timer = new System.Timers.Timer();
                login_timer.Interval = 500;
                login_timer.Elapsed += new System.Timers.ElapsedEventHandler(check_account_login_timer_tick);
                login_timer.Enabled = true;

                download_quote_timer = new System.Timers.Timer();
                download_quote_timer.Interval = 500;
                download_quote_timer.Elapsed += new System.Timers.ElapsedEventHandler(download_quote_tick);
                download_quote_timer.Enabled = true;

                is_quote_updated = false;
                show_client_flag = true;

                chart_custom_price = -1;
                chart_custom_ratio = -1;

                tradingdesk_state = TradingDeskState.ShowOrder;
                showorder_state = ShowOrderState.ShowAll;
                showorder_state_new = ShowOrderState.ShowAll;
                manage_alert_state = ManageAlertState.AddAlert;
                control_pending_state = ControlPendingState.AddPending;

                selected_pending_order = -1;

                is_moneyshift_processing = false;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Init failed: " + ex.ToString());
            }
        }

        private void read_server_info()
        {
            string folderWithServers = Path.Combine(Directory.GetCurrentDirectory(), "Servers");

            DirectoryInfo d = new DirectoryInfo(folderWithServers);
            FileInfo[] Files = d.GetFiles("*.srv"); //Getting Text files

            list_server_info = new List<string>();

            foreach (FileInfo file in Files)
            {
                string fileName = file.Name;
                fileName = fileName.Remove(fileName.Length - 4);
                list_server_info.Add(fileName);
            }
        }

        private void change_symbol_num()
        {
            if(!Settings.broker_mode)
            {
                //Settings.symbol_num = 3;
            }
        }

        private void check_font_installed()
        {
            try
            {
                string fontName = "Roboto";
                float fontSize = 12;
                using (Font fontTester = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel))
                {
                    if (fontTester.Name == fontName) return;
                }

                install_font(@"Fonts\Roboto-Regular.ttf");
                install_font(@"Fonts\Roboto-Bold.ttf");
                install_font(@"Fonts\Roboto-Italic.ttf");
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Check font install failed: " + ex.ToString());
            }
        }

        private void install_font(string font_str)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = font_str;
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            Process proc = Process.Start(psi);
            proc.WaitForExit();
        }

        private void check_reopen_timer_tick(object sender, EventArgs e)
        {
            if (!close_trades_enabled) return;
            if (!g_API.login_finished) return;

            DateTime cur_date = g_client.server_time;
            if (cur_date == DateTime.MinValue) return;

            //Reopen Orders
            //if (cur_date.Hour == 18 && check_reopen_last_time.Hour < 18 && check_reopen_last_time.Day == cur_date.Day)
            //{
            //    check_reopen_last_time = cur_date;
            //    var last_date = g_client.get_end_time(cur_date);
            //    if (last_date.Date == cur_date.Date)
            //    {
            //        g_API.reopen_old_orders_last_day();
            //    }
            //}

            if (cur_date.Hour == 18 && check_reopen_last_time.Hour < 18 && check_reopen_last_time.Day == cur_date.Day)
            {
                g_API.close_old_orders_per_day(cur_date);
            }

            check_reopen_last_time = cur_date;
        }

        private void save_statement_commission_timer_tick(object sender, EventArgs e)
        {
            check_save_commission();
            check_save_statement();
        }

        private void check_save_commission()
        {
            if (!g_API.login_finished) return;

            DateTime cur_date = g_client.server_time;
            if (cur_date == DateTime.MinValue) return;

            if (cur_date.Hour == 18 && save_commission_last_time.Hour < 18 && save_commission_last_time.Day == cur_date.Day)
            {
                save_commission_last_time = cur_date;
                var last_date = g_client.get_end_time(cur_date);
                if (last_date.Date == cur_date.Date)
                {
                    g_client.save_commission();
                }
            }
            save_commission_last_time = cur_date;
        }

        private void check_save_statement()
        {
            if (!Settings.vps_server) return;
            if (!g_API.login_finished) return;

            DateTime cur_date = g_client.server_time;
            if (cur_date == DateTime.MinValue) return;

            if (cur_date.Hour == 18 && save_pdf_last_time.Hour < 18 && save_pdf_last_time.Day == cur_date.Day)
            {
                save_pdf_last_time = cur_date;
                var last_date = g_client.get_end_time(cur_date);
                if (last_date.Date == cur_date.Date)
                {
                    save_statement_as_pdf();
                }
            }
            save_pdf_last_time = cur_date;
        }

        private void save_statement_as_pdf()
        {
            for(int i = 0; i < g_client.tot_client_num; i++)
            {
                StatementInfo info = new StatementInfo();
                Task.Run(() =>
                {
                    info = g_client.get_statement_info(i);
                }).Wait();

                statement_html_ctrl.AutoSavePDF(info);
            }
        }

        public void update_warning_label(string warning_str)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                lab_top_warning.Text = warning_str;
            });
        }

        private void download_quote_tick(object sender, EventArgs e)
        {
            try
            {
                g_API.DownloadQuoteHistory();
            }
            catch(Exception )
            {

            }
        }

        private void check_account_login_timer_tick(object sender, EventArgs e)
        {
            if (account_login_request == 0) return;
            if (!g_API.login_finished) return;

            this.InvokeOnUiThreadIfRequired(() =>
            {
                set_login_status(false);
            });

            if (account_login_request == 1)
            {
                account_login_request = 0;
                g_API.login_initial_client();
            }
            else if (account_login_request == 2)
            {
                account_login_request = 0;
                g_API.login_new_client();
            }
            else
            {
                int client_id = account_login_request - 3;
                account_login_request = 0;
                g_API.login_one_client(client_id);
            }
        }

        private void check_money_shift_is_valid()
        {
            if (is_moneyshift_processing)
                return;

            is_moneyshift_processing = true;
            int len = g_API.checkMoneyShiftList.Count;
            
            for(int i = len - 1; i >= 0; i--)
            {
                CheckMoneyShiftInfo info = g_API.checkMoneyShiftList[i];

                if((DateTime.Now - info.start_time).TotalMinutes > 10)
                {
                    g_API.checkMoneyShiftList.RemoveAt(i);
                }
                else if(info.finished1 && info.finished2) //all finished
                {
                    g_API.checkMoneyShiftList.RemoveAt(i);
                }
                else if(info.finished1 && !info.finished2)
                {
                    TimeSpan ts = DateTime.Now - info.end_time1;
                    if(ts.Seconds > 10)
                    {
                        string alert_str = string.Format("Moneyshift error: {0}({1},{2}) Amount:{3}", info.client_name, info.account1, info.account2, info.amount);

                        Settings.Log.Error(alert_str);
                        g_client.AlertSoundAndMessage(alert_str);
                        if (phone_notify_on) g_client.send_sms_price_alert(alert_str);

                        g_API.checkMoneyShiftList.RemoveAt(i);
                    }
                }
                else if(!info.finished1 && info.finished2)
                {
                    TimeSpan ts = DateTime.Now - info.end_time2;
                    if (ts.TotalSeconds > 10)
                    {
                        string alert_str = string.Format("Moneyshift error: {0}({1},{2}) Amount:{3}", info.client_name, info.account1, info.account2, info.amount);

                        Settings.Log.Error(alert_str);
                        g_client.AlertSoundAndMessage(alert_str);
                        if (phone_notify_on) g_client.send_sms_price_alert(alert_str);

                        g_API.checkMoneyShiftList.RemoveAt(i);
                    }
                }
            }
            is_moneyshift_processing = false;
        }

        private void update_panels_timer_tick(object sender, EventArgs e)
        {
            check_money_shift_is_valid();

            check_margin_call_on_off();

            if (!is_quote_updated) return;
            is_quote_updated = false;

            this.InvokeOnUiThreadIfRequired(() =>
            {
                update_panels(false);
            });
        }

        private void check_margin_call_on_off()
        {
            try
            {
                DateTime curTime = DateTime.Now;
                DateTime startTime = new DateTime(curTime.Year, curTime.Month, curTime.Day, 23, 05, 00);

                if (curTime >= startTime && (curTime - startTime).TotalSeconds <= 2)
                {
                    if(curTime.DayOfWeek == DayOfWeek.Friday)
                    {
                        if(margin_call_on)
                        {
                            margin_call_on = false;
                            update_setting_labels();
                        }
                    }
                    else if(curTime.DayOfWeek == DayOfWeek.Sunday)
                    {
                        if(!margin_call_on)
                        {
                            margin_call_on = true;
                            update_setting_labels();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Check margin call on off failed:" + ex.ToString());
            }
        }

        private void auto_login_timer_tick(object sender, EventArgs e)
        {
            if (g_client.isExit) return;
            if (account_login_request != 0) return;

            if (g_API.check_relogin_accounts())
            {
                this.InvokeOnUiThreadIfRequired(() =>
                {
                    nav_login_Click(this, EventArgs.Empty);
                    set_login_status(false);
                    g_API.relogin_accounts();
                });
            }
        }

        private void init_number_format()
        {
            var current = System.Threading.Thread.CurrentThread.CurrentCulture;
            var culture = System.Globalization.CultureInfo.CreateSpecificCulture(current.Name);
            culture.NumberFormat.NumberDecimalSeparator = ".";
            culture.NumberFormat.NumberGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void read_client_from_db()
        {
            g_client.read_client_from_db(g_sql);
        }

        private void login_initial_client()
        {
            if (g_client.no_client()) return;
            account_login_request = 1;
        }

        private void login_new_client()
        {
            account_login_request = 2;
        }

        private void login_one_client(int id)
        {
            account_login_request = 3 + id;
        }

        void set_login_status(bool value)
        {
            nav_dashboard.Enabled = value;
            nav_administrator.Enabled = value;
            nav_clients.Enabled = value;
            nav_pamm.Enabled = value;
            nav_settings.Enabled = value;
            nav_statistics.Enabled = value;
            nav_tradingdesk.Enabled = value;
            nav_details.Enabled = value;
            nav_orders.Enabled = value;
            nav_history.Enabled = value;
            nav_statement.Enabled = value;

            btn_login.Enabled = value;
            btn_search.Enabled = value;
            btn_setting.Enabled = value;
            btn_login_new_account.Enabled = value;

            //btn_expand.Enabled = value;
            //btn_show_password.Enabled = value;
            //btn_hide_password.Enabled = value;

            progress.Visible = !value;
        }

        private void login_initial_finished(object sender, EventArgs e)
        {
            try
            {
                this.InvokeOnUiThreadIfRequired(() =>
                {
                    check_license();
                    set_login_status(true);
                    show_clients_list();
                });
            }
            catch(Exception ex)
            {
                Settings.Log.Error("login initial finished failed: " + ex.ToString());
            }
        }

        private void login_new_finished(object sender, EventArgs e)
        {
            bool isSuccess = ((LoginArgs)e).isSuccess;
            try
            {
                this.InvokeOnUiThreadIfRequired(() =>
                {
                    set_login_status(true);
                    try
                    {
                        if (!isSuccess)
                        {
                            //g_client.remove_one_client(g_client.tot_client_num - 1);

                            Settings.Log.Error("Failed a new client login");
                            //MessageBox.Show("Login failed. Please input client information correctly");
                        }
                        else
                        {
                            Settings.Log.Info("Succeed a new client login");
                        }
                        show_clients_list();

                        ClientInfo client_info = new ClientInfo();
                        g_client.read_one_client(client_info, g_client.tot_client_num - 1);
                        g_sql.insert_client_into_db(client_info);
                    }
                    catch (Exception ex)
                    {
                        Settings.Log.Error("Update after new login failed: " + ex.ToString());
                    }
                });
            }
            catch(Exception ex)
            {
                Settings.Log.Error("login new finished failed: " + ex.ToString());
            }
        }

        private void login_connection_changed(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {                
                show_clients_list();
            });
        }

        private void login_currency_changed(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                show_clients_list();
            });
        }

        private void OnQuote_called(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                g_API.close_orders_SLTP();
                quote_order_changed(false);
            });
        }

        private void OnOrderUpdate_called(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                quote_order_changed(true);
            });
        }

        private void draw_chart_called_R3(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                if(IsControlAtFront(panel_tradingdesk)) //origin panel
                    draw_candle_chart_origin();
                else //new panel
                    draw_candle_chart_R3();
            });
        }

        private void draw_chart_called_R8(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                draw_candle_chart_R8(); //new panel
            });
        }

        private void init_nav_buttons()
        {
            foreach (var ctrl in nav_panel.Controls)
            {
                BunifuFlatButton btn = ctrl as BunifuFlatButton;
                if (btn != null)
                    btn.selected = false;
            }
            panel_tf_button.Visible = false;
            panel_balance_alert.Visible = false;

            btn_tradingdesk_new.Visible = false;
            lab_pip_difference.Visible = false;
            lab_stockprice_diff.Visible = false;

            lab_top_warning.Visible = false;
        }

        // Borderless resize
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        private void onmousewheel(object sender, MouseEventArgs e)
        {
            int prev_num = Settings.current_candle_num;

            Settings.current_candle_num -= e.Delta / 10;
            Settings.current_candle_num = Math.Min(Settings.current_candle_num, Settings.max_candle_num);
            Settings.current_candle_num = Math.Max(Settings.current_candle_num, Settings.min_candle_num);

            if (Settings.current_candle_num == prev_num) return;

            draw_candle_chart_origin();
            draw_candle_chart_R3();
            draw_candle_chart_R8();
        }

        private void btn_login_new_account_Click(object sender, EventArgs e)
        {
            Settings.Log.Info("Login new account");
            try
            {
                int same_id = g_client.save_new_account(ctrl_client);

                if(same_id == -2) return;
                else if(same_id != -1)
                {
                    delete_one_client(same_id);
                }
                login_new_client();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Login new client failed: " + ex.ToString());
            }
        }

        private void update_login_page_textbox()
        {
            tb_login_page.Text = g_page_client.update_current_state(); 
        }

        private void update_orders_page_textbox()
        {
            tb_orders_page.Text = g_page_orders.update_current_state();
        }

        private void update_dashboard_page_textbox()
        {
            tb_dashboard_page.Text = g_page_dashboard.update_current_state();
        }

        private void update_pamm_page_textbox()
        {
            tb_pamm_page.Text = g_page_pamm.update_current_state();
        }

        private void dp_login_display_num_onItemSelected(object sender, EventArgs e)
        {
            int curId = dp_login_display_num.selectedIndex;
            g_page_client.display_num = Settings.displayNumList[curId];
            show_clients_list();
        }

        private void dp_orders_display_num_onItemSelected(object sender, EventArgs e)
        {
            int curId = dp_orders_display_num.selectedIndex;
            g_page_orders.display_num = Settings.displayNumList[curId];
            show_orders();
        }

        private void dp_dashboard_display_num_onItemSelected(object sender, EventArgs e)
        {
            int curId = dp_dashboard_display_num.selectedIndex;
            g_page_dashboard.display_num = Settings.displayNumList[curId];
            show_dashboard();
        }

        private void dp_pamm_display_num_onItemSelected(object sender, EventArgs e)
        {
            int curId = dp_pamm_display_num.selectedIndex;
            g_page_pamm.display_num = Settings.displayNumList[curId];
            show_pamm();
        }

        private void btn_pamm_start_Click(object sender, EventArgs e)
        {
            g_page_pamm.start_click();
            show_pamm();
        }

        private void btn_pamm_prev_Click(object sender, EventArgs e)
        {
            g_page_pamm.prev_click();
            show_pamm();
        }

        private void btn_pamm_next_Click(object sender, EventArgs e)
        {
            g_page_pamm.next_click();
            show_pamm();
        }

        private void btn_pamm_end_Click(object sender, EventArgs e)
        {
            g_page_pamm.end_click();
            show_pamm();
        }

        private void btn_login_start_Click(object sender, EventArgs e)
        {
            g_page_client.start_click();
            show_clients_list();
        }

        private void btn_login_prev_Click(object sender, EventArgs e)
        {
            g_page_client.prev_click();
            show_clients_list();
        }

        private void btn_login_next_Click(object sender, EventArgs e)
        {
            g_page_client.next_click();
            show_clients_list();
        }

        private void btn_login_end_Click(object sender, EventArgs e)
        {
            g_page_client.end_click();
            show_clients_list();
        }

        private void btn_orders_start_Click(object sender, EventArgs e)
        {
            g_page_orders.start_click();
            show_orders();
        }

        private void btn_orders_prev_Click(object sender, EventArgs e)
        {
            g_page_orders.prev_click();
            show_orders();
        }

        private void btn_orders_next_Click(object sender, EventArgs e)
        {
            g_page_orders.next_click();
            show_orders();
        }

        private void btn_orders_end_Click(object sender, EventArgs e)
        {
            g_page_orders.end_click();
            show_orders();
        }

        private void btn_dashboard_start_Click(object sender, EventArgs e)
        {
            g_page_dashboard.start_click();
            show_dashboard();
        }

        private void btn_dashboard_prev_Click(object sender, EventArgs e)
        {
            g_page_dashboard.prev_click();
            show_dashboard();
        }

        private void btn_dashboard_next_Click(object sender, EventArgs e)
        {
            g_page_dashboard.next_click();
            show_dashboard();
        }

        private void btn_dashboard_end_Click(object sender, EventArgs e)
        {
            g_page_dashboard.end_click();
            show_dashboard();
        }

        private void show_clients_list()
        {
            if (g_API.login_finished) set_login_status(true);
            
            try
            {
                g_page_client.tot_num = g_client.tot_client_num;
                update_login_page_textbox();

                ClientInfo _info = new ClientInfo();

                flow_clients.SuspendLayout();
                foreach (ClientCtrl ctr in flow_clients.Controls)
                {
                    int control_id = flow_clients.Controls.IndexOf(ctr);
                    int overall_id = g_page_client.get_overall_id(control_id);
                    if (control_id >= g_page_client.display_num || overall_id < 0)
                    {
                        ctr.Hide();
                        continue;
                    }
                    ctr.Show();

                    g_client.read_one_client(_info, overall_id);
                    ctr.set_contents(_info, show_client_flag);
                }
                flow_clients.ResumeLayout();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Show clients failed: " + ex.ToString());
            }
        }

        private void client_dbl_click(object sender, EventArgs arg)
        {
            try
            {
                if (!g_API.login_finished) return;

                int control_id = flow_clients.Controls.IndexOf(sender as Control);
                int overall_id = g_page_client.get_overall_id(control_id);

                if (overall_id >= 0)
                    login_one_client(overall_id);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("client dbl click failed: " + ex.ToString());
            }
        }

        private void client_delete_click(object sender, EventArgs arg)
        {
            try
            {
                if (!g_API.login_finished) return;

                int control_id = flow_clients.Controls.IndexOf(sender as Control);
                int overall_id = g_page_client.get_overall_id(control_id);

                if (overall_id >= 0)
                {
                    delete_one_client(overall_id);
                    show_clients_list();
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("client delete click failed: " + ex.ToString());
            }
        }

        private void delete_one_client(int client_id)
        {
            if (client_id >= g_client.tot_client_num) return;

            try
            {
                ClientInfo info = new ClientInfo();
                g_client.read_one_client(info, client_id);
                g_sql.delete_one_client(info);

                Settings.Log.Info($"Client(Name = {g_client.nameList[client_id]}, userId1 = {g_client.userIdList[2 * client_id]}, userId2 = {g_client.userIdList[2 * client_id + 1]}) was deleted");

                g_client.remove_one_client(client_id);
                g_client.update_clients_after_delete();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("client delete failed: " + ex.ToString());
            }
        }

        private void set_password_visible(bool fg)
        {
            try
            {
                btn_show_password.Visible = fg;
                btn_hide_password.Visible = !fg;

                ctrl_client.set_password_visible(fg);
                foreach (ClientCtrl ctr in flow_clients.Controls)
                {
                    ctr.set_password_visible(fg);
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Set password visible failed: " + ex.ToString());
            }
        }

        private void change_button_height()
        {
            if (client_expand)
            {
                btn_expand.Text = "-";
                nav_orders.Height = nav_dashboard.Height;
                nav_tradingdesk.Height = nav_dashboard.Height;
                nav_pamm.Height = nav_dashboard.Height;
                nav_history.Height = nav_dashboard.Height;
                nav_statement.Height = nav_dashboard.Height;
            }
            else
            {
                btn_expand.Text = "+";
                nav_orders.Height = 0;
                nav_tradingdesk.Height = 0;
                nav_pamm.Height = 0;
                nav_history.Height = 0;
                nav_statement.Height = 0;
            }

            nav_details.Height = 0;
            nav_statistics.Height = 0;
            nav_administrator.Height = 0;
        }

        private void tb_client_search_TextChanged(object sender, EventArgs e)
        {
            string keyStr = ((TextBox)sender).Text;
            search_client_list(keyStr);
        }

        private void quote_order_changed(bool order_updated)
        {
            if (!order_updated)
            {
                is_quote_updated = true;
                return;
            }
            update_panels(order_updated);
        }

        private void check_license()
        {
            if (Settings.broker_mode) return;

            if (!Settings.broker_mode)
            {
                if (g_API.license_state == 1)
                {
                    if (g_client.server_time > dt_picker.Value)
                    {
                        g_API.license_state = 0;
                    }
                }
                if (g_API.license_state == 0)
                {
                    g_API.license_state = -1;
                    //MessageBox.Show("License was expired!");
                }
                if (g_API.license_state <= 0)
                {
                    Thread.Sleep(3);
                    Close();
                }
            }
        }
        
        private void update_panels(bool order_updated)
        {
            g_client.check_unmatched_opened_order();

            check_license();
            check_money_shift();
            check_margin_alert_call();
            check_price_alert();

            if (phone_notify_on) g_client.check_free_pip_notification();
            if (nav_dashboard.selected == true) show_dashboard(order_updated);
            if (nav_pamm.selected == true) show_pamm(order_updated);
            if (nav_details.selected == true) show_details(order_updated);
            if (nav_orders.selected == true) show_orders(order_updated);
            if (nav_administrator.selected == true) show_administrator(order_updated);
            if (nav_statistics.selected == true) show_statistics(order_updated);
            if (nav_statement.selected == true) show_statement();
            if (nav_tradingdesk.selected == true)
            {
                if(IsControlAtFront(panel_tradingdesk)) show_tradingdesk(order_updated);
                else show_tradingdesk_new(order_updated);
            }
        }

        private void check_price_alert()
        {
            for(int i = 0; i < Settings.symbol_num; i++)
            {
                double cur_price = g_API.R3_bid[i];

                if(g_price_alert.check_alert_price(i, cur_price))
                {
                    string digit_str = g_API.get_digit_string(i);
                    string symbol_str = Settings.SymbolsToSubscribe[i];

                    string alert_str = "Price Alert in " + symbol_str + " at " + cur_price.ToString(digit_str);

                    g_client.AlertSoundAndMessage(alert_str);
                    if (phone_notify_on) g_client.send_sms_price_alert(alert_str);
                }
            }
        }

        private void check_margin_alert_call()
        {
            try
            {
                g_client.RefreshMarginCallDict();

                for (int i = 0; i < g_client.tot_client_num; i++)
                {
                    if(!margin_call_on)  
                    {
                        g_client.marginAlertFlagList[i] = false;
                        g_client.marginCallFlagList[i] = false;
                        continue;
                    }
                    if (!g_client.check_connection_both_accounts(i))
                    {
                        g_client.marginAlertFlagList[i] = false;
                        g_client.marginCallFlagList[i] = false;
                        continue;
                    }

                    List<int> close_order_ticket1 = new List<int>();
                    List<int> close_order_ticket2 = new List<int>();
                    bool meet_margin_call = g_client.check_margin_call_for_unmatched_orders(i, out close_order_ticket1, out close_order_ticket2);

                    if (!meet_margin_call)
                        continue;

                    // filter recently tried orders
                    int user_id1 = g_client.userIdList[2 * i];
                    int user_id2 = g_client.userIdList[2 * i + 1];

                    var close_order_ticket1_filtered = new List<int>();
                    var close_order_ticket2_filtered = new List<int>();

                    foreach(var ticket in close_order_ticket1)
                    {
                        var margin_call_info = new MarginCallInfo(user_id1, ticket);

                        if (g_client.ExistInMarginCallDict(margin_call_info))
                            continue;

                        g_client.AddMarginCallDict(margin_call_info);
                        close_order_ticket1_filtered.Add(ticket);
                    }

                    foreach (var ticket in close_order_ticket2)
                    {
                        var margin_call_info = new MarginCallInfo(user_id2, ticket);

                        if (g_client.ExistInMarginCallDict(margin_call_info))
                            continue;

                        g_client.AddMarginCallDict(margin_call_info);
                        close_order_ticket2_filtered.Add(ticket);
                    }

                    if (close_order_ticket1_filtered.Count + close_order_ticket2_filtered.Count == 0)
                        continue;

                    Thread thread = new Thread(() =>
                    {
                        g_API.close_unmatched_orders_for_margin_call(i, close_order_ticket1_filtered, close_order_ticket2_filtered);
                    });
                    thread.Start();

                    string alert_str = "Margin Call at " + g_client.nameList[i];
                    Settings.Log.Error(alert_str);
                    g_client.AlertSoundAndMessage(alert_str);
                    if (phone_notify_on) g_client.send_sms_price_alert(alert_str);
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("check margin call failed: " + ex.ToString());
            }
        }

        private void check_money_shift()
        {
            try
            {
                if (!Settings.broker_mode && !Settings.vps_server)
                    return;

                TimeSpan ts;
                DateTime last_money_shift_time = g_client.last_money_shift_time;

                int money_shift_count = 0;

                for (int i = 0; i < g_client.tot_client_num; i++)
                {
                    bool continueFlag = false;

                    if (!g_client.check_connection_both_accounts(i, false)) continueFlag = true;
                    if (!g_client.check_money_shift_flag(i)) continueFlag = true;
                    if (g_client.check_is_pending(i) > 0) continueFlag = true;

                    if (!g_client.check_hedge(i, 0) || !g_client.check_hedge(i, 1))
                        continue;

                    if (continueFlag || !money_shift_on)
                    {
                        g_client.init_pending_time(i);
                        continue;
                    }

                    double free_pip_diff = g_client.get_free_pip_diff(i);
                    int first_second = 1;
                    if (free_pip_diff < 0)
                    {
                        free_pip_diff = -free_pip_diff;
                        first_second = 2;
                    }

                    int money_shift_pip_limit = g_client.get_moneyshift_limit(i);
                    int money_shift_current = (int)(Math.Abs(g_client.get_current_money_shift(i)));
                    int current_balance = g_client.get_current_balance(i, first_second);

                    if (free_pip_diff >= money_shift_pip_limit && money_shift_current > 0)
                    {
                        if(current_balance == 0)
                        {
                            //MessageBox.Show(g_client.nameList[i] + " doesn't have enough balance to transfer money!");
                            update_warning_label(g_client.nameList[i] + ": No balance to transfer money!");
                            continue;
                        }
                        money_shift_current = Math.Min(money_shift_current, current_balance);

                        money_shift_current = Math.Min(money_shift_current, Settings.max_money_transfer);

                        ts = DateTime.Now - g_client.lastPendingTime[i];
                        if (g_client.check_initial_pending_time(i) || ts.Seconds < Settings.money_shift_wait_time)
                        {
                            if (g_client.check_initial_pending_time(i))
                                g_client.lastPendingTime[i] = DateTime.Now;
                            continue;
                        }

                        //check condition before money shift
                        ts = DateTime.Now - last_money_shift_time;
                        if (ts.Seconds < Settings.money_shift_login_time_period) continue;
                        if (money_shift_count >= Settings.money_shift_once_num) continue;

                        MoneyShiftParam param = new MoneyShiftParam();
                        if (!g_client.get_money_shift_param(param, i, money_shift_current, first_second)) continue;

                        money_shift_count++;

                        g_client.set_is_pending(i, first_second);
                        g_client.leave_log_for_money_shfit(i, first_second, money_shift_current);
                        g_client.init_pending_time(i);
                        g_client.last_money_shift_time = DateTime.Now;

                        while(is_moneyshift_processing)
                        {
                            Thread.Sleep(1);
                        }
                        g_API.save_moneyshift_info(i, first_second, money_shift_current);

                        new Thread(async () =>
                        {
                            var res = await FXFellowAuto.auto_settle(param);

                            if (((Result)res).success == false && ((Result)res).msg.Contains("Pending") == false) //if failed and not pending, 
                            {
                                g_client.set_is_pending(param.client_id, 0);
                            }

                            this.InvokeOnUiThreadIfRequired(() =>
                            {
                                quote_order_changed(false);
                            });
                        }).Start();
                    }
                    else
                    {
                        g_client.init_pending_time(i);
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Money shift failed: " + ex.ToString());
            }
        }

        private void search_client_list(string keyStr)
        {
            if (keyStr == "") return;

            try
            {
                //find client id from db
                int clientId = g_sql.search_name_userId(keyStr);

                //find real id from client list
                int resId = g_client.find_id_from_clientID(clientId);
                if (resId < 0) return;

                ClientInfo client_info = new ClientInfo();

                g_client.read_one_client(client_info, resId);
                ctrl_client.set_contents(client_info, show_client_flag);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("search client list failed: " + ex.ToString());
            }
        }

        private void init_ui()
        {
            try
            {
                change_button_height();
                set_password_visible(false);

                chart_view.MouseWheel += onmousewheel;
                chart_view_3.MouseWheel += onmousewheel;
                chart_view_8.MouseWheel += onmousewheel;

                ctrl_account_pamm.m_dbl_click_handle += account_dbl_click_one;
                ctrl_account_tradingdesk.m_dbl_click_handle += account_dbl_click_one;
                ctrl_account_orders.m_dbl_click_handle += account_dbl_click_one;

                client_expand = false;
                panel_tf_button.Visible = false;
                panel_balance_alert.Visible = false;

                tb_login_page.Text = "1 / 1";
                tb_orders_page.Text = "1 / 1";
                tb_pamm_page.Text = "1 / 1";
                tb_dashboard_page.Text = "1 / 1";

                dt_picker.Format = DateTimePickerFormat.Custom;
                dt_picker.CustomFormat = "dd/MM/yyyy";

                swap_dt_picker.Format = DateTimePickerFormat.Custom;
                swap_dt_picker.CustomFormat = "dd/MM/yyyy";

                if (!Settings.broker_mode)
                {
                    dt_picker.Enabled = false;
                    tb_license.Enabled = false;
                    //btn_show_password.Visible = false;
                    //btn_hide_password.Visible = false;
                    ctrl_client.disable_accounts();
                }

                ctrl_client.set_server_info(list_server_info);

                init_license();
                init_swap_start_date();
                init_login_ui();
                init_dashboard_ui();
                init_pamm_ui();
                init_orders_ui();

                btn_restore.DoubleBuffered(true);
                btn_maximize.DoubleBuffered(true);

                if (Settings.broker_mode)
                    lab_broker_client.Text = "BROKER";
                else
                    if (Settings.vps_server)
                    lab_broker_client.Text = "CLIENT VPS";
                else
                {
                    lab_broker_client.Text = "CLIENT PC";
                    lab_setting_moneyshfit.Visible = false;
                    btn_setting_moneyshfit.Visible = false;
                }
                lab_version_release.Text = "Version " + Settings.version_num + " Release " + Settings.release_num;
                lab_top_warning.Text = "";

                if (!Settings.broker_mode)
                {
                    close_trades_enabled = true;
                    cb_close_trades.Checked = true;

                    cb_close_trades.Enabled = false;
                }
                else
                {
                    close_trades_enabled = false;
                    cb_close_trades.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("init ui failed: " + ex.ToString());
            }
        }

        private void save_swap_start_date()
        {
            string _date = swap_dt_picker.Text;

            g_sql.save_swap_start_date(_date);
        }

        private void init_swap_start_date()
        {
            string _date = g_sql.read_swap_start_date();

            DateTime dt;
            if (!DateTime.TryParseExact(_date, Settings.datetime_formats, System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out dt)) dt = new DateTime(2020, 2, 1);

            swap_dt_picker.Value = dt;
        }

        private void save_license()
        {
            if (!Settings.broker_mode) return;

            SimpleAES _aes = new SimpleAES();

            string _number = tb_license.Text;
            string _date = dt_picker.Text;

            LicenseInfo info = new LicenseInfo();
            info.number = _number;
            info.date = _aes.Encrypt(_date + _number);

            g_sql.save_license(info);
        }

        void init_license()
        {
            LicenseInfo info = g_sql.read_license();
            tb_license.Text = info.number;

            string _date;
            SimpleAES _aes = new SimpleAES();
            try
            {
                _date = _aes.Decrypt(info.date);
                if (_date.Contains(info.number))
                {
                    info.date = _date.Substring(0, 10);
                }
                else
                {
                    info.Init();
                    if(!Settings.broker_mode)
                        g_API.license_state = 0;
                }
            }
            catch(Exception)
            {
                info.Init();
                if (!Settings.broker_mode)
                    g_API.license_state = 0;
            }

            DateTime dt;
            if (!DateTime.TryParseExact(info.date, Settings.datetime_formats, System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out dt)) dt = DateTime.Now;
            dt_picker.Value = dt;
        }

        private void init_login_ui()
        {
            flow_clients.SuspendLayout();
            flow_clients.Controls.Clear();
            for (int i = 0; i < Settings.max_control_num; i++)
            {
                ClientCtrl ctr = new ClientCtrl()
                {
                    Width = flow_clients.Width - Settings.scrollGap,
                    m_is_confirmed = true,
                };
                ctr.set_password_visible(btn_show_password.Visible == true);
                ctr.set_server_info(list_server_info);
                //ctr.lock_content();

                ctr.m_dbl_click_handle += client_dbl_click;
                ctr.m_delete_click_handle += client_delete_click;
                
                flow_clients.Controls.Add(ctr);
            }
            flow_clients.ResumeLayout();
        }

        private void init_dashboard_ui()
        {
            flow_dashboard.SuspendLayout();
            flow_dashboard.Controls.Clear();
            for (int i = 0; i < Settings.max_control_num; i++)
            {
                AccountsCtrl ctr = new AccountsCtrl()
                {
                    Width = flow_dashboard.Width - Settings.scrollGap,
                };
                ctr.m_dbl_click_handle += account_dbl_click;
                update_account_ctrl_labels(ctr);
                update_account_ctrl_colors(ctr);
                flow_dashboard.Controls.Add(ctr);
            }
            flow_dashboard.ResumeLayout();
        }

        private void init_pamm_ui()
        {
            flow_pamm.SuspendLayout();
            flow_pamm.Controls.Clear();
            for (int i = 0; i < Settings.max_control_num; i++)
            {
                AccountPAMM ctr = new AccountPAMM()
                {
                    Width = flow_pamm.Width - Settings.scrollGap,
                };

                ctr.change_colors(lab_settings_account1.BackColor, lab_settings_account2.BackColor, lab_settings_pip.BackColor);
                ctr.m_dbl_click_handle += account_pamm_dbl_click;
                ctr.m_combo_change_handle += account_pamm_combo_change;
                flow_pamm.Controls.Add(ctr);
            }
            flow_pamm.ResumeLayout();
        }

        private void init_orders_ui()
        {
            ctrl_header.m_header_click_handle += orders_header_click;

            flow_orders.SuspendLayout();
            flow_orders.Controls.Clear();
            for (int i = 0; i < Settings.max_control_num; i++)
            {
                OrderCtrl ctr = new OrderCtrl()
                {
                    Width = flow_orders.Width - Settings.scrollGap,
                    m_sep_col = Settings.sep_colors[i % 3]
                };
                ctr.m_close_click_handle += orders_close_clicked;
                ctr.m_SLTP_changed_handle += orders_SLTP_changed;
                flow_orders.Controls.Add(ctr);
            }
            flow_orders.ResumeLayout();
        }

        private void orders_SLTP_changed(object sender, EventArgs e)
        {
            int control_id = flow_orders.Controls.IndexOf(sender as Control);
            int overall_id = g_page_orders.get_overall_id(control_id);

            nav_orders.Focus();

            if(overall_id >= 0)
            {
                OrderSLTPArgs arg = (OrderSLTPArgs)e;
                g_client.update_orders_SLTP(overall_id, arg);
            }
        }

        private void orders_header_click(object sender, EventArgs e)
        {
            Headers header = ((CustomArgs)e).idx;

            if(g_client.orders_sort_item == header)
            {
                g_client.orders_sort_increased = !g_client.orders_sort_increased;
            }
            else
            {
                g_client.orders_sort_item = header;
                g_client.orders_sort_increased = true;
            }

            g_client.sort_orders_list();
            show_orders();
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {
            client_expand = !client_expand;
            change_button_height();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_client_info(int id)
        {
            try
            {
                ClientInfo info = new ClientInfo();
                if (id < 0)
                {
                    for (int i = 0; i < g_client.tot_client_num; i++)
                    {
                        g_client.read_one_client(info, i);
                        g_sql.update_db(info);
                    }
                }
                else if (id < g_client.tot_client_num)
                {
                    g_client.read_one_client(info, id);
                    g_sql.update_db(info);
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("save client info failed: " + ex.ToString());
            }
        }

        private void nav_login_Click(object sender, EventArgs e)
        {
            init_nav_buttons();

            nav_login.selected = true;
            panel_login.BringToFront();
            lab_head_title.Text = "LOGIN";

            show_clients_list();
        }

        private void btn_show_password_Click(object sender, EventArgs e)
        {
            set_password_visible(false);
        }

        private void btn_hide_password_Click(object sender, EventArgs e)
        {
            set_password_visible(true);
        }

        private void flow_ctrl_Resize(object sender, EventArgs e)
        {
            ctrl_header_master.SuspendLayout();
            ctrl_account_pamm.SuspendLayout();

            flow_clients.SuspendLayout();
            flow_orders.SuspendLayout();
            flow_dashboard.SuspendLayout();
            flow_pamm.SuspendLayout();

            ctrl_header_master.Width = flow_pamm.Width;
            ctrl_account_pamm.Width = flow_pamm.Width;

            foreach (Control ctrl in flow_clients.Controls)
            {
                ctrl.Width = flow_clients.Width - Settings.scrollGap;
            }

            foreach (Control ctrl in flow_dashboard.Controls)
            {
                ctrl.Width = flow_dashboard.Width - Settings.scrollGap;
            }

            foreach (Control ctrl in flow_orders.Controls)
            {
                ctrl.Width = flow_orders.Width - Settings.scrollGap;
            }

            foreach (Control ctrl in flow_pamm.Controls)
            {
                ctrl.Width = flow_pamm.Width - Settings.scrollGap;
            }

            flow_clients.HorizontalScroll.Maximum = 0;
            flow_clients.AutoScroll = false;
            flow_clients.AutoScroll = true;

            flow_dashboard.HorizontalScroll.Maximum = 0;
            flow_dashboard.AutoScroll = false;
            flow_dashboard.AutoScroll = true;

            flow_orders.HorizontalScroll.Maximum = 0;
            flow_orders.AutoScroll = false;
            flow_orders.AutoScroll = true;

            flow_pamm.HorizontalScroll.Maximum = 0;
            flow_pamm.AutoScroll = false;
            flow_pamm.AutoScroll = true;

            ctrl_header_master.ResumeLayout();
            ctrl_account_pamm.ResumeLayout();
            flow_clients.ResumeLayout();
            flow_orders.ResumeLayout();
            flow_dashboard.ResumeLayout();
            flow_pamm.ResumeLayout();
            panel_history.Invalidate();
            panel_td_pendingorder.Invalidate();
        }

        private void nav_dashboard_Click(object sender, EventArgs e)
        {
            if (nav_dashboard.selected == true) return;
            init_nav_buttons();
            nav_dashboard.selected = true;
            panel_dashboard.BringToFront();
            lab_head_title.Text = "DASHBOARD";
            lab_top_warning.Visible = true;

            panel_balance_alert.BringToFront();
            panel_balance_alert.Visible = false;

            show_dashboard();
        }

        private void show_balance_alert()
        {
            try
            {
                if (g_client.balance_alert_client_id < 0)
                {
                    panel_balance_alert.Visible = false;
                    return;
                }
                panel_balance_alert.Visible = true;
                btn_balance_alert_name.Text = g_client.nameList[g_client.balance_alert_client_id];
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Show balance alert failed: " + ex.ToString());
            }
        }

        private void btn_balance_alert_name_Click(object sender, EventArgs e)
        {
            if (g_client.balance_alert_client_id < 0) return;

            g_client.current_client_id = g_client.balance_alert_client_id;
            nav_details_Click(this, EventArgs.Empty);
        }

        private void show_dashboard(bool order_updated = false)
        {
            try
            {
                g_client.check_balance_alert();
                show_balance_alert();

                bool settingFlag = check_dashboard_setting();
                g_page_dashboard.tot_num = g_client.tot_client_num;
                update_dashboard_page_textbox();

                flow_dashboard.SuspendLayout();
                foreach (AccountsCtrl ctr in flow_dashboard.Controls)
                {
                    int control_id = flow_dashboard.Controls.IndexOf(ctr as Control);
                    int overall_id = g_page_dashboard.get_overall_id(control_id);
                    if (control_id >= g_page_dashboard.display_num || overall_id < 0)
                    {
                        ctr.Hide();
                        continue;
                    }
                    ctr.Show();
                    if (settingFlag)
                    {
                        update_account_ctrl_labels(ctr);
                    }
                    update_account_ctrl_colors(ctr);

                    //input live data
                    update_account_ctrl_contents(overall_id, ctr, order_updated);
                }
                flow_dashboard.ResumeLayout();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Show dashboard failed: " + ex.ToString());
            }
        }

        private void cb_settings_OnChange(object sender, EventArgs e)
        {
            show_client_flag = cb_settings_show_client.Checked;
            update_header_account_labels();
        }

        private void update_header_account_labels()
        {
            update_header_ctrl_labels(ctrl_header_administrator);
            update_header_ctrl_labels(ctrl_header_dashboard);
            update_header_ctrl_labels(ctrl_header_details);
            update_header_ctrl_labels(ctrl_header_tradingdesk);
            update_header_ctrl_labels(ctrl_header_orders);

            update_account_ctrl_labels(ctrl_account_administrator);
            update_account_ctrl_labels(ctrl_account_details);
            update_account_ctrl_labels(ctrl_account_orders);
            update_account_ctrl_labels(ctrl_account_tradingdesk);
        }

        private void update_header_account_colors()
        {
            update_account_ctrl_colors(ctrl_account_administrator);
            update_account_ctrl_colors(ctrl_account_details);
            update_account_ctrl_colors(ctrl_account_orders);
            update_account_ctrl_colors(ctrl_account_tradingdesk);
        }

        private void update_header_ctrl_labels(HeaderCtrl header_ctrl)
        {
            header_ctrl.restoreHeaders();
            if (cb_settings_curr.Checked == false) header_ctrl.removeHeaders(2);
            if (cb_settings_shiftat.Checked == false) header_ctrl.removeHeaders(4);
            if (cb_settings_transfer.Checked == false) header_ctrl.removeHeaders(9);
            if (cb_settings_equity.Checked == false) header_ctrl.removeHeaders(10);
            if (cb_settings_balance.Checked == false) header_ctrl.removeHeaders(11);
            if (cb_settings_pnl.Checked == false) header_ctrl.removeHeaders(12);
        }

        private void update_account_ctrl_labels(AccountsCtrl ctr)
        {
            ctr.restore_labels();
            if (cb_settings_curr.Checked == false) ctr.remove_labels(2);
            if (cb_settings_shiftat.Checked == false) ctr.remove_labels(4);
            if (cb_settings_transfer.Checked == false) ctr.remove_labels(9);
            if (cb_settings_equity.Checked == false) ctr.remove_labels(10);
            if (cb_settings_balance.Checked == false) ctr.remove_labels(11);
            if (cb_settings_pnl.Checked == false) ctr.remove_labels(12);
        }

        private void update_account_ctrl_colors(AccountsCtrl ctr)
        {
            ctr.change_colors(lab_settings_account1.BackColor, lab_settings_account2.BackColor, lab_settings_pip.BackColor);
        }

        private void update_account_ctrl_contents(int clientId, AccountsCtrl ctr, bool orderUpdated = false)
        {
            try
            {
                ClientDetails client_details = new ClientDetails();
                client_details.Init();
                client_details.money_shift_on = money_shift_on;

                if(!g_client.no_client())
                {
                    g_client.get_client_details_dashboard(client_details, clientId, orderUpdated);
                    ctr.change_connections(g_client.connectionList[2 * clientId], g_client.connectionList[2 * clientId + 1]);
                }

                ctr.set_contents(client_details, show_client_flag);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Read client data error: " + ex.ToString());
            }
        }

        private bool check_dashboard_setting()
        {
            int num_setting = get_setting_into_number();
            if(num_setting != dashboard_setting)
            {
                dashboard_setting = num_setting;
                return true;
            }
            return false;
        }

        private int get_setting_into_number()
        {
            int num_setting = 0;

            if (cb_settings_curr.Checked == true) num_setting = num_setting * 2 + 1; else num_setting *= 2;
            if (cb_settings_transfer.Checked == true) num_setting = num_setting * 2 + 1; else num_setting *= 2;
            if (cb_settings_balance.Checked == true) num_setting = num_setting * 2 + 1; else num_setting *= 2;
            if (cb_settings_pnl.Checked == true) num_setting = num_setting * 2 + 1; else num_setting *= 2;
            if (cb_settings_equity.Checked == true) num_setting = num_setting * 2 + 1; else num_setting *= 2;
            if (cb_settings_shiftat.Checked == true) num_setting = num_setting * 2 + 1; else num_setting *= 2;

            return num_setting;
        }

        private void account_dbl_click_one(object sender, EventArgs e)
        {
            int id = g_client.current_client_id;
            change_current_client_id(id);
        }

        private void account_dbl_click(object sender, EventArgs e)
        {
            int control_id = flow_dashboard.Controls.IndexOf(sender as Control);
            int overall_id = g_page_dashboard.get_overall_id(control_id);
            if(overall_id >= 0)
                change_current_client_id(overall_id);
        }

        private void account_pamm_dbl_click(object sender, EventArgs e)
        {
            int control_id = flow_pamm.Controls.IndexOf(sender as Control);
            int overall_id = g_page_pamm.get_overall_id(control_id);
            if (overall_id >= 0)
                change_master_client_id(overall_id);
        }

        private void account_pamm_combo_change(object sender, EventArgs e)
        {
            int control_id = flow_pamm.Controls.IndexOf(sender as Control);
            int overall_id = g_page_pamm.get_overall_id(control_id);
            if (overall_id >= 0)
            {
                g_client.set_pamm_setting(((AccountPAMM)sender).check_combo(), overall_id);
                save_client_info(overall_id);
            }
        }

        private void nav_clients_Click(object sender, EventArgs e)
        {
            if (nav_clients.selected == true) return;
            init_nav_buttons();
            nav_clients.selected = true;
            panel_clients.BringToFront();
            lab_head_title.Text = "CLIENTS SEARCH";

            show_active_client_num();
            tb_search_account.Text = "";
            tb_search_money_shift.Text = "";
            tb_search_name.Text = "";
            tb_search_pamm.Text = "";
        }

        private void tb_search_account_TextChanged(object sender, EventArgs e)
        {
            string keyStr = ((TextBox)sender).Text;

            int clientId = g_sql.search_userId(keyStr);
            int curId = g_client.find_id_from_clientID(clientId);
            change_current_client_id(curId);
        }

        private void tb_search_name_TextChanged(object sender, EventArgs e)
        {
            string keyStr = ((TextBox)sender).Text;

            int clientId = g_sql.search_name(keyStr);
            int curId = g_client.find_id_from_clientID(clientId);
            change_current_client_id(curId);
        }

        private void tb_search_pamm_TextChanged(object sender, EventArgs e)
        {
            string keyStr = ((TextBox)sender).Text;

            int clientId = g_sql.search_pamm(keyStr);
            int curId = g_client.find_id_from_clientID(clientId);
            change_current_client_id(curId);
        }

        private void tb_search_money_shift_TextChanged(object sender, EventArgs e)
        {
            string keyStr = ((TextBox)sender).Text;

            int clientId = g_sql.search_moneyshift(keyStr);
            int curId = g_client.find_id_from_clientID(clientId);
            change_current_client_id(curId);
        }

        private void change_current_client_id(int curId)
        {
            if (curId < 0) return;
            //DialogResult result = MessageBox.Show("Change current client into \"" + g_client.nameList[curId] + "(" +
            //    g_client.userIdList[2 * curId].ToString() + "," + g_client.userIdList[2 * curId + 1].ToString() + ")\"", "Confirmation", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            {
                g_client.current_client_id = curId;
                Settings.Log.Info("Change a client into " + g_client.nameList[curId]);

                nav_details_Click(this, EventArgs.Empty);
            }
        }

        private void change_master_client_id(int curId)
        {
            if (curId < 0) return;
            //DialogResult result = MessageBox.Show("Change master client into \"" + g_client.nameList[curId] + "(" +
            //    g_client.userIdList[2 * curId].ToString() + "," + g_client.userIdList[2 * curId + 1].ToString() + ")\"", "Confirmation", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            {
                g_client.master_client_id = curId;
                Settings.Log.Info("Change master client into " + g_client.nameList[curId]);
                show_pamm();
            }
        }

        private void show_active_client_num()
        {
            int res1 = g_client.get_live_clients_num();
            int res2 = g_client.get_pamm_client_num();
            int res3 = g_client.get_moneyshift_client_num();

            lab_active_clients.Text = res1.ToString();
            lab_active_pamm.Text = res2.ToString();
            lab_active_money_shift.Text = res3.ToString();
        }

        private void nav_statement_Click(object sender, EventArgs e)
        {
            if (nav_statement.selected) return;

            init_nav_buttons();
            nav_statement.selected = true;
            panel_statement.BringToFront();
            lab_head_title.Text = "STATEMENT";

            show_statement();
        }

        private void show_statement()
        {
            if (g_client.tot_client_num == 0 || g_client.current_client_id < 0)
                return;

            StatementInfo info = new StatementInfo();
            Task.Run(() =>
            {
                info = g_client.get_statement_info();
            }).Wait();

            statement_html_ctrl.EditHTML(info);
            statement_html_ctrl.Display();
        }

        private void nav_details_Click(object sender, EventArgs e)
        {
            if (nav_details.selected == true) return;
            
            init_nav_buttons();
            nav_details.selected = true;
            panel_details.BringToFront();
            lab_head_title.Text = "DETAILS";

            //update from db
            tb_margin_alert.Text = g_client.get_margin_alert_amount().ToString();
            tb_margin_call.Text = g_client.get_margin_call_amount().ToString();
            tb_moneyshift.Text = g_client.get_moneyshift_limit().ToString();
            cb_moneyshift_onoff.Checked = g_client.get_moneyshift_setting();
            cb_pamm_onoff.Checked = g_client.get_pamm_setting();
            tb_notification.Text = g_client.get_notification_amount().ToString();
            tb_phone_number.Text = g_client.get_phone_number();

            show_details(true);
        }

        private void show_details(bool order_updated = false)
        {
            try
            {
                update_account_ctrl_colors(ctrl_account_details);
                update_account_ctrl_contents(g_client.current_client_id, ctrl_account_details);

                change_swapfree_hedge_state();
                //update labels
                update_details_contents(order_updated);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Show details failed: " + ex.ToString());
            }
        }

        private void update_details_contents(bool order_updated)
        {
            if (g_client.current_client_id < 0 || g_client.current_client_id >= g_client.tot_client_num) return;

            //update real time
            DetailsInfo info = new DetailsInfo();
            info.Init();

            try
            {
                g_client.get_details_info(info, order_updated, swap_dt_picker.Value);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Update details contents failed: " + ex.ToString());
            }

            //update labels           

            lab_details_swap_tot.Text = info.tot_swap.ToString("#,##0.00");

            //int _month = DateTime.Now.Month;
            //lab_details_month.Text = Settings.Months[_month];

            //lab_details_open_lots1.Text = info.opened_lots1.ToString("#,##0.00");
            //lab_details_open_lots2.Text = info.opened_lots2.ToString("#,##0.00");

            //lab_details_close_lots1.Text = info.closed_lots1.ToString("#,##0.00");
            //lab_details_close_lots2.Text = info.closed_lots2.ToString("#,##0.00");

            //lab_details_diff1.Text = (info.opened_lots1 - info.closed_lots1).ToString("#,##0.00");
            //lab_details_diff2.Text = (info.opened_lots2 - info.closed_lots2).ToString("#,##0.00");

            //lab_details_reopen.Text = (info.reopen_lots1 + info.reopen_lots2).ToString("#,##0.00");
            //lab_details_breakeven.Text = info.breakeven.ToString("#,##0");
        }

        private void btn_margin_alert_save_Click(object sender, EventArgs e)
        {
            g_client.set_margin_alert_amount(tb_margin_alert.Text);
            tb_margin_alert.Text = g_client.get_margin_alert_amount().ToString();
            save_client_info(g_client.current_client_id);
        }

        private void btn_margin_call_save_Click(object sender, EventArgs e)
        {
            g_client.set_margin_call_amount(tb_margin_call.Text);
            tb_margin_call.Text = g_client.get_margin_call_amount().ToString();
            save_client_info(g_client.current_client_id);
        }

        private void btn_moneyshift_save_Click(object sender, EventArgs e)
        {
            g_client.set_moneyshift_amount(tb_moneyshift.Text);
            tb_moneyshift.Text = g_client.get_moneyshift_limit().ToString();
            save_client_info(g_client.current_client_id);
        }

        private void cb_pamm_onoff_OnChange(object sender, EventArgs e)
        {
            g_client.set_pamm_setting(cb_pamm_onoff.Checked);
            save_client_info(g_client.current_client_id);
        }

        private void cb_money_shift_onoff_OnChange(object sender, EventArgs e)
        {
            g_client.init_pending_time(g_client.current_client_id);

            g_client.set_moneyshift_setting(cb_moneyshift_onoff.Checked);
            save_client_info(g_client.current_client_id);

            update_panels(false);
        }

        private void nav_orders_Click(object sender, EventArgs e)
        {
            if (nav_orders.selected == true) return;
            init_nav_buttons();
            nav_orders.selected = true;
            panel_orders.BringToFront();
            lab_head_title.Text = "ORDERS";

            panel_tf_button.BringToFront();
            set_visible_panel_tf_button(false);

            show_orders(true);
        }

        private void show_margin_call_notification(object param)
        {
            int client_id = (int)param;
            if (!g_client.check_connection_both_accounts(client_id)) return;

            close_all_orders(client_id);
        }

        private void show_orders(bool order_updated = false)
        {
            try
            {
                update_spread_swap_breakeven();

                update_account_ctrl_colors(ctrl_account_orders);
                update_account_ctrl_contents(g_client.current_client_id, ctrl_account_orders);

                if(order_updated) //rearrange order list
                {
                    g_page_orders.tot_num = g_client.get_matched_order_list_display();
                }
                
                update_orders_page_textbox();

                flow_orders.SuspendLayout();
                foreach (OrderCtrl ctr in flow_orders.Controls)
                {
                    int control_id = flow_orders.Controls.IndexOf(ctr as Control);
                    int overall_id = g_page_orders.get_overall_id(control_id);
                    if(control_id >= g_page_orders.display_num || overall_id < 0)
                    {
                        ctr.Hide();
                        continue;
                    }
                    ctr.Show();

                    //update live data
                    update_order_ctrl_contents(overall_id, ctr);
                }
                flow_orders.ResumeLayout();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't show orders: " + ex.ToString());
            }
        }

        private void update_order_spread_realtime(OrderDetails order_details)
        {
            int symbol_id = g_client.get_symbol_id(order_details.symbol1);
            double _lots = 0;
            if (symbol_id >= 0)
            {
                int spread1 = (int)((g_API.R3_ask[symbol_id] - g_API.R3_bid[symbol_id]) / Settings.SymbolsPoint[symbol_id]);
                int spread2 = (int)((g_API.R8_ask[symbol_id] - g_API.R8_bid[symbol_id]) / Settings.SymbolsPoint[symbol_id]);

                if (double.TryParse(order_details.lot1, out _lots))
                {
                    order_details.spread1 = (_lots * spread1).ToString("#,##0.00");
                }
                if (double.TryParse(order_details.lot2, out _lots))
                {
                    order_details.spread2 = (_lots * spread2).ToString("#,##0.00");
                }
            }
        }

        private void update_order_ctrl_contents(int orderId, OrderCtrl ctr)
        {
            try
            {
                OrderDetails order_details = new OrderDetails();
                order_details.Init();
                g_client.get_order_details(order_details, g_client.current_client_id, orderId);

                //Modify spread in realtime
                update_order_spread_realtime(order_details);

                ctr.set_contents(order_details, show_client_flag);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't show orders: " + ex.ToString());
            }
        }

        private void remove_control_flow_orders(int cnt)
        {
            for(int i = 0; i < cnt; i++)
            {
                flow_orders.Controls.RemoveAt(0);
            }
        }

        private void orders_close_clicked(object sender, EventArgs e)
        {
            if(margin_call_on)
            {
                MessageBox.Show("Please turn off margin call first.");
                return;
            }

            int control_id = flow_orders.Controls.IndexOf(sender as Control);
            int overall_id = g_page_orders.get_overall_id(control_id);
            if (overall_id >= 0)
            {
                Settings.Log.Info("Orders: close order button was clicked.");

                int order_id1 = g_client.R8_orderList[overall_id];
                int order_id2 = g_client.R3_orderList[overall_id];

                g_API.close_hedge_orders(g_client.current_client_id, order_id1, order_id2);
            }
        }

        private void nav_tradingdesk_Click(object sender, EventArgs e)
        {
            if (IsControlAtFront(panel_tradingdesk)) return;

            init_nav_buttons();
            nav_tradingdesk.selected = true;

            panel_tradingdesk.BringToFront();
            lab_head_title.Text = "TRADING DESK";

            panel_tf_button.BringToFront();
            set_visible_panel_tf_button(true);

            if (g_API.current_tf == Timeframe.MN1) btn_h4.Textcolor = Color.Orange;

            btn_tradingdesk_new.Visible = true;

            show_tradingdesk(true);
        }

        private void set_visible_panel_tf_button(bool is_tradingdesk)
        {
            btn_plus.Visible = is_tradingdesk;
            btn_minus.Visible = is_tradingdesk;
            btn_m1.Visible = is_tradingdesk;
            btn_m5.Visible = is_tradingdesk;
            btn_m15.Visible = is_tradingdesk;
            btn_m30.Visible = is_tradingdesk;
            btn_h1.Visible = is_tradingdesk;
            btn_h4.Visible = is_tradingdesk;
            btn_d1.Visible = is_tradingdesk;
            btn_w1.Visible = is_tradingdesk;

            panel_tf_button.Visible = true;
        }

        private void btn_tradingdesk_new_Click(object sender, EventArgs e)
        {
            if (IsControlAtFront(panel_tradingdesk_new)) return;

            panel_tradingdesk_new.BringToFront();
            show_tradingdesk_new(true);
        }

        private bool IsControlAtFront(Control control)
        {
            return control.Parent.Controls.GetChildIndex(control) == 0;
        }

        private void show_tradingdesk(bool order_updated = false)
        {
            if (g_client.no_client()) return;

            try
            {
                update_account_ctrl_colors(ctrl_account_tradingdesk);
                update_account_ctrl_contents(g_client.current_client_id, ctrl_account_tradingdesk);
                update_tradingdesk_order_labels(order_updated);

                update_lots_percent();
                update_spread_swap_breakeven();
                g_API.check_quote_history(false);
                td_buysell_ctrl.update_bid_ask();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Show trading desk failed: " + ex.ToString());
            }
        }

        private void update_lots_percent()
        {
            LotsPercentInfo info = g_client.get_lots_percent();

            lab_td_symbol0.Text = Settings.SymbolsToSubscribe[0];
            lab_td_lot0.Text = info.lotsList[0].ToString("0.00");
            lab_td_percent0.Text = info.percentList[0].ToString("0");

            lab_td_symbol1.Text = Settings.SymbolsToSubscribe[1];
            lab_td_lot1.Text = info.lotsList[1].ToString("0.00");
            lab_td_percent1.Text = info.percentList[1].ToString("0");

            if(Settings.symbol_num == 8)
            {
                lab_td_symbol2.Text = Settings.SymbolsToSubscribe[2];
                lab_td_lot2.Text = info.lotsList[2].ToString("0.00");
                lab_td_percent2.Text = info.percentList[2].ToString("0");

                lab_td_symbol3.Text = Settings.SymbolsToSubscribe[3];
                lab_td_lot3.Text = info.lotsList[3].ToString("0.00");
                lab_td_percent3.Text = info.percentList[3].ToString("0");

                lab_td_symbol4.Text = Settings.SymbolsToSubscribe[4];
                lab_td_lot4.Text = info.lotsList[4].ToString("0.00");
                lab_td_percent4.Text = info.percentList[4].ToString("0");
            }
            else
            {
                lab_td_symbol2.Text = "";
                lab_td_lot2.Text = "";
                lab_td_percent2.Text = "";

                lab_td_symbol3.Text = "";
                lab_td_lot3.Text = "";
                lab_td_percent3.Text = "";

                lab_td_symbol4.Text = "";
                lab_td_lot4.Text = "";
                lab_td_percent4.Text = "";
            }
        }

        private void show_tradingdesk_new(bool order_updated = false)
        {
            if (g_client.no_client()) return;

            try
            {
                lab_pip_difference.Visible = true;
                lab_stockprice_diff.Visible = true;

                update_spread_swap_breakeven();
                update_price_difference();
                g_API.check_quote_history(true);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Show new trading desk failed: " + ex.ToString());
            }
        }

        private void update_price_difference()
        {
            try
            {
                //lab_stockprice_8.Text = g_API.get_ask_price(0);
                //lab_stockprice_3.Text = g_API.get_ask_price(1);
                lab_stockprice_diff.Text = g_API.get_price_difference_string();

                lab_tradingdesk_new_client.Text = g_client.nameList[g_client.current_client_id];
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Update price difference failed: " + ex.ToString());
            }
        }

        private void update_spread_swap_breakeven()
        {
            int symbol_id = g_API.tradingdesk_symbol_id;

            double _swap = g_client.get_symbol_swap(symbol_id);
            
            _swap *= Settings.SwapSpreadRatio[symbol_id];
            lab_swap.Text = "SWAP " + _swap.ToString("#,##0.00");

            double _spread = g_API.get_spread_sum(symbol_id);
            _spread *= Settings.SwapSpreadRatio[symbol_id];

            if(_spread < ((int)num_spread_alert.Value))
            {
                g_client.AlertSpread();
            }

            lab_spread.Text = "SPREAD " + _spread.ToString("#,##0");

            int breakeven = 0;
            if (_swap > 0) breakeven = (int)(_spread / _swap + 0.99);

            lab_breakeven.Text = "BREAK EVEN DAYS " + breakeven.ToString("#,##0");
        }

        private void clear_tradingdesk_order_labels()
        {
            lab_order1_account1.Text = "";
            lab_order1_symbol1.Text = "";
            lab_order1_lot1.Text = "";
            lab_order1_sell1.Text = "";
            lab_order1_buy1.Text = "";
            lab_order1_spread1.Text = "";
            lab_order1_pnl1.Text = "";

            lab_order2_account1.Text = "";
            lab_order2_symbol1.Text = "";
            lab_order2_lot1.Text = "";
            lab_order2_sell1.Text = "";
            lab_order2_buy1.Text = "";
            lab_order2_spread1.Text = "";
            lab_order2_pnl1.Text = "";

            lab_order1_account2.Text = "";
            lab_order1_symbol2.Text = "";
            lab_order1_lot2.Text = "";
            lab_order1_sell2.Text = "";
            lab_order1_buy2.Text = "";
            lab_order1_spread2.Text = "";
            lab_order1_pnl2.Text = "";

            lab_order2_account2.Text = "";
            lab_order2_symbol2.Text = "";
            lab_order2_lot2.Text = "";
            lab_order2_sell2.Text = "";
            lab_order2_buy2.Text = "";
            lab_order2_spread2.Text = "";
            lab_order2_pnl2.Text = "";
        }

        private void update_tradingdesk_order_labels(bool order_updated)
        {
            try
            {
                change_tradingdesk_label_color(1, Color.Black);
                change_tradingdesk_label_color(2, Color.Black);

                label1_order_id = -1;
                label2_order_id = -1;

                int totNum;
                if (order_updated)
                {
                    totNum = g_client.get_matched_order_list_display();
                    clear_tradingdesk_order_labels();
                }
                else
                    totNum = g_client.tot_order_num_display;

                if(totNum <= 0) return;

                int symbol_id;
                OrderDetails order_details = new OrderDetails();

                label1_order_id = g_client.get_recent_order_id(-1);
                if(label1_order_id >= 0)
                {
                    g_client.get_order_details(order_details, g_client.current_client_id, label1_order_id);

                    //Modify spread in realtime
                    update_order_spread_realtime(order_details);

                    lab_order1_account1.Text = order_details.userId1;
                    lab_order1_account2.Text = order_details.userId2;
                    string str_symbol1 = order_details.symbol1;
                    if (str_symbol1 == "XBRUSD") str_symbol1 = "UKOilCash";
                    if (str_symbol1 == "XTIUSD") str_symbol1 = "USOilCash";
                    lab_order1_symbol1.Text = str_symbol1;                    
                    lab_order1_symbol2.Text = order_details.symbol2;
                    lab_order1_lot1.Text = order_details.lot1;
                    lab_order1_lot2.Text = order_details.lot2;
                    lab_order1_spread1.Text = order_details.spread1;
                    lab_order1_spread2.Text = order_details.spread2;
                    lab_order1_pnl1.Text = order_details.pnl1;
                    lab_order1_pnl2.Text = order_details.pnl2;
                    symbol_id = g_client.get_symbol_id(order_details.symbol1);

                    if(symbol_id >= 0)
                    {
                        if (Settings.SymbolSellAccount[symbol_id] == 0)
                        {
                            lab_order1_sell1.Text = order_details.lot1;
                            lab_order1_buy1.Text = "";
                            lab_order1_sell2.Text = "";
                            lab_order1_buy2.Text = order_details.lot2;
                        }
                        else
                        {
                            lab_order1_sell1.Text = "";
                            lab_order1_buy1.Text = order_details.lot1; ;
                            lab_order1_sell2.Text = order_details.lot2;
                            lab_order1_buy2.Text = "";
                        }
                    }

                    if(!show_client_flag)
                    {
                        lab_order1_account1.Text = "180****";
                        lab_order1_account2.Text = "130****";
                    }

                    if (order_details.isPending)
                        change_tradingdesk_label_color(1, Color.DarkOrange);
                }

                if (totNum <= 1) return;

                label2_order_id = g_client.get_recent_order_id(label1_order_id);

                if(label2_order_id >= 0)
                {
                    g_client.get_order_details(order_details, g_client.current_client_id, label2_order_id);

                    //Modify spread in realtime
                    update_order_spread_realtime(order_details);

                    lab_order2_account1.Text = order_details.userId1;
                    lab_order2_account2.Text = order_details.userId2;
                    lab_order2_symbol1.Text = order_details.symbol1;
                    string str_symbol2 = order_details.symbol2;
                    if (str_symbol2 == "XBRUSD") str_symbol2 = "UKOilCash";
                    if (str_symbol2 == "XTIUSD") str_symbol2 = "USOilCash";
                    lab_order2_symbol2.Text = str_symbol2;
                    lab_order2_lot1.Text = order_details.lot1;
                    lab_order2_lot2.Text = order_details.lot2;
                    lab_order2_spread1.Text = order_details.spread1;
                    lab_order2_spread2.Text = order_details.spread2;
                    lab_order2_pnl1.Text = order_details.pnl1;
                    lab_order2_pnl2.Text = order_details.pnl2;
                    symbol_id = g_client.get_symbol_id(order_details.symbol1);
                    if(symbol_id >= 0)
                    {
                        if (Settings.SymbolSellAccount[symbol_id] == 0)
                        {
                            lab_order2_sell1.Text = order_details.lot1;
                            lab_order2_buy1.Text = "";
                            lab_order2_sell2.Text = "";
                            lab_order2_buy2.Text = order_details.lot2;
                        }
                        else
                        {
                            lab_order2_sell1.Text = "";
                            lab_order2_buy1.Text = order_details.lot1; ;
                            lab_order2_sell2.Text = order_details.lot2;
                            lab_order2_buy2.Text = "";
                        }
                    }
                }

                if (!show_client_flag)
                {
                    lab_order2_account1.Text = "180****";
                    lab_order2_account2.Text = "130****";
                }

                if (order_details.isPending)
                    change_tradingdesk_label_color(2, Color.DarkOrange);

            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't update order labels: " + ex.ToString());
            }
        }

        private void change_tradingdesk_label_color(int id, Color col)
        {
            if(id == 1)
            {
                lab_order1_account1.ForeColor = col;
                lab_order1_account2.ForeColor = col;
                lab_order1_symbol1.ForeColor = col;
                lab_order1_symbol2.ForeColor = col;
                lab_order1_lot1.ForeColor = col;
                lab_order1_lot2.ForeColor = col;
                lab_order1_spread1.ForeColor = col;
                lab_order1_spread2.ForeColor = col;
                lab_order1_pnl1.ForeColor = col;
                lab_order1_pnl2.ForeColor = col;
                lab_order1_sell1.ForeColor = col;
                lab_order1_buy1.ForeColor = col;
                lab_order1_sell2.ForeColor = col;
                lab_order1_buy2.ForeColor = col;
            }
            else
            {
                lab_order2_account1.ForeColor = col;
                lab_order2_account2.ForeColor = col;
                lab_order2_symbol1.ForeColor = col;
                lab_order2_symbol2.ForeColor = col;
                lab_order2_lot1.ForeColor = col;
                lab_order2_lot2.ForeColor = col;
                lab_order2_spread1.ForeColor = col;
                lab_order2_spread2.ForeColor = col;
                lab_order2_pnl1.ForeColor = col;
                lab_order2_pnl2.ForeColor = col;
                lab_order2_sell1.ForeColor = col;
                lab_order2_buy1.ForeColor = col;
                lab_order2_sell2.ForeColor = col;
                lab_order2_buy2.ForeColor = col;
            }
        }

        private void nav_pamm_Click(object sender, EventArgs e)
        {
            if (nav_pamm.selected == true) return;
            init_nav_buttons();
            nav_pamm.selected = true;
            panel_pamm.BringToFront();
            lab_head_title.Text = "PAMM (Percentage Allocation Master Module)";

            show_pamm();
        }

        private void show_pamm(bool order_updated = false)
        {
            try
            {
                double lots = get_lotsize(false);
                double pamm_percent = pamm_buysell_ctrl.slave_percent / 100.0;

                ctrl_account_pamm.change_colors(lab_settings_account1.BackColor, lab_settings_account2.BackColor, lab_settings_pip.BackColor);
                update_account_pamm_ctrl_contents(g_client.master_client_id, ctrl_account_pamm, true, lots, order_updated);

                g_page_pamm.tot_num = g_client.tot_client_num;
                update_pamm_page_textbox();

                flow_pamm.SuspendLayout();
                foreach (AccountPAMM ctr in flow_pamm.Controls)
                {
                    int control_id = flow_pamm.Controls.IndexOf(ctr as Control);
                    int overall_id = g_page_pamm.get_overall_id(control_id);
                    if (control_id >= g_page_pamm.display_num || overall_id < 0)
                    {
                        ctr.Hide();
                        continue;
                    }
                    ctr.Show();

                    ctr.change_colors(lab_settings_account1.BackColor, lab_settings_account2.BackColor, lab_settings_pip.BackColor);

                    double new_lots;
                    if (overall_id != g_client.master_client_id) new_lots = lots * pamm_percent;
                    else new_lots = lots;

                    //update live data
                    update_account_pamm_ctrl_contents(overall_id, ctr, false, new_lots, order_updated);

                    //update combo Flag
                    bool comboFlag = false;
                    if (g_client.pammList[overall_id] == 1) comboFlag = true;
                    if (overall_id == g_client.master_client_id) comboFlag = false;
                    ctr.change_combo(comboFlag);
                }
                flow_pamm.ResumeLayout();

                update_pamm_bid_ask_price();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("show pamm failed: " + ex.ToString());
            }
        }

        private void update_pamm_bid_ask_price()
        {
            if (g_client.no_client()) return;

            try
            {
                pamm_buysell_ctrl.update_bid_ask();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Update pamm bid ask price failed: " + ex.ToString());
            }
        }

        private void update_account_pamm_ctrl_contents(int clientId, AccountPAMM ctr, bool is_master, double lots, bool order_updated = false)
        {
            try
            {
                ClientDetails client_details = new ClientDetails();
                client_details.Init();

                if(!g_client.no_client())
                {
                    g_client.get_client_details_pamm(client_details, clientId, is_master, lots, order_updated);
                    ctr.change_connections(g_client.connectionList[2 * clientId], g_client.connectionList[2 * clientId + 1]);
                }
                ctr.set_contents(client_details, show_client_flag);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Read pamm client error: " + ex.ToString());
            }
        }

        private void nav_administrator_Click(object sender, EventArgs e)
        {
            if (nav_administrator.selected == true) return;
            init_nav_buttons();
            nav_administrator.selected = true;
            panel_administrator.BringToFront();
            lab_head_title.Text = "ADMINISTRATOR";

            show_administrator(true);
        }

        private void show_administrator(bool order_updated = false)
        {
            update_account_ctrl_colors(ctrl_account_administrator);
            update_account_ctrl_contents(g_client.current_client_id, ctrl_account_administrator);

            try
            {
                int _year = DateTime.Now.Year;
                int _month = DateTime.Now.Month;
                lab_admin_month.Text = Settings.Months[_month];
                lab_admin_year.Text = _year.ToString();

                bool change_flag = false;
                if (lab_admin_month.Text != Settings.Months[_month]) change_flag = true;

                AdminInfo info = new AdminInfo();
                info.Init();

                double val;
                if (!Double.TryParse(tb_admin_interest.Text, out val)) val = 0;
                info.interest = val;

                if (!order_updated && !change_flag) return;

                //g_client.get_admin_info(info);

                lab_admin_profit.Text = info.profit.ToString("#,##0.00");
                lab_admin_loss.Text = info.loss.ToString("#,##0.00");
                lab_admin_swap.Text = info.swap.ToString("#,##0.00");

                lab_admin_closed.Text = info.lots.ToString("#,##0.00");
                lab_admin_commission_total.Text = info.commission_total.ToString("#,##0.00");
                lab_admin_commission_month.Text = info.swap_month.ToString("#,##0.00");
                lab_admin_commission_year.Text = info.swap_year.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Show administrator failed: " + ex.ToString());
            }
        }

        private void nav_statistics_Click(object sender, EventArgs e)
        {
            if (nav_statistics.selected == true) return;
            init_nav_buttons();
            nav_statistics.selected = true;
            panel_statistics.BringToFront();
            lab_head_title.Text = "STATISTICS";

            //show_statistics(true);
        }

        private void show_statistics(bool order_updated = false)
        {
            StatisticsInfo info = new StatisticsInfo();
            info.Init();

            try
            {
                g_client.update_EUR_CHF_ratio(g_API.R3_bid[0], g_API.R8_ask[1]);
                g_client.get_statistics_info(info, order_updated);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Show statistics failed: " + ex.ToString());
            }

            //update contents
            lab_tot_clients.Text = g_client.tot_client_num.ToString();
            lab_live_clients.Text = g_client.get_live_clients_num().ToString();

            lab_open_profit_R8.Text = info.open_profit_R8.ToString("#,##0.00");
            lab_open_loss_R8.Text = info.open_loss_R8.ToString("#,##0.00");
            lab_open_lots_R8.Text = info.open_lots_R8.ToString("#,##0.00");

            lab_open_profit_R3.Text = info.open_profit_R3.ToString("#,##0.00");
            lab_open_loss_R3.Text = info.open_loss_R3.ToString("#,##0.00");
            lab_open_lots_R3.Text = info.open_lots_R3.ToString("#,##0.00");

            if (order_updated)
            {
                lab_close_profit_R8.Text = info.close_profit_R8.ToString("#,##0.00");
                lab_close_loss_R8.Text = info.close_loss_R8.ToString("#,##0.00");
                lab_close_lots_R8.Text = info.close_lots_R8.ToString("#,##0.00");

                lab_close_profit_R3.Text = info.close_profit_R3.ToString("#,##0.00");
                lab_close_loss_R3.Text = info.close_loss_R3.ToString("#,##0.00");
                lab_close_lots_R3.Text = info.close_lots_R3.ToString("#,##0.00");

                lab_commission_total_R8.Text = info.commission_total_R8.ToString("#,##0.00");
                lab_commission_total_R3.Text = info.commission_total_R3.ToString("#,##0.00");
            }
        }

        private void nav_settings_Click(object sender, EventArgs e)
        {
            if (nav_settings.selected == true) return;
            init_nav_buttons();
            nav_settings.selected = true;
            panel_settings.BringToFront();
            lab_head_title.Text = "SETTINGS";

            //g_client.save_commission();
        }
        private void nav_history_Click(object sender, EventArgs e)
        {
            if (nav_history.selected == true) return;
           
            init_nav_buttons();
            nav_history.selected = true;
            panel_history.BringToFront();

            progress_history.Visible = true;

            try
            {
                grid_order_history_180.Rows.Clear();
                grid_order_history_130.Rows.Clear();

                int year = g_client.server_time.Year;
                var orders = new List<OrderHistory>();

                Thread thread = new Thread(() =>
                {
                    if (g_client.current_client_id < 0 || g_client.current_client_id >= g_client.tot_client_num)
                    {
                        orders = g_client.get_closed_order();
                    }
                    else
                    {
                        orders = g_client.get_closed_order(g_client.current_client_id);
                    }

                    this.InvokeOnUiThreadIfRequired(() =>
                    {
                        progress_history.Visible = false;

                        int i_180 = 0;
                        int i_130 = 0;
                        foreach (var order in orders)
                        {
                            string dt_str = "MM/dd/yyyy";

                            if (order.is_180)
                            {
                                grid_order_history_180.Rows.Add(order.Lots.ToString("0.00"), order.OpenTime.ToString(dt_str), order.CloseTime.ToString(dt_str), order.pnl.ToString("0.00"));

                                if (i_180 % 2 == 0)
                                {
                                    grid_order_history_180.Rows[i_180].DefaultCellStyle.BackColor = Color.White;
                                }
                                else
                                {
                                    grid_order_history_180.Rows[i_180].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                                }
                                i_180++;
                            }
                            else
                            {
                                grid_order_history_130.Rows.Add(order.Lots.ToString("0.00"), order.OpenTime.ToString(dt_str), order.CloseTime.ToString(dt_str), order.pnl.ToString("0.00"));

                                if (i_130 % 2 == 0)
                                {
                                    grid_order_history_130.Rows[i_130].DefaultCellStyle.BackColor = Color.White;
                                }
                                else
                                {
                                    grid_order_history_130.Rows[i_130].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                                }
                                i_130++;
                            }
                        }

                        lab_head_title.Text = "HISTORY " + year.ToString();
                        lab_history_180.Text = "HISTORY " + year.ToString() + " 180";
                        lab_history_130.Text = "HISTORY " + year.ToString() + " 130";

                        int client_id = g_client.current_client_id;
                        if (client_id >= 0 && client_id < g_client.tot_client_num)
                        {
                            lab_history_client_name.Text = g_client.nameList[client_id];
                        }
                        else
                        {
                            lab_history_client_name.Text = "";
                        }
                    });
                });

                thread.Start();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Show history failed: " + ex.ToString());
            }
            
        }

        private void header_double_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
            {
                this.SuspendLayout();
                this.WindowState = FormWindowState.Maximized;
                btn_maximize.Visible = false;
                btn_restore.Visible = true;
                this.ResumeLayout();
            }
            else
            {
                this.SuspendLayout();
                this.WindowState = FormWindowState.Normal;
                btn_maximize.Visible = true;
                btn_restore.Visible = false;
                this.ResumeLayout();
            }
        }

        private void draw_candle_chart_origin()
        {
            if (g_API.R3_open[0] == 0 || g_API.R3_open[1] == 0) return;
            if (!IsControlAtFront(panel_tradingdesk)) return;
            try
            {
                if (chart_view.Series["stocks"].Points != null)
                    chart_view.Series["stocks"].Points.Clear();
                
                double p_o, p_h, p_l, p_c;
                DateTime dt;
                string dtString;

                //set border style
                chart_view.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
                chart_view.ChartAreas[0].BorderColor = Color.Black;
                chart_view.ChartAreas[0].BorderWidth = 2;

                //grid line width
                chart_view.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
                chart_view.ChartAreas[0].AxisY2.MajorGrid.LineWidth = 1;

                //set axis
                chart_view.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
                chart_view.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                chart_view.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

                ////display title
                //double _swap = g_client.get_symbol_swap(Settings.SymbolsToSubscribe1[g_API.tradingdesk_symbol_id]);
                //int _spread = g_API.get_spread_sum(g_API.tradingdesk_symbol_id);

                //if(_swap > 0)
                //{
                //    double breakeven = _spread / _swap;
                //    chart_view.Titles[0].Visible = true;
                //    chart_view.Titles[0].Text = breakeven.ToString("0.0") + " Days at BREAK EVEN";
                //}

                double minVal = 1e9;
                double maxVal = -1e9;
                for (int i = 0; i < Settings.current_candle_num; i++)
                {
                    minVal = Math.Min(minVal, g_API.R3_low[i]);
                    maxVal = Math.Max(maxVal, g_API.R3_high[i]);
                }

                double diff = (maxVal - minVal) * 0.25;
                minVal = Math.Truncate((minVal - diff) * 1e5) / 1e5;
                maxVal = Math.Truncate((maxVal + diff) * 1e5) / 1e5;

                //axis interval
                chart_view.ChartAreas[0].AxisX.Interval = Settings.current_candle_num / 10;
                chart_view.ChartAreas[0].AxisX.IsMarginVisible = true;
                chart_view.ChartAreas[0].AxisX.Maximum = Settings.current_candle_num * 1.1;
                chart_view.ChartAreas[0].AxisX.Minimum = 0;

                chart_view.ChartAreas[0].AxisY2.Minimum = minVal;
                chart_view.ChartAreas[0].AxisY2.Maximum = maxVal;
                chart_view.ChartAreas[0].AxisY2.Interval = Math.Truncate(diff / 2 * 1e5) / 1e5;
                chart_view.ChartAreas[0].AxisY2.LabelStyle.Format = g_API.get_digit_string();

                chart_view.ChartAreas[0].AxisY.Minimum = minVal;
                chart_view.ChartAreas[0].AxisY.Maximum = maxVal;

                //chart_view.Series["stocks"].BackGradientStyle = GradientStyle.VerticalCenter;

                //candle color
                byte r, g, b;
                r = lab_settings_short.BackColor.R;
                g = lab_settings_short.BackColor.G;
                b = lab_settings_short.BackColor.B;
                string shortColor = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

                r = lab_settings_long.BackColor.R;
                g = lab_settings_long.BackColor.G;
                b = lab_settings_long.BackColor.B;
                string longColor = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

                chart_view.Series["stocks"]["PriceDownColor"] = shortColor;
                chart_view.Series["stocks"]["PriceUpColor"] = longColor;
                chart_view.Series["stocks"].Color = lab_settings_stick.BackColor;

                //grid line color
                chart_view.ChartAreas[0].AxisX.MajorGrid.LineColor = lab_settings_grid.BackColor;
                chart_view.ChartAreas[0].AxisY.MajorGrid.LineColor = lab_settings_grid.BackColor;
                chart_view.ChartAreas[0].AxisY2.MajorGrid.LineColor = lab_settings_grid.BackColor;

                for (int i = 0; i < Settings.current_candle_num; i++)
                {
                    int curId = Settings.current_candle_num - i - 1;
                    dt = g_API.R3_historytime[curId];

                    if ((int)g_API.current_tf < (int)Timeframe.D1)
                        dtString = dt.ToString("d MMM HH:mm");
                    else
                        dtString = dt.ToString("d MMM yyyy");

                    p_o = g_API.R3_open[curId];
                    p_h = g_API.R3_high[curId];
                    p_l = g_API.R3_low[curId];
                    p_c = g_API.R3_close[curId];

                    DataPoint point = new DataPoint();
                    point.SetValueXY(dtString, p_l, p_h, p_o, p_c);
                    chart_view.Series["stocks"].Points.Add(point);
                    chart_view.Series["stocks"].Points[i].ToolTip = string.Format("{0}\nOpen:{1}\nHigh:{2}\nLow:{3}\nClose:{4}", dtString, p_o, p_h, p_l, p_c);
                    chart_view.Series["stocks"].Points[i].BorderColor = Color.Black;
                    chart_view.Series["stocks"].Points[i].BorderWidth = 1;
                }

                display_striplines();
                update_pending_panel();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't draw candle chart: " + ex.ToString());
            }
        }

        private void update_pending_panel()
        {
            double maxVal = chart_view.ChartAreas[0].AxisY.Maximum;
            double minVal = chart_view.ChartAreas[0].AxisY.Minimum;

            //update panel
            if (tradingdesk_state != TradingDeskState.ShowOrder)
            {
                panel_td_pendingorder.Visible = true;

                var x = chart_view.Location.X + chart_view.ChartAreas[0].AxisX.ValueToPixelPosition(Settings.current_candle_num * 1.1);
                var y = chart_view.Location.Y + chart_view.ChartAreas[0].AxisY2.ValueToPixelPosition(maxVal);
                var height = -chart_view.ChartAreas[0].AxisY2.ValueToPixelPosition(maxVal) + chart_view.ChartAreas[0].AxisY2.ValueToPixelPosition(minVal);

                panel_td_pendingorder.Location = new Point((int)x - panel_td_pendingorder.Width, (int)y + 1);
                panel_td_pendingorder.Height = (int)height;
                panel_td_pendingorder.Invalidate();
            }
            else panel_td_pendingorder.Visible = false;
        }

        private void display_striplines()
        {
            remove_prev_striplines(chart_view);
            manage_custom_line();

            if (tradingdesk_state == TradingDeskState.ShowOrder)
            {
                manage_show_orders();
            }
            else if (tradingdesk_state == TradingDeskState.ShowPending)
            {
                manage_pending_orders();
            }
            else
            {
                manage_alerts();
            }
        }

        private void remove_prev_striplines(Chart _chart)
        {
            _chart.ChartAreas[0].AxisY2.StripLines.Clear();
        }

        private void manage_custom_line()
        {
            if (tradingdesk_state == TradingDeskState.ShowOrder)
                return;

            double maxVal = chart_view.ChartAreas[0].AxisY.Maximum;
            double minVal = chart_view.ChartAreas[0].AxisY.Minimum;

            if (chart_custom_ratio > 0)
            {
                chart_custom_price = maxVal * (1 - chart_custom_ratio) + minVal * chart_custom_ratio;
                chart_custom_ratio = -1;
            }
            if (chart_custom_price > 0)
            {
                if(tradingdesk_state == TradingDeskState.ShowPending)
                {
                    add_strip_line(chart_view, chart_custom_price, 0, Color.Red);
                }
                else //price alert
                {
                    int symbol_id = g_API.tradingdesk_symbol_id;
                    if (manage_alert_state == ManageAlertState.AddAlert)                    
                        g_price_alert.add_price(symbol_id, chart_custom_price);
                    else
                        g_price_alert.remove_price(symbol_id, chart_custom_price);
                    chart_custom_price = -1;
                }
            }
        }

        private void manage_tradingdesk_new_orders(Chart _chart, int server_flag)
        {
            remove_prev_striplines(_chart);

            if (showorder_state_new == ShowOrderState.ShowAll)
            {
                int _symbol_id = g_API.tradingdesk_symbol_id;
                string _symbol = Settings.SymbolsToSubscribe[_symbol_id];

                double maxVal = _chart.ChartAreas[0].AxisY.Maximum;
                double minVal = _chart.ChartAreas[0].AxisY.Minimum;

                if (g_client.check_connection_both_accounts(g_client.current_client_id, false))
                {
                    var orders = g_client.qcList[2 * g_client.current_client_id + server_flag].GetOpenedOrders();
                    foreach (var order in orders)
                    {
                        if (!g_API.is_market_order(order)) continue;
                        string symbol = remove_suffix(order.Symbol);
                        if (symbol == "UKOilCash") symbol = "XITUSD";
                        if (symbol == _symbol)
                        {
                            add_strip_line(_chart, order.OpenPrice, order.Lots, Color.Black);
                        }
                    }
                }
            }
        }

        private void manage_show_orders()
        {
            try
            {
                int _symbol_id = g_API.tradingdesk_symbol_id;
                string _symbol = Settings.SymbolsToSubscribe[_symbol_id];
                double _points = Settings.SymbolsPoint[_symbol_id];

                MinMaxPriceInfo price_info = new MinMaxPriceInfo();
                g_client.get_min_max_order_price(price_info, _symbol, 1);

                double maxVal = chart_view.ChartAreas[0].AxisY.Maximum;
                double minVal = chart_view.ChartAreas[0].AxisY.Minimum;

                if (showorder_state == ShowOrderState.ShowAll)
                {
                    if (g_client.check_connection_both_accounts(g_client.current_client_id, false))
                    {
                        var orders = g_client.qcList[2 * g_client.current_client_id + 1].GetOpenedOrders();
                        foreach (var order in orders)
                        {
                            if(!g_API.is_market_order(order)) continue;
                            string symbol = remove_suffix(order.Symbol);
                            Settings.Log.Debug("Order Symbol: " + symbol);
                            if (symbol == "UKOilCash") symbol = "XITUSD";
                            if (symbol == _symbol)
                            {
                                if (Math.Abs(order.OpenPrice - price_info.maxPrice) > _points && Math.Abs(order.OpenPrice - price_info.minPrice) > _points
                                    && Math.Abs(order.OpenPrice - price_info.breakevenPrice) > _points)
                                {
                                    add_strip_line(chart_view, order.OpenPrice, order.Lots, Color.Black);
                                }
                            }
                        }
                    }
                }

                if (price_info.minPrice > 0)
                {
                    add_strip_line(chart_view, price_info.minPrice, price_info.minLots, Color.Green);
                }
                if (price_info.maxPrice < 1e8)
                {
                    add_strip_line(chart_view, price_info.maxPrice, price_info.maxLots, Color.Red);
                }
                if (price_info.breakevenPrice < 1e8)
                {
                    add_strip_line(chart_view, price_info.breakevenPrice, price_info.breakevenLots, Color.Yellow);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Show orders failed: " + ex.ToString());
            }
        }

        private void manage_pending_orders()
        {
            int _symbol_id = g_API.tradingdesk_symbol_id;
            string _symbol = Settings.SymbolsToSubscribe[_symbol_id];
            double _points = Settings.SymbolsPoint[_symbol_id];

            double maxVal = chart_view.ChartAreas[0].AxisY.Maximum;
            double minVal = chart_view.ChartAreas[0].AxisY.Minimum;

            if (g_client.check_connection_both_accounts(g_client.current_client_id, false))
            {
                var orders = g_client.qcList[2 * g_client.current_client_id + 1].GetOpenedOrders();
                foreach (var order in orders)
                {
                    if (g_API.is_market_order(order)) continue;
                    string symbol = remove_suffix(order.Symbol);
                    if (symbol == "UKOilCash") symbol = "XITUSD";
                    if (symbol == _symbol)
                    {
                        Color col = Color.Black;
                        if (order.Ticket == selected_pending_order) col = Color.Red;

                        add_strip_line(chart_view, order.OpenPrice, order.Lots, col);
                    }
                }
            }
        }

        private void manage_alerts()
        {
            int symbol_id = g_API.tradingdesk_symbol_id;
            var priceList = g_price_alert.symbolAlertPriceList[symbol_id];
            double maxVal = chart_view.ChartAreas[0].AxisY.Maximum;
            double minVal = chart_view.ChartAreas[0].AxisY.Minimum;

            foreach (var price in priceList)
            {
                add_strip_line(chart_view, price, 0, Color.Red);
            }
        }

        private void add_strip_line(Chart _chart, double price, double Lots, Color col)
        {
            StripLine stripline = new StripLine();
            stripline.Interval = 0;
            stripline.IntervalOffset = price;
            stripline.StripWidth = 0;
            stripline.BorderWidth = 1;
            stripline.BorderColor = col;
            stripline.BorderDashStyle = ChartDashStyle.DashDot;

            if(Lots > 0)
                stripline.Text = Lots.ToString("0.00");

            stripline.TextAlignment = StringAlignment.Near;
            stripline.TextLineAlignment = StringAlignment.Far;
            stripline.TextOrientation = TextOrientation.Auto;
            _chart.ChartAreas[0].AxisY2.StripLines.Add(stripline);
        }

        public string remove_suffix(string str)
        {
            int len = str.Length;
            if (str[len - 1] == '.' || str[len - 1] == '-' || str[len - 1] == 'x')
                str = str.Remove(len - 1);
            return str;
        }

        private void draw_candle_chart_R3()
        {
            if (g_API.R3_open[0] == 0 || g_API.R3_open[1] == 0) return;
            if (!IsControlAtFront(panel_tradingdesk_new)) return;
            try
            {
                if (chart_view_3.Series["stocks"].Points != null)
                    chart_view_3.Series["stocks"].Points.Clear();

                double p_o, p_h, p_l, p_c;
                DateTime dt;
                string dtString;

                chart_view_3.Titles[1].Text = g_API.get_ask_price(1);

                //set border style
                chart_view_3.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
                chart_view_3.ChartAreas[0].BorderColor = Color.Black;
                chart_view_3.ChartAreas[0].BorderWidth = 2;

                //grid line width
                chart_view_3.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
                chart_view_3.ChartAreas[0].AxisY2.MajorGrid.LineWidth = 1;

                //set axis
                chart_view_3.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
                chart_view_3.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                chart_view_3.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

                double minVal = 1e9;
                double maxVal = -1e9;
                for (int i = 0; i < Settings.current_candle_num; i++)
                {
                    minVal = Math.Min(minVal, g_API.R3_low[i]);
                    maxVal = Math.Max(maxVal, g_API.R3_high[i]);
                }

                double diff = (maxVal - minVal) * 0.25;
                minVal = Math.Truncate((minVal - diff) * 1e5) / 1e5;
                maxVal = Math.Truncate((maxVal + diff) * 1e5) / 1e5;

                //axis interval
                chart_view_3.ChartAreas[0].AxisX.Interval = Settings.current_candle_num / 10;
                chart_view_3.ChartAreas[0].AxisX.IsMarginVisible = true;
                chart_view_3.ChartAreas[0].AxisX.Maximum = Settings.current_candle_num * 1.1;
                chart_view_3.ChartAreas[0].AxisX.Minimum = 0;

                chart_view_3.ChartAreas[0].AxisY2.Minimum = minVal;
                chart_view_3.ChartAreas[0].AxisY2.Maximum = maxVal;
                chart_view_3.ChartAreas[0].AxisY2.Interval = Math.Truncate(diff / 2 * 1e5) / 1e5;
                chart_view_3.ChartAreas[0].AxisY2.LabelStyle.Format = g_API.get_digit_string();

                chart_view_3.ChartAreas[0].AxisY.Minimum = minVal;
                chart_view_3.ChartAreas[0].AxisY.Maximum = maxVal;

                //chart_view.Series["stocks"].BackGradientStyle = GradientStyle.VerticalCenter;

                //candle color
                byte r, g, b;
                r = lab_settings_short.BackColor.R;
                g = lab_settings_short.BackColor.G;
                b = lab_settings_short.BackColor.B;
                string shortColor = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

                r = lab_settings_long.BackColor.R;
                g = lab_settings_long.BackColor.G;
                b = lab_settings_long.BackColor.B;
                string longColor = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

                chart_view_3.Series["stocks"]["PriceDownColor"] = shortColor;
                chart_view_3.Series["stocks"]["PriceUpColor"] = longColor;
                chart_view_3.Series["stocks"].Color = lab_settings_stick.BackColor;

                //grid line color
                chart_view_3.ChartAreas[0].AxisX.MajorGrid.LineColor = lab_settings_grid.BackColor;
                chart_view_3.ChartAreas[0].AxisY.MajorGrid.LineColor = lab_settings_grid.BackColor;
                chart_view_3.ChartAreas[0].AxisY2.MajorGrid.LineColor = lab_settings_grid.BackColor;

                for (int i = 0; i < Settings.current_candle_num; i++)
                {
                    int curId = Settings.current_candle_num - i - 1;
                    dt = g_API.R3_historytime[curId];

                    if ((int)g_API.current_tf < (int)Timeframe.D1)
                        dtString = dt.ToString("d MMM HH:mm");
                    else
                        dtString = dt.ToString("d MMM yyyy");

                    p_o = g_API.R3_open[curId];
                    p_h = g_API.R3_high[curId];
                    p_l = g_API.R3_low[curId];
                    p_c = g_API.R3_close[curId];

                    DataPoint point = new DataPoint();
                    point.SetValueXY(dtString, p_l, p_h, p_o, p_c);
                    chart_view_3.Series["stocks"].Points.Add(point);
                    chart_view_3.Series["stocks"].Points[i].ToolTip = string.Format("{0}\nOpen:{1}\nHigh:{2}\nLow:{3}\nClose:{4}", dtString, p_o, p_h, p_l, p_c);
                    chart_view_3.Series["stocks"].Points[i].BorderColor = Color.Black;
                    chart_view_3.Series["stocks"].Points[i].BorderWidth = 1;
                }

                manage_tradingdesk_new_orders(chart_view_3, 1);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't draw candle chart: " + ex.ToString());
            }
        }

        private void draw_candle_chart_R8()
        {
            if (g_API.R8_open[0] == 0 || g_API.R8_open[1] == 0) return;
            if (!IsControlAtFront(panel_tradingdesk_new)) return;
            try
            {
                if (chart_view_8.Series["stocks"].Points != null)
                    chart_view_8.Series["stocks"].Points.Clear();

                double p_o, p_h, p_l, p_c;
                DateTime dt;
                string dtString;

                chart_view_8.Titles[1].Text = g_API.get_ask_price(0);

                //set border style
                chart_view_8.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
                chart_view_8.ChartAreas[0].BorderColor = Color.Black;
                chart_view_8.ChartAreas[0].BorderWidth = 2;

                //grid line width
                chart_view_8.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
                chart_view_8.ChartAreas[0].AxisY2.MajorGrid.LineWidth = 1;

                //set axis
                chart_view_8.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
                chart_view_8.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                chart_view_8.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

                double minVal = 1e9;
                double maxVal = -1e9;
                for (int i = 0; i < Settings.current_candle_num; i++)
                {
                    minVal = Math.Min(minVal, g_API.R8_low[i]);
                    maxVal = Math.Max(maxVal, g_API.R8_high[i]);
                }

                double diff = (maxVal - minVal) * 0.25;
                minVal = Math.Truncate((minVal - diff) * 1e5) / 1e5;
                maxVal = Math.Truncate((maxVal + diff) * 1e5) / 1e5;

                //axis interval
                chart_view_8.ChartAreas[0].AxisX.Interval = Settings.current_candle_num / 10;
                chart_view_8.ChartAreas[0].AxisX.IsMarginVisible = true;
                chart_view_8.ChartAreas[0].AxisX.Maximum = Settings.current_candle_num * 1.1;
                chart_view_8.ChartAreas[0].AxisX.Minimum = 0;

                chart_view_8.ChartAreas[0].AxisY2.Minimum = minVal;
                chart_view_8.ChartAreas[0].AxisY2.Maximum = maxVal;
                chart_view_8.ChartAreas[0].AxisY2.Interval = Math.Truncate(diff / 2 * 1e5) / 1e5;
                chart_view_8.ChartAreas[0].AxisY2.LabelStyle.Format = g_API.get_digit_string();

                chart_view_8.ChartAreas[0].AxisY.Minimum = minVal;
                chart_view_8.ChartAreas[0].AxisY.Maximum = maxVal;

                //chart_view.Series["stocks"].BackGradientStyle = GradientStyle.VerticalCenter;

                //candle color
                byte r, g, b;
                r = lab_settings_short.BackColor.R;
                g = lab_settings_short.BackColor.G;
                b = lab_settings_short.BackColor.B;
                string shortColor = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

                r = lab_settings_long.BackColor.R;
                g = lab_settings_long.BackColor.G;
                b = lab_settings_long.BackColor.B;
                string longColor = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

                chart_view_8.Series["stocks"]["PriceDownColor"] = shortColor;
                chart_view_8.Series["stocks"]["PriceUpColor"] = longColor;
                chart_view_8.Series["stocks"].Color = lab_settings_stick.BackColor;

                //grid line color
                chart_view_8.ChartAreas[0].AxisX.MajorGrid.LineColor = lab_settings_grid.BackColor;
                chart_view_8.ChartAreas[0].AxisY.MajorGrid.LineColor = lab_settings_grid.BackColor;
                chart_view_8.ChartAreas[0].AxisY2.MajorGrid.LineColor = lab_settings_grid.BackColor;

                for (int i = 0; i < Settings.current_candle_num; i++)
                {
                    int curId = Settings.current_candle_num - i - 1;
                    dt = g_API.R8_historytime[curId];

                    if ((int)g_API.current_tf < (int)Timeframe.D1)
                        dtString = dt.ToString("d MMM HH:mm");
                    else
                        dtString = dt.ToString("d MMM yyyy");

                    p_o = g_API.R8_open[curId];
                    p_h = g_API.R8_high[curId];
                    p_l = g_API.R8_low[curId];
                    p_c = g_API.R8_close[curId];

                    DataPoint point = new DataPoint();
                    point.SetValueXY(dtString, p_l, p_h, p_o, p_c);
                    chart_view_8.Series["stocks"].Points.Add(point);
                    chart_view_8.Series["stocks"].Points[i].ToolTip = string.Format("{0}\nOpen:{1}\nHigh:{2}\nLow:{3}\nClose:{4}", dtString, p_o, p_h, p_l, p_c);
                    chart_view_8.Series["stocks"].Points[i].BorderColor = Color.Black;
                    chart_view_8.Series["stocks"].Points[i].BorderWidth = 1;
                }

                manage_tradingdesk_new_orders(chart_view_8, 0);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't draw candle chart: " + ex.ToString());
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (Settings.current_candle_num == Settings.min_candle_num) return;

            Settings.current_candle_num = (int)(Settings.current_candle_num * 0.7);
            Settings.current_candle_num = Math.Min(Settings.current_candle_num, Settings.max_candle_num);
            Settings.current_candle_num = Math.Max(Settings.current_candle_num, Settings.min_candle_num);

            draw_candle_chart_origin();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (Settings.current_candle_num == Settings.max_candle_num) return;

            Settings.current_candle_num = (int)(Settings.current_candle_num * 1.5);
            Settings.current_candle_num = Math.Min(Settings.current_candle_num, Settings.max_candle_num);
            Settings.current_candle_num = Math.Max(Settings.current_candle_num, Settings.min_candle_num);

            draw_candle_chart_origin();
        }

        private void init_timeframe_button_color()
        {
            btn_m1.Textcolor = Color.White;
            btn_m5.Textcolor = Color.White;
            btn_m15.Textcolor = Color.White;
            btn_m30.Textcolor = Color.White;
            btn_h1.Textcolor = Color.White;
            btn_h4.Textcolor = Color.White;
            btn_d1.Textcolor = Color.White;
            btn_w1.Textcolor = Color.White;
        }

        private void btn_m1_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.M1) return;

            init_timeframe_button_color();
            btn_m1.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.M1;
            g_API.request_quote_history();
        }

        private void btn_m5_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.M5) return;

            init_timeframe_button_color();
            btn_m5.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.M5;
            g_API.request_quote_history();
        }

        private void btn_m15_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.M15) return;

            init_timeframe_button_color();
            btn_m15.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.M15;
            g_API.request_quote_history();

        }

        private void btn_m30_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.M30) return;

            init_timeframe_button_color();
            btn_m30.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.M30;
            g_API.request_quote_history();
        }

        private void btn_h1_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.H1) return;

            init_timeframe_button_color();
            btn_h1.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.H1;
            g_API.request_quote_history();
        }

        private void btn_h4_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.H4) return;

            init_timeframe_button_color();
            btn_h4.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.H4;
            g_API.request_quote_history();
        }

        private void btn_d1_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.D1) return;

            init_timeframe_button_color();
            btn_d1.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.D1;
            g_API.request_quote_history();
        }

        private void btn_w1_Click(object sender, EventArgs e)
        {
            if (g_API.current_tf == Timeframe.W1) return;

            init_timeframe_button_color();
            btn_w1.Textcolor = Color.Orange;

            g_API.current_tf = Timeframe.W1;
            g_API.request_quote_history();
        }

        private double get_lotsize(bool is_tradigdesk)
        {
            if(is_tradigdesk)
            {
                return td_buysell_ctrl.get_lotsize();
            }
            else
            {
                return pamm_buysell_ctrl.get_lotsize();
            }
        }

        private double get_percent_from_string(string percentStr)
        {
            double percent;
            try
            {
                percent = double.Parse(percentStr);
                if (percent < 0) percent = 0;
            }
            catch (Exception)
            {
                percent = 0;
            }
            return percent;
        }

        private void set_lotsize(double lots, bool is_tradingdesk)
        {
            if(is_tradingdesk)
            {
                td_buysell_ctrl.set_lotsize(lots);
            }
            else
            {
                pamm_buysell_ctrl.set_lotsize(lots);
            }
        }

        private void btn_tradingdesk_lotsize_down_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize(true);

            curLot -= 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot, true);
        }

        private void btn_tradingdesk_lotsize_up_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize(true);

            curLot += 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot, true);
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_KeyPress_3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (char.IsDigit(e.KeyChar) && (sender as TextBox).Text.Length >= 3) e.Handled = true;
        }

        private void tb_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (char.IsDigit(e.KeyChar) && (sender as TextBox).Text.Length >= 2) e.Handled = true;
        }

        private void btn_tradingdesk_buy_Click(object sender, EventArgs e)
        {
            if (!g_client.check_connection_both_accounts(g_client.current_client_id)) return;

            //if pending order, buy/sell button works only
            if (tradingdesk_state == TradingDeskState.ShowPending) return;

            Settings.Log.Info("Tradingdesk: buy button was clicked.");

            double lots = get_lotsize(true);

            if (Settings.SymbolSellAccount[g_API.tradingdesk_symbol_id] == 0)
            {
                g_API.open_R3_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.MarketOrder, 0);
            }
            else
            {
                g_API.open_R8_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.MarketOrder, 0);
            }
        }

        private void btn_tradingdesk_sell_Click(object sender, EventArgs e)
        {
            if (margin_call_on)
            {
                MessageBox.Show("Please turn off margin call first.");
                return;
            }

            if (!g_client.check_connection_both_accounts(g_client.current_client_id)) return;

            //if pending order, buy/sell button works only
            if (tradingdesk_state == TradingDeskState.ShowPending) return;

            Settings.Log.Info("Tradingdesk: sell button was clicked.");

            double lots = get_lotsize(true);

            if (Settings.SymbolSellAccount[g_API.tradingdesk_symbol_id] == 0)
            {
                g_API.open_R8_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.MarketOrder, 0);
            }
            else
            {
                g_API.open_R3_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.MarketOrder, 0);
            }
        }

        private void btn_tradingdesk_buysell_Click(object sender, EventArgs e)
        {
            if(margin_call_on)
            {
                MessageBox.Show("Please turn off margin call first.");
                return;
            }

            if (!g_client.check_connection_both_accounts(g_client.current_client_id)) return;

            Settings.Log.Info("Tradingdesk: one click button was clicked.");

            double lots = get_lotsize(true);

            if (tradingdesk_state != TradingDeskState.ShowPending) //market order
            {
                g_API.open_R8_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.MarketOrder, 0);
                g_API.open_R3_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.MarketOrder, 0);
            }
            else
            {
                //g_API.open_R8_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.PendingOrder, chart_custom_price);
                g_API.open_R3_order_async(g_API.tradingdesk_symbol_id, lots, MarketPending.PendingOrder, chart_custom_price);
            }
        }

        private void btn_pamm_sell_Click(object sender, EventArgs e)
        {
            if (margin_call_on)
            {
                MessageBox.Show("Please turn off margin call first.");
                return;
            }

            if (!g_client.check_connection_both_accounts(g_client.master_client_id)) return;

            double lots = get_lotsize(false);
            double pamm_percent =  pamm_buysell_ctrl.slave_percent / 100.0;
            double newLots;

            Settings.Log.Info("PAMM: sell button was clicked.");

            double master_margin = g_API.get_master_free_margin();

            for(int i = 0; i < g_client.tot_client_num; i++)
            {
                if (!g_client.check_connection_both_accounts(i)) continue;

                if (i == g_client.master_client_id)
                {
                    newLots = lots;
                }
                else
                {
                    if (g_client.pammList[i] == 0) continue;
                    if (master_margin == 0) continue;

                    newLots = g_API.get_new_lots(i, lots * pamm_percent, master_margin);
                }
                if (newLots == 0) continue;

                if (Settings.SymbolSellAccount[g_API.pamm_symbol_id] == 0)
                    g_API.open_R8_order_async(g_API.pamm_symbol_id, newLots, MarketPending.MarketOrder, 0, i);
                else
                    g_API.open_R3_order_async(g_API.pamm_symbol_id, newLots, MarketPending.MarketOrder, 0, i);
            }
        }

        private void btn_pamm_buy_Click(object sender, EventArgs e)
        {
            if (!g_client.check_connection_both_accounts(g_client.master_client_id)) return;

            double lots = get_lotsize(false);
            double pamm_percent =  pamm_buysell_ctrl.slave_percent / 100.0;
            double newLots;

            Settings.Log.Info("PAMM: buy button was clicked.");

            double master_margin = g_API.get_master_free_margin();

            for (int i = 0; i < g_client.tot_client_num; i++)
            {
                if (!g_client.check_connection_both_accounts(i)) continue;

                if (i == g_client.master_client_id)
                {
                    newLots = lots;
                }
                else
                {
                    if (g_client.pammList[i] == 0) continue;
                    if (master_margin == 0) continue;

                    newLots = g_API.get_new_lots(i, lots * pamm_percent, master_margin);
                }
                if (newLots == 0) continue;

                if (Settings.SymbolSellAccount[g_API.pamm_symbol_id] == 0)
                    g_API.open_R3_order_async(g_API.pamm_symbol_id, newLots, MarketPending.MarketOrder, 0, i);
                else
                    g_API.open_R8_order_async(g_API.pamm_symbol_id, newLots, MarketPending.MarketOrder, 0, i);
            }
        }

        private void btn_pamm_buysell_Click(object sender, EventArgs e)
        {
            if (!g_client.check_connection_both_accounts(g_client.master_client_id)) return;

            double lots = get_lotsize(false);
            double pamm_percent =  pamm_buysell_ctrl.slave_percent / 100.0;
            double newLots;

            Settings.Log.Info("PAMM: one click button was clicked.");

            double master_margin = g_API.get_master_free_margin();

            for (int i = 0; i < g_client.tot_client_num; i++)
            {
                if (!g_client.check_connection_both_accounts(i)) continue;

                if (i == g_client.master_client_id)
                {
                    newLots = lots;
                }
                else
                {
                    if (g_client.pammList[i] == 0) continue;
                    if (master_margin == 0) continue;

                    newLots = g_API.get_new_lots(i, lots * pamm_percent, master_margin);
                }
                if (newLots == 0) continue;

                g_API.open_R8_order_async(g_API.pamm_symbol_id, newLots, MarketPending.MarketOrder, 0, i);
                g_API.open_R3_order_async(g_API.pamm_symbol_id, newLots, MarketPending.MarketOrder, 0, i);
            }
        }

        private void lab_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                ((Label)sender).BackColor = colorPicker.Color;
                update_header_account_colors();
            }
        }

        private void lab_font_Click(object sender, EventArgs e)
        {
            FontDialog fontPicker = new FontDialog();
            if (fontPicker.ShowDialog() == DialogResult.OK)
            {
                ((Label)sender).Text = fontPicker.Font.Name.ToString();
            }
        }

        private void btn_pamm_lotsize_down_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize(false);

            curLot -= 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot, false);
        }

        private void btn_pamm_lotsize_up_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize(false);

            curLot += 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot, false);
        }

        private void btn_order1_close_Click(object sender, EventArgs e)
        {
            if (margin_call_on)
            {
                MessageBox.Show("Please turn off margin call first.");
                return;
            }

            if (label1_order_id >= 0)
            {
                Settings.Log.Info("Tradingdesk: close order button was clicked.");
                int order_id1 = g_client.R8_orderList[label1_order_id];
                int order_id2 = g_client.R3_orderList[label1_order_id];

                g_API.close_hedge_orders(g_client.current_client_id, order_id1, order_id2);
            }
        }

        private void btn_order2_close_Click(object sender, EventArgs e)
        {
            if (margin_call_on)
            {
                MessageBox.Show("Please turn off margin call first.");
                return;
            }

            if (label2_order_id >= 0)
            {
                Settings.Log.Info("Tradingdesk: close order button was clicked.");
                int order_id1 = g_client.R8_orderList[label2_order_id];
                int order_id2 = g_client.R3_orderList[label2_order_id];

                g_API.close_hedge_orders(g_client.current_client_id, order_id1, order_id2);
            }
        }

        private void td_symbol_changed(object sender, EventArgs e)
        {
            if (g_API.tradingdesk_symbol_id == td_buysell_ctrl.symbol_id)
                return;
            g_API.tradingdesk_symbol_id = td_buysell_ctrl.symbol_id;
            update_spread_swap_breakeven();
            g_API.request_quote_history();

            init_custom_vales();
            selected_pending_order = -1;
        }

        private void pamm_symbol_changed(object sender, EventArgs e)
        {
            if (g_API.pamm_symbol_id == pamm_buysell_ctrl.symbol_id) return;

            g_API.pamm_symbol_id = pamm_buysell_ctrl.symbol_id;
            pamm_buysell_ctrl.update_bid_ask();
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            close_all_orders(g_client.current_client_id);
        }

        private void close_all_orders(int client_id)
        {
            List<int> R83_orderList = g_client.get_matched_order_list_close(client_id);

            g_API.close_all_hedge_orders(client_id, R83_orderList);
        }

        private void tb_admin_interest_TextChanged(object sender, EventArgs e)
        {
            show_administrator(true);
        }

        private void btn_notification_save_Click(object sender, EventArgs e)
        {
            g_client.set_notification_amount(tb_notification.Text);
            tb_notification.Text = g_client.get_notification_amount().ToString();
            save_client_info(g_client.current_client_id);
        }

        private void btn_phone_number_save_Click(object sender, EventArgs e)
        {
            g_client.set_phone_number(tb_phone_number.Text);
            tb_phone_number.Text = g_client.get_phone_number();
            save_client_info(g_client.current_client_id);
        }

        private void tb_pamm_percent_TextChanged(object sender, EventArgs e)
        {
            show_pamm();
        }

        private void tb_license_TextChanged(object sender, EventArgs e)
        {
            save_license();
        }

        private void dt_picker_ValueChanged(object sender, EventArgs e)
        {
            save_license();
        }

        private void tb_pamm_lotsize_TextChanged(object sender, EventArgs e)
        {
            show_pamm(true);
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            header_double_Click(this, EventArgs.Empty);
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            header_double_Click(this, EventArgs.Empty);
        }

        private void btn_setting_moneyshfit_Click(object sender, EventArgs e)
        {
            g_client.init_pending_time(-1);

            money_shift_on = !money_shift_on;
            update_setting_labels();
        }

        private void btn_setting_margincall_Click(object sender, EventArgs e)
        {
            margin_call_on = !margin_call_on;
            update_setting_labels();
        }

        private void btn_setting_phone_Click(object sender, EventArgs e)
        {
            phone_notify_on = !phone_notify_on;
            update_setting_labels();
        }

        private void update_setting_labels()
        {
            if (money_shift_on)
                lab_setting_moneyshfit.BackColor = Color.Green;
            else
                lab_setting_moneyshfit.BackColor = Color.Red;

            if (margin_call_on)
                lab_setting_margincall.BackColor = Color.Green;
            else
                lab_setting_margincall.BackColor = Color.Red;

            if (phone_notify_on)
                lab_setting_phone.BackColor = Color.Green;
            else
                lab_setting_phone.BackColor = Color.Red;
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                PDFViewer pdf_viewer = new PDFViewer("MANUAL DASHBOARD.pdf");
                pdf_viewer.Show();
                pdf_viewer.WindowState = FormWindowState.Maximized;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Open pdf failed: " + ex.ToString());
            }
        }

        private void Grid_order_history_Paint(object sender, PaintEventArgs e)
        {
            grid_order_history_180.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.FromArgb(219, 177, 125));
            Graphics g = e.Graphics;

            //int variance = 2;
            // g.DrawRectangle(p, new Rectangle(grid_order_history.Location.X - panel_history.Location.X  - variance, grid_order_history.Location.Y - panel_history.Location.Y -30 - variance, grid_order_history.Width + 1  - variance , grid_order_history.Height +1 ));
            //var height = 30;
            //var width = 352;
            var scroll = 18;

            g.DrawLine(p, grid_order_history_180.Location.X - 82,
                              grid_order_history_180.Location.Y,
                              grid_order_history_180.Location.X - 82,
                              grid_order_history_180.Location.Y + grid_order_history_180.Height);

            g.DrawLine(p, grid_order_history_180.Location.X + grid_order_history_180.Width - scroll - panel_history.Location.X - 82,
                             grid_order_history_180.Location.Y - 50,
                             grid_order_history_180.Location.X + grid_order_history_180.Width - scroll - panel_history.Location.X - 82,
                             grid_order_history_180.Location.Y + grid_order_history_180.Height);
        }

        private void Panel_history_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(219, 177, 125));
            Graphics g = e.Graphics;

            //var height = 27;
            //var width = 352;
            var scroll = 18;

            g.DrawLine(p, grid_order_history_180.Location.X ,
                           grid_order_history_180.Location.Y  + grid_order_history_180.Height,
                           grid_order_history_180.Location.X   + grid_order_history_180.Width - scroll ,
                           grid_order_history_180.Location.Y   + grid_order_history_180.Height);

            g.DrawLine(p, grid_order_history_180.Location.X,
                       grid_order_history_180.Location.Y ,
                       grid_order_history_180.Location.X + grid_order_history_180.Width - scroll,
                       grid_order_history_180.Location.Y );
        }

        private void Chart_view_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = e.Graphics;
            myBrush.Dispose();
        }

        private void Panel_td_pendingorder_MouseMove(object sender, MouseEventArgs e)
        {
            if(tradingdesk_state == TradingDeskState.ShowPending)
                return; //disable pending order

            if (tradingdesk_state != TradingDeskState.ShowPending) return;
            if (control_pending_state != ControlPendingState.AddPending) return;

            if (Control.MouseButtons == MouseButtons.Left)
            {
                if (e.Y + 20 > panel_td_pendingorder.Location.Y && e.Y + 20 <= panel_td_pendingorder.Location.Y + panel_td_pendingorder.Height)
                {
                    double ratio = 1.0 * (e.Y + 20 - panel_td_pendingorder.Location.Y) / panel_td_pendingorder.Height;
                    chart_custom_ratio = ratio;

                    display_striplines();
                }
            }
        }

        private void Panel_td_pendingorder_MouseClick(object sender, MouseEventArgs e)
        {
            if (tradingdesk_state == TradingDeskState.ShowPending)
                return; //disable pending order

            if (Control.MouseButtons == MouseButtons.Left)
            {
                if (e.Y + 20 > panel_td_pendingorder.Location.Y && e.Y + 20 <= panel_td_pendingorder.Location.Y + panel_td_pendingorder.Height)
                {
                    double ratio = 1.0 * (e.Y + 20 - panel_td_pendingorder.Location.Y) / panel_td_pendingorder.Height;
                    chart_custom_ratio = ratio;

                    if(tradingdesk_state == TradingDeskState.ShowPending)
                    {
                        if(control_pending_state == ControlPendingState.ModifyPending)
                        {
                            selected_pending_order = get_nearest_pending_order_with_price();
                        }
                        else if(control_pending_state == ControlPendingState.DeletePending)
                        {
                            selected_pending_order = get_nearest_pending_order_with_price();

                            //delete pending order
                            if (selected_pending_order > 0)
                                g_API.delete_one_pending_order(selected_pending_order);

                            selected_pending_order = -1;
                        }
                    }
                    display_striplines();
                }
            }
            else if(Control.MouseButtons == MouseButtons.Right)
            {
                if (tradingdesk_state != TradingDeskState.ShowPending) return;
                if (control_pending_state != ControlPendingState.ModifyPending) return;
                if (selected_pending_order < 0) return;

                if (e.Y + 20 > panel_td_pendingorder.Location.Y && e.Y + 20 <= panel_td_pendingorder.Location.Y + panel_td_pendingorder.Height)
                {
                    double ratio = 1.0 * (e.Y + 20 - panel_td_pendingorder.Location.Y) / panel_td_pendingorder.Height;
                    chart_custom_ratio = ratio;

                    double new_price = calc_chart_custom_price();
                    init_custom_vales();

                    //modify pending order
                    if (selected_pending_order > 0 && new_price > 0)
                        g_API.modify_R3_pending_order_async(selected_pending_order, new_price);
                }
            }
        }

        private double calc_chart_custom_price()
        {
            double maxVal = chart_view.ChartAreas[0].AxisY.Maximum;
            double minVal = chart_view.ChartAreas[0].AxisY.Minimum;
            double cur_price = maxVal * (1 - chart_custom_ratio) + minVal * chart_custom_ratio;

            return cur_price;
        }

        private int get_nearest_pending_order_with_price()
        {
            int ticket = -1;
            if (chart_custom_ratio < 0) return ticket;

            double maxVal = chart_view.ChartAreas[0].AxisY.Maximum;
            double minVal = chart_view.ChartAreas[0].AxisY.Minimum;
            double cur_price = maxVal * (1 - chart_custom_ratio) + minVal * chart_custom_ratio;
            chart_custom_ratio = -1;

            int _symbol_id = g_API.tradingdesk_symbol_id;
            string _symbol = Settings.SymbolsToSubscribe[_symbol_id];
            double _points = Settings.SymbolsPoint[_symbol_id];
            double threshold = _points * 500;

            if (g_client.check_connection_both_accounts(g_client.current_client_id, false))
            {
                var orders = g_client.qcList[2 * g_client.current_client_id + 1].GetOpenedOrders();
                double minDiff = 1e9;

                foreach (var order in orders)
                {
                    if (g_API.is_market_order(order)) continue;
                    string symbol = remove_suffix(order.Symbol);
                    if (symbol == "UKOilCash") symbol = "XITUSD";
                    if (symbol == _symbol)
                    {
                        double diff = Math.Abs(order.OpenPrice - cur_price);
                        if(diff < threshold)
                        {
                            if(diff < minDiff)
                            {
                                ticket = order.Ticket;
                                minDiff = diff;
                            }
                        }
                    }
                }
            }
            return ticket;
        }

        private void btn_td_show_order_Click(object sender, EventArgs e)
        {
            if(tradingdesk_state == TradingDeskState.ShowOrder)
            {
                showorder_state = 1 - showorder_state;
            }

            tradingdesk_state = TradingDeskState.ShowOrder;
            change_alert_button_visible();
            change_pending_button_visible();
            init_custom_vales();
            selected_pending_order = -1;

            display_striplines();
            update_pending_panel();
        }

        private void btn_td_pending_order_Click(object sender, EventArgs e)
        {
            if (tradingdesk_state == TradingDeskState.ShowPending)
                return;

            tradingdesk_state = TradingDeskState.ShowPending;
            change_alert_button_visible();
            change_pending_button_visible();
            init_custom_vales();
            selected_pending_order = -1;

            display_striplines();
            update_pending_panel();
        }

        private void btn_td_alert_Click(object sender, EventArgs e)
        {
            if (tradingdesk_state == TradingDeskState.ShowAlert)
                return;

            tradingdesk_state = TradingDeskState.ShowAlert;
            change_alert_button_visible();
            change_pending_button_visible();
            init_custom_vales();
            selected_pending_order = -1;

            display_striplines();
            update_pending_panel();
        }

        private void btn_add_price_alert_Click(object sender, EventArgs e)
        {
            manage_alert_state = ManageAlertState.RemoveAlert;
            change_alert_button_visible();

            display_striplines();
        }

        private void btn_remove_price_alert_Click(object sender, EventArgs e)
        {
            manage_alert_state = ManageAlertState.AddAlert;
            change_alert_button_visible();

            display_striplines();
        }

        private void change_alert_button_visible()
        {
            btn_add_price_alert.Visible = false;
            btn_remove_price_alert.Visible = false;
            if(tradingdesk_state == TradingDeskState.ShowAlert)
            {
                btn_add_price_alert.Visible = (manage_alert_state == ManageAlertState.AddAlert);
                btn_remove_price_alert.Visible = (manage_alert_state == ManageAlertState.RemoveAlert); ;
            }
        }

        private void init_custom_vales()
        {
            chart_custom_price = -1;
            chart_custom_ratio = -1;
        }

        private void chart_view_8_DoubleClick(object sender, EventArgs e)
        {
            showorder_state_new = 1 - showorder_state_new;

            manage_tradingdesk_new_orders(chart_view_8, 0);
            manage_tradingdesk_new_orders(chart_view_3, 1);
        }

        private void chart_view_3_DoubleClick(object sender, EventArgs e)
        {
            showorder_state_new = 1 - showorder_state_new;

            manage_tradingdesk_new_orders(chart_view_8, 0);
            manage_tradingdesk_new_orders(chart_view_3, 1);
        }

        private void btn_add_pending_order_Click(object sender, EventArgs e)
        {
            control_pending_state = ControlPendingState.ModifyPending;
            init_custom_vales();
            change_pending_button_visible();
            selected_pending_order = -1;

            display_striplines();
        }

        private void btn_modify_pending_order_Click(object sender, EventArgs e)
        {
            control_pending_state = ControlPendingState.DeletePending;
            init_custom_vales();
            change_pending_button_visible();
            selected_pending_order = -1;

            display_striplines();
        }

        private void btn_delete_pending_order_Click(object sender, EventArgs e)
        {
            control_pending_state = ControlPendingState.AddPending;
            init_custom_vales();
            change_pending_button_visible();
            selected_pending_order = -1;

            display_striplines();
        }

        private void change_pending_button_visible()
        {
            btn_add_pending_order.Visible = false;
            btn_modify_pending_order.Visible = false;
            btn_delete_pending_order.Visible = false;

            if(tradingdesk_state == TradingDeskState.ShowPending)
            {
                if (control_pending_state == ControlPendingState.AddPending) btn_add_pending_order.Visible = true;
                if (control_pending_state == ControlPendingState.ModifyPending) btn_modify_pending_order.Visible = true;
                if (control_pending_state == ControlPendingState.DeletePending) btn_delete_pending_order.Visible = true;
            }
        }

        private void btn_statement_year_pdf_Click(object sender, EventArgs e)
        {
            statement_html_ctrl.SavePDF();
        }

        private void lab_top_warning_Click(object sender, EventArgs e)
        {
            lab_top_warning.Text = "";
        }

        private void cb_close_trades_OnChange(object sender, EventArgs e)
        {
            close_trades_enabled = cb_close_trades.Checked;
        }

        private void swap_dt_picker_ValueChanged(object sender, EventArgs e)
        {
            update_details_contents(false);
        }

        private void change_swapfree_hedge_state()
        {
            int id = g_client.current_client_id;

            cb_swapfree1.Checked = g_client.check_swapfree(id, 0);
            cb_swapfree2.Checked = g_client.check_swapfree(id, 1);
            lab_details_account1.Text = g_client.userIdList[2 * id].ToString();
            lab_details_account2.Text = g_client.userIdList[2 * id + 1].ToString();

            cb_hedge1.Checked = g_client.check_hedge(id, 0);
            cb_hedge2.Checked = g_client.check_hedge(id, 1);
            lab_hedge_account1.Text = g_client.userIdList[2 * id].ToString();
            lab_hedge_account2.Text = g_client.userIdList[2 * id + 1].ToString();
        }

        private void cb_swapfree_OnChange(object sender, EventArgs e)
        {
            int id = g_client.current_client_id;

            g_client.swapfreeFlagList[2 * id] = cb_swapfree1.Checked ? 1 : 0;
            g_client.swapfreeFlagList[2 * id + 1] = cb_swapfree2.Checked ? 1 : 0;

            save_client_info(id);
            update_details_contents(false);
        }

        private void cb_hedge_OnChange(object sender, EventArgs e)
        {
            int id = g_client.current_client_id;

            g_client.hedgeFlagList[2 * id] = cb_hedge1.Checked ? 1 : 0;
            g_client.hedgeFlagList[2 * id + 1] = cb_hedge2.Checked ? 1 : 0;

            save_client_info(id);
            update_details_contents(false);
        }
    }
}