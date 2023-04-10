using System.Windows.Forms;

namespace FXFellowDashboard
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title21 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title22 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title23 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title24 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title25 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.All = new System.Windows.Forms.Panel();
            this.layout_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_side = new System.Windows.Forms.TableLayoutPanel();
            this.lab_prog_name = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lab_version_release = new System.Windows.Forms.Label();
            this.lab_broker_client = new System.Windows.Forms.Label();
            this.lab_setting_phone = new System.Windows.Forms.Label();
            this.lab_setting_margincall = new System.Windows.Forms.Label();
            this.lab_setting_moneyshfit = new System.Windows.Forms.Label();
            this.btn_pdf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_setting_phone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_setting_margincall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_setting_moneyshfit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_tab = new System.Windows.Forms.Panel();
            this.btn_expand = new System.Windows.Forms.Button();
            this.nav_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_clients = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_details = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_orders = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_tradingdesk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_pamm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_administrator = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_statistics = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_history = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_statement = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nav_settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_middle = new System.Windows.Forms.Panel();
            this.panel_tf_button = new System.Windows.Forms.Panel();
            this.btn_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_plus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_minus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_m1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_m5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_m15 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_m30 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_h1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_h4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_d1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_w1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lab_spread = new System.Windows.Forms.Label();
            this.lab_swap = new System.Windows.Forms.Label();
            this.lab_breakeven = new System.Windows.Forms.Label();
            this.panel_balance_alert = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.btn_balance_alert_name = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_tradingdesk = new System.Windows.Forms.Panel();
            this.panel_tradingdesk_up = new System.Windows.Forms.TableLayoutPanel();
            this.panel_tradingdesk_up_client = new System.Windows.Forms.TableLayoutPanel();
            this.ctrl_account_tradingdesk = new FXFellowDashboard.AccountsCtrl();
            this.ctrl_header_tradingdesk = new FXFellowDashboard.HeaderCtrl();
            this.panel_tradingdesk_up_symbol = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.td_buysell_ctrl = new FXFellowDashboard.TDBuySellCtrl();
            this.btn_delete_pending_order = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_modify_pending_order = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_add_pending_order = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_remove_price_alert = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_add_price_alert = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_td_show_order = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_td_pending_order = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_td_alert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel24 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_td_percent4 = new System.Windows.Forms.Label();
            this.lab_td_percent3 = new System.Windows.Forms.Label();
            this.lab_td_percent2 = new System.Windows.Forms.Label();
            this.lab_td_percent1 = new System.Windows.Forms.Label();
            this.lab_td_percent0 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.lab_td_lot4 = new System.Windows.Forms.Label();
            this.lab_td_lot3 = new System.Windows.Forms.Label();
            this.lab_td_lot2 = new System.Windows.Forms.Label();
            this.lab_td_lot1 = new System.Windows.Forms.Label();
            this.lab_td_lot0 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.lab_td_symbol4 = new System.Windows.Forms.Label();
            this.lab_td_symbol3 = new System.Windows.Forms.Label();
            this.lab_td_symbol2 = new System.Windows.Forms.Label();
            this.lab_td_symbol1 = new System.Windows.Forms.Label();
            this.lab_td_symbol0 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.panel_tradingdesk_down = new System.Windows.Forms.TableLayoutPanel();
            this.panel_order2 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_order2_account2 = new System.Windows.Forms.Label();
            this.lab_order2_sell2 = new System.Windows.Forms.Label();
            this.lab_order2_lot2 = new System.Windows.Forms.Label();
            this.lab_order2_symbol2 = new System.Windows.Forms.Label();
            this.lab_order2_pnl2 = new System.Windows.Forms.Label();
            this.lab_order2_spread2 = new System.Windows.Forms.Label();
            this.lab_order2_buy2 = new System.Windows.Forms.Label();
            this.lab_order2_symbol1 = new System.Windows.Forms.Label();
            this.lab_order2_account1 = new System.Windows.Forms.Label();
            this.lab_order2_lot1 = new System.Windows.Forms.Label();
            this.lab_order2_sell1 = new System.Windows.Forms.Label();
            this.lab_order2_buy1 = new System.Windows.Forms.Label();
            this.lab_order2_spread1 = new System.Windows.Forms.Label();
            this.lab_order2_pnl1 = new System.Windows.Forms.Label();
            this.panel_order1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_order1_pnl2 = new System.Windows.Forms.Label();
            this.lab_order1_spread2 = new System.Windows.Forms.Label();
            this.lab_order1_buy2 = new System.Windows.Forms.Label();
            this.lab_order1_sell2 = new System.Windows.Forms.Label();
            this.lab_order1_lot2 = new System.Windows.Forms.Label();
            this.lab_order1_symbol2 = new System.Windows.Forms.Label();
            this.lab_order1_account2 = new System.Windows.Forms.Label();
            this.lab_order1_pnl1 = new System.Windows.Forms.Label();
            this.lab_order1_spread1 = new System.Windows.Forms.Label();
            this.lab_order1_buy1 = new System.Windows.Forms.Label();
            this.lab_order1_sell1 = new System.Windows.Forms.Label();
            this.lab_order1_lot1 = new System.Windows.Forms.Label();
            this.lab_order1_symbol1 = new System.Windows.Forms.Label();
            this.lab_order1_account1 = new System.Windows.Forms.Label();
            this.order_separator = new System.Windows.Forms.Label();
            this.panel_order_header = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_order1_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_order2_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_chart = new System.Windows.Forms.Panel();
            this.panel_td_pendingorder = new System.Windows.Forms.Panel();
            this.chart_view = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_details = new System.Windows.Forms.Panel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.ctrl_account_details = new FXFellowDashboard.AccountsCtrl();
            this.ctrl_header_details = new FXFellowDashboard.HeaderCtrl();
            this.panel13 = new System.Windows.Forms.Panel();
            this.swap_dt_picker = new System.Windows.Forms.DateTimePicker();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_phone_number = new System.Windows.Forms.TextBox();
            this.tb_notification = new System.Windows.Forms.TextBox();
            this.btn_notification_save = new Bunifu.Framework.UI.BunifuImageButton();
            this.label47 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btn_phone_number_save = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_money_difference_save = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_margin_alert_save = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_margin_call_save = new Bunifu.Framework.UI.BunifuImageButton();
            this.label36 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lab_hedge_account2 = new System.Windows.Forms.Label();
            this.lab_hedge_account1 = new System.Windows.Forms.Label();
            this.lab_details_account2 = new System.Windows.Forms.Label();
            this.lab_details_account1 = new System.Windows.Forms.Label();
            this.cb_hedge2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.tb_moneyshift = new System.Windows.Forms.TextBox();
            this.cb_swapfree2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_hedge1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_close_trades = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_swapfree1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label49 = new System.Windows.Forms.Label();
            this.cb_moneyshift_onoff = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label45 = new System.Windows.Forms.Label();
            this.cb_pamm_onoff = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label241 = new System.Windows.Forms.Label();
            this.tb_margin_call = new System.Windows.Forms.TextBox();
            this.label239 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.tb_margin_alert = new System.Windows.Forms.TextBox();
            this.label238 = new System.Windows.Forms.Label();
            this.label237 = new System.Windows.Forms.Label();
            this.lab_details_breakeven = new System.Windows.Forms.Label();
            this.lab_details_swap_tot = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.label224 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label53 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dt_picker = new System.Windows.Forms.DateTimePicker();
            this.tb_license = new System.Windows.Forms.TextBox();
            this.tb_client_search = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.btn_login_new_account = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label52 = new System.Windows.Forms.Label();
            this.flow_clients = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ctrl_client = new FXFellowDashboard.ClientCtrl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.progress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btn_show_password = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_hide_password = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dp_login_display_num = new Bunifu.Framework.UI.BunifuDropdown();
            this.tb_login_page = new System.Windows.Forms.TextBox();
            this.btn_login_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_login_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_login_end = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_login_start = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.cb_settings_show_client = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_settings_shiftat = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label41 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lab_settings_font = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.lab_settings_stick = new System.Windows.Forms.Label();
            this.lab_settings_short = new System.Windows.Forms.Label();
            this.lab_settings_long = new System.Windows.Forms.Label();
            this.lab_settings_grid = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.cb_settings_equity = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label172 = new System.Windows.Forms.Label();
            this.cb_settings_pnl = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_settings_transfer = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_settings_balance = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_settings_curr = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label175 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.lab_settings_pip = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.lab_settings_account2 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.lab_settings_account1 = new System.Windows.Forms.Label();
            this.panel_pamm = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dp_pamm_display_num = new Bunifu.Framework.UI.BunifuDropdown();
            this.tb_pamm_page = new System.Windows.Forms.TextBox();
            this.btn_pamm_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_pamm_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_pamm_end = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_pamm_start = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_pamm_master = new System.Windows.Forms.TableLayoutPanel();
            this.ctrl_header_master = new FXFellowDashboard.HeaderPAMM();
            this.label90 = new System.Windows.Forms.Label();
            this.ctrl_account_pamm = new FXFellowDashboard.AccountPAMM();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pamm_buysell_ctrl = new FXFellowDashboard.PAMMBuySellCtrl();
            this.btn_pamm_master = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ctrl_header_slave = new FXFellowDashboard.HeaderPAMM();
            this.flow_pamm = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_dashboard = new System.Windows.Forms.Panel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dp_dashboard_display_num = new Bunifu.Framework.UI.BunifuDropdown();
            this.tb_dashboard_page = new System.Windows.Forms.TextBox();
            this.btn_dashboard_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_dashboard_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_dashboard_end = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_dashboard_start = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ctrl_header_dashboard = new FXFellowDashboard.HeaderCtrl();
            this.flow_dashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_orders = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ctrl_account_orders = new FXFellowDashboard.AccountsCtrl();
            this.ctrl_header_orders = new FXFellowDashboard.HeaderCtrl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dp_orders_display_num = new Bunifu.Framework.UI.BunifuDropdown();
            this.tb_orders_page = new System.Windows.Forms.TextBox();
            this.btn_orders_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_orders_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_orders_end = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_orders_start = new Bunifu.Framework.UI.BunifuImageButton();
            this.flow_orders = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrl_header = new FXFellowDashboard.OrderHeaderCtrl();
            this.panel_history = new System.Windows.Forms.Panel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_history_130 = new System.Windows.Forms.Label();
            this.progress_history = new System.Windows.Forms.Label();
            this.grid_order_history_130 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_order_history_180 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lab_history_client_name = new System.Windows.Forms.Label();
            this.lab_history_180 = new System.Windows.Forms.Label();
            this.panel_statement = new System.Windows.Forms.Panel();
            this.statement_html_ctrl = new FXFellowDashboard.HTMLViewCtrl();
            this.btn_statement_year_pdf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_tradingdesk_new = new System.Windows.Forms.Panel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.chart_view_3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel23 = new System.Windows.Forms.Panel();
            this.chart_view_8 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel21 = new System.Windows.Forms.Panel();
            this.lab_tradingdesk_new_client = new System.Windows.Forms.Label();
            this.panel_statistics = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lab_live_clients = new System.Windows.Forms.Label();
            this.lab_tot_clients = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lab_commission_total_R8 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.lab_commission_per_lot_R8 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.lab_commission_total_R3 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.lab_commission_per_lot_R3 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.lab_close_lots_R8 = new System.Windows.Forms.Label();
            this.lab_close_loss_R8 = new System.Windows.Forms.Label();
            this.lab_close_profit_R8 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.lab_close_lots_R3 = new System.Windows.Forms.Label();
            this.lab_close_loss_R3 = new System.Windows.Forms.Label();
            this.lab_close_profit_R3 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.lab_open_lots_R8 = new System.Windows.Forms.Label();
            this.lab_open_loss_R8 = new System.Windows.Forms.Label();
            this.lab_open_profit_R8 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.lab_open_lots_R3 = new System.Windows.Forms.Label();
            this.lab_open_loss_R3 = new System.Windows.Forms.Label();
            this.lab_open_profit_R3 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_administrator = new System.Windows.Forms.Panel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ctrl_account_administrator = new FXFellowDashboard.AccountsCtrl();
            this.ctrl_header_administrator = new FXFellowDashboard.HeaderCtrl();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tb_admin_interest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_admin_month = new System.Windows.Forms.Label();
            this.lab_admin_year = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_admin_commission_year = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lab_admin_commission_month = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_admin_commission_total = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.lab_admin_closed = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.lab_admin_swap = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.lab_admin_loss = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.lab_admin_profit = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.panel_clients = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.label99 = new System.Windows.Forms.Label();
            this.tb_search_money_shift = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.label98 = new System.Windows.Forms.Label();
            this.tb_search_pamm = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_search_account = new System.Windows.Forms.Label();
            this.tb_search_account = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_search_name = new System.Windows.Forms.Label();
            this.tb_search_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.lab_active_clients = new System.Windows.Forms.Label();
            this.lab_active_pamm = new System.Windows.Forms.Label();
            this.lab_active_money_shift = new System.Windows.Forms.Label();
            this.panel_head_1 = new System.Windows.Forms.Panel();
            this.panel_head = new System.Windows.Forms.Panel();
            this.lab_top_warning = new System.Windows.Forms.Label();
            this.btn_tradingdesk_new = new System.Windows.Forms.Button();
            this.lab_stockprice_diff = new System.Windows.Forms.Label();
            this.btn_login = new Bunifu.Framework.UI.BunifuImageButton();
            this.lab_pip_difference = new System.Windows.Forms.Label();
            this.btn_search = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_setting = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_logo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_maximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_restore = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.lab_head_title = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lab_spread_alert = new System.Windows.Forms.Label();
            this.num_spread_alert = new System.Windows.Forms.NumericUpDown();
            this.All.SuspendLayout();
            this.layout_main.SuspendLayout();
            this.panel_side.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel_tab.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.panel_middle.SuspendLayout();
            this.panel_tf_button.SuspendLayout();
            this.btn_panel.SuspendLayout();
            this.panel_balance_alert.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_tradingdesk.SuspendLayout();
            this.panel_tradingdesk_up.SuspendLayout();
            this.panel_tradingdesk_up_client.SuspendLayout();
            this.panel_tradingdesk_up_symbol.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_pending_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modify_pending_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_pending_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_remove_price_alert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_price_alert)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel24.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.panel_tradingdesk_down.SuspendLayout();
            this.panel_order2.SuspendLayout();
            this.panel_order1.SuspendLayout();
            this.panel_order_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order1_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order2_close)).BeginInit();
            this.panel_chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_view)).BeginInit();
            this.panel_details.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_notification_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_phone_number_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_money_difference_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_margin_alert_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_margin_call_save)).BeginInit();
            this.panel_login.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_show_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide_password)).BeginInit();
            this.panel19.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_start)).BeginInit();
            this.panel_settings.SuspendLayout();
            this.panel_pamm.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_start)).BeginInit();
            this.panel_pamm_master.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.panel_dashboard.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_start)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel_orders.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_start)).BeginInit();
            this.panel_history.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_history_130)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_history_180)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel_statement.SuspendLayout();
            this.panel_tradingdesk_new.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_view_3)).BeginInit();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_view_8)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel_statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel_administrator.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_clients.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.panel_head_1.SuspendLayout();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_spread_alert)).BeginInit();
            this.SuspendLayout();
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(125)))));
            this.All.Controls.Add(this.layout_main);
            this.All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All.Location = new System.Drawing.Point(4, 4);
            this.All.Name = "All";
            this.All.Padding = new System.Windows.Forms.Padding(1);
            this.All.Size = new System.Drawing.Size(1192, 792);
            this.All.TabIndex = 0;
            // 
            // layout_main
            // 
            this.layout_main.ColumnCount = 2;
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.layout_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_main.Controls.Add(this.panel_side, 0, 0);
            this.layout_main.Controls.Add(this.panel_main, 1, 0);
            this.layout_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_main.Location = new System.Drawing.Point(1, 1);
            this.layout_main.Margin = new System.Windows.Forms.Padding(0);
            this.layout_main.Name = "layout_main";
            this.layout_main.RowCount = 1;
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 794F));
            this.layout_main.Size = new System.Drawing.Size(1190, 790);
            this.layout_main.TabIndex = 2;
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panel_side.ColumnCount = 1;
            this.panel_side.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_side.Controls.Add(this.lab_prog_name, 0, 0);
            this.panel_side.Controls.Add(this.panel20, 0, 4);
            this.panel_side.Controls.Add(this.panel_tab, 0, 1);
            this.panel_side.Controls.Add(this.panel_middle, 0, 2);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Margin = new System.Windows.Forms.Padding(0);
            this.panel_side.Name = "panel_side";
            this.panel_side.RowCount = 5;
            this.panel_side.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panel_side.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.panel_side.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.panel_side.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_side.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.panel_side.Size = new System.Drawing.Size(200, 790);
            this.panel_side.TabIndex = 0;
            // 
            // lab_prog_name
            // 
            this.lab_prog_name.AutoSize = true;
            this.lab_prog_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.lab_prog_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_prog_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_prog_name.ForeColor = System.Drawing.Color.White;
            this.lab_prog_name.Location = new System.Drawing.Point(0, 0);
            this.lab_prog_name.Margin = new System.Windows.Forms.Padding(0);
            this.lab_prog_name.Name = "lab_prog_name";
            this.lab_prog_name.Size = new System.Drawing.Size(200, 60);
            this.lab_prog_name.TabIndex = 0;
            this.lab_prog_name.Text = "FX TRUST DASHBOARD";
            this.lab_prog_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.lab_version_release);
            this.panel20.Controls.Add(this.lab_broker_client);
            this.panel20.Controls.Add(this.lab_setting_phone);
            this.panel20.Controls.Add(this.lab_setting_margincall);
            this.panel20.Controls.Add(this.lab_setting_moneyshfit);
            this.panel20.Controls.Add(this.btn_pdf);
            this.panel20.Controls.Add(this.btn_setting_phone);
            this.panel20.Controls.Add(this.btn_setting_margincall);
            this.panel20.Controls.Add(this.btn_setting_moneyshfit);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(0, 590);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(200, 200);
            this.panel20.TabIndex = 4;
            // 
            // lab_version_release
            // 
            this.lab_version_release.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_version_release.ForeColor = System.Drawing.Color.White;
            this.lab_version_release.Location = new System.Drawing.Point(33, 126);
            this.lab_version_release.Name = "lab_version_release";
            this.lab_version_release.Size = new System.Drawing.Size(152, 20);
            this.lab_version_release.TabIndex = 3;
            this.lab_version_release.Text = "Version 1 Release 6";
            this.lab_version_release.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_broker_client
            // 
            this.lab_broker_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_broker_client.ForeColor = System.Drawing.Color.White;
            this.lab_broker_client.Location = new System.Drawing.Point(33, 103);
            this.lab_broker_client.Margin = new System.Windows.Forms.Padding(0);
            this.lab_broker_client.Name = "lab_broker_client";
            this.lab_broker_client.Size = new System.Drawing.Size(120, 20);
            this.lab_broker_client.TabIndex = 3;
            this.lab_broker_client.Text = "BROKER";
            this.lab_broker_client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_setting_phone
            // 
            this.lab_setting_phone.BackColor = System.Drawing.Color.Red;
            this.lab_setting_phone.Location = new System.Drawing.Point(19, 67);
            this.lab_setting_phone.Margin = new System.Windows.Forms.Padding(0);
            this.lab_setting_phone.Name = "lab_setting_phone";
            this.lab_setting_phone.Size = new System.Drawing.Size(10, 25);
            this.lab_setting_phone.TabIndex = 2;
            // 
            // lab_setting_margincall
            // 
            this.lab_setting_margincall.BackColor = System.Drawing.Color.Red;
            this.lab_setting_margincall.Location = new System.Drawing.Point(19, 40);
            this.lab_setting_margincall.Margin = new System.Windows.Forms.Padding(0);
            this.lab_setting_margincall.Name = "lab_setting_margincall";
            this.lab_setting_margincall.Size = new System.Drawing.Size(10, 25);
            this.lab_setting_margincall.TabIndex = 2;
            // 
            // lab_setting_moneyshfit
            // 
            this.lab_setting_moneyshfit.BackColor = System.Drawing.Color.Red;
            this.lab_setting_moneyshfit.Location = new System.Drawing.Point(19, 13);
            this.lab_setting_moneyshfit.Margin = new System.Windows.Forms.Padding(0);
            this.lab_setting_moneyshfit.Name = "lab_setting_moneyshfit";
            this.lab_setting_moneyshfit.Size = new System.Drawing.Size(10, 25);
            this.lab_setting_moneyshfit.TabIndex = 2;
            // 
            // btn_pdf
            // 
            this.btn_pdf.Activecolor = System.Drawing.Color.Transparent;
            this.btn_pdf.BackColor = System.Drawing.Color.Transparent;
            this.btn_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pdf.BorderRadius = 0;
            this.btn_pdf.ButtonText = "MANUAL PDF";
            this.btn_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pdf.DisabledColor = System.Drawing.Color.Gray;
            this.btn_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_pdf.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_pdf.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_pdf.Iconimage")));
            this.btn_pdf.Iconimage_right = null;
            this.btn_pdf.Iconimage_right_Selected = null;
            this.btn_pdf.Iconimage_Selected = null;
            this.btn_pdf.IconMarginLeft = 0;
            this.btn_pdf.IconMarginRight = 0;
            this.btn_pdf.IconRightVisible = true;
            this.btn_pdf.IconRightZoom = 0D;
            this.btn_pdf.IconVisible = false;
            this.btn_pdf.IconZoom = 90D;
            this.btn_pdf.IsTab = true;
            this.btn_pdf.Location = new System.Drawing.Point(33, 149);
            this.btn_pdf.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_pdf.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_pdf.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_pdf.selected = false;
            this.btn_pdf.Size = new System.Drawing.Size(160, 24);
            this.btn_pdf.TabIndex = 1;
            this.btn_pdf.Text = "MANUAL PDF";
            this.btn_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pdf.Textcolor = System.Drawing.Color.White;
            this.btn_pdf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // btn_setting_phone
            // 
            this.btn_setting_phone.Activecolor = System.Drawing.Color.Transparent;
            this.btn_setting_phone.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting_phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setting_phone.BorderRadius = 0;
            this.btn_setting_phone.ButtonText = "PHONE NOTIFY ON/OFF";
            this.btn_setting_phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting_phone.DisabledColor = System.Drawing.Color.Gray;
            this.btn_setting_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_setting_phone.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_setting_phone.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_setting_phone.Iconimage")));
            this.btn_setting_phone.Iconimage_right = null;
            this.btn_setting_phone.Iconimage_right_Selected = null;
            this.btn_setting_phone.Iconimage_Selected = null;
            this.btn_setting_phone.IconMarginLeft = 0;
            this.btn_setting_phone.IconMarginRight = 0;
            this.btn_setting_phone.IconRightVisible = true;
            this.btn_setting_phone.IconRightZoom = 0D;
            this.btn_setting_phone.IconVisible = false;
            this.btn_setting_phone.IconZoom = 90D;
            this.btn_setting_phone.IsTab = true;
            this.btn_setting_phone.Location = new System.Drawing.Point(33, 67);
            this.btn_setting_phone.Margin = new System.Windows.Forms.Padding(0);
            this.btn_setting_phone.Name = "btn_setting_phone";
            this.btn_setting_phone.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_setting_phone.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_setting_phone.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_setting_phone.selected = false;
            this.btn_setting_phone.Size = new System.Drawing.Size(160, 24);
            this.btn_setting_phone.TabIndex = 1;
            this.btn_setting_phone.Text = "PHONE NOTIFY ON/OFF";
            this.btn_setting_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting_phone.Textcolor = System.Drawing.Color.White;
            this.btn_setting_phone.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setting_phone.Click += new System.EventHandler(this.btn_setting_phone_Click);
            // 
            // btn_setting_margincall
            // 
            this.btn_setting_margincall.Activecolor = System.Drawing.Color.Transparent;
            this.btn_setting_margincall.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting_margincall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setting_margincall.BorderRadius = 0;
            this.btn_setting_margincall.ButtonText = "MARGIN CALL ON/OFF";
            this.btn_setting_margincall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting_margincall.DisabledColor = System.Drawing.Color.Gray;
            this.btn_setting_margincall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_setting_margincall.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_setting_margincall.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_setting_margincall.Iconimage")));
            this.btn_setting_margincall.Iconimage_right = null;
            this.btn_setting_margincall.Iconimage_right_Selected = null;
            this.btn_setting_margincall.Iconimage_Selected = null;
            this.btn_setting_margincall.IconMarginLeft = 0;
            this.btn_setting_margincall.IconMarginRight = 0;
            this.btn_setting_margincall.IconRightVisible = true;
            this.btn_setting_margincall.IconRightZoom = 0D;
            this.btn_setting_margincall.IconVisible = false;
            this.btn_setting_margincall.IconZoom = 90D;
            this.btn_setting_margincall.IsTab = true;
            this.btn_setting_margincall.Location = new System.Drawing.Point(33, 40);
            this.btn_setting_margincall.Margin = new System.Windows.Forms.Padding(0);
            this.btn_setting_margincall.Name = "btn_setting_margincall";
            this.btn_setting_margincall.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_setting_margincall.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_setting_margincall.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_setting_margincall.selected = false;
            this.btn_setting_margincall.Size = new System.Drawing.Size(160, 24);
            this.btn_setting_margincall.TabIndex = 1;
            this.btn_setting_margincall.Text = "MARGIN CALL ON/OFF";
            this.btn_setting_margincall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting_margincall.Textcolor = System.Drawing.Color.White;
            this.btn_setting_margincall.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setting_margincall.Click += new System.EventHandler(this.btn_setting_margincall_Click);
            // 
            // btn_setting_moneyshfit
            // 
            this.btn_setting_moneyshfit.Activecolor = System.Drawing.Color.Transparent;
            this.btn_setting_moneyshfit.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting_moneyshfit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setting_moneyshfit.BorderRadius = 0;
            this.btn_setting_moneyshfit.ButtonText = "MONEY SHIFT ON/OFF";
            this.btn_setting_moneyshfit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting_moneyshfit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_setting_moneyshfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_setting_moneyshfit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_setting_moneyshfit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_setting_moneyshfit.Iconimage")));
            this.btn_setting_moneyshfit.Iconimage_right = null;
            this.btn_setting_moneyshfit.Iconimage_right_Selected = null;
            this.btn_setting_moneyshfit.Iconimage_Selected = null;
            this.btn_setting_moneyshfit.IconMarginLeft = 0;
            this.btn_setting_moneyshfit.IconMarginRight = 0;
            this.btn_setting_moneyshfit.IconRightVisible = true;
            this.btn_setting_moneyshfit.IconRightZoom = 0D;
            this.btn_setting_moneyshfit.IconVisible = false;
            this.btn_setting_moneyshfit.IconZoom = 90D;
            this.btn_setting_moneyshfit.IsTab = true;
            this.btn_setting_moneyshfit.Location = new System.Drawing.Point(33, 13);
            this.btn_setting_moneyshfit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_setting_moneyshfit.Name = "btn_setting_moneyshfit";
            this.btn_setting_moneyshfit.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_setting_moneyshfit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_setting_moneyshfit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_setting_moneyshfit.selected = false;
            this.btn_setting_moneyshfit.Size = new System.Drawing.Size(160, 24);
            this.btn_setting_moneyshfit.TabIndex = 1;
            this.btn_setting_moneyshfit.Text = "MONEY SHIFT ON/OFF";
            this.btn_setting_moneyshfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting_moneyshfit.Textcolor = System.Drawing.Color.White;
            this.btn_setting_moneyshfit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_setting_moneyshfit.Click += new System.EventHandler(this.btn_setting_moneyshfit_Click);
            // 
            // panel_tab
            // 
            this.panel_tab.Controls.Add(this.btn_expand);
            this.panel_tab.Controls.Add(this.nav_panel);
            this.panel_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tab.Location = new System.Drawing.Point(0, 60);
            this.panel_tab.Margin = new System.Windows.Forms.Padding(0);
            this.panel_tab.Name = "panel_tab";
            this.panel_tab.Size = new System.Drawing.Size(200, 210);
            this.panel_tab.TabIndex = 1;
            // 
            // btn_expand
            // 
            this.btn_expand.BackColor = System.Drawing.Color.Transparent;
            this.btn_expand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_expand.FlatAppearance.BorderSize = 0;
            this.btn_expand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_expand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expand.ForeColor = System.Drawing.Color.White;
            this.btn_expand.Location = new System.Drawing.Point(5, 29);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(17, 24);
            this.btn_expand.TabIndex = 2;
            this.btn_expand.Text = "+";
            this.btn_expand.UseVisualStyleBackColor = false;
            this.btn_expand.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // nav_panel
            // 
            this.nav_panel.Controls.Add(this.bunifuFlatButton2);
            this.nav_panel.Controls.Add(this.nav_login);
            this.nav_panel.Controls.Add(this.nav_dashboard);
            this.nav_panel.Controls.Add(this.nav_clients);
            this.nav_panel.Controls.Add(this.nav_details);
            this.nav_panel.Controls.Add(this.nav_orders);
            this.nav_panel.Controls.Add(this.nav_tradingdesk);
            this.nav_panel.Controls.Add(this.nav_pamm);
            this.nav_panel.Controls.Add(this.nav_administrator);
            this.nav_panel.Controls.Add(this.nav_statistics);
            this.nav_panel.Controls.Add(this.nav_history);
            this.nav_panel.Controls.Add(this.nav_statement);
            this.nav_panel.Controls.Add(this.nav_settings);
            this.nav_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nav_panel.Location = new System.Drawing.Point(25, 5);
            this.nav_panel.Margin = new System.Windows.Forms.Padding(0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(175, 205);
            this.nav_panel.TabIndex = 2;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "LICENSE";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(181, 0);
            this.bunifuFlatButton2.TabIndex = 6;
            this.bunifuFlatButton2.Text = "LICENSE";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.nav_administrator_Click);
            // 
            // nav_login
            // 
            this.nav_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_login.BorderRadius = 0;
            this.nav_login.ButtonText = " LOGIN";
            this.nav_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_login.DisabledColor = System.Drawing.Color.Gray;
            this.nav_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_login.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_login.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_login.Iconimage")));
            this.nav_login.Iconimage_right = null;
            this.nav_login.Iconimage_right_Selected = null;
            this.nav_login.Iconimage_Selected = null;
            this.nav_login.IconMarginLeft = 0;
            this.nav_login.IconMarginRight = 0;
            this.nav_login.IconRightVisible = true;
            this.nav_login.IconRightZoom = 0D;
            this.nav_login.IconVisible = false;
            this.nav_login.IconZoom = 90D;
            this.nav_login.IsTab = true;
            this.nav_login.Location = new System.Drawing.Point(0, 0);
            this.nav_login.Margin = new System.Windows.Forms.Padding(0);
            this.nav_login.Name = "nav_login";
            this.nav_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_login.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_login.selected = true;
            this.nav_login.Size = new System.Drawing.Size(181, 25);
            this.nav_login.TabIndex = 2;
            this.nav_login.Text = " LOGIN";
            this.nav_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_login.Textcolor = System.Drawing.Color.White;
            this.nav_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_login.Click += new System.EventHandler(this.nav_login_Click);
            // 
            // nav_dashboard
            // 
            this.nav_dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_dashboard.BorderRadius = 0;
            this.nav_dashboard.ButtonText = " DASHBOARD";
            this.nav_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_dashboard.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_dashboard.Iconimage")));
            this.nav_dashboard.Iconimage_right = null;
            this.nav_dashboard.Iconimage_right_Selected = null;
            this.nav_dashboard.Iconimage_Selected = null;
            this.nav_dashboard.IconMarginLeft = 0;
            this.nav_dashboard.IconMarginRight = 0;
            this.nav_dashboard.IconRightVisible = true;
            this.nav_dashboard.IconRightZoom = 0D;
            this.nav_dashboard.IconVisible = false;
            this.nav_dashboard.IconZoom = 90D;
            this.nav_dashboard.IsTab = true;
            this.nav_dashboard.Location = new System.Drawing.Point(0, 25);
            this.nav_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.nav_dashboard.Name = "nav_dashboard";
            this.nav_dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_dashboard.selected = false;
            this.nav_dashboard.Size = new System.Drawing.Size(181, 25);
            this.nav_dashboard.TabIndex = 3;
            this.nav_dashboard.Text = " DASHBOARD";
            this.nav_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_dashboard.Textcolor = System.Drawing.Color.White;
            this.nav_dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_dashboard.Click += new System.EventHandler(this.nav_dashboard_Click);
            this.nav_dashboard.DoubleClick += new System.EventHandler(this.btn_expand_Click);
            // 
            // nav_clients
            // 
            this.nav_clients.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_clients.BorderRadius = 0;
            this.nav_clients.ButtonText = " CLIENTS";
            this.nav_clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_clients.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_clients.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_clients.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_clients.Iconimage")));
            this.nav_clients.Iconimage_right = null;
            this.nav_clients.Iconimage_right_Selected = null;
            this.nav_clients.Iconimage_Selected = null;
            this.nav_clients.IconMarginLeft = 0;
            this.nav_clients.IconMarginRight = 0;
            this.nav_clients.IconRightVisible = true;
            this.nav_clients.IconRightZoom = 0D;
            this.nav_clients.IconVisible = false;
            this.nav_clients.IconZoom = 90D;
            this.nav_clients.IsTab = true;
            this.nav_clients.Location = new System.Drawing.Point(0, 50);
            this.nav_clients.Margin = new System.Windows.Forms.Padding(0);
            this.nav_clients.Name = "nav_clients";
            this.nav_clients.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_clients.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_clients.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_clients.selected = false;
            this.nav_clients.Size = new System.Drawing.Size(181, 0);
            this.nav_clients.TabIndex = 3;
            this.nav_clients.Text = " CLIENTS";
            this.nav_clients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_clients.Textcolor = System.Drawing.Color.White;
            this.nav_clients.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_clients.Click += new System.EventHandler(this.nav_clients_Click);
            this.nav_clients.DoubleClick += new System.EventHandler(this.btn_expand_Click);
            // 
            // nav_details
            // 
            this.nav_details.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_details.BorderRadius = 0;
            this.nav_details.ButtonText = "  DETAILS";
            this.nav_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_details.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_details.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_details.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_details.Iconimage")));
            this.nav_details.Iconimage_right = null;
            this.nav_details.Iconimage_right_Selected = null;
            this.nav_details.Iconimage_Selected = null;
            this.nav_details.IconMarginLeft = 0;
            this.nav_details.IconMarginRight = 0;
            this.nav_details.IconRightVisible = true;
            this.nav_details.IconRightZoom = 0D;
            this.nav_details.IconVisible = false;
            this.nav_details.IconZoom = 90D;
            this.nav_details.IsTab = true;
            this.nav_details.Location = new System.Drawing.Point(20, 50);
            this.nav_details.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.nav_details.Name = "nav_details";
            this.nav_details.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_details.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_details.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_details.selected = false;
            this.nav_details.Size = new System.Drawing.Size(181, 0);
            this.nav_details.TabIndex = 4;
            this.nav_details.Text = "  DETAILS";
            this.nav_details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_details.Textcolor = System.Drawing.Color.White;
            this.nav_details.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_details.Click += new System.EventHandler(this.nav_details_Click);
            // 
            // nav_orders
            // 
            this.nav_orders.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_orders.BorderRadius = 0;
            this.nav_orders.ButtonText = " ORDERS";
            this.nav_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_orders.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_orders.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_orders.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_orders.Iconimage")));
            this.nav_orders.Iconimage_right = null;
            this.nav_orders.Iconimage_right_Selected = null;
            this.nav_orders.Iconimage_Selected = null;
            this.nav_orders.IconMarginLeft = 0;
            this.nav_orders.IconMarginRight = 0;
            this.nav_orders.IconRightVisible = true;
            this.nav_orders.IconRightZoom = 0D;
            this.nav_orders.IconVisible = false;
            this.nav_orders.IconZoom = 90D;
            this.nav_orders.IsTab = true;
            this.nav_orders.Location = new System.Drawing.Point(20, 50);
            this.nav_orders.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.nav_orders.Name = "nav_orders";
            this.nav_orders.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_orders.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_orders.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_orders.selected = false;
            this.nav_orders.Size = new System.Drawing.Size(181, 25);
            this.nav_orders.TabIndex = 5;
            this.nav_orders.Text = " ORDERS";
            this.nav_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_orders.Textcolor = System.Drawing.Color.White;
            this.nav_orders.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_orders.Click += new System.EventHandler(this.nav_orders_Click);
            // 
            // nav_tradingdesk
            // 
            this.nav_tradingdesk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_tradingdesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_tradingdesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_tradingdesk.BorderRadius = 0;
            this.nav_tradingdesk.ButtonText = " TRADING DESK";
            this.nav_tradingdesk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_tradingdesk.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_tradingdesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_tradingdesk.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_tradingdesk.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_tradingdesk.Iconimage")));
            this.nav_tradingdesk.Iconimage_right = null;
            this.nav_tradingdesk.Iconimage_right_Selected = null;
            this.nav_tradingdesk.Iconimage_Selected = null;
            this.nav_tradingdesk.IconMarginLeft = 0;
            this.nav_tradingdesk.IconMarginRight = 0;
            this.nav_tradingdesk.IconRightVisible = true;
            this.nav_tradingdesk.IconRightZoom = 0D;
            this.nav_tradingdesk.IconVisible = false;
            this.nav_tradingdesk.IconZoom = 90D;
            this.nav_tradingdesk.IsTab = true;
            this.nav_tradingdesk.Location = new System.Drawing.Point(20, 75);
            this.nav_tradingdesk.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.nav_tradingdesk.Name = "nav_tradingdesk";
            this.nav_tradingdesk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_tradingdesk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_tradingdesk.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_tradingdesk.selected = false;
            this.nav_tradingdesk.Size = new System.Drawing.Size(181, 25);
            this.nav_tradingdesk.TabIndex = 6;
            this.nav_tradingdesk.Text = " TRADING DESK";
            this.nav_tradingdesk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_tradingdesk.Textcolor = System.Drawing.Color.White;
            this.nav_tradingdesk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_tradingdesk.Click += new System.EventHandler(this.nav_tradingdesk_Click);
            // 
            // nav_pamm
            // 
            this.nav_pamm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_pamm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_pamm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_pamm.BorderRadius = 0;
            this.nav_pamm.ButtonText = " PAMM";
            this.nav_pamm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_pamm.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_pamm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_pamm.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_pamm.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_pamm.Iconimage")));
            this.nav_pamm.Iconimage_right = null;
            this.nav_pamm.Iconimage_right_Selected = null;
            this.nav_pamm.Iconimage_Selected = null;
            this.nav_pamm.IconMarginLeft = 0;
            this.nav_pamm.IconMarginRight = 0;
            this.nav_pamm.IconRightVisible = true;
            this.nav_pamm.IconRightZoom = 0D;
            this.nav_pamm.IconVisible = false;
            this.nav_pamm.IconZoom = 90D;
            this.nav_pamm.IsTab = true;
            this.nav_pamm.Location = new System.Drawing.Point(20, 100);
            this.nav_pamm.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.nav_pamm.Name = "nav_pamm";
            this.nav_pamm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_pamm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_pamm.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_pamm.selected = false;
            this.nav_pamm.Size = new System.Drawing.Size(181, 25);
            this.nav_pamm.TabIndex = 6;
            this.nav_pamm.Text = " PAMM";
            this.nav_pamm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_pamm.Textcolor = System.Drawing.Color.White;
            this.nav_pamm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_pamm.Click += new System.EventHandler(this.nav_pamm_Click);
            // 
            // nav_administrator
            // 
            this.nav_administrator.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_administrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_administrator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_administrator.BorderRadius = 0;
            this.nav_administrator.ButtonText = " ADMINISTRATOR";
            this.nav_administrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_administrator.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_administrator.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_administrator.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_administrator.Iconimage")));
            this.nav_administrator.Iconimage_right = null;
            this.nav_administrator.Iconimage_right_Selected = null;
            this.nav_administrator.Iconimage_Selected = null;
            this.nav_administrator.IconMarginLeft = 0;
            this.nav_administrator.IconMarginRight = 0;
            this.nav_administrator.IconRightVisible = true;
            this.nav_administrator.IconRightZoom = 0D;
            this.nav_administrator.IconVisible = false;
            this.nav_administrator.IconZoom = 90D;
            this.nav_administrator.IsTab = true;
            this.nav_administrator.Location = new System.Drawing.Point(0, 125);
            this.nav_administrator.Margin = new System.Windows.Forms.Padding(0);
            this.nav_administrator.Name = "nav_administrator";
            this.nav_administrator.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_administrator.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_administrator.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_administrator.selected = false;
            this.nav_administrator.Size = new System.Drawing.Size(181, 0);
            this.nav_administrator.TabIndex = 6;
            this.nav_administrator.Text = " ADMINISTRATOR";
            this.nav_administrator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_administrator.Textcolor = System.Drawing.Color.White;
            this.nav_administrator.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_administrator.Click += new System.EventHandler(this.nav_administrator_Click);
            // 
            // nav_statistics
            // 
            this.nav_statistics.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_statistics.BorderRadius = 0;
            this.nav_statistics.ButtonText = " STATISTICS";
            this.nav_statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_statistics.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_statistics.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_statistics.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_statistics.Iconimage")));
            this.nav_statistics.Iconimage_right = null;
            this.nav_statistics.Iconimage_right_Selected = null;
            this.nav_statistics.Iconimage_Selected = null;
            this.nav_statistics.IconMarginLeft = 0;
            this.nav_statistics.IconMarginRight = 0;
            this.nav_statistics.IconRightVisible = true;
            this.nav_statistics.IconRightZoom = 0D;
            this.nav_statistics.IconVisible = false;
            this.nav_statistics.IconZoom = 90D;
            this.nav_statistics.IsTab = true;
            this.nav_statistics.Location = new System.Drawing.Point(0, 125);
            this.nav_statistics.Margin = new System.Windows.Forms.Padding(0);
            this.nav_statistics.Name = "nav_statistics";
            this.nav_statistics.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_statistics.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_statistics.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_statistics.selected = false;
            this.nav_statistics.Size = new System.Drawing.Size(181, 0);
            this.nav_statistics.TabIndex = 6;
            this.nav_statistics.Text = " STATISTICS";
            this.nav_statistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_statistics.Textcolor = System.Drawing.Color.White;
            this.nav_statistics.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_statistics.Click += new System.EventHandler(this.nav_statistics_Click);
            // 
            // nav_history
            // 
            this.nav_history.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_history.BorderRadius = 0;
            this.nav_history.ButtonText = " HISTORY";
            this.nav_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_history.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_history.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_history.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_history.Iconimage")));
            this.nav_history.Iconimage_right = null;
            this.nav_history.Iconimage_right_Selected = null;
            this.nav_history.Iconimage_Selected = null;
            this.nav_history.IconMarginLeft = 0;
            this.nav_history.IconMarginRight = 0;
            this.nav_history.IconRightVisible = true;
            this.nav_history.IconRightZoom = 0D;
            this.nav_history.IconVisible = false;
            this.nav_history.IconZoom = 90D;
            this.nav_history.IsTab = true;
            this.nav_history.Location = new System.Drawing.Point(20, 125);
            this.nav_history.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.nav_history.Name = "nav_history";
            this.nav_history.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_history.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_history.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_history.selected = false;
            this.nav_history.Size = new System.Drawing.Size(181, 25);
            this.nav_history.TabIndex = 6;
            this.nav_history.Text = " HISTORY";
            this.nav_history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_history.Textcolor = System.Drawing.Color.White;
            this.nav_history.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_history.Click += new System.EventHandler(this.nav_history_Click);
            // 
            // nav_statement
            // 
            this.nav_statement.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_statement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_statement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_statement.BorderRadius = 0;
            this.nav_statement.ButtonText = " STATEMENT";
            this.nav_statement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_statement.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_statement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_statement.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_statement.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_statement.Iconimage")));
            this.nav_statement.Iconimage_right = null;
            this.nav_statement.Iconimage_right_Selected = null;
            this.nav_statement.Iconimage_Selected = null;
            this.nav_statement.IconMarginLeft = 0;
            this.nav_statement.IconMarginRight = 0;
            this.nav_statement.IconRightVisible = true;
            this.nav_statement.IconRightZoom = 0D;
            this.nav_statement.IconVisible = false;
            this.nav_statement.IconZoom = 90D;
            this.nav_statement.IsTab = true;
            this.nav_statement.Location = new System.Drawing.Point(20, 150);
            this.nav_statement.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.nav_statement.Name = "nav_statement";
            this.nav_statement.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_statement.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_statement.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_statement.selected = false;
            this.nav_statement.Size = new System.Drawing.Size(181, 25);
            this.nav_statement.TabIndex = 7;
            this.nav_statement.Text = " STATEMENT";
            this.nav_statement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_statement.Textcolor = System.Drawing.Color.White;
            this.nav_statement.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_statement.Click += new System.EventHandler(this.nav_statement_Click);
            // 
            // nav_settings
            // 
            this.nav_settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.nav_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nav_settings.BorderRadius = 0;
            this.nav_settings.ButtonText = " SETTINGS";
            this.nav_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nav_settings.DisabledColor = System.Drawing.Color.Transparent;
            this.nav_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nav_settings.Iconcolor = System.Drawing.Color.Transparent;
            this.nav_settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("nav_settings.Iconimage")));
            this.nav_settings.Iconimage_right = null;
            this.nav_settings.Iconimage_right_Selected = null;
            this.nav_settings.Iconimage_Selected = null;
            this.nav_settings.IconMarginLeft = 0;
            this.nav_settings.IconMarginRight = 0;
            this.nav_settings.IconRightVisible = true;
            this.nav_settings.IconRightZoom = 0D;
            this.nav_settings.IconVisible = false;
            this.nav_settings.IconZoom = 90D;
            this.nav_settings.IsTab = true;
            this.nav_settings.Location = new System.Drawing.Point(0, 175);
            this.nav_settings.Margin = new System.Windows.Forms.Padding(0);
            this.nav_settings.Name = "nav_settings";
            this.nav_settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.nav_settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.nav_settings.OnHoverTextColor = System.Drawing.Color.White;
            this.nav_settings.selected = false;
            this.nav_settings.Size = new System.Drawing.Size(181, 25);
            this.nav_settings.TabIndex = 6;
            this.nav_settings.Text = " SETTINGS";
            this.nav_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nav_settings.Textcolor = System.Drawing.Color.White;
            this.nav_settings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_settings.Click += new System.EventHandler(this.nav_settings_Click);
            // 
            // panel_middle
            // 
            this.panel_middle.Controls.Add(this.panel_tf_button);
            this.panel_middle.Controls.Add(this.panel_balance_alert);
            this.panel_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_middle.Location = new System.Drawing.Point(0, 270);
            this.panel_middle.Margin = new System.Windows.Forms.Padding(0);
            this.panel_middle.Name = "panel_middle";
            this.panel_middle.Size = new System.Drawing.Size(200, 164);
            this.panel_middle.TabIndex = 5;
            // 
            // panel_tf_button
            // 
            this.panel_tf_button.Controls.Add(this.btn_panel);
            this.panel_tf_button.Location = new System.Drawing.Point(0, 0);
            this.panel_tf_button.Name = "panel_tf_button";
            this.panel_tf_button.Size = new System.Drawing.Size(200, 165);
            this.panel_tf_button.TabIndex = 2;
            // 
            // btn_panel
            // 
            this.btn_panel.Controls.Add(this.btn_plus);
            this.btn_panel.Controls.Add(this.btn_minus);
            this.btn_panel.Controls.Add(this.btn_m1);
            this.btn_panel.Controls.Add(this.btn_m5);
            this.btn_panel.Controls.Add(this.btn_m15);
            this.btn_panel.Controls.Add(this.btn_m30);
            this.btn_panel.Controls.Add(this.btn_h1);
            this.btn_panel.Controls.Add(this.btn_h4);
            this.btn_panel.Controls.Add(this.btn_d1);
            this.btn_panel.Controls.Add(this.btn_w1);
            this.btn_panel.Controls.Add(this.lab_spread);
            this.btn_panel.Controls.Add(this.lab_swap);
            this.btn_panel.Controls.Add(this.lab_breakeven);
            this.btn_panel.Controls.Add(this.lab_spread_alert);
            this.btn_panel.Controls.Add(this.num_spread_alert);
            this.btn_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_panel.Location = new System.Drawing.Point(28, 0);
            this.btn_panel.Name = "btn_panel";
            this.btn_panel.Size = new System.Drawing.Size(172, 165);
            this.btn_panel.TabIndex = 0;
            // 
            // btn_plus
            // 
            this.btn_plus.Activecolor = System.Drawing.Color.Transparent;
            this.btn_plus.BackColor = System.Drawing.Color.Transparent;
            this.btn_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_plus.BorderRadius = 0;
            this.btn_plus.ButtonText = "CHART +";
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.DisabledColor = System.Drawing.Color.Gray;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_plus.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_plus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_plus.Iconimage")));
            this.btn_plus.Iconimage_right = null;
            this.btn_plus.Iconimage_right_Selected = null;
            this.btn_plus.Iconimage_Selected = null;
            this.btn_plus.IconMarginLeft = 0;
            this.btn_plus.IconMarginRight = 0;
            this.btn_plus.IconRightVisible = true;
            this.btn_plus.IconRightZoom = 0D;
            this.btn_plus.IconVisible = false;
            this.btn_plus.IconZoom = 90D;
            this.btn_plus.IsTab = true;
            this.btn_plus.Location = new System.Drawing.Point(0, 0);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_plus.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_plus.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_plus.selected = false;
            this.btn_plus.Size = new System.Drawing.Size(80, 20);
            this.btn_plus.TabIndex = 0;
            this.btn_plus.Text = "CHART +";
            this.btn_plus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_plus.Textcolor = System.Drawing.Color.White;
            this.btn_plus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Activecolor = System.Drawing.Color.Transparent;
            this.btn_minus.BackColor = System.Drawing.Color.Transparent;
            this.btn_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minus.BorderRadius = 0;
            this.btn_minus.ButtonText = "CHART -";
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.DisabledColor = System.Drawing.Color.Gray;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_minus.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_minus.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_minus.Iconimage")));
            this.btn_minus.Iconimage_right = null;
            this.btn_minus.Iconimage_right_Selected = null;
            this.btn_minus.Iconimage_Selected = null;
            this.btn_minus.IconMarginLeft = 0;
            this.btn_minus.IconMarginRight = 0;
            this.btn_minus.IconRightVisible = true;
            this.btn_minus.IconRightZoom = 0D;
            this.btn_minus.IconVisible = false;
            this.btn_minus.IconZoom = 90D;
            this.btn_minus.IsTab = true;
            this.btn_minus.Location = new System.Drawing.Point(80, 0);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_minus.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_minus.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_minus.selected = false;
            this.btn_minus.Size = new System.Drawing.Size(80, 20);
            this.btn_minus.TabIndex = 0;
            this.btn_minus.Text = "CHART -";
            this.btn_minus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_minus.Textcolor = System.Drawing.Color.White;
            this.btn_minus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_m1
            // 
            this.btn_m1.Activecolor = System.Drawing.Color.Transparent;
            this.btn_m1.BackColor = System.Drawing.Color.Transparent;
            this.btn_m1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_m1.BorderRadius = 0;
            this.btn_m1.ButtonText = "M1";
            this.btn_m1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_m1.DisabledColor = System.Drawing.Color.Gray;
            this.btn_m1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_m1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_m1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_m1.Iconimage")));
            this.btn_m1.Iconimage_right = null;
            this.btn_m1.Iconimage_right_Selected = null;
            this.btn_m1.Iconimage_Selected = null;
            this.btn_m1.IconMarginLeft = 0;
            this.btn_m1.IconMarginRight = 0;
            this.btn_m1.IconRightVisible = true;
            this.btn_m1.IconRightZoom = 0D;
            this.btn_m1.IconVisible = false;
            this.btn_m1.IconZoom = 90D;
            this.btn_m1.IsTab = true;
            this.btn_m1.Location = new System.Drawing.Point(0, 20);
            this.btn_m1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_m1.Name = "btn_m1";
            this.btn_m1.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_m1.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_m1.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_m1.selected = false;
            this.btn_m1.Size = new System.Drawing.Size(40, 20);
            this.btn_m1.TabIndex = 0;
            this.btn_m1.Text = "M1";
            this.btn_m1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_m1.Textcolor = System.Drawing.Color.White;
            this.btn_m1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m1.Click += new System.EventHandler(this.btn_m1_Click);
            // 
            // btn_m5
            // 
            this.btn_m5.Activecolor = System.Drawing.Color.Transparent;
            this.btn_m5.BackColor = System.Drawing.Color.Transparent;
            this.btn_m5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_m5.BorderRadius = 0;
            this.btn_m5.ButtonText = "M5";
            this.btn_m5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_m5.DisabledColor = System.Drawing.Color.Gray;
            this.btn_m5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_m5.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_m5.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_m5.Iconimage")));
            this.btn_m5.Iconimage_right = null;
            this.btn_m5.Iconimage_right_Selected = null;
            this.btn_m5.Iconimage_Selected = null;
            this.btn_m5.IconMarginLeft = 0;
            this.btn_m5.IconMarginRight = 0;
            this.btn_m5.IconRightVisible = true;
            this.btn_m5.IconRightZoom = 0D;
            this.btn_m5.IconVisible = false;
            this.btn_m5.IconZoom = 90D;
            this.btn_m5.IsTab = true;
            this.btn_m5.Location = new System.Drawing.Point(40, 20);
            this.btn_m5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_m5.Name = "btn_m5";
            this.btn_m5.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_m5.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_m5.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_m5.selected = false;
            this.btn_m5.Size = new System.Drawing.Size(40, 20);
            this.btn_m5.TabIndex = 0;
            this.btn_m5.Text = "M5";
            this.btn_m5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_m5.Textcolor = System.Drawing.Color.White;
            this.btn_m5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m5.Click += new System.EventHandler(this.btn_m5_Click);
            // 
            // btn_m15
            // 
            this.btn_m15.Activecolor = System.Drawing.Color.Transparent;
            this.btn_m15.BackColor = System.Drawing.Color.Transparent;
            this.btn_m15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_m15.BorderRadius = 0;
            this.btn_m15.ButtonText = "M15";
            this.btn_m15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_m15.DisabledColor = System.Drawing.Color.Gray;
            this.btn_m15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_m15.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_m15.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_m15.Iconimage")));
            this.btn_m15.Iconimage_right = null;
            this.btn_m15.Iconimage_right_Selected = null;
            this.btn_m15.Iconimage_Selected = null;
            this.btn_m15.IconMarginLeft = 0;
            this.btn_m15.IconMarginRight = 0;
            this.btn_m15.IconRightVisible = true;
            this.btn_m15.IconRightZoom = 0D;
            this.btn_m15.IconVisible = false;
            this.btn_m15.IconZoom = 90D;
            this.btn_m15.IsTab = true;
            this.btn_m15.Location = new System.Drawing.Point(80, 20);
            this.btn_m15.Margin = new System.Windows.Forms.Padding(0);
            this.btn_m15.Name = "btn_m15";
            this.btn_m15.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_m15.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_m15.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_m15.selected = false;
            this.btn_m15.Size = new System.Drawing.Size(40, 20);
            this.btn_m15.TabIndex = 0;
            this.btn_m15.Text = "M15";
            this.btn_m15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_m15.Textcolor = System.Drawing.Color.White;
            this.btn_m15.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m15.Click += new System.EventHandler(this.btn_m15_Click);
            // 
            // btn_m30
            // 
            this.btn_m30.Activecolor = System.Drawing.Color.Transparent;
            this.btn_m30.BackColor = System.Drawing.Color.Transparent;
            this.btn_m30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_m30.BorderRadius = 0;
            this.btn_m30.ButtonText = "M30";
            this.btn_m30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_m30.DisabledColor = System.Drawing.Color.Gray;
            this.btn_m30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_m30.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_m30.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_m30.Iconimage")));
            this.btn_m30.Iconimage_right = null;
            this.btn_m30.Iconimage_right_Selected = null;
            this.btn_m30.Iconimage_Selected = null;
            this.btn_m30.IconMarginLeft = 0;
            this.btn_m30.IconMarginRight = 0;
            this.btn_m30.IconRightVisible = true;
            this.btn_m30.IconRightZoom = 0D;
            this.btn_m30.IconVisible = false;
            this.btn_m30.IconZoom = 90D;
            this.btn_m30.IsTab = true;
            this.btn_m30.Location = new System.Drawing.Point(120, 20);
            this.btn_m30.Margin = new System.Windows.Forms.Padding(0);
            this.btn_m30.Name = "btn_m30";
            this.btn_m30.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_m30.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_m30.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_m30.selected = false;
            this.btn_m30.Size = new System.Drawing.Size(40, 20);
            this.btn_m30.TabIndex = 0;
            this.btn_m30.Text = "M30";
            this.btn_m30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_m30.Textcolor = System.Drawing.Color.White;
            this.btn_m30.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m30.Click += new System.EventHandler(this.btn_m30_Click);
            // 
            // btn_h1
            // 
            this.btn_h1.Activecolor = System.Drawing.Color.Transparent;
            this.btn_h1.BackColor = System.Drawing.Color.Transparent;
            this.btn_h1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_h1.BorderRadius = 0;
            this.btn_h1.ButtonText = "H1";
            this.btn_h1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_h1.DisabledColor = System.Drawing.Color.Gray;
            this.btn_h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_h1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_h1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_h1.Iconimage")));
            this.btn_h1.Iconimage_right = null;
            this.btn_h1.Iconimage_right_Selected = null;
            this.btn_h1.Iconimage_Selected = null;
            this.btn_h1.IconMarginLeft = 0;
            this.btn_h1.IconMarginRight = 0;
            this.btn_h1.IconRightVisible = true;
            this.btn_h1.IconRightZoom = 0D;
            this.btn_h1.IconVisible = false;
            this.btn_h1.IconZoom = 90D;
            this.btn_h1.IsTab = true;
            this.btn_h1.Location = new System.Drawing.Point(0, 40);
            this.btn_h1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_h1.Name = "btn_h1";
            this.btn_h1.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_h1.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_h1.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_h1.selected = false;
            this.btn_h1.Size = new System.Drawing.Size(40, 20);
            this.btn_h1.TabIndex = 0;
            this.btn_h1.Text = "H1";
            this.btn_h1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_h1.Textcolor = System.Drawing.Color.White;
            this.btn_h1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_h1.Click += new System.EventHandler(this.btn_h1_Click);
            // 
            // btn_h4
            // 
            this.btn_h4.Activecolor = System.Drawing.Color.Transparent;
            this.btn_h4.BackColor = System.Drawing.Color.Transparent;
            this.btn_h4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_h4.BorderRadius = 0;
            this.btn_h4.ButtonText = "H4";
            this.btn_h4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_h4.DisabledColor = System.Drawing.Color.Gray;
            this.btn_h4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_h4.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_h4.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_h4.Iconimage")));
            this.btn_h4.Iconimage_right = null;
            this.btn_h4.Iconimage_right_Selected = null;
            this.btn_h4.Iconimage_Selected = null;
            this.btn_h4.IconMarginLeft = 0;
            this.btn_h4.IconMarginRight = 0;
            this.btn_h4.IconRightVisible = true;
            this.btn_h4.IconRightZoom = 0D;
            this.btn_h4.IconVisible = false;
            this.btn_h4.IconZoom = 90D;
            this.btn_h4.IsTab = true;
            this.btn_h4.Location = new System.Drawing.Point(40, 40);
            this.btn_h4.Margin = new System.Windows.Forms.Padding(0);
            this.btn_h4.Name = "btn_h4";
            this.btn_h4.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_h4.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_h4.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_h4.selected = false;
            this.btn_h4.Size = new System.Drawing.Size(40, 20);
            this.btn_h4.TabIndex = 0;
            this.btn_h4.Text = "H4";
            this.btn_h4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_h4.Textcolor = System.Drawing.Color.White;
            this.btn_h4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_h4.Click += new System.EventHandler(this.btn_h4_Click);
            // 
            // btn_d1
            // 
            this.btn_d1.Activecolor = System.Drawing.Color.Transparent;
            this.btn_d1.BackColor = System.Drawing.Color.Transparent;
            this.btn_d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_d1.BorderRadius = 0;
            this.btn_d1.ButtonText = "D1";
            this.btn_d1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_d1.DisabledColor = System.Drawing.Color.Gray;
            this.btn_d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_d1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_d1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_d1.Iconimage")));
            this.btn_d1.Iconimage_right = null;
            this.btn_d1.Iconimage_right_Selected = null;
            this.btn_d1.Iconimage_Selected = null;
            this.btn_d1.IconMarginLeft = 0;
            this.btn_d1.IconMarginRight = 0;
            this.btn_d1.IconRightVisible = true;
            this.btn_d1.IconRightZoom = 0D;
            this.btn_d1.IconVisible = false;
            this.btn_d1.IconZoom = 90D;
            this.btn_d1.IsTab = true;
            this.btn_d1.Location = new System.Drawing.Point(80, 40);
            this.btn_d1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_d1.Name = "btn_d1";
            this.btn_d1.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_d1.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_d1.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_d1.selected = false;
            this.btn_d1.Size = new System.Drawing.Size(40, 20);
            this.btn_d1.TabIndex = 0;
            this.btn_d1.Text = "D1";
            this.btn_d1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_d1.Textcolor = System.Drawing.Color.White;
            this.btn_d1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d1.Click += new System.EventHandler(this.btn_d1_Click);
            // 
            // btn_w1
            // 
            this.btn_w1.Activecolor = System.Drawing.Color.Transparent;
            this.btn_w1.BackColor = System.Drawing.Color.Transparent;
            this.btn_w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_w1.BorderRadius = 0;
            this.btn_w1.ButtonText = "W1";
            this.btn_w1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_w1.DisabledColor = System.Drawing.Color.Gray;
            this.btn_w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_w1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_w1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_w1.Iconimage")));
            this.btn_w1.Iconimage_right = null;
            this.btn_w1.Iconimage_right_Selected = null;
            this.btn_w1.Iconimage_Selected = null;
            this.btn_w1.IconMarginLeft = 0;
            this.btn_w1.IconMarginRight = 0;
            this.btn_w1.IconRightVisible = true;
            this.btn_w1.IconRightZoom = 0D;
            this.btn_w1.IconVisible = false;
            this.btn_w1.IconZoom = 90D;
            this.btn_w1.IsTab = true;
            this.btn_w1.Location = new System.Drawing.Point(120, 40);
            this.btn_w1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_w1.Name = "btn_w1";
            this.btn_w1.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_w1.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_w1.OnHoverTextColor = System.Drawing.Color.Orange;
            this.btn_w1.selected = false;
            this.btn_w1.Size = new System.Drawing.Size(40, 20);
            this.btn_w1.TabIndex = 0;
            this.btn_w1.Text = "W1";
            this.btn_w1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_w1.Textcolor = System.Drawing.Color.White;
            this.btn_w1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_w1.Click += new System.EventHandler(this.btn_w1_Click);
            // 
            // lab_spread
            // 
            this.lab_spread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_spread.ForeColor = System.Drawing.Color.White;
            this.lab_spread.Location = new System.Drawing.Point(0, 65);
            this.lab_spread.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lab_spread.Name = "lab_spread";
            this.lab_spread.Size = new System.Drawing.Size(175, 20);
            this.lab_spread.TabIndex = 1;
            this.lab_spread.Text = "SPREAD 32";
            // 
            // lab_swap
            // 
            this.lab_swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_swap.ForeColor = System.Drawing.Color.White;
            this.lab_swap.Location = new System.Drawing.Point(0, 88);
            this.lab_swap.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lab_swap.Name = "lab_swap";
            this.lab_swap.Size = new System.Drawing.Size(162, 20);
            this.lab_swap.TabIndex = 1;
            this.lab_swap.Text = "SWAP 6.33";
            // 
            // lab_breakeven
            // 
            this.lab_breakeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_breakeven.ForeColor = System.Drawing.Color.White;
            this.lab_breakeven.Location = new System.Drawing.Point(0, 111);
            this.lab_breakeven.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lab_breakeven.Name = "lab_breakeven";
            this.lab_breakeven.Size = new System.Drawing.Size(162, 20);
            this.lab_breakeven.TabIndex = 1;
            this.lab_breakeven.Text = "BELASTUNG 82%";
            // 
            // panel_balance_alert
            // 
            this.panel_balance_alert.Controls.Add(this.label42);
            this.panel_balance_alert.Controls.Add(this.label40);
            this.panel_balance_alert.Controls.Add(this.label46);
            this.panel_balance_alert.Controls.Add(this.btn_balance_alert_name);
            this.panel_balance_alert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_balance_alert.Location = new System.Drawing.Point(0, 0);
            this.panel_balance_alert.Margin = new System.Windows.Forms.Padding(0);
            this.panel_balance_alert.Name = "panel_balance_alert";
            this.panel_balance_alert.Size = new System.Drawing.Size(200, 164);
            this.panel_balance_alert.TabIndex = 5;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label42.Location = new System.Drawing.Point(16, 122);
            this.label42.Margin = new System.Windows.Forms.Padding(0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(160, 1);
            this.label42.TabIndex = 24;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(33, 51);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(117, 16);
            this.label40.TabIndex = 3;
            this.label40.Text = "BALANCE ALERT";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.Yellow;
            this.label46.Location = new System.Drawing.Point(16, 46);
            this.label46.Margin = new System.Windows.Forms.Padding(0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(10, 25);
            this.label46.TabIndex = 2;
            // 
            // btn_balance_alert_name
            // 
            this.btn_balance_alert_name.Activecolor = System.Drawing.Color.Transparent;
            this.btn_balance_alert_name.BackColor = System.Drawing.Color.Transparent;
            this.btn_balance_alert_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_balance_alert_name.BorderRadius = 0;
            this.btn_balance_alert_name.ButtonText = "Client Name";
            this.btn_balance_alert_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_balance_alert_name.DisabledColor = System.Drawing.Color.Gray;
            this.btn_balance_alert_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_balance_alert_name.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_balance_alert_name.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_balance_alert_name.Iconimage")));
            this.btn_balance_alert_name.Iconimage_right = null;
            this.btn_balance_alert_name.Iconimage_right_Selected = null;
            this.btn_balance_alert_name.Iconimage_Selected = null;
            this.btn_balance_alert_name.IconMarginLeft = 0;
            this.btn_balance_alert_name.IconMarginRight = 0;
            this.btn_balance_alert_name.IconRightVisible = true;
            this.btn_balance_alert_name.IconRightZoom = 0D;
            this.btn_balance_alert_name.IconVisible = false;
            this.btn_balance_alert_name.IconZoom = 90D;
            this.btn_balance_alert_name.IsTab = true;
            this.btn_balance_alert_name.Location = new System.Drawing.Point(33, 82);
            this.btn_balance_alert_name.Margin = new System.Windows.Forms.Padding(0);
            this.btn_balance_alert_name.Name = "btn_balance_alert_name";
            this.btn_balance_alert_name.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_balance_alert_name.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_balance_alert_name.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_balance_alert_name.selected = false;
            this.btn_balance_alert_name.Size = new System.Drawing.Size(140, 46);
            this.btn_balance_alert_name.TabIndex = 1;
            this.btn_balance_alert_name.Text = "Client Name";
            this.btn_balance_alert_name.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_balance_alert_name.Textcolor = System.Drawing.Color.White;
            this.btn_balance_alert_name.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_balance_alert_name.Click += new System.EventHandler(this.btn_balance_alert_name_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_tradingdesk);
            this.panel_main.Controls.Add(this.panel_details);
            this.panel_main.Controls.Add(this.panel_login);
            this.panel_main.Controls.Add(this.panel_settings);
            this.panel_main.Controls.Add(this.panel_pamm);
            this.panel_main.Controls.Add(this.panel_dashboard);
            this.panel_main.Controls.Add(this.panel_orders);
            this.panel_main.Controls.Add(this.panel_history);
            this.panel_main.Controls.Add(this.panel_statement);
            this.panel_main.Controls.Add(this.panel_tradingdesk_new);
            this.panel_main.Controls.Add(this.panel_statistics);
            this.panel_main.Controls.Add(this.panel_administrator);
            this.panel_main.Controls.Add(this.panel_clients);
            this.panel_main.Controls.Add(this.panel_head_1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(200, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(990, 790);
            this.panel_main.TabIndex = 1;
            // 
            // panel_tradingdesk
            // 
            this.panel_tradingdesk.BackColor = System.Drawing.Color.White;
            this.panel_tradingdesk.Controls.Add(this.panel_tradingdesk_up);
            this.panel_tradingdesk.Controls.Add(this.panel_tradingdesk_down);
            this.panel_tradingdesk.Controls.Add(this.panel_chart);
            this.panel_tradingdesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tradingdesk.Location = new System.Drawing.Point(0, 60);
            this.panel_tradingdesk.Name = "panel_tradingdesk";
            this.panel_tradingdesk.Size = new System.Drawing.Size(990, 730);
            this.panel_tradingdesk.TabIndex = 6;
            // 
            // panel_tradingdesk_up
            // 
            this.panel_tradingdesk_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tradingdesk_up.BackColor = System.Drawing.Color.White;
            this.panel_tradingdesk_up.ColumnCount = 1;
            this.panel_tradingdesk_up.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_tradingdesk_up.Controls.Add(this.panel_tradingdesk_up_client, 0, 0);
            this.panel_tradingdesk_up.Controls.Add(this.panel_tradingdesk_up_symbol, 0, 1);
            this.panel_tradingdesk_up.Location = new System.Drawing.Point(0, 0);
            this.panel_tradingdesk_up.Margin = new System.Windows.Forms.Padding(0);
            this.panel_tradingdesk_up.Name = "panel_tradingdesk_up";
            this.panel_tradingdesk_up.RowCount = 2;
            this.panel_tradingdesk_up.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.panel_tradingdesk_up.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_tradingdesk_up.Size = new System.Drawing.Size(990, 225);
            this.panel_tradingdesk_up.TabIndex = 1;
            // 
            // panel_tradingdesk_up_client
            // 
            this.panel_tradingdesk_up_client.ColumnCount = 1;
            this.panel_tradingdesk_up_client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_tradingdesk_up_client.Controls.Add(this.ctrl_account_tradingdesk, 0, 1);
            this.panel_tradingdesk_up_client.Controls.Add(this.ctrl_header_tradingdesk, 0, 0);
            this.panel_tradingdesk_up_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tradingdesk_up_client.Location = new System.Drawing.Point(0, 0);
            this.panel_tradingdesk_up_client.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panel_tradingdesk_up_client.Name = "panel_tradingdesk_up_client";
            this.panel_tradingdesk_up_client.RowCount = 2;
            this.panel_tradingdesk_up_client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_tradingdesk_up_client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_tradingdesk_up_client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_tradingdesk_up_client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_tradingdesk_up_client.Size = new System.Drawing.Size(960, 102);
            this.panel_tradingdesk_up_client.TabIndex = 0;
            // 
            // ctrl_account_tradingdesk
            // 
            this.ctrl_account_tradingdesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_account_tradingdesk.Location = new System.Drawing.Point(0, 30);
            this.ctrl_account_tradingdesk.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_account_tradingdesk.Name = "ctrl_account_tradingdesk";
            this.ctrl_account_tradingdesk.Size = new System.Drawing.Size(960, 72);
            this.ctrl_account_tradingdesk.TabIndex = 1;
            // 
            // ctrl_header_tradingdesk
            // 
            this.ctrl_header_tradingdesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.ctrl_header_tradingdesk.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrl_header_tradingdesk.Location = new System.Drawing.Point(0, 0);
            this.ctrl_header_tradingdesk.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_header_tradingdesk.Name = "ctrl_header_tradingdesk";
            this.ctrl_header_tradingdesk.Size = new System.Drawing.Size(960, 30);
            this.ctrl_header_tradingdesk.TabIndex = 2;
            // 
            // panel_tradingdesk_up_symbol
            // 
            this.panel_tradingdesk_up_symbol.ColumnCount = 3;
            this.panel_tradingdesk_up_symbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.41F));
            this.panel_tradingdesk_up_symbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.18F));
            this.panel_tradingdesk_up_symbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.41F));
            this.panel_tradingdesk_up_symbol.Controls.Add(this.tableLayoutPanel28, 1, 0);
            this.panel_tradingdesk_up_symbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tradingdesk_up_symbol.Location = new System.Drawing.Point(0, 102);
            this.panel_tradingdesk_up_symbol.Margin = new System.Windows.Forms.Padding(0);
            this.panel_tradingdesk_up_symbol.Name = "panel_tradingdesk_up_symbol";
            this.panel_tradingdesk_up_symbol.RowCount = 1;
            this.panel_tradingdesk_up_symbol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_tradingdesk_up_symbol.Size = new System.Drawing.Size(990, 123);
            this.panel_tradingdesk_up_symbol.TabIndex = 1;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.ColumnCount = 4;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel28.Controls.Add(this.panel22, 2, 0);
            this.tableLayoutPanel28.Controls.Add(this.panel24, 0, 0);
            this.tableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel28.Location = new System.Drawing.Point(73, 0);
            this.tableLayoutPanel28.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 1;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(843, 123);
            this.tableLayoutPanel28.TabIndex = 5;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.td_buysell_ctrl);
            this.panel22.Controls.Add(this.btn_delete_pending_order);
            this.panel22.Controls.Add(this.btn_modify_pending_order);
            this.panel22.Controls.Add(this.btn_add_pending_order);
            this.panel22.Controls.Add(this.btn_remove_price_alert);
            this.panel22.Controls.Add(this.btn_add_price_alert);
            this.panel22.Controls.Add(this.flowLayoutPanel1);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(161, 0);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(650, 123);
            this.panel22.TabIndex = 4;
            // 
            // td_buysell_ctrl
            // 
            this.td_buysell_ctrl.Location = new System.Drawing.Point(6, 7);
            this.td_buysell_ctrl.Margin = new System.Windows.Forms.Padding(0);
            this.td_buysell_ctrl.Name = "td_buysell_ctrl";
            this.td_buysell_ctrl.Size = new System.Drawing.Size(450, 100);
            this.td_buysell_ctrl.TabIndex = 73;
            // 
            // btn_delete_pending_order
            // 
            this.btn_delete_pending_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_pending_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_pending_order.Image")));
            this.btn_delete_pending_order.ImageActive = null;
            this.btn_delete_pending_order.Location = new System.Drawing.Point(608, 43);
            this.btn_delete_pending_order.Name = "btn_delete_pending_order";
            this.btn_delete_pending_order.Size = new System.Drawing.Size(28, 27);
            this.btn_delete_pending_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_delete_pending_order.TabIndex = 9;
            this.btn_delete_pending_order.TabStop = false;
            this.btn_delete_pending_order.Visible = false;
            this.btn_delete_pending_order.Zoom = 20;
            this.btn_delete_pending_order.Click += new System.EventHandler(this.btn_delete_pending_order_Click);
            // 
            // btn_modify_pending_order
            // 
            this.btn_modify_pending_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_modify_pending_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_modify_pending_order.Image")));
            this.btn_modify_pending_order.ImageActive = null;
            this.btn_modify_pending_order.Location = new System.Drawing.Point(608, 43);
            this.btn_modify_pending_order.Name = "btn_modify_pending_order";
            this.btn_modify_pending_order.Size = new System.Drawing.Size(28, 27);
            this.btn_modify_pending_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_modify_pending_order.TabIndex = 8;
            this.btn_modify_pending_order.TabStop = false;
            this.btn_modify_pending_order.Visible = false;
            this.btn_modify_pending_order.Zoom = 20;
            this.btn_modify_pending_order.Click += new System.EventHandler(this.btn_modify_pending_order_Click);
            // 
            // btn_add_pending_order
            // 
            this.btn_add_pending_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_pending_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pending_order.Image")));
            this.btn_add_pending_order.ImageActive = null;
            this.btn_add_pending_order.Location = new System.Drawing.Point(608, 43);
            this.btn_add_pending_order.Name = "btn_add_pending_order";
            this.btn_add_pending_order.Size = new System.Drawing.Size(28, 27);
            this.btn_add_pending_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add_pending_order.TabIndex = 7;
            this.btn_add_pending_order.TabStop = false;
            this.btn_add_pending_order.Visible = false;
            this.btn_add_pending_order.Zoom = 20;
            this.btn_add_pending_order.Click += new System.EventHandler(this.btn_add_pending_order_Click);
            // 
            // btn_remove_price_alert
            // 
            this.btn_remove_price_alert.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove_price_alert.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove_price_alert.Image")));
            this.btn_remove_price_alert.ImageActive = null;
            this.btn_remove_price_alert.Location = new System.Drawing.Point(608, 76);
            this.btn_remove_price_alert.Name = "btn_remove_price_alert";
            this.btn_remove_price_alert.Size = new System.Drawing.Size(28, 27);
            this.btn_remove_price_alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_remove_price_alert.TabIndex = 6;
            this.btn_remove_price_alert.TabStop = false;
            this.btn_remove_price_alert.Visible = false;
            this.btn_remove_price_alert.Zoom = 20;
            this.btn_remove_price_alert.Click += new System.EventHandler(this.btn_remove_price_alert_Click);
            // 
            // btn_add_price_alert
            // 
            this.btn_add_price_alert.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_price_alert.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_price_alert.Image")));
            this.btn_add_price_alert.ImageActive = null;
            this.btn_add_price_alert.Location = new System.Drawing.Point(608, 76);
            this.btn_add_price_alert.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_price_alert.Name = "btn_add_price_alert";
            this.btn_add_price_alert.Size = new System.Drawing.Size(28, 27);
            this.btn_add_price_alert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add_price_alert.TabIndex = 5;
            this.btn_add_price_alert.TabStop = false;
            this.btn_add_price_alert.Visible = false;
            this.btn_add_price_alert.Zoom = 20;
            this.btn_add_price_alert.Click += new System.EventHandler(this.btn_add_price_alert_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_td_show_order);
            this.flowLayoutPanel1.Controls.Add(this.btn_td_pending_order);
            this.flowLayoutPanel1.Controls.Add(this.btn_td_alert);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(466, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(130, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_td_show_order
            // 
            this.btn_td_show_order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_td_show_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_td_show_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_td_show_order.BorderRadius = 0;
            this.btn_td_show_order.ButtonText = "SHOW ORDER";
            this.btn_td_show_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_td_show_order.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_td_show_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_td_show_order.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_td_show_order.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_td_show_order.Iconimage")));
            this.btn_td_show_order.Iconimage_right = null;
            this.btn_td_show_order.Iconimage_right_Selected = null;
            this.btn_td_show_order.Iconimage_Selected = null;
            this.btn_td_show_order.IconMarginLeft = 0;
            this.btn_td_show_order.IconMarginRight = 0;
            this.btn_td_show_order.IconRightVisible = true;
            this.btn_td_show_order.IconRightZoom = 0D;
            this.btn_td_show_order.IconVisible = false;
            this.btn_td_show_order.IconZoom = 90D;
            this.btn_td_show_order.IsTab = true;
            this.btn_td_show_order.Location = new System.Drawing.Point(0, 0);
            this.btn_td_show_order.Margin = new System.Windows.Forms.Padding(0);
            this.btn_td_show_order.Name = "btn_td_show_order";
            this.btn_td_show_order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_td_show_order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.btn_td_show_order.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_td_show_order.selected = true;
            this.btn_td_show_order.Size = new System.Drawing.Size(130, 31);
            this.btn_td_show_order.TabIndex = 5;
            this.btn_td_show_order.Text = "SHOW ORDER";
            this.btn_td_show_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_td_show_order.Textcolor = System.Drawing.Color.White;
            this.btn_td_show_order.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_td_show_order.Click += new System.EventHandler(this.btn_td_show_order_Click);
            // 
            // btn_td_pending_order
            // 
            this.btn_td_pending_order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_td_pending_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_td_pending_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_td_pending_order.BorderRadius = 0;
            this.btn_td_pending_order.ButtonText = "PENDING ORDER";
            this.btn_td_pending_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_td_pending_order.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_td_pending_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_td_pending_order.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_td_pending_order.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_td_pending_order.Iconimage")));
            this.btn_td_pending_order.Iconimage_right = null;
            this.btn_td_pending_order.Iconimage_right_Selected = null;
            this.btn_td_pending_order.Iconimage_Selected = null;
            this.btn_td_pending_order.IconMarginLeft = 0;
            this.btn_td_pending_order.IconMarginRight = 0;
            this.btn_td_pending_order.IconRightVisible = true;
            this.btn_td_pending_order.IconRightZoom = 0D;
            this.btn_td_pending_order.IconVisible = false;
            this.btn_td_pending_order.IconZoom = 90D;
            this.btn_td_pending_order.IsTab = true;
            this.btn_td_pending_order.Location = new System.Drawing.Point(0, 34);
            this.btn_td_pending_order.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btn_td_pending_order.Name = "btn_td_pending_order";
            this.btn_td_pending_order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_td_pending_order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.btn_td_pending_order.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_td_pending_order.selected = false;
            this.btn_td_pending_order.Size = new System.Drawing.Size(130, 31);
            this.btn_td_pending_order.TabIndex = 6;
            this.btn_td_pending_order.Text = "PENDING ORDER";
            this.btn_td_pending_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_td_pending_order.Textcolor = System.Drawing.Color.White;
            this.btn_td_pending_order.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_td_pending_order.Click += new System.EventHandler(this.btn_td_pending_order_Click);
            // 
            // btn_td_alert
            // 
            this.btn_td_alert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_td_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_td_alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_td_alert.BorderRadius = 0;
            this.btn_td_alert.ButtonText = "ALERT";
            this.btn_td_alert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_td_alert.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_td_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_td_alert.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_td_alert.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_td_alert.Iconimage")));
            this.btn_td_alert.Iconimage_right = null;
            this.btn_td_alert.Iconimage_right_Selected = null;
            this.btn_td_alert.Iconimage_Selected = null;
            this.btn_td_alert.IconMarginLeft = 0;
            this.btn_td_alert.IconMarginRight = 0;
            this.btn_td_alert.IconRightVisible = true;
            this.btn_td_alert.IconRightZoom = 0D;
            this.btn_td_alert.IconVisible = false;
            this.btn_td_alert.IconZoom = 90D;
            this.btn_td_alert.IsTab = true;
            this.btn_td_alert.Location = new System.Drawing.Point(0, 68);
            this.btn_td_alert.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btn_td_alert.Name = "btn_td_alert";
            this.btn_td_alert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_td_alert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.btn_td_alert.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_td_alert.selected = false;
            this.btn_td_alert.Size = new System.Drawing.Size(130, 31);
            this.btn_td_alert.TabIndex = 7;
            this.btn_td_alert.Text = "ALERT";
            this.btn_td_alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_td_alert.Textcolor = System.Drawing.Color.White;
            this.btn_td_alert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_td_alert.Click += new System.EventHandler(this.btn_td_alert_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.tableLayoutPanel29);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(130, 123);
            this.panel24.TabIndex = 5;
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.ColumnCount = 3;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel29.Controls.Add(this.lab_td_percent4, 2, 6);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_percent3, 2, 5);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_percent2, 2, 4);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_percent1, 2, 3);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_percent0, 2, 2);
            this.tableLayoutPanel29.Controls.Add(this.label72, 2, 1);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_lot4, 1, 6);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_lot3, 1, 5);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_lot2, 1, 4);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_lot1, 1, 3);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_lot0, 1, 2);
            this.tableLayoutPanel29.Controls.Add(this.label62, 1, 1);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_symbol4, 0, 6);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_symbol3, 0, 5);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_symbol2, 0, 4);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_symbol1, 0, 3);
            this.tableLayoutPanel29.Controls.Add(this.lab_td_symbol0, 0, 2);
            this.tableLayoutPanel29.Controls.Add(this.label43, 0, 1);
            this.tableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel29.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel29.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 8;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(130, 123);
            this.tableLayoutPanel29.TabIndex = 0;
            // 
            // lab_td_percent4
            // 
            this.lab_td_percent4.AutoSize = true;
            this.lab_td_percent4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_percent4.Location = new System.Drawing.Point(97, 87);
            this.lab_td_percent4.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_percent4.Name = "lab_td_percent4";
            this.lab_td_percent4.Size = new System.Drawing.Size(33, 16);
            this.lab_td_percent4.TabIndex = 18;
            this.lab_td_percent4.Text = "%";
            this.lab_td_percent4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_percent3
            // 
            this.lab_td_percent3.AutoSize = true;
            this.lab_td_percent3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_percent3.Location = new System.Drawing.Point(97, 71);
            this.lab_td_percent3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_percent3.Name = "lab_td_percent3";
            this.lab_td_percent3.Size = new System.Drawing.Size(33, 16);
            this.lab_td_percent3.TabIndex = 17;
            this.lab_td_percent3.Text = "%";
            this.lab_td_percent3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_percent2
            // 
            this.lab_td_percent2.AutoSize = true;
            this.lab_td_percent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_percent2.Location = new System.Drawing.Point(97, 55);
            this.lab_td_percent2.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_percent2.Name = "lab_td_percent2";
            this.lab_td_percent2.Size = new System.Drawing.Size(33, 16);
            this.lab_td_percent2.TabIndex = 16;
            this.lab_td_percent2.Text = "%";
            this.lab_td_percent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_percent1
            // 
            this.lab_td_percent1.AutoSize = true;
            this.lab_td_percent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_percent1.Location = new System.Drawing.Point(97, 39);
            this.lab_td_percent1.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_percent1.Name = "lab_td_percent1";
            this.lab_td_percent1.Size = new System.Drawing.Size(33, 16);
            this.lab_td_percent1.TabIndex = 15;
            this.lab_td_percent1.Text = "%";
            this.lab_td_percent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_percent0
            // 
            this.lab_td_percent0.AutoSize = true;
            this.lab_td_percent0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_percent0.Location = new System.Drawing.Point(97, 23);
            this.lab_td_percent0.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_percent0.Name = "lab_td_percent0";
            this.lab_td_percent0.Size = new System.Drawing.Size(33, 16);
            this.lab_td_percent0.TabIndex = 14;
            this.lab_td_percent0.Text = "%";
            this.lab_td_percent0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(97, 7);
            this.label72.Margin = new System.Windows.Forms.Padding(0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(33, 16);
            this.label72.TabIndex = 13;
            this.label72.Text = "%";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_lot4
            // 
            this.lab_td_lot4.AutoSize = true;
            this.lab_td_lot4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_lot4.Location = new System.Drawing.Point(58, 87);
            this.lab_td_lot4.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_lot4.Name = "lab_td_lot4";
            this.lab_td_lot4.Size = new System.Drawing.Size(39, 16);
            this.lab_td_lot4.TabIndex = 12;
            this.lab_td_lot4.Text = "LOT";
            this.lab_td_lot4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_lot3
            // 
            this.lab_td_lot3.AutoSize = true;
            this.lab_td_lot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_lot3.Location = new System.Drawing.Point(58, 71);
            this.lab_td_lot3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_lot3.Name = "lab_td_lot3";
            this.lab_td_lot3.Size = new System.Drawing.Size(39, 16);
            this.lab_td_lot3.TabIndex = 11;
            this.lab_td_lot3.Text = "LOT";
            this.lab_td_lot3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_lot2
            // 
            this.lab_td_lot2.AutoSize = true;
            this.lab_td_lot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_lot2.Location = new System.Drawing.Point(58, 55);
            this.lab_td_lot2.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_lot2.Name = "lab_td_lot2";
            this.lab_td_lot2.Size = new System.Drawing.Size(39, 16);
            this.lab_td_lot2.TabIndex = 10;
            this.lab_td_lot2.Text = "LOT";
            this.lab_td_lot2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_lot1
            // 
            this.lab_td_lot1.AutoSize = true;
            this.lab_td_lot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_lot1.Location = new System.Drawing.Point(58, 39);
            this.lab_td_lot1.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_lot1.Name = "lab_td_lot1";
            this.lab_td_lot1.Size = new System.Drawing.Size(39, 16);
            this.lab_td_lot1.TabIndex = 9;
            this.lab_td_lot1.Text = "LOT";
            this.lab_td_lot1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_lot0
            // 
            this.lab_td_lot0.AutoSize = true;
            this.lab_td_lot0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_lot0.Location = new System.Drawing.Point(58, 23);
            this.lab_td_lot0.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_lot0.Name = "lab_td_lot0";
            this.lab_td_lot0.Size = new System.Drawing.Size(39, 16);
            this.lab_td_lot0.TabIndex = 8;
            this.lab_td_lot0.Text = "LOT";
            this.lab_td_lot0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(58, 7);
            this.label62.Margin = new System.Windows.Forms.Padding(0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(39, 16);
            this.label62.TabIndex = 7;
            this.label62.Text = "LOT";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_td_symbol4
            // 
            this.lab_td_symbol4.AutoSize = true;
            this.lab_td_symbol4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_symbol4.Location = new System.Drawing.Point(0, 87);
            this.lab_td_symbol4.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_symbol4.Name = "lab_td_symbol4";
            this.lab_td_symbol4.Size = new System.Drawing.Size(58, 16);
            this.lab_td_symbol4.TabIndex = 6;
            this.lab_td_symbol4.Text = "SYMBOL";
            this.lab_td_symbol4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_td_symbol3
            // 
            this.lab_td_symbol3.AutoSize = true;
            this.lab_td_symbol3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_symbol3.Location = new System.Drawing.Point(0, 71);
            this.lab_td_symbol3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_symbol3.Name = "lab_td_symbol3";
            this.lab_td_symbol3.Size = new System.Drawing.Size(58, 16);
            this.lab_td_symbol3.TabIndex = 4;
            this.lab_td_symbol3.Text = "SYMBOL";
            this.lab_td_symbol3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_td_symbol2
            // 
            this.lab_td_symbol2.AutoSize = true;
            this.lab_td_symbol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_symbol2.Location = new System.Drawing.Point(0, 55);
            this.lab_td_symbol2.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_symbol2.Name = "lab_td_symbol2";
            this.lab_td_symbol2.Size = new System.Drawing.Size(58, 16);
            this.lab_td_symbol2.TabIndex = 3;
            this.lab_td_symbol2.Text = "SYMBOL";
            this.lab_td_symbol2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_td_symbol1
            // 
            this.lab_td_symbol1.AutoSize = true;
            this.lab_td_symbol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_symbol1.Location = new System.Drawing.Point(0, 39);
            this.lab_td_symbol1.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_symbol1.Name = "lab_td_symbol1";
            this.lab_td_symbol1.Size = new System.Drawing.Size(58, 16);
            this.lab_td_symbol1.TabIndex = 2;
            this.lab_td_symbol1.Text = "SYMBOL";
            this.lab_td_symbol1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_td_symbol0
            // 
            this.lab_td_symbol0.AutoSize = true;
            this.lab_td_symbol0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_td_symbol0.Location = new System.Drawing.Point(0, 23);
            this.lab_td_symbol0.Margin = new System.Windows.Forms.Padding(0);
            this.lab_td_symbol0.Name = "lab_td_symbol0";
            this.lab_td_symbol0.Size = new System.Drawing.Size(58, 16);
            this.lab_td_symbol0.TabIndex = 1;
            this.lab_td_symbol0.Text = "SYMBOL";
            this.lab_td_symbol0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(0, 7);
            this.label43.Margin = new System.Windows.Forms.Padding(0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(58, 16);
            this.label43.TabIndex = 0;
            this.label43.Text = "SYMBOL";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_tradingdesk_down
            // 
            this.panel_tradingdesk_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tradingdesk_down.BackColor = System.Drawing.Color.White;
            this.panel_tradingdesk_down.ColumnCount = 4;
            this.panel_tradingdesk_down.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.panel_tradingdesk_down.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.75F));
            this.panel_tradingdesk_down.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_tradingdesk_down.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.panel_tradingdesk_down.Controls.Add(this.panel_order2, 1, 4);
            this.panel_tradingdesk_down.Controls.Add(this.panel_order1, 1, 2);
            this.panel_tradingdesk_down.Controls.Add(this.order_separator, 1, 3);
            this.panel_tradingdesk_down.Controls.Add(this.panel_order_header, 1, 0);
            this.panel_tradingdesk_down.Controls.Add(this.btn_order1_close, 2, 2);
            this.panel_tradingdesk_down.Controls.Add(this.btn_order2_close, 2, 4);
            this.panel_tradingdesk_down.Location = new System.Drawing.Point(0, 577);
            this.panel_tradingdesk_down.Margin = new System.Windows.Forms.Padding(0);
            this.panel_tradingdesk_down.Name = "panel_tradingdesk_down";
            this.panel_tradingdesk_down.RowCount = 6;
            this.panel_tradingdesk_down.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
            this.panel_tradingdesk_down.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.panel_tradingdesk_down.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panel_tradingdesk_down.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.panel_tradingdesk_down.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panel_tradingdesk_down.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_tradingdesk_down.Size = new System.Drawing.Size(991, 150);
            this.panel_tradingdesk_down.TabIndex = 2;
            // 
            // panel_order2
            // 
            this.panel_order2.ColumnCount = 7;
            this.panel_order2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_order2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order2.Controls.Add(this.lab_order2_account2, 0, 1);
            this.panel_order2.Controls.Add(this.lab_order2_sell2, 0, 1);
            this.panel_order2.Controls.Add(this.lab_order2_lot2, 0, 1);
            this.panel_order2.Controls.Add(this.lab_order2_symbol2, 0, 1);
            this.panel_order2.Controls.Add(this.lab_order2_pnl2, 0, 1);
            this.panel_order2.Controls.Add(this.lab_order2_spread2, 0, 1);
            this.panel_order2.Controls.Add(this.lab_order2_buy2, 0, 1);
            this.panel_order2.Controls.Add(this.lab_order2_symbol1, 1, 0);
            this.panel_order2.Controls.Add(this.lab_order2_account1, 0, 0);
            this.panel_order2.Controls.Add(this.lab_order2_lot1, 2, 0);
            this.panel_order2.Controls.Add(this.lab_order2_sell1, 3, 0);
            this.panel_order2.Controls.Add(this.lab_order2_buy1, 4, 0);
            this.panel_order2.Controls.Add(this.lab_order2_spread1, 5, 0);
            this.panel_order2.Controls.Add(this.lab_order2_pnl1, 6, 0);
            this.panel_order2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_order2.Location = new System.Drawing.Point(30, 79);
            this.panel_order2.Margin = new System.Windows.Forms.Padding(0);
            this.panel_order2.Name = "panel_order2";
            this.panel_order2.RowCount = 2;
            this.panel_order2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_order2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_order2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_order2.Size = new System.Drawing.Size(900, 49);
            this.panel_order2.TabIndex = 3;
            // 
            // lab_order2_account2
            // 
            this.lab_order2_account2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_account2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_account2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_account2.Location = new System.Drawing.Point(1, 25);
            this.lab_order2_account2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_account2.Name = "lab_order2_account2";
            this.lab_order2_account2.Size = new System.Drawing.Size(126, 23);
            this.lab_order2_account2.TabIndex = 22;
            this.lab_order2_account2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_sell2
            // 
            this.lab_order2_sell2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_sell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_sell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_sell2.Location = new System.Drawing.Point(385, 25);
            this.lab_order2_sell2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_sell2.Name = "lab_order2_sell2";
            this.lab_order2_sell2.Size = new System.Drawing.Size(126, 23);
            this.lab_order2_sell2.TabIndex = 21;
            this.lab_order2_sell2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_lot2
            // 
            this.lab_order2_lot2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_lot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_lot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_lot2.Location = new System.Drawing.Point(257, 25);
            this.lab_order2_lot2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_lot2.Name = "lab_order2_lot2";
            this.lab_order2_lot2.Size = new System.Drawing.Size(126, 23);
            this.lab_order2_lot2.TabIndex = 20;
            this.lab_order2_lot2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_symbol2
            // 
            this.lab_order2_symbol2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_symbol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_symbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_symbol2.Location = new System.Drawing.Point(129, 25);
            this.lab_order2_symbol2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_symbol2.Name = "lab_order2_symbol2";
            this.lab_order2_symbol2.Size = new System.Drawing.Size(126, 23);
            this.lab_order2_symbol2.TabIndex = 19;
            this.lab_order2_symbol2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_pnl2
            // 
            this.lab_order2_pnl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_pnl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_pnl2.Location = new System.Drawing.Point(769, 25);
            this.lab_order2_pnl2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_pnl2.Name = "lab_order2_pnl2";
            this.lab_order2_pnl2.Size = new System.Drawing.Size(130, 23);
            this.lab_order2_pnl2.TabIndex = 18;
            this.lab_order2_pnl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_spread2
            // 
            this.lab_order2_spread2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_spread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_spread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_spread2.Location = new System.Drawing.Point(641, 25);
            this.lab_order2_spread2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_spread2.Name = "lab_order2_spread2";
            this.lab_order2_spread2.Size = new System.Drawing.Size(126, 23);
            this.lab_order2_spread2.TabIndex = 17;
            this.lab_order2_spread2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_buy2
            // 
            this.lab_order2_buy2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_buy2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_buy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_buy2.Location = new System.Drawing.Point(513, 25);
            this.lab_order2_buy2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_buy2.Name = "lab_order2_buy2";
            this.lab_order2_buy2.Size = new System.Drawing.Size(126, 23);
            this.lab_order2_buy2.TabIndex = 15;
            this.lab_order2_buy2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_symbol1
            // 
            this.lab_order2_symbol1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_symbol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_symbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_symbol1.Location = new System.Drawing.Point(129, 1);
            this.lab_order2_symbol1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_symbol1.Name = "lab_order2_symbol1";
            this.lab_order2_symbol1.Size = new System.Drawing.Size(126, 22);
            this.lab_order2_symbol1.TabIndex = 8;
            this.lab_order2_symbol1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_account1
            // 
            this.lab_order2_account1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_account1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_account1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_account1.Location = new System.Drawing.Point(1, 1);
            this.lab_order2_account1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_account1.Name = "lab_order2_account1";
            this.lab_order2_account1.Size = new System.Drawing.Size(126, 22);
            this.lab_order2_account1.TabIndex = 10;
            this.lab_order2_account1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_lot1
            // 
            this.lab_order2_lot1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_lot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_lot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_lot1.Location = new System.Drawing.Point(257, 1);
            this.lab_order2_lot1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_lot1.Name = "lab_order2_lot1";
            this.lab_order2_lot1.Size = new System.Drawing.Size(126, 22);
            this.lab_order2_lot1.TabIndex = 11;
            this.lab_order2_lot1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_sell1
            // 
            this.lab_order2_sell1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_sell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_sell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_sell1.Location = new System.Drawing.Point(385, 1);
            this.lab_order2_sell1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_sell1.Name = "lab_order2_sell1";
            this.lab_order2_sell1.Size = new System.Drawing.Size(126, 22);
            this.lab_order2_sell1.TabIndex = 14;
            this.lab_order2_sell1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_buy1
            // 
            this.lab_order2_buy1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_buy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_buy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_buy1.Location = new System.Drawing.Point(513, 1);
            this.lab_order2_buy1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_buy1.Name = "lab_order2_buy1";
            this.lab_order2_buy1.Size = new System.Drawing.Size(126, 22);
            this.lab_order2_buy1.TabIndex = 16;
            this.lab_order2_buy1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_spread1
            // 
            this.lab_order2_spread1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_spread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_spread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_spread1.Location = new System.Drawing.Point(641, 1);
            this.lab_order2_spread1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_spread1.Name = "lab_order2_spread1";
            this.lab_order2_spread1.Size = new System.Drawing.Size(126, 22);
            this.lab_order2_spread1.TabIndex = 9;
            this.lab_order2_spread1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order2_pnl1
            // 
            this.lab_order2_pnl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order2_pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order2_pnl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order2_pnl1.Location = new System.Drawing.Point(769, 1);
            this.lab_order2_pnl1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order2_pnl1.Name = "lab_order2_pnl1";
            this.lab_order2_pnl1.Size = new System.Drawing.Size(130, 22);
            this.lab_order2_pnl1.TabIndex = 12;
            this.lab_order2_pnl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_order1
            // 
            this.panel_order1.ColumnCount = 7;
            this.panel_order1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_order1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order1.Controls.Add(this.lab_order1_pnl2, 6, 1);
            this.panel_order1.Controls.Add(this.lab_order1_spread2, 5, 1);
            this.panel_order1.Controls.Add(this.lab_order1_buy2, 4, 1);
            this.panel_order1.Controls.Add(this.lab_order1_sell2, 3, 1);
            this.panel_order1.Controls.Add(this.lab_order1_lot2, 2, 1);
            this.panel_order1.Controls.Add(this.lab_order1_symbol2, 1, 1);
            this.panel_order1.Controls.Add(this.lab_order1_account2, 0, 1);
            this.panel_order1.Controls.Add(this.lab_order1_pnl1, 6, 0);
            this.panel_order1.Controls.Add(this.lab_order1_spread1, 5, 0);
            this.panel_order1.Controls.Add(this.lab_order1_buy1, 4, 0);
            this.panel_order1.Controls.Add(this.lab_order1_sell1, 3, 0);
            this.panel_order1.Controls.Add(this.lab_order1_lot1, 2, 0);
            this.panel_order1.Controls.Add(this.lab_order1_symbol1, 1, 0);
            this.panel_order1.Controls.Add(this.lab_order1_account1, 0, 0);
            this.panel_order1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_order1.Location = new System.Drawing.Point(30, 27);
            this.panel_order1.Margin = new System.Windows.Forms.Padding(0);
            this.panel_order1.Name = "panel_order1";
            this.panel_order1.RowCount = 2;
            this.panel_order1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_order1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_order1.Size = new System.Drawing.Size(900, 49);
            this.panel_order1.TabIndex = 2;
            // 
            // lab_order1_pnl2
            // 
            this.lab_order1_pnl2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_pnl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_pnl2.Location = new System.Drawing.Point(769, 25);
            this.lab_order1_pnl2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_pnl2.Name = "lab_order1_pnl2";
            this.lab_order1_pnl2.Size = new System.Drawing.Size(130, 23);
            this.lab_order1_pnl2.TabIndex = 13;
            this.lab_order1_pnl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_spread2
            // 
            this.lab_order1_spread2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_spread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_spread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_spread2.Location = new System.Drawing.Point(641, 25);
            this.lab_order1_spread2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_spread2.Name = "lab_order1_spread2";
            this.lab_order1_spread2.Size = new System.Drawing.Size(126, 23);
            this.lab_order1_spread2.TabIndex = 12;
            this.lab_order1_spread2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_buy2
            // 
            this.lab_order1_buy2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_buy2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_buy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_buy2.Location = new System.Drawing.Point(513, 25);
            this.lab_order1_buy2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_buy2.Name = "lab_order1_buy2";
            this.lab_order1_buy2.Size = new System.Drawing.Size(126, 23);
            this.lab_order1_buy2.TabIndex = 11;
            this.lab_order1_buy2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_sell2
            // 
            this.lab_order1_sell2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_sell2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_sell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_sell2.Location = new System.Drawing.Point(385, 25);
            this.lab_order1_sell2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_sell2.Name = "lab_order1_sell2";
            this.lab_order1_sell2.Size = new System.Drawing.Size(126, 23);
            this.lab_order1_sell2.TabIndex = 10;
            this.lab_order1_sell2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_lot2
            // 
            this.lab_order1_lot2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_lot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_lot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_lot2.Location = new System.Drawing.Point(257, 25);
            this.lab_order1_lot2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_lot2.Name = "lab_order1_lot2";
            this.lab_order1_lot2.Size = new System.Drawing.Size(126, 23);
            this.lab_order1_lot2.TabIndex = 9;
            this.lab_order1_lot2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_symbol2
            // 
            this.lab_order1_symbol2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_symbol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_symbol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_symbol2.Location = new System.Drawing.Point(129, 25);
            this.lab_order1_symbol2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_symbol2.Name = "lab_order1_symbol2";
            this.lab_order1_symbol2.Size = new System.Drawing.Size(126, 23);
            this.lab_order1_symbol2.TabIndex = 8;
            this.lab_order1_symbol2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_account2
            // 
            this.lab_order1_account2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_account2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_account2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_account2.Location = new System.Drawing.Point(1, 25);
            this.lab_order1_account2.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_account2.Name = "lab_order1_account2";
            this.lab_order1_account2.Size = new System.Drawing.Size(126, 23);
            this.lab_order1_account2.TabIndex = 7;
            this.lab_order1_account2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_pnl1
            // 
            this.lab_order1_pnl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_pnl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_pnl1.Location = new System.Drawing.Point(769, 1);
            this.lab_order1_pnl1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_pnl1.Name = "lab_order1_pnl1";
            this.lab_order1_pnl1.Size = new System.Drawing.Size(130, 22);
            this.lab_order1_pnl1.TabIndex = 6;
            this.lab_order1_pnl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_spread1
            // 
            this.lab_order1_spread1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_spread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_spread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_spread1.Location = new System.Drawing.Point(641, 1);
            this.lab_order1_spread1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_spread1.Name = "lab_order1_spread1";
            this.lab_order1_spread1.Size = new System.Drawing.Size(126, 22);
            this.lab_order1_spread1.TabIndex = 5;
            this.lab_order1_spread1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_buy1
            // 
            this.lab_order1_buy1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_buy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_buy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_buy1.Location = new System.Drawing.Point(513, 1);
            this.lab_order1_buy1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_buy1.Name = "lab_order1_buy1";
            this.lab_order1_buy1.Size = new System.Drawing.Size(126, 22);
            this.lab_order1_buy1.TabIndex = 4;
            this.lab_order1_buy1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_sell1
            // 
            this.lab_order1_sell1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_sell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_sell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_sell1.Location = new System.Drawing.Point(385, 1);
            this.lab_order1_sell1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_sell1.Name = "lab_order1_sell1";
            this.lab_order1_sell1.Size = new System.Drawing.Size(126, 22);
            this.lab_order1_sell1.TabIndex = 3;
            this.lab_order1_sell1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_lot1
            // 
            this.lab_order1_lot1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_lot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_lot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_lot1.Location = new System.Drawing.Point(257, 1);
            this.lab_order1_lot1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_lot1.Name = "lab_order1_lot1";
            this.lab_order1_lot1.Size = new System.Drawing.Size(126, 22);
            this.lab_order1_lot1.TabIndex = 2;
            this.lab_order1_lot1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_symbol1
            // 
            this.lab_order1_symbol1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_symbol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_symbol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_symbol1.Location = new System.Drawing.Point(129, 1);
            this.lab_order1_symbol1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_symbol1.Name = "lab_order1_symbol1";
            this.lab_order1_symbol1.Size = new System.Drawing.Size(126, 22);
            this.lab_order1_symbol1.TabIndex = 1;
            this.lab_order1_symbol1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_order1_account1
            // 
            this.lab_order1_account1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lab_order1_account1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_order1_account1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lab_order1_account1.Location = new System.Drawing.Point(1, 1);
            this.lab_order1_account1.Margin = new System.Windows.Forms.Padding(1);
            this.lab_order1_account1.Name = "lab_order1_account1";
            this.lab_order1_account1.Size = new System.Drawing.Size(126, 22);
            this.lab_order1_account1.TabIndex = 0;
            this.lab_order1_account1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // order_separator
            // 
            this.order_separator.BackColor = System.Drawing.Color.Red;
            this.order_separator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_separator.Location = new System.Drawing.Point(30, 76);
            this.order_separator.Margin = new System.Windows.Forms.Padding(0);
            this.order_separator.Name = "order_separator";
            this.order_separator.Size = new System.Drawing.Size(900, 3);
            this.order_separator.TabIndex = 0;
            this.order_separator.Text = "label9";
            // 
            // panel_order_header
            // 
            this.panel_order_header.ColumnCount = 7;
            this.panel_order_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_order_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.panel_order_header.Controls.Add(this.label10, 0, 0);
            this.panel_order_header.Controls.Add(this.label11, 1, 0);
            this.panel_order_header.Controls.Add(this.label12, 2, 0);
            this.panel_order_header.Controls.Add(this.label13, 3, 0);
            this.panel_order_header.Controls.Add(this.label14, 4, 0);
            this.panel_order_header.Controls.Add(this.label15, 5, 0);
            this.panel_order_header.Controls.Add(this.label16, 6, 0);
            this.panel_order_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_order_header.Location = new System.Drawing.Point(30, 0);
            this.panel_order_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_order_header.Name = "panel_order_header";
            this.panel_order_header.RowCount = 1;
            this.panel_order_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_order_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.panel_order_header.Size = new System.Drawing.Size(900, 24);
            this.panel_order_header.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(1, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "ACCOUNT NO.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(129, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "SYMBOL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(257, 1);
            this.label12.Margin = new System.Windows.Forms.Padding(1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "LOT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(385, 1);
            this.label13.Margin = new System.Windows.Forms.Padding(1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "SELL";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightGray;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.Location = new System.Drawing.Point(513, 1);
            this.label14.Margin = new System.Windows.Forms.Padding(1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "BUY";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label15.Location = new System.Drawing.Point(641, 1);
            this.label15.Margin = new System.Windows.Forms.Padding(1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "SPREAD";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label16.Location = new System.Drawing.Point(769, 1);
            this.label16.Margin = new System.Windows.Forms.Padding(1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 22);
            this.label16.TabIndex = 6;
            this.label16.Text = "P/L";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_order1_close
            // 
            this.btn_order1_close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_order1_close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_order1_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_order1_close.Image")));
            this.btn_order1_close.ImageActive = null;
            this.btn_order1_close.Location = new System.Drawing.Point(932, 29);
            this.btn_order1_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_order1_close.Name = "btn_order1_close";
            this.btn_order1_close.Size = new System.Drawing.Size(26, 45);
            this.btn_order1_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_order1_close.TabIndex = 4;
            this.btn_order1_close.TabStop = false;
            this.btn_order1_close.Zoom = 10;
            this.btn_order1_close.Click += new System.EventHandler(this.btn_order1_close_Click);
            // 
            // btn_order2_close
            // 
            this.btn_order2_close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_order2_close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_order2_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_order2_close.Image")));
            this.btn_order2_close.ImageActive = null;
            this.btn_order2_close.Location = new System.Drawing.Point(932, 81);
            this.btn_order2_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_order2_close.Name = "btn_order2_close";
            this.btn_order2_close.Size = new System.Drawing.Size(26, 45);
            this.btn_order2_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_order2_close.TabIndex = 4;
            this.btn_order2_close.TabStop = false;
            this.btn_order2_close.Zoom = 10;
            this.btn_order2_close.Click += new System.EventHandler(this.btn_order2_close_Click);
            // 
            // panel_chart
            // 
            this.panel_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_chart.Controls.Add(this.panel_td_pendingorder);
            this.panel_chart.Controls.Add(this.chart_view);
            this.panel_chart.Location = new System.Drawing.Point(0, 220);
            this.panel_chart.Name = "panel_chart";
            this.panel_chart.Size = new System.Drawing.Size(989, 354);
            this.panel_chart.TabIndex = 0;
            // 
            // panel_td_pendingorder
            // 
            this.panel_td_pendingorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_td_pendingorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.panel_td_pendingorder.Location = new System.Drawing.Point(942, 19);
            this.panel_td_pendingorder.Name = "panel_td_pendingorder";
            this.panel_td_pendingorder.Size = new System.Drawing.Size(8, 296);
            this.panel_td_pendingorder.TabIndex = 1;
            this.panel_td_pendingorder.Visible = false;
            this.panel_td_pendingorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_td_pendingorder_MouseClick);
            this.panel_td_pendingorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_td_pendingorder_MouseMove);
            // 
            // chart_view
            // 
            chartArea13.Name = "ChartArea1";
            this.chart_view.ChartAreas.Add(chartArea13);
            this.chart_view.Dock = System.Windows.Forms.DockStyle.Fill;
            legend13.Enabled = false;
            legend13.Name = "Legend1";
            this.chart_view.Legends.Add(legend13);
            this.chart_view.Location = new System.Drawing.Point(0, 0);
            this.chart_view.Margin = new System.Windows.Forms.Padding(0);
            this.chart_view.Name = "chart_view";
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series37.CustomProperties = "PointWidth=0.5";
            series37.Legend = "Legend1";
            series37.Name = "stocks";
            series37.YValuesPerPoint = 4;
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.Legend = "Legend1";
            series38.Name = "line1";
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Legend = "Legend1";
            series39.Name = "line2";
            this.chart_view.Series.Add(series37);
            this.chart_view.Series.Add(series38);
            this.chart_view.Series.Add(series39);
            this.chart_view.Size = new System.Drawing.Size(989, 354);
            this.chart_view.TabIndex = 0;
            this.chart_view.Text = "chart1";
            title21.DockedToChartArea = "ChartArea1";
            title21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title21.ForeColor = System.Drawing.Color.Red;
            title21.Name = "Title1";
            title21.Text = "0 Days at BREAK EVEN";
            title21.Visible = false;
            this.chart_view.Titles.Add(title21);
            this.chart_view.Paint += new System.Windows.Forms.PaintEventHandler(this.Chart_view_Paint);
            // 
            // panel_details
            // 
            this.panel_details.BackColor = System.Drawing.Color.White;
            this.panel_details.Controls.Add(this.tableLayoutPanel16);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.Location = new System.Drawing.Point(0, 60);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(990, 730);
            this.panel_details.TabIndex = 4;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.CausesValidation = false;
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.panel12, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.panel13, 0, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.ctrl_account_details);
            this.panel12.Controls.Add(this.ctrl_header_details);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panel12.Size = new System.Drawing.Size(990, 102);
            this.panel12.TabIndex = 1;
            // 
            // ctrl_account_details
            // 
            this.ctrl_account_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_account_details.Location = new System.Drawing.Point(0, 32);
            this.ctrl_account_details.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_account_details.Name = "ctrl_account_details";
            this.ctrl_account_details.Size = new System.Drawing.Size(960, 70);
            this.ctrl_account_details.TabIndex = 1;
            // 
            // ctrl_header_details
            // 
            this.ctrl_header_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.ctrl_header_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrl_header_details.Location = new System.Drawing.Point(0, 0);
            this.ctrl_header_details.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_header_details.Name = "ctrl_header_details";
            this.ctrl_header_details.Size = new System.Drawing.Size(960, 32);
            this.ctrl_header_details.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.swap_dt_picker);
            this.panel13.Controls.Add(this.label39);
            this.panel13.Controls.Add(this.label35);
            this.panel13.Controls.Add(this.label37);
            this.panel13.Controls.Add(this.label34);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.label30);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.tb_phone_number);
            this.panel13.Controls.Add(this.tb_notification);
            this.panel13.Controls.Add(this.btn_notification_save);
            this.panel13.Controls.Add(this.label47);
            this.panel13.Controls.Add(this.label66);
            this.panel13.Controls.Add(this.label48);
            this.panel13.Controls.Add(this.label33);
            this.panel13.Controls.Add(this.btn_phone_number_save);
            this.panel13.Controls.Add(this.btn_money_difference_save);
            this.panel13.Controls.Add(this.btn_margin_alert_save);
            this.panel13.Controls.Add(this.btn_margin_call_save);
            this.panel13.Controls.Add(this.label36);
            this.panel13.Controls.Add(this.label19);
            this.panel13.Controls.Add(this.label38);
            this.panel13.Controls.Add(this.lab_hedge_account2);
            this.panel13.Controls.Add(this.lab_hedge_account1);
            this.panel13.Controls.Add(this.lab_details_account2);
            this.panel13.Controls.Add(this.lab_details_account1);
            this.panel13.Controls.Add(this.cb_hedge2);
            this.panel13.Controls.Add(this.tb_moneyshift);
            this.panel13.Controls.Add(this.cb_swapfree2);
            this.panel13.Controls.Add(this.cb_hedge1);
            this.panel13.Controls.Add(this.cb_close_trades);
            this.panel13.Controls.Add(this.cb_swapfree1);
            this.panel13.Controls.Add(this.label49);
            this.panel13.Controls.Add(this.cb_moneyshift_onoff);
            this.panel13.Controls.Add(this.label45);
            this.panel13.Controls.Add(this.cb_pamm_onoff);
            this.panel13.Controls.Add(this.label241);
            this.panel13.Controls.Add(this.tb_margin_call);
            this.panel13.Controls.Add(this.label239);
            this.panel13.Controls.Add(this.label240);
            this.panel13.Controls.Add(this.tb_margin_alert);
            this.panel13.Controls.Add(this.label238);
            this.panel13.Controls.Add(this.label237);
            this.panel13.Controls.Add(this.lab_details_breakeven);
            this.panel13.Controls.Add(this.lab_details_swap_tot);
            this.panel13.Controls.Add(this.label225);
            this.panel13.Controls.Add(this.label229);
            this.panel13.Controls.Add(this.label224);
            this.panel13.Controls.Add(this.label217);
            this.panel13.Controls.Add(this.label219);
            this.panel13.Controls.Add(this.label213);
            this.panel13.Controls.Add(this.label44);
            this.panel13.Controls.Add(this.label214);
            this.panel13.Controls.Add(this.label208);
            this.panel13.Controls.Add(this.label209);
            this.panel13.Controls.Add(this.label202);
            this.panel13.Controls.Add(this.label203);
            this.panel13.Controls.Add(this.label204);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 102);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(990, 628);
            this.panel13.TabIndex = 2;
            // 
            // swap_dt_picker
            // 
            this.swap_dt_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.swap_dt_picker.Location = new System.Drawing.Point(111, 65);
            this.swap_dt_picker.Name = "swap_dt_picker";
            this.swap_dt_picker.Size = new System.Drawing.Size(112, 23);
            this.swap_dt_picker.TabIndex = 137;
            this.swap_dt_picker.Value = new System.DateTime(2020, 2, 1, 0, 0, 0, 0);
            this.swap_dt_picker.ValueChanged += new System.EventHandler(this.swap_dt_picker_ValueChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label39.Location = new System.Drawing.Point(539, 207);
            this.label39.Margin = new System.Windows.Forms.Padding(0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(28, 17);
            this.label39.TabIndex = 136;
            this.label39.Text = "Pip";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label35.Location = new System.Drawing.Point(25, 522);
            this.label35.Margin = new System.Windows.Forms.Padding(0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(800, 1);
            this.label35.TabIndex = 135;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label37.Location = new System.Drawing.Point(23, 501);
            this.label37.Margin = new System.Windows.Forms.Padding(0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(180, 20);
            this.label37.TabIndex = 134;
            this.label37.Text = "HEDGE ON/OFF";
            this.label37.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label34.Location = new System.Drawing.Point(21, 421);
            this.label34.Margin = new System.Windows.Forms.Padding(0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(800, 1);
            this.label34.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label7.Location = new System.Drawing.Point(26, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(800, 1);
            this.label7.TabIndex = 132;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label30.Location = new System.Drawing.Point(23, 134);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(186, 20);
            this.label30.TabIndex = 131;
            this.label30.Text = "AUTOMATIC";
            this.label30.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(751, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 130;
            this.label2.Text = "Days";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_phone_number
            // 
            this.tb_phone_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_phone_number.Location = new System.Drawing.Point(217, 302);
            this.tb_phone_number.Margin = new System.Windows.Forms.Padding(0);
            this.tb_phone_number.Name = "tb_phone_number";
            this.tb_phone_number.Size = new System.Drawing.Size(136, 16);
            this.tb_phone_number.TabIndex = 129;
            this.tb_phone_number.Text = "0041787805050";
            this.tb_phone_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_notification
            // 
            this.tb_notification.BackColor = System.Drawing.Color.Orange;
            this.tb_notification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_notification.Location = new System.Drawing.Point(215, 342);
            this.tb_notification.Margin = new System.Windows.Forms.Padding(0);
            this.tb_notification.Name = "tb_notification";
            this.tb_notification.Size = new System.Drawing.Size(71, 16);
            this.tb_notification.TabIndex = 128;
            this.tb_notification.Text = "80";
            this.tb_notification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_notification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // btn_notification_save
            // 
            this.btn_notification_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_notification_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_notification_save.Image")));
            this.btn_notification_save.ImageActive = null;
            this.btn_notification_save.Location = new System.Drawing.Point(349, 336);
            this.btn_notification_save.Name = "btn_notification_save";
            this.btn_notification_save.Size = new System.Drawing.Size(30, 30);
            this.btn_notification_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_notification_save.TabIndex = 120;
            this.btn_notification_save.TabStop = false;
            this.btn_notification_save.Zoom = 20;
            this.btn_notification_save.Click += new System.EventHandler(this.btn_notification_save_Click);
            // 
            // label47
            // 
            this.label47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label47.Location = new System.Drawing.Point(683, 98);
            this.label47.Margin = new System.Windows.Forms.Padding(0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(76, 23);
            this.label47.TabIndex = 113;
            this.label47.Text = "ON / OFF";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label66
            // 
            this.label66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label66.Location = new System.Drawing.Point(591, 566);
            this.label66.Margin = new System.Windows.Forms.Padding(0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(150, 23);
            this.label66.TabIndex = 113;
            this.label66.Text = "HEDGE ON / OFF";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label48
            // 
            this.label48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label48.Location = new System.Drawing.Point(597, 467);
            this.label48.Margin = new System.Windows.Forms.Padding(0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(150, 23);
            this.label48.TabIndex = 113;
            this.label48.Text = "SWAP FREE ON / OFF";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label33.Location = new System.Drawing.Point(683, 204);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 23);
            this.label33.TabIndex = 113;
            this.label33.Text = "ON / OFF";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_phone_number_save
            // 
            this.btn_phone_number_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_phone_number_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_phone_number_save.Image")));
            this.btn_phone_number_save.ImageActive = null;
            this.btn_phone_number_save.Location = new System.Drawing.Point(350, 296);
            this.btn_phone_number_save.Name = "btn_phone_number_save";
            this.btn_phone_number_save.Size = new System.Drawing.Size(30, 30);
            this.btn_phone_number_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_phone_number_save.TabIndex = 119;
            this.btn_phone_number_save.TabStop = false;
            this.btn_phone_number_save.Zoom = 20;
            this.btn_phone_number_save.Click += new System.EventHandler(this.btn_phone_number_save_Click);
            // 
            // btn_money_difference_save
            // 
            this.btn_money_difference_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_money_difference_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_money_difference_save.Image")));
            this.btn_money_difference_save.ImageActive = null;
            this.btn_money_difference_save.Location = new System.Drawing.Point(571, 200);
            this.btn_money_difference_save.Name = "btn_money_difference_save";
            this.btn_money_difference_save.Size = new System.Drawing.Size(30, 30);
            this.btn_money_difference_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_money_difference_save.TabIndex = 112;
            this.btn_money_difference_save.TabStop = false;
            this.btn_money_difference_save.Zoom = 20;
            this.btn_money_difference_save.Click += new System.EventHandler(this.btn_moneyshift_save_Click);
            // 
            // btn_margin_alert_save
            // 
            this.btn_margin_alert_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_margin_alert_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_margin_alert_save.Image")));
            this.btn_margin_alert_save.ImageActive = null;
            this.btn_margin_alert_save.Location = new System.Drawing.Point(759, 296);
            this.btn_margin_alert_save.Name = "btn_margin_alert_save";
            this.btn_margin_alert_save.Size = new System.Drawing.Size(30, 30);
            this.btn_margin_alert_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_margin_alert_save.TabIndex = 111;
            this.btn_margin_alert_save.TabStop = false;
            this.btn_margin_alert_save.Zoom = 20;
            this.btn_margin_alert_save.Click += new System.EventHandler(this.btn_margin_alert_save_Click);
            // 
            // btn_margin_call_save
            // 
            this.btn_margin_call_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_margin_call_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_margin_call_save.Image")));
            this.btn_margin_call_save.ImageActive = null;
            this.btn_margin_call_save.Location = new System.Drawing.Point(759, 345);
            this.btn_margin_call_save.Name = "btn_margin_call_save";
            this.btn_margin_call_save.Size = new System.Drawing.Size(30, 30);
            this.btn_margin_call_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_margin_call_save.TabIndex = 3;
            this.btn_margin_call_save.TabStop = false;
            this.btn_margin_call_save.Zoom = 20;
            this.btn_margin_call_save.Click += new System.EventHandler(this.btn_margin_call_save_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label36.Location = new System.Drawing.Point(30, 300);
            this.label36.Margin = new System.Windows.Forms.Padding(0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(168, 17);
            this.label36.TabIndex = 116;
            this.label36.Text = "SMARTPHONE NUMBER";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(31, 363);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 23);
            this.label19.TabIndex = 114;
            this.label19.Text = "(EMPTY or ZERO = OFF)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label38.Location = new System.Drawing.Point(29, 340);
            this.label38.Margin = new System.Windows.Forms.Padding(0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(152, 23);
            this.label38.TabIndex = 114;
            this.label38.Text = "ALARM BY FREE PIP";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_hedge_account2
            // 
            this.lab_hedge_account2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_hedge_account2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_hedge_account2.Location = new System.Drawing.Point(30, 566);
            this.lab_hedge_account2.Margin = new System.Windows.Forms.Padding(0);
            this.lab_hedge_account2.Name = "lab_hedge_account2";
            this.lab_hedge_account2.Size = new System.Drawing.Size(178, 23);
            this.lab_hedge_account2.TabIndex = 94;
            this.lab_hedge_account2.Text = "ACCOUNT";
            this.lab_hedge_account2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_hedge_account1
            // 
            this.lab_hedge_account1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_hedge_account1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_hedge_account1.Location = new System.Drawing.Point(30, 538);
            this.lab_hedge_account1.Margin = new System.Windows.Forms.Padding(0);
            this.lab_hedge_account1.Name = "lab_hedge_account1";
            this.lab_hedge_account1.Size = new System.Drawing.Size(184, 23);
            this.lab_hedge_account1.TabIndex = 91;
            this.lab_hedge_account1.Text = "ACCOUNT";
            this.lab_hedge_account1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_details_account2
            // 
            this.lab_details_account2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_details_account2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_details_account2.Location = new System.Drawing.Point(30, 467);
            this.lab_details_account2.Margin = new System.Windows.Forms.Padding(0);
            this.lab_details_account2.Name = "lab_details_account2";
            this.lab_details_account2.Size = new System.Drawing.Size(178, 23);
            this.lab_details_account2.TabIndex = 94;
            this.lab_details_account2.Text = "ACCOUNT";
            this.lab_details_account2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_details_account1
            // 
            this.lab_details_account1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_details_account1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_details_account1.Location = new System.Drawing.Point(30, 439);
            this.lab_details_account1.Margin = new System.Windows.Forms.Padding(0);
            this.lab_details_account1.Name = "lab_details_account1";
            this.lab_details_account1.Size = new System.Drawing.Size(184, 23);
            this.lab_details_account1.TabIndex = 91;
            this.lab_details_account1.Text = "ACCOUNT";
            this.lab_details_account1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_hedge2
            // 
            this.cb_hedge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_hedge2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_hedge2.Checked = false;
            this.cb_hedge2.CheckedOnColor = System.Drawing.Color.Green;
            this.cb_hedge2.ForeColor = System.Drawing.Color.White;
            this.cb_hedge2.Location = new System.Drawing.Point(764, 567);
            this.cb_hedge2.Name = "cb_hedge2";
            this.cb_hedge2.Size = new System.Drawing.Size(20, 20);
            this.cb_hedge2.TabIndex = 75;
            this.cb_hedge2.OnChange += new System.EventHandler(this.cb_hedge_OnChange);
            // 
            // tb_moneyshift
            // 
            this.tb_moneyshift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_moneyshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_moneyshift.Location = new System.Drawing.Point(489, 207);
            this.tb_moneyshift.Margin = new System.Windows.Forms.Padding(0);
            this.tb_moneyshift.Name = "tb_moneyshift";
            this.tb_moneyshift.Size = new System.Drawing.Size(45, 16);
            this.tb_moneyshift.TabIndex = 90;
            this.tb_moneyshift.Text = "10";
            this.tb_moneyshift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_moneyshift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // cb_swapfree2
            // 
            this.cb_swapfree2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_swapfree2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_swapfree2.Checked = false;
            this.cb_swapfree2.CheckedOnColor = System.Drawing.Color.Green;
            this.cb_swapfree2.ForeColor = System.Drawing.Color.White;
            this.cb_swapfree2.Location = new System.Drawing.Point(764, 468);
            this.cb_swapfree2.Name = "cb_swapfree2";
            this.cb_swapfree2.Size = new System.Drawing.Size(20, 20);
            this.cb_swapfree2.TabIndex = 75;
            this.cb_swapfree2.OnChange += new System.EventHandler(this.cb_swapfree_OnChange);
            // 
            // cb_hedge1
            // 
            this.cb_hedge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_hedge1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_hedge1.Checked = false;
            this.cb_hedge1.CheckedOnColor = System.Drawing.Color.Green;
            this.cb_hedge1.ForeColor = System.Drawing.Color.White;
            this.cb_hedge1.Location = new System.Drawing.Point(764, 539);
            this.cb_hedge1.Name = "cb_hedge1";
            this.cb_hedge1.Size = new System.Drawing.Size(20, 20);
            this.cb_hedge1.TabIndex = 71;
            this.cb_hedge1.OnChange += new System.EventHandler(this.cb_hedge_OnChange);
            // 
            // cb_close_trades
            // 
            this.cb_close_trades.BackColor = System.Drawing.Color.Green;
            this.cb_close_trades.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_close_trades.Checked = true;
            this.cb_close_trades.CheckedOnColor = System.Drawing.Color.Green;
            this.cb_close_trades.ForeColor = System.Drawing.Color.White;
            this.cb_close_trades.Location = new System.Drawing.Point(764, 99);
            this.cb_close_trades.Name = "cb_close_trades";
            this.cb_close_trades.Size = new System.Drawing.Size(20, 20);
            this.cb_close_trades.TabIndex = 75;
            this.cb_close_trades.OnChange += new System.EventHandler(this.cb_close_trades_OnChange);
            // 
            // cb_swapfree1
            // 
            this.cb_swapfree1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_swapfree1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_swapfree1.Checked = false;
            this.cb_swapfree1.CheckedOnColor = System.Drawing.Color.Green;
            this.cb_swapfree1.ForeColor = System.Drawing.Color.White;
            this.cb_swapfree1.Location = new System.Drawing.Point(764, 440);
            this.cb_swapfree1.Name = "cb_swapfree1";
            this.cb_swapfree1.Size = new System.Drawing.Size(20, 20);
            this.cb_swapfree1.TabIndex = 71;
            this.cb_swapfree1.OnChange += new System.EventHandler(this.cb_swapfree_OnChange);
            // 
            // label49
            // 
            this.label49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label49.Location = new System.Drawing.Point(591, 538);
            this.label49.Margin = new System.Windows.Forms.Padding(0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(150, 23);
            this.label49.TabIndex = 70;
            this.label49.Text = "HEDGE ON / OFF";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_moneyshift_onoff
            // 
            this.cb_moneyshift_onoff.BackColor = System.Drawing.Color.Green;
            this.cb_moneyshift_onoff.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_moneyshift_onoff.Checked = true;
            this.cb_moneyshift_onoff.CheckedOnColor = System.Drawing.Color.Green;
            this.cb_moneyshift_onoff.ForeColor = System.Drawing.Color.White;
            this.cb_moneyshift_onoff.Location = new System.Drawing.Point(764, 205);
            this.cb_moneyshift_onoff.Name = "cb_moneyshift_onoff";
            this.cb_moneyshift_onoff.Size = new System.Drawing.Size(20, 20);
            this.cb_moneyshift_onoff.TabIndex = 75;
            this.cb_moneyshift_onoff.OnChange += new System.EventHandler(this.cb_money_shift_onoff_OnChange);
            // 
            // label45
            // 
            this.label45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label45.Location = new System.Drawing.Point(597, 439);
            this.label45.Margin = new System.Windows.Forms.Padding(0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(150, 23);
            this.label45.TabIndex = 70;
            this.label45.Text = "SWAP FREE ON / OFF";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_pamm_onoff
            // 
            this.cb_pamm_onoff.BackColor = System.Drawing.Color.Green;
            this.cb_pamm_onoff.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_pamm_onoff.Checked = true;
            this.cb_pamm_onoff.CheckedOnColor = System.Drawing.Color.Green;
            this.cb_pamm_onoff.ForeColor = System.Drawing.Color.White;
            this.cb_pamm_onoff.Location = new System.Drawing.Point(764, 171);
            this.cb_pamm_onoff.Name = "cb_pamm_onoff";
            this.cb_pamm_onoff.Size = new System.Drawing.Size(20, 20);
            this.cb_pamm_onoff.TabIndex = 71;
            this.cb_pamm_onoff.OnChange += new System.EventHandler(this.cb_pamm_onoff_OnChange);
            // 
            // label241
            // 
            this.label241.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label241.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label241.Location = new System.Drawing.Point(683, 170);
            this.label241.Margin = new System.Windows.Forms.Padding(0);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(76, 23);
            this.label241.TabIndex = 70;
            this.label241.Text = "ON / OFF";
            this.label241.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_margin_call
            // 
            this.tb_margin_call.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_margin_call.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_margin_call.Location = new System.Drawing.Point(633, 351);
            this.tb_margin_call.Margin = new System.Windows.Forms.Padding(0);
            this.tb_margin_call.Name = "tb_margin_call";
            this.tb_margin_call.Size = new System.Drawing.Size(60, 16);
            this.tb_margin_call.TabIndex = 68;
            this.tb_margin_call.Text = "10";
            this.tb_margin_call.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_margin_call.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label239
            // 
            this.label239.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label239.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label239.Location = new System.Drawing.Point(425, 349);
            this.label239.Margin = new System.Windows.Forms.Padding(0);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(220, 23);
            this.label239.TabIndex = 67;
            this.label239.Text = "MARGIN CALL BY FREE PIP";
            this.label239.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label240
            // 
            this.label240.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.label240.Location = new System.Drawing.Point(427, 373);
            this.label240.Margin = new System.Windows.Forms.Padding(0);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(280, 3);
            this.label240.TabIndex = 69;
            // 
            // tb_margin_alert
            // 
            this.tb_margin_alert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_margin_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_margin_alert.Location = new System.Drawing.Point(633, 302);
            this.tb_margin_alert.Margin = new System.Windows.Forms.Padding(0);
            this.tb_margin_alert.Name = "tb_margin_alert";
            this.tb_margin_alert.Size = new System.Drawing.Size(60, 16);
            this.tb_margin_alert.TabIndex = 65;
            this.tb_margin_alert.Text = "20";
            this.tb_margin_alert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_margin_alert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label238
            // 
            this.label238.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label238.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label238.Location = new System.Drawing.Point(425, 300);
            this.label238.Margin = new System.Windows.Forms.Padding(0);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(220, 23);
            this.label238.TabIndex = 64;
            this.label238.Text = "MARGIN ALERT BY FREE PIP";
            this.label238.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label237
            // 
            this.label237.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(195)))), ((int)(((byte)(71)))));
            this.label237.Location = new System.Drawing.Point(427, 324);
            this.label237.Margin = new System.Windows.Forms.Padding(0);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(280, 3);
            this.label237.TabIndex = 66;
            // 
            // lab_details_breakeven
            // 
            this.lab_details_breakeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_details_breakeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_details_breakeven.Location = new System.Drawing.Point(681, 66);
            this.lab_details_breakeven.Margin = new System.Windows.Forms.Padding(0);
            this.lab_details_breakeven.Name = "lab_details_breakeven";
            this.lab_details_breakeven.Size = new System.Drawing.Size(66, 23);
            this.lab_details_breakeven.TabIndex = 54;
            this.lab_details_breakeven.Text = "4";
            this.lab_details_breakeven.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_details_swap_tot
            // 
            this.lab_details_swap_tot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_details_swap_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_details_swap_tot.Location = new System.Drawing.Point(283, 66);
            this.lab_details_swap_tot.Margin = new System.Windows.Forms.Padding(0);
            this.lab_details_swap_tot.Name = "lab_details_swap_tot";
            this.lab_details_swap_tot.Size = new System.Drawing.Size(105, 23);
            this.lab_details_swap_tot.TabIndex = 52;
            this.lab_details_swap_tot.Text = "5872";
            this.lab_details_swap_tot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label225
            // 
            this.label225.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label225.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label225.Location = new System.Drawing.Point(425, 66);
            this.label225.Margin = new System.Windows.Forms.Padding(0);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(149, 23);
            this.label225.TabIndex = 50;
            this.label225.Text = "BREAK EVEN";
            this.label225.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label229
            // 
            this.label229.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label229.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label229.Location = new System.Drawing.Point(30, 66);
            this.label229.Margin = new System.Windows.Forms.Padding(0);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(69, 23);
            this.label229.TabIndex = 46;
            this.label229.Text = "SWAP";
            this.label229.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label224
            // 
            this.label224.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label224.Location = new System.Drawing.Point(23, 400);
            this.label224.Margin = new System.Windows.Forms.Padding(0);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(150, 20);
            this.label224.TabIndex = 41;
            this.label224.Text = "SWAP ON/OFF";
            this.label224.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label217
            // 
            this.label217.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label217.Location = new System.Drawing.Point(25, 274);
            this.label217.Margin = new System.Windows.Forms.Padding(0);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(800, 1);
            this.label217.TabIndex = 38;
            // 
            // label219
            // 
            this.label219.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label219.Location = new System.Drawing.Point(23, 253);
            this.label219.Margin = new System.Windows.Forms.Padding(0);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(180, 20);
            this.label219.TabIndex = 36;
            this.label219.Text = "ALERT NOTIFICATION";
            this.label219.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label213.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label213.Location = new System.Drawing.Point(218, 207);
            this.label213.Margin = new System.Windows.Forms.Padding(0);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(282, 17);
            this.label213.TabIndex = 32;
            this.label213.Text = "INTERNER GELD TRANSFER AUTOMATIK";
            this.label213.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label213.Visible = false;
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label44.Location = new System.Drawing.Point(30, 99);
            this.label44.Margin = new System.Windows.Forms.Padding(0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(209, 20);
            this.label44.TabIndex = 31;
            this.label44.Text = "CLOSE TRADES AFTER 30 DAYS";
            this.label44.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label214
            // 
            this.label214.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label214.Location = new System.Drawing.Point(30, 205);
            this.label214.Margin = new System.Windows.Forms.Padding(0);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(209, 20);
            this.label214.TabIndex = 31;
            this.label214.Text = "MONEY SHIFT AUTOMATIC ";
            this.label214.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label208
            // 
            this.label208.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label208.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label208.Location = new System.Drawing.Point(84, 170);
            this.label208.Margin = new System.Windows.Forms.Padding(0);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(220, 20);
            this.label208.TabIndex = 27;
            this.label208.Text = "AUTOMATISCHER HANDEL";
            this.label208.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label208.Visible = false;
            // 
            // label209
            // 
            this.label209.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label209.Location = new System.Drawing.Point(30, 170);
            this.label209.Margin = new System.Windows.Forms.Padding(0);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(150, 20);
            this.label209.TabIndex = 26;
            this.label209.Text = "PAMM ";
            this.label209.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label202
            // 
            this.label202.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label202.Location = new System.Drawing.Point(25, 52);
            this.label202.Margin = new System.Windows.Forms.Padding(0);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(800, 1);
            this.label202.TabIndex = 23;
            // 
            // label203
            // 
            this.label203.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label203.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label203.Location = new System.Drawing.Point(108, 31);
            this.label203.Margin = new System.Windows.Forms.Padding(0);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(150, 20);
            this.label203.TabIndex = 22;
            this.label203.Text = "ZINSERTRAG";
            this.label203.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label203.Visible = false;
            // 
            // label204
            // 
            this.label204.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label204.Location = new System.Drawing.Point(23, 31);
            this.label204.Margin = new System.Windows.Forms.Padding(0);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(150, 20);
            this.label204.TabIndex = 21;
            this.label204.Text = "INTEREST ";
            this.label204.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.White;
            this.panel_login.Controls.Add(this.tableLayoutPanel4);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Location = new System.Drawing.Point(0, 60);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(990, 730);
            this.panel_login.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label53, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label52, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.flow_clients, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel17, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel18, 1, 7);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Location = new System.Drawing.Point(20, 217);
            this.label53.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(950, 1);
            this.label53.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dt_picker);
            this.panel2.Controls.Add(this.tb_license);
            this.panel2.Controls.Add(this.tb_client_search);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label51);
            this.panel2.Controls.Add(this.btn_login_new_account);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 50);
            this.panel2.TabIndex = 0;
            // 
            // dt_picker
            // 
            this.dt_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dt_picker.Location = new System.Drawing.Point(365, 12);
            this.dt_picker.Name = "dt_picker";
            this.dt_picker.Size = new System.Drawing.Size(112, 23);
            this.dt_picker.TabIndex = 4;
            this.dt_picker.Value = new System.DateTime(2019, 9, 19, 0, 0, 0, 0);
            this.dt_picker.ValueChanged += new System.EventHandler(this.dt_picker_ValueChanged);
            // 
            // tb_license
            // 
            this.tb_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_license.Location = new System.Drawing.Point(182, 12);
            this.tb_license.Name = "tb_license";
            this.tb_license.Size = new System.Drawing.Size(100, 24);
            this.tb_license.TabIndex = 3;
            this.tb_license.Text = "123-456-789";
            this.tb_license.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_license.TextChanged += new System.EventHandler(this.tb_license_TextChanged);
            // 
            // tb_client_search
            // 
            this.tb_client_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_client_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_client_search.Location = new System.Drawing.Point(845, 12);
            this.tb_client_search.Name = "tb_client_search";
            this.tb_client_search.Size = new System.Drawing.Size(100, 24);
            this.tb_client_search.TabIndex = 3;
            this.tb_client_search.TextChanged += new System.EventHandler(this.tb_client_search_TextChanged);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(109, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 44);
            this.label20.TabIndex = 2;
            this.label20.Text = "LICENSE";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.Location = new System.Drawing.Point(300, 3);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 44);
            this.label22.TabIndex = 2;
            this.label22.Text = "EXPIRY";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label51.Location = new System.Drawing.Point(779, 3);
            this.label51.Margin = new System.Windows.Forms.Padding(0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(70, 44);
            this.label51.TabIndex = 2;
            this.label51.Text = "SEARCH";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login_new_account
            // 
            this.btn_login_new_account.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_login_new_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_login_new_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login_new_account.BorderRadius = 0;
            this.btn_login_new_account.ButtonText = "LOGIN";
            this.btn_login_new_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_new_account.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_login_new_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_login_new_account.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login_new_account.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_login_new_account.Iconimage")));
            this.btn_login_new_account.Iconimage_right = null;
            this.btn_login_new_account.Iconimage_right_Selected = null;
            this.btn_login_new_account.Iconimage_Selected = null;
            this.btn_login_new_account.IconMarginLeft = 0;
            this.btn_login_new_account.IconMarginRight = 0;
            this.btn_login_new_account.IconRightVisible = true;
            this.btn_login_new_account.IconRightZoom = 0D;
            this.btn_login_new_account.IconVisible = false;
            this.btn_login_new_account.IconZoom = 90D;
            this.btn_login_new_account.IsTab = false;
            this.btn_login_new_account.Location = new System.Drawing.Point(4, 3);
            this.btn_login_new_account.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.btn_login_new_account.Name = "btn_login_new_account";
            this.btn_login_new_account.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_login_new_account.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.btn_login_new_account.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_login_new_account.selected = false;
            this.btn_login_new_account.Size = new System.Drawing.Size(104, 44);
            this.btn_login_new_account.TabIndex = 1;
            this.btn_login_new_account.Text = "LOGIN";
            this.btn_login_new_account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login_new_account.Textcolor = System.Drawing.Color.Black;
            this.btn_login_new_account.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_login_new_account.Click += new System.EventHandler(this.btn_login_new_account_Click);
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Location = new System.Drawing.Point(20, 62);
            this.label52.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(950, 1);
            this.label52.TabIndex = 2;
            // 
            // flow_clients
            // 
            this.flow_clients.AutoScroll = true;
            this.flow_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_clients.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_clients.Location = new System.Drawing.Point(22, 222);
            this.flow_clients.Margin = new System.Windows.Forms.Padding(2);
            this.flow_clients.Name = "flow_clients";
            this.flow_clients.Size = new System.Drawing.Size(946, 481);
            this.flow_clients.TabIndex = 6;
            this.flow_clients.WrapContents = false;
            this.flow_clients.Resize += new System.EventHandler(this.flow_ctrl_Resize);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Controls.Add(this.ctrl_client, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(23, 68);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(944, 104);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // ctrl_client
            // 
            this.ctrl_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrl_client.Location = new System.Drawing.Point(3, 3);
            this.ctrl_client.m_is_confirmed = false;
            this.ctrl_client.Name = "ctrl_client";
            this.ctrl_client.Size = new System.Drawing.Size(908, 98);
            this.ctrl_client.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 10);
            this.panel3.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Controls.Add(this.label58, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label57, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label56, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label55, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label54, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 0, 70, 0);
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(754, 20);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Visible = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label58.Location = new System.Drawing.Point(505, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(176, 20);
            this.label58.TabIndex = 4;
            this.label58.Text = "CLIENT NAME";
            this.label58.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label57.Location = new System.Drawing.Point(369, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(130, 20);
            this.label57.TabIndex = 3;
            this.label57.Text = "PASSWORD";
            this.label57.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label56.Location = new System.Drawing.Point(233, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(130, 20);
            this.label56.TabIndex = 2;
            this.label56.Text = "ACCOUNT NO.";
            this.label56.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label55.Location = new System.Drawing.Point(153, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(34, 20);
            this.label55.TabIndex = 1;
            this.label55.Text = "TYPE";
            this.label55.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label54.Location = new System.Drawing.Point(3, 2);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(144, 18);
            this.label54.TabIndex = 0;
            this.label54.Text = "SERVER";
            this.label54.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 4;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel17.Controls.Add(this.progress, 3, 0);
            this.tableLayoutPanel17.Controls.Add(this.panel14, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.panel19, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(20, 175);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(950, 40);
            this.tableLayoutPanel17.TabIndex = 9;
            // 
            // progress
            // 
            this.progress.animated = true;
            this.progress.animationIterval = 10;
            this.progress.animationSpeed = 5;
            this.progress.BackColor = System.Drawing.Color.White;
            this.progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress.BackgroundImage")));
            this.progress.Dock = System.Windows.Forms.DockStyle.Right;
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progress.ForeColor = System.Drawing.Color.SeaGreen;
            this.progress.LabelVisible = false;
            this.progress.LineProgressThickness = 5;
            this.progress.LineThickness = 4;
            this.progress.Location = new System.Drawing.Point(910, 0);
            this.progress.Margin = new System.Windows.Forms.Padding(0);
            this.progress.MaxValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progress.Size = new System.Drawing.Size(40, 40);
            this.progress.TabIndex = 6;
            this.progress.Value = 30;
            this.progress.Visible = false;
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel14.Controls.Add(this.btn_show_password);
            this.panel14.Controls.Add(this.btn_hide_password);
            this.panel14.Location = new System.Drawing.Point(606, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(60, 40);
            this.panel14.TabIndex = 7;
            // 
            // btn_show_password
            // 
            this.btn_show_password.BackColor = System.Drawing.Color.White;
            this.btn_show_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_show_password.Image = ((System.Drawing.Image)(resources.GetObject("btn_show_password.Image")));
            this.btn_show_password.ImageActive = null;
            this.btn_show_password.Location = new System.Drawing.Point(0, 0);
            this.btn_show_password.Margin = new System.Windows.Forms.Padding(10);
            this.btn_show_password.Name = "btn_show_password";
            this.btn_show_password.Size = new System.Drawing.Size(60, 40);
            this.btn_show_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_show_password.TabIndex = 1;
            this.btn_show_password.TabStop = false;
            this.btn_show_password.Zoom = 20;
            this.btn_show_password.Click += new System.EventHandler(this.btn_show_password_Click);
            // 
            // btn_hide_password
            // 
            this.btn_hide_password.BackColor = System.Drawing.Color.White;
            this.btn_hide_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hide_password.Image = ((System.Drawing.Image)(resources.GetObject("btn_hide_password.Image")));
            this.btn_hide_password.ImageActive = null;
            this.btn_hide_password.Location = new System.Drawing.Point(0, 0);
            this.btn_hide_password.Margin = new System.Windows.Forms.Padding(10);
            this.btn_hide_password.Name = "btn_hide_password";
            this.btn_hide_password.Size = new System.Drawing.Size(60, 40);
            this.btn_hide_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_hide_password.TabIndex = 0;
            this.btn_hide_password.TabStop = false;
            this.btn_hide_password.Zoom = 20;
            this.btn_hide_password.Click += new System.EventHandler(this.btn_hide_password_Click);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label21);
            this.panel19.Controls.Add(this.label60);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(606, 40);
            this.panel19.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label21.Location = new System.Drawing.Point(159, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(202, 38);
            this.label21.TabIndex = 6;
            this.label21.Text = "KUNDEN EINGELOGGT";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label60
            // 
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label60.Location = new System.Drawing.Point(0, 0);
            this.label60.Margin = new System.Windows.Forms.Padding(0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(188, 38);
            this.label60.TabIndex = 5;
            this.label60.Text = "CLIENTS LOGGED IN /";
            this.label60.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 3;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Controls.Add(this.panel15, 1, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(20, 705);
            this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(950, 25);
            this.tableLayoutPanel18.TabIndex = 10;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dp_login_display_num);
            this.panel15.Controls.Add(this.tb_login_page);
            this.panel15.Controls.Add(this.btn_login_prev);
            this.panel15.Controls.Add(this.btn_login_next);
            this.panel15.Controls.Add(this.btn_login_end);
            this.panel15.Controls.Add(this.btn_login_start);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(225, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(500, 25);
            this.panel15.TabIndex = 0;
            // 
            // dp_login_display_num
            // 
            this.dp_login_display_num.BackColor = System.Drawing.Color.Transparent;
            this.dp_login_display_num.BorderRadius = 3;
            this.dp_login_display_num.DisabledColor = System.Drawing.Color.Gray;
            this.dp_login_display_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dp_login_display_num.ForeColor = System.Drawing.Color.Black;
            this.dp_login_display_num.Items = new string[] {
        "30",
        "20"};
            this.dp_login_display_num.Location = new System.Drawing.Point(381, 3);
            this.dp_login_display_num.Margin = new System.Windows.Forms.Padding(0);
            this.dp_login_display_num.Name = "dp_login_display_num";
            this.dp_login_display_num.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_login_display_num.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_login_display_num.selectedIndex = 0;
            this.dp_login_display_num.Size = new System.Drawing.Size(60, 20);
            this.dp_login_display_num.TabIndex = 7;
            this.dp_login_display_num.onItemSelected += new System.EventHandler(this.dp_login_display_num_onItemSelected);
            // 
            // tb_login_page
            // 
            this.tb_login_page.BackColor = System.Drawing.Color.White;
            this.tb_login_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_login_page.Location = new System.Drawing.Point(175, 3);
            this.tb_login_page.Name = "tb_login_page";
            this.tb_login_page.ReadOnly = true;
            this.tb_login_page.Size = new System.Drawing.Size(80, 20);
            this.tb_login_page.TabIndex = 6;
            this.tb_login_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login_prev
            // 
            this.btn_login_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_prev.Image")));
            this.btn_login_prev.ImageActive = null;
            this.btn_login_prev.Location = new System.Drawing.Point(143, 3);
            this.btn_login_prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login_prev.Name = "btn_login_prev";
            this.btn_login_prev.Size = new System.Drawing.Size(20, 20);
            this.btn_login_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_login_prev.TabIndex = 5;
            this.btn_login_prev.TabStop = false;
            this.btn_login_prev.Zoom = 20;
            this.btn_login_prev.Click += new System.EventHandler(this.btn_login_prev_Click);
            // 
            // btn_login_next
            // 
            this.btn_login_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_next.Image")));
            this.btn_login_next.ImageActive = null;
            this.btn_login_next.Location = new System.Drawing.Point(266, 3);
            this.btn_login_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login_next.Name = "btn_login_next";
            this.btn_login_next.Size = new System.Drawing.Size(20, 20);
            this.btn_login_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_login_next.TabIndex = 4;
            this.btn_login_next.TabStop = false;
            this.btn_login_next.Zoom = 20;
            this.btn_login_next.Click += new System.EventHandler(this.btn_login_next_Click);
            // 
            // btn_login_end
            // 
            this.btn_login_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login_end.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_end.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_end.Image")));
            this.btn_login_end.ImageActive = null;
            this.btn_login_end.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_login_end.InitialImage")));
            this.btn_login_end.Location = new System.Drawing.Point(301, 3);
            this.btn_login_end.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login_end.Name = "btn_login_end";
            this.btn_login_end.Size = new System.Drawing.Size(20, 20);
            this.btn_login_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_login_end.TabIndex = 3;
            this.btn_login_end.TabStop = false;
            this.btn_login_end.Zoom = 20;
            this.btn_login_end.Click += new System.EventHandler(this.btn_login_end_Click);
            // 
            // btn_login_start
            // 
            this.btn_login_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_start.Image")));
            this.btn_login_start.ImageActive = null;
            this.btn_login_start.Location = new System.Drawing.Point(108, 3);
            this.btn_login_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login_start.Name = "btn_login_start";
            this.btn_login_start.Size = new System.Drawing.Size(20, 20);
            this.btn_login_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_login_start.TabIndex = 2;
            this.btn_login_start.TabStop = false;
            this.btn_login_start.Zoom = 20;
            this.btn_login_start.Click += new System.EventHandler(this.btn_login_start_Click);
            // 
            // panel_settings
            // 
            this.panel_settings.BackColor = System.Drawing.Color.White;
            this.panel_settings.Controls.Add(this.cb_settings_show_client);
            this.panel_settings.Controls.Add(this.cb_settings_shiftat);
            this.panel_settings.Controls.Add(this.label41);
            this.panel_settings.Controls.Add(this.label28);
            this.panel_settings.Controls.Add(this.textBox5);
            this.panel_settings.Controls.Add(this.lab_settings_font);
            this.panel_settings.Controls.Add(this.label193);
            this.panel_settings.Controls.Add(this.label194);
            this.panel_settings.Controls.Add(this.label195);
            this.panel_settings.Controls.Add(this.label196);
            this.panel_settings.Controls.Add(this.label185);
            this.panel_settings.Controls.Add(this.label187);
            this.panel_settings.Controls.Add(this.label189);
            this.panel_settings.Controls.Add(this.label191);
            this.panel_settings.Controls.Add(this.lab_settings_stick);
            this.panel_settings.Controls.Add(this.lab_settings_short);
            this.panel_settings.Controls.Add(this.lab_settings_long);
            this.panel_settings.Controls.Add(this.lab_settings_grid);
            this.panel_settings.Controls.Add(this.label183);
            this.panel_settings.Controls.Add(this.label184);
            this.panel_settings.Controls.Add(this.label180);
            this.panel_settings.Controls.Add(this.label181);
            this.panel_settings.Controls.Add(this.label176);
            this.panel_settings.Controls.Add(this.label179);
            this.panel_settings.Controls.Add(this.cb_settings_equity);
            this.panel_settings.Controls.Add(this.label172);
            this.panel_settings.Controls.Add(this.cb_settings_pnl);
            this.panel_settings.Controls.Add(this.cb_settings_transfer);
            this.panel_settings.Controls.Add(this.cb_settings_balance);
            this.panel_settings.Controls.Add(this.cb_settings_curr);
            this.panel_settings.Controls.Add(this.label175);
            this.panel_settings.Controls.Add(this.label171);
            this.panel_settings.Controls.Add(this.label173);
            this.panel_settings.Controls.Add(this.lab_settings_pip);
            this.panel_settings.Controls.Add(this.label167);
            this.panel_settings.Controls.Add(this.label168);
            this.panel_settings.Controls.Add(this.label169);
            this.panel_settings.Controls.Add(this.lab_settings_account2);
            this.panel_settings.Controls.Add(this.label166);
            this.panel_settings.Controls.Add(this.label165);
            this.panel_settings.Controls.Add(this.label164);
            this.panel_settings.Controls.Add(this.label162);
            this.panel_settings.Controls.Add(this.label163);
            this.panel_settings.Controls.Add(this.label159);
            this.panel_settings.Controls.Add(this.label160);
            this.panel_settings.Controls.Add(this.label161);
            this.panel_settings.Controls.Add(this.lab_settings_account1);
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_settings.Location = new System.Drawing.Point(0, 60);
            this.panel_settings.Margin = new System.Windows.Forms.Padding(0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(990, 730);
            this.panel_settings.TabIndex = 9;
            // 
            // cb_settings_show_client
            // 
            this.cb_settings_show_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_show_client.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_settings_show_client.Checked = true;
            this.cb_settings_show_client.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_show_client.ForeColor = System.Drawing.Color.White;
            this.cb_settings_show_client.Location = new System.Drawing.Point(714, 306);
            this.cb_settings_show_client.Name = "cb_settings_show_client";
            this.cb_settings_show_client.Size = new System.Drawing.Size(20, 20);
            this.cb_settings_show_client.TabIndex = 71;
            this.cb_settings_show_client.OnChange += new System.EventHandler(this.cb_settings_OnChange);
            // 
            // cb_settings_shiftat
            // 
            this.cb_settings_shiftat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_shiftat.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_settings_shiftat.Checked = true;
            this.cb_settings_shiftat.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_shiftat.ForeColor = System.Drawing.Color.White;
            this.cb_settings_shiftat.Location = new System.Drawing.Point(714, 276);
            this.cb_settings_shiftat.Name = "cb_settings_shiftat";
            this.cb_settings_shiftat.Size = new System.Drawing.Size(20, 20);
            this.cb_settings_shiftat.TabIndex = 71;
            this.cb_settings_shiftat.OnChange += new System.EventHandler(this.cb_settings_OnChange);
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label41.Location = new System.Drawing.Point(467, 306);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(150, 20);
            this.label41.TabIndex = 70;
            this.label41.Text = "SHOW CLIENT";
            this.label41.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label28.Location = new System.Drawing.Point(466, 276);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(150, 20);
            this.label28.TabIndex = 70;
            this.label28.Text = "%";
            this.label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(322, 526);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(57, 16);
            this.textBox5.TabIndex = 69;
            this.textBox5.Text = "10";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Visible = false;
            // 
            // lab_settings_font
            // 
            this.lab_settings_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_settings_font.Location = new System.Drawing.Point(319, 496);
            this.lab_settings_font.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_font.Name = "lab_settings_font";
            this.lab_settings_font.Size = new System.Drawing.Size(150, 20);
            this.lab_settings_font.TabIndex = 68;
            this.lab_settings_font.Text = "ROBOTO";
            this.lab_settings_font.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lab_settings_font.Visible = false;
            this.lab_settings_font.Click += new System.EventHandler(this.lab_font_Click);
            // 
            // label193
            // 
            this.label193.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label193.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label193.Location = new System.Drawing.Point(146, 306);
            this.label193.Margin = new System.Windows.Forms.Padding(0);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(150, 20);
            this.label193.TabIndex = 67;
            this.label193.Text = "DOCHT";
            this.label193.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label194
            // 
            this.label194.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label194.Location = new System.Drawing.Point(38, 306);
            this.label194.Margin = new System.Windows.Forms.Padding(0);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(150, 20);
            this.label194.TabIndex = 66;
            this.label194.Text = "CANDLE STICK /";
            this.label194.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label195
            // 
            this.label195.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label195.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label195.Location = new System.Drawing.Point(150, 276);
            this.label195.Margin = new System.Windows.Forms.Padding(0);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(150, 20);
            this.label195.TabIndex = 65;
            this.label195.Text = "KERZEN SELL";
            this.label195.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label196
            // 
            this.label196.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label196.Location = new System.Drawing.Point(38, 276);
            this.label196.Margin = new System.Windows.Forms.Padding(0);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(150, 20);
            this.label196.TabIndex = 64;
            this.label196.Text = "CANDLE SHORT /";
            this.label196.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label185
            // 
            this.label185.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label185.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label185.Location = new System.Drawing.Point(145, 246);
            this.label185.Margin = new System.Windows.Forms.Padding(0);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(150, 20);
            this.label185.TabIndex = 63;
            this.label185.Text = "KERZEN BUY";
            this.label185.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label187
            // 
            this.label187.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label187.Location = new System.Drawing.Point(38, 246);
            this.label187.Margin = new System.Windows.Forms.Padding(0);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(150, 20);
            this.label187.TabIndex = 62;
            this.label187.Text = "CANDLE LONG /";
            this.label187.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label189
            // 
            this.label189.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label189.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label189.Location = new System.Drawing.Point(130, 216);
            this.label189.Margin = new System.Windows.Forms.Padding(0);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(150, 20);
            this.label189.TabIndex = 61;
            this.label189.Text = "CHART GITTER";
            this.label189.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label191
            // 
            this.label191.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label191.Location = new System.Drawing.Point(38, 216);
            this.label191.Margin = new System.Windows.Forms.Padding(0);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(150, 20);
            this.label191.TabIndex = 60;
            this.label191.Text = "CHART GRID /";
            this.label191.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_settings_stick
            // 
            this.lab_settings_stick.BackColor = System.Drawing.Color.Black;
            this.lab_settings_stick.Location = new System.Drawing.Point(306, 305);
            this.lab_settings_stick.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_stick.Name = "lab_settings_stick";
            this.lab_settings_stick.Size = new System.Drawing.Size(70, 23);
            this.lab_settings_stick.TabIndex = 59;
            this.lab_settings_stick.Click += new System.EventHandler(this.lab_color_Click);
            // 
            // lab_settings_short
            // 
            this.lab_settings_short.BackColor = System.Drawing.Color.Black;
            this.lab_settings_short.Location = new System.Drawing.Point(306, 275);
            this.lab_settings_short.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_short.Name = "lab_settings_short";
            this.lab_settings_short.Size = new System.Drawing.Size(70, 23);
            this.lab_settings_short.TabIndex = 57;
            this.lab_settings_short.Click += new System.EventHandler(this.lab_color_Click);
            // 
            // lab_settings_long
            // 
            this.lab_settings_long.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.lab_settings_long.Location = new System.Drawing.Point(306, 245);
            this.lab_settings_long.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_long.Name = "lab_settings_long";
            this.lab_settings_long.Size = new System.Drawing.Size(70, 23);
            this.lab_settings_long.TabIndex = 55;
            this.lab_settings_long.Click += new System.EventHandler(this.lab_color_Click);
            // 
            // lab_settings_grid
            // 
            this.lab_settings_grid.BackColor = System.Drawing.Color.LightGray;
            this.lab_settings_grid.Location = new System.Drawing.Point(306, 215);
            this.lab_settings_grid.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_grid.Name = "lab_settings_grid";
            this.lab_settings_grid.Size = new System.Drawing.Size(70, 23);
            this.lab_settings_grid.TabIndex = 53;
            this.lab_settings_grid.Click += new System.EventHandler(this.lab_color_Click);
            // 
            // label183
            // 
            this.label183.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label183.Location = new System.Drawing.Point(40, 588);
            this.label183.Margin = new System.Windows.Forms.Padding(0);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(450, 1);
            this.label183.TabIndex = 52;
            this.label183.Visible = false;
            // 
            // label184
            // 
            this.label184.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label184.Location = new System.Drawing.Point(38, 567);
            this.label184.Margin = new System.Windows.Forms.Padding(0);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(150, 20);
            this.label184.TabIndex = 51;
            this.label184.Text = "TRADINGDESK";
            this.label184.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label184.Visible = false;
            // 
            // label180
            // 
            this.label180.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label180.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label180.Location = new System.Drawing.Point(118, 528);
            this.label180.Margin = new System.Windows.Forms.Padding(0);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(150, 20);
            this.label180.TabIndex = 49;
            this.label180.Text = "SCHRIFTGRÖSSE";
            this.label180.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label180.Visible = false;
            // 
            // label181
            // 
            this.label181.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label181.Location = new System.Drawing.Point(38, 528);
            this.label181.Margin = new System.Windows.Forms.Padding(0);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(150, 20);
            this.label181.TabIndex = 48;
            this.label181.Text = "FONT SIZE /";
            this.label181.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label181.Visible = false;
            // 
            // label176
            // 
            this.label176.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label176.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label176.Location = new System.Drawing.Point(122, 497);
            this.label176.Margin = new System.Windows.Forms.Padding(0);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(150, 20);
            this.label176.TabIndex = 47;
            this.label176.Text = "SCHRIFTART";
            this.label176.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label176.Visible = false;
            // 
            // label179
            // 
            this.label179.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label179.Location = new System.Drawing.Point(38, 497);
            this.label179.Margin = new System.Windows.Forms.Padding(0);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(150, 20);
            this.label179.TabIndex = 46;
            this.label179.Text = "FONT TYPE /";
            this.label179.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label179.Visible = false;
            // 
            // cb_settings_equity
            // 
            this.cb_settings_equity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_equity.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_settings_equity.Checked = true;
            this.cb_settings_equity.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_equity.ForeColor = System.Drawing.Color.White;
            this.cb_settings_equity.Location = new System.Drawing.Point(714, 246);
            this.cb_settings_equity.Name = "cb_settings_equity";
            this.cb_settings_equity.Size = new System.Drawing.Size(20, 20);
            this.cb_settings_equity.TabIndex = 45;
            this.cb_settings_equity.OnChange += new System.EventHandler(this.cb_settings_OnChange);
            // 
            // label172
            // 
            this.label172.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label172.Location = new System.Drawing.Point(466, 246);
            this.label172.Margin = new System.Windows.Forms.Padding(0);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(150, 20);
            this.label172.TabIndex = 44;
            this.label172.Text = "EQUITY";
            this.label172.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cb_settings_pnl
            // 
            this.cb_settings_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_pnl.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_settings_pnl.Checked = true;
            this.cb_settings_pnl.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_pnl.ForeColor = System.Drawing.Color.White;
            this.cb_settings_pnl.Location = new System.Drawing.Point(714, 216);
            this.cb_settings_pnl.Name = "cb_settings_pnl";
            this.cb_settings_pnl.Size = new System.Drawing.Size(20, 20);
            this.cb_settings_pnl.TabIndex = 43;
            this.cb_settings_pnl.OnChange += new System.EventHandler(this.cb_settings_OnChange);
            // 
            // cb_settings_transfer
            // 
            this.cb_settings_transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_transfer.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_settings_transfer.Checked = true;
            this.cb_settings_transfer.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_transfer.ForeColor = System.Drawing.Color.White;
            this.cb_settings_transfer.Location = new System.Drawing.Point(714, 156);
            this.cb_settings_transfer.Name = "cb_settings_transfer";
            this.cb_settings_transfer.Size = new System.Drawing.Size(20, 20);
            this.cb_settings_transfer.TabIndex = 42;
            this.cb_settings_transfer.OnChange += new System.EventHandler(this.cb_settings_OnChange);
            // 
            // cb_settings_balance
            // 
            this.cb_settings_balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_balance.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_settings_balance.Checked = true;
            this.cb_settings_balance.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_balance.ForeColor = System.Drawing.Color.White;
            this.cb_settings_balance.Location = new System.Drawing.Point(714, 186);
            this.cb_settings_balance.Name = "cb_settings_balance";
            this.cb_settings_balance.Size = new System.Drawing.Size(20, 20);
            this.cb_settings_balance.TabIndex = 41;
            this.cb_settings_balance.OnChange += new System.EventHandler(this.cb_settings_OnChange);
            // 
            // cb_settings_curr
            // 
            this.cb_settings_curr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_curr.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_settings_curr.Checked = true;
            this.cb_settings_curr.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_settings_curr.ForeColor = System.Drawing.Color.White;
            this.cb_settings_curr.Location = new System.Drawing.Point(714, 126);
            this.cb_settings_curr.Name = "cb_settings_curr";
            this.cb_settings_curr.Size = new System.Drawing.Size(20, 20);
            this.cb_settings_curr.TabIndex = 40;
            this.cb_settings_curr.OnChange += new System.EventHandler(this.cb_settings_OnChange);
            // 
            // label175
            // 
            this.label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label175.Location = new System.Drawing.Point(466, 216);
            this.label175.Margin = new System.Windows.Forms.Padding(0);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(150, 20);
            this.label175.TabIndex = 38;
            this.label175.Text = "P/L";
            this.label175.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label171
            // 
            this.label171.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label171.Location = new System.Drawing.Point(466, 186);
            this.label171.Margin = new System.Windows.Forms.Padding(0);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(150, 20);
            this.label171.TabIndex = 33;
            this.label171.Text = "BALANCE";
            this.label171.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label173
            // 
            this.label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label173.Location = new System.Drawing.Point(38, 186);
            this.label173.Margin = new System.Windows.Forms.Padding(0);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(150, 20);
            this.label173.TabIndex = 31;
            this.label173.Text = "FREE PIP";
            this.label173.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_settings_pip
            // 
            this.lab_settings_pip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.lab_settings_pip.Location = new System.Drawing.Point(306, 185);
            this.lab_settings_pip.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_pip.Name = "lab_settings_pip";
            this.lab_settings_pip.Size = new System.Drawing.Size(70, 23);
            this.lab_settings_pip.TabIndex = 30;
            this.lab_settings_pip.Click += new System.EventHandler(this.lab_color_Click);
            // 
            // label167
            // 
            this.label167.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label167.Location = new System.Drawing.Point(466, 156);
            this.label167.Margin = new System.Windows.Forms.Padding(0);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(150, 20);
            this.label167.TabIndex = 28;
            this.label167.Text = "TRANSFERSUMME";
            this.label167.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label168.Location = new System.Drawing.Point(381, 158);
            this.label168.Margin = new System.Windows.Forms.Padding(0);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(56, 17);
            this.label168.TabIndex = 27;
            this.label168.Text = "180xxxx";
            this.label168.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label168.Visible = false;
            // 
            // label169
            // 
            this.label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label169.Location = new System.Drawing.Point(38, 156);
            this.label169.Margin = new System.Windows.Forms.Padding(0);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(150, 20);
            this.label169.TabIndex = 26;
            this.label169.Text = "ACCOUNT STP/ECN";
            this.label169.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_settings_account2
            // 
            this.lab_settings_account2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(168)))));
            this.lab_settings_account2.Location = new System.Drawing.Point(306, 155);
            this.lab_settings_account2.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_account2.Name = "lab_settings_account2";
            this.lab_settings_account2.Size = new System.Drawing.Size(70, 23);
            this.lab_settings_account2.TabIndex = 25;
            this.lab_settings_account2.Click += new System.EventHandler(this.lab_color_Click);
            // 
            // label166
            // 
            this.label166.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label166.Location = new System.Drawing.Point(466, 126);
            this.label166.Margin = new System.Windows.Forms.Padding(0);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(150, 20);
            this.label166.TabIndex = 23;
            this.label166.Text = "CURR";
            this.label166.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label165.Location = new System.Drawing.Point(381, 128);
            this.label165.Margin = new System.Windows.Forms.Padding(0);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(56, 17);
            this.label165.TabIndex = 22;
            this.label165.Text = "130xxxx";
            this.label165.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label165.Visible = false;
            // 
            // label164
            // 
            this.label164.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label164.Location = new System.Drawing.Point(38, 126);
            this.label164.Margin = new System.Windows.Forms.Padding(0);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(150, 20);
            this.label164.TabIndex = 21;
            this.label164.Text = "ACCOUNT SWAPFREE";
            this.label164.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label162
            // 
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label162.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label162.Location = new System.Drawing.Point(581, 81);
            this.label162.Margin = new System.Windows.Forms.Padding(0);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(206, 20);
            this.label162.TabIndex = 20;
            this.label162.Text = "SPALTEN AUS-EINBLENDEN";
            this.label162.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label163
            // 
            this.label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label163.Location = new System.Drawing.Point(458, 81);
            this.label163.Margin = new System.Windows.Forms.Padding(0);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(150, 20);
            this.label163.TabIndex = 19;
            this.label163.Text = "VISIBLE FIELDS /";
            this.label163.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label159
            // 
            this.label159.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label159.Location = new System.Drawing.Point(40, 102);
            this.label159.Margin = new System.Windows.Forms.Padding(0);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(800, 1);
            this.label159.TabIndex = 18;
            // 
            // label160
            // 
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label160.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label160.Location = new System.Drawing.Point(175, 81);
            this.label160.Margin = new System.Windows.Forms.Padding(0);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(150, 20);
            this.label160.TabIndex = 17;
            this.label160.Text = "FARBEN AUSWAHL";
            this.label160.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label161
            // 
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label161.Location = new System.Drawing.Point(38, 81);
            this.label161.Margin = new System.Windows.Forms.Padding(0);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(150, 20);
            this.label161.TabIndex = 16;
            this.label161.Text = "COLOR SETTINGS /";
            this.label161.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_settings_account1
            // 
            this.lab_settings_account1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(232)))));
            this.lab_settings_account1.Location = new System.Drawing.Point(306, 125);
            this.lab_settings_account1.Margin = new System.Windows.Forms.Padding(0);
            this.lab_settings_account1.Name = "lab_settings_account1";
            this.lab_settings_account1.Size = new System.Drawing.Size(70, 23);
            this.lab_settings_account1.TabIndex = 0;
            this.lab_settings_account1.Click += new System.EventHandler(this.lab_color_Click);
            // 
            // panel_pamm
            // 
            this.panel_pamm.BackColor = System.Drawing.Color.White;
            this.panel_pamm.Controls.Add(this.tableLayoutPanel2);
            this.panel_pamm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pamm.Location = new System.Drawing.Point(0, 60);
            this.panel_pamm.Name = "panel_pamm";
            this.panel_pamm.Size = new System.Drawing.Size(990, 730);
            this.panel_pamm.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel24, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel_pamm_master, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel20, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.ColumnCount = 3;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Controls.Add(this.panel16, 1, 0);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(0, 705);
            this.tableLayoutPanel24.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 1;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(960, 25);
            this.tableLayoutPanel24.TabIndex = 11;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dp_pamm_display_num);
            this.panel16.Controls.Add(this.tb_pamm_page);
            this.panel16.Controls.Add(this.btn_pamm_prev);
            this.panel16.Controls.Add(this.btn_pamm_next);
            this.panel16.Controls.Add(this.btn_pamm_end);
            this.panel16.Controls.Add(this.btn_pamm_start);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(230, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(500, 25);
            this.panel16.TabIndex = 0;
            // 
            // dp_pamm_display_num
            // 
            this.dp_pamm_display_num.BackColor = System.Drawing.Color.Transparent;
            this.dp_pamm_display_num.BorderRadius = 3;
            this.dp_pamm_display_num.DisabledColor = System.Drawing.Color.Gray;
            this.dp_pamm_display_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dp_pamm_display_num.ForeColor = System.Drawing.Color.Black;
            this.dp_pamm_display_num.Items = new string[] {
        "30",
        "20"};
            this.dp_pamm_display_num.Location = new System.Drawing.Point(381, 3);
            this.dp_pamm_display_num.Margin = new System.Windows.Forms.Padding(0);
            this.dp_pamm_display_num.Name = "dp_pamm_display_num";
            this.dp_pamm_display_num.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_pamm_display_num.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_pamm_display_num.selectedIndex = 0;
            this.dp_pamm_display_num.Size = new System.Drawing.Size(60, 20);
            this.dp_pamm_display_num.TabIndex = 7;
            this.dp_pamm_display_num.onItemSelected += new System.EventHandler(this.dp_pamm_display_num_onItemSelected);
            // 
            // tb_pamm_page
            // 
            this.tb_pamm_page.BackColor = System.Drawing.Color.White;
            this.tb_pamm_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_pamm_page.Location = new System.Drawing.Point(174, 3);
            this.tb_pamm_page.Name = "tb_pamm_page";
            this.tb_pamm_page.ReadOnly = true;
            this.tb_pamm_page.Size = new System.Drawing.Size(80, 20);
            this.tb_pamm_page.TabIndex = 6;
            this.tb_pamm_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_pamm_prev
            // 
            this.btn_pamm_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pamm_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_pamm_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_pamm_prev.Image")));
            this.btn_pamm_prev.ImageActive = null;
            this.btn_pamm_prev.Location = new System.Drawing.Point(143, 3);
            this.btn_pamm_prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pamm_prev.Name = "btn_pamm_prev";
            this.btn_pamm_prev.Size = new System.Drawing.Size(20, 20);
            this.btn_pamm_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pamm_prev.TabIndex = 5;
            this.btn_pamm_prev.TabStop = false;
            this.btn_pamm_prev.Zoom = 20;
            this.btn_pamm_prev.Click += new System.EventHandler(this.btn_pamm_prev_Click);
            // 
            // btn_pamm_next
            // 
            this.btn_pamm_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pamm_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_pamm_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_pamm_next.Image")));
            this.btn_pamm_next.ImageActive = null;
            this.btn_pamm_next.Location = new System.Drawing.Point(266, 3);
            this.btn_pamm_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pamm_next.Name = "btn_pamm_next";
            this.btn_pamm_next.Size = new System.Drawing.Size(20, 20);
            this.btn_pamm_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pamm_next.TabIndex = 4;
            this.btn_pamm_next.TabStop = false;
            this.btn_pamm_next.Zoom = 20;
            this.btn_pamm_next.Click += new System.EventHandler(this.btn_pamm_next_Click);
            // 
            // btn_pamm_end
            // 
            this.btn_pamm_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pamm_end.BackColor = System.Drawing.Color.Transparent;
            this.btn_pamm_end.Image = ((System.Drawing.Image)(resources.GetObject("btn_pamm_end.Image")));
            this.btn_pamm_end.ImageActive = null;
            this.btn_pamm_end.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_pamm_end.InitialImage")));
            this.btn_pamm_end.Location = new System.Drawing.Point(301, 3);
            this.btn_pamm_end.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pamm_end.Name = "btn_pamm_end";
            this.btn_pamm_end.Size = new System.Drawing.Size(20, 20);
            this.btn_pamm_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pamm_end.TabIndex = 3;
            this.btn_pamm_end.TabStop = false;
            this.btn_pamm_end.Zoom = 20;
            this.btn_pamm_end.Click += new System.EventHandler(this.btn_pamm_end_Click);
            // 
            // btn_pamm_start
            // 
            this.btn_pamm_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pamm_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_pamm_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_pamm_start.Image")));
            this.btn_pamm_start.ImageActive = null;
            this.btn_pamm_start.Location = new System.Drawing.Point(108, 3);
            this.btn_pamm_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_pamm_start.Name = "btn_pamm_start";
            this.btn_pamm_start.Size = new System.Drawing.Size(20, 20);
            this.btn_pamm_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pamm_start.TabIndex = 2;
            this.btn_pamm_start.TabStop = false;
            this.btn_pamm_start.Zoom = 20;
            this.btn_pamm_start.Click += new System.EventHandler(this.btn_pamm_start_Click);
            // 
            // panel_pamm_master
            // 
            this.panel_pamm_master.BackColor = System.Drawing.Color.White;
            this.panel_pamm_master.ColumnCount = 2;
            this.panel_pamm_master.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.panel_pamm_master.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.panel_pamm_master.Controls.Add(this.ctrl_header_master, 0, 0);
            this.panel_pamm_master.Controls.Add(this.label90, 0, 2);
            this.panel_pamm_master.Controls.Add(this.ctrl_account_pamm, 0, 3);
            this.panel_pamm_master.Controls.Add(this.tableLayoutPanel15, 0, 5);
            this.panel_pamm_master.Controls.Add(this.btn_pamm_master, 0, 1);
            this.panel_pamm_master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pamm_master.Location = new System.Drawing.Point(0, 0);
            this.panel_pamm_master.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panel_pamm_master.Name = "panel_pamm_master";
            this.panel_pamm_master.RowCount = 7;
            this.panel_pamm_master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_pamm_master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_pamm_master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.panel_pamm_master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.panel_pamm_master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_pamm_master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.panel_pamm_master.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_pamm_master.Size = new System.Drawing.Size(960, 254);
            this.panel_pamm_master.TabIndex = 0;
            // 
            // ctrl_header_master
            // 
            this.ctrl_header_master.Location = new System.Drawing.Point(0, 0);
            this.ctrl_header_master.m_master_mode = true;
            this.ctrl_header_master.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_header_master.Name = "ctrl_header_master";
            this.ctrl_header_master.Size = new System.Drawing.Size(524, 30);
            this.ctrl_header_master.TabIndex = 0;
            // 
            // label90
            // 
            this.label90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(182)))), ((int)(((byte)(158)))));
            this.label90.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label90.Location = new System.Drawing.Point(8, 60);
            this.label90.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(884, 2);
            this.label90.TabIndex = 1;
            this.label90.Text = "label90";
            // 
            // ctrl_account_pamm
            // 
            this.ctrl_account_pamm.Location = new System.Drawing.Point(0, 62);
            this.ctrl_account_pamm.m_master_mode = true;
            this.ctrl_account_pamm.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_account_pamm.Name = "ctrl_account_pamm";
            this.ctrl_account_pamm.Size = new System.Drawing.Size(524, 70);
            this.ctrl_account_pamm.TabIndex = 3;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.panel10, 1, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(892, 105);
            this.tableLayoutPanel15.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pamm_buysell_ctrl);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(96, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(700, 105);
            this.panel10.TabIndex = 2;
            // 
            // pamm_buysell_ctrl
            // 
            this.pamm_buysell_ctrl.Location = new System.Drawing.Point(72, 3);
            this.pamm_buysell_ctrl.Margin = new System.Windows.Forms.Padding(0);
            this.pamm_buysell_ctrl.Name = "pamm_buysell_ctrl";
            this.pamm_buysell_ctrl.Size = new System.Drawing.Size(562, 100);
            this.pamm_buysell_ctrl.TabIndex = 0;
            // 
            // btn_pamm_master
            // 
            this.btn_pamm_master.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.btn_pamm_master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.btn_pamm_master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pamm_master.BorderRadius = 0;
            this.btn_pamm_master.ButtonText = "MASTER / SENDER";
            this.btn_pamm_master.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pamm_master.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.btn_pamm_master.Enabled = false;
            this.btn_pamm_master.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_pamm_master.ForeColor = System.Drawing.Color.White;
            this.btn_pamm_master.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_pamm_master.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_pamm_master.Iconimage")));
            this.btn_pamm_master.Iconimage_right = null;
            this.btn_pamm_master.Iconimage_right_Selected = null;
            this.btn_pamm_master.Iconimage_Selected = null;
            this.btn_pamm_master.IconMarginLeft = 0;
            this.btn_pamm_master.IconMarginRight = 0;
            this.btn_pamm_master.IconRightVisible = true;
            this.btn_pamm_master.IconRightZoom = 0D;
            this.btn_pamm_master.IconVisible = false;
            this.btn_pamm_master.IconZoom = 90D;
            this.btn_pamm_master.IsTab = false;
            this.btn_pamm_master.Location = new System.Drawing.Point(10, 32);
            this.btn_pamm_master.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
            this.btn_pamm_master.Name = "btn_pamm_master";
            this.btn_pamm_master.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.btn_pamm_master.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.btn_pamm_master.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.btn_pamm_master.selected = false;
            this.btn_pamm_master.Size = new System.Drawing.Size(171, 28);
            this.btn_pamm_master.TabIndex = 5;
            this.btn_pamm_master.Text = "MASTER / SENDER";
            this.btn_pamm_master.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pamm_master.Textcolor = System.Drawing.Color.White;
            this.btn_pamm_master.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.bunifuFlatButton1, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.ctrl_header_slave, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.flow_pamm, 0, 2);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(0, 254);
            this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(990, 451);
            this.tableLayoutPanel20.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "SLAVE / EMPFÄNGER";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.bunifuFlatButton1.Enabled = false;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(171, 30);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "SLAVE / EMPFÄNGER";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ctrl_header_slave
            // 
            this.ctrl_header_slave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_header_slave.Location = new System.Drawing.Point(0, 30);
            this.ctrl_header_slave.m_master_mode = false;
            this.ctrl_header_slave.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ctrl_header_slave.Name = "ctrl_header_slave";
            this.ctrl_header_slave.Size = new System.Drawing.Size(960, 32);
            this.ctrl_header_slave.TabIndex = 4;
            // 
            // flow_pamm
            // 
            this.flow_pamm.AutoScroll = true;
            this.flow_pamm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_pamm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_pamm.Location = new System.Drawing.Point(0, 62);
            this.flow_pamm.Margin = new System.Windows.Forms.Padding(0);
            this.flow_pamm.Name = "flow_pamm";
            this.flow_pamm.Size = new System.Drawing.Size(990, 389);
            this.flow_pamm.TabIndex = 5;
            this.flow_pamm.WrapContents = false;
            this.flow_pamm.Resize += new System.EventHandler(this.flow_ctrl_Resize);
            // 
            // panel_dashboard
            // 
            this.panel_dashboard.BackColor = System.Drawing.Color.White;
            this.panel_dashboard.Controls.Add(this.tableLayoutPanel19);
            this.panel_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dashboard.Location = new System.Drawing.Point(0, 60);
            this.panel_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.panel_dashboard.Name = "panel_dashboard";
            this.panel_dashboard.Size = new System.Drawing.Size(990, 730);
            this.panel_dashboard.TabIndex = 2;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Controls.Add(this.tableLayoutPanel25, 0, 2);
            this.tableLayoutPanel19.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.flow_dashboard, 0, 1);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel19.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 3;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel19.TabIndex = 0;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 3;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel25.Controls.Add(this.panel17, 1, 0);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(0, 705);
            this.tableLayoutPanel25.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(990, 25);
            this.tableLayoutPanel25.TabIndex = 12;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dp_dashboard_display_num);
            this.panel17.Controls.Add(this.tb_dashboard_page);
            this.panel17.Controls.Add(this.btn_dashboard_prev);
            this.panel17.Controls.Add(this.btn_dashboard_next);
            this.panel17.Controls.Add(this.btn_dashboard_end);
            this.panel17.Controls.Add(this.btn_dashboard_start);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(245, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(500, 25);
            this.panel17.TabIndex = 0;
            // 
            // dp_dashboard_display_num
            // 
            this.dp_dashboard_display_num.BackColor = System.Drawing.Color.Transparent;
            this.dp_dashboard_display_num.BorderRadius = 3;
            this.dp_dashboard_display_num.DisabledColor = System.Drawing.Color.Gray;
            this.dp_dashboard_display_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dp_dashboard_display_num.ForeColor = System.Drawing.Color.Black;
            this.dp_dashboard_display_num.Items = new string[] {
        "30",
        "20"};
            this.dp_dashboard_display_num.Location = new System.Drawing.Point(381, 4);
            this.dp_dashboard_display_num.Margin = new System.Windows.Forms.Padding(0);
            this.dp_dashboard_display_num.Name = "dp_dashboard_display_num";
            this.dp_dashboard_display_num.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_dashboard_display_num.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_dashboard_display_num.selectedIndex = 0;
            this.dp_dashboard_display_num.Size = new System.Drawing.Size(60, 20);
            this.dp_dashboard_display_num.TabIndex = 7;
            this.dp_dashboard_display_num.onItemSelected += new System.EventHandler(this.dp_dashboard_display_num_onItemSelected);
            // 
            // tb_dashboard_page
            // 
            this.tb_dashboard_page.BackColor = System.Drawing.Color.White;
            this.tb_dashboard_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_dashboard_page.Location = new System.Drawing.Point(175, 4);
            this.tb_dashboard_page.Name = "tb_dashboard_page";
            this.tb_dashboard_page.ReadOnly = true;
            this.tb_dashboard_page.Size = new System.Drawing.Size(80, 20);
            this.tb_dashboard_page.TabIndex = 6;
            this.tb_dashboard_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_dashboard_prev
            // 
            this.btn_dashboard_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dashboard_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard_prev.Image")));
            this.btn_dashboard_prev.ImageActive = null;
            this.btn_dashboard_prev.Location = new System.Drawing.Point(143, 4);
            this.btn_dashboard_prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard_prev.Name = "btn_dashboard_prev";
            this.btn_dashboard_prev.Size = new System.Drawing.Size(20, 20);
            this.btn_dashboard_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dashboard_prev.TabIndex = 5;
            this.btn_dashboard_prev.TabStop = false;
            this.btn_dashboard_prev.Zoom = 20;
            this.btn_dashboard_prev.Click += new System.EventHandler(this.btn_dashboard_prev_Click);
            // 
            // btn_dashboard_next
            // 
            this.btn_dashboard_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dashboard_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard_next.Image")));
            this.btn_dashboard_next.ImageActive = null;
            this.btn_dashboard_next.Location = new System.Drawing.Point(266, 4);
            this.btn_dashboard_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard_next.Name = "btn_dashboard_next";
            this.btn_dashboard_next.Size = new System.Drawing.Size(20, 20);
            this.btn_dashboard_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dashboard_next.TabIndex = 4;
            this.btn_dashboard_next.TabStop = false;
            this.btn_dashboard_next.Zoom = 20;
            this.btn_dashboard_next.Click += new System.EventHandler(this.btn_dashboard_next_Click);
            // 
            // btn_dashboard_end
            // 
            this.btn_dashboard_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dashboard_end.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard_end.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard_end.Image")));
            this.btn_dashboard_end.ImageActive = null;
            this.btn_dashboard_end.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_dashboard_end.InitialImage")));
            this.btn_dashboard_end.Location = new System.Drawing.Point(301, 4);
            this.btn_dashboard_end.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard_end.Name = "btn_dashboard_end";
            this.btn_dashboard_end.Size = new System.Drawing.Size(20, 20);
            this.btn_dashboard_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dashboard_end.TabIndex = 3;
            this.btn_dashboard_end.TabStop = false;
            this.btn_dashboard_end.Zoom = 20;
            this.btn_dashboard_end.Click += new System.EventHandler(this.btn_dashboard_end_Click);
            // 
            // btn_dashboard_start
            // 
            this.btn_dashboard_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dashboard_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard_start.Image")));
            this.btn_dashboard_start.ImageActive = null;
            this.btn_dashboard_start.Location = new System.Drawing.Point(108, 4);
            this.btn_dashboard_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard_start.Name = "btn_dashboard_start";
            this.btn_dashboard_start.Size = new System.Drawing.Size(20, 20);
            this.btn_dashboard_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dashboard_start.TabIndex = 2;
            this.btn_dashboard_start.TabStop = false;
            this.btn_dashboard_start.Zoom = 20;
            this.btn_dashboard_start.Click += new System.EventHandler(this.btn_dashboard_start_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ctrl_header_dashboard);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(960, 32);
            this.panel6.TabIndex = 0;
            // 
            // ctrl_header_dashboard
            // 
            this.ctrl_header_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.ctrl_header_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_header_dashboard.Location = new System.Drawing.Point(0, 0);
            this.ctrl_header_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_header_dashboard.Name = "ctrl_header_dashboard";
            this.ctrl_header_dashboard.Size = new System.Drawing.Size(960, 32);
            this.ctrl_header_dashboard.TabIndex = 0;
            // 
            // flow_dashboard
            // 
            this.flow_dashboard.AutoScroll = true;
            this.flow_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_dashboard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_dashboard.Location = new System.Drawing.Point(0, 32);
            this.flow_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.flow_dashboard.Name = "flow_dashboard";
            this.flow_dashboard.Size = new System.Drawing.Size(990, 673);
            this.flow_dashboard.TabIndex = 1;
            this.flow_dashboard.WrapContents = false;
            this.flow_dashboard.Resize += new System.EventHandler(this.flow_ctrl_Resize);
            // 
            // panel_orders
            // 
            this.panel_orders.BackColor = System.Drawing.Color.White;
            this.panel_orders.Controls.Add(this.tableLayoutPanel1);
            this.panel_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_orders.Location = new System.Drawing.Point(0, 60);
            this.panel_orders.Name = "panel_orders";
            this.panel_orders.Size = new System.Drawing.Size(990, 730);
            this.panel_orders.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ctrl_account_orders);
            this.panel4.Controls.Add(this.ctrl_header_orders);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panel4.Size = new System.Drawing.Size(990, 102);
            this.panel4.TabIndex = 0;
            // 
            // ctrl_account_orders
            // 
            this.ctrl_account_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_account_orders.Location = new System.Drawing.Point(0, 32);
            this.ctrl_account_orders.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_account_orders.Name = "ctrl_account_orders";
            this.ctrl_account_orders.Size = new System.Drawing.Size(960, 70);
            this.ctrl_account_orders.TabIndex = 1;
            // 
            // ctrl_header_orders
            // 
            this.ctrl_header_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.ctrl_header_orders.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrl_header_orders.Location = new System.Drawing.Point(0, 0);
            this.ctrl_header_orders.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_header_orders.Name = "ctrl_header_orders";
            this.ctrl_header_orders.Size = new System.Drawing.Size(960, 32);
            this.ctrl_header_orders.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(990, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(182)))), ((int)(((byte)(158)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(79, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 2);
            this.label1.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel26, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.flow_orders, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.ctrl_header, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 132);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(990, 598);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.ColumnCount = 3;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel26.Controls.Add(this.panel18, 1, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(79, 573);
            this.tableLayoutPanel26.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(811, 25);
            this.tableLayoutPanel26.TabIndex = 13;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dp_orders_display_num);
            this.panel18.Controls.Add(this.tb_orders_page);
            this.panel18.Controls.Add(this.btn_orders_prev);
            this.panel18.Controls.Add(this.btn_orders_next);
            this.panel18.Controls.Add(this.btn_orders_end);
            this.panel18.Controls.Add(this.btn_orders_start);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(155, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(500, 25);
            this.panel18.TabIndex = 0;
            // 
            // dp_orders_display_num
            // 
            this.dp_orders_display_num.BackColor = System.Drawing.Color.Transparent;
            this.dp_orders_display_num.BorderRadius = 3;
            this.dp_orders_display_num.DisabledColor = System.Drawing.Color.Gray;
            this.dp_orders_display_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dp_orders_display_num.ForeColor = System.Drawing.Color.Black;
            this.dp_orders_display_num.Items = new string[] {
        "30",
        "20"};
            this.dp_orders_display_num.Location = new System.Drawing.Point(381, 3);
            this.dp_orders_display_num.Margin = new System.Windows.Forms.Padding(0);
            this.dp_orders_display_num.Name = "dp_orders_display_num";
            this.dp_orders_display_num.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_orders_display_num.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(126)))));
            this.dp_orders_display_num.selectedIndex = 0;
            this.dp_orders_display_num.Size = new System.Drawing.Size(60, 20);
            this.dp_orders_display_num.TabIndex = 7;
            this.dp_orders_display_num.onItemSelected += new System.EventHandler(this.dp_orders_display_num_onItemSelected);
            // 
            // tb_orders_page
            // 
            this.tb_orders_page.BackColor = System.Drawing.Color.White;
            this.tb_orders_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_orders_page.Location = new System.Drawing.Point(174, 3);
            this.tb_orders_page.Name = "tb_orders_page";
            this.tb_orders_page.ReadOnly = true;
            this.tb_orders_page.Size = new System.Drawing.Size(80, 20);
            this.tb_orders_page.TabIndex = 6;
            this.tb_orders_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_orders_prev
            // 
            this.btn_orders_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_orders_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_orders_prev.Image")));
            this.btn_orders_prev.ImageActive = null;
            this.btn_orders_prev.Location = new System.Drawing.Point(143, 3);
            this.btn_orders_prev.Margin = new System.Windows.Forms.Padding(0);
            this.btn_orders_prev.Name = "btn_orders_prev";
            this.btn_orders_prev.Size = new System.Drawing.Size(20, 20);
            this.btn_orders_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_orders_prev.TabIndex = 5;
            this.btn_orders_prev.TabStop = false;
            this.btn_orders_prev.Zoom = 20;
            this.btn_orders_prev.Click += new System.EventHandler(this.btn_orders_prev_Click);
            // 
            // btn_orders_next
            // 
            this.btn_orders_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_orders_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_orders_next.Image")));
            this.btn_orders_next.ImageActive = null;
            this.btn_orders_next.Location = new System.Drawing.Point(266, 3);
            this.btn_orders_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_orders_next.Name = "btn_orders_next";
            this.btn_orders_next.Size = new System.Drawing.Size(20, 20);
            this.btn_orders_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_orders_next.TabIndex = 4;
            this.btn_orders_next.TabStop = false;
            this.btn_orders_next.Zoom = 20;
            this.btn_orders_next.Click += new System.EventHandler(this.btn_orders_next_Click);
            // 
            // btn_orders_end
            // 
            this.btn_orders_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_orders_end.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders_end.Image = ((System.Drawing.Image)(resources.GetObject("btn_orders_end.Image")));
            this.btn_orders_end.ImageActive = null;
            this.btn_orders_end.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_orders_end.InitialImage")));
            this.btn_orders_end.Location = new System.Drawing.Point(301, 3);
            this.btn_orders_end.Margin = new System.Windows.Forms.Padding(0);
            this.btn_orders_end.Name = "btn_orders_end";
            this.btn_orders_end.Size = new System.Drawing.Size(20, 20);
            this.btn_orders_end.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_orders_end.TabIndex = 3;
            this.btn_orders_end.TabStop = false;
            this.btn_orders_end.Zoom = 20;
            this.btn_orders_end.Click += new System.EventHandler(this.btn_orders_end_Click);
            // 
            // btn_orders_start
            // 
            this.btn_orders_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_orders_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_orders_start.Image")));
            this.btn_orders_start.ImageActive = null;
            this.btn_orders_start.Location = new System.Drawing.Point(108, 3);
            this.btn_orders_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_orders_start.Name = "btn_orders_start";
            this.btn_orders_start.Size = new System.Drawing.Size(20, 20);
            this.btn_orders_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_orders_start.TabIndex = 2;
            this.btn_orders_start.TabStop = false;
            this.btn_orders_start.Zoom = 20;
            this.btn_orders_start.Click += new System.EventHandler(this.btn_orders_start_Click);
            // 
            // flow_orders
            // 
            this.flow_orders.AutoScroll = true;
            this.flow_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_orders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_orders.Location = new System.Drawing.Point(79, 30);
            this.flow_orders.Margin = new System.Windows.Forms.Padding(0);
            this.flow_orders.Name = "flow_orders";
            this.flow_orders.Size = new System.Drawing.Size(811, 543);
            this.flow_orders.TabIndex = 0;
            this.flow_orders.WrapContents = false;
            this.flow_orders.Resize += new System.EventHandler(this.flow_ctrl_Resize);
            // 
            // ctrl_header
            // 
            this.ctrl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_header.Location = new System.Drawing.Point(79, 0);
            this.ctrl_header.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ctrl_header.Name = "ctrl_header";
            this.ctrl_header.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ctrl_header.Size = new System.Drawing.Size(781, 30);
            this.ctrl_header.TabIndex = 1;
            // 
            // panel_history
            // 
            this.panel_history.BackColor = System.Drawing.Color.White;
            this.panel_history.Controls.Add(this.tableLayoutPanel14);
            this.panel_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_history.Location = new System.Drawing.Point(0, 60);
            this.panel_history.Margin = new System.Windows.Forms.Padding(0);
            this.panel_history.Name = "panel_history";
            this.panel_history.Size = new System.Drawing.Size(990, 730);
            this.panel_history.TabIndex = 9;
            this.panel_history.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_history_Paint);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 5;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel14.Controls.Add(this.lab_history_130, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.progress_history, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.grid_order_history_130, 3, 1);
            this.tableLayoutPanel14.Controls.Add(this.grid_order_history_180, 1, 1);
            this.tableLayoutPanel14.Controls.Add(this.panel11, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // lab_history_130
            // 
            this.lab_history_130.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_history_130.AutoSize = true;
            this.lab_history_130.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_history_130.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_history_130.Location = new System.Drawing.Point(643, 32);
            this.lab_history_130.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lab_history_130.Name = "lab_history_130";
            this.lab_history_130.Size = new System.Drawing.Size(137, 18);
            this.lab_history_130.TabIndex = 6;
            this.lab_history_130.Text = "HISTORY 2019 130";
            // 
            // progress_history
            // 
            this.progress_history.AutoSize = true;
            this.progress_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.progress_history.Location = new System.Drawing.Point(3, 0);
            this.progress_history.Name = "progress_history";
            this.progress_history.Size = new System.Drawing.Size(69, 40);
            this.progress_history.TabIndex = 4;
            this.progress_history.Text = "LOADING.....";
            this.progress_history.Visible = false;
            // 
            // grid_order_history_130
            // 
            this.grid_order_history_130.AllowUserToAddRows = false;
            this.grid_order_history_130.AllowUserToDeleteRows = false;
            this.grid_order_history_130.AllowUserToResizeColumns = false;
            this.grid_order_history_130.AllowUserToResizeRows = false;
            this.grid_order_history_130.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_history_130.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.grid_order_history_130.ColumnHeadersHeight = 30;
            this.grid_order_history_130.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_order_history_130.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order_history_130.DefaultCellStyle = dataGridViewCellStyle18;
            this.grid_order_history_130.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_order_history_130.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_order_history_130.EnableHeadersVisualStyles = false;
            this.grid_order_history_130.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.grid_order_history_130.Location = new System.Drawing.Point(514, 60);
            this.grid_order_history_130.Margin = new System.Windows.Forms.Padding(0);
            this.grid_order_history_130.Name = "grid_order_history_130";
            this.grid_order_history_130.ReadOnly = true;
            this.grid_order_history_130.RowHeadersVisible = false;
            this.grid_order_history_130.RowTemplate.Height = 30;
            this.grid_order_history_130.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order_history_130.Size = new System.Drawing.Size(396, 640);
            this.grid_order_history_130.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "LOT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "DATE OPEN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 144;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE CLOSED";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 140;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "P/L";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // grid_order_history_180
            // 
            this.grid_order_history_180.AllowUserToAddRows = false;
            this.grid_order_history_180.AllowUserToDeleteRows = false;
            this.grid_order_history_180.AllowUserToResizeColumns = false;
            this.grid_order_history_180.AllowUserToResizeRows = false;
            this.grid_order_history_180.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_order_history_180.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grid_order_history_180.ColumnHeadersHeight = 30;
            this.grid_order_history_180.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid_order_history_180.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_order_history_180.DefaultCellStyle = dataGridViewCellStyle20;
            this.grid_order_history_180.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_order_history_180.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_order_history_180.EnableHeadersVisualStyles = false;
            this.grid_order_history_180.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.grid_order_history_180.Location = new System.Drawing.Point(79, 60);
            this.grid_order_history_180.Margin = new System.Windows.Forms.Padding(0);
            this.grid_order_history_180.Name = "grid_order_history_180";
            this.grid_order_history_180.ReadOnly = true;
            this.grid_order_history_180.RowHeadersVisible = false;
            this.grid_order_history_180.RowTemplate.Height = 30;
            this.grid_order_history_180.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_order_history_180.Size = new System.Drawing.Size(396, 640);
            this.grid_order_history_180.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LOT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DATE OPEN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 144;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DATE CLOSED";
            this.Column3.MinimumWidth = 140;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "P/L";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lab_history_client_name);
            this.panel11.Controls.Add(this.lab_history_180);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(79, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(396, 60);
            this.panel11.TabIndex = 7;
            // 
            // lab_history_client_name
            // 
            this.lab_history_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_history_client_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_history_client_name.Location = new System.Drawing.Point(0, 6);
            this.lab_history_client_name.Margin = new System.Windows.Forms.Padding(0);
            this.lab_history_client_name.Name = "lab_history_client_name";
            this.lab_history_client_name.Size = new System.Drawing.Size(397, 18);
            this.lab_history_client_name.TabIndex = 6;
            this.lab_history_client_name.Text = "name";
            this.lab_history_client_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_history_180
            // 
            this.lab_history_180.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lab_history_180.AutoSize = true;
            this.lab_history_180.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_history_180.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_history_180.Location = new System.Drawing.Point(127, 32);
            this.lab_history_180.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lab_history_180.Name = "lab_history_180";
            this.lab_history_180.Size = new System.Drawing.Size(137, 18);
            this.lab_history_180.TabIndex = 6;
            this.lab_history_180.Text = "HISTORY 2019 180";
            // 
            // panel_statement
            // 
            this.panel_statement.BackColor = System.Drawing.Color.White;
            this.panel_statement.Controls.Add(this.statement_html_ctrl);
            this.panel_statement.Controls.Add(this.btn_statement_year_pdf);
            this.panel_statement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_statement.Location = new System.Drawing.Point(0, 60);
            this.panel_statement.Margin = new System.Windows.Forms.Padding(0);
            this.panel_statement.Name = "panel_statement";
            this.panel_statement.Size = new System.Drawing.Size(990, 730);
            this.panel_statement.TabIndex = 11;
            // 
            // statement_html_ctrl
            // 
            this.statement_html_ctrl.AllowDrop = true;
            this.statement_html_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statement_html_ctrl.AutoScroll = true;
            this.statement_html_ctrl.Location = new System.Drawing.Point(18, 18);
            this.statement_html_ctrl.Margin = new System.Windows.Forms.Padding(0);
            this.statement_html_ctrl.Name = "statement_html_ctrl";
            this.statement_html_ctrl.Size = new System.Drawing.Size(550, 696);
            this.statement_html_ctrl.TabIndex = 7;
            // 
            // btn_statement_year_pdf
            // 
            this.btn_statement_year_pdf.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_statement_year_pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_statement_year_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_statement_year_pdf.BorderRadius = 0;
            this.btn_statement_year_pdf.ButtonText = "STATEMENT PDF";
            this.btn_statement_year_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_statement_year_pdf.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_statement_year_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statement_year_pdf.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_statement_year_pdf.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_statement_year_pdf.Iconimage")));
            this.btn_statement_year_pdf.Iconimage_right = null;
            this.btn_statement_year_pdf.Iconimage_right_Selected = null;
            this.btn_statement_year_pdf.Iconimage_Selected = null;
            this.btn_statement_year_pdf.IconMarginLeft = 0;
            this.btn_statement_year_pdf.IconMarginRight = 0;
            this.btn_statement_year_pdf.IconRightVisible = true;
            this.btn_statement_year_pdf.IconRightZoom = 0D;
            this.btn_statement_year_pdf.IconVisible = false;
            this.btn_statement_year_pdf.IconZoom = 90D;
            this.btn_statement_year_pdf.IsTab = true;
            this.btn_statement_year_pdf.Location = new System.Drawing.Point(587, 138);
            this.btn_statement_year_pdf.Margin = new System.Windows.Forms.Padding(0);
            this.btn_statement_year_pdf.Name = "btn_statement_year_pdf";
            this.btn_statement_year_pdf.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.btn_statement_year_pdf.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.btn_statement_year_pdf.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_statement_year_pdf.selected = true;
            this.btn_statement_year_pdf.Size = new System.Drawing.Size(130, 31);
            this.btn_statement_year_pdf.TabIndex = 6;
            this.btn_statement_year_pdf.Text = "STATEMENT PDF";
            this.btn_statement_year_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_statement_year_pdf.Textcolor = System.Drawing.Color.White;
            this.btn_statement_year_pdf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_statement_year_pdf.Click += new System.EventHandler(this.btn_statement_year_pdf_Click);
            // 
            // panel_tradingdesk_new
            // 
            this.panel_tradingdesk_new.BackColor = System.Drawing.Color.White;
            this.panel_tradingdesk_new.Controls.Add(this.tableLayoutPanel12);
            this.panel_tradingdesk_new.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tradingdesk_new.Location = new System.Drawing.Point(0, 60);
            this.panel_tradingdesk_new.Name = "panel_tradingdesk_new";
            this.panel_tradingdesk_new.Size = new System.Drawing.Size(990, 730);
            this.panel_tradingdesk_new.TabIndex = 10;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel27, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.panel21, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.ColumnCount = 1;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel27.Controls.Add(this.panel25, 0, 1);
            this.tableLayoutPanel27.Controls.Add(this.panel23, 0, 0);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(5, 50);
            this.tableLayoutPanel27.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 2;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(985, 680);
            this.tableLayoutPanel27.TabIndex = 1;
            // 
            // panel25
            // 
            this.panel25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel25.Controls.Add(this.chart_view_3);
            this.panel25.Location = new System.Drawing.Point(3, 343);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(979, 334);
            this.panel25.TabIndex = 2;
            // 
            // chart_view_3
            // 
            chartArea14.Name = "ChartArea1";
            this.chart_view_3.ChartAreas.Add(chartArea14);
            this.chart_view_3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend14.Enabled = false;
            legend14.Name = "Legend1";
            this.chart_view_3.Legends.Add(legend14);
            this.chart_view_3.Location = new System.Drawing.Point(0, 0);
            this.chart_view_3.Margin = new System.Windows.Forms.Padding(0);
            this.chart_view_3.Name = "chart_view_3";
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series40.CustomProperties = "PointWidth=0.5";
            series40.Legend = "Legend1";
            series40.Name = "stocks";
            series40.YValuesPerPoint = 4;
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series41.Legend = "Legend1";
            series41.Name = "line1";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series42.Legend = "Legend1";
            series42.Name = "line2";
            this.chart_view_3.Series.Add(series40);
            this.chart_view_3.Series.Add(series41);
            this.chart_view_3.Series.Add(series42);
            this.chart_view_3.Size = new System.Drawing.Size(979, 334);
            this.chart_view_3.TabIndex = 0;
            this.chart_view_3.Text = "chart1";
            title22.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title22.DockedToChartArea = "ChartArea1";
            title22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title22.Name = "Title1";
            title22.Text = "Ask Stock Price   Fx Fellow Real 3";
            title23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            title23.DockedToChartArea = "ChartArea1";
            title23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title23.Name = "Title2";
            title23.Position.Auto = false;
            title23.Position.Height = 6F;
            title23.Position.Width = 8F;
            title23.Position.X = 8F;
            title23.Position.Y = 16F;
            title23.Text = "1.10934";
            this.chart_view_3.Titles.Add(title22);
            this.chart_view_3.Titles.Add(title23);
            this.chart_view_3.DoubleClick += new System.EventHandler(this.chart_view_3_DoubleClick);
            // 
            // panel23
            // 
            this.panel23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel23.Controls.Add(this.chart_view_8);
            this.panel23.Location = new System.Drawing.Point(3, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(979, 334);
            this.panel23.TabIndex = 1;
            // 
            // chart_view_8
            // 
            chartArea15.Name = "ChartArea1";
            this.chart_view_8.ChartAreas.Add(chartArea15);
            this.chart_view_8.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Enabled = false;
            legend15.Name = "Legend1";
            this.chart_view_8.Legends.Add(legend15);
            this.chart_view_8.Location = new System.Drawing.Point(0, 0);
            this.chart_view_8.Margin = new System.Windows.Forms.Padding(0);
            this.chart_view_8.Name = "chart_view_8";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series43.CustomProperties = "PointWidth=0.5";
            series43.Legend = "Legend1";
            series43.Name = "stocks";
            series43.YValuesPerPoint = 4;
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series44.Legend = "Legend1";
            series44.Name = "line1";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series45.Legend = "Legend1";
            series45.Name = "line2";
            this.chart_view_8.Series.Add(series43);
            this.chart_view_8.Series.Add(series44);
            this.chart_view_8.Series.Add(series45);
            this.chart_view_8.Size = new System.Drawing.Size(979, 334);
            this.chart_view_8.TabIndex = 0;
            this.chart_view_8.Text = "chart1";
            title24.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title24.DockedToChartArea = "ChartArea1";
            title24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title24.Name = "Title1";
            title24.Text = "Ask Stock Price   Fx Fellow Real 8";
            title25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            title25.DockedToChartArea = "ChartArea1";
            title25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title25.Name = "Title2";
            title25.Position.Auto = false;
            title25.Position.Height = 6F;
            title25.Position.Width = 8F;
            title25.Position.X = 8F;
            title25.Position.Y = 16F;
            title25.Text = "1.10934";
            this.chart_view_8.Titles.Add(title24);
            this.chart_view_8.Titles.Add(title25);
            this.chart_view_8.DoubleClick += new System.EventHandler(this.chart_view_8_DoubleClick);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.lab_tradingdesk_new_client);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(5, 0);
            this.panel21.Margin = new System.Windows.Forms.Padding(0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(985, 50);
            this.panel21.TabIndex = 2;
            // 
            // lab_tradingdesk_new_client
            // 
            this.lab_tradingdesk_new_client.AutoSize = true;
            this.lab_tradingdesk_new_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_tradingdesk_new_client.Location = new System.Drawing.Point(10, 19);
            this.lab_tradingdesk_new_client.Name = "lab_tradingdesk_new_client";
            this.lab_tradingdesk_new_client.Size = new System.Drawing.Size(89, 18);
            this.lab_tradingdesk_new_client.TabIndex = 0;
            this.lab_tradingdesk_new_client.Text = "Client Name";
            // 
            // panel_statistics
            // 
            this.panel_statistics.BackColor = System.Drawing.Color.White;
            this.panel_statistics.Controls.Add(this.textBox3);
            this.panel_statistics.Controls.Add(this.textBox4);
            this.panel_statistics.Controls.Add(this.bunifuImageButton1);
            this.panel_statistics.Controls.Add(this.bunifuImageButton2);
            this.panel_statistics.Controls.Add(this.label32);
            this.panel_statistics.Controls.Add(this.label29);
            this.panel_statistics.Controls.Add(this.label31);
            this.panel_statistics.Controls.Add(this.label25);
            this.panel_statistics.Controls.Add(this.label26);
            this.panel_statistics.Controls.Add(this.label27);
            this.panel_statistics.Controls.Add(this.lab_live_clients);
            this.panel_statistics.Controls.Add(this.lab_tot_clients);
            this.panel_statistics.Controls.Add(this.label9);
            this.panel_statistics.Controls.Add(this.label17);
            this.panel_statistics.Controls.Add(this.lab_commission_total_R8);
            this.panel_statistics.Controls.Add(this.label155);
            this.panel_statistics.Controls.Add(this.label156);
            this.panel_statistics.Controls.Add(this.lab_commission_per_lot_R8);
            this.panel_statistics.Controls.Add(this.label158);
            this.panel_statistics.Controls.Add(this.label134);
            this.panel_statistics.Controls.Add(this.label135);
            this.panel_statistics.Controls.Add(this.lab_commission_total_R3);
            this.panel_statistics.Controls.Add(this.label153);
            this.panel_statistics.Controls.Add(this.label151);
            this.panel_statistics.Controls.Add(this.lab_commission_per_lot_R3);
            this.panel_statistics.Controls.Add(this.label150);
            this.panel_statistics.Controls.Add(this.lab_close_lots_R8);
            this.panel_statistics.Controls.Add(this.lab_close_loss_R8);
            this.panel_statistics.Controls.Add(this.lab_close_profit_R8);
            this.panel_statistics.Controls.Add(this.label136);
            this.panel_statistics.Controls.Add(this.label137);
            this.panel_statistics.Controls.Add(this.label138);
            this.panel_statistics.Controls.Add(this.label139);
            this.panel_statistics.Controls.Add(this.lab_close_lots_R3);
            this.panel_statistics.Controls.Add(this.lab_close_loss_R3);
            this.panel_statistics.Controls.Add(this.lab_close_profit_R3);
            this.panel_statistics.Controls.Add(this.label143);
            this.panel_statistics.Controls.Add(this.label144);
            this.panel_statistics.Controls.Add(this.label145);
            this.panel_statistics.Controls.Add(this.label146);
            this.panel_statistics.Controls.Add(this.label147);
            this.panel_statistics.Controls.Add(this.label148);
            this.panel_statistics.Controls.Add(this.label119);
            this.panel_statistics.Controls.Add(this.label120);
            this.panel_statistics.Controls.Add(this.label121);
            this.panel_statistics.Controls.Add(this.lab_open_lots_R8);
            this.panel_statistics.Controls.Add(this.lab_open_loss_R8);
            this.panel_statistics.Controls.Add(this.lab_open_profit_R8);
            this.panel_statistics.Controls.Add(this.label97);
            this.panel_statistics.Controls.Add(this.label106);
            this.panel_statistics.Controls.Add(this.label107);
            this.panel_statistics.Controls.Add(this.label108);
            this.panel_statistics.Controls.Add(this.label110);
            this.panel_statistics.Controls.Add(this.label113);
            this.panel_statistics.Controls.Add(this.label118);
            this.panel_statistics.Controls.Add(this.lab_open_lots_R3);
            this.panel_statistics.Controls.Add(this.lab_open_loss_R3);
            this.panel_statistics.Controls.Add(this.lab_open_profit_R3);
            this.panel_statistics.Controls.Add(this.label87);
            this.panel_statistics.Controls.Add(this.label88);
            this.panel_statistics.Controls.Add(this.label85);
            this.panel_statistics.Controls.Add(this.label86);
            this.panel_statistics.Controls.Add(this.label83);
            this.panel_statistics.Controls.Add(this.label84);
            this.panel_statistics.Controls.Add(this.label82);
            this.panel_statistics.Controls.Add(this.label81);
            this.panel_statistics.Controls.Add(this.label79);
            this.panel_statistics.Controls.Add(this.label80);
            this.panel_statistics.Controls.Add(this.label78);
            this.panel_statistics.Controls.Add(this.label6);
            this.panel_statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_statistics.Location = new System.Drawing.Point(0, 60);
            this.panel_statistics.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel_statistics.Name = "panel_statistics";
            this.panel_statistics.Size = new System.Drawing.Size(990, 730);
            this.panel_statistics.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(762, 641);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 17);
            this.textBox3.TabIndex = 131;
            this.textBox3.Text = "0041787805050";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox4.Location = new System.Drawing.Point(362, 641);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 17);
            this.textBox4.TabIndex = 130;
            this.textBox4.Text = "80";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(433, 635);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 113;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(909, 635);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 112;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(195)))), ((int)(((byte)(71)))));
            this.label32.Location = new System.Drawing.Point(44, 668);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(900, 3);
            this.label32.TabIndex = 88;
            // 
            // label29
            // 
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label29.Location = new System.Drawing.Point(526, 639);
            this.label29.Margin = new System.Windows.Forms.Padding(0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(225, 23);
            this.label29.TabIndex = 86;
            this.label29.Text = "SMARTPHONE NUMBER";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label31.Location = new System.Drawing.Point(44, 639);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(278, 23);
            this.label31.TabIndex = 84;
            this.label31.Text = "NOTIFICATION ALARM BY FREE PIP";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label25.Location = new System.Drawing.Point(40, 622);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(900, 1);
            this.label25.TabIndex = 83;
            // 
            // label26
            // 
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label26.Location = new System.Drawing.Point(206, 599);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(228, 23);
            this.label26.TabIndex = 82;
            this.label26.Text = "ALARM VON ALLEN KUNDEN";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label27.Location = new System.Drawing.Point(40, 599);
            this.label27.Margin = new System.Windows.Forms.Padding(0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(166, 23);
            this.label27.TabIndex = 81;
            this.label27.Text = "ALERTS ALL CLIENTS /";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_live_clients
            // 
            this.lab_live_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_live_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_live_clients.Location = new System.Drawing.Point(337, 58);
            this.lab_live_clients.Margin = new System.Windows.Forms.Padding(0);
            this.lab_live_clients.Name = "lab_live_clients";
            this.lab_live_clients.Size = new System.Drawing.Size(85, 23);
            this.lab_live_clients.TabIndex = 73;
            this.lab_live_clients.Text = "785";
            this.lab_live_clients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_tot_clients
            // 
            this.lab_tot_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_tot_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_tot_clients.Location = new System.Drawing.Point(332, 24);
            this.lab_tot_clients.Margin = new System.Windows.Forms.Padding(0);
            this.lab_tot_clients.Name = "lab_tot_clients";
            this.lab_tot_clients.Size = new System.Drawing.Size(90, 23);
            this.lab_tot_clients.TabIndex = 72;
            this.lab_tot_clients.Text = "1258";
            this.lab_tot_clients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label9.Location = new System.Drawing.Point(131, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 23);
            this.label9.TabIndex = 71;
            this.label9.Text = "KUNDEN ONLINE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label17.Location = new System.Drawing.Point(40, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 23);
            this.label17.TabIndex = 70;
            this.label17.Text = "LOGGED IN / ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_commission_total_R8
            // 
            this.lab_commission_total_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_commission_total_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_commission_total_R8.Location = new System.Drawing.Point(830, 544);
            this.lab_commission_total_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_commission_total_R8.Name = "lab_commission_total_R8";
            this.lab_commission_total_R8.Size = new System.Drawing.Size(66, 23);
            this.lab_commission_total_R8.TabIndex = 69;
            this.lab_commission_total_R8.Text = "2589";
            this.lab_commission_total_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label155
            // 
            this.label155.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label155.Location = new System.Drawing.Point(526, 544);
            this.label155.Margin = new System.Windows.Forms.Padding(0);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(279, 23);
            this.label155.TabIndex = 68;
            this.label155.Text = "COMMISSION TOTAL(CLOSED ORDERS)";
            this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label156
            // 
            this.label156.BackColor = System.Drawing.Color.Gainsboro;
            this.label156.Location = new System.Drawing.Point(522, 540);
            this.label156.Margin = new System.Windows.Forms.Padding(0);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(380, 1);
            this.label156.TabIndex = 67;
            // 
            // lab_commission_per_lot_R8
            // 
            this.lab_commission_per_lot_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_commission_per_lot_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_commission_per_lot_R8.Location = new System.Drawing.Point(830, 517);
            this.lab_commission_per_lot_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_commission_per_lot_R8.Name = "lab_commission_per_lot_R8";
            this.lab_commission_per_lot_R8.Size = new System.Drawing.Size(66, 23);
            this.lab_commission_per_lot_R8.TabIndex = 66;
            this.lab_commission_per_lot_R8.Text = "8.00";
            this.lab_commission_per_lot_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label158
            // 
            this.label158.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label158.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label158.Location = new System.Drawing.Point(526, 517);
            this.label158.Margin = new System.Windows.Forms.Padding(0);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(166, 23);
            this.label158.TabIndex = 65;
            this.label158.Text = "COMMISSION PER LOT";
            this.label158.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label134
            // 
            this.label134.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label134.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label134.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label134.Location = new System.Drawing.Point(661, 457);
            this.label134.Margin = new System.Windows.Forms.Padding(0);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(166, 23);
            this.label134.TabIndex = 64;
            this.label134.Text = "GESCHLOSSEN";
            this.label134.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label135
            // 
            this.label135.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label135.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label135.Location = new System.Drawing.Point(526, 457);
            this.label135.Margin = new System.Windows.Forms.Padding(0);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(166, 23);
            this.label135.TabIndex = 63;
            this.label135.Text = "CLOSED TRADES /";
            this.label135.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_commission_total_R3
            // 
            this.lab_commission_total_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_commission_total_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_commission_total_R3.Location = new System.Drawing.Point(356, 543);
            this.lab_commission_total_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_commission_total_R3.Name = "lab_commission_total_R3";
            this.lab_commission_total_R3.Size = new System.Drawing.Size(66, 23);
            this.lab_commission_total_R3.TabIndex = 62;
            this.lab_commission_total_R3.Text = "2589";
            this.lab_commission_total_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label153
            // 
            this.label153.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label153.Location = new System.Drawing.Point(44, 543);
            this.label153.Margin = new System.Windows.Forms.Padding(0);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(278, 23);
            this.label153.TabIndex = 61;
            this.label153.Text = "COMMISSION TOTAL(CLOSED ORDERS)";
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label151
            // 
            this.label151.BackColor = System.Drawing.Color.Gainsboro;
            this.label151.Location = new System.Drawing.Point(44, 539);
            this.label151.Margin = new System.Windows.Forms.Padding(0);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(380, 1);
            this.label151.TabIndex = 60;
            // 
            // lab_commission_per_lot_R3
            // 
            this.lab_commission_per_lot_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_commission_per_lot_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_commission_per_lot_R3.Location = new System.Drawing.Point(356, 516);
            this.lab_commission_per_lot_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_commission_per_lot_R3.Name = "lab_commission_per_lot_R3";
            this.lab_commission_per_lot_R3.Size = new System.Drawing.Size(66, 23);
            this.lab_commission_per_lot_R3.TabIndex = 59;
            this.lab_commission_per_lot_R3.Text = "8.00";
            this.lab_commission_per_lot_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label150
            // 
            this.label150.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label150.Location = new System.Drawing.Point(44, 516);
            this.label150.Margin = new System.Windows.Forms.Padding(0);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(166, 23);
            this.label150.TabIndex = 58;
            this.label150.Text = "COMMISSION PER LOT";
            this.label150.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_close_lots_R8
            // 
            this.lab_close_lots_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_close_lots_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_close_lots_R8.Location = new System.Drawing.Point(830, 456);
            this.lab_close_lots_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_close_lots_R8.Name = "lab_close_lots_R8";
            this.lab_close_lots_R8.Size = new System.Drawing.Size(66, 23);
            this.lab_close_lots_R8.TabIndex = 57;
            this.lab_close_lots_R8.Text = "2589";
            this.lab_close_lots_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_close_loss_R8
            // 
            this.lab_close_loss_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_close_loss_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_close_loss_R8.Location = new System.Drawing.Point(811, 419);
            this.lab_close_loss_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_close_loss_R8.Name = "lab_close_loss_R8";
            this.lab_close_loss_R8.Size = new System.Drawing.Size(85, 23);
            this.lab_close_loss_R8.TabIndex = 56;
            this.lab_close_loss_R8.Text = "256987";
            this.lab_close_loss_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_close_profit_R8
            // 
            this.lab_close_profit_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_close_profit_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_close_profit_R8.Location = new System.Drawing.Point(806, 382);
            this.lab_close_profit_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_close_profit_R8.Name = "lab_close_profit_R8";
            this.lab_close_profit_R8.Size = new System.Drawing.Size(90, 23);
            this.lab_close_profit_R8.TabIndex = 55;
            this.lab_close_profit_R8.Text = "1256987";
            this.lab_close_profit_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label136
            // 
            this.label136.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label136.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label136.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label136.Location = new System.Drawing.Point(581, 419);
            this.label136.Margin = new System.Windows.Forms.Padding(0);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(166, 23);
            this.label136.TabIndex = 52;
            this.label136.Text = "VERLUST";
            this.label136.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label137
            // 
            this.label137.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label137.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label137.Location = new System.Drawing.Point(526, 419);
            this.label137.Margin = new System.Windows.Forms.Padding(0);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(166, 23);
            this.label137.TabIndex = 51;
            this.label137.Text = "LOSS /";
            this.label137.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label138
            // 
            this.label138.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label138.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label138.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label138.Location = new System.Drawing.Point(593, 382);
            this.label138.Margin = new System.Windows.Forms.Padding(0);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(166, 23);
            this.label138.TabIndex = 50;
            this.label138.Text = "GEWINN";
            this.label138.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label139
            // 
            this.label139.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label139.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label139.Location = new System.Drawing.Point(526, 382);
            this.label139.Margin = new System.Windows.Forms.Padding(0);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(166, 23);
            this.label139.TabIndex = 49;
            this.label139.Text = "PROFIT /";
            this.label139.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_close_lots_R3
            // 
            this.lab_close_lots_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_close_lots_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_close_lots_R3.Location = new System.Drawing.Point(356, 456);
            this.lab_close_lots_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_close_lots_R3.Name = "lab_close_lots_R3";
            this.lab_close_lots_R3.Size = new System.Drawing.Size(66, 23);
            this.lab_close_lots_R3.TabIndex = 48;
            this.lab_close_lots_R3.Text = "2589";
            this.lab_close_lots_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_close_loss_R3
            // 
            this.lab_close_loss_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_close_loss_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_close_loss_R3.Location = new System.Drawing.Point(337, 419);
            this.lab_close_loss_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_close_loss_R3.Name = "lab_close_loss_R3";
            this.lab_close_loss_R3.Size = new System.Drawing.Size(85, 23);
            this.lab_close_loss_R3.TabIndex = 47;
            this.lab_close_loss_R3.Text = "256987";
            this.lab_close_loss_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_close_profit_R3
            // 
            this.lab_close_profit_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_close_profit_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_close_profit_R3.Location = new System.Drawing.Point(332, 382);
            this.lab_close_profit_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_close_profit_R3.Name = "lab_close_profit_R3";
            this.lab_close_profit_R3.Size = new System.Drawing.Size(90, 23);
            this.lab_close_profit_R3.TabIndex = 46;
            this.lab_close_profit_R3.Text = "1256987";
            this.lab_close_profit_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label143
            // 
            this.label143.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label143.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label143.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label143.Location = new System.Drawing.Point(179, 456);
            this.label143.Margin = new System.Windows.Forms.Padding(0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(166, 23);
            this.label143.TabIndex = 45;
            this.label143.Text = "GESCHLOSSEN";
            this.label143.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label144
            // 
            this.label144.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label144.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label144.Location = new System.Drawing.Point(44, 456);
            this.label144.Margin = new System.Windows.Forms.Padding(0);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(166, 23);
            this.label144.TabIndex = 44;
            this.label144.Text = "CLOSED TRADES /";
            this.label144.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label145
            // 
            this.label145.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label145.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label145.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label145.Location = new System.Drawing.Point(99, 419);
            this.label145.Margin = new System.Windows.Forms.Padding(0);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(166, 23);
            this.label145.TabIndex = 43;
            this.label145.Text = "VERLUST";
            this.label145.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label146
            // 
            this.label146.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label146.Location = new System.Drawing.Point(44, 419);
            this.label146.Margin = new System.Windows.Forms.Padding(0);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(166, 23);
            this.label146.TabIndex = 42;
            this.label146.Text = "LOSS /";
            this.label146.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label147
            // 
            this.label147.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label147.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label147.Location = new System.Drawing.Point(111, 382);
            this.label147.Margin = new System.Windows.Forms.Padding(0);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(166, 23);
            this.label147.TabIndex = 41;
            this.label147.Text = "GEWINN";
            this.label147.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label148
            // 
            this.label148.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label148.Location = new System.Drawing.Point(44, 382);
            this.label148.Margin = new System.Windows.Forms.Padding(0);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(166, 23);
            this.label148.TabIndex = 40;
            this.label148.Text = "PROFIT /";
            this.label148.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label119
            // 
            this.label119.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label119.Location = new System.Drawing.Point(38, 358);
            this.label119.Margin = new System.Windows.Forms.Padding(0);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(900, 1);
            this.label119.TabIndex = 39;
            // 
            // label120
            // 
            this.label120.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label120.Location = new System.Drawing.Point(170, 335);
            this.label120.Margin = new System.Windows.Forms.Padding(0);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(275, 23);
            this.label120.TabIndex = 38;
            this.label120.Text = "GESCHLOSSENE POSITIONEN";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label121
            // 
            this.label121.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(38, 335);
            this.label121.Margin = new System.Windows.Forms.Padding(0);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(166, 23);
            this.label121.TabIndex = 37;
            this.label121.Text = "CLOSED TRADES /";
            this.label121.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_open_lots_R8
            // 
            this.lab_open_lots_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_open_lots_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_open_lots_R8.Location = new System.Drawing.Point(830, 278);
            this.lab_open_lots_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_open_lots_R8.Name = "lab_open_lots_R8";
            this.lab_open_lots_R8.Size = new System.Drawing.Size(66, 23);
            this.lab_open_lots_R8.TabIndex = 36;
            this.lab_open_lots_R8.Text = "2589";
            this.lab_open_lots_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_open_loss_R8
            // 
            this.lab_open_loss_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_open_loss_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_open_loss_R8.Location = new System.Drawing.Point(811, 241);
            this.lab_open_loss_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_open_loss_R8.Name = "lab_open_loss_R8";
            this.lab_open_loss_R8.Size = new System.Drawing.Size(85, 23);
            this.lab_open_loss_R8.TabIndex = 35;
            this.lab_open_loss_R8.Text = "256987";
            this.lab_open_loss_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_open_profit_R8
            // 
            this.lab_open_profit_R8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_open_profit_R8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_open_profit_R8.Location = new System.Drawing.Point(806, 204);
            this.lab_open_profit_R8.Margin = new System.Windows.Forms.Padding(0);
            this.lab_open_profit_R8.Name = "lab_open_profit_R8";
            this.lab_open_profit_R8.Size = new System.Drawing.Size(90, 23);
            this.lab_open_profit_R8.TabIndex = 34;
            this.lab_open_profit_R8.Text = "1256987";
            this.lab_open_profit_R8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label97
            // 
            this.label97.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label97.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label97.Location = new System.Drawing.Point(663, 278);
            this.label97.Margin = new System.Windows.Forms.Padding(0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(134, 23);
            this.label97.TabIndex = 33;
            this.label97.Text = "OFFENE ORDERS";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label106
            // 
            this.label106.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label106.Location = new System.Drawing.Point(526, 278);
            this.label106.Margin = new System.Windows.Forms.Padding(0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(166, 23);
            this.label106.TabIndex = 32;
            this.label106.Text = "OPENED TRADES /";
            this.label106.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label107
            // 
            this.label107.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label107.Location = new System.Drawing.Point(579, 241);
            this.label107.Margin = new System.Windows.Forms.Padding(0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(166, 23);
            this.label107.TabIndex = 31;
            this.label107.Text = "VERLUST";
            this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label108
            // 
            this.label108.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label108.Location = new System.Drawing.Point(526, 241);
            this.label108.Margin = new System.Windows.Forms.Padding(0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(166, 23);
            this.label108.TabIndex = 30;
            this.label108.Text = "LOSS /";
            this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label110
            // 
            this.label110.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label110.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label110.Location = new System.Drawing.Point(591, 204);
            this.label110.Margin = new System.Windows.Forms.Padding(0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(166, 23);
            this.label110.TabIndex = 29;
            this.label110.Text = "GEWINN";
            this.label110.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label113
            // 
            this.label113.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label113.Location = new System.Drawing.Point(526, 204);
            this.label113.Margin = new System.Windows.Forms.Padding(0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(166, 23);
            this.label113.TabIndex = 28;
            this.label113.Text = "PROFIT /";
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label118
            // 
            this.label118.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label118.Location = new System.Drawing.Point(523, 98);
            this.label118.Margin = new System.Windows.Forms.Padding(0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(206, 51);
            this.label118.TabIndex = 27;
            this.label118.Text = "SERVER SF 180";
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_open_lots_R3
            // 
            this.lab_open_lots_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_open_lots_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_open_lots_R3.Location = new System.Drawing.Point(356, 278);
            this.lab_open_lots_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_open_lots_R3.Name = "lab_open_lots_R3";
            this.lab_open_lots_R3.Size = new System.Drawing.Size(66, 23);
            this.lab_open_lots_R3.TabIndex = 26;
            this.lab_open_lots_R3.Text = "2589";
            this.lab_open_lots_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_open_loss_R3
            // 
            this.lab_open_loss_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_open_loss_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_open_loss_R3.Location = new System.Drawing.Point(337, 241);
            this.lab_open_loss_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_open_loss_R3.Name = "lab_open_loss_R3";
            this.lab_open_loss_R3.Size = new System.Drawing.Size(85, 23);
            this.lab_open_loss_R3.TabIndex = 25;
            this.lab_open_loss_R3.Text = "256987";
            this.lab_open_loss_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab_open_profit_R3
            // 
            this.lab_open_profit_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_open_profit_R3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_open_profit_R3.Location = new System.Drawing.Point(332, 204);
            this.lab_open_profit_R3.Margin = new System.Windows.Forms.Padding(0);
            this.lab_open_profit_R3.Name = "lab_open_profit_R3";
            this.lab_open_profit_R3.Size = new System.Drawing.Size(90, 23);
            this.lab_open_profit_R3.TabIndex = 24;
            this.lab_open_profit_R3.Text = "1256987";
            this.lab_open_profit_R3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label87
            // 
            this.label87.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label87.Location = new System.Drawing.Point(180, 278);
            this.label87.Margin = new System.Windows.Forms.Padding(0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(166, 23);
            this.label87.TabIndex = 23;
            this.label87.Text = "OFFENE ORDERS";
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label88
            // 
            this.label88.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label88.Location = new System.Drawing.Point(44, 278);
            this.label88.Margin = new System.Windows.Forms.Padding(0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(166, 23);
            this.label88.TabIndex = 22;
            this.label88.Text = "OPENED TRADES /";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label85
            // 
            this.label85.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label85.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label85.Location = new System.Drawing.Point(97, 241);
            this.label85.Margin = new System.Windows.Forms.Padding(0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(166, 23);
            this.label85.TabIndex = 21;
            this.label85.Text = "VERLUST";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label86
            // 
            this.label86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label86.Location = new System.Drawing.Point(44, 241);
            this.label86.Margin = new System.Windows.Forms.Padding(0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(166, 23);
            this.label86.TabIndex = 20;
            this.label86.Text = "LOSS /";
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label83
            // 
            this.label83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label83.Location = new System.Drawing.Point(111, 204);
            this.label83.Margin = new System.Windows.Forms.Padding(0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(166, 23);
            this.label83.TabIndex = 19;
            this.label83.Text = "GEWINN";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label84
            // 
            this.label84.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label84.Location = new System.Drawing.Point(44, 204);
            this.label84.Margin = new System.Windows.Forms.Padding(0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(166, 23);
            this.label84.TabIndex = 18;
            this.label84.Text = "PROFIT /";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label82
            // 
            this.label82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label82.Location = new System.Drawing.Point(37, 98);
            this.label82.Margin = new System.Windows.Forms.Padding(0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(239, 51);
            this.label82.TabIndex = 17;
            this.label82.Text = "SERVER ECN 130";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label81
            // 
            this.label81.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label81.Location = new System.Drawing.Point(40, 178);
            this.label81.Margin = new System.Windows.Forms.Padding(0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(900, 1);
            this.label81.TabIndex = 16;
            // 
            // label79
            // 
            this.label79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label79.Location = new System.Drawing.Point(174, 155);
            this.label79.Margin = new System.Windows.Forms.Padding(0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(166, 23);
            this.label79.TabIndex = 3;
            this.label79.Text = "OFFENE POSITIONEN";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label80
            // 
            this.label80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(40, 155);
            this.label80.Margin = new System.Windows.Forms.Padding(0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(166, 23);
            this.label80.TabIndex = 2;
            this.label80.Text = "OPENED TRADES /";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label78
            // 
            this.label78.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label78.Location = new System.Drawing.Point(181, 24);
            this.label78.Margin = new System.Windows.Forms.Padding(0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(166, 23);
            this.label78.TabIndex = 1;
            this.label78.Text = "ALLE KUNDEN";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(40, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "ALL CLIENTS CRM /";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_administrator
            // 
            this.panel_administrator.BackColor = System.Drawing.Color.White;
            this.panel_administrator.Controls.Add(this.tableLayoutPanel11);
            this.panel_administrator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_administrator.Location = new System.Drawing.Point(0, 60);
            this.panel_administrator.Margin = new System.Windows.Forms.Padding(0);
            this.panel_administrator.Name = "panel_administrator";
            this.panel_administrator.Size = new System.Drawing.Size(990, 730);
            this.panel_administrator.TabIndex = 7;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel13, 0, 2);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.66666F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ctrl_account_administrator);
            this.panel5.Controls.Add(this.ctrl_header_administrator);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(990, 118);
            this.panel5.TabIndex = 0;
            // 
            // ctrl_account_administrator
            // 
            this.ctrl_account_administrator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrl_account_administrator.Location = new System.Drawing.Point(0, 32);
            this.ctrl_account_administrator.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_account_administrator.Name = "ctrl_account_administrator";
            this.ctrl_account_administrator.Size = new System.Drawing.Size(990, 86);
            this.ctrl_account_administrator.TabIndex = 1;
            // 
            // ctrl_header_administrator
            // 
            this.ctrl_header_administrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.ctrl_header_administrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrl_header_administrator.Location = new System.Drawing.Point(0, 0);
            this.ctrl_header_administrator.Margin = new System.Windows.Forms.Padding(0);
            this.ctrl_header_administrator.Name = "ctrl_header_administrator";
            this.ctrl_header_administrator.Size = new System.Drawing.Size(990, 32);
            this.ctrl_header_administrator.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.panel9, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(60, 169);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 4;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(870, 561);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tb_admin_interest);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.lab_admin_month);
            this.panel9.Controls.Add(this.lab_admin_year);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.lab_admin_commission_year);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.label24);
            this.panel9.Controls.Add(this.lab_admin_commission_month);
            this.panel9.Controls.Add(this.label128);
            this.panel9.Controls.Add(this.label129);
            this.panel9.Controls.Add(this.label131);
            this.panel9.Controls.Add(this.label132);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel9.Location = new System.Drawing.Point(0, 360);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(870, 180);
            this.panel9.TabIndex = 2;
            // 
            // tb_admin_interest
            // 
            this.tb_admin_interest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_admin_interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tb_admin_interest.Location = new System.Drawing.Point(770, 35);
            this.tb_admin_interest.Margin = new System.Windows.Forms.Padding(0);
            this.tb_admin_interest.Name = "tb_admin_interest";
            this.tb_admin_interest.Size = new System.Drawing.Size(60, 17);
            this.tb_admin_interest.TabIndex = 91;
            this.tb_admin_interest.Text = "20";
            this.tb_admin_interest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_admin_interest.TextChanged += new System.EventHandler(this.tb_admin_interest_TextChanged);
            this.tb_admin_interest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(833, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_admin_month
            // 
            this.lab_admin_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_month.Location = new System.Drawing.Point(591, 63);
            this.lab_admin_month.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_month.Name = "lab_admin_month";
            this.lab_admin_month.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_month.TabIndex = 43;
            this.lab_admin_month.Text = "JULI";
            this.lab_admin_month.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lab_admin_year
            // 
            this.lab_admin_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_year.Location = new System.Drawing.Point(591, 93);
            this.lab_admin_year.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_year.Name = "lab_admin_year";
            this.lab_admin_year.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_year.TabIndex = 42;
            this.lab_admin_year.Text = "2019";
            this.lab_admin_year.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(830, 1);
            this.label5.TabIndex = 41;
            // 
            // lab_admin_commission_year
            // 
            this.lab_admin_commission_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_commission_year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_admin_commission_year.Location = new System.Drawing.Point(716, 93);
            this.lab_admin_commission_year.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_commission_year.Name = "lab_admin_commission_year";
            this.lab_admin_commission_year.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_commission_year.TabIndex = 12;
            this.lab_admin_commission_year.Text = "1468";
            this.lab_admin_commission_year.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label23.Location = new System.Drawing.Point(222, 93);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(250, 25);
            this.label23.TabIndex = 11;
            this.label23.Text = "KOMMISION FÜR DAS JAHR";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label24.Location = new System.Drawing.Point(3, 93);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(250, 25);
            this.label24.TabIndex = 10;
            this.label24.Text = "COMMISSION FOR THE YEAR /";
            this.label24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_admin_commission_month
            // 
            this.lab_admin_commission_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_commission_month.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_admin_commission_month.Location = new System.Drawing.Point(715, 63);
            this.lab_admin_commission_month.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_commission_month.Name = "lab_admin_commission_month";
            this.lab_admin_commission_month.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_commission_month.TabIndex = 5;
            this.lab_admin_commission_month.Text = "1468";
            this.lab_admin_commission_month.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label128
            // 
            this.label128.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label128.Location = new System.Drawing.Point(237, 63);
            this.label128.Margin = new System.Windows.Forms.Padding(0);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(250, 25);
            this.label128.TabIndex = 4;
            this.label128.Text = "KOMMISION FÜR DEN MONAT";
            this.label128.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label129
            // 
            this.label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label129.Location = new System.Drawing.Point(3, 63);
            this.label129.Margin = new System.Windows.Forms.Padding(0);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(250, 25);
            this.label129.TabIndex = 3;
            this.label129.Text = "COMMISSION FOR THE MONTH /";
            this.label129.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label131
            // 
            this.label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label131.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label131.Location = new System.Drawing.Point(219, 28);
            this.label131.Margin = new System.Windows.Forms.Padding(0);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(250, 25);
            this.label131.TabIndex = 1;
            this.label131.Text = "GEWINNBETEILIGUNG %";
            this.label131.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label132
            // 
            this.label132.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label132.Location = new System.Drawing.Point(3, 28);
            this.label132.Margin = new System.Windows.Forms.Padding(0);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(250, 25);
            this.label132.TabIndex = 0;
            this.label132.Text = "COMMITMENT TO INTEREST / ";
            this.label132.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.lab_admin_commission_total);
            this.panel8.Controls.Add(this.label111);
            this.panel8.Controls.Add(this.label112);
            this.panel8.Controls.Add(this.label114);
            this.panel8.Controls.Add(this.lab_admin_closed);
            this.panel8.Controls.Add(this.label116);
            this.panel8.Controls.Add(this.label117);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 180);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(870, 180);
            this.panel8.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(830, 1);
            this.label3.TabIndex = 40;
            // 
            // lab_admin_commission_total
            // 
            this.lab_admin_commission_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_commission_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_admin_commission_total.Location = new System.Drawing.Point(716, 104);
            this.lab_admin_commission_total.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_commission_total.Name = "lab_admin_commission_total";
            this.lab_admin_commission_total.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_commission_total.TabIndex = 8;
            this.lab_admin_commission_total.Text = "2056";
            this.lab_admin_commission_total.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label111
            // 
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label111.Location = new System.Drawing.Point(3, 104);
            this.label111.Margin = new System.Windows.Forms.Padding(0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(250, 25);
            this.label111.TabIndex = 6;
            this.label111.Text = "COMMISSION TOTAL";
            this.label111.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label112
            // 
            this.label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label112.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label112.Location = new System.Drawing.Point(716, 75);
            this.label112.Margin = new System.Windows.Forms.Padding(0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(120, 25);
            this.label112.TabIndex = 5;
            this.label112.Text = "8.00";
            this.label112.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label114
            // 
            this.label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label114.Location = new System.Drawing.Point(3, 75);
            this.label114.Margin = new System.Windows.Forms.Padding(0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(250, 25);
            this.label114.TabIndex = 3;
            this.label114.Text = "COMMISSION PER LOT";
            this.label114.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_admin_closed
            // 
            this.lab_admin_closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_closed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_admin_closed.Location = new System.Drawing.Point(716, 40);
            this.lab_admin_closed.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_closed.Name = "lab_admin_closed";
            this.lab_admin_closed.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_closed.TabIndex = 2;
            this.lab_admin_closed.Text = "257";
            this.lab_admin_closed.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label116
            // 
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label116.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label116.Location = new System.Drawing.Point(148, 40);
            this.label116.Margin = new System.Windows.Forms.Padding(0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(250, 25);
            this.label116.TabIndex = 1;
            this.label116.Text = "GESCHLOSSENE POSITIONEN";
            this.label116.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label117
            // 
            this.label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label117.Location = new System.Drawing.Point(3, 40);
            this.label117.Margin = new System.Windows.Forms.Padding(0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(250, 25);
            this.label117.TabIndex = 0;
            this.label117.Text = "CLOSED POSITION /";
            this.label117.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label75);
            this.panel7.Controls.Add(this.lab_admin_swap);
            this.panel7.Controls.Add(this.label67);
            this.panel7.Controls.Add(this.label68);
            this.panel7.Controls.Add(this.lab_admin_loss);
            this.panel7.Controls.Add(this.label64);
            this.panel7.Controls.Add(this.label65);
            this.panel7.Controls.Add(this.lab_admin_profit);
            this.panel7.Controls.Add(this.label61);
            this.panel7.Controls.Add(this.label59);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(474, 180);
            this.panel7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(830, 1);
            this.label8.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label18.Location = new System.Drawing.Point(3, 13);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(250, 25);
            this.label18.TabIndex = 41;
            this.label18.Text = "CRM";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label75
            // 
            this.label75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label75.Location = new System.Drawing.Point(2, 211);
            this.label75.Margin = new System.Windows.Forms.Padding(0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(808, 1);
            this.label75.TabIndex = 15;
            // 
            // lab_admin_swap
            // 
            this.lab_admin_swap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_swap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_admin_swap.Location = new System.Drawing.Point(716, 115);
            this.lab_admin_swap.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_swap.Name = "lab_admin_swap";
            this.lab_admin_swap.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_swap.TabIndex = 8;
            this.lab_admin_swap.Text = "148658";
            this.lab_admin_swap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label67
            // 
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label67.Location = new System.Drawing.Point(114, 115);
            this.label67.Margin = new System.Windows.Forms.Padding(0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(250, 25);
            this.label67.TabIndex = 7;
            this.label67.Text = "ZINSEN TOTAL";
            this.label67.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label68
            // 
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label68.Location = new System.Drawing.Point(3, 115);
            this.label68.Margin = new System.Windows.Forms.Padding(0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(250, 25);
            this.label68.TabIndex = 6;
            this.label68.Text = "SWAP TOTAL /";
            this.label68.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_admin_loss
            // 
            this.lab_admin_loss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_loss.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_admin_loss.Location = new System.Drawing.Point(716, 82);
            this.lab_admin_loss.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_loss.Name = "lab_admin_loss";
            this.lab_admin_loss.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_loss.TabIndex = 5;
            this.lab_admin_loss.Text = "-21587";
            this.lab_admin_loss.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label64
            // 
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label64.Location = new System.Drawing.Point(109, 82);
            this.label64.Margin = new System.Windows.Forms.Padding(0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(250, 25);
            this.label64.TabIndex = 4;
            this.label64.Text = "VERLUSTE TOTAL";
            this.label64.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label65
            // 
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label65.Location = new System.Drawing.Point(3, 82);
            this.label65.Margin = new System.Windows.Forms.Padding(0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(250, 25);
            this.label65.TabIndex = 3;
            this.label65.Text = "LOSS TOTAL /";
            this.label65.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_admin_profit
            // 
            this.lab_admin_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_admin_profit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_admin_profit.Location = new System.Drawing.Point(716, 50);
            this.lab_admin_profit.Margin = new System.Windows.Forms.Padding(0);
            this.lab_admin_profit.Name = "lab_admin_profit";
            this.lab_admin_profit.Size = new System.Drawing.Size(120, 25);
            this.lab_admin_profit.TabIndex = 2;
            this.lab_admin_profit.Text = "12589";
            this.lab_admin_profit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.label61.Location = new System.Drawing.Point(123, 50);
            this.label61.Margin = new System.Windows.Forms.Padding(0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(250, 25);
            this.label61.TabIndex = 1;
            this.label61.Text = "GEWINNE TOTAL";
            this.label61.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label59
            // 
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label59.Location = new System.Drawing.Point(3, 50);
            this.label59.Margin = new System.Windows.Forms.Padding(0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(250, 25);
            this.label59.TabIndex = 0;
            this.label59.Text = "PROFIT TOTAL /";
            this.label59.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel_clients
            // 
            this.panel_clients.BackColor = System.Drawing.Color.White;
            this.panel_clients.Controls.Add(this.tableLayoutPanel7);
            this.panel_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_clients.Location = new System.Drawing.Point(0, 60);
            this.panel_clients.Name = "panel_clients";
            this.panel_clients.Size = new System.Drawing.Size(990, 730);
            this.panel_clients.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel22, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel21, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.panel1, 0, 9);
            this.tableLayoutPanel7.Controls.Add(this.label102, 0, 10);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel23, 0, 11);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 12;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63698F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091323F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091323F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091323F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.63699F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45207F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(990, 730);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 4;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel22.Controls.Add(this.label99, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.tb_search_money_shift, 2, 0);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(0, 324);
            this.tableLayoutPanel22.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(990, 30);
            this.tableLayoutPanel22.TabIndex = 3;
            // 
            // label99
            // 
            this.label99.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label99.Location = new System.Drawing.Point(72, 2);
            this.label99.Margin = new System.Windows.Forms.Padding(2);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(346, 26);
            this.label99.TabIndex = 0;
            this.label99.Text = "CLIENT SEARCH BY MONEY SHIFT";
            this.label99.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_search_money_shift
            // 
            this.tb_search_money_shift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search_money_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_search_money_shift.Location = new System.Drawing.Point(421, 1);
            this.tb_search_money_shift.Margin = new System.Windows.Forms.Padding(1);
            this.tb_search_money_shift.Name = "tb_search_money_shift";
            this.tb_search_money_shift.Size = new System.Drawing.Size(400, 26);
            this.tb_search_money_shift.TabIndex = 1;
            this.tb_search_money_shift.TextChanged += new System.EventHandler(this.tb_search_money_shift_TextChanged);
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 4;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel21.Controls.Add(this.label98, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.tb_search_pamm, 2, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(0, 242);
            this.tableLayoutPanel21.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(990, 30);
            this.tableLayoutPanel21.TabIndex = 2;
            // 
            // label98
            // 
            this.label98.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label98.Location = new System.Drawing.Point(72, 2);
            this.label98.Margin = new System.Windows.Forms.Padding(2);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(346, 26);
            this.label98.TabIndex = 0;
            this.label98.Text = "CLIENT SEARCH BY PAMM";
            this.label98.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_search_pamm
            // 
            this.tb_search_pamm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search_pamm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_search_pamm.Location = new System.Drawing.Point(421, 1);
            this.tb_search_pamm.Margin = new System.Windows.Forms.Padding(1);
            this.tb_search_pamm.Name = "tb_search_pamm";
            this.tb_search_pamm.Size = new System.Drawing.Size(400, 26);
            this.tb_search_pamm.TabIndex = 1;
            this.tb_search_pamm.TextChanged += new System.EventHandler(this.tb_search_pamm_TextChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel8.Controls.Add(this.lab_search_account, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tb_search_account, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(990, 30);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // lab_search_account
            // 
            this.lab_search_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_search_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_search_account.Location = new System.Drawing.Point(72, 2);
            this.lab_search_account.Margin = new System.Windows.Forms.Padding(2);
            this.lab_search_account.Name = "lab_search_account";
            this.lab_search_account.Size = new System.Drawing.Size(346, 26);
            this.lab_search_account.TabIndex = 0;
            this.lab_search_account.Text = "CLIENT SEARCH ACCOUNT NO.";
            this.lab_search_account.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_search_account
            // 
            this.tb_search_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_search_account.Location = new System.Drawing.Point(421, 1);
            this.tb_search_account.Margin = new System.Windows.Forms.Padding(1);
            this.tb_search_account.Name = "tb_search_account";
            this.tb_search_account.Size = new System.Drawing.Size(400, 26);
            this.tb_search_account.TabIndex = 1;
            this.tb_search_account.TextChanged += new System.EventHandler(this.tb_search_account_TextChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel9.Controls.Add(this.lab_search_name, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.tb_search_name, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 160);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(990, 30);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // lab_search_name
            // 
            this.lab_search_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_search_name.Location = new System.Drawing.Point(72, 2);
            this.lab_search_name.Margin = new System.Windows.Forms.Padding(2);
            this.lab_search_name.Name = "lab_search_name";
            this.lab_search_name.Size = new System.Drawing.Size(346, 26);
            this.lab_search_name.TabIndex = 1;
            this.lab_search_name.Text = "CLIENT SEARCH NAME";
            this.lab_search_name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_search_name
            // 
            this.tb_search_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_search_name.Location = new System.Drawing.Point(421, 1);
            this.tb_search_name.Margin = new System.Windows.Forms.Padding(1);
            this.tb_search_name.Name = "tb_search_name";
            this.tb_search_name.Size = new System.Drawing.Size(400, 26);
            this.tb_search_name.TabIndex = 2;
            this.tb_search_name.TextChanged += new System.EventHandler(this.tb_search_name_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label101);
            this.panel1.Controls.Add(this.label100);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(70, 432);
            this.panel1.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 32);
            this.panel1.TabIndex = 5;
            // 
            // label101
            // 
            this.label101.Dock = System.Windows.Forms.DockStyle.Left;
            this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.label101.Location = new System.Drawing.Point(160, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(235, 32);
            this.label101.TabIndex = 5;
            this.label101.Text = "EINGELOGTE KUNDEN";
            this.label101.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label100
            // 
            this.label100.Dock = System.Windows.Forms.DockStyle.Left;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label100.Location = new System.Drawing.Point(0, 0);
            this.label100.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(160, 32);
            this.label100.TabIndex = 4;
            this.label100.Text = "ACTIVE CLIENTS /";
            this.label100.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label102
            // 
            this.label102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.label102.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label102.Location = new System.Drawing.Point(70, 464);
            this.label102.Margin = new System.Windows.Forms.Padding(70, 0, 70, 1);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(850, 2);
            this.label102.TabIndex = 6;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 3;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Controls.Add(this.label103, 0, 1);
            this.tableLayoutPanel23.Controls.Add(this.label104, 0, 2);
            this.tableLayoutPanel23.Controls.Add(this.label105, 0, 3);
            this.tableLayoutPanel23.Controls.Add(this.lab_active_clients, 1, 1);
            this.tableLayoutPanel23.Controls.Add(this.lab_active_pamm, 1, 2);
            this.tableLayoutPanel23.Controls.Add(this.lab_active_money_shift, 1, 3);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(70, 467);
            this.tableLayoutPanel23.Margin = new System.Windows.Forms.Padding(70, 0, 70, 0);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 5;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(850, 263);
            this.tableLayoutPanel23.TabIndex = 7;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label103.Location = new System.Drawing.Point(0, 30);
            this.label103.Margin = new System.Windows.Forms.Padding(0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(340, 30);
            this.label103.TabIndex = 0;
            this.label103.Text = "ACTIVE CLIENTS";
            this.label103.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label104.Location = new System.Drawing.Point(0, 60);
            this.label104.Margin = new System.Windows.Forms.Padding(0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(340, 30);
            this.label104.TabIndex = 1;
            this.label104.Text = "ACTIVE BY PAMM";
            this.label104.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label105.Location = new System.Drawing.Point(0, 90);
            this.label105.Margin = new System.Windows.Forms.Padding(0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(340, 30);
            this.label105.TabIndex = 2;
            this.label105.Text = "ACTIVE BY MONEY SHIFT";
            this.label105.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lab_active_clients
            // 
            this.lab_active_clients.AutoSize = true;
            this.lab_active_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_active_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_active_clients.Location = new System.Drawing.Point(340, 30);
            this.lab_active_clients.Margin = new System.Windows.Forms.Padding(0);
            this.lab_active_clients.Name = "lab_active_clients";
            this.lab_active_clients.Size = new System.Drawing.Size(85, 30);
            this.lab_active_clients.TabIndex = 3;
            this.lab_active_clients.Text = "689";
            this.lab_active_clients.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lab_active_pamm
            // 
            this.lab_active_pamm.AutoSize = true;
            this.lab_active_pamm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_active_pamm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_active_pamm.Location = new System.Drawing.Point(340, 60);
            this.lab_active_pamm.Margin = new System.Windows.Forms.Padding(0);
            this.lab_active_pamm.Name = "lab_active_pamm";
            this.lab_active_pamm.Size = new System.Drawing.Size(85, 30);
            this.lab_active_pamm.TabIndex = 4;
            this.lab_active_pamm.Text = "412";
            this.lab_active_pamm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lab_active_money_shift
            // 
            this.lab_active_money_shift.AutoSize = true;
            this.lab_active_money_shift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_active_money_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_active_money_shift.Location = new System.Drawing.Point(340, 90);
            this.lab_active_money_shift.Margin = new System.Windows.Forms.Padding(0);
            this.lab_active_money_shift.Name = "lab_active_money_shift";
            this.lab_active_money_shift.Size = new System.Drawing.Size(85, 30);
            this.lab_active_money_shift.TabIndex = 5;
            this.lab_active_money_shift.Text = "325";
            this.lab_active_money_shift.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel_head_1
            // 
            this.panel_head_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.panel_head_1.Controls.Add(this.panel_head);
            this.panel_head_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head_1.Location = new System.Drawing.Point(0, 0);
            this.panel_head_1.Margin = new System.Windows.Forms.Padding(0);
            this.panel_head_1.Name = "panel_head_1";
            this.panel_head_1.Padding = new System.Windows.Forms.Padding(1);
            this.panel_head_1.Size = new System.Drawing.Size(990, 60);
            this.panel_head_1.TabIndex = 0;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.White;
            this.panel_head.Controls.Add(this.lab_top_warning);
            this.panel_head.Controls.Add(this.btn_tradingdesk_new);
            this.panel_head.Controls.Add(this.lab_stockprice_diff);
            this.panel_head.Controls.Add(this.btn_login);
            this.panel_head.Controls.Add(this.lab_pip_difference);
            this.panel_head.Controls.Add(this.btn_search);
            this.panel_head.Controls.Add(this.btn_setting);
            this.panel_head.Controls.Add(this.btn_logo);
            this.panel_head.Controls.Add(this.btn_maximize);
            this.panel_head.Controls.Add(this.btn_restore);
            this.panel_head.Controls.Add(this.btn_exit);
            this.panel_head.Controls.Add(this.lab_head_title);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_head.Location = new System.Drawing.Point(1, 1);
            this.panel_head.Margin = new System.Windows.Forms.Padding(0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(988, 58);
            this.panel_head.TabIndex = 0;
            this.panel_head.DoubleClick += new System.EventHandler(this.header_double_Click);
            // 
            // lab_top_warning
            // 
            this.lab_top_warning.BackColor = System.Drawing.Color.Transparent;
            this.lab_top_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_top_warning.Location = new System.Drawing.Point(197, 21);
            this.lab_top_warning.Name = "lab_top_warning";
            this.lab_top_warning.Size = new System.Drawing.Size(500, 17);
            this.lab_top_warning.TabIndex = 4;
            this.lab_top_warning.Text = "Warning";
            this.lab_top_warning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_top_warning.Visible = false;
            this.lab_top_warning.Click += new System.EventHandler(this.lab_top_warning_Click);
            // 
            // btn_tradingdesk_new
            // 
            this.btn_tradingdesk_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_tradingdesk_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_tradingdesk_new.FlatAppearance.BorderSize = 0;
            this.btn_tradingdesk_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tradingdesk_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_tradingdesk_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tradingdesk_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_tradingdesk_new.ForeColor = System.Drawing.Color.Black;
            this.btn_tradingdesk_new.Location = new System.Drawing.Point(141, 15);
            this.btn_tradingdesk_new.Name = "btn_tradingdesk_new";
            this.btn_tradingdesk_new.Size = new System.Drawing.Size(27, 24);
            this.btn_tradingdesk_new.TabIndex = 3;
            this.btn_tradingdesk_new.Text = "+";
            this.btn_tradingdesk_new.UseVisualStyleBackColor = false;
            this.btn_tradingdesk_new.Click += new System.EventHandler(this.btn_tradingdesk_new_Click);
            // 
            // lab_stockprice_diff
            // 
            this.lab_stockprice_diff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.lab_stockprice_diff.Enabled = false;
            this.lab_stockprice_diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_stockprice_diff.ForeColor = System.Drawing.Color.White;
            this.lab_stockprice_diff.Location = new System.Drawing.Point(307, 17);
            this.lab_stockprice_diff.Name = "lab_stockprice_diff";
            this.lab_stockprice_diff.Size = new System.Drawing.Size(103, 25);
            this.lab_stockprice_diff.TabIndex = 0;
            this.lab_stockprice_diff.Text = "1.10259";
            this.lab_stockprice_diff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Image = global::FXFellowDashboard.Properties.Resources.Gender_Neutral_User_64px;
            this.btn_login.ImageActive = null;
            this.btn_login.Location = new System.Drawing.Point(734, 17);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(28, 27);
            this.btn_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_login.TabIndex = 1;
            this.btn_login.TabStop = false;
            this.btn_login.Zoom = 20;
            this.btn_login.Click += new System.EventHandler(this.nav_login_Click);
            // 
            // lab_pip_difference
            // 
            this.lab_pip_difference.AutoSize = true;
            this.lab_pip_difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lab_pip_difference.Location = new System.Drawing.Point(197, 21);
            this.lab_pip_difference.Name = "lab_pip_difference";
            this.lab_pip_difference.Size = new System.Drawing.Size(97, 17);
            this.lab_pip_difference.TabIndex = 0;
            this.lab_pip_difference.Text = "Pip Difference";
            this.lab_pip_difference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Image = global::FXFellowDashboard.Properties.Resources.Search_48px;
            this.btn_search.ImageActive = null;
            this.btn_search.Location = new System.Drawing.Point(772, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(28, 27);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 1;
            this.btn_search.TabStop = false;
            this.btn_search.Zoom = 20;
            this.btn_search.Click += new System.EventHandler(this.nav_clients_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting.Image = global::FXFellowDashboard.Properties.Resources.Settings_64px;
            this.btn_setting.ImageActive = null;
            this.btn_setting.Location = new System.Drawing.Point(810, 17);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(28, 27);
            this.btn_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_setting.TabIndex = 1;
            this.btn_setting.TabStop = false;
            this.btn_setting.Zoom = 20;
            this.btn_setting.Click += new System.EventHandler(this.nav_settings_Click);
            // 
            // btn_logo
            // 
            this.btn_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logo.BackColor = System.Drawing.Color.Transparent;
            this.btn_logo.Image = global::FXFellowDashboard.Properties.Resources.logo;
            this.btn_logo.ImageActive = null;
            this.btn_logo.Location = new System.Drawing.Point(933, 5);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(48, 48);
            this.btn_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logo.TabIndex = 1;
            this.btn_logo.TabStop = false;
            this.btn_logo.Zoom = 0;
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.ImageActive = null;
            this.btn_maximize.Location = new System.Drawing.Point(848, 17);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(28, 27);
            this.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximize.TabIndex = 1;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Zoom = 20;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.BackColor = System.Drawing.Color.Transparent;
            this.btn_restore.Image = ((System.Drawing.Image)(resources.GetObject("btn_restore.Image")));
            this.btn_restore.ImageActive = null;
            this.btn_restore.Location = new System.Drawing.Point(848, 17);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(28, 27);
            this.btn_restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restore.TabIndex = 1;
            this.btn_restore.TabStop = false;
            this.btn_restore.Visible = false;
            this.btn_restore.Zoom = 20;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = global::FXFellowDashboard.Properties.Resources.Exit_64px;
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(886, 17);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(28, 27);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 20;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lab_head_title
            // 
            this.lab_head_title.AutoSize = true;
            this.lab_head_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lab_head_title.Location = new System.Drawing.Point(26, 20);
            this.lab_head_title.Name = "lab_head_title";
            this.lab_head_title.Size = new System.Drawing.Size(119, 18);
            this.lab_head_title.TabIndex = 0;
            this.lab_head_title.Text = "TRADING DESK";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lab_prog_name;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel_head;
            this.bunifuDragControl2.Vertical = true;
            // 
            // lab_spread_alert
            // 
            this.lab_spread_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_spread_alert.ForeColor = System.Drawing.Color.White;
            this.lab_spread_alert.Location = new System.Drawing.Point(0, 134);
            this.lab_spread_alert.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lab_spread_alert.Name = "lab_spread_alert";
            this.lab_spread_alert.Size = new System.Drawing.Size(108, 20);
            this.lab_spread_alert.TabIndex = 2;
            this.lab_spread_alert.Text = "SPREAD ALERT <";
            // 
            // num_spread_alert
            // 
            this.num_spread_alert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_spread_alert.Location = new System.Drawing.Point(111, 134);
            this.num_spread_alert.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_spread_alert.Name = "num_spread_alert";
            this.num_spread_alert.Size = new System.Drawing.Size(46, 16);
            this.num_spread_alert.TabIndex = 3;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.All.ResumeLayout(false);
            this.layout_main.ResumeLayout(false);
            this.panel_side.ResumeLayout(false);
            this.panel_side.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel_tab.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.panel_middle.ResumeLayout(false);
            this.panel_tf_button.ResumeLayout(false);
            this.btn_panel.ResumeLayout(false);
            this.panel_balance_alert.ResumeLayout(false);
            this.panel_balance_alert.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_tradingdesk.ResumeLayout(false);
            this.panel_tradingdesk_up.ResumeLayout(false);
            this.panel_tradingdesk_up_client.ResumeLayout(false);
            this.panel_tradingdesk_up_symbol.ResumeLayout(false);
            this.tableLayoutPanel28.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_pending_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modify_pending_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_pending_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_remove_price_alert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_price_alert)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel29.PerformLayout();
            this.panel_tradingdesk_down.ResumeLayout(false);
            this.panel_order2.ResumeLayout(false);
            this.panel_order1.ResumeLayout(false);
            this.panel_order_header.ResumeLayout(false);
            this.panel_order_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order1_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_order2_close)).EndInit();
            this.panel_chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_view)).EndInit();
            this.panel_details.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_notification_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_phone_number_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_money_difference_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_margin_alert_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_margin_call_save)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_show_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide_password)).EndInit();
            this.panel19.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_start)).EndInit();
            this.panel_settings.ResumeLayout(false);
            this.panel_settings.PerformLayout();
            this.panel_pamm.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pamm_start)).EndInit();
            this.panel_pamm_master.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.panel_dashboard.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard_start)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel_orders.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_orders_start)).EndInit();
            this.panel_history.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_history_130)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_order_history_180)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel_statement.ResumeLayout(false);
            this.panel_tradingdesk_new.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_view_3)).EndInit();
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_view_8)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel_statistics.ResumeLayout(false);
            this.panel_statistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel_administrator.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel_clients.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.panel_head_1.ResumeLayout(false);
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_spread_alert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel All;
        private System.Windows.Forms.TableLayoutPanel layout_main;
        private System.Windows.Forms.TableLayoutPanel panel_side;
        private System.Windows.Forms.Label lab_prog_name;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel panel_head_1;
        private System.Windows.Forms.Panel panel_head;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lab_head_title;
        private System.Windows.Forms.Panel panel_dashboard;
        private System.Windows.Forms.Panel panel_tab;
        private System.Windows.Forms.FlowLayoutPanel nav_panel;
        private Bunifu.Framework.UI.BunifuFlatButton nav_login;
        private Bunifu.Framework.UI.BunifuFlatButton nav_dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton nav_clients;
        private Bunifu.Framework.UI.BunifuFlatButton nav_details;
        private Bunifu.Framework.UI.BunifuFlatButton nav_orders;
        private System.Windows.Forms.Button btn_expand;
        private Bunifu.Framework.UI.BunifuFlatButton nav_tradingdesk;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_login;
        private Bunifu.Framework.UI.BunifuImageButton btn_search;
        private Bunifu.Framework.UI.BunifuImageButton btn_setting;
        private Bunifu.Framework.UI.BunifuFlatButton nav_administrator;
        private Bunifu.Framework.UI.BunifuFlatButton nav_statistics;
        private Bunifu.Framework.UI.BunifuFlatButton nav_settings;
		private Bunifu.Framework.UI.BunifuFlatButton nav_history;
        private Bunifu.Framework.UI.BunifuImageButton btn_logo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
		private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Panel panel_history;
        private System.Windows.Forms.Panel panel_statistics;
        private System.Windows.Forms.Panel panel_administrator;
        private System.Windows.Forms.Panel panel_tradingdesk;
        private System.Windows.Forms.Panel panel_orders;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.Panel panel_clients;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_view;
        private System.Windows.Forms.Panel panel_tf_button;
        private System.Windows.Forms.FlowLayoutPanel btn_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_plus;
        private Bunifu.Framework.UI.BunifuFlatButton btn_minus;
        private Bunifu.Framework.UI.BunifuFlatButton btn_m1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_m5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_m15;
        private Bunifu.Framework.UI.BunifuFlatButton btn_m30;
        private Bunifu.Framework.UI.BunifuFlatButton btn_h1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_h4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_d1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_w1;
        private System.Windows.Forms.Label lab_spread;
        private System.Windows.Forms.Label lab_swap;
        private System.Windows.Forms.Label lab_breakeven;
        private Bunifu.Framework.UI.BunifuFlatButton nav_pamm;
        private System.Windows.Forms.Panel panel_pamm;
        private System.Windows.Forms.TableLayoutPanel panel_tradingdesk_down;
        private System.Windows.Forms.TableLayoutPanel panel_tradingdesk_up;
        private System.Windows.Forms.TableLayoutPanel panel_tradingdesk_up_client;
        private System.Windows.Forms.TableLayoutPanel panel_tradingdesk_up_symbol;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private TextBox tb_client_search;
        private Label label51;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login_new_account;
        private Label label53;
        private Label label52;
        private FlowLayoutPanel flow_clients;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel3;
        private Label label58;
        private Label label57;
        private Label label56;
        private Label label55;
        private Label label54;
        private FXFellowDashboard.ClientCtrl ctrl_client;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label lab_search_account;
        private TextBox tb_search_account;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lab_search_name;
        private TextBox tb_search_name;
        private AccountsCtrl ctrl_account_tradingdesk;
        private HeaderCtrl ctrl_header_tradingdesk;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private AccountsCtrl ctrl_account_orders;
        private HeaderCtrl ctrl_header_orders;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel10;
        private FlowLayoutPanel flow_orders;
        private TableLayoutPanel tableLayoutPanel11;
        private Panel panel5;
        private AccountsCtrl ctrl_account_administrator;
        private HeaderCtrl ctrl_header_administrator;
        private TableLayoutPanel tableLayoutPanel19;
        private Panel panel6;
        private HeaderCtrl ctrl_header_dashboard;
        private FlowLayoutPanel flow_dashboard;
        private OrderHeaderCtrl ctrl_header;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel panel_pamm_master;
        private TableLayoutPanel tableLayoutPanel20;
        private HeaderPAMM ctrl_header_slave;
        private FlowLayoutPanel flow_pamm;
        private HeaderPAMM ctrl_header_master;
        private Label label90;
        private AccountPAMM ctrl_account_pamm;
        private TableLayoutPanel tableLayoutPanel22;
        private Label label99;
        private TextBox tb_search_money_shift;
        private TableLayoutPanel tableLayoutPanel21;
        private Label label98;
        private TextBox tb_search_pamm;
        private Panel panel1;
        private Label label101;
        private Label label100;
        private Label label102;
        private TableLayoutPanel tableLayoutPanel23;
        private Label label103;
        private Label label104;
        private Label label105;
        private Label lab_active_clients;
        private Label lab_active_pamm;
        private Label lab_active_money_shift;
        private TableLayoutPanel tableLayoutPanel13;
        private Panel panel7;
        private Panel panel9;
        private Label lab_admin_commission_month;
        private Label label128;
        private Label label129;
        private Label label131;
        private Label label132;
        private Panel panel8;
        private Label lab_admin_commission_total;
        private Label label111;
        private Label label112;
        private Label label114;
        private Label lab_admin_closed;
        private Label label116;
        private Label label117;
        private Label label75;
        private Label lab_admin_swap;
        private Label label67;
        private Label label68;
        private Label lab_admin_loss;
        private Label label64;
        private Label label65;
        private Label lab_admin_profit;
        private Label label61;
        private Label label59;
        private Label lab_open_lots_R8;
        private Label lab_open_loss_R8;
        private Label lab_open_profit_R8;
        private Label label97;
        private Label label106;
        private Label label107;
        private Label label108;
        private Label label110;
        private Label label113;
        private Label label118;
        private Label lab_open_lots_R3;
        private Label lab_open_loss_R3;
        private Label lab_open_profit_R3;
        private Label label87;
        private Label label88;
        private Label label85;
        private Label label86;
        private Label label83;
        private Label label84;
        private Label label82;
        private Label label81;
        private Label label79;
        private Label label80;
        private Label label78;
        private Label label6;
        private Label lab_commission_total_R8;
        private Label label155;
        private Label label156;
        private Label lab_commission_per_lot_R8;
        private Label label158;
        private Label label134;
        private Label label135;
        private Label lab_commission_total_R3;
        private Label label153;
        private Label label151;
        private Label lab_commission_per_lot_R3;
        private Label label150;
        private Label lab_close_lots_R8;
        private Label lab_close_loss_R8;
        private Label lab_close_profit_R8;
        private Label label136;
        private Label label137;
        private Label label138;
        private Label label139;
        private Label lab_close_lots_R3;
        private Label lab_close_loss_R3;
        private Label lab_close_profit_R3;
        private Label label143;
        private Label label144;
        private Label label145;
        private Label label146;
        private Label label147;
        private Label label148;
        private Label label119;
        private Label label120;
        private Label label121;
        private Label lab_settings_account1;
        private Label label166;
        private Label label165;
        private Label label164;
        private Label label162;
        private Label label163;
        private Label label159;
        private Label label160;
        private Label label161;
        private Bunifu.Framework.UI.BunifuCheckbox cb_settings_pnl;
        private Bunifu.Framework.UI.BunifuCheckbox cb_settings_transfer;
        private Bunifu.Framework.UI.BunifuCheckbox cb_settings_balance;
        private Bunifu.Framework.UI.BunifuCheckbox cb_settings_curr;
        private Label label175;
        private Label label171;
        private Label label173;
        private Label lab_settings_pip;
        private Label label167;
        private Label label168;
        private Label label169;
        private Label lab_settings_account2;
        private Label label193;
        private Label label194;
        private Label label195;
        private Label label196;
        private Label label185;
        private Label label187;
        private Label label189;
        private Label label191;
        private Label lab_settings_stick;
        private Label lab_settings_short;
        private Label lab_settings_long;
        private Label lab_settings_grid;
        private Label label183;
        private Label label184;
        private Label label180;
        private Label label181;
        private Label label176;
        private Label label179;
        private Bunifu.Framework.UI.BunifuCheckbox cb_settings_equity;
        private Label label172;
        private Label lab_settings_font;
        private TableLayoutPanel tableLayoutPanel15;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel16;
        private Panel panel12;
        private AccountsCtrl ctrl_account_details;
        private HeaderCtrl ctrl_header_details;
        private Panel panel13;
        private Label label224;
        private Label label217;
        private Label label219;
        private Label label213;
        private Label label214;
        private Label label208;
        private Label label209;
        private Label label202;
        private Label label203;
        private Label label204;
        private Label lab_details_breakeven;
        private Label lab_details_swap_tot;
        private Label label225;
        private Label label229;
        private Label label238;
        private TextBox tb_margin_alert;
        private Label label237;
        private Bunifu.Framework.UI.BunifuCheckbox cb_moneyshift_onoff;
        private Bunifu.Framework.UI.BunifuCheckbox cb_pamm_onoff;
        private Label label241;
        private TextBox tb_margin_call;
        private Label label239;
        private Label label240;
        private Label lab_details_account1;
        private TextBox tb_moneyshift;
        private Bunifu.Framework.UI.BunifuFlatButton btn_pamm_master;
        private TextBox textBox5;
        private TableLayoutPanel panel_order2;
        private TableLayoutPanel panel_order1;
        private Label order_separator;
        private TableLayoutPanel panel_order_header;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lab_order2_account2;
        private Label lab_order2_sell2;
        private Label lab_order2_lot2;
        private Label lab_order2_symbol2;
        private Label lab_order2_pnl2;
        private Label lab_order2_spread2;
        private Label lab_order2_buy2;
        private Label lab_order2_symbol1;
        private Label lab_order2_account1;
        private Label lab_order2_lot1;
        private Label lab_order2_sell1;
        private Label lab_order2_buy1;
        private Label lab_order2_spread1;
        private Label lab_order2_pnl1;
        private Label lab_order1_pnl2;
        private Label lab_order1_spread2;
        private Label lab_order1_buy2;
        private Label lab_order1_sell2;
        private Label lab_order1_lot2;
        private Label lab_order1_symbol2;
        private Label lab_order1_account2;
        private Label lab_order1_pnl1;
        private Label lab_order1_spread1;
        private Label lab_order1_buy1;
        private Label lab_order1_sell1;
        private Label lab_order1_lot1;
        private Label lab_order1_symbol1;
        private Label lab_order1_account1;
        private Bunifu.Framework.UI.BunifuImageButton btn_order1_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_order2_close;
        private TableLayoutPanel tableLayoutPanel17;
        private Label label60;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progress;
        private Panel panel14;
        private Bunifu.Framework.UI.BunifuImageButton btn_hide_password;
        private Bunifu.Framework.UI.BunifuImageButton btn_show_password;
        private TableLayoutPanel tableLayoutPanel18;
        private Panel panel15;
        private Bunifu.Framework.UI.BunifuImageButton btn_login_prev;
        private Bunifu.Framework.UI.BunifuImageButton btn_login_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_login_end;
        private Bunifu.Framework.UI.BunifuImageButton btn_login_start;
        private Bunifu.Framework.UI.BunifuDropdown dp_login_display_num;
        private TextBox tb_login_page;
        private TableLayoutPanel tableLayoutPanel24;
        private Panel panel16;
        private Bunifu.Framework.UI.BunifuDropdown dp_pamm_display_num;
        private TextBox tb_pamm_page;
        private Bunifu.Framework.UI.BunifuImageButton btn_pamm_prev;
        private Bunifu.Framework.UI.BunifuImageButton btn_pamm_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_pamm_end;
        private Bunifu.Framework.UI.BunifuImageButton btn_pamm_start;
        private TableLayoutPanel tableLayoutPanel25;
        private Panel panel17;
        private Bunifu.Framework.UI.BunifuDropdown dp_dashboard_display_num;
        private TextBox tb_dashboard_page;
        private Bunifu.Framework.UI.BunifuImageButton btn_dashboard_prev;
        private Bunifu.Framework.UI.BunifuImageButton btn_dashboard_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_dashboard_end;
        private Bunifu.Framework.UI.BunifuImageButton btn_dashboard_start;
        private TableLayoutPanel tableLayoutPanel26;
        private Panel panel18;
        private Bunifu.Framework.UI.BunifuDropdown dp_orders_display_num;
        private TextBox tb_orders_page;
        private Bunifu.Framework.UI.BunifuImageButton btn_orders_prev;
        private Bunifu.Framework.UI.BunifuImageButton btn_orders_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_orders_end;
        private Bunifu.Framework.UI.BunifuImageButton btn_orders_start;
        private Bunifu.Framework.UI.BunifuImageButton btn_money_difference_save;
        private Bunifu.Framework.UI.BunifuImageButton btn_margin_alert_save;
        private Bunifu.Framework.UI.BunifuImageButton btn_margin_call_save;
        private Label lab_live_clients;
        private Label lab_tot_clients;
        private Label label9;
        private Label label17;
        private Panel panel19;
        private Label label21;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Label lab_admin_commission_year;
        private Label label23;
        private Label label24;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Label label32;
        private Label label29;
        private Label label31;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label33;
        private Bunifu.Framework.UI.BunifuImageButton btn_notification_save;
        private Bunifu.Framework.UI.BunifuImageButton btn_phone_number_save;
        private Label label36;
        private Label label38;
        private Bunifu.Framework.UI.BunifuCheckbox cb_settings_shiftat;
        private Label label28;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox tb_phone_number;
        private TextBox tb_notification;
        private Label label35;
        private Label label37;
        private Label label34;
        private Label label7;
        private Label label30;
        private Label label2;
        private Label lab_admin_month;
        private Label lab_admin_year;
        private Label label5;
        private Label label3;
        private Label label8;
        private Label label18;
        private Label label4;
        private TextBox tb_admin_interest;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Label label19;
        private DateTimePicker dt_picker;
        private TextBox tb_license;
        private Label label20;
        private Label label22;
        private Bunifu.Framework.UI.BunifuCheckbox cb_settings_show_client;
        private Label label41;
        private Bunifu.Framework.UI.BunifuImageButton btn_maximize;
        private Bunifu.Framework.UI.BunifuImageButton btn_restore;
        private Panel panel20;
        private Label lab_version_release;
        private Label lab_broker_client;
        private Label lab_setting_phone;
        private Label lab_setting_margincall;
        private Label lab_setting_moneyshfit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_setting_phone;
        private Bunifu.Framework.UI.BunifuFlatButton btn_setting_margincall;
        private Bunifu.Framework.UI.BunifuFlatButton btn_setting_moneyshfit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_pdf;
        private Label lab_details_account2;
        private Panel panel_td_pendingorder;
        private Button btn_tradingdesk_new;
        private Panel panel_tradingdesk_new;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel27;
        private Panel panel25;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_view_3;
        private Panel panel23;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_view_8;
        private Panel panel21;
        private Label lab_tradingdesk_new_client;
        private Label lab_stockprice_diff;
        private Label lab_pip_difference;
        private Panel panel22;
        private Bunifu.Framework.UI.BunifuImageButton btn_add_price_alert;
        private FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_td_show_order;
        private Bunifu.Framework.UI.BunifuFlatButton btn_td_pending_order;
        private Bunifu.Framework.UI.BunifuFlatButton btn_td_alert;
        private Bunifu.Framework.UI.BunifuImageButton btn_remove_price_alert;
        private Bunifu.Framework.UI.BunifuImageButton btn_delete_pending_order;
        private Bunifu.Framework.UI.BunifuImageButton btn_modify_pending_order;
        private Bunifu.Framework.UI.BunifuImageButton btn_add_pending_order;
        private TDBuySellCtrl td_buysell_ctrl;
        private PAMMBuySellCtrl pamm_buysell_ctrl;
        private Bunifu.Framework.UI.BunifuFlatButton nav_statement;
        private Panel panel_statement;
        private Bunifu.Framework.UI.BunifuFlatButton btn_statement_year_pdf;
        private HTMLViewCtrl statement_html_ctrl;
        private Label label39;
        private TableLayoutPanel tableLayoutPanel14;
        private Label lab_history_130;
        private Label progress_history;
        private DataGridView grid_order_history_130;
        private DataGridView grid_order_history_180;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panel_middle;
        private Panel panel_balance_alert;
        private Label label40;
        private Label label46;
        private Bunifu.Framework.UI.BunifuFlatButton btn_balance_alert_name;
        private Label label42;
        private Panel panel11;
        private Label lab_history_client_name;
        private Label lab_history_180;
        private TableLayoutPanel tableLayoutPanel28;
        private Panel panel24;
        private TableLayoutPanel tableLayoutPanel29;
        private Label lab_td_symbol4;
        private Label lab_td_symbol3;
        private Label lab_td_symbol2;
        private Label lab_td_symbol1;
        private Label lab_td_symbol0;
        private Label label43;
        private Label label62;
        private Label lab_td_percent4;
        private Label lab_td_percent3;
        private Label lab_td_percent2;
        private Label lab_td_percent1;
        private Label lab_td_percent0;
        private Label label72;
        private Label lab_td_lot4;
        private Label lab_td_lot3;
        private Label lab_td_lot2;
        private Label lab_td_lot1;
        private Label lab_td_lot0;
        private Label lab_top_warning;
        private Label label47;
        private Bunifu.Framework.UI.BunifuCheckbox cb_close_trades;
        private Label label44;
        private DateTimePicker swap_dt_picker;
        private Label label48;
        private Bunifu.Framework.UI.BunifuCheckbox cb_swapfree2;
        private Bunifu.Framework.UI.BunifuCheckbox cb_swapfree1;
        private Label label45;
        private Label label66;
        private Label lab_hedge_account2;
        private Label lab_hedge_account1;
        private Bunifu.Framework.UI.BunifuCheckbox cb_hedge2;
        private Bunifu.Framework.UI.BunifuCheckbox cb_hedge1;
        private Label label49;
        private Label lab_spread_alert;
        private NumericUpDown num_spread_alert;
    }
}

