namespace LibraryManagementSystem
{
    partial class AUDBooksForm
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
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.authorNameTextbox = new System.Windows.Forms.TextBox();
            this.publisherTextbox = new System.Windows.Forms.TextBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.bookIdTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookLocationLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfCopiesTextbox = new System.Windows.Forms.TextBox();
            this.dissertationsRadioBtn = new System.Windows.Forms.RadioButton();
            this.reviewsRadioBtn = new System.Windows.Forms.RadioButton();
            this.courseRadioButton = new System.Windows.Forms.RadioButton();
            this.journalRadioBtn = new System.Windows.Forms.RadioButton();
            this.articlesRadioBtn = new System.Windows.Forms.RadioButton();
            this.referenceRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.allBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher Name:";
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Location = new System.Drawing.Point(166, 120);
            this.bookNameTextbox.Multiline = true;
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(227, 33);
            this.bookNameTextbox.TabIndex = 4;
            // 
            // authorNameTextbox
            // 
            this.authorNameTextbox.Location = new System.Drawing.Point(166, 163);
            this.authorNameTextbox.Multiline = true;
            this.authorNameTextbox.Name = "authorNameTextbox";
            this.authorNameTextbox.Size = new System.Drawing.Size(227, 34);
            this.authorNameTextbox.TabIndex = 5;
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.Location = new System.Drawing.Point(166, 210);
            this.publisherTextbox.Multiline = true;
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Size = new System.Drawing.Size(227, 31);
            this.publisherTextbox.TabIndex = 6;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(61, 300);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 46);
            this.addBookButton.TabIndex = 8;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // updateBookButton
            // 
            this.updateBookButton.Location = new System.Drawing.Point(191, 300);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(75, 46);
            this.updateBookButton.TabIndex = 9;
            this.updateBookButton.Text = "Update Book";
            this.updateBookButton.UseVisualStyleBackColor = true;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(318, 300);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(75, 46);
            this.deleteBookButton.TabIndex = 10;
            this.deleteBookButton.Text = "Delete Book";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // bookIdTextbox
            // 
            this.bookIdTextbox.Location = new System.Drawing.Point(166, 73);
            this.bookIdTextbox.Multiline = true;
            this.bookIdTextbox.Name = "bookIdTextbox";
            this.bookIdTextbox.Size = new System.Drawing.Size(227, 36);
            this.bookIdTextbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Book ID:";
            // 
            // bookLocationLabel
            // 
            this.bookLocationLabel.AutoSize = true;
            this.bookLocationLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLocationLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.bookLocationLabel.Location = new System.Drawing.Point(525, 93);
            this.bookLocationLabel.Name = "bookLocationLabel";
            this.bookLocationLabel.Size = new System.Drawing.Size(0, 20);
            this.bookLocationLabel.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "No. Of Copies:";
            // 
            // numberOfCopiesTextbox
            // 
            this.numberOfCopiesTextbox.Location = new System.Drawing.Point(166, 248);
            this.numberOfCopiesTextbox.Multiline = true;
            this.numberOfCopiesTextbox.Name = "numberOfCopiesTextbox";
            this.numberOfCopiesTextbox.Size = new System.Drawing.Size(100, 30);
            this.numberOfCopiesTextbox.TabIndex = 27;
            // 
            // dissertationsRadioBtn
            // 
            this.dissertationsRadioBtn.AutoSize = true;
            this.dissertationsRadioBtn.Location = new System.Drawing.Point(35, 38);
            this.dissertationsRadioBtn.Name = "dissertationsRadioBtn";
            this.dissertationsRadioBtn.Size = new System.Drawing.Size(116, 22);
            this.dissertationsRadioBtn.TabIndex = 28;
            this.dissertationsRadioBtn.TabStop = true;
            this.dissertationsRadioBtn.Text = "Dissertations";
            this.dissertationsRadioBtn.UseVisualStyleBackColor = true;
            this.dissertationsRadioBtn.CheckedChanged += new System.EventHandler(this.dissertationsRadioBtn_CheckedChanged);
            // 
            // reviewsRadioBtn
            // 
            this.reviewsRadioBtn.AutoSize = true;
            this.reviewsRadioBtn.Location = new System.Drawing.Point(167, 38);
            this.reviewsRadioBtn.Name = "reviewsRadioBtn";
            this.reviewsRadioBtn.Size = new System.Drawing.Size(85, 22);
            this.reviewsRadioBtn.TabIndex = 29;
            this.reviewsRadioBtn.TabStop = true;
            this.reviewsRadioBtn.Text = "Reveiws";
            this.reviewsRadioBtn.UseVisualStyleBackColor = true;
            this.reviewsRadioBtn.CheckedChanged += new System.EventHandler(this.dissertationsRadioBtn_CheckedChanged);
            // 
            // courseRadioButton
            // 
            this.courseRadioButton.AutoSize = true;
            this.courseRadioButton.Location = new System.Drawing.Point(35, 78);
            this.courseRadioButton.Name = "courseRadioButton";
            this.courseRadioButton.Size = new System.Drawing.Size(118, 22);
            this.courseRadioButton.TabIndex = 30;
            this.courseRadioButton.TabStop = true;
            this.courseRadioButton.Text = "Course Book";
            this.courseRadioButton.UseVisualStyleBackColor = true;
            this.courseRadioButton.CheckedChanged += new System.EventHandler(this.dissertationsRadioBtn_CheckedChanged);
            // 
            // journalRadioBtn
            // 
            this.journalRadioBtn.AutoSize = true;
            this.journalRadioBtn.Location = new System.Drawing.Point(167, 78);
            this.journalRadioBtn.Name = "journalRadioBtn";
            this.journalRadioBtn.Size = new System.Drawing.Size(86, 22);
            this.journalRadioBtn.TabIndex = 31;
            this.journalRadioBtn.TabStop = true;
            this.journalRadioBtn.Text = "Journals";
            this.journalRadioBtn.UseVisualStyleBackColor = true;
            this.journalRadioBtn.CheckedChanged += new System.EventHandler(this.dissertationsRadioBtn_CheckedChanged);
            // 
            // articlesRadioBtn
            // 
            this.articlesRadioBtn.AutoSize = true;
            this.articlesRadioBtn.Location = new System.Drawing.Point(35, 115);
            this.articlesRadioBtn.Name = "articlesRadioBtn";
            this.articlesRadioBtn.Size = new System.Drawing.Size(77, 22);
            this.articlesRadioBtn.TabIndex = 32;
            this.articlesRadioBtn.TabStop = true;
            this.articlesRadioBtn.Text = "Articles";
            this.articlesRadioBtn.UseVisualStyleBackColor = true;
            this.articlesRadioBtn.CheckedChanged += new System.EventHandler(this.dissertationsRadioBtn_CheckedChanged);
            // 
            // referenceRadioBtn
            // 
            this.referenceRadioBtn.AutoSize = true;
            this.referenceRadioBtn.Location = new System.Drawing.Point(167, 115);
            this.referenceRadioBtn.Name = "referenceRadioBtn";
            this.referenceRadioBtn.Size = new System.Drawing.Size(147, 22);
            this.referenceRadioBtn.TabIndex = 33;
            this.referenceRadioBtn.TabStop = true;
            this.referenceRadioBtn.Text = "Reference Entries";
            this.referenceRadioBtn.UseVisualStyleBackColor = true;
            this.referenceRadioBtn.CheckedChanged += new System.EventHandler(this.dissertationsRadioBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dissertationsRadioBtn);
            this.groupBox1.Controls.Add(this.referenceRadioBtn);
            this.groupBox1.Controls.Add(this.reviewsRadioBtn);
            this.groupBox1.Controls.Add(this.articlesRadioBtn);
            this.groupBox1.Controls.Add(this.courseRadioButton);
            this.groupBox1.Controls.Add(this.journalRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(529, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 154);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genre";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Red;
            this.resultLabel.Location = new System.Drawing.Point(421, 9);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 35;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(809, 547);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 41);
            this.exitBtn.TabIndex = 36;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(399, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 33);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // allBooksDataGridView
            // 
            this.allBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBooksDataGridView.Location = new System.Drawing.Point(12, 352);
            this.allBooksDataGridView.Name = "allBooksDataGridView";
            this.allBooksDataGridView.RowHeadersWidth = 51;
            this.allBooksDataGridView.RowTemplate.Height = 24;
            this.allBooksDataGridView.Size = new System.Drawing.Size(891, 189);
            this.allBooksDataGridView.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Book Details";
            // 
            // AUDBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allBooksDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numberOfCopiesTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bookLocationLabel);
            this.Controls.Add(this.bookIdTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.updateBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.publisherTextbox);
            this.Controls.Add(this.authorNameTextbox);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AUDBooks";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.AUDBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.TextBox authorNameTextbox;
        private System.Windows.Forms.TextBox publisherTextbox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.TextBox bookIdTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bookLocationLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberOfCopiesTextbox;
        private System.Windows.Forms.RadioButton dissertationsRadioBtn;
        private System.Windows.Forms.RadioButton reviewsRadioBtn;
        private System.Windows.Forms.RadioButton courseRadioButton;
        private System.Windows.Forms.RadioButton journalRadioBtn;
        private System.Windows.Forms.RadioButton articlesRadioBtn;
        private System.Windows.Forms.RadioButton referenceRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView allBooksDataGridView;
        private System.Windows.Forms.Label label4;
    }
}