namespace LibraryManagementSystem
{
    partial class LibrarianLogInForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGenreDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.searchedBookGridView = new System.Windows.Forms.DataGridView();
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchedBookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueBookToolStripMenuItem,
            this.issueBookToolStripMenuItem1,
            this.logOutToolStripMenuItem,
            this.showAllBooksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.issueBookToolStripMenuItem.Text = "Find Book";
            // 
            // issueBookToolStripMenuItem1
            // 
            this.issueBookToolStripMenuItem1.Name = "issueBookToolStripMenuItem1";
            this.issueBookToolStripMenuItem1.Size = new System.Drawing.Size(146, 24);
            this.issueBookToolStripMenuItem1.Text = "Issue/ Return Book";
            this.issueBookToolStripMenuItem1.Click += new System.EventHandler(this.issueBookToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // searchGenreDropdown
            // 
            this.searchGenreDropdown.FormattingEnabled = true;
            this.searchGenreDropdown.Location = new System.Drawing.Point(181, 142);
            this.searchGenreDropdown.Name = "searchGenreDropdown";
            this.searchGenreDropdown.Size = new System.Drawing.Size(121, 24);
            this.searchGenreDropdown.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Search by Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Find Book";
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(476, 85);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(75, 40);
            this.searchBookButton.TabIndex = 16;
            this.searchBookButton.Text = "Search";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.searchBookButton_Click);
            // 
            // searchedBookGridView
            // 
            this.searchedBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedBookGridView.Location = new System.Drawing.Point(45, 226);
            this.searchedBookGridView.Name = "searchedBookGridView";
            this.searchedBookGridView.RowHeadersWidth = 51;
            this.searchedBookGridView.RowTemplate.Height = 24;
            this.searchedBookGridView.Size = new System.Drawing.Size(833, 282);
            this.searchedBookGridView.TabIndex = 15;
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Location = new System.Drawing.Point(181, 86);
            this.bookNameTextbox.Multiline = true;
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(275, 39);
            this.bookNameTextbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by Name";
            // 
            // showAllBooksToolStripMenuItem
            // 
            this.showAllBooksToolStripMenuItem.Name = "showAllBooksToolStripMenuItem";
            this.showAllBooksToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.showAllBooksToolStripMenuItem.Text = "Show All Books";
            this.showAllBooksToolStripMenuItem.Click += new System.EventHandler(this.showAllBooksToolStripMenuItem_Click);
            // 
            // LibrarianLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 540);
            this.Controls.Add(this.searchGenreDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.searchedBookGridView);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibrarianLogInForm";
            this.Text = "Librarian Form";
            this.Load += new System.EventHandler(this.LibrarianLogInForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchedBookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ComboBox searchGenreDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.DataGridView searchedBookGridView;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem showAllBooksToolStripMenuItem;
    }
}