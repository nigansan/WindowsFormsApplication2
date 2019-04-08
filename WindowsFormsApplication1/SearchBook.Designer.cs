namespace WindowsFormsApplication1
{
    partial class searchBooks
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.search_books = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookTitle = new System.Windows.Forms.CheckBox();
            this.byAuthor = new System.Windows.Forms.CheckBox();
            this.byIsbn = new System.Windows.Forms.CheckBox();
            this.lend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
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
            // searchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 447);
            this.Controls.Add(this.lend);
            this.Controls.Add(this.byIsbn);
            this.Controls.Add(this.byAuthor);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search_books);
            this.Name = "searchBooks";
            this.Text = "searchBooks";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label search_books;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox bookTitle;
        private System.Windows.Forms.CheckBox byIsbn;
        private System.Windows.Forms.CheckBox byAuthor;
        private System.Windows.Forms.Button lend;
    }
}

