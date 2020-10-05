namespace I_IT
{
    partial class ProgressBarDetailed
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
            this.components = new System.ComponentModel.Container();
            this.itemCounter = new System.Windows.Forms.Label();
            this.timeRemaining = new System.Windows.Forms.Label();
            this.backdropPanel = new System.Windows.Forms.Panel();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backdropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemCounter
            // 
            this.itemCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemCounter.AutoSize = true;
            this.itemCounter.Font = new System.Drawing.Font("Calibri", 10F);
            this.itemCounter.Location = new System.Drawing.Point(3, 29);
            this.itemCounter.Name = "itemCounter";
            this.itemCounter.Size = new System.Drawing.Size(46, 17);
            this.itemCounter.TabIndex = 1;
            this.itemCounter.Text = "1 of 10";
            // 
            // timeRemaining
            // 
            this.timeRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeRemaining.AutoSize = true;
            this.timeRemaining.Font = new System.Drawing.Font("Calibri", 10F);
            this.timeRemaining.Location = new System.Drawing.Point(84, 29);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(229, 17);
            this.timeRemaining.TabIndex = 2;
            this.timeRemaining.Text = "1 day, 23 hours, 59 minutes, 59 seconds";
            this.timeRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // backdropPanel
            // 
            this.backdropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backdropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backdropPanel.Controls.Add(this.progressPanel);
            this.backdropPanel.Location = new System.Drawing.Point(-1, -1);
            this.backdropPanel.Name = "backdropPanel";
            this.backdropPanel.Size = new System.Drawing.Size(318, 26);
            this.backdropPanel.TabIndex = 3;
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(217)))), ((int)(((byte)(100)))));
            this.progressPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressPanel.Location = new System.Drawing.Point(-1, -1);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(155, 26);
            this.progressPanel.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ProgressBarDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.backdropPanel);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.itemCounter);
            this.Name = "ProgressBarDetailed";
            this.Size = new System.Drawing.Size(316, 49);
            this.backdropPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label itemCounter;
        private System.Windows.Forms.Label timeRemaining;
        private System.Windows.Forms.Panel backdropPanel;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Timer timer;
    }
}
