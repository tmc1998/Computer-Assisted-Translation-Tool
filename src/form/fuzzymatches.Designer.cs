namespace src.form
{
    partial class fuzzymatches
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblfuzzymatches = new System.Windows.Forms.Label();
            this.rtbFuzzyMatches = new System.Windows.Forms.RichTextBox();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTop.Controls.Add(this.lblfuzzymatches);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 36);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // lblfuzzymatches
            // 
            this.lblfuzzymatches.AutoSize = true;
            this.lblfuzzymatches.Location = new System.Drawing.Point(3, 9);
            this.lblfuzzymatches.Name = "lblfuzzymatches";
            this.lblfuzzymatches.Size = new System.Drawing.Size(74, 13);
            this.lblfuzzymatches.TabIndex = 0;
            this.lblfuzzymatches.Text = "fuzzy matches";
            // 
            // rtbFuzzyMatches
            // 
            this.rtbFuzzyMatches.Location = new System.Drawing.Point(6, 42);
            this.rtbFuzzyMatches.Name = "rtbFuzzyMatches";
            this.rtbFuzzyMatches.ReadOnly = true;
            this.rtbFuzzyMatches.Size = new System.Drawing.Size(920, 403);
            this.rtbFuzzyMatches.TabIndex = 1;
            this.rtbFuzzyMatches.Text = "";
            // 
            // fuzzymatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFuzzyMatches);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fuzzymatches";
            this.Text = "fuzzymatches";
            this.Load += new System.EventHandler(this.fuzzymatches_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblfuzzymatches;
        private System.Windows.Forms.RichTextBox rtbFuzzyMatches;
    }
}