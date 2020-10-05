namespace I_IT
{
    partial class PostdatedCheques
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
            this.tbBatchNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbManual = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBatchNo
            // 
            this.tbBatchNo.Location = new System.Drawing.Point(114, 42);
            this.tbBatchNo.Name = "tbBatchNo";
            this.tbBatchNo.Size = new System.Drawing.Size(100, 20);
            this.tbBatchNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Due Date";
            // 
            // itemsPanel
            // 
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.Location = new System.Drawing.Point(95, 97);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(610, 326);
            this.itemsPanel.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(114, 68);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(711, 397);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbManual
            // 
            this.cbManual.AutoSize = true;
            this.cbManual.Location = new System.Drawing.Point(236, 45);
            this.cbManual.Name = "cbManual";
            this.cbManual.Size = new System.Drawing.Size(61, 17);
            this.cbManual.TabIndex = 13;
            this.cbManual.Text = "Manual";
            this.cbManual.UseVisualStyleBackColor = true;
            this.cbManual.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PostdatedCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbManual);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBatchNo);
            this.Name = "PostdatedCheques";
            this.Text = "PostdatedCheques";
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBatchNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel itemsPanel;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox cbManual;
    }
}