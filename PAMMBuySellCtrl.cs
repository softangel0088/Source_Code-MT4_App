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
    public partial class PAMMBuySellCtrl : UserControl
    {
        public int tot_symbol;
        public int symbol_id;
        public int slave_percent;
        public MT4APIWrapper api;

        public EventHandler m_buysell_click_handle;
        public EventHandler m_buy_click_handle;
        public EventHandler m_sell_click_handle;
        public EventHandler m_symbol_change_handle;

        private System.Timers.Timer timer = null;
        private int dir = 0;

        public PAMMBuySellCtrl()
        {
            InitializeComponent();

            panel_slave_percent.MouseDown += new MouseEventHandler(button_MouseDown);
            panel_slave_percent.MouseUp += new MouseEventHandler(button_MouseUp);
            panel_slave_percent.Disposed += new EventHandler(button_Disposed);
        }

        public void Init(MT4APIWrapper p_api)
        {
            tot_symbol = Settings.symbol_num;
            symbol_id = 0;
            display_symbol();

            api = p_api;
            update_bid_ask();

            slave_percent = 100;
            display_slave_percent();

            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Tick);
            timer.Enabled = false;
        }

        void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) dir = 1; else dir = -1;
            timer.Enabled = true;
        }

        void button_MouseUp(object sender, MouseEventArgs e)
        {
            timer.Enabled = false;
        }

        void button_Disposed(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            change_slave_percent(dir);
        }

        public void display_slave_percent()
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                lab_slave_percent.Text = " " + slave_percent.ToString() + "%";
            });
        }
        public void update_bid_ask()
        {
            if (api == null) return;

            this.InvokeOnUiThreadIfRequired(() =>
            {
                bool is_increased = api.R3_increase_flag[symbol_id];
                double price = api.R3_bid[symbol_id];

                int price_int = (int)(price / Settings.SymbolsPoint[symbol_id] / 10);
                lab_bid_decimal.Text = (price_int % 100).ToString("00");
                if (price < 100) lab_bid_int.Text = (((int)(price * 100)) / 100.0).ToString("#,##0.00");
                else lab_bid_int.Text = ((int)price).ToString() + ".";

                price = api.R3_ask[symbol_id];
                price_int = (int)(price / Settings.SymbolsPoint[symbol_id] / 10);
                lab_ask_decimal.Text = (price_int % 100).ToString("00");
                if (price < 100) lab_ask_int.Text = (((int)(price * 100)) / 100.0).ToString("#,##0.00");
                else lab_ask_int.Text = ((int)price).ToString() + ".";

                Color col = is_increased ? Color.Blue : Color.Red;
                panel_ask.BackColor = col;
                panel_bid.BackColor = col;
                panel_one_click.BackColor = col;
            });
        }

        private string remove_suffix(string str)
        {
            int len = str.Length;
            if (str[len - 1] == '.' || str[len - 1] == '-' || str[len - 1] == 'x')
                str = str.Remove(len - 1);
            return str;
        }

        private void display_symbol()
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                string symbol_str = Settings.SymbolsToSubscribe[symbol_id];
                lab_symbol.Text = remove_suffix(symbol_str);
            });
        }

        public double get_lotsize()
        {
            double lot;
            int lot_int = 0;
            int lot_decimal = 0;

            string decimal_str = tb_lotsize_decimal.Text;
            if (decimal_str.Length == 1) decimal_str += "0";

            if (!int.TryParse(tb_lotsize_int.Text, out lot_int)) lot_int = 0;
            if (!int.TryParse(decimal_str, out lot_decimal)) lot_decimal = 0;

            lot = lot_int + lot_decimal * 0.01;
            if (lot <= 0) lot = 0.01;

            return lot;
        }
        public void set_lotsize(double lots)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                int lots_int, lots_decimal;

                lots_int = (int)(lots + 1e-3);
                lots_decimal = ((int)(lots * 100 + 1e-3)) % 100;

                tb_lotsize_int.Text = lots_int.ToString();
                tb_lotsize_decimal.Text = lots_decimal.ToString("00");
            });
        }

        private void panel_lot_plus_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize();

            curLot += 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot);
        }

        private void panel_lot_minus_Click(object sender, EventArgs e)
        {
            double curLot = get_lotsize();

            curLot -= 0.01;
            curLot = Math.Max(curLot, 0.01);
            curLot = Math.Min(curLot, 999.99);

            set_lotsize(curLot);
        }

        private void panel_symbol_Click(object sender, EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            if (mouseEvent.Button == MouseButtons.Right)
            {
                symbol_id--;
                if (symbol_id < 0) symbol_id += tot_symbol;
            }
            else
            {
                symbol_id++;
                if (symbol_id >= tot_symbol) symbol_id -= tot_symbol;
            }
            display_symbol();
            update_bid_ask();

            //if (m_symbol_change_handle != null)
            //    m_symbol_change_handle(this, e);
        }

        private void tb_KeyPress_3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (char.IsDigit(e.KeyChar) && (sender as TextBox).Text.Length >= 3) e.Handled = true;
        }

        private void tb_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (char.IsDigit(e.KeyChar) && (sender as TextBox).Text.Length >= 2) e.Handled = true;
        }

        private void panel_one_click_Click(object sender, EventArgs e)
        {
            if (m_buysell_click_handle != null)
                m_buysell_click_handle(this, e);
        }

        private void panel_bid_Click(object sender, EventArgs e)
        {
            if (m_buysell_click_handle != null)
                m_sell_click_handle(this, e);
        }

        private void panel_ask_Click(object sender, EventArgs e)
        {
            if (m_buysell_click_handle != null)
                m_buy_click_handle(this, e);
        }

        private void change_slave_percent(int dir)
        {
            slave_percent += dir;
            if (slave_percent > 100) slave_percent = 100;
            if (slave_percent < 1) slave_percent = 1;

            display_slave_percent();
        }

        private void panel_slave_percent_Click(object sender, EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            if (mouseEvent.Button == MouseButtons.Right)
            {
                change_slave_percent(1);
            }
            else
            {
                change_slave_percent(-1);
            }
        }
    }
}
