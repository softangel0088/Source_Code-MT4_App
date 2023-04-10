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
    public partial class StockSellButton : UserControl
    {
        public StockSellButton()
        {
            InitializeComponent();
            lab_caption.Click += onclickbutton;
            lab_first.Click += onclickbutton;
            lab_second.Click += onclickbutton;
            lab_third.Click += onclickbutton;
            panel_1.Click += onclickbutton;
            panel_2.Click += onclickbutton;
        }

        private void onclickbutton(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        public void set_contents(double price)
        {
            double p1;
            int p2, p3;

            if (price < 10)
            {
                p1 = ((int)(price * 100)) / 100.0;
                p2 = ((int)(price * 10000)) % 100;
                p3 = (int)(price * 100000) % 10;

                lab_first.Text = p1.ToString("#,##0.00");
                lab_second.Text = p2.ToString("00");
                lab_third.Text = p3.ToString();

            }
            else if(price < 100)
            {
                p1 = ((int)(price * 100)) / 100.0;
                p2 = ((int)(price * 10000)) % 100;

                lab_first.Text = p1.ToString("#,##0.00");
                lab_second.Text = p2.ToString("00");
                lab_third.Text = "";
            }
            else
            {
                p1 = (int)price;
                p2 = ((int)(price * 100)) % 100;
                p3 = (int)(price * 1000) % 10;

                lab_first.Text = p1.ToString() + ".";
                lab_second.Text = p2.ToString("00");
                lab_third.Text = p3.ToString();
            }
        }

        public void set_color(Color col)
        {
            panel_1.BackColor = col;
            panel_2.BackColor = col;
        }

    }
}
