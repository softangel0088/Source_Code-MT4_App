using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FXFellowDashboard
{
    class PriceAlert
    {
        public List<double>[] symbolAlertPriceList;
        public List<double>[] symbolPrevPriceList;
        public List<int>[] symbolAlertCountList;

        bool is_changing;

        public void Init()
        {
            int symbol_num = Settings.symbol_num;

            symbolAlertPriceList = new List<double>[symbol_num];
            symbolPrevPriceList = new List<double>[symbol_num];
            symbolAlertCountList = new List<int>[symbol_num];

            for (int i = 0; i < symbol_num; i++)
            {
                symbolAlertPriceList[i] = new List<double>();
                symbolPrevPriceList[i] = new List<double>();
                symbolAlertCountList[i] = new List<int>();
            }

            is_changing = false;
        }

        public void add_price(int symbol_id, double price)
        {
            while (is_changing) Thread.Sleep(1);

            is_changing = true;
            symbolAlertPriceList[symbol_id].Add(price);
            symbolPrevPriceList[symbol_id].Add(-1);
            symbolAlertCountList[symbol_id].Add(5);
            is_changing = false;
        }

        public void remove_price(int symbol_id, double price)
        {
            while(is_changing) Thread.Sleep(1);

            try
            {
                double threshold = Settings.SymbolsPoint[symbol_id] * 100;

                int remove_id = -1;
                double minDiff = 1e9;

                is_changing = true;
                int len = symbolAlertPriceList[symbol_id].Count;
                for (int i = 0; i < len; i++)
                {
                    double alert_price = symbolAlertPriceList[symbol_id][i];
                    double diff = Math.Abs(alert_price - price);
                    if (diff < threshold)
                    {
                        if (diff < minDiff)
                        {
                            minDiff = diff;
                            remove_id = i;
                        }
                    }
                }
                remove_alert_list(symbol_id, remove_id);
                is_changing = false;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Remove price alert failed: " + ex.ToString());
            }
        }

        private void remove_alert_list(int symbol_id, int remove_id)
        {
            if (remove_id < 0) return;
            symbolAlertPriceList[symbol_id].RemoveAt(remove_id);
            symbolPrevPriceList[symbol_id].RemoveAt(remove_id);
            symbolAlertCountList[symbol_id].RemoveAt(remove_id);
        }

        public bool check_alert_price(int symbol_id, double price)
        {
            while (is_changing) Thread.Sleep(1);

            bool is_crossed = false;
            int len = symbolAlertPriceList[symbol_id].Count;
            double _point = Settings.SymbolsPoint[symbol_id];

            is_changing = true;
            for(int i = len - 1; i >= 0; i--)
            {
                bool crossed = false;
                if(symbolPrevPriceList[symbol_id][i] > 0)
                {
                    if (symbolPrevPriceList[symbol_id][i] > symbolAlertPriceList[symbol_id][i] && price < symbolAlertPriceList[symbol_id][i]) crossed = true;
                    if (symbolPrevPriceList[symbol_id][i] < symbolAlertPriceList[symbol_id][i] && price > symbolAlertPriceList[symbol_id][i]) crossed = true;
                }
                symbolPrevPriceList[symbol_id][i] = price;

                if(crossed)
                {
                    is_crossed = true;
                    symbolAlertCountList[symbol_id][i]--;
                    if(symbolAlertCountList[symbol_id][i] == 0)
                    {
                        remove_alert_list(symbol_id, i);
                    }
                }
            }
            is_changing = false;
            return is_crossed;
        }
    }
}
