namespace WindowsFormsApplication2
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
            this.mP_LibraryDataSet = new WindowsFormsApplication2.MP_LibraryDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new WindowsFormsApplication2.MP_LibraryDataSetTableAdapters.bookTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
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
            this.textBox1.Location = new System.Drawing.Point(56, 143);
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
            this.lend.Location = new System.Drawing.Point(427, 360);
            this.lend.Name = "lend";
            this.lend.Size = new System.Drawing.Size(128, 41);
            this.lend.TabIndex = 8;
            this.lend.Text = "Lend";
            this.lend.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // mP_LibraryDataSet
            // 
            this.mP_LibraryDataSet.DataSetName = "MP_LibraryDataSet";
            this.mP_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.mP_LibraryDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 447);
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
            ((System.ComponentModel.ISupportInitialize)(this.mP_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
    }
}

