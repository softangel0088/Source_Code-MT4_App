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
    public partial class ClientCtrl : UserControl
    {
        private bool is_confirmed = false;
        public EventHandler m_dbl_click_handle;
        public EventHandler m_delete_click_handle;
        public EventHandler m_setting_changed_handle;

        public bool m_is_confirmed
        {
            get
            {
                return is_confirmed;
            }
            set
            {
                is_confirmed = value;
                if(is_confirmed)
                {
                    tb_name.ReadOnly = true;
                    tb_account1.ReadOnly = true;
                    tb_account2.ReadOnly = true;
                    tb_password1.ReadOnly = true;
                    tb_password2.ReadOnly = true;
                    tb_email.ReadOnly = true;
                    tb_email_password.ReadOnly = true;
                    panel_name.BackColor = Color.FromArgb(240, 240, 240);

                    lab_con1.BackColor = Color.Gray;
                    lab_con2.BackColor = Color.Gray;
                }
                else
                {
                    tb_name.ForeColor = Color.Gray;
                    tb_account1.ForeColor = Color.Gray;
                    tb_account2.ForeColor = Color.Gray;
                    tb_password1.ForeColor = Color.Gray;
                    tb_password2.ForeColor = Color.Gray;
                    tb_email.ForeColor = Color.Gray;
                    tb_email_password.ForeColor = Color.Gray;

                    btn_delete.Visible = false;
                }
            }
        }
        public ClientCtrl()
        {
            InitializeComponent();

            lab_con1.BackColor = Color.White;
            lab_con2.BackColor = Color.White;
            tb_password1.UseSystemPasswordChar = true;
            tb_password2.UseSystemPasswordChar = true;
            tb_email_password.UseSystemPasswordChar = true;
        }

        void dbl_click(object sender, EventArgs e)
        {
            if (m_dbl_click_handle != null)
                m_dbl_click_handle(this, e);
        }

        void delete_click(object sender, EventArgs e)
        {
            if (m_delete_click_handle != null)
                m_delete_click_handle(this, e);
        }

        public void set_password_visible(bool fg)
        {
            tb_password1.UseSystemPasswordChar = !fg;
            tb_password2.UseSystemPasswordChar = !fg;
            tb_email_password.UseSystemPasswordChar = !fg;
        }

        public void set_server_info(List<string> list_server_info)
        {
            int count = list_server_info.Count;

            cb_server1.Items.Clear();
            foreach (var info in list_server_info)
            {
                cb_server1.Items.Add(info);
            }

            cb_server2.Items.Clear();
            foreach (var info in list_server_info)
            {
                cb_server2.Items.Add(info);
            }
        }

        public void set_contents(ClientInfo info, bool show_client_flag)
        {
            tb_name.Text = info.name;
            tb_account1.Text = info.userId1.ToString();
            tb_account2.Text = info.userId2.ToString();
            tb_password1.Text = info.password1;
            tb_password2.Text = info.password2;
            tb_email.Text = info.email;
            tb_email_password.Text = info.emailPassword;

            tb_stop_level1.Text = info.stop_level1.ToString("0");
            tb_stop_level2.Text = info.stop_level2.ToString("0");

            lab_con1.BackColor = Color.Gray;
            lab_con2.BackColor = Color.Gray;

            if (info.connection1 == 0)
                lab_con1.BackColor = Color.Red;
            else if (info.connection1 == 1)
                lab_con1.BackColor = Color.Green;
            else if (info.connection1 == 2)
                lab_con1.BackColor = Color.Orange;

            if (info.connection2 == 0)
                lab_con2.BackColor = Color.Red;
            else if (info.connection2 == 1)
                lab_con2.BackColor = Color.Green;
            else if (info.connection2 == 2)
                lab_con2.BackColor = Color.Orange;

            if(!show_client_flag)
            {
                tb_name.Text = "**** ****";
                tb_account1.Text = "180****";
                tb_account2.Text = "130****";
                tb_email.Text = "**** ****";
            }

            int index1 = cb_server1.Items.IndexOf(info.server_name1);
            if (index1 < 0)
                index1 = cb_server1.Items.IndexOf("FXFellow-Real8");
            cb_server1.SelectedIndex = index1;

            int index2 = cb_server1.Items.IndexOf(info.server_name2);
            if (index2 < 0)
                index2 = cb_server1.Items.IndexOf("FXFellow-Real3");
            cb_server2.SelectedIndex = index2;
        }

        public void disable_accounts()
        {
            tb_account1.Enabled = false;
            tb_account2.Enabled = false;
            tb_email.Enabled = false;
            tb_name.Enabled = false;
        }

        public ClientInfo read_client_info_from_ctrl()
        {
            var info = new ClientInfo();

            try
            {
                info.name = tb_name.Text;
                if(!int.TryParse(tb_account1.Text, out info.userId1)) info.userId1 = 0;
                if (!int.TryParse(tb_account2.Text, out info.userId2)) info.userId2 = 0;
                info.password1 = tb_password1.Text;
                info.password2 = tb_password2.Text;
                info.email = tb_email.Text;
                info.emailPassword = tb_email_password.Text;
                info.server_name1 = cb_server1.SelectedItem.ToString();
                info.server_name2 = cb_server2.SelectedItem.ToString();

                if (!double.TryParse(tb_stop_level1.Text, out info.stop_level1)) info.stop_level1 = 0;
                if (!double.TryParse(tb_stop_level2.Text, out info.stop_level2)) info.stop_level2 = 0;
            }
            catch (Exception) { }

            return info;
        }

        public void set_default_contents()
        {
            tb_name.Text = "Name";
            tb_account1.Text = "180";
            tb_account2.Text = "130";
            tb_password1.Text = "Password";
            tb_password2.Text = "Password";
            tb_email.Text = "Mail Address";
            tb_email_password.Text = "Password";
            tb_stop_level1.Text = "0";
            tb_stop_level2.Text = "0";
        }

        public void lock_content()
        {
            cb_server1.Enabled = false;
            cb_server2.Enabled = false;

            tb_account1.Enabled = false;
            tb_account2.Enabled = false;

            tb_password1.Enabled = false;
            tb_password2.Enabled = false;

            tb_stop_level1.Enabled = false;
            tb_stop_level2.Enabled = false;

            tb_email.Enabled = false;
            tb_email_password.Enabled = false;
            tb_name.Enabled = false;
        }

        private void panel_name_MouseClick(object sender, MouseEventArgs e)
        {
            tb_name.Focus();
        }

        private void tb_account1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tb_account1.ReadOnly)
            {
                tb_account1.Text = "";
                tb_account1.ForeColor = Color.Black;
            }
        }

        private void tb_account2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tb_account2.ReadOnly)
            {
                tb_account2.Text = "";
                tb_account2.ForeColor = Color.Black;
            }
        }
        private void tb_password1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tb_password1.ReadOnly)
            {
                tb_password1.Text = "";
                tb_password1.ForeColor = Color.Black;
            }
        }
        private void tb_password2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tb_password2.ReadOnly)
            {
                tb_password2.Text = "";
                tb_password2.ForeColor = Color.Black;
            }
        }
        private void tb_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tb_name.ReadOnly)
            {
                tb_name.Text = "";
                tb_name.ForeColor = Color.Black;
            }
        }

        private void tb_email_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tb_email.ReadOnly)
            {
                tb_email.Text = "";
                tb_email.ForeColor = Color.Black;
            }
        }

        private void tb_email_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (!tb_email_password.ReadOnly)
            {
                tb_email_password.Text = "";
                tb_email_password.ForeColor = Color.Black;
            }
        }

        private void Tb_setting_KeyPress(object sender, KeyPressEventArgs e)
        {
            m_setting_changed_handle?.Invoke(this, EventArgs.Empty);
        }
    }
}
