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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
            this.groupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rtbTutorial = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.editorGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dataGridViewHTMLColumn1 = new DataGridViewHTML.DataGridViewHTMLColumn();
            this.htmlSourceColumn = new DataGridViewHTML.DataGridViewHTMLColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.sourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Size = new System.Drawing.Size(549, 497);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.Values.Heading = "Hướng dẫn";
            // 
            // rtbTutorial
            // 
            this.rtbTutorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTutorial.Location = new System.Drawing.Point(2, 4);
            this.rtbTutorial.Name = "rtbTutorial";
            this.rtbTutorial.Size = new System.Drawing.Size(540, 466);
            this.rtbTutorial.TabIndex = 3;
            this.rtbTutorial.Text = "";
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
            this.htmlSourceColumn,
            this.targetColumn,
            this.confirmColumn,
            this.sourceColumn});
            this.editorGrid.Location = new System.Drawing.Point(2, 21);
            this.editorGrid.MultiSelect = false;
            this.editorGrid.Name = "editorGrid";
            this.editorGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.editorGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.editorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.editorGrid.Size = new System.Drawing.Size(534, 444);
            this.editorGrid.TabIndex = 2;
            this.editorGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editorGrid_CellClick);
            this.editorGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editorGrid_CellContentClick);
            this.editorGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.editorGrid_CellEndEdit);
            this.editorGrid.SelectionChanged += new System.EventHandler(this.editorGrid_SelectionChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(4, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(128, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Values.Text = "Trạng thái phân đoạn";
            // 
            // dataGridViewHTMLColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHTMLColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewHTMLColumn1.HeaderText = "Câu nguồn";
            this.dataGridViewHTMLColumn1.Name = "dataGridViewHTMLColumn1";
            this.dataGridViewHTMLColumn1.ReadOnly = true;
            // 
            // htmlSourceColumn
            // 
            this.htmlSourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.htmlSourceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.htmlSourceColumn.FillWeight = 200F;
            this.htmlSourceColumn.HeaderText = "Câu nguồn";
            this.htmlSourceColumn.Name = "htmlSourceColumn";
            this.htmlSourceColumn.ReadOnly = true;
            // 
            // targetColumn
            // 
            this.targetColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.targetColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.targetColumn.FillWeight = 111.9289F;
            this.targetColumn.HeaderText = "Câu dịch";
            this.targetColumn.Name = "targetColumn";
            // 
            // confirmColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = false;
            this.confirmColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.confirmColumn.FalseValue = null;
            this.confirmColumn.FillWeight = 76.14214F;
            this.confirmColumn.HeaderText = "Đã lưu";
            this.confirmColumn.IndeterminateValue = null;
            this.confirmColumn.Name = "confirmColumn";
            this.confirmColumn.ReadOnly = true;
            this.confirmColumn.TrueValue = null;
            this.confirmColumn.Width = 50;
            // 
            // sourceColumn
            // 
            this.sourceColumn.HeaderText = "Column1";
            this.sourceColumn.Name = "sourceColumn";
            this.sourceColumn.ReadOnly = true;
            this.sourceColumn.Visible = false;
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(555, 501);
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
        private DataGridViewHTML.DataGridViewHTMLColumn dataGridViewHTMLColumn1;
        private DataGridViewHTML.DataGridViewHTMLColumn htmlSourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn confirmColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumn;
    }
}