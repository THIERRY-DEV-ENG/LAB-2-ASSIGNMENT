using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm() : this("User") { }

        public MainForm(string username)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + username + "!";
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            new MushroomForm().ShowDialog(this);
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            new BicycleForm().ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
