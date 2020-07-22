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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fuzzymatches));
            this.groupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rtbFuzzyMatches = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.resultGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1.Panel)).BeginInit();
            this.groupBox1.Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            // 
            // groupBox1.Panel
            // 
            this.groupBox1.Panel.Controls.Add(this.rtbFuzzyMatches);
            this.groupBox1.Panel.Controls.Add(this.resultGrid);
            this.groupBox1.Size = new System.Drawing.Size(321, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.Values.Heading = "Gợi ý";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtbFuzzyMatches
            // 
            this.rtbFuzzyMatches.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbFuzzyMatches.Location = new System.Drawing.Point(3, -2);
            this.rtbFuzzyMatches.Name = "rtbFuzzyMatches";
            this.rtbFuzzyMatches.Size = new System.Drawing.Size(311, 211);
            this.rtbFuzzyMatches.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.rtbFuzzyMatches.TabIndex = 1;
            this.rtbFuzzyMatches.Text = "";
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceColumn,
            this.targetColumn,
            this.scoreColumn,
            this.typeColumn});
            this.resultGrid.Location = new System.Drawing.Point(4, 4);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.RowHeadersVisible = false;
            this.resultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultGrid.Size = new System.Drawing.Size(300, 195);
            this.resultGrid.TabIndex = 0;
            this.resultGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultGrid_CellContentClick);
            // 
            // sourceColumn
            // 
            this.sourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sourceColumn.HeaderText = "Câu nguồn";
            this.sourceColumn.Name = "sourceColumn";
            this.sourceColumn.ReadOnly = true;
            // 
            // targetColumn
            // 
            this.targetColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.targetColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.targetColumn.HeaderText = "Câu dịch";
            this.targetColumn.Name = "targetColumn";
            this.targetColumn.ReadOnly = true;
            // 
            // scoreColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.scoreColumn.HeaderText = "Điểm";
            this.scoreColumn.Name = "scoreColumn";
            this.scoreColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.typeColumn.HeaderText = "Loại";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // fuzzymatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(331, 240);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fuzzymatches";
            this.Text = "fuzzymatches";
            this.Load += new System.EventHandler(this.fuzzymatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1.Panel)).EndInit();
            this.groupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbFuzzyMatches;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView resultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
    }
}