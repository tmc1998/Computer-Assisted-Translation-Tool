namespace src.form
{
    partial class projectfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projectfiles));
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lbltimecreation = new System.Windows.Forms.Label();
            this.lblLocationFile = new System.Windows.Forms.Label();
            this.btnVertical = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.groupBoxFileSelect = new System.Windows.Forms.GroupBox();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.groupBoxFileSelect.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListIcon
            // 
            this.imageListIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListIcon.TransparentColor = System.Drawing.Color.White;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl1.Location = new System.Drawing.Point(6, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(92, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Tên dự án : ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl2.Location = new System.Drawing.Point(6, 126);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(117, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Địa chỉ tập tin : ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(447, 30);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(171, 44);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Mở tập tin";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(447, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Location = new System.Drawing.Point(176, 27);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(51, 20);
            this.lblNameProject.TabIndex = 7;
            this.lblNameProject.Text = "label1";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreationTime.Location = new System.Drawing.Point(6, 77);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(108, 20);
            this.lblCreationTime.TabIndex = 8;
            this.lblCreationTime.Text = "Thời gian tạo :";
            // 
            // lbltimecreation
            // 
            this.lbltimecreation.AutoSize = true;
            this.lbltimecreation.Location = new System.Drawing.Point(176, 77);
            this.lbltimecreation.Name = "lbltimecreation";
            this.lbltimecreation.Size = new System.Drawing.Size(51, 20);
            this.lbltimecreation.TabIndex = 9;
            this.lbltimecreation.Text = "label1";
            // 
            // lblLocationFile
            // 
            this.lblLocationFile.AutoSize = true;
            this.lblLocationFile.Location = new System.Drawing.Point(176, 126);
            this.lblLocationFile.Name = "lblLocationFile";
            this.lblLocationFile.Size = new System.Drawing.Size(51, 20);
            this.lblLocationFile.TabIndex = 10;
            this.lblLocationFile.Text = "label1";
            // 
            // btnVertical
            // 
            this.btnVertical.Image = ((System.Drawing.Image)(resources.GetObject("btnVertical.Image")));
            this.btnVertical.Location = new System.Drawing.Point(529, 293);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(89, 90);
            this.btnVertical.TabIndex = 6;
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("btnHorizontal.Image")));
            this.btnHorizontal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHorizontal.Location = new System.Drawing.Point(529, 143);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(89, 89);
            this.btnHorizontal.TabIndex = 5;
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LargeImageList = this.imageListIcon;
            this.listViewFiles.Location = new System.Drawing.Point(6, 30);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(517, 460);
            this.listViewFiles.SmallImageList = this.imageListIcon;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // groupBoxFileSelect
            // 
            this.groupBoxFileSelect.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxFileSelect.Controls.Add(this.listViewFiles);
            this.groupBoxFileSelect.Controls.Add(this.btnVertical);
            this.groupBoxFileSelect.Controls.Add(this.btnHorizontal);
            this.groupBoxFileSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxFileSelect.Location = new System.Drawing.Point(6, 12);
            this.groupBoxFileSelect.Name = "groupBoxFileSelect";
            this.groupBoxFileSelect.Size = new System.Drawing.Size(624, 504);
            this.groupBoxFileSelect.TabIndex = 12;
            this.groupBoxFileSelect.TabStop = false;
            this.groupBoxFileSelect.Text = "Chọn tệp";
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDetail.Controls.Add(this.lblLocationFile);
            this.groupBoxDetail.Controls.Add(this.lbl1);
            this.groupBoxDetail.Controls.Add(this.lbl2);
            this.groupBoxDetail.Controls.Add(this.btnCancel);
            this.groupBoxDetail.Controls.Add(this.lblNameProject);
            this.groupBoxDetail.Controls.Add(this.btnOk);
            this.groupBoxDetail.Controls.Add(this.lbltimecreation);
            this.groupBoxDetail.Controls.Add(this.lblCreationTime);
            this.groupBoxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxDetail.Location = new System.Drawing.Point(6, 522);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(624, 174);
            this.groupBoxDetail.TabIndex = 13;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "Thông tin";
            // 
            // projectfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 708);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.groupBoxFileSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "projectfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.projectfiles_FormClosing);
            this.Load += new System.EventHandler(this.projectfiles_Load);
            this.groupBoxFileSelect.ResumeLayout(false);
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label lbltimecreation;
        private System.Windows.Forms.Label lblLocationFile;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.GroupBox groupBoxFileSelect;
        private System.Windows.Forms.GroupBox groupBoxDetail;
    }
}