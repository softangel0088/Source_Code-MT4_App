namespace FXFellowDashboard
{
    partial class OrderHeaderCtrl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_closeat = new System.Windows.Forms.Label();
            this.lab_PnL = new System.Windows.Forms.Label();
            this.lab_swap = new System.Windows.Forms.Label();
            this.lab_closed = new System.Windows.Forms.Label();
            this.lab_active = new System.Windows.Forms.Label();
            this.lab_lot = new System.Windows.Forms.Label();
            this.lab_currency = new System.Windows.Forms.Label();
            this.lab_account = new System.Windows.Forms.Label();
            this.lab_commission = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lab_closeat, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_PnL, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_swap, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_closed, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_active, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_lot, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_currency, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_account, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_commission, 8, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lab_closeat
            // 
            this.lab_closeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_closeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_closeat.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_closeat.Location = new System.Drawing.Point(596, 1);
            this.lab_closeat.Margin = new System.Windows.Forms.Padding(1);
            this.lab_closeat.Name = "lab_closeat";
            this.lab_closeat.Size = new System.Drawing.Size(83, 24);
            this.lab_closeat.TabIndex = 7;
            this.lab_closeat.Text = "SL / TP";
            this.lab_closeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_closeat.Click += new System.EventHandler(this.lab_closeat_Click);
            // 
            // lab_PnL
            // 
            this.lab_PnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_PnL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_PnL.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_PnL.Location = new System.Drawing.Point(511, 1);
            this.lab_PnL.Margin = new System.Windows.Forms.Padding(1);
            this.lab_PnL.Name = "lab_PnL";
            this.lab_PnL.Size = new System.Drawing.Size(83, 24);
            this.lab_PnL.TabIndex = 6;
            this.lab_PnL.Text = "PROFIT/LOSS";
            this.lab_PnL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_PnL.Click += new System.EventHandler(this.lab_PnL_Click);
            // 
            // lab_swap
            // 
            this.lab_swap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_swap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_swap.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_swap.Location = new System.Drawing.Point(426, 1);
            this.lab_swap.Margin = new System.Windows.Forms.Padding(1);
            this.lab_swap.Name = "lab_swap";
            this.lab_swap.Size = new System.Drawing.Size(83, 24);
            this.lab_swap.TabIndex = 5;
            this.lab_swap.Text = "SWAP";
            this.lab_swap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_swap.Click += new System.EventHandler(this.lab_swap_Click);
            // 
            // lab_closed
            // 
            this.lab_closed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_closed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_closed.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_closed.Location = new System.Drawing.Point(341, 1);
            this.lab_closed.Margin = new System.Windows.Forms.Padding(1);
            this.lab_closed.Name = "lab_closed";
            this.lab_closed.Size = new System.Drawing.Size(83, 24);
            this.lab_closed.TabIndex = 4;
            this.lab_closed.Text = "SPREAD";
            this.lab_closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_closed.Click += new System.EventHandler(this.lab_closed_Click);
            // 
            // lab_active
            // 
            this.lab_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_active.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_active.Location = new System.Drawing.Point(256, 1);
            this.lab_active.Margin = new System.Windows.Forms.Padding(1);
            this.lab_active.Name = "lab_active";
            this.lab_active.Size = new System.Drawing.Size(83, 24);
            this.lab_active.TabIndex = 3;
            this.lab_active.Text = "ACTIVE";
            this.lab_active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_active.Click += new System.EventHandler(this.lab_active_Click);
            // 
            // lab_lot
            // 
            this.lab_lot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_lot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_lot.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_lot.Location = new System.Drawing.Point(171, 1);
            this.lab_lot.Margin = new System.Windows.Forms.Padding(1);
            this.lab_lot.Name = "lab_lot";
            this.lab_lot.Size = new System.Drawing.Size(83, 24);
            this.lab_lot.TabIndex = 2;
            this.lab_lot.Text = "LOT";
            this.lab_lot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_lot.Click += new System.EventHandler(this.lab_lot_Click);
            // 
            // lab_currency
            // 
            this.lab_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_currency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_currency.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_currency.Location = new System.Drawing.Point(86, 1);
            this.lab_currency.Margin = new System.Windows.Forms.Padding(1);
            this.lab_currency.Name = "lab_currency";
            this.lab_currency.Size = new System.Drawing.Size(83, 24);
            this.lab_currency.TabIndex = 1;
            this.lab_currency.Text = "CURRENCY";
            this.lab_currency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_currency.Click += new System.EventHandler(this.lab_currency_Click);
            // 
            // lab_account
            // 
            this.lab_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_account.Font = new System.Drawing.Font("Roboto", 8F);
            this.lab_account.Location = new System.Drawing.Point(1, 1);
            this.lab_account.Margin = new System.Windows.Forms.Padding(1);
            this.lab_account.Name = "lab_account";
            this.lab_account.Size = new System.Drawing.Size(83, 24);
            this.lab_account.TabIndex = 0;
            this.lab_account.Text = "ACCOUNT";
            this.lab_account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_account.Click += new System.EventHandler(this.lab_account_Click);
            // 
            // lab_commission
            // 
            this.lab_commission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lab_commission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_commission.Font = new System.Drawing.Font("Roboto", 9F);
            this.lab_commission.Location = new System.Drawing.Point(681, 1);
            this.lab_commission.Margin = new System.Windows.Forms.Padding(1);
            this.lab_commission.Name = "lab_commission";
            this.lab_commission.Size = new System.Drawing.Size(88, 24);
            this.lab_commission.TabIndex = 8;
            this.lab_commission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_commission.Click += new System.EventHandler(this.lab_commission_Click);
            // 
            // OrderHeaderCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OrderHeaderCtrl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Size = new System.Drawing.Size(800, 26);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab_closeat;
        private System.Windows.Forms.Label lab_PnL;
        private System.Windows.Forms.Label lab_swap;
        private System.Windows.Forms.Label lab_closed;
        private System.Windows.Forms.Label lab_active;
        private System.Windows.Forms.Label lab_lot;
        private System.Windows.Forms.Label lab_currency;
        private System.Windows.Forms.Label lab_account;
        private System.Windows.Forms.Label lab_commission;
    }
}
