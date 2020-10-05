namespace I_IT
{
    partial class StatMetPod
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Topic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subscribers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTopicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeSubscribersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Topic,
            this.Subscribers});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 475);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Topic
            // 
            this.Topic.Text = "Topic";
            // 
            // Subscribers
            // 
            this.Subscribers.Text = "Subscribers";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.seeSubscribersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDateToolStripMenuItem,
            this.changeTopicToolStripMenuItem,
            this.chooseFieldsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeDateToolStripMenuItem
            // 
            this.changeDateToolStripMenuItem.Name = "changeDateToolStripMenuItem";
            this.changeDateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeDateToolStripMenuItem.Text = "Change Date";
            this.changeDateToolStripMenuItem.Click += new System.EventHandler(this.changeDateToolStripMenuItem_Click);
            // 
            // changeTopicToolStripMenuItem
            // 
            this.changeTopicToolStripMenuItem.Name = "changeTopicToolStripMenuItem";
            this.changeTopicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeTopicToolStripMenuItem.Text = "Change Topic";
            this.changeTopicToolStripMenuItem.Click += new System.EventHandler(this.changeTopicToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // seeSubscribersToolStripMenuItem
            // 
            this.seeSubscribersToolStripMenuItem.Name = "seeSubscribersToolStripMenuItem";
            this.seeSubscribersToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.seeSubscribersToolStripMenuItem.Text = "See Subscribers";
            this.seeSubscribersToolStripMenuItem.Click += new System.EventHandler(this.seeSubscribersToolStripMenuItem_Click);
            // 
            // chooseFieldsToolStripMenuItem
            // 
            this.chooseFieldsToolStripMenuItem.Name = "chooseFieldsToolStripMenuItem";
            this.chooseFieldsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chooseFieldsToolStripMenuItem.Text = "Choose Fields";
            this.chooseFieldsToolStripMenuItem.Click += new System.EventHandler(this.chooseFieldsToolStripMenuItem_Click);
            // 
            // StatMetPod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 514);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StatMetPod";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statutory Planning Meetings";
            this.Load += new System.EventHandler(this.StatMetPod_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Topic;
        private System.Windows.Forms.ColumnHeader Subscribers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeSubscribersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTopicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFieldsToolStripMenuItem;
    }
}