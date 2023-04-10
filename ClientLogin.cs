using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using MTClientAPI;

namespace FXFellowDashboard
{
    public class ClientLogin
    {
        private QuoteClient qc1, qc2;

        public List<QuoteClient> qcList;
        public List<OrderClient> ocList;
        public List<int> clientIdList;
        public List<string> nameList;
        public List<int> connectionList;
        public List<string> currencyList;
        public List<int> userIdList;
        public List<string> passwordList;
        public List<string> emailList;
        public List<string> emailPasswordList;
        public List<string> serverNameList;
        public List<int> serverIndexList;
        public List<int> swapfreeFlagList;
        public List<int> hedgeFlagList;
        public List<int> pammList;
        public List<int> moneyShiftFlagList;
        public List<int> moneyShiftLimitList;
        public List<double> marginAlertAmountList;
        public List<double> marginCallAmountList;
        public List<double> freePipAmountList;
        public List<string> phoneNumberList;
        public List<bool> marginAlertFlagList;
        public List<bool> marginCallFlagList;
        public List<int> isPendingList;
        public List<DateTime> lastPendingTime;
        public List<bool> freePipFlagList;
        public List<DateTime> freePipLastTime;
        public List<DateTime> marginAlertTime;
        public List<double> closedOrderSwapList;
        public List<double> closedOrderLotsList;
        public List<double> closedOrderReopenList;
        public Dictionary<int, Order[]> closedOrderDict;
        public Dictionary<string, double> openedOrderDifference;
        public Dictionary<string, DateTime> openOrderDifferenceTime;
        public Dictionary<int, bool> accountBestConnectionDict;
        public List<double> stopLevelList;

        public DateTime lastAutoLoginTime;

        public int tot_client_num;
        public int current_client_id;
        public int datafeed_client_id;
        public int master_client_id;
        public int balance_alert_client_id;

        public List<int> R8_orderList;
        public List<int> R3_orderList;
        public int tot_order_num_display;

        public Dictionary<int, double> dict_SLTP;
        public Dictionary<int, bool> dict_close_pending;

        public Headers orders_sort_item;
        public bool orders_sort_increased;

        public DateTime last_money_shift_time;

        public double EUR_ratio;
        public double CHF_ratio;

        public bool isExit;

        public DateTime server_time;

        public Dictionary<MarginCallInfo, DateTime> margin_call_dict;

        public void Init()
        {
            qcList = new List<QuoteClient>();
            ocList = new List<OrderClient>();
            clientIdList = new List<int>();
            nameList = new List<string>();
            connectionList = new List<int>();
            currencyList = new List<string>();
            userIdList = new List<int>();
            passwordList = new List<string>();
            emailList = new List<string>();
            emailPasswordList = new List<string>();
            serverNameList = new List<string>();
            serverIndexList = new List<int>();
            swapfreeFlagList = new List<int>();
            swapfreeFlagList = new List<int>();
            hedgeFlagList = new List<int>();
            pammList = new List<int>();
            moneyShiftFlagList = new List<int>();
            moneyShiftLimitList = new List<int>();
            marginAlertAmountList = new List<double>();
            marginCallAmountList = new List<double>();
            isPendingList = new List<int>();
            lastPendingTime = new List<DateTime>();
            marginAlertFlagList = new List<bool>();
            marginCallFlagList = new List<bool>();
            freePipAmountList = new List<double>();
            phoneNumberList = new List<string>();
            R8_orderList = new List<int>();
            R3_orderList = new List<int>();
            freePipFlagList = new List<bool>();
            freePipLastTime = new List<DateTime>();
            marginAlertTime = new List<DateTime>();
            closedOrderLotsList = new List<double>();
            closedOrderSwapList = new List<double>();
            closedOrderReopenList = new List<double>();
            closedOrderDict = new Dictionary<int, Order[]>();
            openedOrderDifference = new Dictionary<string, double>();
            openOrderDifferenceTime = new Dictionary<string, DateTime>();
            accountBestConnectionDict = new Dictionary<int, bool>();

            stopLevelList = new List<double>();

            dict_SLTP = new Dictionary<int, double>();
            dict_close_pending = new Dictionary<int, bool>();

            balance_alert_client_id = -1;
            current_client_id = 0;
            master_client_id = 0;
            datafeed_client_id = -1;

            tot_client_num = 0;
            tot_order_num_display = 0;

            orders_sort_item = Headers.Account;
            orders_sort_increased = true;

            last_money_shift_time = DateTime.MinValue;
            lastAutoLoginTime = DateTime.Now;

            EUR_ratio = 1.1;
            CHF_ratio = 1.02;

            isExit = false;

            server_time = DateTime.MinValue;

            margin_call_dict = new Dictionary<MarginCallInfo, DateTime>();
        }

        // Remove elements older than 30 seconds
        public void RefreshMarginCallDict()
        {
            try
            {
                var delete_list = new List<MarginCallInfo>();
                foreach(var item in margin_call_dict)
                {
                    if(item.Value < DateTime.Now.AddSeconds(-10))
                    {
                        delete_list.Add(item.Key);
                    }
                }

                foreach(var info in delete_list)
                {
                    foreach(var item in margin_call_dict)
                    {
                        if(info.SameInfo(item.Key))
                        {
                            margin_call_dict.Remove(item.Key);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Failed to refresh margin call dict: " + ex.ToString());
            }
        }

        public bool ExistInMarginCallDict(MarginCallInfo info)
        {
            try
            {
                foreach(var item in margin_call_dict)
                {
                    if (info.SameInfo(item.Key))
                        return true;
                }
            }
            catch (Exception) { }

            return false;
        }

        public void AddMarginCallDict(MarginCallInfo info)
        {
            try
            {
                margin_call_dict.Add(info, DateTime.Now);
            }
            catch (Exception) { }
        }

        public void save_commission()
        {
            if (server_time == DateTime.MinValue)
                return;

            try
            {
                string res_str = "";

                for (int i = 0; i < tot_client_num; i++)
                {
                    res_str += nameList[i] + "(" + userIdList[2 * i].ToString() + "," + userIdList[2 * i + 1].ToString() + ")\n";
                    double lots_sum = 0;

                    for (int k = 0; k < 2; k++)
                    {
                        var orders = closedOrderDict[userIdList[2 * i + k]];
                        var sorted_orders = orders.OrderBy(o => o.CloseTime).ToList();
                        foreach (var order in sorted_orders)
                        {
                            if (is_market_order(order))
                            {
                                if (order.CloseTime.Month == server_time.Month && order.CloseTime.Year == server_time.Year)
                                {
                                    string order_symbol = order.Symbol;
                                    if (order_symbol.Length == 6) order_symbol += " ";

                                    res_str += order_symbol + " " + order.Type.ToString() + " " + order.Lots.ToString("0.00") + " Lots " +
                                        order.OpenTime.ToString("MM/dd/yyyy HH:mm:ss") + "-" + order.CloseTime.ToString("MM/dd/yyyy HH:mm:ss") + "\n";
                                    lots_sum += order.Lots;
                                }
                            }
                        }
                    }
                    res_str += "Total: " + lots_sum.ToString("0.00") + " Lots\n\n";
                }

                string dir_name = "Commission";
                if (!Directory.Exists(dir_name))
                {
                    Directory.CreateDirectory(dir_name);
                }

                string file_path = dir_name + "\\Commission_" + server_time.ToString("MM.dd.yyyy") + ".txt";
                File.WriteAllText(file_path, res_str);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Save commission failed: " + ex.ToString());
            }

        }

        public void save_account_best_connection(int userId)
        {
            bool val = false;
            if(!accountBestConnectionDict.TryGetValue(userId, out val))
            {
                accountBestConnectionDict.Add(userId, true);
            }
        }

        public void update_orders_SLTP(int order_id, OrderSLTPArgs arg)
        {
            QuoteClient qc1 = qcList[2 * current_client_id];
            QuoteClient qc2 = qcList[2 * current_client_id + 1];

            int orderId1 = R8_orderList[order_id];
            int orderId2 = R3_orderList[order_id];

            var orders1 = qc1.GetOpenedOrders();
            var orders2 = qc2.GetOpenedOrders();

            int ticket;
            double SLTP;

            if (orderId1 >= 0 && orderId1 < orders1.Length) 
            {
                if (!is_market_order(orders1[orderId1])) return;
                ticket = orders1[orderId1].Ticket;
                if(dict_SLTP.TryGetValue(ticket, out SLTP))
                {
                    if (arg.SLTP1 != 0)
                        dict_SLTP[ticket] = arg.SLTP1;
                    else
                        dict_SLTP.Remove(ticket);
                }
                else if(arg.SLTP1 != 0)
                {
                    dict_SLTP.Add(ticket, arg.SLTP1);
                }
            }

            if (orderId2 >= 0 && orderId2 < orders2.Length)
            {
                if (!is_market_order(orders2[orderId2])) return;
                ticket = orders2[orderId2].Ticket;
                if (dict_SLTP.TryGetValue(ticket, out SLTP))
                {
                    if (arg.SLTP2 != 0)
                        dict_SLTP[ticket] = arg.SLTP2;
                    else
                        dict_SLTP.Remove(ticket);
                }
                else if (arg.SLTP2 != 0)
                {
                    dict_SLTP.Add(ticket, arg.SLTP2);
                }
            }
        }

        public void update_EUR_CHF_ratio(double eur_bid, double chf_ask)
        {
            if (eur_bid > 0)
                EUR_ratio = eur_bid;
            if (chf_ask > 0)
                CHF_ratio = 1 / chf_ask;
        }

        public bool check_connection_both_accounts(int client_id, bool check_master = true)
        {
            if (client_id < 0 || client_id >= tot_client_num) return false;

            if(check_master)
            {
                if (connectionList[2 * client_id] == 1 && connectionList[2 * client_id + 1] == 1) return true;
            }
            else
            {
                if (connectionList[2 * client_id] > 0  && connectionList[2 * client_id + 1] > 0) return true;
            }
            return false;
        }

        public void check_balance_alert()
        {
            try
            {
                double max_ratio = 100;
                int alert_client_id = -1;
                for(int i = 0; i < tot_client_num; i++)
                {
                    if (!check_connection_both_accounts(i, false)) continue;

                    QuoteClient qc1 = qcList[2 * i];
                    QuoteClient qc2 = qcList[2 * i + 1];

                    if (!check_hedge(i, 0) || !check_hedge(i, 1))
                        continue;

                    double balance1 = qc1.AccountBalance;
                    double balance2 = qc2.AccountBalance;
                    double sumVal = balance1 + balance2;

                    if (sumVal < 1e-3) continue;

                    double ratio = Math.Min(balance1 / sumVal, balance2 / sumVal) * 100;

                    if(ratio <= Settings.balance_alert_ratio)
                    {
                        if(max_ratio > ratio)
                        {
                            max_ratio = ratio;
                            alert_client_id = i;
                        }
                    }
                }

                if (balance_alert_client_id != alert_client_id && alert_client_id >= 0)
                {
                    AlertSound();
                }

                balance_alert_client_id = alert_client_id;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Check balance alert failed: " + ex.ToString());
                balance_alert_client_id = -1;
            }
        }

        // check if order was opened within last 10 seconds
        private bool CheckRecentOrder(DateTime server_time, DateTime order_open_time)
        {
            // server time can be shifted 1 hour for some brokers
            if (server_time < order_open_time)
                server_time = server_time.AddHours(1);

            if (server_time < order_open_time)
                return true;

            if ((server_time - order_open_time).TotalSeconds <= 10)
                return true;

            return false;
        }

        // check if there are unmatched orders
        // don't check when there is a recent order that was opened within 10 seconds
        public bool check_margin_call_for_unmatched_orders(int client_id, out List<int> close_order_ticket1, out List<int> close_order_ticket2)
        {
            close_order_ticket1 = new List<int>();
            close_order_ticket2 = new List<int>();

            try
            {
                if (!check_connection_both_accounts(client_id, false))
                    return false;

                QuoteClient qc1 = qcList[2 * client_id];
                QuoteClient qc2 = qcList[2 * client_id + 1];

                if (qc1.AccountBalance == 0 || qc2.AccountBalance == 0)
                    return false;

                if (qc1.AccountEquity == 0 || qc2.AccountEquity == 0)
                    return false;

                DateTime server_time1 = qc1.ServerTime;
                DateTime server_time2 = qc2.ServerTime;

                var orders1 = qc1.GetOpenedOrders();
                var orders2 = qc2.GetOpenedOrders();

                double lotsum1 = 0;
                double lotsum2 = 0;

                foreach (var order in orders1)
                {
                    var utc_time = order.OpenTime.ToUniversalTime();

                    if (CheckRecentOrder(server_time1, order.OpenTime))
                        return false;

                    if (is_market_order(order))
                    {
                        lotsum1 += order.Lots;
                    }
                }

                foreach (var order in orders2)
                {
                    if (CheckRecentOrder(server_time2, order.OpenTime))
                        return false;

                    if (is_market_order(order))
                    {
                        lotsum2 += order.Lots;
                    }
                }

                if (lotsum1 == lotsum2)
                    return false;

                int count1 = orders1.Length;
                int count2 = orders2.Length;

                bool[] visit_flag1 = new bool[count1];
                bool[] visit_flag2 = new bool[count2];
                for (int i = 0; i < count1; i++) visit_flag1[i] = false;
                for (int i = 0; i < count2; i++) visit_flag2[i] = false;

                for(int i = 0; i < count1; i++)
                {
                    var order1 = orders1[i];
                    if (!is_market_order(order1))
                        continue;
                    string symbol = order1.Symbol;
                    if (symbol == "USOilCash") symbol = "XTIUSD";
                    if (symbol == "UKOilCash") symbol = "XBRUSD";

                    for (int j = 0; j < count2; j++)
                    {
                        var order2 = orders2[j];

                        if (!is_market_order(order2) || visit_flag2[j])
                            continue;                        

                        if (remove_suffix(symbol) == remove_suffix(order2.Symbol) && order1.Lots == order2.Lots)
                        {
                            visit_flag1[i] = true;
                            visit_flag2[j] = true;
                            break;
                        }
                    }
                }

                for(int i = 0; i < count1; i++)
                {
                    if (!visit_flag1[i])
                        close_order_ticket1.Add(orders1[i].Ticket);
                }

                for(int i = 0; i < count2; i++)
                {
                    if (!visit_flag2[i])
                        close_order_ticket2.Add(orders2[i].Ticket);
                }

                return close_order_ticket1.Count > 0 || close_order_ticket2.Count > 0;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Failed to check margin call: " + ex.ToString());
            }

            return false;
        }

        public void check_unmatched_opened_order()
        {
            try
            {
                var message = "";
                for (int i = 0; i < tot_client_num; i++)
                {
                    if (!check_connection_both_accounts(i, false)) continue;

                    QuoteClient qc1 = qcList[2 * i];
                    QuoteClient qc2 = qcList[2 * i + 1];

                    if (!check_hedge(i, 0) || !check_hedge(i, 1))
                        continue;

                    var orders1 = qc1.GetOpenedOrders();
                    var orders2 = qc2.GetOpenedOrders();

                    double lotsum1 = 0;
                    double lotsum2 = 0;

                    foreach(var order in orders1)
                    {
                        if (is_market_order(order)) lotsum1 += order.Lots;
                    }

                    foreach (var order in orders2)
                    {
                        if (is_market_order(order)) lotsum2 += order.Lots;
                    }

                    var name = nameList[i];
                    double difference = lotsum1 - lotsum2;

                    if (!openedOrderDifference.ContainsKey(name))
                    {
                        openedOrderDifference.Add(name, difference);
                        openOrderDifferenceTime.Add(name, DateTime.Now);
                    }
                    else
                    {
                        var odiff = openedOrderDifference[name];
                        if (odiff != difference)
                        {
                            openedOrderDifference[name] = difference;
                            openOrderDifferenceTime[name] = DateTime.Now;
                        }
                        else
                        {
                            if (Math.Abs(difference) > 0)
                            {
                                if((DateTime.Now - openOrderDifferenceTime[name]).TotalSeconds >= 10)
                                {
                                    openOrderDifferenceTime[name] = DateTime.MaxValue;
                                    message += name + "(" + qc1.User + "," + qc2.User + ") ";
                                }
                            }
                        }
                    }
                }
                if (!string.IsNullOrEmpty(message))
                {
                    message = "Attention! Different Lots: " + message;
                    AlertSoundAndMessage(message);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("check opened order unmatched: " + ex.ToString());
            }
        }

        public List<int> get_matched_order_list_close(int client_id = -1)
        {
            List<int> R83_orderList = new List<int>();
            R83_orderList.Clear();

            try
            {
                if (tot_client_num == 0) return R83_orderList;
                if (client_id < 0) client_id = current_client_id;

                if(check_connection_both_accounts(client_id, false))
                {
                    QuoteClient qc1 = qcList[2 * client_id];
                    QuoteClient qc2 = qcList[2 * client_id + 1];

                    var orders1 = qc1.GetOpenedOrders();
                    var orders2 = qc2.GetOpenedOrders();

                    int len1 = orders1.Length;
                    int len2 = orders2.Length;

                    bool[] checkFlag = new bool[len2];
                    for (int i = 0; i < len2; i++) checkFlag[i] = false;
                    bool isPending;
                    int _count = 0;

                    for (int i = len1 - 1; i >= 0; i--)
                    {
                        if (dict_close_pending.TryGetValue(orders1[i].Ticket, out isPending)) continue;
                        if (!is_market_order(orders1[i])) continue;

                        R83_orderList.Add(i);
                        R83_orderList.Add(-1);
                        _count += 2;

                        for (int k = len2 - 1; k >= 0; k--)
                        {
                            if (checkFlag[k]) continue;
                            if (!is_market_order(orders2[k])) continue;
                            if (dict_close_pending.TryGetValue(orders2[k].Ticket, out isPending))
                            {
                                checkFlag[k] = true;
                                continue;
                            }
                            Order order1 = orders1[i];
                            Order order2 = orders2[k];

                            string symbol1 = remove_suffix(order1.Symbol);
                            string symbol2 = remove_suffix(order2.Symbol);
                            if (symbol1 == "USOilCash") symbol1 = "XTIUSD";
                            if (symbol1 == "UKOilCash") symbol1 = "XBRUSD";

                            if (symbol1 == symbol2 && order1.Lots == order2.Lots)
                            {
                                checkFlag[k] = true;
                                R83_orderList[_count - 1] = k;
                                break;
                            }
                        }
                    }
                    for (int i = len2 - 1; i >= 0; i--)
                    {
                        if (checkFlag[i]) continue;
                        if (!is_market_order(orders2[i])) continue;
                        R83_orderList.Add(-1);
                        R83_orderList.Add(i);
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get matched order list close failed: " + ex.ToString());
                R83_orderList.Clear();
            }
            return R83_orderList;
        }

        public bool is_market_order(Order order)
        {
            if (order.Type == Op.Buy || order.Type == Op.Sell) return true;
            return false;
        }

        public int get_matched_order_list_display(int client_id = -1)
        {
            try
            {
                R8_orderList.Clear();
                R3_orderList.Clear();
                tot_order_num_display = 0;

                if (tot_client_num == 0) return tot_order_num_display;
                if (client_id < 0) client_id = current_client_id;

                if(check_connection_both_accounts(client_id, false))
                {
                    QuoteClient qc1 = qcList[2 * client_id];
                    QuoteClient qc2 = qcList[2 * client_id + 1];

                    var orders1 = qc1.GetOpenedOrders();
                    var orders2 = qc2.GetOpenedOrders();

                    int len1 = orders1.Length;
                    int len2 = orders2.Length;

                    bool[] checkFlag = new bool[len2];
                    for (int i = 0; i < len2; i++) checkFlag[i] = false;
                    bool isPending;
                    int _count = 0;

                    for (int i = len1 - 1; i >= 0; i--)
                    {
                        if (!Settings.show_pending_order && !is_market_order(orders1[i])) continue;
                        if (dict_close_pending.TryGetValue(orders1[i].Ticket, out isPending)) continue;
                        R8_orderList.Add(i);
                        R3_orderList.Add(-1);
                        _count++;

                        for (int k = len2 - 1; k >= 0; k--)
                        {
                            if (!Settings.show_pending_order && !is_market_order(orders2[k])) continue;
                            if (checkFlag[k]) continue;
                            if (dict_close_pending.TryGetValue(orders2[k].Ticket, out isPending))
                            {
                                checkFlag[k] = true;
                                continue;
                            }
                            Order order1 = orders1[i];
                            Order order2 = orders2[k];

                            //check pending order
                            if (is_market_order(order1) != is_market_order(order2)) continue;

                            string symbol1 = remove_suffix(order1.Symbol);
                            string symbol2 = remove_suffix(order2.Symbol);
                            if (symbol1 == "USOilCash") symbol1 = "XTIUSD";
                            if (symbol1 == "UKOilCash") symbol1 = "XBRUSD";

                            if (symbol1 == symbol2 && order1.Lots == order2.Lots)
                            {
                                checkFlag[k] = true;
                                R3_orderList[_count - 1] = k;
                                break;
                            }
                        }
                    }

                    for (int i = len2 - 1; i >= 0; i--)
                    {
                        if (checkFlag[i]) continue;
                        if (!Settings.show_pending_order && !is_market_order(orders2[i])) continue;
                        R8_orderList.Add(-1);
                        R3_orderList.Add(i);
                    }

                    tot_order_num_display = R8_orderList.Count;

                    sort_orders_list();
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get matched order list display failed: " + ex.ToString());

                R8_orderList.Clear();
                R3_orderList.Clear();
                tot_order_num_display = 0;
            }

            return tot_order_num_display;
        }

        public void sort_orders_list()
        {
            if (tot_order_num_display == 0) return;
            if(is_invalid_client()) return;

            try
            {
                DateTime[] dt_orders = new DateTime[tot_order_num_display];
                String[] str_orders = new String[tot_order_num_display];
                double[] dbl_orders = new double[tot_order_num_display];

                int[] sorted_id = new int[tot_order_num_display];
                int[] prev_R8_orders = new int[tot_order_num_display];
                int[] prev_R3_orders = new int[tot_order_num_display];

                for (int i = 0; i < tot_order_num_display; i++)
                {
                    dt_orders[i] = DateTime.Now;
                    str_orders[i] = "";
                    dbl_orders[i] = 0;

                    sorted_id[i] = i;
                    prev_R3_orders[i] = R3_orderList[i];
                    prev_R8_orders[i] = R8_orderList[i];
                }

                QuoteClient qc1 = qcList[2 * current_client_id];
                QuoteClient qc2 = qcList[2 * current_client_id + 1];

                for(int i = 0; i < tot_order_num_display; i++)
                {
                    int orderId1 = R8_orderList[i];
                    int orderId2 = R3_orderList[i];

                    var orders1 = qc1.GetOpenedOrders();
                    var orders2 = qc2.GetOpenedOrders();

                    if (orderId1 >= 0 && orderId1 < orders1.Length) //not exceed 
                    {
                        switch(orders_sort_item)
                        {
                            case Headers.Account:
                                dt_orders[i] = orders1[orderId1].OpenTime;
                                break;
                            case Headers.Active:
                                dbl_orders[i] = DateTime.Now.Subtract(orders1[orderId1].OpenTime).TotalDays;
                                break;
                            case Headers.Commission:
                                dbl_orders[i] = orders1[orderId1].Swap;
                                break;
                            case Headers.Spread:
                                dbl_orders[i] = DateTime.Now.Subtract(orders1[orderId1].OpenTime).TotalDays;
                                break;
                            case Headers.Currency:
                                string str_symbol = orders1[orderId1].Symbol;
                                if (str_symbol == "USOilCash") str_symbol = "XTIUSD";
                                if (str_symbol == "UKOilCash") str_symbol = "XBRUSD";
                                str_orders[i] = remove_suffix(orders1[orderId1].Symbol);
                                break;
                            case Headers.Lot:
                                dbl_orders[i] = orders1[orderId1].Lots;
                                break;
                            case Headers.PnL:
                                dbl_orders[i] = orders1[orderId1].Profit;
                                break;
                            case Headers.Swap:
                                dbl_orders[i] = orders1[orderId1].Swap;
                                break;
                            default:
                                dt_orders[i] = orders1[orderId1].OpenTime;
                                break;
                        }
                    }
                    else if (orderId2 >= 0 && orderId2 < orders2.Length) //not exceed
                    {
                        switch (orders_sort_item)
                        {
                            case Headers.Account:
                                dt_orders[i] = orders2[orderId2].OpenTime;
                                break;
                            case Headers.Active:
                                dbl_orders[i] = DateTime.Now.Subtract(orders2[orderId2].OpenTime).TotalDays;
                                break;
                            case Headers.Commission:
                                dbl_orders[i] = orders2[orderId2].Swap;
                                break;
                            case Headers.Spread:
                                dbl_orders[i] = DateTime.Now.Subtract(orders2[orderId2].OpenTime).TotalDays;
                                break;
                            case Headers.Currency:                                
                                str_orders[i] = remove_suffix(orders2[orderId2].Symbol);
                                break;
                            case Headers.Lot:
                                dbl_orders[i] = orders1[orderId2].Lots;
                                break;
                            case Headers.PnL:
                                dbl_orders[i] = orders1[orderId2].Profit;
                                break;
                            case Headers.Swap:
                                dbl_orders[i] = orders1[orderId2].Swap;
                                break;
                            default:
                                dt_orders[i] = orders1[orderId2].OpenTime;
                                break;
                        }
                    }
                }

                for(int k = 0; k < tot_order_num_display; k++)
                {
                    for(int i = k + 1; i < tot_order_num_display; i++)
                    {
                        bool swapFlag = false;
                        if(orders_sort_item == Headers.Account) //datetime
                        {
                            if(orders_sort_increased)
                            {
                                if(dt_orders[sorted_id[k]] < dt_orders[sorted_id[i]])
                                {
                                    swapFlag = true;
                                }
                            }
                            else
                            {
                                if (dt_orders[sorted_id[k]] > dt_orders[sorted_id[i]])
                                {
                                    swapFlag = true;
                                }
                            }
                        }
                        else if(orders_sort_item == Headers.Currency) //string
                        {
                            if(orders_sort_increased)
                            {
                                if (String.Compare(str_orders[sorted_id[k]], str_orders[sorted_id[i]]) > 0)
                                {
                                    swapFlag = true;
                                }
                            }
                            else
                            {
                                if (String.Compare(str_orders[sorted_id[k]], str_orders[sorted_id[i]]) < 0)
                                {
                                    swapFlag = true;
                                }
                            }
                        }
                        else
                        {
                            if (orders_sort_increased)
                            {
                                if (dbl_orders[sorted_id[k]] > dbl_orders[sorted_id[i]])
                                {
                                    swapFlag = true;
                                }
                            }
                            else
                            {
                                if (dbl_orders[sorted_id[k]] < dbl_orders[sorted_id[i]])
                                {
                                    swapFlag = true;
                                }
                            }
                        }

                        if(swapFlag)
                        {
                            int tmp = sorted_id[k];
                            sorted_id[k] = sorted_id[i];
                            sorted_id[i] = tmp;
                        }
                    }
                }

                for(int i = 0; i < tot_order_num_display; i++)
                {
                    R3_orderList[i] = prev_R3_orders[sorted_id[i]];
                    R8_orderList[i] = prev_R8_orders[sorted_id[i]];
                }

            }
            catch(Exception ex)
            {
                Settings.Log.Error("Sort orders failed: " + ex.ToString());
            }
            
        }

        public int find_id_from_userId(int userId)
        {
            for(int i = 0; i < tot_client_num; i++)
            {
                if (userIdList[2 * i] == userId) return 2 * i;
                if (userIdList[2 * i + 1] == userId) return 2 * i + 1;
            }
            return -1;
        }

        public int find_id_from_clientID(int clientId)
        {
            if (clientId < 0) return -1;
            for(int i = 0; i < tot_client_num; i++)
            {
                if (clientIdList[i] == clientId) return i;
            }
            return -1;
        }

        public void add_new_client(ClientInfo new_client)
        {
            tot_client_num++;

            qcList.Add(new_client.qc1);
            qcList.Add(new_client.qc2);
            ocList.Add(new_client.oc1);
            ocList.Add(new_client.oc2);
            clientIdList.Add(new_client.clientId);
            nameList.Add(new_client.name);
            connectionList.Add(new_client.connection1);
            connectionList.Add(new_client.connection2);
            currencyList.Add(new_client.currency1);
            currencyList.Add(new_client.currency2);
            userIdList.Add(new_client.userId1);
            userIdList.Add(new_client.userId2);
            passwordList.Add(new_client.password1);
            passwordList.Add(new_client.password2);
            emailList.Add(new_client.email);
            emailPasswordList.Add(new_client.emailPassword);
            serverNameList.Add(new_client.server_name1);
            serverNameList.Add(new_client.server_name2);
            serverIndexList.Add(-1); // use main server
            serverIndexList.Add(-1);
            swapfreeFlagList.Add(new_client.swapfree_flag1);
            swapfreeFlagList.Add(new_client.swapfree_flag2);
            hedgeFlagList.Add(new_client.hedge_flag1);
            hedgeFlagList.Add(new_client.hedge_flag2);
            stopLevelList.Add(new_client.stop_level1);
            stopLevelList.Add(new_client.stop_level2);
            pammList.Add(new_client.pamm);
            moneyShiftFlagList.Add(new_client.moneyShiftFlag);
            moneyShiftLimitList.Add(new_client.moneyShiftAmount);
            marginAlertAmountList.Add(new_client.margin_alert_amount);
            marginCallAmountList.Add(new_client.margin_call_amount);
            freePipAmountList.Add(new_client.free_pip_amount);
            phoneNumberList.Add(new_client.phone_number);
            isPendingList.Add(new_client.is_pending);
            marginAlertFlagList.Add(false);
            marginCallFlagList.Add(false);
            lastPendingTime.Add(DateTime.MinValue);
            freePipFlagList.Add(false);
            freePipLastTime.Add(DateTime.MinValue);
            marginAlertTime.Add(DateTime.Now);
            closedOrderSwapList.Add(0);
            closedOrderSwapList.Add(0);
            closedOrderLotsList.Add(0);
            closedOrderLotsList.Add(0);
            closedOrderReopenList.Add(0);
            closedOrderReopenList.Add(0);
        }

        public void remove_one_client(int pos)
        {
            if (tot_client_num == 0) return;

            tot_client_num--;
            
            try
            {
                qcList.RemoveRange(pos * 2, 2);
                ocList.RemoveRange(pos * 2, 2);
                connectionList.RemoveRange(pos * 2, 2);
                currencyList.RemoveRange(pos * 2, 2);
                userIdList.RemoveRange(pos * 2, 2);
                passwordList.RemoveRange(pos * 2, 2);
                serverNameList.RemoveRange(pos * 2, 2);
                serverIndexList.RemoveRange(pos * 2, 2);
                swapfreeFlagList.RemoveRange(pos * 2, 2);
                hedgeFlagList.RemoveRange(pos * 2, 2);
                stopLevelList.RemoveRange(pos * 2, 2);
                clientIdList.RemoveAt(pos);
                nameList.RemoveAt(pos);
                pammList.RemoveAt(pos);
                emailList.RemoveAt(pos);
                emailPasswordList.RemoveAt(pos);
                moneyShiftFlagList.RemoveAt(pos);
                moneyShiftLimitList.RemoveAt(pos);
                marginAlertAmountList.RemoveAt(pos);
                marginCallAmountList.RemoveAt(pos);
                isPendingList.RemoveAt(pos);
                lastPendingTime.RemoveAt(pos);
                marginAlertFlagList.RemoveAt(pos);
                marginCallFlagList.RemoveAt(pos);
                freePipAmountList.RemoveAt(pos);
                phoneNumberList.RemoveAt(pos);
                freePipFlagList.RemoveAt(pos);
                freePipLastTime.RemoveAt(pos);
                marginAlertTime.RemoveAt(pos);
                closedOrderSwapList.RemoveRange(pos * 2, 2);
                closedOrderLotsList.RemoveRange(pos * 2, 2);
                closedOrderReopenList.RemoveRange(pos * 2, 2);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Remove one client failed: " + ex.ToString());
            }
        }

        public void update_clients_after_delete()
        {
            if(tot_client_num == 0)
            {
                datafeed_client_id = 0;
                current_client_id = 0;
                master_client_id = 0;
                return;
            }

            set_datafeed_client();
            if (current_client_id >= tot_client_num)
            {
                current_client_id = 0;
            }
            if (master_client_id >= tot_client_num)
            {
                master_client_id = 0;
            }
        }

        public void init_pending_time(int clientId)
        {
            if(clientId >= 0 && clientId < tot_client_num)
                lastPendingTime[clientId] = DateTime.MinValue;
            else
            {
                for(int i = 0; i < tot_client_num; i++)
                    lastPendingTime[i] = DateTime.MinValue;
            }
        }

        public void init_pending_userId(int userId)
        {
            for(int i = 0; i < tot_client_num; i++)
            {
                if(userIdList[2 * i] == userId || userIdList[2 * i + 1] == userId)
                {
                    isPendingList[i] = 0;
                }
            }
        }

        public void add_dict_close_pending(int ticket)
        {
            bool val;

            if (dict_close_pending.TryGetValue(ticket, out val)) { }
            else
            {
                dict_close_pending.Add(ticket, true);
            }
        }

        public void remove_dict_close_pending(int ticket)
        {
            bool val;

            if (dict_close_pending.TryGetValue(ticket, out val))
            {
                dict_close_pending.Remove(ticket);
            }
        }

        public void init_margin_alert_call_flag()
        {
            for (int i = 0; i < tot_client_num; i++)
            {
                marginAlertFlagList[i] = false;
                marginCallFlagList[i] = false;
            }
        }

        public void update_closed_orders(int userId, Order order)
        {
            if(!is_market_order(order)) return;

            for (int i = 0; i < tot_client_num; i++)
            {
                int id = -1;
                if (userIdList[2 * i] == userId) id = 2 * i;
                else if (userIdList[2 * i + 1] == userId) id = 2 * i + 1;
                if (id < 0) continue;

                var orders = closedOrderDict[userId];
                var norders = new List<Order>();
                foreach(var o in orders)
                {
                    norders.Add(o);
                }
                var exist = norders.FirstOrDefault(s => s.Ticket == order.Ticket);

                if (exist == null)
                {
                    norders.Add(order);
                    closedOrderDict[userId] = norders.ToArray();

                    if (id >= 0) // && connectionList[id] > 0)
                    {
                        closedOrderLotsList[id] += order.Lots;
                        closedOrderSwapList[id] += order.Swap;

                        TimeSpan ts = order.CloseTime - order.OpenTime;
                        closedOrderReopenList[id] += order.Lots * (count_nights_from_time(order.OpenTime, server_time) - 30);
                    }
                }
            }
        }

        public void wait_for_loading_closed_orders()
        {
            for(int i = 0; i < tot_client_num; i++)
            {
                if(check_connection_both_accounts(i, false))
                {
                    int user_id1 = userIdList[2 * i];
                    int user_id2 = userIdList[2 * i + 1];
                    while (!closedOrderDict.ContainsKey(user_id1) || !closedOrderDict.ContainsKey(user_id2))
                    {
                        Thread.Sleep(1);
                        if (!check_connection_both_accounts(i, false)) break;
                    }
                }
            }
        }

        public bool check_initial_pending_time(int clientId)
        {
            if (lastPendingTime[clientId] == DateTime.MinValue) return true;
            return false;
        }

        public void read_client_from_db(SQLiteWrapper _sql)
        {
            SimpleAES _aes = new SimpleAES();

            try
            {
                DataTable dt = _sql.GetDataTable("account", "");
                int tot_num = dt.Rows.Count;

                if (tot_num == 0)
                {
                    Settings.Log.Info("Login finished");
                    return;
                }

                QuoteClient m_qc = new QuoteClient();
                OrderClient m_oc = new OrderClient();

                ClientInfo client_info = new ClientInfo();

                for (int k = 0; k < tot_num; k++)
                {
                    client_info.Init();

                    try
                    {
                        client_info.qc1 = m_qc;
                        client_info.qc2 = m_qc;
                        client_info.oc1 = m_oc;
                        client_info.oc2 = m_oc;
                        client_info.name = dt.Rows[k]["name"].ToString();
                        client_info.password1 = _aes.Decrypt(dt.Rows[k]["password1"].ToString());
                        client_info.password2 = _aes.Decrypt(dt.Rows[k]["password2"].ToString());
                        client_info.email = dt.Rows[k]["email"].ToString();
                        client_info.emailPassword = _aes.Decrypt(dt.Rows[k]["email_password"].ToString());
                        int.TryParse(dt.Rows[k]["userId1"].ToString(), out client_info.userId1);
                        int.TryParse(dt.Rows[k]["userId2"].ToString(), out client_info.userId2);
                        Int32.TryParse(dt.Rows[k]["money_shift_flag"].ToString(), out client_info.moneyShiftFlag);
                        Int32.TryParse(dt.Rows[k]["money_shift_amount"].ToString(), out client_info.moneyShiftAmount);
                        Int32.TryParse(dt.Rows[k]["pamm"].ToString(), out client_info.pamm);
                        Int32.TryParse(dt.Rows[k]["clientId"].ToString(), out client_info.clientId);
                        double.TryParse(dt.Rows[k]["margin_alert_amount"].ToString(), out client_info.margin_alert_amount);
                        double.TryParse(dt.Rows[k]["margin_call_amount"].ToString(), out client_info.margin_call_amount);
                        double.TryParse(dt.Rows[k]["notification_amount"].ToString(), out client_info.free_pip_amount);
                        client_info.phone_number = dt.Rows[k]["phone_number"].ToString();

                        double.TryParse(dt.Rows[k]["stop_level1"].ToString(), out client_info.stop_level1);
                        double.TryParse(dt.Rows[k]["stop_level2"].ToString(), out client_info.stop_level2);

                        if (dt.Columns.IndexOf("server_name1") > 0)
                        {
                            client_info.server_name1 = dt.Rows[k]["server_name1"].ToString();
                        }
                        else client_info.server_name1 = "FXFellow-Real8";

                        if (dt.Columns.IndexOf("server_name2") > 0)
                        {
                            client_info.server_name2 = dt.Rows[k]["server_name2"].ToString();
                        }
                        else client_info.server_name2 = "FXFellow-Real3";

                        if (dt.Columns.IndexOf("swapfree_flag1") > 0)
                        {
                            int tmp = 0;
                            if (!Int32.TryParse(dt.Rows[k]["swapfree_flag1"].ToString(), out tmp))
                                tmp = 0;
                            client_info.swapfree_flag1 = tmp;
                        }
                        else client_info.swapfree_flag1 = 0;

                        if (dt.Columns.IndexOf("swapfree_flag2") > 0)
                        {
                            int tmp = 0;
                            if (!Int32.TryParse(dt.Rows[k]["swapfree_flag2"].ToString(), out tmp))
                                tmp = 0;
                            client_info.swapfree_flag2 = tmp;
                        }
                        else client_info.swapfree_flag2 = 0;

                        if (dt.Columns.IndexOf("hedge_flag1") > 0)
                        {
                            int tmp = 0;
                            if (!Int32.TryParse(dt.Rows[k]["hedge_flag1"].ToString(), out tmp))
                                tmp = 0;
                            client_info.hedge_flag1 = tmp;
                        }
                        else client_info.hedge_flag1 = 0;

                        if (dt.Columns.IndexOf("hedge_flag2") > 0)
                        {
                            int tmp = 0;
                            if (!Int32.TryParse(dt.Rows[k]["hedge_flag2"].ToString(), out tmp))
                                tmp = 0;
                            client_info.hedge_flag2 = tmp;
                        }
                        else client_info.hedge_flag2 = 0;

                        client_info.margin_alert_amount = 30;
                        client_info.margin_call_amount = 5;
                        client_info.margin_alert_flag = false;
                        client_info.margin_call_flag = false;

                        if (client_info.moneyShiftAmount > 100) client_info.moneyShiftAmount = 10;

                        //if (!client_info.is_valid()) continue;
                    }
                    catch (Exception ex)
                    {
                        Settings.Log.Error("Read db file failed: " + ex.ToString());
                        continue;
                    }

                    add_new_client(client_info);
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Can't read db file: " + ex.ToString());
                return;
            }
        }

        public int save_new_account(ClientCtrl ctrl_client)
        {
            try
            {
                var info = ctrl_client.read_client_info_from_ctrl();

                //new account login
                QuoteClient m_qc = new QuoteClient();
                OrderClient m_oc = new OrderClient();

                ClientInfo client_info = new ClientInfo();

                client_info.Init();

                client_info.qc1 = m_qc;
                client_info.qc2 = m_qc;
                client_info.oc1 = m_oc;
                client_info.oc2 = m_oc;

                client_info.clientId = get_max_client_id() + 1;
                client_info.name = info.name;
                client_info.userId1 = info.userId1;
                client_info.userId2 = info.userId2;
                client_info.password1 = info.password1;
                client_info.password2 = info.password2;
                client_info.email = info.email;
                client_info.emailPassword = info.emailPassword;
                client_info.server_name1 = info.server_name1;
                client_info.server_name2 = info.server_name2;
                client_info.stop_level1 = info.stop_level1;
                client_info.stop_level2 = info.stop_level2;

                if (!client_info.is_valid())
                {
                    return -2;
                }

                int same_id = check_same_account(client_info);

                add_new_client(client_info);
                return same_id;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Login new client failed: " + ex.ToString());
                return -2;
            }
        }

        public int check_same_account(ClientInfo info)
        {
            for(int i = 0; i < tot_client_num; i++)
            {
                if (userIdList[2 * i] == info.userId1) return i;
                if (userIdList[2 * i + 1] == info.userId2) return i;
            }
            return -1;
        }

        public void read_one_client(ClientInfo info, int id)
        {
            info.Init();
            if (id >= tot_client_num) return;

            info.clientId = clientIdList[id];
            info.name = nameList[id];
            info.userId1 = userIdList[2 * id];
            info.userId2 = userIdList[2 * id + 1];
            info.password1 = passwordList[2 * id];
            info.password2 = passwordList[2 * id + 1];
            info.server_name1 = serverNameList[2 * id];
            info.server_name2 = serverNameList[2 * id + 1];
            info.server_index1 = serverIndexList[2 * id];
            info.server_index2 = serverIndexList[2 * id + 1];
            info.swapfree_flag1 = swapfreeFlagList[2 * id];
            info.swapfree_flag2 = swapfreeFlagList[2 * id + 1];
            info.hedge_flag1 = hedgeFlagList[2 * id];
            info.hedge_flag2 = hedgeFlagList[2 * id + 1];
            info.stop_level1 = stopLevelList[2 * id];
            info.stop_level2 = stopLevelList[2 * id + 1];
            info.email = emailList[id];
            info.emailPassword = emailPasswordList[id];
            info.pamm = pammList[id];
            info.moneyShiftFlag = moneyShiftFlagList[id];
            info.moneyShiftAmount = moneyShiftLimitList[id];
            info.margin_alert_amount = marginAlertAmountList[id];
            info.margin_call_amount = marginCallAmountList[id];
            info.is_pending = isPendingList[id];
            info.margin_alert_flag = marginAlertFlagList[id];
            info.margin_call_flag = marginCallFlagList[id];
            info.free_pip_amount = freePipAmountList[id];
            info.phone_number = phoneNumberList[id];
            info.currency1 = currencyList[2 * id];
            info.currency2 = currencyList[2 * id + 1];
            info.connection1 = connectionList[2 * id];
            info.connection2 = connectionList[2 * id + 1];
        }

        public int get_max_client_id()
        {
            if (tot_client_num == 0) return 0;
            return clientIdList[tot_client_num - 1];
        }

        public int get_pamm_client_num()
        {
            int res = 0;
            for (int i = 0; i < tot_client_num; i++)
            {
                if (pammList[i] == 1) res++;
            }
            return res;
        }

        public int get_moneyshift_client_num()
        {
            int res = 0;
            for (int i = 0; i < tot_client_num; i++)
            {
                if (moneyShiftFlagList[i] == 1) res++;
            }
            return res;
        }

        public void get_closed_order_info(int user_id)
        {
            try
            {
                QuoteClient qc;

                for (int i = 0; i < tot_client_num; i++)
                {
                    int id = -1;
                    if (userIdList[2 * i] == user_id) id = 2 * i;
                    else if (userIdList[2 * i + 1] == user_id) id = 2 * i + 1;

                    if(id >= 0)
                    {
                        closedOrderLotsList[id] = 0;
                        closedOrderSwapList[id] = 0;
                        closedOrderReopenList[id] = 0;

                        qc = qcList[id];

                        var orders = new Order[0];

                        try
                        {
                            orders = qc.DownloadOrderHistory(DateTime.Now.AddYears(-1), DateTime.Now.AddDays(2));
                        }
                        catch (Exception)
                        {
                            orders = new Order[0];
                        }

                        if (!closedOrderDict.ContainsKey(user_id))
                            closedOrderDict.Add(user_id, orders);
                        else
                            closedOrderDict[user_id] = orders;

                        foreach (var order in orders)
                        {
                            if (order == null)
                                continue;

                            if (!is_market_order(order))
                                continue;

                            closedOrderSwapList[id] += order.Swap;
                            closedOrderLotsList[id] += order.Lots;

                            closedOrderReopenList[id] += order.Lots * (count_nights_from_time(order.OpenTime, order.CloseTime) - 30);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get closed lots swap failed: " + ex.ToString());
            }
        }

        public int count_nights_from_time(DateTime start_time, DateTime end_time)
        {
            TimeSpan ts = end_time - start_time;
            int day = ts.Days;

            if (start_time.Hour > end_time.Hour) day++;
            else if (start_time.Hour == end_time.Hour && start_time.Minute > end_time.Minute) day++;
            else if (start_time.Hour == end_time.Hour && start_time.Minute == end_time.Minute && start_time.Second > end_time.Second) day++;

            return day;
        }

        public int get_max_orders_num(int client_id = -1)
        {
            if (client_id < 0) client_id = current_client_id;

            if (tot_client_num == 0) return 0;

            try
            {
                QuoteClient qc1 = qcList[2 * client_id];
                QuoteClient qc2 = qcList[2 * client_id + 1];

                var orders1 = qc1.GetOpenedOrders();
                var orders2 = qc2.GetOpenedOrders();

                int len1 = orders1.Length;
                int len2 = orders2.Length;

                if (len1 < len2) len1 = len2;

                return len1;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get max orders num failed: " + ex.ToString());
                return 0;
            }
        }

        public int get_symbol_id(string str)
        {
            if (str == "UKOilCash") str = "XBRUSD";
            if (str == "USOilCash") str = "XTIUSD";
            for (int i = 0; i < Settings.symbol_num; i++)
            {
                if (Settings.SymbolsToSubscribe[i].Contains(str)) return i;
            }
            return -1;
        }

        public int get_server_id(int user_id)
        {
            for(int i = 0; i < tot_client_num; i++)
            {
                if (userIdList[2 * i] == user_id)
                    return 0;
                if (userIdList[2 * i + 1] == user_id)
                    return 1;
            }
            return -1;
        }

        public void get_order_details(OrderDetails od, int clientId, int orderId)
        {
            if (tot_client_num == 0) return;
            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                int orderId1 = R8_orderList[orderId];
                int orderId2 = R3_orderList[orderId];

                var orders1 = qc1.GetOpenedOrders();
                var orders2 = qc2.GetOpenedOrders();

                int symbol_id;

                od.Init();

                if (orderId1 >= 0 && orderId1 < orders1.Length) //not exceed 
                {
                    var order = orders1[orderId1];
                    int _day = count_nights_from_time(order.OpenTime, server_time);
                    double _lots = order.Lots;

                    od.userId1 = userIdList[2 * clientId].ToString();
                    od.symbol1 = remove_suffix(order.Symbol);
                    if (od.symbol1 == "UKOilCash") od.symbol1 = "XBRUSD";
                    if (od.symbol1 == "USOilCash") od.symbol1 = "XTIUSD";
                    od.lot1 = _lots.ToString("#,##0.00");
                    od.active1 = _day.ToString();
                    od.swap1 = order.Swap.ToString("#,##0.00");
                    od.pnl1 = order.Profit.ToString("#,##0.00");
                    od.sl_tp1 = "";
                    od.commission1 = (order.Swap * 0.2).ToString("#,##0.00");

                    symbol_id = get_symbol_id(od.symbol1);
                    if (symbol_id >= 0)
                        od.spread1 = (_lots * Settings.SymbolsSpread1[symbol_id]).ToString("#,##0.00");

                    int ticket = order.Ticket;
                    double SLTP;
                    if(dict_SLTP.TryGetValue(ticket, out SLTP) && SLTP != 0)
                    {
                        od.sl_tp1 = SLTP.ToString("#,##0.00");
                    }

                    if (!is_market_order(order))
                        od.isPending = true;
                }

                if(orderId2 >= 0 && orderId2 < orders2.Length) //not exceed
                {
                    var order = orders2[orderId2];
                    int _day = count_nights_from_time(order.OpenTime, server_time);
                    double _lots = order.Lots;

                    od.userId2 = userIdList[2 * clientId + 1].ToString();
                    od.symbol2 = remove_suffix(order.Symbol);                    
                    od.lot2 = _lots.ToString("#,##0.00");
                    od.active2 = _day.ToString();
                    od.swap2 = order.Swap.ToString("#,##0.00");
                    od.pnl2 = order.Profit.ToString("#,##0.00");
                    od.sl_tp2 = "";

                    symbol_id = get_symbol_id(od.symbol2);
                    if (symbol_id >= 0)
                        od.spread2 = (_lots * Settings.SymbolsSpread2[symbol_id]).ToString("#,##0.00");

                    int ticket = order.Ticket;
                    double SLTP;
                    if (dict_SLTP.TryGetValue(ticket, out SLTP) && SLTP != 0)
                    {
                        od.sl_tp2 = SLTP.ToString("#,##0.00");
                    }

                    if (!is_market_order(order))
                        od.isPending = true;
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get order details failed: " + ex.ToString());
            }

        }

        public bool no_client()
        {
            if (tot_client_num == 0) return true;
            return false;
        }

        public string remove_suffix(string str)
        {
            int len = str.Length;
            if (str[len - 1] == '.' || str[len - 1] == '-' || str[len - 1] == 'x')
                str = str.Remove(len - 1);
            return str;
        }

        public double get_free_margin_min(int clientId)
        {
            if (tot_client_num == 0) return 1e9;

            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                double res = Math.Min(qc1.AccountFreeMargin, qc2.AccountFreeMargin);
                return res;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get client free margin minimum failed: " + ex.ToString());
                return 1e9;
            }
        }

        public bool check_margin_call(int clientId)
        {
            if (tot_client_num == 0) return false;
            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                double margin1 = qc1.AccountFreeMargin;
                double margin2 = qc2.AccountFreeMargin;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Check margin call failed: " + ex.ToString());
            }

            return false;
        }

        public double get_free_pip_diff(int clientId)
        {
            if (tot_client_num == 0) return 0;

            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                double margin1 = qc1.AccountFreeMargin;
                double margin2 = qc2.AccountFreeMargin;

                double lot1, lot2;

                lot1 = lot2 = 0;

                var orders = qc1.GetOpenedOrders();
                foreach (var order in orders)
                {
                    if (is_market_order(order)) lot1 += order.Lots;
                }

                orders = qc2.GetOpenedOrders();
                foreach (var order in orders)
                {
                    if (is_market_order(order)) lot2 += order.Lots;
                }
                if (lot1 == 0 || lot2 == 0)
                {
                    if (margin1 > margin2) return 1e9;
                    return -1e9;
                }

                double pip1, pip2;
                pip1 = pip2 = 0;

                if (lot1 > 1e-3) pip1 = margin1 / lot1 / 10;
                if (lot2 > 1e-3) pip2 = margin2 / lot2 / 10;

                return pip1 - pip2;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get client free pip difference failed: " + ex.ToString());
                return 0;
            }
        }

        public LotsPercentInfo get_lots_percent()
        {
            LotsPercentInfo info = new LotsPercentInfo();
            info.Init();

            if (tot_client_num == 0) return info;

            try
            {
                QuoteClient qc1 = qcList[2 * current_client_id];
                QuoteClient qc2 = qcList[2 * current_client_id + 1];

                double lots_sum = 0;

                for(int k = 0; k < 2; k++)
                {
                    var orders = qc1.GetOpenedOrders();
                    if(k == 1) orders = qc2.GetOpenedOrders();

                    foreach (var order in orders)
                    {
                        if (order == null)
                            continue;
                        if (is_market_order(order))
                        {
                            string symbol_str = remove_suffix(order.Symbol);
                            if (symbol_str == "UKOilCash") symbol_str = "XBRUSD";
                            if (symbol_str == "USOilCash") symbol_str = "XTIUSD";
                            int symbol_id = get_symbol_id(symbol_str);

                            if (symbol_id >= 0 && symbol_id < Settings.symbol_num)
                            {
                                info.lotsList[symbol_id] += order.Lots;
                                lots_sum += order.Lots;
                            }
                        }
                    }
                }

                if(lots_sum > 0)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        info.percentList[i] = info.lotsList[i] / lots_sum * 100;
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get lots percent failed: " + ex.ToString());
                info.Init();
            }
            return info;
        }

        public double get_free_pip_min(int clientId)
        {
            if (tot_client_num == 0) return 1e9;
            
            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];
                double stop_level1 = stopLevelList[2 * clientId];
                double stop_level2 = stopLevelList[2 * clientId + 1];

                double free_margin1 = qc1.AccountFreeMargin;
                double free_margin2 = qc2.AccountFreeMargin;

                double margin1 = qc1.AccountMargin;
                double margin2 = qc2.AccountMargin;

                free_margin1 += margin1 * (100 - stop_level1) / 100.0;
                free_margin2 += margin2 * (100 - stop_level2) / 100.0;

                double lot1, lot2;

                lot1 = lot2 = 0;

                var orders = qc1.GetOpenedOrders();
                foreach(var order in orders)
                {
                    if (is_market_order(order)) lot1 += order.Lots;
                }

                orders = qc2.GetOpenedOrders();
                foreach (var order in orders)
                {
                    if (is_market_order(order)) lot2 += order.Lots;
                }

                double pip1, pip2;
                pip1 = pip2 = 1e9;

                if (lot1 > 1e-3) pip1 = free_margin1 / lot1 / 10;
                if (lot2 > 1e-3) pip2 = free_margin2 / lot2 / 10;

                return Math.Min(pip1, pip2);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get client free pip minimum failed: " + ex.ToString());
                return 1e9;
            }
        }

        public double get_current_money_shift(int clientId)
        {
            if (tot_client_num == 0) return 0;

            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                double money_shift = (qc1.AccountFreeMargin - qc2.AccountFreeMargin) / 2;

                return money_shift;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get client money shift failed: " + ex.ToString());
                return 0;
            }
        }

        public int get_current_balance(int clientId, int first_second)
        {
            if (tot_client_num == 0) return 0;

            try
            {
                QuoteClient qc = qcList[2 * clientId + first_second - 1];
                int res = (int)qc.AccountBalance;
                return res;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get current balance failed: " + ex.ToString());
                return 0;
            }
        }

        public void leave_log_for_money_shfit(int clientId, int firstSecond, int amount, bool alertFlag = false)
        {
            if (tot_client_num == 0) return;

            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                double margin1 = qc1.AccountFreeMargin;
                double margin2 = qc2.AccountFreeMargin;
                string logStr;

                if(firstSecond == 1)
                {
                    logStr = "Money transfer " + amount.ToString() + " from " + qc1.User.ToString() + " (free margin = " + margin1.ToString("#,##0.00") +
                        ") to " + qc2.User.ToString() + " (free margin = " + margin2.ToString() + ")";
                }
                else
                {
                    logStr = "Money transfer " + amount.ToString() + " from " + qc2.User.ToString() + " (free margin = " + margin2.ToString("#,##0.00") +
                        ") to " + qc1.User.ToString() + " (free margin = " + margin1.ToString() + ")";
                }
                if (alertFlag) logStr = "[Alert] " + logStr;
                else logStr = "[Execution] " + logStr;

                Settings.Log.Info(logStr);

                //if (alertFlag)
                //    MessageBox.Show(logStr);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("leave log for money shift failed: " + ex.ToString());
            }
        }

        private bool is_invalid_client()
        {
            if (current_client_id < 0 || current_client_id >= tot_client_num) return true;
            return false;
        }

        public int get_live_clients_num()
        {
            int res = 0;
            for(int i = 0; i < tot_client_num; i++)
            {
                if (check_connection_both_accounts(i, false))
                    res++;
            }
            return res;
        }

        public int get_recent_order_id(int prev_order_id)
        {
            if (tot_client_num == 0) return -1;
            try
            {
                QuoteClient qc1 = qcList[2 * current_client_id];
                QuoteClient qc2 = qcList[2 * current_client_id + 1];

                var orders1 = qc1.GetOpenedOrders();
                var orders2 = qc2.GetOpenedOrders();
                int len1 = orders1.Length;
                int len2 = orders2.Length;

                DateTime recent_time = DateTime.MinValue;
                int recent_id = -1;

                for (int i = 0; i < tot_order_num_display; i++)
                {
                    if (i == prev_order_id) continue;

                    int orderId1 = R8_orderList[i];
                    int orderId2 = R3_orderList[i];

                    if(orderId1 >= 0 && orderId1 < len1)
                    {
                        DateTime open_time = orders1[orderId1].OpenTime;
                        if(open_time > recent_time)
                        {
                            recent_time = open_time;
                            recent_id = i;
                        }
                    }

                    if (orderId2 >= 0 && orderId2 < len2)
                    {
                        DateTime open_time = orders2[orderId2].OpenTime;
                        if (open_time > recent_time)
                        {
                            recent_time = open_time;
                            recent_id = i;
                        }
                    }
                }

                return recent_id;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Find recent order id failed: " + ex.ToString());
                return -1;
            }
        }

        public void get_admin_info(AdminInfo info)
        {
            if (is_invalid_client()) return;

            try
            {
                if (!check_connection_both_accounts(current_client_id, false)) return;

                QuoteClient qc1 = qcList[2 * current_client_id];
                QuoteClient qc2 = qcList[2 * current_client_id + 1];

                double PnL = 0;
                int _year = DateTime.Now.Year;
                int _month = DateTime.Now.Month;

                var orders = qc1.ClosedOrders;
                foreach (var order in orders)
                {
                    if (order.Type == Op.Balance) continue;

                    PnL += order.Profit + order.Swap;
                    info.lots += order.Lots;
                    info.swap += order.Swap;

                    if(order.CloseTime.Year == _year)
                    {
                        info.swap_year += order.Swap;
                        if (order.CloseTime.Month == _month)
                            info.swap_month += order.Swap;
                    }
                }

                orders = qc2.ClosedOrders;
                foreach (var order in orders)
                {
                    if (order.Type == Op.Balance) continue;

                    PnL += order.Profit;
                    info.lots += order.Lots;
                }

                info.commission_total = 8 * info.lots;
                info.swap_month *= info.interest / 100;
                info.swap_year *= info.interest / 100;

                if (PnL >= 0) info.profit = PnL;
                else info.loss = PnL;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get admin info failed: " + ex.ToString());
            }
        }

        public StatementInfo get_statement_info(int client_id = -1)
        {
            if (client_id < 0) client_id = current_client_id;

            StatementInfo info = new StatementInfo();
            info.Init();

            try
            {
                int year = server_time.Year;
                DateTime start_time = new DateTime(year, 1, 1);
                if (year == 2019)
                {
                    start_time = new DateTime(year, 6, 1);
                }

                //180
                info.account1 = userIdList[2 * client_id];
                QuoteClient qc = qcList[2 * client_id];
                var orders = closedOrderDict[qc.User].ToList();
                var ret_orders = orders.ToList();
                ret_orders = ret_orders.Where(s => s.CloseTime.Date >= start_time).ToList();

                foreach (var order in orders)
                {
                    if (!is_market_order(order)) continue;
                    info.closed_pnl1 += order.Profit + order.Swap + order.Commission;
                }
                info.equity1 = qc.AccountEquity;
                info.balance1 = qc.AccountBalance;
                info.margin1 = qc.AccountMargin;
                info.free_margin1 = qc.AccountFreeMargin;
                info.floting_pnl1 = info.equity1 - info.balance1;

                //130
                info.account2 = userIdList[2 * client_id + 1];
                qc = qcList[2 * client_id + 1];
                orders = closedOrderDict[qc.User].ToList();
                ret_orders = orders.ToList();
                ret_orders = ret_orders.Where(s => s.CloseTime.Date >= start_time).ToList();

                foreach (var order in orders)
                {
                    if (!is_market_order(order)) continue;
                    info.closed_pnl2 += order.Profit + order.Swap + order.Commission;
                }
                info.equity2 = qc.AccountEquity;
                info.balance2 = qc.AccountBalance;
                info.margin2 = qc.AccountMargin;
                info.free_margin2 = qc.AccountFreeMargin;
                info.floting_pnl2 = info.equity2 - info.balance2;

                info.cur_time = server_time.ToString("MM/dd/yyyy");
                info.path_time = server_time.ToString("MM-dd-yyyy HH-mm-ss");
                info.client_name = nameList[client_id];
                return info;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get statement info failed: " + ex.ToString());
            }
            return info;
        }

        public List<OrderHistory> get_closed_orders_sub(QuoteClient qc, bool is_180)
        {
            var result = new List<OrderHistory>();
            var ret_orders = new List<Order>();

            var orders = closedOrderDict[qc.User].ToList();
            ret_orders.AddRange(orders.ToList());

            int year = server_time.Year;
            DateTime start_time = new DateTime(year, 1, 1);

            ret_orders = ret_orders.Where(s => s.CloseTime.Date >= start_time).OrderByDescending(s => s.CloseTime).Where(s => s.Type != Op.Balance).ToList();

            foreach (var order in ret_orders)
            {
                if (!is_market_order(order)) continue;

                TimeSpan ts = order.CloseTime - order.OpenTime;
                int _day = count_nights_from_time(order.OpenTime, order.CloseTime);

                var _day_diff = 30 - _day;
                var comment = "";
                if (_day_diff > 0)
                {
                    comment = "FOR 30 DAYS";
                }
                else if (_day_diff < 0)
                {
                    comment = "NOW OPEN/CLOSE";
                }

                //if (_day == 0 && order.Lots == 0.01) continue;

                var nlots = Math.Round(order.Lots * _day_diff / 30, 2);

                result.Add(new OrderHistory()
                {
                    OpenTime = order.OpenTime,
                    CloseTime = order.CloseTime,
                    Lots = order.Lots,
                    comment = comment,
                    days = _day,
                    days_30 = _day_diff,
                    Lots30 = nlots,
                    is_180 = is_180,
                    pnl = order.Profit + order.Swap + order.Commission
                });
            }

            return result;
        }

        public List<OrderHistory> get_closed_order(int client_id = -1)
        {
            var result = new List<OrderHistory>();

            QuoteClient qc1;
            QuoteClient qc2;

            if (client_id == -1)
            {
                for (int i = 0; i < tot_client_num; i++)
                {
                    if (check_connection_both_accounts(i, false))
                    {
                        qc1 = qcList[2 * i];
                        qc2 = qcList[2 * i + 1];
                        try
                        {
                            //R8
                            var orders = get_closed_orders_sub(qc1, true);
                            result.AddRange(orders);
                        }
                        catch { }
                        try
                        {
                            //R3
                            var orders = get_closed_orders_sub(qc2, false);
                            result.AddRange(orders);
                        }
                        catch { }
                    }
                }
            }
            else
            {
                if (check_connection_both_accounts(client_id, false))
                {
                    qc1 = qcList[2 * client_id];
                    qc2 = qcList[2 * client_id + 1];
                    try
                    {
                        //R8
                        var orders = get_closed_orders_sub(qc1, true);
                        result.AddRange(orders);
                    }
                    catch { }
                    try
                    {
                        //R3
                        var orders = get_closed_orders_sub(qc2, false);
                        result.AddRange(orders);
                    }
                    catch { }
                }
            }

            return result;
        }

        public void get_statistics_info(StatisticsInfo info, bool order_updated)
        {
            if (is_invalid_client()) return;

            try
            {
                info.tot_clients = tot_client_num;
                info.live_clients = get_live_clients_num();

                info.commission_per_lot_R8 = 8;
                info.commission_per_lot_R3 = 8;

                QuoteClient qc1;
                QuoteClient qc2;

                double currency_ratio;

                for (int i = 0; i < tot_client_num; i++)
                {
                    if(check_connection_both_accounts(i, false))
                    {
                        qc1 = qcList[2 * i];
                        qc2 = qcList[2 * i + 1];

                        if (qc1.Account.currency == "EUR")
                            currency_ratio = EUR_ratio;
                        else
                            currency_ratio = CHF_ratio;

                        //R8
                        var orders = qc1.GetOpenedOrders();
                        foreach(var order in orders)
                        {
                            info.open_profit_R8 += (order.Profit + order.Swap) * currency_ratio;
                            info.open_lots_R8 += order.Lots;
                        }

                        //R3
                        orders = qc2.GetOpenedOrders();
                        foreach (var order in orders)
                        {
                            info.open_profit_R3 += order.Profit * currency_ratio;
                            info.open_lots_R3 += order.Lots;
                        }

                        if (order_updated)
                        {
                            DateTime from = DateTime.Now.AddDays(-32);
                            DateTime to = DateTime.Now.AddDays(1);

                            //R8
                            orders = qc1.DownloadOrderHistory(from, to);
                            foreach (var order in orders)
                            {
                                if (order.Type == Op.Balance) continue;

                                info.close_profit_R8 += (order.Profit + order.Swap) * currency_ratio;
                                info.close_lots_R8 += order.Lots;
                            }
                            info.commission_total_R8 += 8 * info.close_lots_R8;

                            //R3
                            orders = qc2.DownloadOrderHistory(from, to);
                            foreach (var order in orders)
                            {
                                if (order.Type == Op.Balance) continue;

                                info.close_profit_R3 += order.Profit * currency_ratio;
                                info.close_lots_R3 += order.Lots;
                            }
                            info.commission_total_R3 += 8 * info.close_lots_R3;
                        }
                    }
                }

                if(info.open_profit_R8 < 0)
                {
                    info.open_loss_R8 = info.open_profit_R8;
                    info.open_profit_R8 = 0;
                }

                if (info.open_profit_R3 < 0)
                {
                    info.open_loss_R3 = info.open_profit_R3;
                    info.open_profit_R3 = 0;
                }

                if (info.close_profit_R8 < 0)
                {
                    info.close_loss_R8 = info.close_profit_R8;
                    info.close_profit_R8 = 0;
                }

                if (info.close_profit_R3 < 0)
                {
                    info.close_loss_R3 = info.close_profit_R3;
                    info.close_profit_R3 = 0;
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get statistics info failed: " + ex.ToString());
            }
        }

        public double get_symbol_swap(int symbol_id)
        {
            try
            {
                string symbol = Settings.SymbolsToSubscribe[symbol_id];
                string symbol1 = symbol;
                if (symbol1 == "XTIUSD") symbol1 = "USOilCash";
                if (symbol1 == "XBRUSD") symbol1 = "UKOilCash";
                if (check_connection_both_accounts(datafeed_client_id, false))
                {
                    QuoteClient qc1 = qcList[2 * datafeed_client_id];
                    QuoteClient qc2 = qcList[2 * datafeed_client_id + 1];

                    double swap_short1 = 0;
                    double swap_long1 = 0;

                    double swap_short2 = 0;
                    double swap_long2 = 0;

                    if (qc1.Symbols.Contains(symbol1) && swapfreeFlagList[2 * datafeed_client_id] == 0)
                    {
                        SymbolInfo symbol_info = qc1.GetSymbolInfo(symbol1);
                        swap_short1 = symbol_info.SwapShort;
                        swap_long1 = symbol_info.SwapLong;
                    }

                    if (qc2.Symbols.Contains(symbol) && swapfreeFlagList[2 * datafeed_client_id + 1] == 0)
                    {
                        SymbolInfo symbol_info = qc2.GetSymbolInfo(symbol);
                        swap_short2 = symbol_info.SwapShort;
                        swap_long2 = symbol_info.SwapLong;
                    }

                    if (symbol_id >= 0)
                    {
                        if (Settings.SymbolSellAccount[symbol_id] == 0)
                        {
                            return swap_short1 + swap_long2;
                        }
                        else
                        {
                            return swap_long1 + swap_short2;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get symbol swap failed: " + ex.ToString());
            }
            return 0;
        }
        public DateTime get_end_time(DateTime current)
        {
            var endDate = current.AddMonths(1);
            var tempdate = new DateTime(endDate.Year, endDate.Month, 1);
            tempdate = tempdate.AddDays(-1);
            if (tempdate.DayOfWeek == DayOfWeek.Sunday)
                tempdate = tempdate.AddDays(-2);
            else if (tempdate.DayOfWeek == DayOfWeek.Saturday)
                tempdate = tempdate.AddDays(-1);

            return new DateTime(tempdate.Year, tempdate.Month, tempdate.Day, 18, 0, 0);
        }

        public void get_details_info(DetailsInfo info, bool order_updated, DateTime swap_start_time)
        {
            if (is_invalid_client()) return;

            var first_date = get_end_time(server_time.AddMonths(-1));
            try
            {
                info.userId1 = userIdList[2 * current_client_id];
                info.userId2 = userIdList[2 * current_client_id + 1];

                QuoteClient qc1 = qcList[2 * current_client_id];
                QuoteClient qc2 = qcList[2 * current_client_id + 1];

                if (check_connection_both_accounts(current_client_id, false))
                {
                    info.leverage1 = qc1.AccountLeverage;
                    info.leverage2 = qc2.AccountLeverage;

                    double swap_weighted_sum = 0;

                    info.tot_swap = 0;// closedOrderSwapList[2 * current_client_id] + closedOrderSwapList[2 * current_client_id + 1];

                    //Get swap of closed orders
                    if (closedOrderDict.ContainsKey(info.userId1))
                    {
                        var orders = closedOrderDict[info.userId1];
                        
                        foreach(var order in orders)
                        {
                            if (order == null)
                                continue;
                            if (!is_market_order(order))
                                continue;
                            if (order.CloseTime < swap_start_time)
                                continue;

                            if(swapfreeFlagList[2 * current_client_id] == 0)
                                info.tot_swap += order.Swap;
                        }
                    }

                    if (closedOrderDict.ContainsKey(info.userId2))
                    {
                        var orders = closedOrderDict[info.userId2];

                        foreach (var order in orders)
                        {
                            if (order == null)
                                continue;
                            if (!is_market_order(order))
                                continue;
                            if (order.CloseTime < swap_start_time)
                                continue;

                            if (swapfreeFlagList[2 * current_client_id + 1] == 0)
                                info.tot_swap += order.Swap;
                        }
                    }

                    info.reopen = closedOrderReopenList[2 * current_client_id] + closedOrderReopenList[2 * current_client_id + 1];

                    //R8
                    {
                        var orders = qc1.GetOpenedOrders();
                        foreach (var order in orders)
                        {
                            if (!is_market_order(order)) continue;

                            info.reopen += order.Lots * (count_nights_from_time(order.OpenTime, server_time) - 30);
                            info.opened_lots1 += order.Lots;

                            if (swapfreeFlagList[2 * current_client_id] == 0)
                                info.tot_swap += order.Swap;

                            string symbol_str = order.Symbol;
                            if (symbol_str == "UKOilCash") symbol_str = "XBRUSD";
                            if (symbol_str == "USOilCash") symbol_str = "XTIUSD";

                            int symbol_id = get_symbol_id(symbol_str);
                            if (symbol_id < 0)
                                continue;

                            SymbolInfo symbol_info = qc1.GetSymbolInfo(symbol_str);
                            double swap_short = symbol_info.SwapShort;
                            double swap_long = symbol_info.SwapLong;

                            if(Settings.SymbolSellAccount[symbol_id] == 0)
                                swap_weighted_sum += order.Lots * swap_short;
                            else
                                swap_weighted_sum += order.Lots * swap_long;
                        }


                        var closed_orders = closedOrderDict[qc1.User];
                        var closed_orders_market = closed_orders.Where(s => s.Type == Op.Buy || s.Type == Op.Sell).ToList();
                        var closed_orders_this_month = closed_orders_market.Where(s => s.CloseTime >= first_date).ToList();

                        var lots = info.opened_lots1 - closed_orders_this_month.Sum(s => s.Lots) ;
                        info.closed_lots1 = closed_orders_this_month.Sum(s => s.Lots);
                        info.reopen_lots1 = lots;
                    }

                    // R3
                    {
                        var orders = qc2.GetOpenedOrders();
                        foreach (var order in orders)
                        {
                            if (!is_market_order(order)) continue;

                            info.reopen += order.Lots * (count_nights_from_time(order.OpenTime, server_time) - 30);
                            info.opened_lots2 += order.Lots;

                            if (swapfreeFlagList[2 * current_client_id + 1] == 0)
                                info.tot_swap += order.Swap;

                            int symbol_id = get_symbol_id(order.Symbol);
                            if (symbol_id < 0)
                                continue;

                            SymbolInfo symbol_info = qc1.GetSymbolInfo(order.Symbol);
                            double swap_short = symbol_info.SwapShort;
                            double swap_long = symbol_info.SwapLong;

                            if (Settings.SymbolSellAccount[symbol_id] == 1)
                                swap_weighted_sum += order.Lots * swap_short;
                            else
                                swap_weighted_sum += order.Lots * swap_long;
                        }

                        var closed_orders = closedOrderDict[qc2.User];
                        var closed_orders_market = closed_orders.Where(s => s.Type == Op.Buy || s.Type == Op.Sell).ToList();
                        var closed_orders_this_month = closed_orders_market.Where(s => s.CloseTime >= first_date).ToList();

                        var lots = info.opened_lots2 - closed_orders_this_month.Sum(s => s.Lots) ;
                        info.closed_lots2 = closed_orders_this_month.Sum(s => s.Lots);
                        info.reopen_lots2 = lots;
                    }

                    double PnL = qc1.AccountProfit + qc2.AccountProfit;
                    
                    if(PnL < 0 && swap_weighted_sum > 1e-5)
                    {
                        info.breakeven = -PnL / swap_weighted_sum;
                    }

                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get details info failed: " + ex.ToString());
            }
        }

        public bool check_swapfree(int client_id, int fg)
        {
            int id = 2 * current_client_id + fg;
            if (swapfreeFlagList[id] == 1)
                return true;
            return false;
        }

        public bool check_hedge(int client_id, int fg)
        {
            int id = 2 * current_client_id + fg;
            if (hedgeFlagList[id] == 1)
                return true;
            return false;
        }

        public double get_total_swap(DateTime start_time)
        {
            if (is_invalid_client()) return 0;

            try
            {
                double result = 0;

                if (check_connection_both_accounts(current_client_id, false))
                {
                    QuoteClient qc1 = qcList[2 * current_client_id];
                    QuoteClient qc2 = qcList[2 * current_client_id + 1];

                    //lot, close
                    var orders = qc1.GetOpenedOrders();
                    foreach (var order in orders)
                    {
                        if (!is_market_order(order)) continue;
                        if(order.OpenTime >= start_time) result += order.Swap;
                    }

                    orders = qc2.GetOpenedOrders();
                    foreach (var order in orders)
                    {
                        if (!is_market_order(order)) continue;
                        if (order.OpenTime >= start_time) result += order.Swap;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get total swap failed:" + ex.ToString());
                return 0;
            }
        }

        public void get_min_max_order_price(MinMaxPriceInfo info, string symbol_str, int server_flag, double ask_price = 0)
        {
            info.minPrice = 1e9;
            info.maxPrice = -1e9;
            info.breakevenPrice = 1e9;

            try
            {
                if (check_connection_both_accounts(current_client_id, false))
                {
                    var orders = qcList[2 * current_client_id + server_flag].GetOpenedOrders();
                    foreach(var order in orders)
                    {
                        if (!is_market_order(order)) continue;

                        string str_symbol = order.Symbol;
                        if (str_symbol == "UKOilCash") str_symbol = "XBRUSD";
                        if (str_symbol == "USOilCash") str_symbol = "XTIUSD";

                        if (remove_suffix(str_symbol) == symbol_str)
                        {
                            if(info.minPrice > order.OpenPrice)
                            {
                                info.minPrice = order.OpenPrice;
                                info.minLots = order.Lots;
                            }
                            if(info.maxPrice < order.OpenPrice)
                            {
                                info.maxPrice = order.OpenPrice;
                                info.maxLots = order.Lots;
                            }

                            if(order.OpenPrice > ask_price && info.breakevenPrice > order.OpenPrice)
                            {
                                info.breakevenPrice = order.OpenPrice;
                                info.breakevenLots = order.Lots;
                            }
                        }
                    }
                    if (info.maxPrice == info.minPrice) info.maxPrice = -1e9;
                    if (info.breakevenPrice == info.minPrice || info.breakevenPrice == info.maxPrice) info.breakevenPrice = 1e9;
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get min max order price failed: " + ex.ToString());
            }
        }


        public double get_symbol_belastung(double lots)
        {
            if (lots == 0) return 0;

            if (check_connection_both_accounts(current_client_id, false))
            {
                QuoteClient qc1 = qcList[2 * current_client_id];
                QuoteClient qc2 = qcList[2 * current_client_id + 1];

                double margin1 = qc1.AccountFreeMargin;
                double margin2 = qc2.AccountFreeMargin;

                double margin = Math.Min(margin1, margin2);

                double closed_lots = 0;
                var orders = qc1.GetOpenedOrders();
                foreach(var order in orders)
                {
                    if (!is_market_order(order)) continue;
                    closed_lots += order.Lots;
                }
                if (closed_lots == 0) return 0;

                return margin / closed_lots * lots;
            }
            return 0;
        }

        public void get_client_details_dashboard(ClientDetails cd, int clientId, bool orderUpdated)
        {
            if (tot_client_num == 0) return;

            DateTime cur_time = DateTime.Now;

            var first_date = new DateTime(cur_time.Year, cur_time.Month, 1, 18, 0, 0).AddDays(-1);
            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                double d_lot1, d_pip1, d_transfer1, d_lot1_pending, d_pip1_pending, equity1;
                double d_lot2, d_pip2, d_transfer2, d_lot2_pending, d_pip2_pending, equity2;
                double d_close1, d_close2;
                //double d_closemonth1, d_closemonth2;
                string curr1, curr2;

                double freemargin1, freemargin2;
                double pnl1, pnl2;
                double balance1, balance2;

                int shiftat = 0;

                d_lot1 = d_lot2 = 0;
                d_pip1 = d_pip2 = 0;
                d_close1 = d_close2 = 0;
                d_lot1_pending = d_lot2_pending = 0;
                d_pip1_pending = d_pip2_pending = 0;

                //d_closemonth1 = d_closemonth2 = 0;
                d_transfer1 = d_transfer2 = 0;
                curr1 = "";
                curr2 = "";
                freemargin1 = freemargin2 = 0;
                balance1 = balance2 = 0;
                pnl1 = pnl2 = 0;
                equity1 = equity2 = 0;

                if (check_connection_both_accounts(clientId, false))
                {
                    try
                    {
                        //lot, close
                        {
                            var orders = qc1.GetOpenedOrders();
                            foreach (var order in orders)
                            {
                                if (order.Type == Op.Buy || order.Type == Op.Sell) d_lot1 += order.Lots;
                                else d_lot1_pending += order.Lots;
                            }

                            if (closedOrderDict != null && closedOrderDict.ContainsKey(qc1.User))
                            {
                                var closed_orders = closedOrderDict[qc1.User];
                                var closed_orders_market = closed_orders.Where(s => s.Type == Op.Buy || s.Type == Op.Sell).ToList();
                                var closed_orders_this_month = closed_orders_market.Where(s => s.CloseTime >= first_date && s.Type != Op.Balance).ToList();

                                d_close1 = d_lot1 - closed_orders_this_month.Sum(s => s.Lots);
                            }
                        }

                        {
                            var orders = qc2.GetOpenedOrders();
                            foreach (var order in orders)
                            {
                                if (order.Type == Op.Buy || order.Type == Op.Sell) d_lot2 += order.Lots;
                                else d_lot2_pending += order.Lots;
                            }

                            if (closedOrderDict != null && closedOrderDict.ContainsKey(qc2.User))
                            {
                                var closed_orders = closedOrderDict[qc2.User];
                                var closed_orders_market = closed_orders.Where(s => s.Type == Op.Buy || s.Type == Op.Sell).ToList();
                                var closed_orders_this_month = closed_orders_market.Where(s => s.CloseTime >= first_date && s.Type != Op.Balance).ToList();

                                d_close2 = d_lot2 - closed_orders_this_month.Sum(s => s.Lots);
                            }
                        }
                    }
                    catch (Exception) { }

                    d_lot1_pending = d_lot2_pending;

                    freemargin1 = qc1.AccountFreeMargin;
                    freemargin2 = qc2.AccountFreeMargin;

                    equity1 = qc1.AccountEquity;
                    equity2 = qc2.AccountEquity;

                    double margin1 = qc1.AccountMargin;
                    double margin2 = qc2.AccountMargin;

                    freemargin1 += margin1 * (100 - stopLevelList[2 * clientId]) / 100.0;
                    freemargin2 += margin2 * (100 - stopLevelList[2 * clientId + 1]) / 100.0;

                    //margin
                    if (d_lot1 > 0) d_pip1 = freemargin1 / 10 / d_lot1;
                    if (d_lot2 > 0) d_pip2 = freemargin2 / 10 / d_lot2;

                    if (d_lot1 + d_lot1_pending > 0) d_pip1_pending = freemargin1 / 10 / (d_lot1 + d_lot1_pending);
                    if (d_lot2 + d_lot2_pending > 0) d_pip2_pending = freemargin2 / 10 / (d_lot2 + d_lot2_pending);

                    //transfer
                    if (freemargin1 > freemargin2)
                    {
                        d_transfer1 = (freemargin1 - freemargin2) / 2;
                    }
                    else
                    {
                        d_transfer2 = -(freemargin1 - freemargin2) / 2;
                    }

                    curr1 = qc1.Account.currency;
                    curr2 = qc2.Account.currency;

                    balance1 = qc1.AccountBalance;
                    balance2 = qc2.AccountBalance;

                    pnl1 = qc1.AccountProfit;
                    pnl2 = qc2.AccountProfit;
                }

                if (d_pip1 > 0 && d_pip2 > 0)
                {
                    double min_val = Math.Min(d_pip1, d_pip2);
                    double diff = Math.Abs(d_pip1 - d_pip2);

                    shiftat = (int)(diff / min_val * 100);
                }

                cd.name = nameList[clientId];
                cd.userId1 = userIdList[2 * clientId].ToString();
                cd.curr1 = curr1;
                cd.lot1 = d_lot1.ToString("#,##0.00");
                cd.pip1 = d_pip1.ToString("#,##0.00");
                cd.margin1 = freemargin1.ToString("#,##0.00");
                cd.transfer1 = (d_transfer1 > 0) ? d_transfer1.ToString("#,##0.00") : "";
                cd.balance1 = balance1.ToString("#,##0.00");
                cd.pnl1 = pnl1.ToString("#,##0.00");
                cd.shiftat1 = shiftat.ToString();
                cd.close1 = d_close1.ToString("#,##0.00");
                cd.equity1 = equity1.ToString("#,##0.00");
                cd.lot1_pending = d_lot1_pending.ToString("#,##0.00");
                cd.pip1_pending = d_pip1_pending.ToString("#,##0.00");

                cd.userId2 = userIdList[2 * clientId + 1].ToString();
                cd.curr2 = curr2;
                cd.lot2 = d_lot2.ToString("#,##0.00");
                cd.pip2 = d_pip2.ToString("#,##0.00");
                cd.margin2 = freemargin2.ToString("#,##0.00");
                cd.transfer2 = (d_transfer2 > 0) ? d_transfer2.ToString("#,##0.00") : "";
                cd.balance2 = balance2.ToString("#,##0.00");
                cd.pnl2 = pnl2.ToString("#,##0.00");
                cd.close2 = d_close2.ToString("#,##0.00");
                cd.equity2 = equity2.ToString("#,##0.00");
                cd.lot2_pending = d_lot2_pending.ToString("#,##0.00");
                cd.pip2_pending = d_pip2_pending.ToString("#,##0.00");

                cd.is_pending = isPendingList[clientId];
                if (moneyShiftFlagList[clientId] == 0) cd.money_shift_on = false;
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get client details(dashboard) failed: " + ex.ToString());
            }

        }

        public void get_client_details_pamm(ClientDetails cd, int clientId, bool is_master, double lots, bool order_updated = false)
        {
            if (tot_client_num == 0) return;
            try
            {
                QuoteClient qc1 = qcList[2 * clientId];
                QuoteClient qc2 = qcList[2 * clientId + 1];

                double lot1, lot2;
                double pip1, pip2;
                double freemargin1, freemargin2;
                double minmargin, percent, lotpercent;
                bool firstFlag;
                string curr1, curr2;

                lot1 = lot2 = 0;
                pip1 = pip2 = 0;

                curr1 = "";
                curr2 = "";
                freemargin1 = freemargin2 = 0;

                firstFlag = true;

                minmargin = percent = lotpercent = 0;

                if (check_connection_both_accounts(clientId, false))
                {
                    //lot
                    var orders = qc1.GetOpenedOrders();
                    foreach (var order in orders)
                    {
                        if(is_market_order(order))
                            lot1 += order.Lots;
                    }

                    orders = qc2.GetOpenedOrders();
                    foreach (var order in orders)
                    {
                        if(is_market_order(order))
                            lot2 += order.Lots;
                    }

                    //margin
                    if (lot1 > 0) pip1 = qc1.AccountFreeMargin / 10 / lot1;
                    if (lot2 > 0) pip2 = qc2.AccountFreeMargin / 10 / lot2;

                    curr1 = qc1.Account.currency;
                    curr2 = qc2.Account.currency;

                    freemargin1 = qc1.AccountFreeMargin;
                    freemargin2 = qc2.AccountFreeMargin;

                    if(is_master)
                    {
                        if (freemargin1 < freemargin2)
                        {
                            minmargin = freemargin1;
                            percent = 100;
                        }
                        else
                        {
                            firstFlag = false;
                            minmargin = freemargin2;
                            percent = 100;
                        }
                    }
                    else
                    {
                        if (check_connection_both_accounts(master_client_id, false))
                        {
                            QuoteClient master_qc1 = qcList[2 * master_client_id];
                            QuoteClient master_qc2 = qcList[2 * master_client_id + 1];

                            double master_min = Math.Min(master_qc1.AccountFreeMargin, master_qc2.AccountFreeMargin);

                            if(master_min > 0)
                            {
                                if (freemargin1 < freemargin2)
                                {
                                    minmargin = freemargin1;
                                }
                                else
                                {
                                    firstFlag = false;
                                    minmargin = freemargin2;
                                }
                                percent = minmargin / master_min * 100;
                                lotpercent = lots * minmargin / master_min;
                            }
                        }
                    }
                }


                cd.name = nameList[clientId];
                cd.userId1 = userIdList[2 * clientId].ToString();
                cd.curr1 = curr1;
                cd.lot1 = lot1.ToString("#,##0.00");
                cd.pip1 = pip1.ToString("#,##0.00");
                cd.margin1 = freemargin1.ToString("#,##0.00");
                cd.load1 = "";
                cd.percent1 = "";
                cd.slave_percent1 = "";
                cd.userId2 = userIdList[2 * clientId + 1].ToString();
                cd.curr2 = curr2;
                cd.lot2 = lot2.ToString("#,##0.00");
                cd.pip2 = pip2.ToString("#,##0.00");
                cd.margin2 = freemargin2.ToString("#,##0.00");
                cd.load2 = "";
                cd.percent2 = "";
                cd.slave_percent2 = "";

                if(firstFlag)
                {
                    cd.load1 = minmargin.ToString("#,##0.00");
                    cd.percent1 = percent.ToString("#,##0.00");
                }
                else
                {
                    cd.load2 = minmargin.ToString("#,##0.00");
                    cd.percent2 = percent.ToString("#,##0.00");
                }

                if (is_master == true) //master account
                {
                    cd.slave_percent1 = "ECN";
                    cd.slave_percent2 = "SWAP FREE";
                }
                else
                {
                    if (firstFlag)
                    {
                        cd.slave_percent1 = lotpercent.ToString("#,##0.00");
                    }
                    else
                    {
                        cd.slave_percent2 = lotpercent.ToString("#,##0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Get client details(pamm) failed: " + ex.ToString());
            }

        }

        public void check_free_pip_notification()
        {
            try
            {
                for (int i = 0; i < tot_client_num; i++)
                {
                    if (!check_connection_both_accounts(i, false)) continue;

                    double free_pip_min = get_free_pip_min(i);

                    if (free_pip_min >= get_pip_notification_amount(i))
                    {
                        freePipFlagList[i] = false;
                    }
                    else if (!freePipFlagList[i])
                    {
                        freePipFlagList[i] = true;

                        TimeSpan ts = DateTime.Now - freePipLastTime[i];
                        if (ts.TotalMinutes >= 5)
                        {
                            freePipLastTime[i] = DateTime.Now;
                            send_sms_free_pip(i, free_pip_min);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("check margin call failed: " + ex.ToString());
            }
        }

        public void send_sms_free_pip(int client_id, double free_pip)
        {
            SendSMS sms = new SendSMS();

            SMSParam param = new SMSParam();
            param.message = "Free Pip Notification: " + nameList[client_id] + "(" + userIdList[2 * client_id].ToString() + ", " + userIdList[2 * client_id + 1].ToString() + ") " + free_pip.ToString("#,##0.00") + " pips";
            param.toPhone = "+" + phoneNumberList[client_id];

            Thread th = new Thread(sms.send_sms);
            th.IsBackground = true;
            th.Start(param);
        }

        public void send_sms_price_alert(string alert_str)
        {
            if (tot_client_num == 0) return;

            SendSMS sms = new SendSMS();
            SMSParam param = new SMSParam();
            param.message = alert_str;
            param.toPhone = "+" + phoneNumberList[0];

            Thread th = new Thread(sms.send_sms);
            th.IsBackground = true;
            th.Start(param);
        }

        public void disconnect_all_clients()
        {
            try
            {
                for (int k = 0; k < tot_client_num; k++)
                {
                    QuoteClient qc1 = qcList[2 * k];
                    QuoteClient qc2 = qcList[2 * k + 1];

                    qc1.Disconnect();
                    qc2.Disconnect();
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Disconnect all clients failed: " + ex.ToString());
            }
        }

        public void unsubscribe_all_clients()
        {
            try
            {
                for (int k = 0; k < tot_client_num; k++)
                {
                    if (connectionList[2 * k] > 0)
                    {
                        QuoteClient qc1 = qcList[2 * k];
                        for (int i = 0; i < Settings.symbol_num; i++)
                        {
                            string symbol = Settings.SymbolsToSubscribe[i];
                            if (symbol == "XTIUSD") symbol = "USOilCash";
                            if (symbol == "XBRUSD") symbol = "UKOilCash";
                            if (qc1.IsSubscribed(symbol))
                                qc1.Unsubscribe(symbol);
                        }
                    }

                    if (connectionList[2 * k + 1] > 0)
                    {
                        QuoteClient qc2 = qcList[2 * k + 1];

                        for (int i = 0; i < Settings.symbol_num; i++)
                        {                            
                            if (qc2.IsSubscribed(Settings.SymbolsToSubscribe[i]))
                                qc2.Unsubscribe(Settings.SymbolsToSubscribe[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Unsubscribe all clients failed: " + ex.ToString());
            }
        }

        public void set_datafeed_client()
        {
            if (tot_client_num == 0 || isExit) return;
            try
            {
                if (datafeed_client_id >= tot_client_num) datafeed_client_id = 0;
                if (datafeed_client_id >= 0 && check_connection_both_accounts(datafeed_client_id, false)) return;

                //subscribe
                for (int i = 0; i < tot_client_num; i++)
                {
                    if(check_connection_both_accounts(i, false))
                    {
                        qc1 = qcList[2 * i];
                        foreach (var s in Settings.SymbolsToSubscribe)
                        {
                            string symbol = s;
                            if (symbol == "XTIUSD") symbol = "USOilCash";
                            if (symbol == "XBRUSD") symbol = "UKOilCash";
                            if (qc1.Symbols.Contains(symbol))
                                qc1.Subscribe(symbol);
                        }

                        qc2 = qcList[2 * i + 1];
                        foreach (var s in Settings.SymbolsToSubscribe)
                        {                            
                            if (qc2.Symbols.Contains(s))
                                qc2.Subscribe(s);
                        }

                        datafeed_client_id = i;
                        break;
                    }
                }
                //unsubscribe_all_clients();
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Subscribe Error: " + ex.ToString());
            }
        }

        public void AlertSound()
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "alarm.wav");
                //play a sound
                Thread.Sleep(100);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AlertSpread()
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "alert-spread.wav");
                //play a sound
                Thread.Sleep(300);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AlertSoundAndMessage(string message)
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "alarm.wav");
                //play a sound
                Thread.Sleep(100);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //MessageBox.Show(message);

            MainFrm.mainFrm.update_warning_label(message);
        }

        public bool get_pamm_setting()
        {
            if (tot_client_num == 0) return false;
            if (pammList[current_client_id] == 1) return true;
            return false;
        }

        public bool get_moneyshift_setting()
        {
            if (tot_client_num == 0) return false;
            if (moneyShiftFlagList[current_client_id] == 1) return true;
            return false;
        }

        public int get_moneyshift_limit(int client_id = -1)
        {
            if (tot_client_num == 0) return 0;
            if(client_id < 0)
                return moneyShiftLimitList[current_client_id];
            return moneyShiftLimitList[client_id];
        }

        public double get_pip_notification_amount(int client_id)
        {
            if (tot_client_num == 0) return 0;
            return freePipAmountList[client_id];
        }

        public double get_margin_alert_amount(int client_id = -1)
        {
            try
            {
                if (tot_client_num == 0) return 0;
                if (client_id < 0)
                    return marginAlertAmountList[current_client_id];
                return marginAlertAmountList[client_id];
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Get margin alert failed:" + ex.ToString());
                return 0;
            }
        }

        public double get_margin_call_amount(int client_id = -1)
        {
            if (client_id < 0 && current_client_id < 0) return 0;
            if (tot_client_num == 0) return 0;

            if(client_id < 0)
                return marginCallAmountList[current_client_id];
            return marginCallAmountList[client_id];
        }

        public double get_notification_amount(int client_id = -1)
        {
            if (client_id < 0 && current_client_id < 0) return 0;
            if (tot_client_num == 0) return 0;

            if (client_id < 0)
                return freePipAmountList[current_client_id];
            return freePipAmountList[client_id];
        }

        public string get_phone_number(int client_id = -1)
        {
            if (client_id < 0 && current_client_id < 0) return "";
            if (tot_client_num == 0) return "";

            if (client_id < 0)
                return phoneNumberList[current_client_id];
            return phoneNumberList[client_id];
        }

        public bool set_moneyshift_setting(bool val)
        {
            if (tot_client_num == 0) return false;
            if (val)
                moneyShiftFlagList[current_client_id] = 1;
            else
                moneyShiftFlagList[current_client_id] = 0;
            return true;
        }

        public bool set_pamm_setting(bool val, int client_id = -1)
        {
            if (tot_client_num == 0) return false;

            if (client_id < 0) client_id = current_client_id;
            if (val)
                pammList[client_id] = 1;
            else
                pammList[client_id] = 0;
            return true;
        }

        public bool set_moneyshift_amount(string str)
        {
            if (tot_client_num == 0) return false;

            int val = 0;
            Int32.TryParse(str, out val);
            moneyShiftLimitList[current_client_id] = val;
            return true;
        }

        public bool set_margin_alert_amount(string str)
        {
            if (tot_client_num == 0) return false;

            double val = 0;
            Double.TryParse(str, out val);
            marginAlertAmountList[current_client_id] = val;
            return true;
        }

        public bool set_margin_call_amount(string str)
        {
            if (tot_client_num == 0) return false;

            double val = 0;
            Double.TryParse(str, out val);
            marginCallAmountList[current_client_id] = val;
            return true;
        }

        public bool set_notification_amount(string str)
        {
            if (tot_client_num == 0) return false;

            double val = 0;
            Double.TryParse(str, out val);
            freePipAmountList[current_client_id] = val;
            return true;
        }

        public bool set_phone_number(string str)
        {
            if (tot_client_num == 0) return false;
            phoneNumberList[current_client_id] = str;
            return true;
        }

        public bool check_money_shift_flag(int id)
        {
            if (moneyShiftFlagList[id] == 1) return true;
            return false;
        }

        public int check_is_pending(int id)
        {
            return isPendingList[id];
        }

        public void set_is_pending(int id, int val)
        {
            isPendingList[id] = val;
        }

        public bool is_live_account(int id)
        {
            if (id >= tot_client_num) return false;
            QuoteClient qc1 = qcList[2 * id];
            QuoteClient qc2 = qcList[2 * id + 1];

            if (qc1.AccountType != AccountType.Real || qc2.AccountType != AccountType.Real)
                return false;
            return true;
        }

        public bool get_money_shift_param(MoneyShiftParam param, int id, int amount, int first_second)
        {
            if (!is_live_account(id)) return false;
            param.email = emailList[id];
            param.password = emailPasswordList[id];

            param.src_id = userIdList[2 * id + first_second - 1].ToString();
            param.des_id = userIdList[2 * id + 2 - first_second].ToString();

            param.amount = amount;
            param.client_id = id;

            return true;
        }
    }
}
