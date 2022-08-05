namespace Kalendaria
{
    partial class frmPreferences
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
            this.flpPreferences = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrefsDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpPreferences
            // 
            this.flpPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPreferences.AutoScroll = true;
            this.flpPreferences.Location = new System.Drawing.Point(12, 12);
            this.flpPreferences.Name = "flpPreferences";
            this.flpPreferences.Size = new System.Drawing.Size(450, 553);
            this.flpPreferences.TabIndex = 0;
            // 
            // btnPrefsDone
            // 
            this.btnPrefsDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrefsDone.Location = new System.Drawing.Point(158, 571);
            this.btnPrefsDone.Name = "btnPrefsDone";
            this.btnPrefsDone.Size = new System.Drawing.Size(150, 46);
            this.btnPrefsDone.TabIndex = 1;
            this.btnPrefsDone.Text = "Done";
            this.btnPrefsDone.UseVisualStyleBackColor = true;
            this.btnPrefsDone.Click += new System.EventHandler(this.btnPrefsDone_Click);
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(474, 629);
            this.Controls.Add(this.btnPrefsDone);
            this.Controls.Add(this.flpPreferences);
            this.Name = "frmPreferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpPreferences;
        private Button btnPrefsDone;
    }
}