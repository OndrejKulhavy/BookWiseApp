namespace BookWiseApp.views
{
    partial class AuthorView
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
            this.input_author_first_name = new System.Windows.Forms.TextBox();
            this.input_author_last_name = new System.Windows.Forms.TextBox();
            this.input_author_biography = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_save_author = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_author_first_name
            // 
            this.input_author_first_name.Location = new System.Drawing.Point(87, 9);
            this.input_author_first_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_author_first_name.Name = "input_author_first_name";
            this.input_author_first_name.Size = new System.Drawing.Size(249, 23);
            this.input_author_first_name.TabIndex = 0;
            // 
            // input_author_last_name
            // 
            this.input_author_last_name.Location = new System.Drawing.Point(87, 34);
            this.input_author_last_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_author_last_name.Name = "input_author_last_name";
            this.input_author_last_name.Size = new System.Drawing.Size(249, 23);
            this.input_author_last_name.TabIndex = 1;
            // 
            // input_author_biography
            // 
            this.input_author_biography.Location = new System.Drawing.Point(87, 58);
            this.input_author_biography.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_author_biography.Multiline = true;
            this.input_author_biography.Name = "input_author_biography";
            this.input_author_biography.Size = new System.Drawing.Size(249, 97);
            this.input_author_biography.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biography";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_save_author
            // 
            this.button_save_author.Location = new System.Drawing.Point(253, 165);
            this.button_save_author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save_author.Name = "button_save_author";
            this.button_save_author.Size = new System.Drawing.Size(82, 22);
            this.button_save_author.TabIndex = 6;
            this.button_save_author.Text = "Save";
            this.button_save_author.UseVisualStyleBackColor = true;
            this.button_save_author.Click += new System.EventHandler(this.button_save_author_Click);
            // 
            // AuthorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 196);
            this.Controls.Add(this.button_save_author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_author_biography);
            this.Controls.Add(this.input_author_last_name);
            this.Controls.Add(this.input_author_first_name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthorView";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_author_first_name;
        private TextBox input_author_last_name;
        private TextBox input_author_biography;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_save_author;
    }
}