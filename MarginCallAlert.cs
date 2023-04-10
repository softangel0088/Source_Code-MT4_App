using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FXFellowDashboard
{
    public partial class MarginCallAlert : Form
    {
        private System.Timers.Timer timer = null;
        private int counter;
           
        public MarginCallAlert(string name, string id_str1, string id_str2)
        {
            InitializeComponent();

            counter = 30;
            lab_time.Text = counter.ToString();
            lab_ids.Text = name + "(" + id_str1 + " and " + id_str2 + ")";

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_tick);
            timer.Enabled = true;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer.Stop();
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            this.InvokeOnUiThreadIfRequired(() =>
            {
                lab_time.Text = counter.ToString();
            });
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
            this.DialogResult = DialogResult.OK;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
