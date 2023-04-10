namespace FXFellowDashboard
{
    partial class HeaderPAMM
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
            this.panel_header = new System.Windows.Forms.TableLayoutPanel();
            this.lab_onoff = new System.Windows.Forms.Label();
            this.lab_slave_percent = new System.Windows.Forms.Label();
            this.lab_percent = new System.Windows.Forms.Label();
            this.lab_load = new System.Windows.Forms.Label();
            this.lab_margin = new System.Windows.Forms.Label();
            this.lab_freepip = new System.Windows.Forms.Label();
            this.lab_lot = new System.Windows.Forms.Label();
            this.lab_curr = new System.Windows.Forms.Label();
            this.lab_account = new System.Windows.Forms.Label();
            this.lab_client = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(177)))), ((int)(((byte)(125)))));
            this.panel_header.ColumnCount = 10;
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.panel_header.Controls.Add(this.lab_onoff, 9, 0);
            this.panel_header.Controls.Add(this.lab_slave_percent, 8, 0);
            this.panel_header.Controls.Add(this.lab_percent, 7, 0);
            this.panel_header.Controls.Add(this.lab_load, 6, 0);
            this.panel_header.Controls.Add(this.lab_margin, 5, 0);
            this.panel_header.Controls.Add(this.lab_freepip, 4, 0);
            this.panel_header.Controls.Add(this.lab_lot, 3, 0);
            this.panel_header.Controls.Add(this.lab_curr, 2, 0);
            this.panel_header.Controls.Add(this.lab_account, 1, 0);
            this.panel_header.Controls.Add(this.lab_client, 0, 0);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.RowCount = 1;
            this.panel_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_header.Size = new System.Drawing.Size(950, 32);
            this.panel_header.TabIndex = 1;
            // 
            // lab_onoff
            // 
            this.lab_onoff.BackColor = System.Drawing.Color.White;
            this.lab_onoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_onoff.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_onoff.Location = new System.Drawing.Point(884, 2);
            this.lab_onoff.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.lab_onoff.Name = "lab_onoff";
            this.lab_onoff.Size = new System.Drawing.Size(64, 28);
            this.lab_onoff.TabIndex = 9;
            this.lab_onoff.Text = "ON/OFF";
            this.lab_onoff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_slave_percent
            // 
            this.lab_slave_percent.BackColor = System.Drawing.Color.White;
            this.lab_slave_percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_slave_percent.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_slave_percent.Location = new System.Drawing.Point(789, 2);
            this.lab_slave_percent.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_slave_percent.Name = "lab_slave_percent";
            this.lab_slave_percent.Size = new System.Drawing.Size(93, 28);
            this.lab_slave_percent.TabIndex = 8;
            this.lab_slave_percent.Text = "LOT";
            this.lab_slave_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_percent
            // 
            this.lab_percent.BackColor = System.Drawing.Color.White;
            this.lab_percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_percent.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_percent.Location = new System.Drawing.Point(694, 2);
            this.lab_percent.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_percent.Name = "lab_percent";
            this.lab_percent.Size = new System.Drawing.Size(93, 28);
            this.lab_percent.TabIndex = 7;
            this.lab_percent.Text = "%";
            this.lab_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_load
            // 
            this.lab_load.BackColor = System.Drawing.Color.White;
            this.lab_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_load.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_load.Location = new System.Drawing.Point(599, 2);
            this.lab_load.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_load.Name = "lab_load";
            this.lab_load.Size = new System.Drawing.Size(93, 28);
            this.lab_load.TabIndex = 6;
            this.lab_load.Text = "LOAD";
            this.lab_load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_margin
            // 
            this.lab_margin.BackColor = System.Drawing.Color.White;
            this.lab_margin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_margin.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_margin.Location = new System.Drawing.Point(504, 2);
            this.lab_margin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_margin.Name = "lab_margin";
            this.lab_margin.Size = new System.Drawing.Size(93, 28);
            this.lab_margin.TabIndex = 5;
            this.lab_margin.Text = "FREE MARGIN";
            this.lab_margin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_freepip
            // 
            this.lab_freepip.BackColor = System.Drawing.Color.White;
            this.lab_freepip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_freepip.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_freepip.Location = new System.Drawing.Point(409, 2);
            this.lab_freepip.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_freepip.Name = "lab_freepip";
            this.lab_freepip.Size = new System.Drawing.Size(93, 28);
            this.lab_freepip.TabIndex = 4;
            this.lab_freepip.Text = "FREE PIP";
            this.lab_freepip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_lot
            // 
            this.lab_lot.BackColor = System.Drawing.Color.White;
            this.lab_lot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_lot.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_lot.Location = new System.Drawing.Point(333, 2);
            this.lab_lot.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_lot.Name = "lab_lot";
            this.lab_lot.Size = new System.Drawing.Size(74, 28);
            this.lab_lot.TabIndex = 3;
            this.lab_lot.Text = "LOT";
            this.lab_lot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_curr
            // 
            this.lab_curr.BackColor = System.Drawing.Color.White;
            this.lab_curr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_curr.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_curr.Location = new System.Drawing.Point(257, 2);
            this.lab_curr.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_curr.Name = "lab_curr";
            this.lab_curr.Size = new System.Drawing.Size(74, 28);
            this.lab_curr.TabIndex = 2;
            this.lab_curr.Text = "CURR";
            this.lab_curr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_account
            // 
            this.lab_account.BackColor = System.Drawing.Color.White;
            this.lab_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_account.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_account.Location = new System.Drawing.Point(115, 2);
            this.lab_account.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_account.Name = "lab_account";
            this.lab_account.Size = new System.Drawing.Size(140, 28);
            this.lab_account.TabIndex = 1;
            this.lab_account.Text = "ACCOUNT NO.";
            this.lab_account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_client
            // 
            this.lab_client.BackColor = System.Drawing.Color.White;
            this.lab_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_client.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_client.Location = new System.Drawing.Point(1, 2);
            this.lab_client.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lab_client.Name = "lab_client";
            this.lab_client.Size = new System.Drawing.Size(112, 28);
            this.lab_client.TabIndex = 0;
            this.lab_client.Text = "CLIENT";
            this.lab_client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderPAMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HeaderPAMM";
            this.Size = new System.Drawing.Size(950, 32);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_header;
        private System.Windows.Forms.Label lab_onoff;
        private System.Windows.Forms.Label lab_slave_percent;
        private System.Windows.Forms.Label lab_percent;
        private System.Windows.Forms.Label lab_load;
        private System.Windows.Forms.Label lab_margin;
        private System.Windows.Forms.Label lab_freepip;
        private System.Windows.Forms.Label lab_lot;
        private System.Windows.Forms.Label lab_curr;
        private System.Windows.Forms.Label lab_account;
        private System.Windows.Forms.Label lab_client;
    }
}
