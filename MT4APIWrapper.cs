using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MTClientAPI;

namespace FXFellowDashboard
{
    public enum RQ_TYPE
    {
        OPEN = 0,
        CLOSE = 1,
        REOPEN = 2,
        MODIFY = 3
    };

    public class LotsPercentInfo
    {
        public List<double> lotsList;
        public List<double> percentList;

        public void Init()
        {
            lotsList = new List<double>();
            percentList = new List<double>();

            for(int i = 0; i < 8; i++)
            {
                lotsList.Add(0);
                percentList.Add(0);
            }
        }
    }


    public class CheckMoneyShiftInfo
    {
        public string client_name;

        public int amount;
        public DateTime start_time;

        public int account1;
        public bool finished1;
        public DateTime end_time1;

        public int account2;
        public bool finished2;
        public DateTime end_time2;

        public void Init()
        {
            finished1 = false;
            finished2 = false;
            end_time1 = DateTime.MinValue;
            end_time2 = DateTime.MinValue;
        }
    }

    public class MinMaxPriceInfo
    {
        public double minPrice;
        public double maxPrice;
        public double breakevenPrice;

        public double minLots;
        public double maxLots;
        public double breakevenLots;
    }

    public class ReopenOrderInfo
    {
        public int symbol_id;
        public int client_id;
        public double lots;
    }

    public class OrderInfo
    {
        public int server_id; //R8:0, R3:1
        public int client_id;
        public int request_id;
        public RQ_TYPE request_type;
        public Op order_type;
        public int symbol_id;
        public string symbol;
        public int ticket;
        public double lots;
        public int repeat_num;
        public MarketPending market_pending;
        public double open_price;
        public double modify_price;
    }

    public class MT4APIWrapper
    {
        public bool login_finished;
        public int license_state; //1:good, 0:bad, -1:done
        private ClientLogin client;

        //server 130
        public double[] R3_ask;
        public double[] R3_bid;
        public DateTime[] R3_time;
        public bool[] R3_increase_flag;

        public DateTime[] R3_historytime;
        public double[] R3_open;
        public double[] R3_high;
        public double[] R3_low;
        public double[] R3_close;

        //server 180
        public double[] R8_ask;
        public double[] R8_bid;
        public DateTime[] R8_time;

        public DateTime[] R8_historytime;
        public double[] R8_open;
        public double[] R8_high;
        public double[] R8_low;
        public double[] R8_close;

        public Timeframe current_tf;
        public int tradingdesk_symbol_id;
        public int pamm_symbol_id;

        public EventHandler initial_login_finished_handle;
        public EventHandler new_login_finished_handle;
        public EventHandler connection_changed_handle;
        public EventHandler currency_changed_handle;
        public EventHandler draw_chart_handle_R8;
        public EventHandler draw_chart_handle_R3;
        public EventHandler OnQuote_handle;
        public EventHandler OnOrderUpdate_handle;

        public List<OrderInfo> processing_order_list;
        public Dictionary<int, int> loginSuccessDict;

        public List<CheckMoneyShiftInfo> checkMoneyShiftList;

        public bool is_downloading_history;
        private List<DownloadSymbolInfo> downloadRequestedSymbolList;

        public void Init()
        {
            login_finished = true;
            current_tf = Timeframe.MN1;
            tradingdesk_symbol_id = 0;
            pamm_symbol_id = 0;
            license_state = 1;

            try
            {
                downloadRequestedSymbolList = new List<DownloadSymbolInfo>();
                is_downloading_history = false;

                int symbolNum = Settings.symbol_num;
                int maxNum = 520;

                //server 130
                R3_ask = new double[symbolNum];
                R3_bid = new double[symbolNum];
                R3_time = new DateTime[symbolNum];
                R3_increase_flag = new bool[symbolNum];

                R3_historytime = new DateTime[maxNum];
                R3_open = new double[maxNum];
                R3_high = new double[maxNum];
                R3_low = new double[maxNum];
                R3_close = new double[maxNum];

                //server 180
                R8_bid = new double[symbolNum];
                R8_ask = new double[symbolNum];
                R8_time = new DateTime[symbolNum];

                R8_historytime = new DateTime[maxNum];
                R8_open = new double[maxNum];
                R8_high = new double[maxNum];
                R8_low = new double[maxNum];
                R8_close = new double[maxNum];

                for (int i = 0; i < symbolNum; i++)
                {
                    R3_ask[i] = R8_bid[i] = R3_bid[i] = R8_ask[i] = 0;
                    R3_time[i] = DateTime.MinValue;
                    R8_time[i] = DateTime.MinValue;
                    R3_increase_flag[i] = true;
                }

                processing_order_list = new List<OrderInfo>();
                processing_order_list.Clear();

                loginSuccessDict = new Dictionary<int, int>();
                loginSuccessDict.Clear();

                checkMoneyShiftList = new List<CheckMoneyShiftInfo>();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Init MT4API Wrapper failed: " + ex.ToString());
            }
        }

        public void save_moneyshift_info(int client_id, int first_second, int money_shift_current)
        {
            CheckMoneyShiftInfo info = new CheckMoneyShiftInfo();
            info.Init();
            info.start_time = DateTime.Now;
            info.amount = money_shift_current;
            info.client_name = client.nameList[client_id];

            if (first_second == 1)
            {
                info.account1 = client.userIdList[2 * client_id];
                info.account2 = client.userIdList[2 * client_id + 1];
            }
            else
            {
                info.account1 = client.userIdList[2 * client_id + 1];
                info.account2 = client.userIdList[2 * client_id];
            }

            checkMoneyShiftList.Add(info);
        }

        public void set_client_class(ClientLogin clients)
        {
            client = clients;
        }

        public void login_initial_client()
        {
            try
            {
                login_finished = false;

                int totNum = client.tot_client_num;
                Thread[] threads = new Thread[totNum];
                for (int k = 0; k < totNum; k++)
                {
                    var param = new LoginParam()
                    {
                        id = k,
                        userId1 = client.userIdList[2 * k],
                        userId2 = client.userIdList[2 * k + 1],
                        password1 = client.passwordList[2 * k],
                        password2 = client.passwordList[2 * k + 1],
                        server_name1 = client.serverNameList[2 * k],
                        server_name2 = client.serverNameList[2 * k + 1],
                        server_index1 = client.serverIndexList[2 * k],
                        server_index2 = client.serverIndexList[2 * k + 1]
                    };

                    client.serverIndexList[2 * k]++;
                    client.serverIndexList[2 * k + 1]++;

                    threads[k] = new Thread(login_api);
                    threads[k].IsBackground = true;
                    threads[k].Start(param);

                    Thread.Sleep(1000);
                }

                for(int i = 0; i < totNum; i ++)
                {
                    threads[i].Join();
                }

                client.wait_for_loading_closed_orders();
                client.set_datafeed_client();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Login initial client failed: " + ex.ToString());
            }

            login_finished = true;

            if (initial_login_finished_handle != null)
                initial_login_finished_handle(this, EventArgs.Empty);
        }

        private void disconnect_one_client(int k)
        {
            try
            {
                QuoteClient qc1 = client.qcList[2 * k];
                QuoteClient qc2 = client.qcList[2 * k + 1];

                qc1.Disconnect();
                qc2.Disconnect();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("disconnect one client failed: " + ex.ToString());
            }
        }

        public bool check_relogin_accounts()
        {
            if (!login_finished) return false;

            TimeSpan ts = DateTime.Now - client.lastAutoLoginTime;
            if (ts.Seconds < Settings.relogin_time_limit) return false;

            for (int i = 0; i < client.tot_client_num; i++)
            {
                if (!client.check_connection_both_accounts(i, false))
                {
                    bool val, fg1, fg2;
                    int user_id1 = client.userIdList[2 * i];
                    int user_id2 = client.userIdList[2 * i + 1];
                    fg1 = client.accountBestConnectionDict.TryGetValue(user_id1, out val);
                    fg2 = client.accountBestConnectionDict.TryGetValue(user_id2, out val);

                    if(fg1 || fg2) return true;
                }
            }
            return false;
        }

        public void relogin_accounts()
        {
            for(int i = 0; i < client.tot_client_num; i++)
            {
                if (client.check_connection_both_accounts(i, false)) continue;
                client.lastAutoLoginTime = DateTime.Now;
                login_one_client(i);
            }
        }

        public void login_one_client(int k)
        {
            try
            {
                login_finished = false;

                disconnect_one_client(k);
                var param = new LoginParam()
                {
                    id = k,
                    userId1 = client.userIdList[2 * k],
                    userId2 = client.userIdList[2 * k + 1],
                    password1 = client.passwordList[2 * k],
                    password2 = client.passwordList[2 * k + 1],
                    server_name1 = client.serverNameList[2 * k],
                    server_name2 = client.serverNameList[2 * k + 1],
                    server_index1 = client.serverIndexList[2 * k],
                    server_index2 = client.serverIndexList[2 * k + 1]
                };

                client.serverIndexList[2 * k]++;
                client.serverIndexList[2 * k + 1]++;

                Thread thr = new Thread(login_api);
                thr.IsBackground = true;
                thr.Start(param);
                thr.Join();

                client.wait_for_loading_closed_orders();
                client.set_datafeed_client();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("login one client failed: " + ex.ToString());
            }
            login_finished = true;
            if (initial_login_finished_handle != null)
                initial_login_finished_handle(this, EventArgs.Empty);
        }

        public void login_new_client()
        {
            login_finished = false;
            int totNum = client.tot_client_num;
            int k = totNum - 1;
            try
            { 
                var param = new LoginParam()
                {
                    id = k,
                    userId1 = client.userIdList[2 * k],
                    userId2 = client.userIdList[2 * k + 1],
                    password1 = client.passwordList[2 * k],
                    password2 = client.passwordList[2 * k + 1],
                    server_name1 = client.serverNameList[2 * k],
                    server_name2 = client.serverNameList[2 * k + 1],
                    server_index1 = client.serverIndexList[2 * k],
                    server_index2 = client.serverIndexList[2 * k + 1]
                };

                client.serverIndexList[2 * k]++;
                client.serverIndexList[2 * k + 1]++;

                Thread thr = new Thread(login_api);
                thr.IsBackground = true;
                thr.Start(param);
                thr.Join();

                client.wait_for_loading_closed_orders();
                client.set_datafeed_client();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Login new client failed: " + ex.ToString());
            }
            login_finished = true;

            LoginArgs arg = new LoginArgs();
            arg.isSuccess = true;

            int val = 0;
            if(!loginSuccessDict.TryGetValue(k, out val) || val == 0) arg.isSuccess = false;

            if (new_login_finished_handle != null)
                new_login_finished_handle(this, arg);
        }

        private void change_login_success_dict(int client_id, int fg)
        {
            int val;
            if (loginSuccessDict.TryGetValue(client_id, out val)) loginSuccessDict[client_id] = fg;
            else loginSuccessDict.Add(client_id, fg);
        }

        public void login_api(object p)
        {
            var login_params = p as LoginParam;
            int id = login_params.id;
            int userId1 = login_params.userId1;
            int userId2 = login_params.userId2;
            string password1 = login_params.password1;
            string password2 = login_params.password2;
            string server_name1 = login_params.server_name1;
            string server_name2 = login_params.server_name2;
            int server_index1 = login_params.server_index1;
            int server_index2 = login_params.server_index2;

            if (password1 == "" || password2 == "")
            {
                change_connection(userId1, 0);
                change_connection(userId2, 0);
                change_login_success_dict(id, 0);
                return;
            }

            string serverFile;
            Server[] servers;
            string folderWithServers;

            QuoteClient _qc1, _qc2;
            OrderClient _oc1, _oc2;

            // if connecting now, don't try again
            if(get_connection(userId1) == -1 || get_connection(userId2) == -1)
                return;

            if(get_connection(userId1) == 0)
            {
                //account 1
                serverFile = server_name1 + ".srv";
                folderWithServers = Path.Combine(Directory.GetCurrentDirectory(), "Servers");
                MainServer server1 = QuoteClient.LoadSrv(Path.Combine(folderWithServers, serverFile), out servers); //load broker server file

                string server_host1 = server1.Host;
                int server_port1 = server1.Port;
                int server_count1 = servers.Length;

                // change server dynamically
                if (server_index1 >= 0 && server_count1 > 1)
                {
                    var new_server = servers[server_index1 % server_count1];

                    server_host1 = new_server.Host;
                    server_port1 = new_server.Port;
                }
                Settings.Log.Info($"Trying to login account {userId1} using IP {server_host1}");

                _qc1 = new QuoteClient(userId1, password1, server_host1, server_port1);
                _qc1.OnConnect += new ConnectEventHandler(qc_OnConnect); //subscribe to OnConnect event
                _qc1.OnDisconnect += new DisconnectEventHandler(qc_OnDisconnect); //subscribe to OnDisconnect event
                _qc1.OnOrderUpdate += new OrderUpdateEventHandler(qc_OnOrderUpdate); //subscribe to OnOrderUpdate event
                _qc1.OnQuote += new QuoteEventHandler(qc_OnQuote); //subscribe to OnQuote event
                _qc1.OnQuoteHistory += new QuoteHistoryEventHandler(qc_OnQuoteHistory);
                _qc1.SleepTime = 1;
                _qc1.PathForSavingSrv = folderWithServers;

                _oc1 = new OrderClient(_qc1);
                _oc1.OnOrderProgress += new OrderProgressEventHandler(oc_OnOrderProgress);

                client.qcList[2 * id] = _qc1;
                client.ocList[2 * id] = _oc1;

                try
                {
                    change_connection(userId1, -1); // connecting
                    _qc1.Connect();
                }
                catch (Exception ex)
                {
                    Settings.Log.Error("Login Error: userId1 = " + userId1.ToString() + " " + ex.ToString());
                    change_connection(userId1, 0);
                    change_login_success_dict(id, 0);
                }
            }

            if(get_connection(userId2) == 0)
            {
                //account 2
                serverFile = server_name2 + ".srv";
                folderWithServers = Path.Combine(Directory.GetCurrentDirectory(), "Servers");
                MainServer server2 = QuoteClient.LoadSrv(Path.Combine(folderWithServers, serverFile), out servers); //load broker server file

                string server_host2 = server2.Host;
                int server_port2 = server2.Port;
                int server_count2 = servers.Length;

                // change server dynamically
                if (server_index2 >= 0 && server_count2 > 1)
                {
                    var new_server = servers[server_index2 % server_count2];

                    server_host2 = new_server.Host;
                    server_port2 = new_server.Port;
                }
                Settings.Log.Info($"Trying to login account {userId2} using IP {server_host2}");

                _qc2 = new QuoteClient(userId2, password2, server_host2, server_port2);
                _qc2.OnConnect += new ConnectEventHandler(qc_OnConnect); //subscribe to OnConnect event
                _qc2.OnDisconnect += new DisconnectEventHandler(qc_OnDisconnect); //subscribe to OnDisconnect event
                _qc2.OnOrderUpdate += new OrderUpdateEventHandler(qc_OnOrderUpdate); //subscribe to OnOrderUpdate event
                _qc2.OnQuote += new QuoteEventHandler(qc_OnQuote); //subscribe to OnQuote event
                _qc2.OnQuoteHistory += new QuoteHistoryEventHandler(qc_OnQuoteHistory);
                _qc2.SleepTime = 1;
                _qc2.PathForSavingSrv = folderWithServers;

                _oc2 = new OrderClient(_qc2);
                _oc2.OnOrderProgress += new OrderProgressEventHandler(oc_OnOrderProgress);

                client.qcList[2 * id + 1] = _qc2;
                client.ocList[2 * id + 1] = _oc2;

                try
                {
                    change_connection(userId2, -1); // connecting
                    _qc2.Connect();
                }
                catch (Exception ex)
                {
                    Settings.Log.Error("Login Error: userId2 = " + userId2.ToString() + " " + ex.ToString());
                    change_connection(userId2, 0);
                    change_login_success_dict(id, 0);
                }
            }

            change_login_success_dict(id, 1);
            if (client.server_time == DateTime.MinValue)
            {
                get_server_time(client.qcList[2 * id], client.qcList[2 * id + 1]);
            }
        }

        private void get_server_time(QuoteClient qc1, QuoteClient qc2)
        {
            int count = 0;
            while (client.server_time == DateTime.MinValue && count < 100)
            {
                Thread.Sleep(10);
                count++;
            }
            if (qc1.ServerTime != DateTime.MinValue) client.server_time = qc1.ServerTime;
            if (qc2.ServerTime != DateTime.MinValue) client.server_time = qc2.ServerTime;
        }

        private void refresh_server_time(QuoteClient qc)
        {
            int count = 0;
            while(qc.ServerTime == DateTime.MinValue && count < 100)
            {
                Thread.Sleep(10);
                count++;
            }
        }

        private int get_connection(int user_id)
        {
            try
            {
                for (int i = 0; i < client.tot_client_num; i++)
                {
                    if (client.userIdList[2 * i] == user_id)
                        return client.connectionList[2 * i];

                    if (client.userIdList[2 * i + 1] == user_id)
                        return client.connectionList[2 * i + 1];
                }
            }
            catch (Exception )
            {
            }

            return 0;
        }

        private void change_connection(int user_id, int val)
        {
            try
            {
                if (val > 0) client.save_account_best_connection(user_id);

                for (int i = 0; i < client.tot_client_num; i++)
                {
                    if (client.userIdList[2 * i] == user_id)
                        client.connectionList[2 * i] = val;
                    if (client.userIdList[2 * i + 1] == user_id)
                        client.connectionList[2 * i + 1] = val;
                }
                if (connection_changed_handle != null)
                    connection_changed_handle(this, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Change connection failed: " + ex.ToString());
            }
        }

        private void change_currency(int user_id, string val)
        {
            try
            {
                for (int i = 0; i < client.tot_client_num; i++)
                {
                    if (client.userIdList[2 * i] == user_id)
                        client.currencyList[2 * i] = val;
                    if (client.userIdList[2 * i + 1] == user_id)
                        client.currencyList[2 * i + 1] = val;
                }
                if (currency_changed_handle != null)
                    currency_changed_handle(this, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Change currency failed: " + ex.ToString());
            }
        }

        private void qc_OnQuoteHistory(object sender, QuoteHistoryEventArgs args)
        {
            try
            {
                //Settings.Log.Info($"Downloaded History: Symbol={args.Symbol} Bars={args.Bars.Length}");

                int nBars = args.Bars.Length;
                if (nBars == 1 && args.Bars[0].Time == new DateTime(1970, 1, 1))
                {
                    return;
                }

                is_downloading_history = false;

                int server_id = client.get_server_id(((QuoteClient)sender).User);
                if (server_id < 0)
                    return;

                if(server_id == 0)
                {
                    for (int i = 0; i < nBars; i++)
                    {
                        int id;
                        if (nBars == 1) id = i; else id = nBars - i;

                        R8_historytime[id] = args.Bars[i].Time;
                        R8_open[id] = args.Bars[i].Open;
                        R8_high[id] = args.Bars[i].High;
                        R8_low[id] = args.Bars[i].Low;
                        R8_close[id] = args.Bars[i].Close;
                    }

                    if (R8_open[0] > 0 && R8_open[1] > 0 && draw_chart_handle_R8 != null)
                    {
                        draw_chart_handle_R8(this, EventArgs.Empty);
                    }
                }
                else if (server_id == 1)
                {
                    for (int i = 0; i < nBars; i++)
                    {
                        int id;
                        if (nBars == 1) id = i; else id = nBars - i;

                        R3_historytime[id] = args.Bars[i].Time;
                        R3_open[id] = args.Bars[i].Open;
                        R3_high[id] = args.Bars[i].High;
                        R3_low[id] = args.Bars[i].Low;
                        R3_close[id] = args.Bars[i].Close;
                    }

                    if (R3_open[0] > 0 && R3_open[1] > 0 && draw_chart_handle_R3 != null)
                    {
                        draw_chart_handle_R3(this, EventArgs.Empty);
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("On Quote history failed: " + ex.ToString());
            }
        }

        public void close_orders_SLTP()
        {
            if (license_state <= 0) return;
            try
            {
                QuoteClient qc1;
                QuoteClient qc2;
                List<int> R83_orderList;

                for (int i = 0; i < client.tot_client_num; i++)
                {
                    if(client.check_connection_both_accounts(i))
                    {
                        qc1 = client.qcList[2 * i];
                        qc2 = client.qcList[2 * i + 1];

                        R83_orderList = client.get_matched_order_list_close(i);
                        int tot_num = R83_orderList.Count / 2;
                        if (tot_num == 0) return;

                        var orders1 = qc1.GetOpenedOrders();
                        var orders2 = qc2.GetOpenedOrders();
                        double SLTP;

                        for (int k = 0; k < tot_num; k++)
                        {
                            int order_id1 = R83_orderList[2 * k];
                            int order_id2 = R83_orderList[2 * k + 1];

                            if (order_id1 >= 0 && order_id1 < orders1.Length)
                            {
                                var order = orders1[order_id1];
                                if(client.dict_SLTP.TryGetValue(order.Ticket, out SLTP))
                                {
                                    double cur_PnL = order.Profit + order.Swap;
                                    if((SLTP > 0 && cur_PnL >= SLTP) || (SLTP < 0 && cur_PnL <= SLTP))
                                    {
                                        close_hedge_orders(i, order_id1, order_id2);
                                        continue;
                                    }
                                }
                            }

                            if (order_id2 >= 0 && order_id2 < orders2.Length)
                            {
                                var order = orders2[order_id2];
                                if (client.dict_SLTP.TryGetValue(order.Ticket, out SLTP))
                                {
                                    double cur_PnL = order.Profit + order.Swap;
                                    if ((SLTP > 0 && cur_PnL >= SLTP) || (SLTP < 0 && cur_PnL <= SLTP))
                                    {
                                        close_hedge_orders(i, order_id1, order_id2);
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Close orders SLTP failed: " + ex.ToString());
            }
        }

        private void qc_OnQuote(object sender, QuoteEventArgs args)
        {
            if (client.datafeed_client_id < 0 || client.no_client()) return;

            if (((QuoteClient)sender).ServerTime != DateTime.MinValue)
                client.server_time = ((QuoteClient)sender).ServerTime;

            int user_id = ((QuoteClient)sender).User;
            if (user_id != client.userIdList[client.datafeed_client_id * 2] && user_id != client.userIdList[client.datafeed_client_id * 2 + 1]) return;

            int server_id = client.get_server_id(((QuoteClient)sender).User);

            bool isUpdated = false;
            string str_symbol = args.Symbol;
            if (str_symbol == "UKOilCash") str_symbol = "XBRUSD";
            if (str_symbol == "USOilCash") str_symbol = "XTIUSD";
            for (int i = 0; i < Settings.symbol_num; i++)
            {
                if (!Settings.SymbolsToSubscribe[i].Contains(str_symbol))
                    continue;

                if(server_id == 0)
                {
                    if (R8_bid[i] != args.Bid || R8_ask[i] != args.Ask)
                    {
                        isUpdated = true;

                        R8_ask[i] = args.Ask;
                        R8_bid[i] = args.Bid;
                        R8_time[i] = args.Time;

                        if(i == tradingdesk_symbol_id)
                        {
                            //update history data
                            R8_high[0] = Math.Max(R8_high[0], R8_bid[tradingdesk_symbol_id]);
                            R8_low[0] = Math.Min(R8_low[0], R8_bid[tradingdesk_symbol_id]);
                            R8_close[0] = R8_bid[tradingdesk_symbol_id];
                        }
                    }
                }
                else if(server_id == 1)
                {
                    if (R3_bid[i] < args.Bid) R3_increase_flag[i] = true;
                    else if(R3_bid[i] > args.Bid) R3_increase_flag[i] = false;

                    if (R3_bid[i] != args.Bid || R3_ask[i] != args.Ask)
                    {
                        isUpdated = true;

                        R3_bid[i] = args.Bid;
                        R3_ask[i] = args.Ask;
                        R3_time[i] = args.Time;

                        if(i == tradingdesk_symbol_id)
                        {
                            //update history data
                            R3_high[0] = Math.Max(R3_high[0], R3_bid[tradingdesk_symbol_id]);
                            R3_low[0] = Math.Min(R3_low[0], R3_bid[tradingdesk_symbol_id]);
                            R3_close[0] = R3_bid[tradingdesk_symbol_id];
                        }
                    }
                }
            }

            if (!isUpdated) return;

            if(OnQuote_handle != null)
                OnQuote_handle(this, EventArgs.Empty);
        }

        private void update_moneyshift_list(int user_id, Order order)
        {
            try
            {
                foreach(CheckMoneyShiftInfo info in checkMoneyShiftList)
                {
                    if(info.account1 == user_id) //sender
                    {
                        if(info.amount == -order.Profit)
                        {
                            info.finished1 = true;
                            info.end_time1 = DateTime.Now;
                        }
                    }
                    else if(info.account2 == user_id) //receiver
                    {
                        if(info.amount == order.Profit)
                        {
                            info.finished2 = true;
                            info.end_time2 = DateTime.Now;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Update moneyshift list failed: " + ex.ToString());
            }
        }

        private void qc_OnOrderUpdate(object sender, OrderUpdateEventArgs update)
        {
            int userId = ((QuoteClient)sender).User;
            if (update.Action.ToString() == "Balance")
            {
                client.init_pending_userId(userId);
                update_moneyshift_list(userId, update.Order);
            }
            else if(update.Action.ToString().Contains("Close"))
            {
                client.update_closed_orders(userId, update.Order);
                client.remove_dict_close_pending(update.Order.Ticket);
            }
            else if(update.Action.ToString() == "PendingFill")
            {
                int client_id = client.find_id_from_userId(userId);

                if(client_id % 2 == 0) //pending order at R8
                {
                    //MessageBox.Show("Error: Pending order was filled at R8 server!");
                }
                else if(client_id >= 0)
                {
                    client_id /= 2;
                    Settings.Log.Info("Pending order was triggered: " + update.Order.Symbol + " " + update.Order.Lots.ToString("0.00"));
                    open_R8_order_after_pending(client_id, update.Order);
                }
            }

            if (OnOrderUpdate_handle != null)
                OnOrderUpdate_handle(this, EventArgs.Empty);
        }

        private void qc_OnConnect(object sender, ConnectEventArgs args)
        {
            //client.lastAutoLoginTime = DateTime.Now;
            try
            {
                int user_id = ((QuoteClient)sender).User;
                if (args.Exception == null)
                {
                    string currency = ((QuoteClient)sender).Account.currency;
                    change_currency(user_id, currency);

                    change_connection(user_id, 1);

                    client.get_closed_order_info(user_id);

                    Settings.Log.Info(user_id.ToString() + ": Connected");
                }
                else
                {
                    Settings.Log.Info(user_id.ToString() + ": Disconnected");
                    change_connection(user_id, 0);
                }

                client.set_datafeed_client();
                is_downloading_history = false;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("On Connect failed: " + ex.ToString());
            }
        }

        private void qc_OnDisconnect(object sender, DisconnectEventArgs args)
        {
            //client.lastAutoLoginTime = DateTime.Now;
            try
            {
                int user_id = ((QuoteClient)sender).User;
                change_connection(user_id, 0);
                client.set_datafeed_client();

                Settings.Log.Info(user_id.ToString() + ": Disconnected");
            }
            catch(Exception ex)
            {
                Settings.Log.Error("On Disconnect failed: " + ex.ToString());
            }
        }

        public string get_digit_string(int symbold_id = -1)
        {
            if (symbold_id < 0) symbold_id = tradingdesk_symbol_id;

            int _digit = Settings.SymbolsDigit[symbold_id];

            string resStr = "0.";
            for (int i = 0; i < _digit; i++) resStr += "0";
            return resStr;
        }

        void delete_processing_order_info(int req_id)
        {
            try
            {
                int len = processing_order_list.Count;

                for (int i = 0; i < len; i++)
                {
                    if (processing_order_list[i].request_id == req_id)
                    {
                        processing_order_list.RemoveAt(i);
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Delete order info list failed: " + ex.ToString());
            }
        }

        public double get_spread_sum(int symbold_id)
        {
            double spread1 = (int)((R3_ask[symbold_id] - R3_bid[symbold_id]) / Settings.SymbolsPoint[symbold_id]);
            double spread2 = (int)((R8_ask[symbold_id] - R8_bid[symbold_id]) / Settings.SymbolsPoint[symbold_id]);
            return spread1 + spread2;
        }

        public void close_old_orders_per_day(DateTime curTime, int dayLimit = 30)
        {
            int dayofweek = (int)curTime.DayOfWeek;

            if (dayofweek == 0 || dayofweek == 6)
                return;
            int offset = 0;
            if (dayofweek == 5) offset = 2;

            for (int i = 0; i < client.tot_client_num; i++)
            {
                if (client.check_connection_both_accounts(i))
                {
                    // R8
                    {
                        var qc = client.qcList[2 * i];
                        var orders = qc.GetOpenedOrders();

                        foreach (var order in orders)
                        {
                            if (is_market_order(order))
                            {
                                int _night = client.count_nights_from_time(order.OpenTime, curTime);

                                if(_night <= dayLimit && _night + offset >= dayLimit)
                                {
                                    OrderInfo param = new OrderInfo();
                                    param.client_id = i;
                                    param.symbol = order.Symbol;
                                    param.lots = order.Lots;
                                    param.ticket = order.Ticket;
                                    param.order_type = order.Type;
                                    param.server_id = 0;
                                    param.request_type = RQ_TYPE.CLOSE;
                                    param.repeat_num = 0;
                                    param.open_price = order.OpenPrice;
                                    param.market_pending = MarketPending.MarketOrder;

                                    Thread thr1 = new Thread(close_R8_order);
                                    thr1.Start(param);
                                }
                            }
                        }
                    }

                    // R3
                    {
                        var qc = client.qcList[2 * i + 1];
                        var orders = qc.GetOpenedOrders();

                        foreach (var order in orders)
                        {
                            if (is_market_order(order))
                            {
                                int _night = client.count_nights_from_time(order.OpenTime, curTime);

                                if (_night <= dayLimit && _night + offset >= dayLimit)
                                {
                                    OrderInfo param = new OrderInfo();
                                    param.client_id = i;
                                    param.symbol = order.Symbol;
                                    param.lots = order.Lots;
                                    param.ticket = order.Ticket;
                                    param.order_type = order.Type;
                                    param.server_id = 1;
                                    param.request_type = RQ_TYPE.CLOSE;
                                    param.repeat_num = 0;
                                    param.open_price = order.OpenPrice;
                                    param.market_pending = MarketPending.MarketOrder;

                                    Thread thr1 = new Thread(close_R3_order);
                                    thr1.Start(param);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void reopen_old_orders_last_day()
        {
            var first_time = client.get_end_time(client.server_time.AddDays(-1));
            for (int i = 0; i < client.tot_client_num; i++)
            {
                if (client.check_connection_both_accounts(i))
                {
                    double sum;

                    // R8
                    {
                        var qc1 = client.qcList[2 * i];
                        var orders = qc1.GetOpenedOrders();
                        int symbol_id = client.get_symbol_id("EURUSD");

                        sum = 0;
                        foreach(var order in orders)
                        {
                            if (is_market_order(order)) sum += order.Lots;
                        }

                        ReopenOrderInfo param1 = new ReopenOrderInfo();
                        param1.symbol_id = symbol_id;
                        param1.lots = sum;
                        param1.client_id = i;

                        Thread thr1 = new Thread(reopen_R8_order_async);
                        thr1.IsBackground = true;
                        thr1.Start(param1);
                    }

                    // R3
                    {
                        var qc1 = client.qcList[2 * i + 1];
                        var orders = qc1.GetOpenedOrders();
                        int symbol_id = client.get_symbol_id("EURUSD");

                        sum = 0;
                        foreach (var order in orders)
                        {
                            if (is_market_order(order)) sum += order.Lots;
                        }

                        ReopenOrderInfo param2 = new ReopenOrderInfo();
                        param2.symbol_id = symbol_id;
                        param2.lots = sum;
                        param2.client_id = i;

                        Thread thr2 = new Thread(reopen_R3_order_async);
                        thr2.IsBackground = true;
                        thr2.Start(param2);

                    }
                }
            }
        }

        public string get_ask_price(int server_flag) //R8:0, R3:1
        {
            if(server_flag == 0)
            {
                return R8_ask[tradingdesk_symbol_id].ToString(get_digit_string());
            }
            else
            {
                return R3_ask[tradingdesk_symbol_id].ToString(get_digit_string());
            }
        }

        public string get_price_difference_string()
        {
            double val = Math.Abs(R3_ask[tradingdesk_symbol_id] - R8_ask[tradingdesk_symbol_id]);
            return val.ToString(get_digit_string());
        }

        public double get_price_difference_max_point()
        {
            double result = 0;
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    double val = Math.Abs(R3_ask[i] - R8_ask[i]);
                    val /= Settings.SymbolsPoint[i];
                    result = Math.Max(result, val);
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get price difference max point failed: " + ex.ToString());
            }
            return result;
        }

        private void check_reopen_orders(int req_id, int ticket, string symbol)
        {
            try
            {
                int len = processing_order_list.Count;
                for (int i = 0; i < len; i++)
                {
                    if (processing_order_list[i].request_id == req_id)
                    {
                        OrderInfo param1 = processing_order_list[i];

                        OrderInfo param = new OrderInfo()
                        {
                            client_id = param1.client_id,
                            lots = param1.lots,
                            order_type = param1.order_type,
                            request_id = param1.request_id,
                            server_id = param1.server_id,
                            repeat_num = 0,
                            request_type = param1.request_type,
                            symbol_id = param1.symbol_id,
                        };

                        if(param.request_type == RQ_TYPE.REOPEN)
                        {
                            param.ticket = ticket;
                            param.request_type = RQ_TYPE.CLOSE;
                            param.repeat_num = 0;
                            param.symbol = symbol;

                            if(param.server_id == 0)
                            {
                                Thread.Sleep(35000);

                                Thread thr1 = new Thread(close_R8_order);
                                thr1.IsBackground = true;
                                thr1.Start(param);
                            }
                            else
                            {
                                Thread.Sleep(35000);

                                Thread thr1 = new Thread(close_R3_order);
                                thr1.IsBackground = true;
                                thr1.Start(param);
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Resend request failed: " + ex.ToString());
            }
        }

        void oc_OnOrderProgress(object sender, OrderProgressEventArgs args)
        {
            try
            {
                if (args.Exception == null)
                {
                    Settings.Log.Info("Request Id = " + args.TempID + ": success " + args.Order.Symbol);
                    play_sound();

                    if(args.Type == ProgressType.Opened) //check reopen orders
                    {
                        check_reopen_orders(args.TempID, args.Order.Ticket, args.Order.Symbol);
                    }
                }
                else
                {
                    resend_request(args.TempID);
                    Settings.Log.Error("Request Id = " + args.TempID + ": failed " + args.Exception.Message);
                }
                delete_processing_order_info(args.TempID);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("On Order Process failed: " + ex.ToString());
            }
        }

        private void play_sound()
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ok.wav");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
                player.Play();
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Play sound failed: " + ex.ToString());
            }
        }

        void resend_request(int req_id)
        {
            try
            {
                Thread.Sleep(200);

                int len = processing_order_list.Count;
                for (int i = 0; i < len; i++)
                {
                    if (processing_order_list[i].request_id == req_id)
                    {
                        OrderInfo param = processing_order_list[i];

                        if (param.repeat_num > Settings.max_order_try_num || param.request_type == RQ_TYPE.MODIFY) 
                        {
                            if(param.request_type == RQ_TYPE.CLOSE)
                            {
                                client.remove_dict_close_pending(param.ticket);
                            }
                            
                            break;
                        }
                        param.repeat_num++;

                        Settings.Log.Info($"Trying to resend order: Symbol={param.symbol} Lots={param.lots} Type={param.order_type}");

                        Thread thr;
                        if (param.request_type == RQ_TYPE.OPEN || param.request_type == RQ_TYPE.REOPEN)
                        {
                            if (param.server_id == 0)
                                thr = new Thread(open_R8_order);
                            else
                                thr = new Thread(open_R3_order);
                        }
                        else if(param.request_type == RQ_TYPE.MODIFY)
                        {
                            thr = new Thread(modify_R3_pending_order);
                        }
                        else
                        {
                            if (param.server_id == 0)
                                thr = new Thread(close_R8_order);
                            else
                                thr = new Thread(close_R3_order);
                        }
                        thr.IsBackground = true;
                        thr.Start(param);

                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Resend request failed: " + ex.ToString());
            }
        }

        public bool is_market_order(Order order)
        {
            if (order.Type == Op.Buy || order.Type == Op.Sell) return true;
            return false;
        }

        public void reopen_R3_order_async(object reopen_param)
        {
            int client_id = ((ReopenOrderInfo)reopen_param).client_id;
            int symbol_id = ((ReopenOrderInfo)reopen_param).symbol_id;
            double lots = ((ReopenOrderInfo)reopen_param).lots;

            if (license_state <= 0) return;
            if (client.tot_client_num == 0) return;
            if (lots == 0) return;
            if (!client.check_connection_both_accounts(client_id)) return;

            int div_num = 10;

            double div_lots = lots / div_num;
            div_lots = ((int)(div_lots * 100)) / 100.0;
            if (div_lots < 0.01) div_lots = 0.01;
            double prev_sum = 0;
            double cur_lots;

            for(int i = 0; i < div_num; i++)
            {
                if(i == div_num - 1)
                {
                    cur_lots = lots - prev_sum;
                }
                else
                {
                    cur_lots = div_lots;
                    if (prev_sum + cur_lots > lots) cur_lots = lots - prev_sum;
                    prev_sum += cur_lots;
                }

                if (cur_lots <= 0) continue;

                OrderInfo param = new OrderInfo();
                param.client_id = client_id;
                param.symbol_id = symbol_id;
                param.lots = cur_lots;
                param.request_type = RQ_TYPE.REOPEN;
                param.server_id = 1;
                param.repeat_num = 0;

                Thread thr = new Thread(open_R3_order);
                thr.IsBackground = true;
                thr.Start(param);

                Thread.Sleep(50000);
            }
        }

        public void reopen_R8_order_async(object reopen_param)
        {
            int client_id = ((ReopenOrderInfo)reopen_param).client_id;
            int symbol_id = ((ReopenOrderInfo)reopen_param).symbol_id;
            double lots = ((ReopenOrderInfo)reopen_param).lots;

            if (license_state <= 0) return;
            if (client.tot_client_num == 0) return;
            if (lots == 0) return;
            if (!client.check_connection_both_accounts(client_id)) return;

            int div_num = 10;

            double div_lots = lots / div_num;
            div_lots = ((int)(div_lots * 100)) / 100.0;
            if (div_lots < 0.01) div_lots = 0.01;
            double prev_sum = 0;
            double cur_lots;

            for (int i = 0; i < div_num; i++)
            {
                if (i == div_num - 1)
                {
                    cur_lots = lots - prev_sum;
                }
                else
                {
                    cur_lots = div_lots;
                    if (prev_sum + cur_lots > lots) cur_lots = lots - prev_sum;
                    prev_sum += cur_lots;
                }

                if (cur_lots <= 0) continue;

                OrderInfo param = new OrderInfo();
                param.client_id = client_id;
                param.symbol_id = symbol_id;
                param.lots = cur_lots;
                param.request_type = RQ_TYPE.REOPEN;
                param.server_id = 0;
                param.repeat_num = 0;

                Thread thr = new Thread(open_R8_order);
                thr.IsBackground = true;
                thr.Start(param);

                Thread.Sleep(50000);
            }
        }

        public void open_R3_order_async(int symbol_id, double lots, MarketPending market_pending, double open_price, int client_id = -1)
        {
            Settings.Log.Debug("R3 order open!!!");
            if (license_state <= 0) return;

            if (client_id < 0) client_id = client.current_client_id;
            if (client.tot_client_num == 0)
            {
                Settings.Log.Error("R3 Open Order Error: There is no client");
                return;
            }

            if (lots == 0)
            {
                Settings.Log.Error("R3 Open Order Error: Lots = 0");
                return;
            }

            if (!client.check_connection_both_accounts(client_id))
            {
                Settings.Log.Error("R3 Open Order Error: account is disconnected");
                return;
            }

            if (market_pending == MarketPending.PendingOrder && open_price <= 0)
            {
                Settings.Log.Error("R3 Pending Order Error: open price is not valid");
                //MessageBox.Show("Pending order entry price is not valid!");
                return;
            }

            OrderInfo param = new OrderInfo();
            param.client_id = client_id;
            param.symbol_id = symbol_id;
            param.lots = lots;
            param.request_type = RQ_TYPE.OPEN;
            param.server_id = 1;
            param.repeat_num = 0;
            param.market_pending = market_pending;
            param.open_price = open_price;

            Thread thr = new Thread(open_R3_order);
            thr.IsBackground = true;
            thr.Start(param);
            Settings.Log.Debug("R3 order create!!!");
        }

        public void open_R3_order(object param)
        {
            int symbol_id = ((OrderInfo)param).symbol_id;
            int client_id = ((OrderInfo)param).client_id;
            double lots = ((OrderInfo)param).lots;
            MarketPending market_pending = ((OrderInfo)param).market_pending;
            double open_price = ((OrderInfo)param).open_price;

            //if (!client.check_hedge(client_id, 1))
            //    return;

            try
            {
                QuoteClient qc2 = client.qcList[client_id * 2 + 1];
                OrderClient oc2 = client.ocList[client_id * 2 + 1];
                string current_symbol = Settings.SymbolsToSubscribe[symbol_id];
                
                if (!qc2.Symbols.Contains(current_symbol))
                    return;

                Op _op;
                double price;

                if (!get_quote_wait(qc2, current_symbol))
                {
                    Settings.Log.Error("R3 Order Error: Client name = " + client.nameList[client_id] + " Symbol = " + Settings.SymbolsToSubscribe[symbol_id]);
                    return;
                }

                if (Settings.SymbolSellAccount[symbol_id] == 0)
                {
                    if (market_pending == MarketPending.MarketOrder)
                    {
                        _op = Op.Buy;
                        price = qc2.GetQuote(current_symbol).Ask;
                    }
                    else
                    {
                        price = open_price;
                        if (open_price > qc2.GetQuote(current_symbol).Ask)
                        {
                            _op = Op.BuyStop;
                        }
                        else
                        {
                            _op = Op.BuyLimit;
                        }
                    }
                }
                else
                {
                    if (market_pending == MarketPending.MarketOrder)
                    {
                        _op = Op.Sell;
                        price = qc2.GetQuote(current_symbol).Bid;
                    }
                    else
                    {
                        price = open_price;
                        if (open_price > qc2.GetQuote(current_symbol).Bid)
                        {
                            _op = Op.SellLimit;
                        }
                        else
                        {
                            _op = Op.SellStop;
                        }
                    }
                }

                int req_id = oc2.OrderSendAsync(current_symbol, _op, lots, price, 10000, 0, 0, "", 0, new DateTime());

                ((OrderInfo)param).request_id = req_id;
                processing_order_list.Add((OrderInfo)param); 

                log_order_info((OrderInfo)param);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("R3 Order Error: Client name = " + client.nameList[client_id] + " Symbol = " +
                    Settings.SymbolsToSubscribe[symbol_id] + ": " + ex.ToString());
            }
        }

        public void open_R8_order_after_pending(int client_id, Order order)
        {
            if (license_state <= 0) return;
            
            if (client.tot_client_num == 0)
            {
                Settings.Log.Error("R8 Open Order Error: There is no client");
                return;
            }

            int symbol_id = client.get_symbol_id(client.remove_suffix(order.Symbol));

            OrderInfo param = new OrderInfo();
            param.client_id = client_id;
            param.symbol_id = symbol_id;
            param.lots = order.Lots;
            param.request_type = RQ_TYPE.OPEN;
            param.server_id = 0;
            param.repeat_num = 0;
            param.market_pending = MarketPending.MarketOrder;
            param.open_price = 0;

            Thread thr = new Thread(open_R8_order);
            thr.IsBackground = true;
            thr.Start(param);
        }


        public void open_R8_order_async(int symbol_id, double lots, MarketPending market_pending, double open_price, int client_id = -1)
        {
            if (license_state <= 0) return;

            if (client_id < 0) client_id = client.current_client_id;
            if (client.tot_client_num == 0)
            {
                Settings.Log.Error("R8 Open Order Error: There is no client");
                return;
            }

            if(lots == 0)
            {
                Settings.Log.Error("R8 Open Order Error: Lots = 0");
                return;
            }

            if(!client.check_connection_both_accounts(client_id))
            {
                Settings.Log.Error("R8 Open Order Error: account is disconnected");
                return;
            }

            if(market_pending == MarketPending.PendingOrder &&  open_price < 0)
            {
                Settings.Log.Error("R8 Pending Order Error: open price is not valid");
                //MessageBox.Show("Pending order entry price is not valid!");
                return;
            }

            OrderInfo param = new OrderInfo();
            param.client_id = client_id;
            param.symbol_id = symbol_id;
            param.lots = lots;
            param.request_type = RQ_TYPE.OPEN;
            param.server_id = 0;
            param.repeat_num = 0;
            param.market_pending = market_pending;
            param.open_price = open_price;

            Thread thr = new Thread(open_R8_order);
            thr.IsBackground = true;
            thr.Start(param);
        }

        public void open_R8_order(object param)
        {
            int symbol_id = ((OrderInfo)param).symbol_id;
            int client_id = ((OrderInfo)param).client_id;
            double lots = ((OrderInfo)param).lots;
            MarketPending market_pending = ((OrderInfo)param).market_pending;
            double open_price = ((OrderInfo)param).open_price;

            //if (!client.check_hedge(client_id, 0))
            //    return;

            try
            {
                QuoteClient qc1 = client.qcList[client_id * 2];
                OrderClient oc1 = client.ocList[client_id * 2];

                string current_symbol = Settings.SymbolsToSubscribe[symbol_id];
                if (current_symbol == "XTIUSD") current_symbol = "USOilCash";
                if (current_symbol == "XBRUSD") current_symbol = "UKOilCash";

                if (!qc1.Symbols.Contains(current_symbol))
                    return;

                Op _op;
                double price;

                if(!get_quote_wait(qc1, current_symbol))
                {
                    Settings.Log.Error("R8 Order Error: Client name = " + client.nameList[client_id] + " Symbol = " +
                    Settings.SymbolsToSubscribe[symbol_id]);
                    return;
                }

                if (Settings.SymbolSellAccount[symbol_id] == 1)
                {
                    if(market_pending == MarketPending.MarketOrder)
                    {
                        _op = Op.Buy;
                        price = qc1.GetQuote(current_symbol).Ask;
                    }
                    else
                    {
                        price = open_price;
                        if(open_price > qc1.GetQuote(current_symbol).Ask)
                        {
                            _op = Op.BuyStop;
                        }
                        else
                        {
                            _op = Op.BuyLimit;
                        }
                    }
                }
                else
                {
                    if(market_pending == MarketPending.MarketOrder)
                    {
                        _op = Op.Sell;
                        price = qc1.GetQuote(current_symbol).Bid;
                    }
                    else
                    {
                        price = open_price;
                        if(open_price > qc1.GetQuote(current_symbol).Bid)
                        {
                            _op = Op.SellLimit;
                        }
                        else
                        {
                            _op = Op.SellStop;
                        }
                    }
                }

                int req_id = oc1.OrderSendAsync(current_symbol, _op, lots, price, 10000, 0, 0, "", 0, new DateTime());

                ((OrderInfo)param).request_id = req_id;
                processing_order_list.Add((OrderInfo)param);
                Settings.Log.Debug("R8 order created");
                
                log_order_info((OrderInfo)param);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("R8 Order Error: Client name = " + client.nameList[client_id] + " Symbol = " +
                    Settings.SymbolsToSubscribe[symbol_id] + ": " + ex.ToString());
            }
        }

        void log_order_info(OrderInfo info)
        {
            string typeStr = "Open";
            if (info.request_type == RQ_TYPE.CLOSE) typeStr = "Close";
            if (info.request_type == RQ_TYPE.MODIFY) typeStr = "Modify";

            string symbolStr;
            symbolStr = Settings.SymbolsToSubscribe[info.symbol_id];

            Settings.Log.Info("Request Id = " + info.request_id + " " + client.nameList[info.client_id] +  " " + typeStr + " " + symbolStr + " " + info.lots.ToString() + "Lot");
        }

        private double get_close_price(QuoteClient qc, string symbol, Op type)
        {
            try
            {
                if (!get_quote_wait(qc, symbol)) return 0;

                if (type == Op.Buy) return qc.GetQuote(symbol).Bid;
                else return qc.GetQuote(symbol).Ask;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("get close price failed: " + ex.ToString());
                return 0;
            }
        }

        private bool get_quote_wait(QuoteClient qc, string symbol)
        {
            int count = 0;
            while(qc.GetQuote(symbol) == null && count < 100)
            {
                Thread.Sleep(10);
                count++;
            }
            if (count >= 100)
                return false;

            return true;
        }

        public double get_master_free_margin()
        {
            QuoteClient qc1 = client.qcList[2 * client.master_client_id];
            QuoteClient qc2 = client.qcList[2 * client.master_client_id + 1];

            double margin1 = qc1.AccountFreeMargin;
            double margin2 = qc2.AccountFreeMargin;

            return Math.Min(margin1, margin2);
        }

        public double get_new_lots(int client_id, double lots, double master_margin)
        {
            QuoteClient qc1 = client.qcList[2 * client_id];
            QuoteClient qc2 = client.qcList[2 * client_id + 1];

            double margin1 = qc1.AccountFreeMargin;
            double margin2 = qc2.AccountFreeMargin;

            margin1 = Math.Min(margin1, margin2);

            double newLots = lots * margin1 / master_margin;
            newLots = ((int)(newLots * 100 + 0.5)) / 100.0;

            return newLots;
        }

        public void close_unmatched_orders_for_margin_call(int client_id, List<int> close_order_ticket1, List<int> close_order_ticket2)
        {
            try
            {
                if (license_state <= 0) return;

                if (client.tot_client_num == 0) return;
                if (!client.check_connection_both_accounts(client_id))
                {
                    Settings.Log.Error("Close Order Error: account is disconnected");
                    return;
                }

                //Real 8
                QuoteClient qc = client.qcList[client_id * 2];
                OrderClient oc = client.ocList[client_id * 2];
                var orders = qc.GetOpenedOrders();
                int length = orders.Length;

                for(int i = 0; i < length; i++)
                {
                    var order = orders[i];

                    if(close_order_ticket1.Contains(order.Ticket))
                    {
                        OrderInfo param = new OrderInfo();
                        param.client_id = client_id;
                        param.symbol = order.Symbol;
                        param.lots = order.Lots;
                        param.ticket = order.Ticket;
                        param.order_type = order.Type;
                        param.server_id = 0;
                        param.request_type = RQ_TYPE.CLOSE;
                        param.repeat_num = 0;
                        param.open_price = order.OpenPrice;

                        if (is_market_order(order)) param.market_pending = MarketPending.MarketOrder;
                        else param.market_pending = MarketPending.PendingOrder;

                        Thread thr1 = new Thread(close_R8_order);
                        thr1.IsBackground = true;
                        thr1.Start(param);

                        Thread.Sleep(100);
                    }
                }

                //Real 3
                qc = client.qcList[client_id * 2 + 1];
                oc = client.ocList[client_id * 2 + 1];
                orders = qc.GetOpenedOrders();
                length = orders.Length;

                for (int i = 0; i < length; i++)
                {
                    var order = orders[i];

                    if (close_order_ticket2.Contains(order.Ticket))
                    {
                        OrderInfo param = new OrderInfo();
                        param.client_id = client_id;
                        param.symbol = order.Symbol;
                        param.lots = order.Lots;
                        param.ticket = order.Ticket;
                        param.order_type = order.Type;
                        param.server_id = 0;
                        param.request_type = RQ_TYPE.CLOSE;
                        param.repeat_num = 0;
                        param.open_price = order.OpenPrice;

                        if (is_market_order(order)) param.market_pending = MarketPending.MarketOrder;
                        else param.market_pending = MarketPending.PendingOrder;

                        Thread thr1 = new Thread(close_R3_order);
                        thr1.IsBackground = true;
                        thr1.Start(param);

                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to close unmatched orders for margin call: " + ex.ToString());
            }
        }

        public void close_all_hedge_orders(int client_id, List<int> R83_orderList)
        {
            if (license_state <= 0) return;

            if (client.tot_client_num == 0) return;
            if (!client.check_connection_both_accounts(client_id))
            {
                Settings.Log.Error("Close Order Error: account is disconnected");
                return;
            }

            try
            {
                int tot_num = R83_orderList.Count / 2;

                //Real 8
                QuoteClient qc1 = client.qcList[client_id * 2];
                OrderClient oc1 = client.ocList[client_id * 2];
                var orders1 = qc1.GetOpenedOrders();
                int length1 = orders1.Length;

                //Real 3
                QuoteClient qc2 = client.qcList[client_id * 2 + 1];
                OrderClient oc2 = client.ocList[client_id * 2 + 1];
                var orders2 = qc2.GetOpenedOrders();
                int length2 = orders2.Length;

                int order_id1, order_id2;

                for(int i = 0; i < tot_num; i++)
                {
                    order_id1 = R83_orderList[2 * i];
                    order_id2 = R83_orderList[2 * i + 1];

                    if (order_id1 >= 0 && order_id1 < length1) //close one order
                    {
                        var order = orders1[order_id1];

                        OrderInfo param = new OrderInfo();
                        param.client_id = client_id;
                        param.symbol = order.Symbol;
                        param.lots = order.Lots;
                        param.ticket = order.Ticket;
                        param.order_type = order.Type;
                        param.server_id = 0;
                        param.request_type = RQ_TYPE.CLOSE;
                        param.repeat_num = 0;
                        param.open_price = order.OpenPrice;

                        if(is_market_order(order)) param.market_pending = MarketPending.MarketOrder;
                        else param.market_pending = MarketPending.PendingOrder;

                        Thread thr1 = new Thread(close_R8_order);
                        thr1.IsBackground = true;
                        thr1.Start(param);
                    }

                    if (order_id2 >= 0 && order_id2 < length2) //close one order
                    {
                        var order = orders2[order_id2];

                        OrderInfo param = new OrderInfo();
                        param.client_id = client_id;
                        param.symbol = order.Symbol;
                        param.lots = order.Lots;
                        param.ticket = order.Ticket;
                        param.order_type = order.Type;
                        param.server_id = 1;
                        param.request_type = RQ_TYPE.CLOSE;
                        param.repeat_num = 0;
                        param.open_price = order.OpenPrice;

                        if (is_market_order(order)) param.market_pending = MarketPending.MarketOrder;
                        else param.market_pending = MarketPending.PendingOrder;

                        Thread thr2 = new Thread(close_R3_order);
                        thr2.IsBackground = true;
                        thr2.Start(param);
                    }
                }

            }
            catch (Exception ex)
            {
                Settings.Log.Error("Close hedge orders error: " + ex.ToString());
            }
        }

        public void delete_one_pending_order(int ticket)
        {
            if (ticket < 0) return;
            if (license_state <= 0) return;
            if (client.tot_client_num == 0) return;
            int client_id = client.current_client_id;

            if (!client.check_connection_both_accounts(client_id))
            {
                Settings.Log.Error("Close Order Error: account is disconnected");
                return;
            }

            try
            {
                //Real 3
                QuoteClient qc2 = client.qcList[client_id * 2 + 1];
                OrderClient oc2 = client.ocList[client_id * 2 + 1];

                var orders = qc2.GetOpenedOrders();

                foreach(var order in orders)
                {
                    if (order.Ticket != ticket) continue;

                    OrderInfo param = new OrderInfo();
                    param.client_id = client_id;
                    param.symbol = order.Symbol;
                    param.lots = order.Lots;
                    param.ticket = order.Ticket;
                    param.order_type = order.Type;
                    param.server_id = 1;
                    param.request_type = RQ_TYPE.CLOSE;
                    param.repeat_num = 0;
                    param.open_price = order.OpenPrice;
                    param.market_pending = MarketPending.PendingOrder;

                    Thread thr = new Thread(close_R3_order);
                    thr.IsBackground = true;
                    thr.Start(param);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Close one pending order failed: " + ex.ToString());
            }
        }

        public void close_hedge_orders(int client_id, int order_id1, int order_id2)
        {
            if (license_state <= 0) return;
            if (client.tot_client_num == 0) return;

            if (client_id < 0) client_id = client.current_client_id;
            if (!client.check_connection_both_accounts(client_id))
            {
                Settings.Log.Error("Close Order Error: account is disconnected");
                return;
            }

            try
            {
                //Real 8
                QuoteClient qc1 = client.qcList[client_id * 2];
                OrderClient oc1 = client.ocList[client_id * 2];

                var orders = qc1.GetOpenedOrders();
                int length = orders.Length;

                if (order_id1 >= 0 && order_id1 < length) //close one order
                {
                    var order = orders[order_id1];

                    OrderInfo param = new OrderInfo();
                    param.client_id = client_id;
                    param.symbol = order.Symbol;
                    param.lots = order.Lots;
                    param.ticket = order.Ticket;
                    param.order_type = order.Type;
                    param.server_id = 0;
                    param.request_type = RQ_TYPE.CLOSE;
                    param.repeat_num = 0;
                    param.open_price = order.OpenPrice;
                    
                    if (is_market_order(order)) param.market_pending = MarketPending.MarketOrder;
                    else param.market_pending = MarketPending.PendingOrder;

                    Thread thr1 = new Thread(close_R8_order);
                    thr1.IsBackground = true;
                    thr1.Start(param);
                }

                //Real 3
                QuoteClient qc2 = client.qcList[client_id * 2 + 1];
                OrderClient oc2 = client.ocList[client_id * 2 + 1];

                orders = qc2.GetOpenedOrders();
                length = orders.Length;

                if (order_id2 >= 0 && order_id2 < length) //close one order
                {
                    var order = orders[order_id2];

                    OrderInfo param = new OrderInfo();
                    param.client_id = client_id;
                    param.symbol = order.Symbol;
                    param.lots = order.Lots;
                    param.ticket = order.Ticket;
                    param.order_type = order.Type;
                    param.server_id = 1;
                    param.request_type = RQ_TYPE.CLOSE;
                    param.repeat_num = 0;
                    param.open_price = order.OpenPrice;

                    if (is_market_order(order)) param.market_pending = MarketPending.MarketOrder;
                    else param.market_pending = MarketPending.PendingOrder;

                    Thread thr2 = new Thread(close_R3_order);
                    thr2.IsBackground = true;
                    thr2.Start(param);
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Close hedge orders error: " + ex.ToString());
            }
        }

        private void close_R8_order(object param)
        {
            int client_id = ((OrderInfo)param).client_id;
            string symbol = ((OrderInfo)param).symbol;
            int ticket = ((OrderInfo)param).ticket;
            double lots = ((OrderInfo)param).lots;
            Op order_type = ((OrderInfo)param).order_type;
            double open_price = ((OrderInfo)param).open_price;
            MarketPending market_pending = ((OrderInfo)param).market_pending;

            //if (!client.check_hedge(client_id, 0))
            //    return;

            try
            {
                QuoteClient qc1 = client.qcList[client_id * 2];
                OrderClient oc1 = client.ocList[client_id * 2];

                if(market_pending == MarketPending.MarketOrder)
                {
                    double price = get_close_price(qc1, symbol, order_type);
                    if (price > 0)
                    {
                        int req_id = oc1.OrderCloseAsync(symbol, ticket, lots, price, 10000);

                        ((OrderInfo)param).request_id = req_id;
                        processing_order_list.Add((OrderInfo)param);
                        log_order_info((OrderInfo)param);
                        client.add_dict_close_pending(ticket);
                    }
                }
                else
                {
                    int req_id = oc1.OrderDeleteAsync(ticket, order_type, symbol, lots, open_price);

                    ((OrderInfo)param).request_id = req_id;
                    processing_order_list.Add((OrderInfo)param);
                    log_order_info((OrderInfo)param);
                    client.add_dict_close_pending(ticket);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Close R8 Order Error: Client name = " + client.nameList[client_id] + "\n" + ex.ToString());
            }
        }

        private void close_R3_order(object param)
        {
            int client_id = ((OrderInfo)param).client_id;
            string symbol = ((OrderInfo)param).symbol;
            int ticket = ((OrderInfo)param).ticket;
            double lots = ((OrderInfo)param).lots;
            Op order_type = ((OrderInfo)param).order_type;
            double open_price = ((OrderInfo)param).open_price;
            MarketPending market_pending = ((OrderInfo)param).market_pending;

            //if (!client.check_hedge(client_id, 1))
            //    return;

            try
            {
                QuoteClient qc2 = client.qcList[client_id * 2 + 1];
                OrderClient oc2 = client.ocList[client_id * 2 + 1];

                if (market_pending == MarketPending.MarketOrder)
                {
                    double price = get_close_price(qc2, symbol, order_type);
                    if (price > 0)
                    {
                        int req_id = oc2.OrderCloseAsync(symbol, ticket, lots, price, 10000);

                        ((OrderInfo)param).request_id = req_id;
                        processing_order_list.Add((OrderInfo)param);
                        log_order_info((OrderInfo)param);

                        client.add_dict_close_pending(ticket);
                    }
                }
                else
                {
                    int req_id = oc2.OrderDeleteAsync(ticket, order_type, symbol, lots, open_price);

                    ((OrderInfo)param).request_id = req_id;
                    processing_order_list.Add((OrderInfo)param);
                    log_order_info((OrderInfo)param);
                    client.add_dict_close_pending(ticket);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Close R3 Order Error: Client name = " + client.nameList[client_id] + "\n" + ex.ToString());
            }
        }

        public void modify_R3_pending_order_async(int ticket, double modify_price)
        {
            if (ticket < 0) return;
            if (license_state <= 0) return;
            if (client.tot_client_num == 0) return;
            int client_id = client.current_client_id;

            if (!client.check_connection_both_accounts(client_id))
            {
                Settings.Log.Error("Close Order Error: account is disconnected");
                return;
            }

            try
            {
                //Real 3
                QuoteClient qc2 = client.qcList[client_id * 2 + 1];
                OrderClient oc2 = client.ocList[client_id * 2 + 1];

                var orders = qc2.GetOpenedOrders();

                foreach (var order in orders)
                {
                    if (order.Ticket != ticket) continue;

                    OrderInfo param = new OrderInfo();
                    param.client_id = client_id;
                    param.symbol = order.Symbol;
                    param.lots = order.Lots;
                    param.ticket = order.Ticket;
                    param.order_type = order.Type;
                    param.server_id = 1;
                    param.request_type = RQ_TYPE.MODIFY;
                    param.repeat_num = 0;
                    param.open_price = order.OpenPrice;
                    param.market_pending = MarketPending.PendingOrder;
                    param.modify_price = modify_price;

                    Thread thr = new Thread(modify_R3_pending_order);
                    thr.IsBackground = true;
                    thr.Start(param);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Close one pending order failed: " + ex.ToString());
            }
        }

        private void modify_R3_pending_order(object param)
        {
            int client_id = ((OrderInfo)param).client_id;
            string symbol = ((OrderInfo)param).symbol;
            int ticket = ((OrderInfo)param).ticket;
            double lots = ((OrderInfo)param).lots;
            Op order_type = ((OrderInfo)param).order_type;
            double open_price = ((OrderInfo)param).open_price;
            double modify_price = ((OrderInfo)param).modify_price;

            try
            {
                QuoteClient qc2 = client.qcList[client_id * 2 + 1];
                OrderClient oc2 = client.ocList[client_id * 2 + 1];

                int req_id = oc2.OrderModifyAsync(ticket, symbol, order_type, lots, modify_price, 0, 0, new DateTime());

                ((OrderInfo)param).request_id = req_id;
                processing_order_list.Add((OrderInfo)param);
                log_order_info((OrderInfo)param);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Modify R3 pending order error: Client name = " + client.nameList[client_id] + "\n" + ex.ToString());
            }
        }

        public void check_quote_history(bool new_panel)
        {
            try
            {
                if (current_tf == Timeframe.MN1) //set default tf into H1
                {
                    current_tf = Timeframe.H4;
                    request_quote_history();
                    return;
                }

                TimeSpan ts_R3 = R3_time[tradingdesk_symbol_id] - R3_historytime[0];
                TimeSpan ts_R8 = R8_time[tradingdesk_symbol_id] - R8_historytime[0];

                if (ts_R3.TotalMinutes >= (int)current_tf || ts_R8.TotalMinutes >= (int)current_tf)
                {
                    request_quote_history();
                }
                else
                {
                    if(draw_chart_handle_R3 != null)
                        draw_chart_handle_R3(this, EventArgs.Empty);

                    if(new_panel)
                    {
                        if (draw_chart_handle_R8 != null)
                            draw_chart_handle_R8(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Request quote history failed: " + ex.ToString());
            }
        }

        public void request_quote_history()
        {
            try
            {
                string symbol = Settings.SymbolsToSubscribe[tradingdesk_symbol_id];
                int tf = (int)current_tf;

                RemoveDifferentSymbol(symbol, tf);

                for(int client_id = 0; client_id < 2; client_id++)
                {
                    if (!ExistDownloadSymbol(client_id, symbol, tf, false))
                    {
                        // For Past candles
                        var info = new DownloadSymbolInfo();
                        info.client_id = client_id;
                        info.symbol = symbol;
                        info.tf = tf;
                        downloadRequestedSymbolList.Add(info);
                    }

                    if (!ExistDownloadSymbol(client_id, symbol, tf, true))
                    {
                        // For Current candle
                        var curInfo = new DownloadSymbolInfo();
                        curInfo.client_id = client_id;
                        curInfo.symbol = symbol;
                        curInfo.tf = tf;
                        curInfo.isCurrent = true;
                        downloadRequestedSymbolList.Add(curInfo);
                    }
                }
            }
            catch (Exception) { }
        }

        private DownloadSymbolInfo GetDownloadInfo()
        {
            // Download closed candle history first
            try
            {
                return downloadRequestedSymbolList[0];
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to get download symbol: " + ex.ToString());
            }

            return null;
        }

        public void DownloadQuoteHistory()
        {
            try
            {
                if (is_downloading_history) return;
                if (downloadRequestedSymbolList.Count == 0) return;

                var downloadInfo = GetDownloadInfo();
                if (downloadInfo == null)
                    return;

                int client_id = downloadInfo.client_id;
                string symbol = downloadInfo.symbol;
                int tf = downloadInfo.tf;
                bool isCurrent = downloadInfo.isCurrent;

                is_downloading_history = true;
                if (isCurrent) // Download only live candle
                {
                    //Settings.Log.Info($"Downloading {symbol} live candle: TF={tf} ClientID={client_id}");
                    RemoveSameDownloadSymbol(client_id, symbol, tf, true);

                    DownloadQuoteHistory(client_id, symbol, tf, 0);
                }
                else // Download closed history
                {
                    int candleNum = Settings.max_candle_num;
                    //Settings.Log.Info($"Downloading {symbol} history: TF={tf} ClientID={client_id}");

                    RemoveSameDownloadSymbol(client_id, symbol, tf, false);
                    DownloadQuoteHistory(client_id, symbol, tf, candleNum);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't download past ohlc data: " + ex.ToString());
                is_downloading_history = false;
            }
        }

        public void DownloadQuoteHistory(int client_id, string symbol, int tf, int candleNum)
        {
            try
            {
                QuoteClient qc = client.qcList[client.datafeed_client_id * 2 + client_id];
                refresh_server_time(qc);
                if (qc.ServerTime == DateTime.MinValue)
                    return;

                var timeframe = (Timeframe)tf;
                var start_time = qc.ServerTime.AddHours(1);

                qc.DownloadQuoteHistory(symbol, timeframe, start_time, (short)candleNum);
            }
            catch (Exception)
            {
                is_downloading_history = false;
            }
        }

        private void RemoveSameDownloadSymbol(int client_id, string symbol, int tf, bool is_current)
        {
            try
            {
                int count = downloadRequestedSymbolList.Count;
                for (int i = 0; i < count; i++)
                {
                    var info = downloadRequestedSymbolList[i];
                    if (info.client_id == client_id && info.symbol == symbol && info.tf == tf && info.isCurrent == is_current)
                    {
                        downloadRequestedSymbolList.RemoveAt(i);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to remove download symbol: " + ex.ToString());
            }
        }

        private void RemoveDifferentSymbol(string symbol, int tf)
        {
            try
            {
                int count = downloadRequestedSymbolList.Count;
                for(int i = count - 1; i >= 0; i--)
                {
                    var info = downloadRequestedSymbolList[i];
                    if (info.symbol != symbol || info.tf != tf)
                    {
                        downloadRequestedSymbolList.RemoveAt(i);
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to remove download symbol: " + ex.ToString());
            }
        }

        private bool ExistDownloadSymbol(int client_id, string symbol, int tf, bool is_current)
        {
            try
            {
                int count = downloadRequestedSymbolList.Count;
                for (int i = 0; i < count; i++)
                {
                    var info = downloadRequestedSymbolList[i];
                    if (info.client_id == client_id && info.symbol == symbol && info.tf == tf && info.isCurrent == is_current)
                        return true;
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Exist download symbol error: " + ex.ToString());
            }

            return false;
        }
    }

    public class DownloadSymbolInfo
    {
        public int client_id; //0, 1
        public string symbol;
        public int tf;
        public bool isCurrent;

        public DownloadSymbolInfo()
        {
            client_id = 0;
            symbol = "";
            tf = 1;
            isCurrent = false;
        }
    }

    public class LoginArgs : EventArgs
    {
        public bool isSuccess;
    }
}
