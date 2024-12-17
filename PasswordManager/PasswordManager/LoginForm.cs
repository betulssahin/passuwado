using System;
using System.Windows.Forms;
using System.IO;

namespace PasswordManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usr = usrnameBox.Text;
            string pass = passwordBox.Text;

            if (usr == "admin" && pass == "123")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password wrong!");
            }
        }

        
    }


}
