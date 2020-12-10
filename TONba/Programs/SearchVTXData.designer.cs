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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkRoll = new System.Windows.Forms.CheckBox();
            this.chkLoc = new System.Windows.Forms.CheckBox();
            this.chkOwn = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.LocationText = new System.Windows.Forms.TextBox();
            this.OwnerText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(255, 88);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkRoll
            // 
            this.chkRoll.AutoSize = true;
            this.chkRoll.Checked = true;
            this.chkRoll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoll.Location = new System.Drawing.Point(50, 91);
            this.chkRoll.Name = "chkRoll";
            this.chkRoll.Size = new System.Drawing.Size(142, 28);
            this.chkRoll.TabIndex = 10;
            this.chkRoll.Text = "Roll Number";
            this.chkRoll.UseVisualStyleBackColor = true;
            this.chkRoll.CheckedChanged += new System.EventHandler(this.chkRoll_CheckedChanged);
            // 
            // chkLoc
            // 
            this.chkLoc.AutoSize = true;
            this.chkLoc.Location = new System.Drawing.Point(50, 141);
            this.chkLoc.Name = "chkLoc";
            this.chkLoc.Size = new System.Drawing.Size(106, 28);
            this.chkLoc.TabIndex = 11;
            this.chkLoc.Text = "Address";
            this.chkLoc.UseVisualStyleBackColor = true;
            this.chkLoc.CheckedChanged += new System.EventHandler(this.chkLoc_CheckedChanged);
            // 
            // chkOwn
            // 
            this.chkOwn.AutoSize = true;
            this.chkOwn.Location = new System.Drawing.Point(50, 187);
            this.chkOwn.Name = "chkOwn";
            this.chkOwn.Size = new System.Drawing.Size(93, 28);
            this.chkOwn.TabIndex = 12;
            this.chkOwn.Text = "Owner";
            this.chkOwn.UseVisualStyleBackColor = true;
            this.chkOwn.CheckedChanged += new System.EventHandler(this.chkOwn_CheckedChanged);
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
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(199, 88);
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
            this.LocationText.Location = new System.Drawing.Point(199, 141);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(361, 28);
            this.LocationText.TabIndex = 20;
            // 
            // OwnerText
            // 
            this.OwnerText.Location = new System.Drawing.Point(199, 186);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkOwn);
            this.Controls.Add(this.chkLoc);
            this.Controls.Add(this.chkRoll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchVTXData";
            this.Text = "Search Vailtech Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkRoll;
        private System.Windows.Forms.CheckBox chkLoc;
        private System.Windows.Forms.CheckBox chkOwn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LocationText;
        private System.Windows.Forms.TextBox OwnerText;
    }
}