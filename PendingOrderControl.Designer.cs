namespace FXFellowDashboard
{
    partial class PendingOrderControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER LOTS";
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(95)))));
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(7, 22);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(78, 20);
            this.bunifuCustomTextbox1.TabIndex = 5;
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PendingOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.label1);
            this.Name = "PendingOrderControl";
            this.Size = new System.Drawing.Size(120, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.Button button2;
    }
}
