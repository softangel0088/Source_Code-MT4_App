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
    public partial class HeaderCtrl : UserControl
    {
        public HeaderCtrl()
        {
            InitializeComponent();
        }

        public void restoreHeaders()
        {
            panel_header.ColumnStyles[2] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.56F);
            panel_header.ColumnStyles[4] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.56F);
            panel_header.ColumnStyles[8] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_header.ColumnStyles[9] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_header.ColumnStyles[10] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_header.ColumnStyles[11] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
            panel_header.ColumnStyles[12] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.26F);
        }

        public void removeHeaders(int id)
        {
            panel_header.ColumnStyles[id].SizeType = SizeType.Absolute;
            panel_header.ColumnStyles[id].Width = 0;
        }
    }
}
