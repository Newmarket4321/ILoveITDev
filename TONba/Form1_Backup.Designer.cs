namespace I_IT
{
    partial class Form1_Backup
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("2", "1376684835_62721.ico");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("3", "1376684839_62723.ico");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Test", "1376684830_62724.ico");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Backup));
            this.programs = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.console = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // programs
            // 
            this.programs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.programs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.programs.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            listViewItem6.Group = listViewGroup2;
            this.programs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.programs.LargeImageList = this.imageList;
            this.programs.Location = new System.Drawing.Point(5, 4);
            this.programs.Name = "programs";
            this.programs.ShowItemToolTips = true;
            this.programs.Size = new System.Drawing.Size(304, 500);
            this.programs.SmallImageList = this.imageList;
            this.programs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.programs.TabIndex = 0;
            this.programs.TileSize = new System.Drawing.Size(300, 46);
            this.programs.UseCompatibleStateImageBehavior = false;
            this.programs.View = System.Windows.Forms.View.SmallIcon;
            this.programs.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.programs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.programs_MouseClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Add.png");
            this.imageList.Images.SetKeyName(1, "Calculator.png");
            this.imageList.Images.SetKeyName(2, "Coin.png");
            this.imageList.Images.SetKeyName(3, "Convert.png");
            this.imageList.Images.SetKeyName(4, "Delete.png");
            this.imageList.Images.SetKeyName(5, "Export.png");
            this.imageList.Images.SetKeyName(6, "Folder.png");
            this.imageList.Images.SetKeyName(7, "Form.png");
            this.imageList.Images.SetKeyName(8, "Group.png");
            this.imageList.Images.SetKeyName(9, "House.png");
            this.imageList.Images.SetKeyName(10, "Import.png");
            this.imageList.Images.SetKeyName(11, "Leaf.png");
            this.imageList.Images.SetKeyName(12, "Pencil.png");
            this.imageList.Images.SetKeyName(13, "Play.png");
            this.imageList.Images.SetKeyName(14, "Printer.png");
            this.imageList.Images.SetKeyName(15, "Report.png");
            this.imageList.Images.SetKeyName(16, "Search.png");
            this.imageList.Images.SetKeyName(17, "Services.png");
            this.imageList.Images.SetKeyName(18, "Shapes.png");
            this.imageList.Images.SetKeyName(19, "User.png");
            this.imageList.Images.SetKeyName(20, "Water Tower.png");
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.console.Location = new System.Drawing.Point(315, 4);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(265, 500);
            this.console.TabIndex = 1;
            this.console.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(588, 510);
            this.Controls.Add(this.console);
            this.Controls.Add(this.programs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I❤IT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView programs;
        private System.Windows.Forms.TextBox console;
        public System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

