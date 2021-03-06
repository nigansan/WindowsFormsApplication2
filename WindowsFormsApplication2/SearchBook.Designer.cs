﻿namespace WindowsFormsApplication2
{
    partial class SearchBooks
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
            this.search_books = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookTitle = new System.Windows.Forms.CheckBox();
            this.byAuthor = new System.Windows.Forms.CheckBox();
            this.byIsbn = new System.Windows.Forms.CheckBox();
            this.lend = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mP_LibraryDataSet = new WindowsFormsApplication2.MP_LibraryDataSet();
            this.bookTableAdapter = new WindowsFormsApplication2.MP_LibraryDataSetTableAdapters.bookTableAdapter();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP_LibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // search_books
            // 
            this.search_books.AutoSize = true;
            this.search_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_books.Location = new System.Drawing.Point(51, 31);
            this.search_books.Name = "search_books";
            this.search_books.Size = new System.Drawing.Size(158, 25);
            this.search_books.TabIndex = 0;
            this.search_books.Text = "Search Books";
            this.search_books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_books.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.Location = new System.Drawing.Point(56, 70);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(120, 20);
            this.bookTitle.TabIndex = 5;
            this.bookTitle.Text = "By Book Title";
            this.bookTitle.UseVisualStyleBackColor = true;
            this.bookTitle.CheckedChanged += new System.EventHandler(this.bookTitle_CheckedChanged);
            // 
            // byAuthor
            // 
            this.byAuthor.AutoSize = true;
            this.byAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byAuthor.Location = new System.Drawing.Point(215, 70);
            this.byAuthor.Name = "byAuthor";
            this.byAuthor.Size = new System.Drawing.Size(133, 20);
            this.byAuthor.TabIndex = 6;
            this.byAuthor.Text = "By Book Author";
            this.byAuthor.UseVisualStyleBackColor = true;
            // 
            // byIsbn
            // 
            this.byIsbn.AutoSize = true;
            this.byIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byIsbn.Location = new System.Drawing.Point(383, 70);
            this.byIsbn.Name = "byIsbn";
            this.byIsbn.Size = new System.Drawing.Size(84, 20);
            this.byIsbn.TabIndex = 7;
            this.byIsbn.Text = "By ISBN";
            this.byIsbn.UseVisualStyleBackColor = true;
            // 
            // lend
            // 
            this.lend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lend.Location = new System.Drawing.Point(383, 360);
            this.lend.Name = "lend";
            this.lend.Size = new System.Drawing.Size(128, 41);
            this.lend.TabIndex = 8;
            this.lend.Text = "Lend";
            this.lend.UseVisualStyleBackColor = true;
            this.lend.Click += new System.EventHandler(this.lend_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(56, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(793, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.mP_LibraryDataSet;
            // 
            // mP_LibraryDataSet
            // 
            this.mP_LibraryDataSet.DataSetName = "MP_LibraryDataSet";
            this.mP_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(331, 146);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(427, 146);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lend);
            this.Controls.Add(this.byIsbn);
            this.Controls.Add(this.byAuthor);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search_books);
            this.Name = "SearchBooks";
            this.Text = "Search Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP_LibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label search_books;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox bookTitle;
        private System.Windows.Forms.CheckBox byIsbn;
        private System.Windows.Forms.CheckBox byAuthor;
        private System.Windows.Forms.Button lend;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MP_LibraryDataSet mP_LibraryDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private MP_LibraryDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button button1;
    }
}

