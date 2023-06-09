using BookWiseApp.Database.DAO;
using BookWiseApp.Database.Models;
using BookWiseApp.views;

namespace BookWiseApp
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //get data from textboxes
            string username = input_login_username.Text;
            string password = input_login_password.Text;

            bool isValid = new EmployeeDAO().ValidateLogin(username, password);
            if (isValid)
            {
                new MainMenu().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void input_register_btn_Click(object sender, EventArgs e)
        {
            new EmployeeView().Show();
        }

        private void LoginView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = input_login_username.Text;
                string password = input_login_password.Text;

                bool isValid = new EmployeeDAO().ValidateLogin(username, password);
                if (isValid)
                {
                    new MainMenu().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
    }
}
