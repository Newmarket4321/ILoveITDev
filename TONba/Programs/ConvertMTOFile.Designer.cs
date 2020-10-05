namespace I_IT
{
    partial class ConvertMTOFile
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
            this.progressBarDetailed1 = new I_IT.ProgressBarDetailed();
            this.SuspendLayout();
            // 
            // progressBarDetailed1
            // 
            this.progressBarDetailed1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarDetailed1.BackColor = System.Drawing.Color.White;
            this.progressBarDetailed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarDetailed1.Location = new System.Drawing.Point(2, -2);
            this.progressBarDetailed1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBarDetailed1.Name = "progressBarDetailed1";
            this.progressBarDetailed1.Size = new System.Drawing.Size(413, 54);
            this.progressBarDetailed1.TabIndex = 1;
            this.progressBarDetailed1.Value = 0;
            // 
            // ConvertMTOFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 49);
            this.Controls.Add(this.progressBarDetailed1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertMTOFile";
            this.Text = "Convert MTO File";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBarDetailed progressBarDetailed1;
    }
}