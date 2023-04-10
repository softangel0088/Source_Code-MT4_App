namespace FXFellowDashboard
{
    partial class HTMLViewCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.web_browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // web_browser
            // 
            this.web_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_browser.Location = new System.Drawing.Point(0, 0);
            this.web_browser.Margin = new System.Windows.Forms.Padding(0);
            this.web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_browser.Name = "web_browser";
            this.web_browser.Size = new System.Drawing.Size(651, 828);
            this.web_browser.TabIndex = 0;
            // 
            // HTMLViewCtrl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.web_browser);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HTMLViewCtrl";
            this.Size = new System.Drawing.Size(651, 828);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser web_browser;
    }
}
