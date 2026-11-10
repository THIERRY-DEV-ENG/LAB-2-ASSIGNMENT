namespace Lab2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMushroom = new System.Windows.Forms.Button();
            this.btnBicycle = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 64);
            this.pnlHeader.TabIndex = 0;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LAB 2";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseMnemonic = false;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(20, 80);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(360, 28);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.UseMnemonic = false;
            this.btnMushroom.BackColor = System.Drawing.Color.White;
            this.btnMushroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMushroom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMushroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMushroom.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMushroom.ForeColor = System.Drawing.Color.Black;
            this.btnMushroom.Location = new System.Drawing.Point(80, 124);
            this.btnMushroom.Name = "btnMushroom";
            this.btnMushroom.Size = new System.Drawing.Size(240, 48);
            this.btnMushroom.TabIndex = 2;
            this.btnMushroom.Text = "Mushroom Identifier";
            this.btnMushroom.UseVisualStyleBackColor = false;
            this.btnMushroom.Click += new System.EventHandler(this.btnMushroom_Click);
            this.btnBicycle.BackColor = System.Drawing.Color.White;
            this.btnBicycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBicycle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBicycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBicycle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBicycle.ForeColor = System.Drawing.Color.Black;
            this.btnBicycle.Location = new System.Drawing.Point(80, 184);
            this.btnBicycle.Name = "btnBicycle";
            this.btnBicycle.Size = new System.Drawing.Size(240, 48);
            this.btnBicycle.TabIndex = 3;
            this.btnBicycle.Text = "Bicycle Rental";
            this.btnBicycle.UseVisualStyleBackColor = false;
            this.btnBicycle.Click += new System.EventHandler(this.btnBicycle_Click);
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(80, 244);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 48);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnMushroom);
            this.Controls.Add(this.btnBicycle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB 2";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMushroom;
        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btnLogout;
    }
}
