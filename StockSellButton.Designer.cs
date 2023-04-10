namespace FXFellowDashboard
{
    partial class StockSellButton
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
            this.lab_caption = new System.Windows.Forms.Label();
            this.lab_first = new System.Windows.Forms.Label();
            this.lab_second = new System.Windows.Forms.Label();
            this.lab_third = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.panel_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_caption
            // 
            this.lab_caption.AutoSize = true;
            this.lab_caption.BackColor = System.Drawing.Color.Transparent;
            this.lab_caption.Font = new System.Drawing.Font("ROBOTO", 10F, System.Drawing.FontStyle.Bold);
            this.lab_caption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_caption.Location = new System.Drawing.Point(7, 3);
            this.lab_caption.Name = "lab_caption";
            this.lab_caption.Size = new System.Drawing.Size(46, 17);
            this.lab_caption.TabIndex = 0;
            this.lab_caption.Text = "SELL";
            // 
            // lab_first
            // 
            this.lab_first.BackColor = System.Drawing.Color.Transparent;
            this.lab_first.Font = new System.Drawing.Font("ROBOTO", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_first.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_first.Location = new System.Drawing.Point(8, 16);
            this.lab_first.Name = "lab_first";
            this.lab_first.Size = new System.Drawing.Size(40, 11);
            this.lab_first.TabIndex = 2;
            this.lab_first.Text = "1.12";
            // 
            // lab_second
            // 
            this.lab_second.AutoSize = true;
            this.lab_second.BackColor = System.Drawing.Color.Transparent;
            this.lab_second.Font = new System.Drawing.Font("ROBOTO", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_second.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_second.Location = new System.Drawing.Point(42, 4);
            this.lab_second.Name = "lab_second";
            this.lab_second.Size = new System.Drawing.Size(46, 31);
            this.lab_second.TabIndex = 3;
            this.lab_second.Text = "05";
            // 
            // lab_third
            // 
            this.lab_third.AutoSize = true;
            this.lab_third.BackColor = System.Drawing.Color.Transparent;
            this.lab_third.Font = new System.Drawing.Font("ROBOTO", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_third.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_third.Location = new System.Drawing.Point(83, 10);
            this.lab_third.Name = "lab_third";
            this.lab_third.Size = new System.Drawing.Size(14, 13);
            this.lab_third.TabIndex = 4;
            this.lab_third.Text = "7";
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(213)))));
            this.panel_1.Controls.Add(this.lab_caption);
            this.panel_1.Location = new System.Drawing.Point(0, 0);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(56, 22);
            this.panel_1.TabIndex = 5;
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(213)))));
            this.panel_2.Controls.Add(this.lab_third);
            this.panel_2.Controls.Add(this.lab_second);
            this.panel_2.Controls.Add(this.lab_first);
            this.panel_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_2.Location = new System.Drawing.Point(0, 22);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(100, 34);
            this.panel_2.TabIndex = 6;
            // 
            // StockSellButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StockSellButton";
            this.Size = new System.Drawing.Size(100, 56);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_caption;
        private System.Windows.Forms.Label lab_first;
        private System.Windows.Forms.Label lab_second;
        private System.Windows.Forms.Label lab_third;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_2;
    }
}
