namespace src.form
{
    partial class importTB
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
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.GroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtLocation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddFolder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1.Panel)).BeginInit();
            this.GroupBox1.Panel.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Values.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Values.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(2, -4);
            this.GroupBox1.Name = "GroupBox1";
            // 
            // GroupBox1.Panel
            // 
            this.GroupBox1.Panel.Controls.Add(this.btnAddFolder);
            this.GroupBox1.Panel.Controls.Add(this.txtLocation);
            this.GroupBox1.Size = new System.Drawing.Size(410, 89);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.Values.Heading = "Đường dẫn";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(8, 18);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(288, 23);
            this.txtLocation.TabIndex = 0;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(313, 16);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(90, 25);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Values.Text = "...";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // importTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 128);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "importTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm cơ sở thuật ngữ từ tập tin";
            this.Load += new System.EventHandler(this.importTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1.Panel)).EndInit();
            this.GroupBox1.Panel.ResumeLayout(false);
            this.GroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLocation;
    }
}