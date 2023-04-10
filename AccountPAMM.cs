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
    public partial class AccountPAMM : UserControl
    {
        private bool _master_mode;
        public EventHandler m_dbl_click_handle;
        public EventHandler m_combo_change_handle;

        public bool m_master_mode
        {
            get
            {
                return _master_mode;
            }
            set
            {
                _master_mode = value;
                if (_master_mode)
                {
                    panel_all.ColumnStyles[1].Width = 0;
                }
            }
        }

        public void change_colors(Color col_account1, Color col_account2, Color col_freepip)
        {
            lab_account1.BackColor = col_account1;
            lab_curr1.BackColor = col_account1;
            lab_lot1.BackColor = col_account1;
            lab_load1.BackColor = col_account1;
            lab_percent1.BackColor = col_account1;
            lab_slave_percent1.BackColor = col_account1;
            lab_margin1.BackColor = col_account1;

            lab_account2.BackColor = col_account2;
            lab_curr2.BackColor = col_account2;
            lab_lot2.BackColor = col_account2;
            lab_load2.BackColor = col_account2;
            lab_percent2.BackColor = col_account2;
            lab_slave_percent2.BackColor = col_account2;
            lab_margin2.BackColor = col_account2;

            lab_pip1.BackColor = lab_pip2.BackColor = col_freepip;
        }

        void dbl_click(object sender, EventArgs e)
        {
            if (m_dbl_click_handle != null)
                m_dbl_click_handle(this, e);
        }

        void combo_change(object sender, EventArgs e)
        {
            if (m_combo_change_handle != null)
                m_combo_change_handle(this, e);
        }

        public bool check_combo()
        {
            return cb_onoff.Checked;
        }

        public string get_lot_percent(int id)
        {
            if (id == 0) return lab_slave_percent1.Text;
            return lab_slave_percent2.Text;
        }

        public void change_connections(int con1, int con2)
        {
            if (con1 == 1) lab_con1.BackColor = Color.Green;
            else if (con1 == 2) lab_con1.BackColor = Color.Orange;
            else lab_con1.BackColor = Color.Red;

            if (con2 == 1) lab_con2.BackColor = Color.Green;
            else if (con2 == 2) lab_con2.BackColor = Color.Orange;
            else lab_con2.BackColor = Color.Red;
        }

        public void set_contents(ClientDetails cd, bool show_client_flag)
        {
            lab_client_name.Text = cd.name;
            lab_account1.Text = cd.userId1;
            lab_curr1.Text = cd.curr1;
            lab_lot1.Text = cd.lot1;
            lab_pip1.Text = cd.pip1;
            lab_margin1.Text = cd.margin1;
            lab_load1.Text = cd.load1;
            lab_percent1.Text = cd.percent1;
            lab_slave_percent1.Text = cd.slave_percent1;

            lab_account2.Text = cd.userId2;
            lab_curr2.Text = cd.curr2;
            lab_lot2.Text = cd.lot2;
            lab_pip2.Text = cd.pip2;
            lab_margin2.Text = cd.margin2;
            lab_load2.Text = cd.load2;
            lab_percent2.Text = cd.percent2;
            lab_slave_percent2.Text = cd.slave_percent2;

            if(!show_client_flag)
            {
                lab_client_name.Text = "**** ****";
                lab_account1.Text = "180****";
                lab_account2.Text = "130****";
            }
        }

        public void change_combo(bool val)
        {
            cb_onoff.Checked = val;
        }

        public AccountPAMM()
        {
            InitializeComponent();
            this.DoubleBuffered(true);
        }
    }
}
