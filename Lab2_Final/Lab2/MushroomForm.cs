using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }
        private bool IsYes(ComboBox box)
        {
            return box.SelectedItem.ToString() == "Yes";
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            if (cboRing.SelectedIndex < 0 || cboForest.SelectedIndex < 0 ||
                cboGills.SelectedIndex < 0 || cboCup.SelectedIndex < 0)
            {
                lblResult.Text = "Please answer all the questions.";
                return;
            }

            string name;

            if (IsYes(cboRing))
            {
                if (IsYes(cboForest))
                    name = "Amanite tue-mouche";
                else
                    name = IsYes(cboCup) ? "Agaric Jaunissant" : "Coprin chevelu";
            }
            else
            {
                if (!IsYes(cboGills))
                    name = "Cepe de bordeau";
                else
                    name = IsYes(cboCup) ? "Pied bleu" : "Girolle";
            }

            lblResult.Text = "Your mushroom is: " + name;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboRing.SelectedIndex = -1;
            cboForest.SelectedIndex = -1;
            cboGills.SelectedIndex = -1;
            cboCup.SelectedIndex = -1;
            lblResult.Text = "";
        }
    }
}
