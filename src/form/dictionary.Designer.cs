namespace src.form
{
    partial class dictionary
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.GroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rtbDictionary = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.tbGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.wordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sentenceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1.Panel)).BeginInit();
            this.GroupBox1.Panel.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(157, 1);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonDataGridView1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(156, 253);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Cơ sở thuật ngữ";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(1, 1);
            this.GroupBox1.Name = "GroupBox1";
            // 
            // GroupBox1.Panel
            // 
            this.GroupBox1.Panel.Controls.Add(this.tbGrid);
            this.GroupBox1.Panel.Controls.Add(this.rtbDictionary);
            this.GroupBox1.Size = new System.Drawing.Size(150, 253);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.Values.Heading = "Từ điển";
            // 
            // rtbDictionary
            // 
            this.rtbDictionary.Location = new System.Drawing.Point(3, 4);
            this.rtbDictionary.Name = "rtbDictionary";
            this.rtbDictionary.Size = new System.Drawing.Size(140, 54);
            this.rtbDictionary.TabIndex = 0;
            this.rtbDictionary.Text = "";
            // 
            // tbGrid
            // 
            this.tbGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordColumn,
            this.definitionColumn});
            this.tbGrid.Location = new System.Drawing.Point(3, 65);
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.RowHeadersVisible = false;
            this.tbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tbGrid.Size = new System.Drawing.Size(140, 174);
            this.tbGrid.TabIndex = 1;
            this.tbGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbGrid_CellContentClick);
            // 
            // wordColumn
            // 
            this.wordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordColumn.HeaderText = "Từ vựng";
            this.wordColumn.Name = "wordColumn";
            this.wordColumn.ReadOnly = true;
            // 
            // definitionColumn
            // 
            this.definitionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.definitionColumn.HeaderText = "Định nghĩa";
            this.definitionColumn.Name = "definitionColumn";
            this.definitionColumn.ReadOnly = true;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sentenceColumn,
            this.FileColumn});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(4, 4);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(145, 222);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // sentenceColumn
            // 
            this.sentenceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sentenceColumn.HeaderText = "Câu văn";
            this.sentenceColumn.Name = "sentenceColumn";
            this.sentenceColumn.ReadOnly = true;
            // 
            // FileColumn
            // 
            this.FileColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileColumn.HeaderText = "Tệp tin chứa";
            this.FileColumn.Name = "FileColumn";
            this.FileColumn.ReadOnly = true;
            // 
            // dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(316, 260);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.kryptonGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dictionary";
            this.Text = "dictionary";
            this.Load += new System.EventHandler(this.dictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1.Panel)).EndInit();
            this.GroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView tbGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbDictionary;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentenceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileColumn;
    }
}