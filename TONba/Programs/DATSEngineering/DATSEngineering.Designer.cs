namespace I_IT
{
    partial class DATSEngineering
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Tom", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Jeff", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Frank", System.Windows.Forms.HorizontalAlignment.Left);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.resultsList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timesheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.notApprovedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notExportedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paychequesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prePeriodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendDataToJDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingApprovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hoursCalendar1 = new I_IT.HoursCalendar();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 800;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Myriad Pro", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(0, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 32);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Myriad Pro", 15F);
            this.button1.Location = new System.Drawing.Point(313, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Myriad Pro", 15F);
            this.button2.Location = new System.Drawing.Point(344, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "MMMM dd, yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Myriad Pro", 14F);
            this.dateTimePicker1.Location = new System.Drawing.Point(682, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 30);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2015, 9, 27, 8, 48, 0, 0);
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.dateTimePicker1_DropDown);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CustomFormat = "MMMM dd, yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Myriad Pro", 14F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(883, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(201, 30);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.DropDown += new System.EventHandler(this.dateTimePicker2_DropDown);
            // 
            // resultsList
            // 
            this.resultsList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.resultsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader1});
            this.resultsList.FullRowSelect = true;
            listViewGroup4.Header = "Tom";
            listViewGroup4.Name = "Tom";
            listViewGroup5.Header = "Jeff";
            listViewGroup5.Name = "Jeff";
            listViewGroup6.Header = "Frank";
            listViewGroup6.Name = "Frank";
            this.resultsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.resultsList.HideSelection = false;
            this.resultsList.Location = new System.Drawing.Point(1, 202);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(1083, 290);
            this.resultsList.TabIndex = 60;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            this.resultsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resultsList_MouseClick);
            this.resultsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultsList_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hours";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Work Order";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "";
            this.columnHeader7.Text = "Status";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesheetsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.managementOptionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.approveToolStripMenuItem,
            this.pendingApprovalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 36);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timesheetsToolStripMenuItem
            // 
            this.timesheetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.exportToExcelToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.timesheetsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.timesheetsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.timesheetsToolStripMenuItem.Name = "timesheetsToolStripMenuItem";
            this.timesheetsToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.timesheetsToolStripMenuItem.Text = "Timesheets";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(213, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notApprovedToolStripMenuItem1,
            this.notExportedToolStripMenuItem1,
            this.paychequesToolStripMenuItem,
            this.prePeriodToolStripMenuItem1,
            this.workOrderUsageToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(91, 32);
            this.toolStripMenuItem2.Text = "Reports";
            // 
            // notApprovedToolStripMenuItem1
            // 
            this.notApprovedToolStripMenuItem1.Name = "notApprovedToolStripMenuItem1";
            this.notApprovedToolStripMenuItem1.Size = new System.Drawing.Size(246, 32);
            this.notApprovedToolStripMenuItem1.Text = "Not Approved";
            this.notApprovedToolStripMenuItem1.Click += new System.EventHandler(this.notApprovedToolStripMenuItem1_Click);
            // 
            // notExportedToolStripMenuItem1
            // 
            this.notExportedToolStripMenuItem1.Name = "notExportedToolStripMenuItem1";
            this.notExportedToolStripMenuItem1.Size = new System.Drawing.Size(246, 32);
            this.notExportedToolStripMenuItem1.Text = "Not Exported";
            this.notExportedToolStripMenuItem1.Click += new System.EventHandler(this.notExportedToolStripMenuItem1_Click);
            // 
            // paychequesToolStripMenuItem
            // 
            this.paychequesToolStripMenuItem.Name = "paychequesToolStripMenuItem";
            this.paychequesToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.paychequesToolStripMenuItem.Text = "Paycheques";
            this.paychequesToolStripMenuItem.Click += new System.EventHandler(this.paychequesToolStripMenuItem_Click);
            // 
            // prePeriodToolStripMenuItem1
            // 
            this.prePeriodToolStripMenuItem1.Name = "prePeriodToolStripMenuItem1";
            this.prePeriodToolStripMenuItem1.Size = new System.Drawing.Size(246, 32);
            this.prePeriodToolStripMenuItem1.Text = "Pre-Period";
            this.prePeriodToolStripMenuItem1.Click += new System.EventHandler(this.prePeriodToolStripMenuItem1_Click);
            // 
            // workOrderUsageToolStripMenuItem
            // 
            this.workOrderUsageToolStripMenuItem.Name = "workOrderUsageToolStripMenuItem";
            this.workOrderUsageToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.workOrderUsageToolStripMenuItem.Text = "Work Order Usage";
            this.workOrderUsageToolStripMenuItem.Click += new System.EventHandler(this.workOrderUsageToolStripMenuItem_Click);
            // 
            // managementOptionsToolStripMenuItem
            // 
            this.managementOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountsToolStripMenuItem,
            this.loginHistoryToolStripMenuItem,
            this.payrollToolStripMenuItem});
            this.managementOptionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementOptionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.managementOptionsToolStripMenuItem.Name = "managementOptionsToolStripMenuItem";
            this.managementOptionsToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.managementOptionsToolStripMenuItem.Text = "Management Options";
            // 
            // manageAccountsToolStripMenuItem
            // 
            this.manageAccountsToolStripMenuItem.Name = "manageAccountsToolStripMenuItem";
            this.manageAccountsToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.manageAccountsToolStripMenuItem.Text = "Manage Accounts";
            this.manageAccountsToolStripMenuItem.Click += new System.EventHandler(this.manageAccountsToolStripMenuItem_Click);
            // 
            // loginHistoryToolStripMenuItem
            // 
            this.loginHistoryToolStripMenuItem.Name = "loginHistoryToolStripMenuItem";
            this.loginHistoryToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.loginHistoryToolStripMenuItem.Text = "Login History";
            this.loginHistoryToolStripMenuItem.Click += new System.EventHandler(this.loginHistoryToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.sendDataToJDEToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // sendDataToJDEToolStripMenuItem
            // 
            this.sendDataToJDEToolStripMenuItem.Name = "sendDataToJDEToolStripMenuItem";
            this.sendDataToJDEToolStripMenuItem.Size = new System.Drawing.Size(265, 32);
            this.sendDataToJDEToolStripMenuItem.Text = "Send Data to JDE (S)";
            this.sendDataToJDEToolStripMenuItem.Click += new System.EventHandler(this.sendDataToJDEToolStripMenuItem_Click2);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 32);
            this.toolStripMenuItem1.Text = "Select All";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.approveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // pendingApprovalToolStripMenuItem
            // 
            this.pendingApprovalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pendingApprovalToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.pendingApprovalToolStripMenuItem.Name = "pendingApprovalToolStripMenuItem";
            this.pendingApprovalToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.pendingApprovalToolStripMenuItem.Text = "Unapprove";
            this.pendingApprovalToolStripMenuItem.Click += new System.EventHandler(this.pendingApprovalToolStripMenuItem_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Myriad Pro", 14F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(744, 38);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(340, 31);
            this.comboBox3.TabIndex = 71;
            this.comboBox3.DropDownClosed += new System.EventHandler(this.comboBox3_DropDownClosed);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Myriad Pro", 15F);
            this.button3.Location = new System.Drawing.Point(712, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 33);
            this.button3.TabIndex = 74;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Myriad Pro", 15F);
            this.button4.Location = new System.Drawing.Point(681, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 33);
            this.button4.TabIndex = 73;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hoursCalendar1
            // 
            this.hoursCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursCalendar1.BackColor = System.Drawing.SystemColors.Control;
            this.hoursCalendar1.Location = new System.Drawing.Point(1, 99);
            this.hoursCalendar1.Name = "hoursCalendar1";
            this.hoursCalendar1.Size = new System.Drawing.Size(1083, 104);
            this.hoursCalendar1.TabIndex = 76;
            this.hoursCalendar1.DayClicked += new I_IT.HoursCalendar.CalendarEventHandler(this.hoursCalendar1_DayClicked);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(265, 32);
            this.toolStripMenuItem3.Text = "Send Data to JDE (H)";
            // 
            // DATSEngineering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 490);
            this.Controls.Add(this.hoursCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.KeyPreview = true;
            this.Name = "DATSEngineering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Timesheets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Profile_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem timesheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingApprovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem managementOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendDataToJDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paychequesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notApprovedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notExportedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prePeriodToolStripMenuItem1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem workOrderUsageToolStripMenuItem;
        private HoursCalendar hoursCalendar1;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}