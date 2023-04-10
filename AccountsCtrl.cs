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
    public partial class AccountsCtrl : UserControl
    {
        public EventHandler m_dbl_click_handle;

        public AccountsCtrl()
        {
            InitializeComponent();
            this.DoubleBuffered(true);
        }

        public void restore_labels()
        {
            panel_label.ColumnStyles[2] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.56F);
            panel_label.ColumnStyles[4] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.56F);
            panel_label.ColumnStyles[8] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_label.ColumnStyles[9] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_label.ColumnStyles[10] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_label.ColumnStyles[11] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_label.ColumnStyles[12] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
        }

        void dbl_click(object sender, EventArgs e)
        {
            if (m_dbl_click_handle != null)
                m_dbl_click_handle(this, e);
        }

        public void remove_labels(int id)
        {
            panel_label.ColumnStyles[id].Width = 0;
        }

        public void change_colors(Color col_account1, Color col_account2, Color col_freepip)
        {
            lab_account1.BackColor = col_account1;
            lab_curr1.BackColor = col_account1;
            lab_transfer1.BackColor = col_account1;
            lab_balance1.BackColor = col_account1;
            lab_PnL1.BackColor = col_account1;
            lab_margin1.BackColor = col_account1;

            lab_account2.BackColor = col_account2;
            lab_curr2.BackColor = col_account2;
            lab_transfer2.BackColor = col_account2;
            lab_balance2.BackColor = col_account2;
            lab_PnL2.BackColor = col_account2;
            lab_margin2.BackColor = col_account2;

            lab_pip1.BackColor = lab_pip2.BackColor = col_freepip;
        }

        public void change_connections(int con1, int con2)
        {
            if (con1 == 1) lab_con1.BackColor = Color.Green;
            else if(con1 == 2) lab_con1.BackColor = Color.Orange;
            else lab_con1.BackColor = Color.Red;

            if (con2 == 1) lab_con2.BackColor = Color.Green;
            else if (con2 == 2) lab_con2.BackColor = Color.Orange;
            else lab_con2.BackColor = Color.Red;
        }

        public void get_contents(ClientDetails cd)
        {
        }

        public void set_contents(ClientDetails cd, bool show_client_flag)
        {
            lab_client_name.Text = cd.name;

            lab_account1.Text = cd.userId1;
            lab_curr1.Text = cd.curr1;
            lab_lot1.Text = cd.lot1;
            lab_pip1.Text = cd.pip1;
            lab_margin1.Text = cd.margin1;
            lab_transfer1.Text = cd.transfer1;
            lab_balance1.Text = cd.balance1;
            lab_PnL1.Text = cd.pnl1;
            lab_shiftat1.Text = cd.shiftat1;
            //lab_close1.Text = cd.close1;
            lab_equity1.Text = cd.equity1;
            lab_lot1_pending.Text = cd.lot1_pending;
            lab_pip1_pending.Text = cd.pip1_pending;
            
            lab_account2.Text = cd.userId2;
            lab_curr2.Text = cd.curr2;
            lab_lot2.Text = cd.lot2;
            lab_pip2.Text = cd.pip2;
            lab_margin2.Text = cd.margin2;
            lab_transfer2.Text = cd.transfer2;
            lab_balance2.Text = cd.balance2;
            lab_PnL2.Text = cd.pnl2;
            //lab_close2.Text = cd.close2;
            lab_equity2.Text = cd.equity2;
            lab_lot2_pending.Text = cd.lot2_pending;
            lab_pip2_pending.Text = cd.pip2_pending;

            if (cd.is_pending == 1)
            {
                lab_transfer2.Text = "Pending";
                lab_transfer2.BackColor = Color.Yellow;
            }
            else if (cd.is_pending == 2)
            {
                lab_transfer1.Text = "Pending";
                lab_transfer1.BackColor = Color.Yellow;
            }

            if(cd.money_shift_on)
            {
                lab_transfer1.ForeColor = Color.Black;
                lab_transfer2.ForeColor = Color.Black;
            }
            else
            {
                lab_transfer1.ForeColor = Color.Red;
                lab_transfer2.ForeColor = Color.Red;
            }

            if(!show_client_flag)
            {
                lab_client_name.Text = "**** ****";
                lab_account1.Text = "180****";
                lab_account2.Text = "130****";
            }
        }
    }
}
