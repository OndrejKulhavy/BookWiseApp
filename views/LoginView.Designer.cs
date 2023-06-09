namespace BookWiseApp
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_login_username = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.input_login_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_login_username
            // 
            this.input_login_username.Location = new System.Drawing.Point(10, 35);
            this.input_login_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_login_username.Name = "input_login_username";
            this.input_login_username.PlaceholderText = "Enter your username";
            this.input_login_username.Size = new System.Drawing.Size(266, 23);
            this.input_login_username.TabIndex = 0;
            // 
            // button_login
            // 
            this.button_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_login.AutoSize = true;
            this.button_login.Location = new System.Drawing.Point(178, 124);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(98, 25);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // input_login_password
            // 
            this.input_login_password.Location = new System.Drawing.Point(10, 71);
            this.input_login_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_login_password.Name = "input_login_password";
            this.input_login_password.PasswordChar = '*';
            this.input_login_password.PlaceholderText = "Enter your password";
            this.input_login_password.Size = new System.Drawing.Size(266, 23);
            this.input_login_password.TabIndex = 1;
            this.input_login_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_register_btn
            // 
            this.input_register_btn.Location = new System.Drawing.Point(10, 124);
            this.input_register_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_register_btn.Name = "input_register_btn";
            this.input_register_btn.Size = new System.Drawing.Size(132, 25);
            this.input_register_btn.TabIndex = 5;
            this.input_register_btn.Text = "Register Employee";
            this.input_register_btn.UseVisualStyleBackColor = true;
            this.input_register_btn.Click += new System.EventHandler(this.input_register_btn_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 154);
            this.Controls.Add(this.input_register_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_login_password);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.input_login_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginView";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginView_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_login_username;
        private Button button_login;
        private TextBox input_login_password;
        private Label label1;
        private Button input_register_btn;
    }
}