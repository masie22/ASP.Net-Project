namespace LibraryManagementSystem
{
    partial class AdminLogIn
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
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateDeleteBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUpdateDeleteUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminDataGridview = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(713, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBooksToolStripMenuItem,
            this.addUpdateDeleteBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // showBooksToolStripMenuItem
            // 
            this.showBooksToolStripMenuItem.Name = "showBooksToolStripMenuItem";
            this.showBooksToolStripMenuItem.Size = new System.Drawing.Size(345, 34);
            this.showBooksToolStripMenuItem.Text = "Show Books";
            this.showBooksToolStripMenuItem.Click += new System.EventHandler(this.showBooksToolStripMenuItem_Click);
            // 
            // addUpdateDeleteBooksToolStripMenuItem
            // 
            this.addUpdateDeleteBooksToolStripMenuItem.Name = "addUpdateDeleteBooksToolStripMenuItem";
            this.addUpdateDeleteBooksToolStripMenuItem.Size = new System.Drawing.Size(345, 34);
            this.addUpdateDeleteBooksToolStripMenuItem.Text = "Add/Update/Delete Books";
            this.addUpdateDeleteBooksToolStripMenuItem.Click += new System.EventHandler(this.addUpdateDeleteBooksToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUsersToolStripMenuItem,
            this.addUpdateDeleteUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // showUsersToolStripMenuItem
            // 
            this.showUsersToolStripMenuItem.Name = "showUsersToolStripMenuItem";
            this.showUsersToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.showUsersToolStripMenuItem.Text = "Show Users";
            this.showUsersToolStripMenuItem.Click += new System.EventHandler(this.showUsersToolStripMenuItem_Click);
            // 
            // addUpdateDeleteUsersToolStripMenuItem
            // 
            this.addUpdateDeleteUsersToolStripMenuItem.Name = "addUpdateDeleteUsersToolStripMenuItem";
            this.addUpdateDeleteUsersToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.addUpdateDeleteUsersToolStripMenuItem.Text = "Add/Update/Delete Users";
            this.addUpdateDeleteUsersToolStripMenuItem.Click += new System.EventHandler(this.addUpdateDeleteUsersToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(95, 28);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // adminDataGridview
            // 
            this.adminDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridview.Location = new System.Drawing.Point(14, 54);
            this.adminDataGridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminDataGridview.Name = "adminDataGridview";
            this.adminDataGridview.RowHeadersWidth = 51;
            this.adminDataGridview.RowTemplate.Height = 24;
            this.adminDataGridview.Size = new System.Drawing.Size(669, 494);
            this.adminDataGridview.TabIndex = 1;
            // 
            // AdminLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(713, 562);
            this.Controls.Add(this.adminDataGridview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminLogIn";
            this.Text = "AdminAfterLogInPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateDeleteBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUpdateDeleteUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView adminDataGridview;
    }
}