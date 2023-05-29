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
    }
}
