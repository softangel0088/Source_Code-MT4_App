namespace FXFellowDashboard
{
    partial class PDFViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pdf_viewer = new PdfiumViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // pdf_viewer
            // 
            this.pdf_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdf_viewer.Location = new System.Drawing.Point(0, 0);
            this.pdf_viewer.Name = "pdf_viewer";
            this.pdf_viewer.Size = new System.Drawing.Size(784, 1061);
            this.pdf_viewer.TabIndex = 0;
            // 
            // PDFViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 1061);
            this.Controls.Add(this.pdf_viewer);
            this.Name = "PDFViewer";
            this.Text = "MANUAL PDF";
            this.ResumeLayout(false);

        }

        #endregion

        private PdfiumViewer.PdfViewer pdf_viewer;
    }
}