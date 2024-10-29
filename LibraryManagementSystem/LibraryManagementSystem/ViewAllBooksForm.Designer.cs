namespace LibraryManagementSystem
{
    partial class ViewAllBooksForm
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
            this.allBooksGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allBooksGridView
            // 
            this.allBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBooksGridView.Location = new System.Drawing.Point(62, 67);
            this.allBooksGridView.Name = "allBooksGridView";
            this.allBooksGridView.RowHeadersWidth = 51;
            this.allBooksGridView.RowTemplate.Height = 24;
            this.allBooksGridView.Size = new System.Drawing.Size(665, 321);
            this.allBooksGridView.TabIndex = 0;
            // 
            // ViewAllBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allBooksGridView);
            this.Name = "ViewAllBooksForm";
            this.Text = "ViewAllBooks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllBooksForm_FormClosed);
            this.Load += new System.EventHandler(this.ViewAllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allBooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allBooksGridView;
    }
}