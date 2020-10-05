namespace I_IT
{
    partial class LookupIcon
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Test", "1376684830_62724.ico");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2", "1376684835_62721.ico");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3", "1376684839_62723.ico");
            this.iconView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // iconView
            // 
            this.iconView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconView.Font = new System.Drawing.Font("Segoe UI", 12F);
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.iconView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.iconView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.iconView.Location = new System.Drawing.Point(12, 12);
            this.iconView.Name = "iconView";
            this.iconView.ShowGroups = false;
            this.iconView.ShowItemToolTips = true;
            this.iconView.Size = new System.Drawing.Size(681, 433);
            this.iconView.TabIndex = 5;
            this.iconView.TileSize = new System.Drawing.Size(100, 46);
            this.iconView.UseCompatibleStateImageBehavior = false;
            this.iconView.View = System.Windows.Forms.View.Tile;
            this.iconView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconView_MouseClick);
            // 
            // SelectIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 457);
            this.Controls.Add(this.iconView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectIcon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Icon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddPermission_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView iconView;
    }
}