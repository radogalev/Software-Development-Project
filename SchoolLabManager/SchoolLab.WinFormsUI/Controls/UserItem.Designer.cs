namespace SchoolLab.WinFormsUI.Controls
{
    partial class UserItem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 31);
            lblName.TabIndex = 0;
            lblName.Text = "User";
            // 
            // UserItem
            // 
            BackColor = Color.PaleTurquoise;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblName);
            Margin = new Padding(4);
            Name = "UserItem";
            Size = new Size(215, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
