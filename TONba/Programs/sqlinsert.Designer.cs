namespace I_IT
{
    partial class sqlinsert
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
            this.btnCashEntries = new System.Windows.Forms.Button();
            this.btnPostDated = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCashEntries
            // 
            this.btnCashEntries.Location = new System.Drawing.Point(196, 72);
            this.btnCashEntries.Name = "btnCashEntries";
            this.btnCashEntries.Size = new System.Drawing.Size(75, 23);
            this.btnCashEntries.TabIndex = 0;
            this.btnCashEntries.Text = "Cash Entries";
            this.btnCashEntries.UseVisualStyleBackColor = true;
            this.btnCashEntries.Click += new System.EventHandler(this.btnCashEntries_Click);
            // 
            // btnPostDated
            // 
            this.btnPostDated.Location = new System.Drawing.Point(413, 72);
            this.btnPostDated.Name = "btnPostDated";
            this.btnPostDated.Size = new System.Drawing.Size(75, 23);
            this.btnPostDated.TabIndex = 1;
            this.btnPostDated.Text = "Post Dated Cheques";
            this.btnPostDated.UseVisualStyleBackColor = true;
            this.btnPostDated.Click += new System.EventHandler(this.btnPostDated_Click);
            // 
            // sqlinsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPostDated);
            this.Controls.Add(this.btnCashEntries);
            this.Name = "sqlinsert";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCashEntries;
        private System.Windows.Forms.Button btnPostDated;
    }
}