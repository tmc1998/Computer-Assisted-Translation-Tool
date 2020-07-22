namespace src.form
{
    partial class editor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
            this.groupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.editorGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.rtbTutorial = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.sourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1.Panel)).BeginInit();
            this.groupBox1.Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            // 
            // groupBox1.Panel
            // 
            this.groupBox1.Panel.Controls.Add(this.rtbTutorial);
            this.groupBox1.Panel.Controls.Add(this.editorGrid);
            this.groupBox1.Panel.Controls.Add(this.lblStatus);
            this.groupBox1.Size = new System.Drawing.Size(549, 476);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.Values.Heading = "Hướng dẫn";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(4, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(128, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Values.Text = "Trạng thái phân đoạn";
            // 
            // editorGrid
            // 
            this.editorGrid.AllowUserToAddRows = false;
            this.editorGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.editorGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.editorGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.editorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceColumn,
            this.targetColumn,
            this.confirmColumn});
            this.editorGrid.Location = new System.Drawing.Point(2, 21);
            this.editorGrid.Name = "editorGrid";
            this.editorGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.editorGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.editorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.editorGrid.Size = new System.Drawing.Size(534, 250);
            this.editorGrid.TabIndex = 2;
            // 
            // rtbTutorial
            // 
            this.rtbTutorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTutorial.Location = new System.Drawing.Point(2, 135);
            this.rtbTutorial.Name = "rtbTutorial";
            this.rtbTutorial.Size = new System.Drawing.Size(540, 314);
            this.rtbTutorial.TabIndex = 3;
            this.rtbTutorial.Text = "";
            // 
            // sourceColumn
            // 
            this.sourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sourceColumn.HeaderText = "Câu nguồn";
            this.sourceColumn.Name = "sourceColumn";
            this.sourceColumn.ReadOnly = true;
            this.sourceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // targetColumn
            // 
            this.targetColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.targetColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.targetColumn.HeaderText = "Câu dịch";
            this.targetColumn.MinimumWidth = 100;
            this.targetColumn.Name = "targetColumn";
            // 
            // confirmColumn
            // 
            dataGridViewCellStyle4.NullValue = false;
            this.confirmColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.confirmColumn.FillWeight = 152.2843F;
            this.confirmColumn.HeaderText = "Đã lưu";
            this.confirmColumn.Name = "confirmColumn";
            this.confirmColumn.ReadOnly = true;
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(555, 490);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1.Panel)).EndInit();
            this.groupBox1.Panel.ResumeLayout(false);
            this.groupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbTutorial;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView editorGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmColumn;
    }
}