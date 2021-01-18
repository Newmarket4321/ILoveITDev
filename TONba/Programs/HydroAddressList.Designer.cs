namespace I_IT.Programs
{
    partial class HydroAddressList
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
            this.RollNo = new System.Windows.Forms.TextBox();
            this.OldAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RollNo
            // 
            this.RollNo.Location = new System.Drawing.Point(239, 102);
            this.RollNo.MaxLength = 19;
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(196, 20);
            this.RollNo.TabIndex = 81;
            // 
            // OldAdd
            // 
            this.OldAdd.Location = new System.Drawing.Point(239, 66);
            this.OldAdd.MaxLength = 30;
            this.OldAdd.Name = "OldAdd";
            this.OldAdd.Size = new System.Drawing.Size(196, 20);
            this.OldAdd.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "RollNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "OldAddress";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 32);
            this.button1.TabIndex = 82;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HydroAddressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RollNo);
            this.Controls.Add(this.OldAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "HydroAddressList";
            this.Text = "HydroAddressList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RollNo;
        private System.Windows.Forms.TextBox OldAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}