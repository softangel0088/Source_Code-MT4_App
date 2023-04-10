namespace FXFellowDashboard
{
    partial class ClientCtrl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientCtrl));
            this.tbl_layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_email_password = new System.Windows.Forms.TextBox();
            this.tbl_layout2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_stop_level2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_server2 = new System.Windows.Forms.ComboBox();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.tb_account2 = new System.Windows.Forms.TextBox();
            this.tb_password1 = new System.Windows.Forms.TextBox();
            this.lab_type2 = new System.Windows.Forms.Label();
            this.lab_type1 = new System.Windows.Forms.Label();
            this.tb_account1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_server1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_stop_level1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_con1 = new System.Windows.Forms.Label();
            this.lab_con2 = new System.Windows.Forms.Label();
            this.panel_name = new System.Windows.Forms.Panel();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbl_layout1.SuspendLayout();
            this.tbl_layout2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_name.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_layout1
            // 
            this.tbl_layout1.BackColor = System.Drawing.Color.White;
            this.tbl_layout1.ColumnCount = 4;
            this.tbl_layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbl_layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tbl_layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tbl_layout1.Controls.Add(this.tb_email_password, 1, 1);
            this.tbl_layout1.Controls.Add(this.tbl_layout2, 0, 0);
            this.tbl_layout1.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tbl_layout1.Controls.Add(this.panel_name, 1, 0);
            this.tbl_layout1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tbl_layout1.Controls.Add(this.btn_delete, 3, 0);
            this.tbl_layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_layout1.Location = new System.Drawing.Point(0, 0);
            this.tbl_layout1.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_layout1.Name = "tbl_layout1";
            this.tbl_layout1.RowCount = 2;
            this.tbl_layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tbl_layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_layout1.Size = new System.Drawing.Size(600, 98);
            this.tbl_layout1.TabIndex = 0;
            // 
            // tb_email_password
            // 
            this.tb_email_password.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_email_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_email_password.Font = new System.Drawing.Font("Roboto", 10F);
            this.tb_email_password.Location = new System.Drawing.Point(420, 68);
            this.tb_email_password.Name = "tb_email_password";
            this.tb_email_password.Size = new System.Drawing.Size(133, 24);
            this.tb_email_password.TabIndex = 14;
            this.tb_email_password.Text = "Password";
            this.tb_email_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_email_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_email_password_MouseClick);
            this.tb_email_password.DoubleClick += new System.EventHandler(this.dbl_click);
            this.tb_email_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_setting_KeyPress);
            // 
            // tbl_layout2
            // 
            this.tbl_layout2.ColumnCount = 5;
            this.tbl_layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tbl_layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.5F));
            this.tbl_layout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tbl_layout2.Controls.Add(this.panel4, 2, 1);
            this.tbl_layout2.Controls.Add(this.panel2, 0, 1);
            this.tbl_layout2.Controls.Add(this.tb_password2, 4, 1);
            this.tbl_layout2.Controls.Add(this.tb_account2, 3, 1);
            this.tbl_layout2.Controls.Add(this.tb_password1, 4, 0);
            this.tbl_layout2.Controls.Add(this.lab_type2, 1, 1);
            this.tbl_layout2.Controls.Add(this.lab_type1, 1, 0);
            this.tbl_layout2.Controls.Add(this.tb_account1, 3, 0);
            this.tbl_layout2.Controls.Add(this.panel1, 0, 0);
            this.tbl_layout2.Controls.Add(this.panel3, 2, 0);
            this.tbl_layout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_layout2.Location = new System.Drawing.Point(0, 0);
            this.tbl_layout2.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_layout2.Name = "tbl_layout2";
            this.tbl_layout2.RowCount = 2;
            this.tbl_layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layout2.Size = new System.Drawing.Size(417, 65);
            this.tbl_layout2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.Controls.Add(this.tb_stop_level2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(232, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panel4.Size = new System.Drawing.Size(46, 29);
            this.panel4.TabIndex = 20;
            // 
            // tb_stop_level2
            // 
            this.tb_stop_level2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tb_stop_level2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stop_level2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_stop_level2.Font = new System.Drawing.Font("Roboto", 9F);
            this.tb_stop_level2.Location = new System.Drawing.Point(0, 7);
            this.tb_stop_level2.Margin = new System.Windows.Forms.Padding(0);
            this.tb_stop_level2.Name = "tb_stop_level2";
            this.tb_stop_level2.Size = new System.Drawing.Size(46, 15);
            this.tb_stop_level2.TabIndex = 19;
            this.tb_stop_level2.Text = "10";
            this.tb_stop_level2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_stop_level2.DoubleClick += new System.EventHandler(this.dbl_click);
            this.tb_stop_level2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_setting_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.cb_server2);
            this.panel2.Location = new System.Drawing.Point(2, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 28);
            this.panel2.TabIndex = 16;
            // 
            // cb_server2
            // 
            this.cb_server2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_server2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_server2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_server2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_server2.FormattingEnabled = true;
            this.cb_server2.Location = new System.Drawing.Point(0, 3);
            this.cb_server2.Margin = new System.Windows.Forms.Padding(0);
            this.cb_server2.Name = "cb_server2";
            this.cb_server2.Size = new System.Drawing.Size(176, 23);
            this.cb_server2.TabIndex = 1;
            this.cb_server2.TabStop = false;
            // 
            // tb_password2
            // 
            this.tb_password2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tb_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_password2.Font = new System.Drawing.Font("Roboto", 10F);
            this.tb_password2.Location = new System.Drawing.Point(361, 35);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.Size = new System.Drawing.Size(53, 24);
            this.tb_password2.TabIndex = 14;
            this.tb_password2.Text = "Password";
            this.tb_password2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_password2_MouseClick);
            this.tb_password2.DoubleClick += new System.EventHandler(this.dbl_click);
            // 
            // tb_account2
            // 
            this.tb_account2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tb_account2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_account2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_account2.Font = new System.Drawing.Font("Roboto", 10F);
            this.tb_account2.Location = new System.Drawing.Point(283, 35);
            this.tb_account2.Name = "tb_account2";
            this.tb_account2.Size = new System.Drawing.Size(72, 24);
            this.tb_account2.TabIndex = 13;
            this.tb_account2.Text = "130";
            this.tb_account2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_account2_MouseClick);
            this.tb_account2.DoubleClick += new System.EventHandler(this.dbl_click);
            // 
            // tb_password1
            // 
            this.tb_password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tb_password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_password1.Font = new System.Drawing.Font("Roboto", 10F);
            this.tb_password1.Location = new System.Drawing.Point(361, 3);
            this.tb_password1.Name = "tb_password1";
            this.tb_password1.Size = new System.Drawing.Size(53, 24);
            this.tb_password1.TabIndex = 12;
            this.tb_password1.Text = "Password";
            this.tb_password1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_password1_MouseClick);
            this.tb_password1.DoubleClick += new System.EventHandler(this.dbl_click);
            // 
            // lab_type2
            // 
            this.lab_type2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lab_type2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_type2.Font = new System.Drawing.Font("Roboto", 9F);
            this.lab_type2.Location = new System.Drawing.Point(182, 34);
            this.lab_type2.Margin = new System.Windows.Forms.Padding(2);
            this.lab_type2.Name = "lab_type2";
            this.lab_type2.Size = new System.Drawing.Size(46, 29);
            this.lab_type2.TabIndex = 9;
            this.lab_type2.Text = "SF";
            this.lab_type2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_type2.DoubleClick += new System.EventHandler(this.dbl_click);
            // 
            // lab_type1
            // 
            this.lab_type1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lab_type1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_type1.Font = new System.Drawing.Font("Roboto", 9F);
            this.lab_type1.Location = new System.Drawing.Point(182, 2);
            this.lab_type1.Margin = new System.Windows.Forms.Padding(2);
            this.lab_type1.Name = "lab_type1";
            this.lab_type1.Size = new System.Drawing.Size(46, 28);
            this.lab_type1.TabIndex = 4;
            this.lab_type1.Text = "ECN";
            this.lab_type1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_type1.DoubleClick += new System.EventHandler(this.dbl_click);
            // 
            // tb_account1
            // 
            this.tb_account1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tb_account1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_account1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_account1.Font = new System.Drawing.Font("Roboto", 10F);
            this.tb_account1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_account1.Location = new System.Drawing.Point(283, 3);
            this.tb_account1.Name = "tb_account1";
            this.tb_account1.Size = new System.Drawing.Size(72, 24);
            this.tb_account1.TabIndex = 11;
            this.tb_account1.Text = "180";
            this.tb_account1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_account1_MouseClick);
            this.tb_account1.DoubleClick += new System.EventHandler(this.dbl_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.cb_server1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 28);
            this.panel1.TabIndex = 15;
            // 
            // cb_server1
            // 
            this.cb_server1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_server1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_server1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_server1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cb_server1.FormattingEnabled = true;
            this.cb_server1.Location = new System.Drawing.Point(0, 3);
            this.cb_server1.Margin = new System.Windows.Forms.Padding(0);
            this.cb_server1.Name = "cb_server1";
            this.cb_server1.Size = new System.Drawing.Size(176, 23);
            this.cb_server1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.tb_stop_level1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(232, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panel3.Size = new System.Drawing.Size(46, 28);
            this.panel3.TabIndex = 19;
            // 
            // tb_stop_level1
            // 
            this.tb_stop_level1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tb_stop_level1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stop_level1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_stop_level1.Font = new System.Drawing.Font("Roboto", 9F);
            this.tb_stop_level1.Location = new System.Drawing.Point(0, 7);
            this.tb_stop_level1.Margin = new System.Windows.Forms.Padding(0);
            this.tb_stop_level1.Name = "tb_stop_level1";
            this.tb_stop_level1.Size = new System.Drawing.Size(46, 15);
            this.tb_stop_level1.TabIndex = 19;
            this.tb_stop_level1.Text = "10";
            this.tb_stop_level1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_stop_level1.DoubleClick += new System.EventHandler(this.dbl_click);
            this.tb_stop_level1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_setting_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lab_con1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lab_con2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(556, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(10, 65);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lab_con1
            // 
            this.lab_con1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_con1.AutoSize = true;
            this.lab_con1.BackColor = System.Drawing.Color.Gray;
            this.lab_con1.Location = new System.Drawing.Point(2, 3);
            this.lab_con1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.lab_con1.Name = "lab_con1";
            this.lab_con1.Size = new System.Drawing.Size(6, 27);
            this.lab_con1.TabIndex = 0;
            this.lab_con1.Text = "label12";
            // 
            // lab_con2
            // 
            this.lab_con2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_con2.AutoSize = true;
            this.lab_con2.BackColor = System.Drawing.Color.Gray;
            this.lab_con2.Location = new System.Drawing.Point(2, 34);
            this.lab_con2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.lab_con2.Name = "lab_con2";
            this.lab_con2.Size = new System.Drawing.Size(6, 28);
            this.lab_con2.TabIndex = 1;
            this.lab_con2.Text = "label13";
            // 
            // panel_name
            // 
            this.panel_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_name.Controls.Add(this.tb_name);
            this.panel_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_name.Location = new System.Drawing.Point(420, 3);
            this.panel_name.Name = "panel_name";
            this.panel_name.Size = new System.Drawing.Size(133, 59);
            this.panel_name.TabIndex = 2;
            this.panel_name.DoubleClick += new System.EventHandler(this.dbl_click);
            this.panel_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_name_MouseClick);
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Roboto", 9F);
            this.tb_name.Location = new System.Drawing.Point(-60, 19);
            this.tb_name.Margin = new System.Windows.Forms.Padding(0);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(252, 15);
            this.tb_name.TabIndex = 13;
            this.tb_name.Text = "Name";
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_name_MouseClick);
            this.tb_name.DoubleClick += new System.EventHandler(this.dbl_click);
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_setting_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tb_email, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(417, 33);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_email.Font = new System.Drawing.Font("Roboto", 10F);
            this.tb_email.Location = new System.Drawing.Point(283, 3);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(131, 24);
            this.tb_email.TabIndex = 14;
            this.tb_email.Text = "Mail Address";
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_email_MouseClick);
            this.tb_email.DoubleClick += new System.EventHandler(this.dbl_click);
            this.tb_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_setting_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F);
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "BACKEND LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.DoubleClick += new System.EventHandler(this.dbl_click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageActive = null;
            this.btn_delete.Location = new System.Drawing.Point(568, 2);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(30, 61);
            this.btn_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_delete.TabIndex = 15;
            this.btn_delete.TabStop = false;
            this.btn_delete.Zoom = 20;
            this.btn_delete.Click += new System.EventHandler(this.delete_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ClientCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbl_layout1);
            this.Name = "ClientCtrl";
            this.Size = new System.Drawing.Size(600, 98);
            this.tbl_layout1.ResumeLayout(false);
            this.tbl_layout1.PerformLayout();
            this.tbl_layout2.ResumeLayout(false);
            this.tbl_layout2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_name.ResumeLayout(false);
            this.panel_name.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_layout1;
        private System.Windows.Forms.TableLayoutPanel tbl_layout2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab_type2;
        private System.Windows.Forms.Label lab_type1;
        private System.Windows.Forms.Label lab_con1;
        private System.Windows.Forms.Label lab_con2;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.TextBox tb_account2;
        private System.Windows.Forms.TextBox tb_password1;
        private System.Windows.Forms.TextBox tb_account1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_email_password;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_server1;
        private System.Windows.Forms.ComboBox cb_server2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_stop_level2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_stop_level1;
    }
}
