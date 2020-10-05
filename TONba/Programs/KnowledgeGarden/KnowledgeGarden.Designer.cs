namespace I_IT
{
    partial class KnowledgeGarden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowledgeGarden));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nodeList = new System.Windows.Forms.TreeView();
            this.message = new I_IT.RicherTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.data = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRootNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChildNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.nodesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.advancedSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nodeList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.message);
            this.splitContainer1.Size = new System.Drawing.Size(663, 548);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 6;
            // 
            // nodeList
            // 
            this.nodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeList.LabelEdit = true;
            this.nodeList.Location = new System.Drawing.Point(3, 3);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(215, 515);
            this.nodeList.TabIndex = 3;
            this.nodeList.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.nodeList_BeforeLabelEdit);
            this.nodeList.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.nodeList_AfterLabelEdit);
            this.nodeList.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.nodeList_BeforeSelect);
            this.nodeList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.nodeList_AfterSelect);
            this.nodeList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nodeList_KeyDown);
            // 
            // message
            // 
            this.message.AlignCenterVisible = true;
            this.message.AlignLeftVisible = true;
            this.message.AlignRightVisible = true;
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.BoldVisible = true;
            this.message.BulletsVisible = false;
            this.message.ChooseFontVisible = true;
            this.message.FindReplaceVisible = false;
            this.message.FontColorVisible = false;
            this.message.FontFamilyVisible = true;
            this.message.FontSizeVisible = true;
            this.message.GroupAlignmentVisible = true;
            this.message.GroupBoldUnderlineItalicVisible = true;
            this.message.GroupFontColorVisible = false;
            this.message.GroupFontNameAndSizeVisible = true;
            this.message.GroupIndentationAndBulletsVisible = false;
            this.message.GroupInsertVisible = false;
            this.message.GroupSaveAndLoadVisible = false;
            this.message.GroupZoomVisible = false;
            this.message.INDENT = 10;
            this.message.IndentVisible = false;
            this.message.InsertPictureVisible = false;
            this.message.ItalicVisible = true;
            this.message.LoadVisible = false;
            this.message.Location = new System.Drawing.Point(3, 3);
            this.message.Name = "message";
            this.message.OutdentVisible = false;
            this.message.ReadOnly = false;
            this.message.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}" +
    "\r\n\\viewkind4\\uc1\\pard\\lang4105\\f0\\fs17 richerTextBox1\\par\r\n}\r\n";
            this.message.SaveVisible = false;
            this.message.SeparatorAlignVisible = true;
            this.message.SeparatorBoldUnderlineItalicVisible = true;
            this.message.SeparatorFontColorVisible = false;
            this.message.SeparatorFontVisible = true;
            this.message.SeparatorIndentAndBulletsVisible = false;
            this.message.SeparatorInsertVisible = false;
            this.message.SeparatorSaveLoadVisible = false;
            this.message.Size = new System.Drawing.Size(384, 515);
            this.message.TabIndex = 11;
            this.message.ToolStripVisible = true;
            this.message.UnderlineVisible = true;
            this.message.WordWrapVisible = false;
            this.message.ZoomFactorTextVisible = false;
            this.message.ZoomInVisible = false;
            this.message.ZoomOutVisible = false;
            this.message.RTFBoxTextChanged += new I_IT.RicherTextBox.RTFEventHandler(this.message_TextChanged);
            this.message.RTFBoxPrintRequested += new I_IT.RicherTextBox.RTFEventHandler(this.message_RTFBoxPrintRequested);
            this.message.RTFBoxRightClicked += new I_IT.RicherTextBox.RTFEventHandler(this.message_RTFBoxRightClicked);
            this.message.RTFBoxRightMouseUp += new I_IT.RicherTextBox.RTFMouseEventHandler(this.message_RTFBoxRightMouseUp);
            this.message.RTFBoxLinkClicked += new I_IT.RicherTextBox.RTFLinkEventHandler(this.message_RTFBoxLinkClicked);
            this.message.Click += new System.EventHandler(this.message_Click);
            this.message.MouseUp += new System.Windows.Forms.MouseEventHandler(this.message_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // data
            // 
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(59, 17);
            this.data.Text = "Loading...";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 70);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // nodesToolStripMenuItem
            // 
            this.nodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRootNodeToolStripMenuItem,
            this.newChildNodeToolStripMenuItem,
            this.renameNodeToolStripMenuItem,
            this.moveNodeToolStripMenuItem,
            this.deleteNodeToolStripMenuItem});
            this.nodesToolStripMenuItem.Name = "nodesToolStripMenuItem";
            this.nodesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.nodesToolStripMenuItem.Text = "Nodes";
            // 
            // newRootNodeToolStripMenuItem
            // 
            this.newRootNodeToolStripMenuItem.Name = "newRootNodeToolStripMenuItem";
            this.newRootNodeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newRootNodeToolStripMenuItem.Text = "New Root Node";
            this.newRootNodeToolStripMenuItem.Click += new System.EventHandler(this.newRootNode_Click);
            // 
            // newChildNodeToolStripMenuItem
            // 
            this.newChildNodeToolStripMenuItem.Name = "newChildNodeToolStripMenuItem";
            this.newChildNodeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newChildNodeToolStripMenuItem.Text = "New Child Node";
            this.newChildNodeToolStripMenuItem.Click += new System.EventHandler(this.newChildNode_Click);
            // 
            // deleteNodeToolStripMenuItem
            // 
            this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
            this.deleteNodeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteNodeToolStripMenuItem.Text = "Delete Node";
            this.deleteNodeToolStripMenuItem.Click += new System.EventHandler(this.deleteNode_Click);
            // 
            // moveNodeToolStripMenuItem
            // 
            this.moveNodeToolStripMenuItem.Name = "moveNodeToolStripMenuItem";
            this.moveNodeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.moveNodeToolStripMenuItem.Text = "Move Node";
            this.moveNodeToolStripMenuItem.Click += new System.EventHandler(this.moveNode_Click);
            // 
            // renameNodeToolStripMenuItem
            // 
            this.renameNodeToolStripMenuItem.Name = "renameNodeToolStripMenuItem";
            this.renameNodeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.renameNodeToolStripMenuItem.Text = "Rename Node";
            this.renameNodeToolStripMenuItem.Click += new System.EventHandler(this.editNodeName_Click);
            // 
            // KnowledgeGarden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 600);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KnowledgeGarden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knowledge Garden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView nodeList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel data;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private RicherTextBox message;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRootNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChildNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNodeToolStripMenuItem;
    }
}

