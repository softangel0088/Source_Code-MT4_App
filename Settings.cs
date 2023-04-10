using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public class Settings
    {
        public static int symbol_num = 8;
        public static string[] SymbolsToSubscribe = new string[] { "USDMXN", "GBPMXN", "EURMXN", "EURZAR", "GBPZAR", "EURUSD", "XBRUSD", "XTIUSD" };

        public static double[] SwapSpreadRatio = new double[] { 1, 1, 1, 1, 1, 1, 1, 1 };
        public static double[] SymbolsSpread1 = new double[] { 18, 18, 18, 18, 18, 18, 18, 18 };
        public static double[] SymbolsSpread2 = new double[] { 20, 20, 20, 20, 20, 20, 20, 20 };
        public static double[] SymbolsPoint = new double[] { 0.00001, 0.00001, 0.00001, 0.00001, 0.00001, 0.00001, 0.00001, 0.00001 };
        public static int[] SymbolsDigit = new int[] { 5, 5, 5, 5, 5, 5, 5, 5 };

        public static int[] SymbolSellAccount = new int[] { 0, 0, 0, 0, 0, 0, 1, 1 };

        public static int current_candle_num = 50;
        public static int max_candle_num = 300;
        public static int min_candle_num = 20;

        public static Color[] sep_colors = new Color[3] { Color.Tomato, Color.Violet, Color.SeaGreen };

        public static String dbFile = "app.db";

        public static double[][] pip_base_symbol = new double[3][];

        public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static int scrollGap = 30;

        //Page Parameters
        public static int[] displayNumList = new int[] { 30, 20 };
        public static int max_control_num = 30;

        public static int max_money_transfer = 26000;

        // Try 3 times in case of failure
        public static int max_order_try_num = 2;

        public static int margin_call_price_difference_threshold_point = 100;

        public static int update_time_limit = 1000; //millisecond
        public static int relogin_time_limit = 5; //second

        public static int money_shift_wait_time = 10; //second
        public static int money_shift_login_time_period = 5; //second
        public static int money_shift_once_num = 1;

        public static int balance_alert_ratio = 10;

        public static string[] Months = new string[] { "", "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
        public static string[] datetime_formats = { "dd/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "d/MM/yyyy", "dd/MM/yy", "dd/M/yy", "d/M/yy", "d/MM/yy" };

        public static bool show_pending_order = false;

        public static bool broker_mode = true;
        public static bool vps_server = true;
        public static int version_num = 2;
        public static int release_num = 18;

        public static void Init()
        {
            //init pip value
            pip_base_symbol[0] = new double[] { 8.93, 9.18, 8.45, 1.62 }; //EUR
            pip_base_symbol[1] = new double[] { 9.73, 10, 9.20, 1.77 }; //CHF
            pip_base_symbol[2] = new double[] { 10, 10.28, 9.46, 1.82 }; //USD
        }
    }
}
