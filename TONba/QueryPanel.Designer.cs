namespace I_IT
{
    partial class QueryPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // QueryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "QueryPanel";
            this.Size = new System.Drawing.Size(479, 300);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.QueryPanel_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.QueryPanel_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QueryPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QueryPanel_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
