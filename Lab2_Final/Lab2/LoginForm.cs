using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                lblError.Text = "Please enter username and password.";
            }
            else if (username == "thierry" && password == "thierry")
            {
                Hide();
                MainForm main = new MainForm(username);
                main.FormClosed += (s, args) => Close();
                main.Show();
            }
            else
            {
                lblError.Text = "Wrong username or password.";
                txtPassword.Clear();
            }
        }
    }
}
