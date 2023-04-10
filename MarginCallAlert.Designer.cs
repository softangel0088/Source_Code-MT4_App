namespace FXFellowDashboard
{
    partial class MarginCallAlert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_ids = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lab_ids);
            this.panel1.Controls.Add(this.lab_time);
            this.panel1.Controls.Add(this.lab_title);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 265);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Roboto", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Margin Call";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(249, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stop Margin Call";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "triggered the margin call. All positions are closed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_ids
            // 
            this.lab_ids.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lab_ids.Location = new System.Drawing.Point(3, 95);
            this.lab_ids.Name = "lab_ids";
            this.lab_ids.Size = new System.Drawing.Size(420, 32);
            this.lab_ids.TabIndex = 1;
            this.lab_ids.Text = "130xxxxxx and 180xxxxx";
            this.lab_ids.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_time
            // 
            this.lab_time.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.lab_time.Location = new System.Drawing.Point(184, 60);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(58, 32);
            this.lab_time.TabIndex = 1;
            this.lab_time.Text = "30";
            this.lab_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_title
            // 
            this.lab_title.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.Location = new System.Drawing.Point(33, 17);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(360, 35);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "MARGIN CALL ATTENTION";
            this.lab_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarginCallAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(432, 271);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MarginCallAlert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MarginCallAlert";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_ids;
    }
}