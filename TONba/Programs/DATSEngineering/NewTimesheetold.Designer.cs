namespace I_IT
{
    partial class NewTimesheetold
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
            this.workOrderBar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateCalendar = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            this.SuspendLayout();
            // 
            // workOrderBar
            // 
            this.workOrderBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workOrderBar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workOrderBar.DropDownWidth = 390;
            this.workOrderBar.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.workOrderBar.FormattingEnabled = true;
            this.workOrderBar.IntegralHeight = false;
            this.workOrderBar.Location = new System.Drawing.Point(168, 250);
            this.workOrderBar.MaxDropDownItems = 15;
            this.workOrderBar.Name = "workOrderBar";
            this.workOrderBar.Size = new System.Drawing.Size(286, 32);
            this.workOrderBar.TabIndex = 2;
            this.workOrderBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 20F);
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 20F);
            this.label3.Location = new System.Drawing.Point(15, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Work Order";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(418, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 56);
            this.button2.TabIndex = 15;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 20F);
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hours";
            // 
            // dateCalendar
            // 
            this.dateCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateCalendar.Location = new System.Drawing.Point(168, 18);
            this.dateCalendar.MaxSelectionCount = 31;
            this.dateCalendar.Name = "dateCalendar";
            this.dateCalendar.TabIndex = 43;
            this.dateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateCalendar_DateSelected);
            this.dateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dateCalendar_DateSelected);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.button1.Location = new System.Drawing.Point(460, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 34);
            this.button1.TabIndex = 47;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(19, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Drag to select multiple days.";
            // 
            // hourBox
            // 
            this.hourBox.DecimalPlaces = 2;
            this.hourBox.Font = new System.Drawing.Font("Myriad Pro", 20F);
            this.hourBox.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.hourBox.Location = new System.Drawing.Point(168, 194);
            this.hourBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(91, 40);
            this.hourBox.TabIndex = 68;
            this.hourBox.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Calibri Light", 15F);
            this.textBox1.Location = new System.Drawing.Point(164, 304);
            this.textBox1.MaxLength = 8000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 136);
            this.textBox1.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 20F);
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 32);
            this.label5.TabIndex = 69;
            this.label5.Text = "Description";
            // 
            // NewTimesheetold
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateCalendar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workOrderBar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "NewTimesheetold";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Timesheet";
            this.Load += new System.EventHandler(this.NewTimesheetold_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewTimesheet_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox workOrderBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar dateCalendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown hourBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}