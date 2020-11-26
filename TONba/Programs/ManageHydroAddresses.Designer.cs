namespace I_IT
{
    partial class ManageHydroAddresses
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldAdd = new System.Windows.Forms.TextBox();
            this.NewAdd = new System.Windows.Forms.TextBox();
            this.RollNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.OldAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1622, 55);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 45);
            this.toolStripMenuItem1.Text = "Export to Excel";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(240)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.OldAddress,
            this.RollNumber});
            this.dataGridView1.Location = new System.Drawing.Point(230, 323);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 306);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "OldAddress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "NewAddress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "RollNumber";
            // 
            // OldAdd
            // 
            this.OldAdd.Location = new System.Drawing.Point(230, 89);
            this.OldAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OldAdd.MaxLength = 30;
            this.OldAdd.Name = "OldAdd";
            this.OldAdd.Size = new System.Drawing.Size(292, 26);
            this.OldAdd.TabIndex = 74;
            // 
            // NewAdd
            // 
            this.NewAdd.Location = new System.Drawing.Point(230, 151);
            this.NewAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewAdd.MaxLength = 30;
            this.NewAdd.Name = "NewAdd";
            this.NewAdd.Size = new System.Drawing.Size(292, 26);
            this.NewAdd.TabIndex = 75;
            // 
            // RollNo
            // 
            this.RollNo.Location = new System.Drawing.Point(230, 212);
            this.RollNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RollNo.MaxLength = 19;
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(292, 26);
            this.RollNo.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 77;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "lnkColumn";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 43;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "lnkColumn";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            this.Delete.Width = 62;
            // 
            // OldAddress
            // 
            this.OldAddress.DataPropertyName = "OldAddress";
            this.OldAddress.HeaderText = "OldAddress";
            this.OldAddress.MaxInputLength = 30;
            this.OldAddress.Name = "OldAddress";
            this.OldAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OldAddress.Width = 200;
            // 
            // RollNumber
            // 
            this.RollNumber.DataPropertyName = "RollNumber";
            this.RollNumber.HeaderText = "RollNumber";
            this.RollNumber.MaxInputLength = 19;
            this.RollNumber.Name = "RollNumber";
            this.RollNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RollNumber.Width = 150;
            // 
            // ManageHydroAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RollNo);
            this.Controls.Add(this.NewAdd);
            this.Controls.Add(this.OldAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageHydroAddresses";
            this.Text = "ManageHydroAddresses";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldAdd;
        private System.Windows.Forms.TextBox NewAdd;
        private System.Windows.Forms.TextBox RollNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNumber;
    }
}