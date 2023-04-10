using PdfiumViewer;
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
    public partial class PDFViewer : Form
    {
        public PDFViewer(string filename)
        {
            InitializeComponent();

            try
            {
                pdf_viewer.Document = OpenDocument(filename);
            }
            catch(Exception)
            { }
        }

        private PdfDocument OpenDocument(string fileName)
        {
            try
            {
                return PdfDocument.Load(this, fileName);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Open pdf failed: " + ex.ToString());
                return null;
            }
        }
    }
}
