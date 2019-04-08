namespace WindowsFormsApplication2
{
    partial class RemoveBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mP_LibraryDataSet = new WindowsFormsApplication2.MP_LibraryDataSet();
            this.remove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.remove_books = new System.Windows.Forms.Label();
            this.bookTableAdapter = new WindowsFormsApplication2.MP_LibraryDataSetTableAdapters.bookTableAdapter();
            this.byBooktitle = new System.Windows.Forms.RadioButton();
            this.byBookauthor = new System.Windows.Forms.RadioButton();
            this.byIsbn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP_LibraryDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(126, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 16;
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
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(497, 346);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(128, 41);
            this.remove.TabIndex = 15;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 20);
            this.textBox1.TabIndex = 11;
            // 
            // remove_books
            // 
            this.remove_books.AutoSize = true;
            this.remove_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_books.Location = new System.Drawing.Point(121, 17);
            this.remove_books.Name = "remove_books";
            this.remove_books.Size = new System.Drawing.Size(169, 25);
            this.remove_books.TabIndex = 10;
            this.remove_books.Text = "Remove Books";
            this.remove_books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // byBooktitle
            // 
            this.byBooktitle.AutoSize = true;
            this.byBooktitle.Location = new System.Drawing.Point(126, 59);
            this.byBooktitle.Name = "byBooktitle";
            this.byBooktitle.Size = new System.Drawing.Size(88, 17);
            this.byBooktitle.TabIndex = 17;
            this.byBooktitle.TabStop = true;
            this.byBooktitle.Text = "By Book Title";
            this.byBooktitle.UseVisualStyleBackColor = true;
            // 
            // byBookauthor
            // 
            this.byBookauthor.AutoSize = true;
            this.byBookauthor.Location = new System.Drawing.Point(283, 59);
            this.byBookauthor.Name = "byBookauthor";
            this.byBookauthor.Size = new System.Drawing.Size(99, 17);
            this.byBookauthor.TabIndex = 18;
            this.byBookauthor.TabStop = true;
            this.byBookauthor.Text = "By Book Author";
            this.byBookauthor.UseVisualStyleBackColor = true;
            // 
            // byIsbn
            // 
            this.byIsbn.AutoSize = true;
            this.byIsbn.Location = new System.Drawing.Point(451, 59);
            this.byIsbn.Name = "byIsbn";
            this.byIsbn.Size = new System.Drawing.Size(65, 17);
            this.byIsbn.TabIndex = 19;
            this.byIsbn.TabStop = true;
            this.byIsbn.Text = "By ISBN";
            this.byIsbn.UseVisualStyleBackColor = true;
            // 
            // RemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 405);
            this.Controls.Add(this.byIsbn);
            this.Controls.Add(this.byBookauthor);
            this.Controls.Add(this.byBooktitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.remove_books);
            this.Name = "RemoveBook";
            this.Text = "RemoveBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP_LibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private MP_LibraryDataSet mP_LibraryDataSet;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label remove_books;
        private MP_LibraryDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.RadioButton byBooktitle;
        private System.Windows.Forms.RadioButton byBookauthor;
        private System.Windows.Forms.RadioButton byIsbn;
    }
}