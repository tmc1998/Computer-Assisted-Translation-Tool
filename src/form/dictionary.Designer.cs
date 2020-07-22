﻿namespace src.form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGrid = new System.Windows.Forms.DataGridView();
            this.wordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbDictionary = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGrid);
            this.groupBox1.Controls.Add(this.rtbDictionary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ điển";
            // 
            // tbGrid
            // 
            this.tbGrid.AllowUserToAddRows = false;
            this.tbGrid.AllowUserToDeleteRows = false;
            this.tbGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordColumn,
            this.definitionColumn});
            this.tbGrid.Location = new System.Drawing.Point(0, 68);
            this.tbGrid.MultiSelect = false;
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.ReadOnly = true;
            this.tbGrid.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.tbGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbGrid.Size = new System.Drawing.Size(262, 177);
            this.tbGrid.TabIndex = 2;
            this.tbGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbGrid_CellContentClick);
            // 
            // wordColumn
            // 
            this.wordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordColumn.HeaderText = "Từ ";
            this.wordColumn.Name = "wordColumn";
            this.wordColumn.ReadOnly = true;
            this.wordColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // definitionColumn
            // 
            this.definitionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.definitionColumn.HeaderText = "Định nghĩa";
            this.definitionColumn.Name = "definitionColumn";
            this.definitionColumn.ReadOnly = true;
            this.definitionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rtbDictionary
            // 
            this.rtbDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDictionary.Location = new System.Drawing.Point(0, 12);
            this.rtbDictionary.Name = "rtbDictionary";
            this.rtbDictionary.Size = new System.Drawing.Size(262, 50);
            this.rtbDictionary.TabIndex = 1;
            this.rtbDictionary.Text = "";
            // 
            // dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(268, 247);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dictionary";
            this.Text = "dictionary";
            this.Load += new System.EventHandler(this.dictionary_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDictionary;
        private System.Windows.Forms.DataGridView tbGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionColumn;
    }
}