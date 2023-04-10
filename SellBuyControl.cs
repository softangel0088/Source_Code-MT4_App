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
    public partial class SellBuyControl : UserControl
    {
        public SellBuyControl()
        {
            InitializeComponent();
        }


        public double get_lotsize()
        {
            double lot;
            int lot_int = 0;
            int lot_decimal = 0;
           
            if (!int.TryParse(tb_lotsize_int.Text, out lot_int)) lot_int = 0;
            if (!int.TryParse(tb_lotsize_decimal.Text, out lot_decimal)) lot_decimal = 0;

            lot = lot_int + lot_decimal * 0.01;
            if (lot <= 0) lot = 0.01;

            return lot;
        }
        public void set_lotsize(double lots)
        {
            int lots_int, lots_decimal;

            lots_int = (int)(lots + 1e-3);
            lots_decimal = ((int)(lots * 100 + 1e-3)) % 100;
          
            tb_lotsize_int.Text = lots_int.ToString();
            tb_lotsize_decimal.Text = lots_decimal.ToString("00");
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize();

            curLot -= 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot);
           
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize();

            curLot += 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot);
        }
    }
}
