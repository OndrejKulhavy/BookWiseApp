namespace BookWiseApp.views
{
    partial class MainMenu
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabLoans = new System.Windows.Forms.TabPage();
            this.dataGridLoans = new System.Windows.Forms.DataGridView();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.tabAuthors = new System.Windows.Forms.TabPage();
            this.dataGridAuthors = new System.Windows.Forms.DataGridView();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.dataGridMembers = new System.Windows.Forms.DataGridView();
            this.tabScans = new System.Windows.Forms.TabPage();
            this.dataGridScans = new System.Windows.Forms.DataGridView();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.tabLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoans)).BeginInit();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.tabAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).BeginInit();
            this.tabMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            this.tabScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabLoans);
            this.tabs.Controls.Add(this.tabBooks);
            this.tabs.Controls.Add(this.tabAuthors);
            this.tabs.Controls.Add(this.tabMembers);
            this.tabs.Controls.Add(this.tabScans);
            this.tabs.Location = new System.Drawing.Point(10, 23);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(824, 404);
            this.tabs.TabIndex = 0;
            // 
            // tabLoans
            // 
            this.tabLoans.Controls.Add(this.dataGridLoans);
            this.tabLoans.Location = new System.Drawing.Point(4, 24);
            this.tabLoans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLoans.Size = new System.Drawing.Size(816, 376);
            this.tabLoans.TabIndex = 0;
            this.tabLoans.Text = "Loans";
            this.tabLoans.UseVisualStyleBackColor = true;
            // 
            // dataGridLoans
            // 
            this.dataGridLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLoans.Location = new System.Drawing.Point(6, 4);
            this.dataGridLoans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridLoans.Name = "dataGridLoans";
            this.dataGridLoans.ReadOnly = true;
            this.dataGridLoans.RowHeadersWidth = 51;
            this.dataGridLoans.RowTemplate.Height = 29;
            this.dataGridLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLoans.Size = new System.Drawing.Size(804, 368);
            this.dataGridLoans.TabIndex = 0;
            this.dataGridLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLoans_CellClick);
            this.dataGridLoans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLoans_CellContentClick);
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.dataGridBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 24);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBooks.Size = new System.Drawing.Size(816, 376);
            this.tabBooks.TabIndex = 1;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(6, 5);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.RowTemplate.Height = 25;
            this.dataGridBooks.Size = new System.Drawing.Size(804, 366);
            this.dataGridBooks.TabIndex = 0;
            this.dataGridBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooks_CellClick);
            // 
            // tabAuthors
            // 
            this.tabAuthors.Controls.Add(this.dataGridAuthors);
            this.tabAuthors.Location = new System.Drawing.Point(4, 24);
            this.tabAuthors.Name = "tabAuthors";
            this.tabAuthors.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthors.Size = new System.Drawing.Size(816, 376);
            this.tabAuthors.TabIndex = 2;
            this.tabAuthors.Text = "Authors";
            this.tabAuthors.UseVisualStyleBackColor = true;
            // 
            // dataGridAuthors
            // 
            this.dataGridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthors.Location = new System.Drawing.Point(6, 6);
            this.dataGridAuthors.Name = "dataGridAuthors";
            this.dataGridAuthors.RowTemplate.Height = 25;
            this.dataGridAuthors.Size = new System.Drawing.Size(804, 364);
            this.dataGridAuthors.TabIndex = 0;
            this.dataGridAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAuthors_CellClick);
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.dataGridMembers);
            this.tabMembers.Location = new System.Drawing.Point(4, 24);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(816, 376);
            this.tabMembers.TabIndex = 3;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMembers.Location = new System.Drawing.Point(6, 6);
            this.dataGridMembers.Name = "dataGridMembers";
            this.dataGridMembers.RowTemplate.Height = 25;
            this.dataGridMembers.Size = new System.Drawing.Size(804, 364);
            this.dataGridMembers.TabIndex = 0;
            this.dataGridMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMembers_CellClick);
            // 
            // tabScans
            // 
            this.tabScans.Controls.Add(this.dataGridScans);
            this.tabScans.Location = new System.Drawing.Point(4, 24);
            this.tabScans.Name = "tabScans";
            this.tabScans.Padding = new System.Windows.Forms.Padding(3);
            this.tabScans.Size = new System.Drawing.Size(816, 376);
            this.tabScans.TabIndex = 4;
            this.tabScans.Text = "Scans";
            this.tabScans.UseVisualStyleBackColor = true;
            // 
            // dataGridScans
            // 
            this.dataGridScans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridScans.Location = new System.Drawing.Point(6, 6);
            this.dataGridScans.Name = "dataGridScans";
            this.dataGridScans.RowTemplate.Height = 25;
            this.dataGridScans.Size = new System.Drawing.Size(804, 364);
            this.dataGridScans.TabIndex = 0;
            this.dataGridScans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridScans_CellClick);
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(BookWiseApp.Database.Models.Loan);
            // 
            // loanBindingSource1
            // 
            this.loanBindingSource1.DataSource = typeof(BookWiseApp.Database.Models.Loan);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.loanToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 436);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.tabs.ResumeLayout(false);
            this.tabLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoans)).EndInit();
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.tabAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthors)).EndInit();
            this.tabMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            this.tabScans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridScans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabs;
        private TabPage tabLoans;
        private TabPage tabBooks;
        private DataGridView dataGridLoans;
        private BindingSource loanBindingSource1;
        private BindingSource loanBindingSource;
        private DataGridView dataGridBooks;
        private TabPage tabAuthors;
        private TabPage tabMembers;
        private TabPage tabScans;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem authorToolStripMenuItem;
        private DataGridView dataGridAuthors;
        private DataGridView dataGridMembers;
        private DataGridView dataGridScans;
    }
}