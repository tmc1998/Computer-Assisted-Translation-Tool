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
            this.btnSelectFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBoxFileSelect = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnHorizontal = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVertical = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.groupBoxDetail = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lblLocationFile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbltimecreation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNameProject = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxFileSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxFileSelect.Panel)).BeginInit();
            this.groupBoxFileSelect.Panel.SuspendLayout();
            this.groupBoxFileSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxDetail.Panel)).BeginInit();
            this.groupBoxDetail.Panel.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListIcon
            // 
            this.imageListIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListIcon.TransparentColor = System.Drawing.Color.White;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(192, 641);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(140, 35);
            this.btnSelectFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.TabIndex = 15;
            this.btnSelectFile.Values.Text = "Chọn tệp tin thêm";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(338, 641);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 35);
            this.btnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.TabIndex = 16;
            this.btnOk.Values.Text = "Mở tập tin";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(484, 641);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Values.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxFileSelect
            // 
            this.groupBoxFileSelect.Location = new System.Drawing.Point(12, 0);
            this.groupBoxFileSelect.Name = "groupBoxFileSelect";
            // 
            // groupBoxFileSelect.Panel
            // 
            this.groupBoxFileSelect.Panel.Controls.Add(this.btnHorizontal);
            this.groupBoxFileSelect.Panel.Controls.Add(this.btnVertical);
            this.groupBoxFileSelect.Panel.Controls.Add(this.listViewFiles);
            this.groupBoxFileSelect.Size = new System.Drawing.Size(612, 502);
            this.groupBoxFileSelect.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFileSelect.TabIndex = 18;
            this.groupBoxFileSelect.Values.Heading = "Danh sách tệp tin";
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Location = new System.Drawing.Point(517, 160);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(74, 75);
            this.btnHorizontal.TabIndex = 2;
            this.btnHorizontal.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnHorizontal.Values.Image")));
            this.btnHorizontal.Values.Text = "";
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(517, 257);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(74, 75);
            this.btnVertical.TabIndex = 1;
            this.btnVertical.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnVertical.Values.Image")));
            this.btnVertical.Values.Text = "";
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.GridLines = true;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(4, 3);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(493, 465);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Location = new System.Drawing.Point(12, 508);
            this.groupBoxDetail.Name = "groupBoxDetail";
            // 
            // groupBoxDetail.Panel
            // 
            this.groupBoxDetail.Panel.Controls.Add(this.lblLocationFile);
            this.groupBoxDetail.Panel.Controls.Add(this.lbltimecreation);
            this.groupBoxDetail.Panel.Controls.Add(this.lblNameProject);
            this.groupBoxDetail.Panel.Controls.Add(this.kryptonLabel3);
            this.groupBoxDetail.Panel.Controls.Add(this.kryptonLabel2);
            this.groupBoxDetail.Panel.Controls.Add(this.kryptonLabel1);
            this.groupBoxDetail.Size = new System.Drawing.Size(612, 127);
            this.groupBoxDetail.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetail.TabIndex = 7;
            this.groupBoxDetail.Values.Heading = "Thông tin";
            // 
            // lblLocationFile
            // 
            this.lblLocationFile.Location = new System.Drawing.Point(116, 68);
            this.lblLocationFile.Name = "lblLocationFile";
            this.lblLocationFile.Size = new System.Drawing.Size(50, 16);
            this.lblLocationFile.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationFile.TabIndex = 5;
            this.lblLocationFile.Values.Text = "address";
            // 
            // lbltimecreation
            // 
            this.lbltimecreation.Location = new System.Drawing.Point(116, 37);
            this.lbltimecreation.Name = "lbltimecreation";
            this.lbltimecreation.Size = new System.Drawing.Size(32, 16);
            this.lbltimecreation.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimecreation.TabIndex = 4;
            this.lbltimecreation.Values.Text = "time";
            // 
            // lblNameProject
            // 
            this.lblNameProject.Location = new System.Drawing.Point(116, 6);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(39, 16);
            this.lblNameProject.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.TabIndex = 3;
            this.lblNameProject.Values.Text = "name";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(8, 72);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(79, 16);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Địa chỉ tệp tin";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 41);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(79, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Thời gian tạo:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 10);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(64, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Tên dự án:";
            // 
            // projectfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 680);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.groupBoxFileSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "projectfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.projectfiles_FormClosing);
            this.Load += new System.EventHandler(this.projectfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxFileSelect.Panel)).EndInit();
            this.groupBoxFileSelect.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxFileSelect)).EndInit();
            this.groupBoxFileSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxDetail.Panel)).EndInit();
            this.groupBoxDetail.Panel.ResumeLayout(false);
            this.groupBoxDetail.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxDetail)).EndInit();
            this.groupBoxDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSelectFile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupBoxFileSelect;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupBoxDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLocationFile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltimecreation;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNameProject;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ListView listViewFiles;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVertical;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnHorizontal;
    }
}