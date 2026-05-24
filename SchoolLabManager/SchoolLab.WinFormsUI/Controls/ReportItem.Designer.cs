namespace SchoolLab.WinFormsUI.Controls
{
    partial class ReportItem
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
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(3, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Report";
            // 
            // ReportItem
            // 
            BackColor = Color.PaleTurquoise;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblName);
            Name = "ReportItem";
            Size = new Size(250, 40);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
