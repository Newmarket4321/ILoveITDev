namespace I_IT
{
    partial class EditForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.questionTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeAnAnswerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAnOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleChoiceOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mandatoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeThisQuestionMandatoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeThisQuestionNotMandatoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.list = new System.Windows.Forms.ListView();
            this.disclaimerInstructionLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem8,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 36);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 32);
            this.toolStripMenuItem2.Text = "Add";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionTextToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.multipleChoiceOptionsToolStripMenuItem,
            this.mandatoryToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(58, 32);
            this.toolStripMenuItem3.Text = "Edit";
            // 
            // questionTextToolStripMenuItem
            // 
            this.questionTextToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.questionTextToolStripMenuItem.Name = "questionTextToolStripMenuItem";
            this.questionTextToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.questionTextToolStripMenuItem.Text = "Question text";
            this.questionTextToolStripMenuItem.Click += new System.EventHandler(this.questionTextToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeAnAnswerToolStripMenuItem,
            this.chooseAnOptionToolStripMenuItem,
            this.checkBoxesToolStripMenuItem,
            this.disclaimerInstructionLabelToolStripMenuItem});
            this.typeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.typeToolStripMenuItem.Text = "Question type";
            // 
            // typeAnAnswerToolStripMenuItem
            // 
            this.typeAnAnswerToolStripMenuItem.Name = "typeAnAnswerToolStripMenuItem";
            this.typeAnAnswerToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.typeAnAnswerToolStripMenuItem.Text = "Type an answer";
            this.typeAnAnswerToolStripMenuItem.Click += new System.EventHandler(this.typeAnAnswerToolStripMenuItem_Click);
            // 
            // chooseAnOptionToolStripMenuItem
            // 
            this.chooseAnOptionToolStripMenuItem.Name = "chooseAnOptionToolStripMenuItem";
            this.chooseAnOptionToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.chooseAnOptionToolStripMenuItem.Text = "Choose an option";
            this.chooseAnOptionToolStripMenuItem.Click += new System.EventHandler(this.chooseAnOptionToolStripMenuItem_Click);
            // 
            // checkBoxesToolStripMenuItem
            // 
            this.checkBoxesToolStripMenuItem.Name = "checkBoxesToolStripMenuItem";
            this.checkBoxesToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.checkBoxesToolStripMenuItem.Text = "Check boxes";
            this.checkBoxesToolStripMenuItem.Click += new System.EventHandler(this.checkBoxesToolStripMenuItem_Click);
            // 
            // multipleChoiceOptionsToolStripMenuItem
            // 
            this.multipleChoiceOptionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.multipleChoiceOptionsToolStripMenuItem.Name = "multipleChoiceOptionsToolStripMenuItem";
            this.multipleChoiceOptionsToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.multipleChoiceOptionsToolStripMenuItem.Text = "Multiple choice options";
            this.multipleChoiceOptionsToolStripMenuItem.Click += new System.EventHandler(this.multipleChoiceOptionsToolStripMenuItem_Click);
            // 
            // mandatoryToolStripMenuItem
            // 
            this.mandatoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeThisQuestionMandatoryToolStripMenuItem,
            this.makeThisQuestionNotMandatoryToolStripMenuItem});
            this.mandatoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mandatoryToolStripMenuItem.Name = "mandatoryToolStripMenuItem";
            this.mandatoryToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.mandatoryToolStripMenuItem.Text = "Mandatory...";
            // 
            // makeThisQuestionMandatoryToolStripMenuItem
            // 
            this.makeThisQuestionMandatoryToolStripMenuItem.Name = "makeThisQuestionMandatoryToolStripMenuItem";
            this.makeThisQuestionMandatoryToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.makeThisQuestionMandatoryToolStripMenuItem.Text = "Make this question mandatory";
            this.makeThisQuestionMandatoryToolStripMenuItem.Click += new System.EventHandler(this.makeThisQuestionMandatoryToolStripMenuItem_Click);
            // 
            // makeThisQuestionNotMandatoryToolStripMenuItem
            // 
            this.makeThisQuestionNotMandatoryToolStripMenuItem.Name = "makeThisQuestionNotMandatoryToolStripMenuItem";
            this.makeThisQuestionNotMandatoryToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.makeThisQuestionNotMandatoryToolStripMenuItem.Text = "Make this question not mandatory";
            this.makeThisQuestionNotMandatoryToolStripMenuItem.Click += new System.EventHandler(this.makeThisQuestionNotMandatoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 32);
            this.toolStripMenuItem1.Text = "Remove";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(130, 32);
            this.toolStripMenuItem8.Text = "Move Down";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(105, 32);
            this.toolStripMenuItem7.Text = "Move Up";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
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
            this.list.Location = new System.Drawing.Point(0, 39);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.ShowGroups = false;
            this.list.Size = new System.Drawing.Size(824, 478);
            this.list.TabIndex = 70;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            // 
            // disclaimerInstructionLabelToolStripMenuItem
            // 
            this.disclaimerInstructionLabelToolStripMenuItem.Name = "disclaimerInstructionLabelToolStripMenuItem";
            this.disclaimerInstructionLabelToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.disclaimerInstructionLabelToolStripMenuItem.Text = "Disclaimer / instruction label";
            this.disclaimerInstructionLabelToolStripMenuItem.Click += new System.EventHandler(this.disclaimerInstructionLabelToolStripMenuItem_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 522);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.list);
            this.KeyPreview = true;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem questionTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleChoiceOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mandatoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeThisQuestionMandatoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeThisQuestionNotMandatoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeAnAnswerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseAnOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disclaimerInstructionLabelToolStripMenuItem;
    }
}