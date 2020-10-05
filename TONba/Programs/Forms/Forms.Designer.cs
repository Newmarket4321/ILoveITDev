namespace I_IT
{
    partial class Forms
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
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submissionScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showthankYouScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToFormToGetReadyForNextSubmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.givePermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokePermissionFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.list.Location = new System.Drawing.Point(0, 36);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.ShowGroups = false;
            this.list.Size = new System.Drawing.Size(859, 198);
            this.list.TabIndex = 6;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 36);
            this.menuStrip1.TabIndex = 69;
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
            this.titleToolStripMenuItem,
            this.questionsToolStripMenuItem,
            this.submissionScreenToolStripMenuItem,
            this.notificationFrequencyToolStripMenuItem,
            this.notificationEmailToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(58, 32);
            this.toolStripMenuItem3.Text = "Edit";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.titleToolStripMenuItem.Text = "Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.titleToolStripMenuItem_Click);
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.questionsToolStripMenuItem.Text = "Questions";
            this.questionsToolStripMenuItem.Click += new System.EventHandler(this.questionsToolStripMenuItem_Click);
            // 
            // submissionScreenToolStripMenuItem
            // 
            this.submissionScreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showthankYouScreenToolStripMenuItem,
            this.returnToFormToGetReadyForNextSubmissionToolStripMenuItem});
            this.submissionScreenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.submissionScreenToolStripMenuItem.Name = "submissionScreenToolStripMenuItem";
            this.submissionScreenToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.submissionScreenToolStripMenuItem.Text = "Submission Screen";
            // 
            // showthankYouScreenToolStripMenuItem
            // 
            this.showthankYouScreenToolStripMenuItem.Name = "showthankYouScreenToolStripMenuItem";
            this.showthankYouScreenToolStripMenuItem.Size = new System.Drawing.Size(410, 26);
            this.showthankYouScreenToolStripMenuItem.Text = "Show \"thank you\" screen";
            this.showthankYouScreenToolStripMenuItem.Click += new System.EventHandler(this.showthankYouScreenToolStripMenuItem_Click);
            // 
            // returnToFormToGetReadyForNextSubmissionToolStripMenuItem
            // 
            this.returnToFormToGetReadyForNextSubmissionToolStripMenuItem.Name = "returnToFormToGetReadyForNextSubmissionToolStripMenuItem";
            this.returnToFormToGetReadyForNextSubmissionToolStripMenuItem.Size = new System.Drawing.Size(410, 26);
            this.returnToFormToGetReadyForNextSubmissionToolStripMenuItem.Text = "Return to form to get ready for next submission";
            this.returnToFormToGetReadyForNextSubmissionToolStripMenuItem.Click += new System.EventHandler(this.returnToFormToGetReadyForNextSubmissionToolStripMenuItem_Click);
            // 
            // notificationFrequencyToolStripMenuItem
            // 
            this.notificationFrequencyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.notificationFrequencyToolStripMenuItem.Name = "notificationFrequencyToolStripMenuItem";
            this.notificationFrequencyToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.notificationFrequencyToolStripMenuItem.Text = "Notification Frequency";
            this.notificationFrequencyToolStripMenuItem.Click += new System.EventHandler(this.notificationFrequencyToolStripMenuItem_Click);
            // 
            // notificationEmailToolStripMenuItem
            // 
            this.notificationEmailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.notificationEmailToolStripMenuItem.Name = "notificationEmailToolStripMenuItem";
            this.notificationEmailToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.notificationEmailToolStripMenuItem.Text = "Notification E-mail";
            this.notificationEmailToolStripMenuItem.Click += new System.EventHandler(this.notificationEmailToolStripMenuItem_Click);
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
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(123, 32);
            this.toolStripMenuItem5.Text = "Open Form";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.givePermissionToolStripMenuItem,
            this.revokePermissionFromToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(125, 32);
            this.toolStripMenuItem4.Text = "Permissions";
            // 
            // givePermissionToolStripMenuItem
            // 
            this.givePermissionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.givePermissionToolStripMenuItem.Name = "givePermissionToolStripMenuItem";
            this.givePermissionToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.givePermissionToolStripMenuItem.Text = "Give Permission";
            this.givePermissionToolStripMenuItem.Click += new System.EventHandler(this.givePermissionToolStripMenuItem_Click);
            // 
            // revokePermissionFromToolStripMenuItem
            // 
            this.revokePermissionFromToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.revokePermissionFromToolStripMenuItem.Name = "revokePermissionFromToolStripMenuItem";
            this.revokePermissionFromToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.revokePermissionFromToolStripMenuItem.Text = "Revoke Permission from...";
            this.revokePermissionFromToolStripMenuItem.Click += new System.EventHandler(this.revokePermissionFromToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(160, 32);
            this.toolStripMenuItem6.Text = "View Responses";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(12, 32);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 234);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(859, 171);
            this.webBrowser1.TabIndex = 70;
            // 
            // Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 405);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.list);
            this.Name = "Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem givePermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revokePermissionFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationFrequencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem submissionScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showthankYouScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToFormToGetReadyForNextSubmissionToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}