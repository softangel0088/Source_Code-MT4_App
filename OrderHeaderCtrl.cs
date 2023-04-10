using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FXFellowDashboard
{
    public partial class OrderHeaderCtrl : UserControl
    {
        public EventHandler m_header_click_handle;

        public OrderHeaderCtrl()
        {
            InitializeComponent();
        }

        private void set_header_click_handle(Headers header)
        {
            if (m_header_click_handle != null)
            {
                CustomArgs arg = new CustomArgs();
                arg.idx = header;

                m_header_click_handle(this, arg);
            }
        }

        private void lab_account_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.Account);
        }

        private void lab_currency_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.Currency);
        }

        private void lab_lot_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.Lot);
        }

        private void lab_active_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.Active);
        }

        private void lab_closed_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.Spread);
        }

        private void lab_swap_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.Swap);
        }

        private void lab_PnL_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.PnL);
        }

        private void lab_closeat_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.CloseAt);
        }

        private void lab_commission_Click(object sender, EventArgs e)
        {
            set_header_click_handle(Headers.Commission);
        }
    }

    public class CustomArgs : EventArgs
    {
        public Headers idx;
    }
}
