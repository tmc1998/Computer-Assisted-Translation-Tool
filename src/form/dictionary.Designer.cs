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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rtbTermbase = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.tbOffGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.sentenceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rtbD = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.tbGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.wordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbDictionary = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOffGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1.Panel)).BeginInit();
            this.GroupBox1.Panel.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(157, 1);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.rtbTermbase);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tbOffGrid);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(164, 250);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Cơ sở thuật ngữ";
            // 
            // rtbTermbase
            // 
            this.rtbTermbase.Location = new System.Drawing.Point(3, 4);
            this.rtbTermbase.Name = "rtbTermbase";
            this.rtbTermbase.Size = new System.Drawing.Size(154, 232);
            this.rtbTermbase.TabIndex = 3;
            this.rtbTermbase.Text = "";
            // 
            // tbOffGrid
            // 
            this.tbOffGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbOffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbOffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sentenceColumn,
            this.FileColumn});
            this.tbOffGrid.Location = new System.Drawing.Point(4, 4);
            this.tbOffGrid.Name = "tbOffGrid";
            this.tbOffGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbOffGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tbOffGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tbOffGrid.Size = new System.Drawing.Size(153, 222);
            this.tbOffGrid.TabIndex = 0;
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
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(1, 1);
            this.GroupBox1.Name = "GroupBox1";
            // 
            // GroupBox1.Panel
            // 
            this.GroupBox1.Panel.Controls.Add(this.rtbD);
            this.GroupBox1.Panel.Controls.Add(this.tbGrid);
            this.GroupBox1.Panel.Controls.Add(this.rtbDictionary);
            this.GroupBox1.Size = new System.Drawing.Size(150, 250);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.Values.Heading = "Từ điển";
            // 
            // rtbD
            // 
            this.rtbD.Location = new System.Drawing.Point(3, 4);
            this.rtbD.Name = "rtbD";
            this.rtbD.Size = new System.Drawing.Size(140, 232);
            this.rtbD.TabIndex = 2;
            this.rtbD.Text = "";
            // 
            // tbGrid
            // 
            this.tbGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordColumn,
            this.definitionColumn});
            this.tbGrid.Location = new System.Drawing.Point(3, 3);
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.RowHeadersVisible = false;
            this.tbGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbGrid.Size = new System.Drawing.Size(140, 236);
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
            // rtbDictionary
            // 
            this.rtbDictionary.Location = new System.Drawing.Point(3, 4);
            this.rtbDictionary.Name = "rtbDictionary";
            this.rtbDictionary.Size = new System.Drawing.Size(140, 54);
            this.rtbDictionary.TabIndex = 0;
            this.rtbDictionary.Text = "";
            // 
            // dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(325, 252);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbOffGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1.Panel)).EndInit();
            this.GroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView tbGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbDictionary;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView tbOffGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentenceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbTermbase;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbD;
        //private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbDict;
    }
}