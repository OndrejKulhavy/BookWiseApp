namespace BookWiseApp.views
{
    partial class LoanView
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
            this.combo_loan_book = new System.Windows.Forms.ComboBox();
            this.combo_loan_member = new System.Windows.Forms.ComboBox();
            this.date_loan_start = new System.Windows.Forms.DateTimePicker();
            this.date_loan_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_loan_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_loan_book
            // 
            this.combo_loan_book.FormattingEnabled = true;
            this.combo_loan_book.Location = new System.Drawing.Point(84, 8);
            this.combo_loan_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_loan_book.Name = "combo_loan_book";
            this.combo_loan_book.Size = new System.Drawing.Size(219, 23);
            this.combo_loan_book.TabIndex = 0;
            // 
            // combo_loan_member
            // 
            this.combo_loan_member.FormattingEnabled = true;
            this.combo_loan_member.Location = new System.Drawing.Point(84, 34);
            this.combo_loan_member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_loan_member.Name = "combo_loan_member";
            this.combo_loan_member.Size = new System.Drawing.Size(219, 23);
            this.combo_loan_member.TabIndex = 1;
            // 
            // date_loan_start
            // 
            this.date_loan_start.Location = new System.Drawing.Point(84, 59);
            this.date_loan_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_loan_start.Name = "date_loan_start";
            this.date_loan_start.Size = new System.Drawing.Size(219, 23);
            this.date_loan_start.TabIndex = 2;
            // 
            // date_loan_end
            // 
            this.date_loan_end.Location = new System.Drawing.Point(84, 84);
            this.date_loan_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_loan_end.Name = "date_loan_end";
            this.date_loan_end.Size = new System.Drawing.Size(219, 23);
            this.date_loan_end.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Member";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "End";
            // 
            // button_loan_save
            // 
            this.button_loan_save.Location = new System.Drawing.Point(230, 123);
            this.button_loan_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_loan_save.Name = "button_loan_save";
            this.button_loan_save.Size = new System.Drawing.Size(82, 22);
            this.button_loan_save.TabIndex = 8;
            this.button_loan_save.Text = "Save";
            this.button_loan_save.UseVisualStyleBackColor = true;
            this.button_loan_save.Click += new System.EventHandler(this.button_loan_save_Click);
            // 
            // LoanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 154);
            this.Controls.Add(this.button_loan_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_loan_end);
            this.Controls.Add(this.date_loan_start);
            this.Controls.Add(this.combo_loan_member);
            this.Controls.Add(this.combo_loan_book);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoanView";
            this.Text = "LoanView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox combo_loan_book;
        private ComboBox combo_loan_member;
        private DateTimePicker date_loan_start;
        private DateTimePicker date_loan_end;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_loan_save;
    }
}