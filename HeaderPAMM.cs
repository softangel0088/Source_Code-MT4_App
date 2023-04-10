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
    public partial class HeaderPAMM : UserControl
    {
        private bool _master_mode;
        public bool m_master_mode
        {
            get
            {
                return _master_mode;
            }
            set
            {
                _master_mode = value;
                if(_master_mode)
                {
                    panel_header.ColumnStyles[9].Width = 0;
                    lab_slave_percent.Text = "TYP";

                    Padding pd = new Padding(1, 1, 1, 2);
                    lab_client.Margin = pd;
                    lab_account.Margin = pd;
                    lab_curr.Margin = pd;
                    lab_lot.Margin = pd;
                    lab_freepip.Margin = pd;
                    lab_margin.Margin = pd;
                    lab_load.Margin = pd;
                    lab_percent.Margin = pd;
                    lab_slave_percent.Margin = new Padding(1, 1, 2, 2);

                    lab_onoff.Margin = new Padding(0);
                }
            }
        }

        public HeaderPAMM()
        {
            InitializeComponent();
        }
    }
}
