using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public class Utils
    {
        public static bool CheckRealIP(string host)
        {
            int count = Regex.Matches(host, @"[a-zA-Z]").Count;

            return count == 0;
        }
    }
}
