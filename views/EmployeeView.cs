using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookWiseApp.Database.Models;
using BookWiseApp.Database.DAO;

namespace BookWiseApp.views
{
    public partial class EmployeeView : Form
    {
        private Employee? employee;

        public EmployeeView()
        {
            InitializeComponent();
        }

        public EmployeeView(Employee employee)
        {
            InitializeComponent();
            input_employee_first_name.Text = employee.FirstName;
            input_employee_last_name.Text = employee.LastName;
            input_employee_password.Text = employee.PasswordHash;
            input_employee_email.Text = employee.Email;
            input_employee_phone_number.Text = employee.PhoneNumber;
        }

        private void input_employee_save_btn_Click(object sender, EventArgs e)
        {
            string firstName = input_employee_first_name.Text;
            string lastName = input_employee_last_name.Text;
            string password = input_employee_password.Text;
            string email = input_employee_email.Text;
            string phoneNumber = input_employee_phone_number.Text;

            if (employee == null)
            {
                employee = new Employee(firstName, lastName, password, email, phoneNumber);
            }
            else
            {
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.PasswordHash = password;
                employee.Email = email;
                employee.PhoneNumber = phoneNumber;
            }

            var employye = new EmployeeDAO();
            try
            {
                employye.Save(employee);
                MessageBox.Show("Employee saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message);
            }
            this.Close();
        }
    }
}
