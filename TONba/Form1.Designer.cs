namespace I_IT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.console = new System.Windows.Forms.TextBox();
            this.homeScreen1 = new I_IT.HomeScreen();
            this.SuspendLayout();
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
            this.imageList.Images.SetKeyName(21, "Items.png");
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.Location = new System.Drawing.Point(421, 0);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(265, 568);
            this.console.TabIndex = 1;
            this.console.Visible = false;
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // homeScreen1
            // 
            this.homeScreen1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeScreen1.BackColor = System.Drawing.Color.White;
            this.homeScreen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homeScreen1.Location = new System.Drawing.Point(0, 0);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.Size = new System.Drawing.Size(415, 568);
            this.homeScreen1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 568);
            this.Controls.Add(this.homeScreen1);
            this.Controls.Add(this.console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TONba - v4.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox console;
        public System.Windows.Forms.ImageList imageList;
        private HomeScreen homeScreen1;
    }
}

