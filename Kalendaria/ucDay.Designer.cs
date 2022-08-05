namespace Kalendaria
{
    partial class ucDay
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
            this.lblDayNum = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblDayNum
            // 
            this.lblDayNum.AutoSize = true;
            this.lblDayNum.Location = new System.Drawing.Point(3, 0);
            this.lblDayNum.Name = "lblDayNum";
            this.lblDayNum.Size = new System.Drawing.Size(78, 32);
            this.lblDayNum.TabIndex = 0;
            this.lblDayNum.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 35);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(204, 148);
            this.checkedListBox1.TabIndex = 1;
            // 
            // ucDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblDayNum);
            this.Name = "ucDay";
            this.Size = new System.Drawing.Size(210, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDayNum;
        private CheckedListBox checkedListBox1;
    }
}
