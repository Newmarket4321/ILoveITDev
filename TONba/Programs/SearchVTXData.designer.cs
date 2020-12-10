namespace I_IT
{
    partial class SearchVTXData
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRoll = new System.Windows.Forms.CheckBox();
            this.chkLoc = new System.Windows.Forms.CheckBox();
            this.chkOwn = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOwner = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.LocationText = new System.Windows.Forms.TextBox();
            this.OwnerText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll Number";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(220, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roll";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loc";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Own";
            this.label4.Visible = false;
            // 
            // chkRoll
            // 
            this.chkRoll.AutoSize = true;
            this.chkRoll.Checked = true;
            this.chkRoll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoll.Location = new System.Drawing.Point(103, 86);
            this.chkRoll.Name = "chkRoll";
            this.chkRoll.Size = new System.Drawing.Size(22, 21);
            this.chkRoll.TabIndex = 10;
            this.chkRoll.UseVisualStyleBackColor = true;
            this.chkRoll.CheckedChanged += new System.EventHandler(this.chkRoll_CheckedChanged);
            // 
            // chkLoc
            // 
            this.chkLoc.AutoSize = true;
            this.chkLoc.Location = new System.Drawing.Point(103, 141);
            this.chkLoc.Name = "chkLoc";
            this.chkLoc.Size = new System.Drawing.Size(22, 21);
            this.chkLoc.TabIndex = 11;
            this.chkLoc.UseVisualStyleBackColor = true;
            this.chkLoc.Visible = false;
            this.chkLoc.CheckedChanged += new System.EventHandler(this.chkLoc_CheckedChanged);
            // 
            // chkOwn
            // 
            this.chkOwn.AutoSize = true;
            this.chkOwn.Location = new System.Drawing.Point(103, 191);
            this.chkOwn.Name = "chkOwn";
            this.chkOwn.Size = new System.Drawing.Size(22, 21);
            this.chkOwn.TabIndex = 12;
            this.chkOwn.UseVisualStyleBackColor = true;
            this.chkOwn.Visible = false;
            this.chkOwn.CheckedChanged += new System.EventHandler(this.chkOwn_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(164, 86);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 31);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(160, 141);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(449, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(160, 191);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(67, 24);
            this.lblOwner.TabIndex = 16;
            this.lblOwner.Text = "Owner";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(164, 33);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 31);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "1948";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(219, 227);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(214, 28);
            this.dtpTo.TabIndex = 18;
            this.dtpTo.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Transactions from:";
            // 
            // LocationText
            // 
            this.LocationText.Location = new System.Drawing.Point(273, 141);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(361, 28);
            this.LocationText.TabIndex = 20;
            // 
            // OwnerText
            // 
            this.OwnerText.Location = new System.Drawing.Point(273, 186);
            this.OwnerText.Name = "OwnerText";
            this.OwnerText.Size = new System.Drawing.Size(361, 28);
            this.OwnerText.TabIndex = 21;
            // 
            // SearchVTXData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 297);
            this.Controls.Add(this.OwnerText);
            this.Controls.Add(this.LocationText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chkOwn);
            this.Controls.Add(this.chkLoc);
            this.Controls.Add(this.chkRoll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchVTXData";
            this.Text = "Search Vailtech Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRoll;
        private System.Windows.Forms.CheckBox chkLoc;
        private System.Windows.Forms.CheckBox chkOwn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LocationText;
        private System.Windows.Forms.TextBox OwnerText;
    }
}