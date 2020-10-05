namespace I_IT
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unfilterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grid = new SourceGrid.DataGrid();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectMenuItem,
            this.addMenuItem,
            this.editMenuItem,
            this.printMenuItem,
            this.deleteMenuItem,
            this.findMenuItem,
            this.filterMenuItem,
            this.unfilterMenuItem,
            this.graphMenuItem,
            this.exportMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectMenuItem
            // 
            this.selectMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectMenuItem.ForeColor = System.Drawing.Color.Red;
            this.selectMenuItem.Name = "selectMenuItem";
            this.selectMenuItem.Size = new System.Drawing.Size(63, 25);
            this.selectMenuItem.Text = "Select";
            this.selectMenuItem.Visible = false;
            this.selectMenuItem.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(50, 25);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.Visible = false;
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(48, 25);
            this.editMenuItem.Text = "Edit";
            this.editMenuItem.Visible = false;
            this.editMenuItem.Click += new System.EventHandler(this.editMenuItem_Click);
            // 
            // printMenuItem
            // 
            this.printMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.printMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.printMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.Size = new System.Drawing.Size(55, 25);
            this.printMenuItem.Text = "Print";
            this.printMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(66, 25);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Visible = false;
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // findMenuItem
            // 
            this.findMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.findMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.findMenuItem.Name = "findMenuItem";
            this.findMenuItem.Size = new System.Drawing.Size(52, 25);
            this.findMenuItem.Text = "Find";
            this.findMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // filterMenuItem
            // 
            this.filterMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.filterMenuItem.Name = "filterMenuItem";
            this.filterMenuItem.Size = new System.Drawing.Size(57, 25);
            this.filterMenuItem.Text = "Filter";
            // 
            // unfilterMenuItem
            // 
            this.unfilterMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.unfilterMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.unfilterMenuItem.Name = "unfilterMenuItem";
            this.unfilterMenuItem.Size = new System.Drawing.Size(74, 25);
            this.unfilterMenuItem.Text = "Unfilter";
            this.unfilterMenuItem.Visible = false;
            this.unfilterMenuItem.Click += new System.EventHandler(this.unfilterToolStripMenuItem_Click);
            // 
            // graphMenuItem
            // 
            this.graphMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.graphMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.graphMenuItem.Name = "graphMenuItem";
            this.graphMenuItem.Size = new System.Drawing.Size(65, 25);
            this.graphMenuItem.Text = "Graph";
            this.graphMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
            // 
            // exportMenuItem
            // 
            this.exportMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exportMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exportMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.exportMenuItem.Name = "exportMenuItem";
            this.exportMenuItem.Size = new System.Drawing.Size(66, 25);
            this.exportMenuItem.Text = "Export";
            this.exportMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 68;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.CancelEditingWithEscapeKey = false;
            this.grid.ClipboardMode = SourceGrid.ClipboardMode.Copy;
            this.grid.DefaultHeight = 40;
            this.grid.DeleteQuestionMessage = "Are you sure to delete all the selected rows?";
            this.grid.EnableSort = false;
            this.grid.FixedRows = 1;
            this.grid.Location = new System.Drawing.Point(0, 30);
            this.grid.Name = "grid";
            this.grid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid.Size = new System.Drawing.Size(877, 431);
            this.grid.TabIndex = 1;
            this.grid.TabStop = true;
            this.grid.ToolTipText = "";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 482);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Report";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Shown += new System.EventHandler(this.Report_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Report_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unfilterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphMenuItem;
        private SourceGrid.DataGrid grid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem findMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
    }
}