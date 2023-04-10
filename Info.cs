using MTClientAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public class MarginCallInfo
    {
        int user_id = 0;
        int ticket = 0;

        public MarginCallInfo(int _user_id, int _ticket)
        {
            user_id = _user_id;
            ticket = _ticket;
        }

        public bool SameInfo(MarginCallInfo info)
        {
            return info.user_id == user_id && info.ticket == ticket;
        }
    }

    public class LoginParam
    {
        public int id;
        public int userId1;
        public int userId2;
        public string password1;
        public string password2;
        public string server_name1;
        public string server_name2;
        public int server_index1;
        public int server_index2;
    }

    public class ClientInfo
    {
        public QuoteClient qc1;
        public QuoteClient qc2;
        public OrderClient oc1;
        public OrderClient oc2;
        public int clientId;
        public string name;
        public int userId1;
        public int userId2;
        public string password1;
        public string password2;
        public string email;
        public string emailPassword;
        public string currency1;
        public string currency2;
        public int connection1;
        public int connection2;
        public int moneyShiftFlag;
        public int moneyShiftAmount;
        public int pamm;
        public double margin_alert_amount;
        public double margin_call_amount;
        public double free_pip_amount;
        public string phone_number;
        public int is_pending;
        public bool margin_alert_flag;
        public bool margin_call_flag;
        public string server_name1;
        public string server_name2;
        public int server_index1;
        public int server_index2;
        public int swapfree_flag1;
        public int swapfree_flag2;
        public int hedge_flag1;
        public int hedge_flag2;

        public double stop_level1;
        public double stop_level2;

        int default_money_shift_amount = 10;

        public void Init()
        {
            clientId = 0;
            userId1 = userId2 = 0;
            currency1 = currency2 = "";
            connection1 = connection2 = 0;
            moneyShiftFlag = 0;
            moneyShiftAmount = default_money_shift_amount;
            pamm = 1;
            margin_alert_amount = 30;
            margin_call_amount = 5;
            is_pending = 0;
            margin_alert_flag = false;
            margin_call_flag = false;
            server_name1 = server_name2 = "";

            swapfree_flag1 = 0;
            swapfree_flag2 = 0;
            hedge_flag1 = 0;
            hedge_flag2 = 0;

            stop_level1 = 0;
            stop_level2 = 0;

            server_index1 = -1;
            server_index2 = -1;
        }

        public bool is_valid()
        {
            if (userId1 == 180 || userId2 == 130) return false;
            return true;
        }
    }

    public class DetailsInfo
    {
        public int userId1;
        public int userId2;
        public int leverage1;
        public int leverage2;
        public double tot_swap;
        public double month_swap;
        public double reopen;
        public double opened_lots1;
        public double opened_lots2;
        public double closed_lots1;
        public double closed_lots2;
        public double reopen_lots1;
        public double reopen_lots2;
        public double breakeven;

        public void Init()
        {
            userId1 = userId2 = 0;
            leverage1 = leverage2 = 0;
            tot_swap = month_swap = 0;
            reopen = 0;
            opened_lots1 = opened_lots2 = 0;
            closed_lots1 = closed_lots2 = 0;
            reopen_lots1 = reopen_lots2 = 0;
            breakeven = 0;
        }
    }

    public class AdminInfo
    {
        public double profit;
        public double loss;
        public double swap;
        public double swap_month;
        public double swap_year;
        public double lots;
        public double commission_total;
        public double interest;

        public void Init()
        {
            profit = loss = 0;
            lots = 0;
            commission_total = 0;
            interest = 0;
            swap_month = swap_year = swap = 0;
        }
    }

    public class LicenseInfo
    {
        public string number;
        public string date;

        public void Init()
        {
            number = "000-000-000";
            date = "01/01/1970";
        }
    }

    public class StatisticsInfo
    {
        public int tot_clients;
        public int live_clients;
        public double open_profit_R3;
        public double open_loss_R3;
        public double open_lots_R3;
        public double close_profit_R3;
        public double close_loss_R3;
        public double close_lots_R3;
        public double commission_per_lot_R3;
        public double commission_total_R3;
        public double open_profit_R8;
        public double open_loss_R8;
        public double open_lots_R8;
        public double close_profit_R8;
        public double close_loss_R8;
        public double close_lots_R8;
        public double commission_per_lot_R8;
        public double commission_total_R8;

        public void Init()
        {
            tot_clients = live_clients = 0;
            open_profit_R3 = open_loss_R3 = open_lots_R3 = 0;
            close_profit_R3 = close_loss_R3 = close_lots_R3 = 0;
            commission_per_lot_R3 = commission_total_R3 = 0;
            open_profit_R8 = open_loss_R8 = open_lots_R8 = 0;
            close_profit_R8 = close_loss_R8 = close_lots_R8 = 0;
            commission_per_lot_R8 = commission_total_R8 = 0;
        }
    }

    public class ClientDetails
    {
        public string name;
        public string userId1, userId2;
        public string curr1, curr2;
        public string lot1, lot2;
        public string pip1, pip2;
        public string margin1, margin2;
        public string transfer1, transfer2;
        public string balance1, balance2;
        public string pnl1, pnl2;
        public string shiftat1, shiftat2;
        public string close1, close2;
        public string load1, load2;
        public string percent1, percent2;
        public string slave_percent1, slave_percent2;
        public string equity1, equity2;
        public string lot1_pending, lot2_pending;
        public string pip1_pending, pip2_pending;

        public int is_pending; //0:none, 1:first, 2:second
        public bool money_shift_on;

        public void Init()
        {
            name = "";
            userId1 = userId2 = "";
            curr1 = curr2 = "";
            lot1 = lot2 = "";
            pip1 = pip2 = "";
            margin1 = margin2 = "";
            transfer1 = transfer2 = "";
            balance1 = balance2 = "";
            pnl1 = pnl2 = "";
            shiftat1 = shiftat2 = "";
            close1 = close2 = "";
            load1 = load2 = "";
            percent1 = percent2 = "";
            slave_percent1 = slave_percent2 = "";
            equity1 = equity2 = "";
            lot1_pending = lot2_pending = "";
            pip1_pending = pip2_pending = "";

            is_pending = 0;
            money_shift_on = true;
        }
    }

    public class OrderDetails
    {
        public string userId1, userId2;
        public string symbol1, symbol2;
        public string lot1, lot2;
        public string active1, active2;
        public string swap1, swap2;
        public string pnl1, pnl2;
        public string sl_tp1, sl_tp2;
        public string commission1, commission2;
        public string spread1, spread2;
        public bool isPending;

        public void Init()
        {
            userId1 = userId2 = "";
            symbol1 = symbol2 = "";
            lot1 = lot2 = "";
            active1 = active2 = "";
            sl_tp1 = sl_tp2 = "";
            swap1 = swap2 = "";
            pnl1 = pnl2 = "";
            commission1 = commission2 = "";
            spread1 = spread2 = "";
            isPending = false;
        }
    }

    public class OrderHistory
    {
        public double Lots { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int days { get; set; }
        public int days_30 { get; set; }
        public double Lots30 { get; set; }
        public string comment { get; set; }
        public bool is_180;
        public double pnl;
    }
}
