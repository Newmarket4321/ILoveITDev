namespace I_IT
{
    partial class AssessmentAppealCalendar
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Tom", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Jeff", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Frank", System.Windows.Forms.HorizontalAlignment.Left);
            this.list = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRollNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAppealNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCommencementDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.FullRowSelect = true;
            listViewGroup1.Header = "Tom";
            listViewGroup1.Name = "Tom";
            listViewGroup2.Header = "Jeff";
            listViewGroup2.Name = "Jeff";
            listViewGroup3.Header = "Frank";
            listViewGroup3.Name = "Frank";
            this.list.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 37);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.ShowGroups = false;
            this.list.Size = new System.Drawing.Size(623, 560);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 36);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(63, 32);
            this.toolStripMenuItem2.Text = "New";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeRollNumberToolStripMenuItem,
            this.changeAppealNumberToolStripMenuItem,
            this.changeCommencementDateToolStripMenuItem,
            this.changeTypeToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(58, 32);
            this.toolStripMenuItem3.Text = "Edit";
            // 
            // changeRollNumberToolStripMenuItem
            // 
            this.changeRollNumberToolStripMenuItem.Name = "changeRollNumberToolStripMenuItem";
            this.changeRollNumberToolStripMenuItem.Size = new System.Drawing.Size(339, 32);
            this.changeRollNumberToolStripMenuItem.Text = "Change roll number";
            this.changeRollNumberToolStripMenuItem.Click += new System.EventHandler(this.changeRollNumberToolStripMenuItem_Click);
            // 
            // changeAppealNumberToolStripMenuItem
            // 
            this.changeAppealNumberToolStripMenuItem.Name = "changeAppealNumberToolStripMenuItem";
            this.changeAppealNumberToolStripMenuItem.Size = new System.Drawing.Size(339, 32);
            this.changeAppealNumberToolStripMenuItem.Text = "Change appeal number";
            this.changeAppealNumberToolStripMenuItem.Click += new System.EventHandler(this.changeAppealNumberToolStripMenuItem_Click);
            // 
            // changeCommencementDateToolStripMenuItem
            // 
            this.changeCommencementDateToolStripMenuItem.Name = "changeCommencementDateToolStripMenuItem";
            this.changeCommencementDateToolStripMenuItem.Size = new System.Drawing.Size(339, 32);
            this.changeCommencementDateToolStripMenuItem.Text = "Change commencement date";
            this.changeCommencementDateToolStripMenuItem.Click += new System.EventHandler(this.changeCommencementDateToolStripMenuItem_Click);
            // 
            // changeTypeToolStripMenuItem
            // 
            this.changeTypeToolStripMenuItem.Name = "changeTypeToolStripMenuItem";
            this.changeTypeToolStripMenuItem.Size = new System.Drawing.Size(339, 32);
            this.changeTypeToolStripMenuItem.Text = "Change type";
            this.changeTypeToolStripMenuItem.Click += new System.EventHandler(this.changeTypeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 32);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 32);
            this.toolStripMenuItem4.Text = "View as Report";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // AssessmentAppealCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 595);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AssessmentAppealCalendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment Appeal Calendar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssessmentAppealCalendar_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem changeRollNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAppealNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCommencementDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}