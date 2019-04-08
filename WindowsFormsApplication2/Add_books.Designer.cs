namespace WindowsFormsApplication2
{
    partial class Add_books
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.authorName = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.saveBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author Name\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lanuage";
            // 
            // language
            // 
            this.language.FormattingEnabled = true;
            this.language.Items.AddRange(new object[] {
            "Sinhala",
            "Tamil",
            "English"});
            this.language.Location = new System.Drawing.Point(157, 221);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(121, 21);
            this.language.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Qty.";
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(157, 23);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(226, 20);
            this.bookTitle.TabIndex = 6;
            this.bookTitle.TextChanged += new System.EventHandler(this.bookTitle_TextChanged);
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(157, 79);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(226, 20);
            this.isbn.TabIndex = 7;
            // 
            // authorName
            // 
            this.authorName.Location = new System.Drawing.Point(157, 146);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(226, 20);
            this.authorName.TabIndex = 8;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(157, 294);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(121, 20);
            this.qty.TabIndex = 9;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(157, 365);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 32);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // saveBook
            // 
            this.saveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBook.Location = new System.Drawing.Point(317, 365);
            this.saveBook.Name = "saveBook";
            this.saveBook.Size = new System.Drawing.Size(121, 32);
            this.saveBook.TabIndex = 11;
            this.saveBook.Text = "Save Book";
            this.saveBook.UseVisualStyleBackColor = true;
            // 
            // Add_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 440);
            this.Controls.Add(this.saveBook);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.language);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_books";
            this.Text = "Add Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox language;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button saveBook;

    }
}