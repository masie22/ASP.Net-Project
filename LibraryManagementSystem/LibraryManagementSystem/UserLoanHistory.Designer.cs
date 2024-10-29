namespace LibraryManagementSystem
{
    partial class UserLoanHistory
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
            this.userIdTextbox = new System.Windows.Forms.TextBox();
            this.userHistorydataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userHistorydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdTextbox
            // 
            this.userIdTextbox.Location = new System.Drawing.Point(166, 49);
            this.userIdTextbox.Name = "userIdTextbox";
            this.userIdTextbox.Size = new System.Drawing.Size(100, 22);
            this.userIdTextbox.TabIndex = 0;
            this.userIdTextbox.Leave += new System.EventHandler(this.userIdTextbox_Leave);
            // 
            // userHistorydataGridView
            // 
            this.userHistorydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userHistorydataGridView.Location = new System.Drawing.Point(39, 103);
            this.userHistorydataGridView.Name = "userHistorydataGridView";
            this.userHistorydataGridView.RowHeadersWidth = 51;
            this.userHistorydataGridView.RowTemplate.Height = 24;
            this.userHistorydataGridView.Size = new System.Drawing.Size(633, 270);
            this.userHistorydataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter UserID";
            // 
            // UserLoanHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userHistorydataGridView);
            this.Controls.Add(this.userIdTextbox);
            this.Name = "UserLoanHistory";
            this.Text = "UserLoanHistory";
            ((System.ComponentModel.ISupportInitialize)(this.userHistorydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdTextbox;
        private System.Windows.Forms.DataGridView userHistorydataGridView;
        private System.Windows.Forms.Label label1;
    }
}