using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public class MoneyShiftParam
    {
        public string email;
        public string password;
        public string src_id;
        public string des_id;
        public int amount;
        public int client_id;
    }

    public class Result
    {
        public Result(bool _suc, string _msg = "")
        {
            success = _suc;
            msg = _msg;
        }

        public override string ToString()
        {
            return $"{msg} ({success.ToString()})";
        }

        public bool success;
        public string msg;
    }
}
