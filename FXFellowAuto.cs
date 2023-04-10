using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    class FXFellowAuto
    {
        public static async Task<Result> auto_settle(MoneyShiftParam param)
        {
            if (param.amount <= 0)
                return new Result(false, "Amount must be positive");

            Google google = new Google(param);
            var res = await google.workflow();
            google.close();
            return res;
        }
    }
}
