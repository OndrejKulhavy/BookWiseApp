namespace BookWiseApp.views
{
    partial class EmployeeView
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
            this.input_employee_first_name = new System.Windows.Forms.TextBox();
            this.input_employee_last_name = new System.Windows.Forms.TextBox();
            this.input_employee_password = new System.Windows.Forms.TextBox();
            this.input_employee_email = new System.Windows.Forms.TextBox();
            this.input_employee_phone_number = new System.Windows.Forms.TextBox();
            this.input_employee_save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_employee_first_name
            // 
            this.input_employee_first_name.Location = new System.Drawing.Point(12, 12);
            this.input_employee_first_name.Name = "input_employee_first_name";
            this.input_employee_first_name.PlaceholderText = "First Name";
            this.input_employee_first_name.Size = new System.Drawing.Size(394, 27);
            this.input_employee_first_name.TabIndex = 0;
            // 
            // input_employee_last_name
            // 
            this.input_employee_last_name.Location = new System.Drawing.Point(12, 45);
            this.input_employee_last_name.Name = "input_employee_last_name";
            this.input_employee_last_name.PlaceholderText = "Last Name";
            this.input_employee_last_name.Size = new System.Drawing.Size(394, 27);
            this.input_employee_last_name.TabIndex = 1;
            // 
            // input_employee_password
            // 
            this.input_employee_password.Location = new System.Drawing.Point(12, 78);
            this.input_employee_password.Name = "input_employee_password";
            this.input_employee_password.PlaceholderText = "Password";
            this.input_employee_password.Size = new System.Drawing.Size(394, 27);
            this.input_employee_password.TabIndex = 2;
            // 
            // input_employee_email
            // 
            this.input_employee_email.Location = new System.Drawing.Point(12, 111);
            this.input_employee_email.Name = "input_employee_email";
            this.input_employee_email.PlaceholderText = "Email";
            this.input_employee_email.Size = new System.Drawing.Size(394, 27);
            this.input_employee_email.TabIndex = 3;
            // 
            // input_employee_phone_number
            // 
            this.input_employee_phone_number.Location = new System.Drawing.Point(12, 144);
            this.input_employee_phone_number.Name = "input_employee_phone_number";
            this.input_employee_phone_number.PlaceholderText = "Phone Number";
            this.input_employee_phone_number.Size = new System.Drawing.Size(394, 27);
            this.input_employee_phone_number.TabIndex = 4;
            // 
            // input_employee_save_btn
            // 
            this.input_employee_save_btn.Location = new System.Drawing.Point(312, 194);
            this.input_employee_save_btn.Name = "input_employee_save_btn";
            this.input_employee_save_btn.Size = new System.Drawing.Size(94, 29);
            this.input_employee_save_btn.TabIndex = 6;
            this.input_employee_save_btn.Text = "Save";
            this.input_employee_save_btn.UseVisualStyleBackColor = true;
            this.input_employee_save_btn.Click += new System.EventHandler(this.input_employee_save_btn_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 235);
            this.Controls.Add(this.input_employee_save_btn);
            this.Controls.Add(this.input_employee_phone_number);
            this.Controls.Add(this.input_employee_email);
            this.Controls.Add(this.input_employee_password);
            this.Controls.Add(this.input_employee_last_name);
            this.Controls.Add(this.input_employee_first_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_employee_first_name;
        private TextBox input_employee_last_name;
        private TextBox input_employee_password;
        private TextBox input_employee_email;
        private TextBox input_employee_phone_number;
        private Button input_employee_save_btn;
    }
}