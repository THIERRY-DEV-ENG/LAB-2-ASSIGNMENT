using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private int RatePerHour(int hour)
        {
            if (hour < 7) return 500;
            if (hour < 14) return 1000;
            if (hour < 19) return 1500;
            if (hour < 21) return 1000;
            return 500;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start = (int)numStart.Value;
            int end = (int)numEnd.Value;

            txtDetails.Clear();
            lblTotal.Text = "";

            if (start >= end)
            {
                lblError.Text = "Start hour must be smaller than end hour.";
                return;
            }

            lblError.Text = "";
            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                int rate = RatePerHour(hour);
                total += rate;
                txtDetails.AppendText("Hour " + hour + ": " + rate + " RWF" + Environment.NewLine);
            }

            lblTotal.Text = "Total amount to pay: " + total.ToString("N0") + " RWF";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numStart.Value = 8;
            numEnd.Value = 17;
            txtDetails.Clear();
            lblTotal.Text = "";
            lblError.Text = "";
        }
    }
}
