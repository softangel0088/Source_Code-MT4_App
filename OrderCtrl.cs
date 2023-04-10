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
    public partial class OrderCtrl : UserControl
    {
        public EventHandler m_close_click_handle;
        public EventHandler m_SLTP_changed_handle;

        private Color _sep_col;
        public Color m_sep_col
        {
            get
            {
                return _sep_col;
            }
            set
            {
                _sep_col = value;
                separator.BackColor = _sep_col;
            }
        }
        
        public OrderCtrl()
        {
            InitializeComponent();
        }

        void close_click(object sender, EventArgs e)
        {
            if (m_close_click_handle != null)
                m_close_click_handle(this, e);
        }

        void key_press(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                OrderSLTPArgs arg = new OrderSLTPArgs();
                arg.SLTP1 = get_double_from_string(tb_SL_TP1.Text);
                arg.SLTP2 = get_double_from_string(tb_SL_TP2.Text);

                if (m_SLTP_changed_handle != null)
                    m_SLTP_changed_handle(this, arg);
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        double get_double_from_string(string lotStr)
        {
            if (lotStr == "") return 0;
            double val;
            try
            {
                val = double.Parse(lotStr);
            }
            catch (Exception ex)
            {
                val = 0;
                Settings.Log.Error("Get orders SLTP failed: " + ex.ToString());
            }
            return val;
        }

        public void set_contents(OrderDetails od, bool show_client_flag)
        {
            lab_account1.Text = od.userId1;
            string str_symbol1 = od.symbol1;
            if (str_symbol1 == "XTIUSD") str_symbol1 = "USOilCash";
            if (str_symbol1 == "XBRUSD") str_symbol1 = "UKOilCash";
            lab_curr1.Text = str_symbol1;
            lab_lot1.Text = od.lot1;
            lab_active1.Text = od.active1;
            lab_spread1.Text = od.spread1;
            lab_swap1.Text = od.swap1;
            lab_pnl1.Text = od.pnl1;
            lab_commision1.Text = od.commission1;

            lab_account2.Text = od.userId2;
            
            lab_curr2.Text = od.symbol1;
            lab_lot2.Text = od.lot2;
            lab_active2.Text = od.active2;
            lab_spread2.Text = od.spread2;
            lab_swap2.Text = od.swap2;
            lab_pnl2.Text = od.pnl2;

            if(!tb_SL_TP1.Focused) tb_SL_TP1.Text = od.sl_tp1;
            if (!tb_SL_TP2.Focused) tb_SL_TP2.Text = od.sl_tp2;

            if(!show_client_flag)
            {
                lab_account1.Text = "180****";
                lab_account2.Text = "130****";
            }

            if (od.isPending) change_font_color(Color.DarkOrange);
            else change_font_color(Color.Black);
        }

        private void change_font_color(Color col)
        {
            lab_account1.ForeColor = col;
            lab_curr1.ForeColor = col;
            lab_lot1.ForeColor = col;
            lab_account1.ForeColor = col;
            lab_active1.ForeColor = col;
            lab_spread1.ForeColor = col;
            lab_swap1.ForeColor = col;
            lab_pnl1.ForeColor = col;
            lab_commision1.ForeColor = col;
            tb_SL_TP1.ForeColor = col;

            lab_account2.ForeColor = col;
            lab_curr2.ForeColor = col;
            lab_lot2.ForeColor = col;
            lab_account2.ForeColor = col;
            lab_active2.ForeColor = col;
            lab_spread2.ForeColor = col;
            lab_swap2.ForeColor = col;
            lab_pnl2.ForeColor = col;
            tb_SL_TP2.ForeColor = col;
        }
    }

    public class OrderSLTPArgs : EventArgs
    {
        public double SLTP1;
        public double SLTP2;
    }

}
