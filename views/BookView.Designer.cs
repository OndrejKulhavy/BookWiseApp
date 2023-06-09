namespace BookWiseApp.views
{
    partial class BookView
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.input_book_title = new System.Windows.Forms.TextBox();
            this.combo_book_author = new System.Windows.Forms.ComboBox();
            this.combo_book_category = new System.Windows.Forms.ComboBox();
            this.input_book_isbn = new System.Windows.Forms.TextBox();
            this.datePicker_book_published = new System.Windows.Forms.DateTimePicker();
            this.button_book_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // input_book_title
            // 
            this.input_book_title.Location = new System.Drawing.Point(106, 9);
            this.input_book_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_book_title.Name = "input_book_title";
            this.input_book_title.Size = new System.Drawing.Size(287, 23);
            this.input_book_title.TabIndex = 1;
            // 
            // combo_book_author
            // 
            this.combo_book_author.FormattingEnabled = true;
            this.combo_book_author.Location = new System.Drawing.Point(106, 34);
            this.combo_book_author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_book_author.Name = "combo_book_author";
            this.combo_book_author.Size = new System.Drawing.Size(287, 23);
            this.combo_book_author.TabIndex = 2;
            // 
            // combo_book_category
            // 
            this.combo_book_category.FormattingEnabled = true;
            this.combo_book_category.Location = new System.Drawing.Point(106, 59);
            this.combo_book_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_book_category.Name = "combo_book_category";
            this.combo_book_category.Size = new System.Drawing.Size(287, 23);
            this.combo_book_category.TabIndex = 3;
            // 
            // input_book_isbn
            // 
            this.input_book_isbn.Location = new System.Drawing.Point(106, 85);
            this.input_book_isbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_book_isbn.Name = "input_book_isbn";
            this.input_book_isbn.Size = new System.Drawing.Size(287, 23);
            this.input_book_isbn.TabIndex = 4;
            // 
            // datePicker_book_published
            // 
            this.datePicker_book_published.Location = new System.Drawing.Point(106, 110);
            this.datePicker_book_published.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker_book_published.Name = "datePicker_book_published";
            this.datePicker_book_published.Size = new System.Drawing.Size(287, 23);
            this.datePicker_book_published.TabIndex = 5;
            this.datePicker_book_published.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_book_save
            // 
            this.button_book_save.Location = new System.Drawing.Point(310, 166);
            this.button_book_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_book_save.Name = "button_book_save";
            this.button_book_save.Size = new System.Drawing.Size(82, 22);
            this.button_book_save.TabIndex = 6;
            this.button_book_save.Text = "Save";
            this.button_book_save.UseVisualStyleBackColor = true;
            this.button_book_save.Click += new System.EventHandler(this.button_book_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Published";
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 197);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_book_save);
            this.Controls.Add(this.datePicker_book_published);
            this.Controls.Add(this.input_book_isbn);
            this.Controls.Add(this.combo_book_category);
            this.Controls.Add(this.combo_book_author);
            this.Controls.Add(this.input_book_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookView";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox input_book_title;
        private ComboBox combo_book_author;
        private ComboBox combo_book_category;
        private TextBox input_book_isbn;
        private DateTimePicker datePicker_book_published;
        private Button button_book_save;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}