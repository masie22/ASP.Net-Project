namespace LibraryManagementSystem
{
    partial class IssueReturnForm
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
            this.bookNameSearchBtn = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userNameSearchBtn = new System.Windows.Forms.Button();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.issueReturnGridView = new System.Windows.Forms.DataGridView();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.issueBookButton = new System.Windows.Forms.Button();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.issueReturnGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookNameSearchBtn
            // 
            this.bookNameSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameSearchBtn.Location = new System.Drawing.Point(732, 93);
            this.bookNameSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameSearchBtn.Name = "bookNameSearchBtn";
            this.bookNameSearchBtn.Size = new System.Drawing.Size(32, 25);
            this.bookNameSearchBtn.TabIndex = 52;
            this.bookNameSearchBtn.Text = "S";
            this.bookNameSearchBtn.UseVisualStyleBackColor = true;
            this.bookNameSearchBtn.Click += new System.EventHandler(this.bookNameSearchBtn_Click_1);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(132, 62);
            this.userIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(227, 22);
            this.userIDTextBox.TabIndex = 51;
            // 
            // userNameSearchBtn
            // 
            this.userNameSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameSearchBtn.Location = new System.Drawing.Point(367, 87);
            this.userNameSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.userNameSearchBtn.Name = "userNameSearchBtn";
            this.userNameSearchBtn.Size = new System.Drawing.Size(32, 28);
            this.userNameSearchBtn.TabIndex = 50;
            this.userNameSearchBtn.Text = "S";
            this.userNameSearchBtn.UseVisualStyleBackColor = true;
            this.userNameSearchBtn.Click += new System.EventHandler(this.userNameSearchBtn_Click_1);
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.Location = new System.Drawing.Point(156, 148);
            this.dueDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dueDateTimePicker.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Due Date:";
            // 
            // errorLabel
            // 
            this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(156, 24);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(607, 28);
            this.errorLabel.TabIndex = 46;
            // 
            // issueReturnGridView
            // 
            this.issueReturnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueReturnGridView.Location = new System.Drawing.Point(48, 220);
            this.issueReturnGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issueReturnGridView.Name = "issueReturnGridView";
            this.issueReturnGridView.RowHeadersWidth = 51;
            this.issueReturnGridView.RowTemplate.Height = 24;
            this.issueReturnGridView.Size = new System.Drawing.Size(693, 207);
            this.issueReturnGridView.TabIndex = 45;
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(557, 148);
            this.returnBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(80, 54);
            this.returnBookButton.TabIndex = 44;
            this.returnBookButton.Text = "Return Book";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click_1);
            // 
            // issueBookButton
            // 
            this.issueBookButton.Location = new System.Drawing.Point(463, 148);
            this.issueBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issueBookButton.Name = "issueBookButton";
            this.issueBookButton.Size = new System.Drawing.Size(75, 54);
            this.issueBookButton.TabIndex = 43;
            this.issueBookButton.Text = "Issue Book";
            this.issueBookButton.UseVisualStyleBackColor = true;
            this.issueBookButton.Click += new System.EventHandler(this.issueBookButton_Click_1);
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(501, 63);
            this.bookIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(227, 22);
            this.bookIDTextBox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Book ID:";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(501, 93);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(227, 22);
            this.bookNameTextBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Book Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(132, 89);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(227, 22);
            this.userNameTextBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "User\'s Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "User ID:";
            // 
            // IssueReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookNameSearchBtn);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.userNameSearchBtn);
            this.Controls.Add(this.dueDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.issueReturnGridView);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.issueBookButton);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IssueReturnForm";
            this.Text = "IssueReturnBooks";
            ((System.ComponentModel.ISupportInitialize)(this.issueReturnGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookNameSearchBtn;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Button userNameSearchBtn;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView issueReturnGridView;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Button issueBookButton;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}