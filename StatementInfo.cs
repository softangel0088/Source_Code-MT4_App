using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public class StatementInfo
    {
        public int account1;
        public double closed_pnl1;
        public double balance1;
        public double floting_pnl1;
        public double margin1;
        public double free_margin1;
        public double equity1;

        public int account2;
        public double closed_pnl2;
        public double balance2;
        public double floting_pnl2;
        public double margin2;
        public double free_margin2;
        public double equity2;

        public string client_name;
        public string cur_time;
        public string path_time;

        public void Init()
        {
            account1 = 0;
            closed_pnl1 = 0;
            balance1 = 0;
            floting_pnl1 = 0;
            margin1 = 0;
            free_margin1 = 0;
            equity1 = 0;

            account2 = 0;
            closed_pnl2 = 0;
            balance2 = 0;
            floting_pnl2 = 0;
            margin2 = 0;
            free_margin2 = 0;
            equity2 = 0;

            cur_time = "";
        }
    }
}
