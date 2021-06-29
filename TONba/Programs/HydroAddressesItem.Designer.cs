namespace I_IT
{
    partial class HydroAddressesItem
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
            this.button2 = new System.Windows.Forms.Button();
            this.RollNo = new System.Windows.Forms.TextBox();
            this.OldAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(379, 180);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 60);
            this.button2.TabIndex = 38;
            this.button2.Text = "Save and Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // RollNo
            // 
            this.RollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RollNo.Location = new System.Drawing.Point(214, 115);
            this.RollNo.Margin = new System.Windows.Forms.Padding(4);
            this.RollNo.MaxLength = 19;
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(260, 28);
            this.RollNo.TabIndex = 80;
            // 
            // OldAdd
            // 
            this.OldAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OldAdd.Location = new System.Drawing.Point(214, 71);
            this.OldAdd.Margin = new System.Windows.Forms.Padding(4);
            this.OldAdd.MaxLength = 30;
            this.OldAdd.Name = "OldAdd";
            this.OldAdd.Size = new System.Drawing.Size(260, 28);
            this.OldAdd.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(61, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 78;
            this.label3.Text = "Roll Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "Address";
            // 
            // HydroAddressesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 270);
            this.Controls.Add(this.RollNo);
            this.Controls.Add(this.OldAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "HydroAddressesItem";
            this.Text = "Hydro Addresses Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox RollNo;
        private System.Windows.Forms.TextBox OldAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}