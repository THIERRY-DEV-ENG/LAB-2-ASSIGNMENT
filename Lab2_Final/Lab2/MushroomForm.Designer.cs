namespace Lab2
{
    partial class MushroomForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblList = new System.Windows.Forms.Label();
            this.lblRing = new System.Windows.Forms.Label();
            this.cboRing = new System.Windows.Forms.ComboBox();
            this.lblForest = new System.Windows.Forms.Label();
            this.cboForest = new System.Windows.Forms.ComboBox();
            this.lblGills = new System.Windows.Forms.Label();
            this.cboGills = new System.Windows.Forms.ComboBox();
            this.lblCup = new System.Windows.Forms.Label();
            this.cboCup = new System.Windows.Forms.ComboBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 64);
            this.pnlHeader.TabIndex = 0;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mushroom Identifier";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseMnemonic = false;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.lblList.ForeColor = System.Drawing.Color.Black;
            this.lblList.Location = new System.Drawing.Point(30, 76);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(420, 44);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "Think of one: Agaric Jaunissant, Amanite tue-mouche, Cepe de bordeau, Coprin chevelu, Girolle, Pied bleu";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblList.UseMnemonic = false;
            this.lblRing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRing.ForeColor = System.Drawing.Color.Black;
            this.lblRing.Location = new System.Drawing.Point(30, 132);
            this.lblRing.Name = "lblRing";
            this.lblRing.Size = new System.Drawing.Size(280, 28);
            this.lblRing.TabIndex = 2;
            this.lblRing.Text = "Does it have a ring?";
            this.lblRing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRing.UseMnemonic = false;
            this.cboRing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRing.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.cboRing.FormattingEnabled = true;
            this.cboRing.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboRing.Location = new System.Drawing.Point(330, 132);
            this.cboRing.Name = "cboRing";
            this.cboRing.Size = new System.Drawing.Size(120, 28);
            this.cboRing.TabIndex = 3;
            this.lblForest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblForest.ForeColor = System.Drawing.Color.Black;
            this.lblForest.Location = new System.Drawing.Point(30, 174);
            this.lblForest.Name = "lblForest";
            this.lblForest.Size = new System.Drawing.Size(280, 28);
            this.lblForest.TabIndex = 4;
            this.lblForest.Text = "Does it grow in a forest?";
            this.lblForest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblForest.UseMnemonic = false;
            this.cboForest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForest.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.cboForest.FormattingEnabled = true;
            this.cboForest.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboForest.Location = new System.Drawing.Point(330, 174);
            this.cboForest.Name = "cboForest";
            this.cboForest.Size = new System.Drawing.Size(120, 28);
            this.cboForest.TabIndex = 5;
            this.lblGills.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGills.ForeColor = System.Drawing.Color.Black;
            this.lblGills.Location = new System.Drawing.Point(30, 216);
            this.lblGills.Name = "lblGills";
            this.lblGills.Size = new System.Drawing.Size(280, 28);
            this.lblGills.TabIndex = 6;
            this.lblGills.Text = "Does it have gills?";
            this.lblGills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGills.UseMnemonic = false;
            this.cboGills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGills.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.cboGills.FormattingEnabled = true;
            this.cboGills.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboGills.Location = new System.Drawing.Point(330, 216);
            this.cboGills.Name = "cboGills";
            this.cboGills.Size = new System.Drawing.Size(120, 28);
            this.cboGills.TabIndex = 7;
            this.lblCup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCup.ForeColor = System.Drawing.Color.Black;
            this.lblCup.Location = new System.Drawing.Point(30, 258);
            this.lblCup.Name = "lblCup";
            this.lblCup.Size = new System.Drawing.Size(280, 28);
            this.lblCup.TabIndex = 8;
            this.lblCup.Text = "Does it have a convex cup?";
            this.lblCup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCup.UseMnemonic = false;
            this.cboCup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCup.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.cboCup.FormattingEnabled = true;
            this.cboCup.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboCup.Location = new System.Drawing.Point(330, 258);
            this.cboCup.Name = "cboCup";
            this.cboCup.Size = new System.Drawing.Size(120, 28);
            this.cboCup.TabIndex = 9;
            this.btnIdentify.BackColor = System.Drawing.Color.White;
            this.btnIdentify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentify.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIdentify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentify.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnIdentify.ForeColor = System.Drawing.Color.Black;
            this.btnIdentify.Location = new System.Drawing.Point(90, 308);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(140, 44);
            this.btnIdentify.TabIndex = 10;
            this.btnIdentify.Text = "Identify";
            this.btnIdentify.UseVisualStyleBackColor = false;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(250, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 44);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(30, 366);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(420, 56);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.UseMnemonic = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 470);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblRing);
            this.Controls.Add(this.cboRing);
            this.Controls.Add(this.lblForest);
            this.Controls.Add(this.cboForest);
            this.Controls.Add(this.lblGills);
            this.Controls.Add(this.cboGills);
            this.Controls.Add(this.lblCup);
            this.Controls.Add(this.cboCup);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MushroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mushroom Identifier";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblRing;
        private System.Windows.Forms.ComboBox cboRing;
        private System.Windows.Forms.Label lblForest;
        private System.Windows.Forms.ComboBox cboForest;
        private System.Windows.Forms.Label lblGills;
        private System.Windows.Forms.ComboBox cboGills;
        private System.Windows.Forms.Label lblCup;
        private System.Windows.Forms.ComboBox cboCup;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblResult;
    }
}
