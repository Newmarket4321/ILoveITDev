namespace I_IT
{
    partial class TransactionDistribution
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbOwner3 = new System.Windows.Forms.TextBox();
            this.tbOwner2 = new System.Windows.Forms.TextBox();
            this.tbActivityNumber = new System.Windows.Forms.TextBox();
            this.tbStreetUnit = new System.Windows.Forms.TextBox();
            this.tbStreetQual = new System.Windows.Forms.TextBox();
            this.tbStreetName = new System.Windows.Forms.TextBox();
            this.tbStreetNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOwner1 = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.tbRollNumber = new System.Windows.Forms.TextBox();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.dgTransactionDistributions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactionDistributions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(339, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbOwner3
            // 
            this.tbOwner3.Location = new System.Drawing.Point(81, 112);
            this.tbOwner3.Name = "tbOwner3";
            this.tbOwner3.Size = new System.Drawing.Size(201, 20);
            this.tbOwner3.TabIndex = 24;
            // 
            // tbOwner2
            // 
            this.tbOwner2.Location = new System.Drawing.Point(81, 86);
            this.tbOwner2.Name = "tbOwner2";
            this.tbOwner2.Size = new System.Drawing.Size(201, 20);
            this.tbOwner2.TabIndex = 23;
            // 
            // tbActivityNumber
            // 
            this.tbActivityNumber.Location = new System.Drawing.Point(290, 24);
            this.tbActivityNumber.Name = "tbActivityNumber";
            this.tbActivityNumber.Size = new System.Drawing.Size(43, 20);
            this.tbActivityNumber.TabIndex = 22;
            // 
            // tbStreetUnit
            // 
            this.tbStreetUnit.Location = new System.Drawing.Point(647, 60);
            this.tbStreetUnit.Name = "tbStreetUnit";
            this.tbStreetUnit.Size = new System.Drawing.Size(60, 20);
            this.tbStreetUnit.TabIndex = 21;
            // 
            // tbStreetQual
            // 
            this.tbStreetQual.Location = new System.Drawing.Point(405, 60);
            this.tbStreetQual.Name = "tbStreetQual";
            this.tbStreetQual.Size = new System.Drawing.Size(30, 20);
            this.tbStreetQual.TabIndex = 20;
            // 
            // tbStreetName
            // 
            this.tbStreetName.Location = new System.Drawing.Point(441, 60);
            this.tbStreetName.Name = "tbStreetName";
            this.tbStreetName.Size = new System.Drawing.Size(200, 20);
            this.tbStreetName.TabIndex = 19;
            // 
            // tbStreetNumber
            // 
            this.tbStreetNumber.Location = new System.Drawing.Point(339, 60);
            this.tbStreetNumber.Name = "tbStreetNumber";
            this.tbStreetNumber.Size = new System.Drawing.Size(60, 20);
            this.tbStreetNumber.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Address";
            // 
            // tbOwner1
            // 
            this.tbOwner1.Location = new System.Drawing.Point(81, 60);
            this.tbOwner1.Name = "tbOwner1";
            this.tbOwner1.Size = new System.Drawing.Size(201, 20);
            this.tbOwner1.TabIndex = 16;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(10, 63);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(38, 13);
            this.lblOwner.TabIndex = 15;
            this.lblOwner.Text = "Owner";
            // 
            // tbRollNumber
            // 
            this.tbRollNumber.Location = new System.Drawing.Point(81, 24);
            this.tbRollNumber.Name = "tbRollNumber";
            this.tbRollNumber.Size = new System.Drawing.Size(201, 20);
            this.tbRollNumber.TabIndex = 14;
            // 
            // lblRollNumber
            // 
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Location = new System.Drawing.Point(10, 27);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(65, 13);
            this.lblRollNumber.TabIndex = 13;
            this.lblRollNumber.Text = "Roll Number";
            // 
            // dgTransactionDistributions
            // 
            this.dgTransactionDistributions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactionDistributions.Location = new System.Drawing.Point(81, 141);
            this.dgTransactionDistributions.Name = "dgTransactionDistributions";
            this.dgTransactionDistributions.Size = new System.Drawing.Size(657, 297);
            this.dgTransactionDistributions.TabIndex = 26;
            // 
            // TransactionDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgTransactionDistributions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbOwner3);
            this.Controls.Add(this.tbOwner2);
            this.Controls.Add(this.tbActivityNumber);
            this.Controls.Add(this.tbStreetUnit);
            this.Controls.Add(this.tbStreetQual);
            this.Controls.Add(this.tbStreetName);
            this.Controls.Add(this.tbStreetNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOwner1);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.tbRollNumber);
            this.Controls.Add(this.lblRollNumber);
            this.Name = "TransactionDistribution";
            this.Text = "TransactionDistribution";
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactionDistributions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbOwner3;
        private System.Windows.Forms.TextBox tbOwner2;
        private System.Windows.Forms.TextBox tbActivityNumber;
        private System.Windows.Forms.TextBox tbStreetUnit;
        private System.Windows.Forms.TextBox tbStreetQual;
        private System.Windows.Forms.TextBox tbStreetName;
        private System.Windows.Forms.TextBox tbStreetNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOwner1;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox tbRollNumber;
        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.DataGridView dgTransactionDistributions;
    }
}