using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FXFellowDashboard
{
    public class ControlPage
    {
        public int display_num;
        public int current_page;
        public int tot_num;
        public int tot_page;

        public void Init()
        {
            display_num = 30;
            current_page = 1;
            tot_page = 1;
        }

        public string update_current_state()
        {
            tot_page = (int)Math.Ceiling(1.0 * tot_num / display_num);
            if (current_page > tot_page) current_page = tot_page;

            tot_page = Math.Max(tot_page, 1);
            current_page = Math.Max(current_page, 1);

            string resStr = current_page.ToString() + " / " + tot_page.ToString();

            return resStr;
        }

        public void start_click()
        {
            if (current_page == 1) return;
            current_page = 1;
        }

        public void end_click()
        {
            if (display_num * current_page >= tot_num)
                return;
            current_page = (int)Math.Ceiling((double)tot_num / display_num);
            current_page = Math.Max(current_page, 1);
        }

        public void prev_click()
        {
            if (current_page == 1) return;
            current_page--;
        }

        public void next_click()
        {
            if (display_num * current_page >= tot_num) return;
            current_page++;
        }

        public int get_overall_id(int control_id)
        {
            int overall_id = display_num * (current_page - 1) + control_id;
            if (overall_id >= tot_num) return -1;
            return overall_id;
        }
    }
}
