using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp;

namespace FXFellowDashboard
{
    public partial class HTMLViewCtrl : UserControl
    {
        string result_html = "";
        string file_path = "";

        public HTMLViewCtrl()
        {
            InitializeComponent();
        }

        public void EditHTML(StatementInfo info)
        {
            try
            {
                file_path = @"Statement\Statement_" + info.client_name + "_" + info.account1.ToString() + "_" + 
                    info.account2.ToString() + "_" + info.path_time + ".pdf";

                result_html = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), @"Statement\Statement.html"));

                //replace real values
                result_html = result_html.Replace("state_res_20", (info.equity1 + info.equity2).ToString("0.00"));
                result_html = result_html.Replace("state_res_19", info.cur_time);
                result_html = result_html.Replace("state_res_18", info.equity2.ToString("0.00"));
                result_html = result_html.Replace("state_res_17", info.account2.ToString());
                result_html = result_html.Replace("state_res_16", info.equity1.ToString("0.00"));
                result_html = result_html.Replace("state_res_15", info.account1.ToString());
                result_html = result_html.Replace("state_res_14", info.equity2.ToString("0.00"));
                result_html = result_html.Replace("state_res_13", info.free_margin2.ToString("0.00"));
                result_html = result_html.Replace("state_res_12", info.margin2.ToString("0.00"));
                result_html = result_html.Replace("state_res_11", info.floting_pnl2.ToString("0.00"));
                result_html = result_html.Replace("state_res_10", info.balance2.ToString("0.00"));
                result_html = result_html.Replace("state_res_9", info.closed_pnl2.ToString("0.00"));
                result_html = result_html.Replace("state_res_8", info.account2.ToString());
                result_html = result_html.Replace("state_res_7", info.equity1.ToString("0.00"));
                result_html = result_html.Replace("state_res_6", info.free_margin1.ToString("0.00"));
                result_html = result_html.Replace("state_res_5", info.margin1.ToString("0.00"));
                result_html = result_html.Replace("state_res_4", info.floting_pnl1.ToString("0.00"));
                result_html = result_html.Replace("state_res_3", info.balance1.ToString("0.00"));
                result_html = result_html.Replace("state_res_2", info.closed_pnl1.ToString("0.00"));
                result_html = result_html.Replace("state_res_1", info.account1.ToString());
                result_html = result_html.Replace("state_res_0", info.client_name);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Edit HTML failed: " + ex.ToString());
            }
        }

        public void Display()
        {
            web_browser.DocumentText = result_html;
        }

        public void SavePDF()
        {
            try
            {
                PdfDocument pdf = PdfGenerator.GeneratePdf(result_html, PageSize.A4);
                string path = Path.Combine(Directory.GetCurrentDirectory(), file_path);

                if(File.Exists(path))
                {
                    while(File.Exists(path))
                    {
                        path = path.Replace(".pdf", "_.pdf");
                    }
                    //MessageBox.Show("Same statement file already exists");
                }
                pdf.Save(path);
                OpenPDF(path);
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Save pdf failed: " + ex.ToString());
            }
        }

        private void OpenPDF(string path)
        {
            try
            {
                PDFViewer pdf_viewer = new PDFViewer(path);
                pdf_viewer.Text = "Statement Year";
                pdf_viewer.Show();
                pdf_viewer.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Open pdf failed: " + ex.ToString());
            }
        }

        public void AutoSavePDF(StatementInfo info)
        {
            try
            {
                string f_path = @"Statement\Statement_" + info.client_name + "_" + info.account1.ToString() + "_" +
                    info.account2.ToString() + "_" + info.path_time + ".pdf";

                string html = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), @"Statement\Statement.html"));

                //replace real values
                html = html.Replace("state_res_20", (info.equity1 + info.equity2).ToString("0.00"));
                html = html.Replace("state_res_19", info.cur_time);
                html = html.Replace("state_res_18", info.equity2.ToString("0.00"));
                html = html.Replace("state_res_17", info.account2.ToString());
                html = html.Replace("state_res_16", info.equity1.ToString("0.00"));
                html = html.Replace("state_res_15", info.account1.ToString());
                html = html.Replace("state_res_14", info.equity2.ToString("0.00"));
                html = html.Replace("state_res_13", info.free_margin2.ToString("0.00"));
                html = html.Replace("state_res_12", info.margin2.ToString("0.00"));
                html = html.Replace("state_res_11", info.floting_pnl2.ToString("0.00"));
                html = html.Replace("state_res_10", info.balance2.ToString("0.00"));
                html = html.Replace("state_res_9", info.closed_pnl2.ToString("0.00"));
                html = html.Replace("state_res_8", info.account2.ToString());
                html = html.Replace("state_res_7", info.equity1.ToString("0.00"));
                html = html.Replace("state_res_6", info.free_margin1.ToString("0.00"));
                html = html.Replace("state_res_5", info.margin1.ToString("0.00"));
                html = html.Replace("state_res_4", info.floting_pnl1.ToString("0.00"));
                html = html.Replace("state_res_3", info.balance1.ToString("0.00"));
                html = html.Replace("state_res_2", info.closed_pnl1.ToString("0.00"));
                html = html.Replace("state_res_1", info.account1.ToString());
                html = html.Replace("state_res_0", info.client_name);

                PdfDocument pdf = PdfGenerator.GeneratePdf(html, PageSize.A4);
                string path = Path.Combine(Directory.GetCurrentDirectory(), f_path);

                if (File.Exists(path))
                {
                    while (File.Exists(path))
                    {
                        path = path.Replace(".pdf", "_.pdf");
                    }
                }
                pdf.Save(path);
            }
            catch (Exception ex)
            {
                Settings.Log.Error("Edit HTML failed: " + ex.ToString());
            }
        }
    }
}
