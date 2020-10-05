namespace I_IT
{
    partial class NewUserForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.finishDateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.Hardware = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Software = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Hardware.SuspendLayout();
            this.Software.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.nameBox.Location = new System.Drawing.Point(10, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(215, 27);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Employee Name";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.button1.Location = new System.Drawing.Point(824, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Hardware);
            this.tabControl1.Controls.Add(this.Software);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 545);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.finishDateBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.statusBox);
            this.tabPage1.Controls.Add(this.startDateBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.positionBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Information";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(329, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 27);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label7.Location = new System.Drawing.Point(325, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Previous Employee\'s Computer Name";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.textBox4.Location = new System.Drawing.Point(329, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(255, 27);
            this.textBox4.TabIndex = 15;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(329, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(357, 23);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "This new employee replaces a previous employee";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label6.Location = new System.Drawing.Point(325, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(242, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 23);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "N/A";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label5.Location = new System.Drawing.Point(6, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Finish Date";
            // 
            // finishDateBox
            // 
            this.finishDateBox.Location = new System.Drawing.Point(8, 305);
            this.finishDateBox.Name = "finishDateBox";
            this.finishDateBox.Size = new System.Drawing.Size(217, 27);
            this.finishDateBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label4.Location = new System.Drawing.Point(6, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Starting Date";
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Permanent",
            "Part Time",
            "Contract",
            "Student",
            "Other"});
            this.statusBox.Location = new System.Drawing.Point(10, 163);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(215, 27);
            this.statusBox.TabIndex = 7;
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(8, 235);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(217, 27);
            this.startDateBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position/Title";
            // 
            // positionBox
            // 
            this.positionBox.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.positionBox.Location = new System.Drawing.Point(10, 90);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(215, 27);
            this.positionBox.TabIndex = 2;
            // 
            // Hardware
            // 
            this.Hardware.AutoScroll = true;
            this.Hardware.BackColor = System.Drawing.SystemColors.Control;
            this.Hardware.Controls.Add(this.label21);
            this.Hardware.Controls.Add(this.label10);
            this.Hardware.Controls.Add(this.label8);
            this.Hardware.Location = new System.Drawing.Point(4, 28);
            this.Hardware.Name = "Hardware";
            this.Hardware.Padding = new System.Windows.Forms.Padding(3);
            this.Hardware.Size = new System.Drawing.Size(911, 513);
            this.Hardware.TabIndex = 1;
            this.Hardware.Text = "Hardware";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label10.Location = new System.Drawing.Point(631, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(905, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Costs are subject to change without notice. Values are approximate.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Software
            // 
            this.Software.AutoScroll = true;
            this.Software.BackColor = System.Drawing.SystemColors.Control;
            this.Software.Controls.Add(this.label11);
            this.Software.Controls.Add(this.label12);
            this.Software.Controls.Add(this.label20);
            this.Software.Location = new System.Drawing.Point(4, 28);
            this.Software.Name = "Software";
            this.Software.Padding = new System.Windows.Forms.Padding(3);
            this.Software.Size = new System.Drawing.Size(818, 386);
            this.Software.TabIndex = 2;
            this.Software.Text = "Software";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label11.Location = new System.Drawing.Point(463, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Account Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label12.Location = new System.Drawing.Point(188, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Item";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(3, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(812, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Costs are subject to change without notice. Values are approximate.";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.comboBox6);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.comboBox5);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.comboBox4);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.comboBox3);
            this.tabPage4.Controls.Add(this.textBox23);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.textBox22);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(745, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Additional Access";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label19.Location = new System.Drawing.Point(158, 240);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 19);
            this.label19.TabIndex = 80;
            this.label19.Text = "Tasks";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "-",
            "View Only",
            "Everything"});
            this.comboBox6.Location = new System.Drawing.Point(215, 237);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(159, 27);
            this.comboBox6.TabIndex = 79;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label18.Location = new System.Drawing.Point(140, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 19);
            this.label18.TabIndex = 78;
            this.label18.Text = "Contacts";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "-",
            "View Only",
            "Everything"});
            this.comboBox5.Location = new System.Drawing.Point(215, 204);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(159, 27);
            this.comboBox5.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label17.Location = new System.Drawing.Point(140, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 19);
            this.label17.TabIndex = 76;
            this.label17.Text = "Calendar";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "-",
            "View Only",
            "Everything"});
            this.comboBox4.Location = new System.Drawing.Point(215, 171);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(159, 27);
            this.comboBox4.TabIndex = 75;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label16.Location = new System.Drawing.Point(76, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(248, 19);
            this.label16.TabIndex = 74;
            this.label16.Text = "What areas will they need access to?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label13.Location = new System.Drawing.Point(158, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 73;
            this.label13.Text = "E-mail";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "-",
            "View Only",
            "Everything"});
            this.comboBox3.Location = new System.Drawing.Point(215, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 27);
            this.comboBox3.TabIndex = 72;
            // 
            // textBox23
            // 
            this.textBox23.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.textBox23.Location = new System.Drawing.Point(28, 346);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(419, 27);
            this.textBox23.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label15.Location = new System.Drawing.Point(24, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(350, 38);
            this.label15.TabIndex = 70;
            this.label15.Text = "Will your mailbox be administered by another user?\r\nIf so, please list them:";
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.textBox22.Location = new System.Drawing.Point(28, 61);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(419, 27);
            this.textBox22.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label14.Location = new System.Drawing.Point(24, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(423, 38);
            this.label14.TabIndex = 59;
            this.label14.Text = "Will the user need access to anyone else’s mailbox or calendar?\r\nIf so, please li" +
    "st them:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.label21.Location = new System.Drawing.Point(410, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 19);
            this.label21.TabIndex = 20;
            this.label21.Text = "Description";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User Form";
            this.Load += new System.EventHandler(this.Visa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OwnershipChangeReport_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Hardware.ResumeLayout(false);
            this.Hardware.PerformLayout();
            this.Software.ResumeLayout(false);
            this.Software.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker finishDateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.TabPage Hardware;
        private System.Windows.Forms.TabPage Software;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}