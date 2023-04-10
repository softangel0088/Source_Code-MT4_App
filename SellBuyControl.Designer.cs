namespace FXFellowDashboard
{
    partial class SellBuyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellBuyControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_lotsize_int = new System.Windows.Forms.TextBox();
            this.tb_lotsize_decimal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_lotsize_decimal);
            this.panel1.Controls.Add(this.tb_lotsize_int);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 25);
            this.panel1.TabIndex = 0;
            // 
            // tb_lotsize_int
            // 
            this.tb_lotsize_int.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lotsize_int.Location = new System.Drawing.Point(29, 5);
            this.tb_lotsize_int.Name = "tb_lotsize_int";
            this.tb_lotsize_int.Size = new System.Drawing.Size(41, 13);
            this.tb_lotsize_int.TabIndex = 0;
            this.tb_lotsize_int.Text = "0";
            this.tb_lotsize_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_lotsize_decimal
            // 
            this.tb_lotsize_decimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lotsize_decimal.Location = new System.Drawing.Point(94, 5);
            this.tb_lotsize_decimal.Name = "tb_lotsize_decimal";
            this.tb_lotsize_decimal.Size = new System.Drawing.Size(28, 13);
            this.tb_lotsize_decimal.TabIndex = 0;
            this.tb_lotsize_decimal.Text = "01";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 16);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.Panel2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(130, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 16);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.Panel3_Click);
            // 
            // SellBuyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "SellBuyControl";
            this.Size = new System.Drawing.Size(152, 25);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_lotsize_decimal;
        private System.Windows.Forms.TextBox tb_lotsize_int;
    }
}
