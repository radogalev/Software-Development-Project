using System.ComponentModel;
namespace SchoolLab.WinFormsUI.Controls
{
    partial class ReportItem
    {
        private IContainer components = null;
        private Label lblName;

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
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(317, 80);
            lblName.TabIndex = 0;
            lblName.Text = "Report";
            // 
            // ReportItem
            // 
            BackColor = Color.PaleTurquoise;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblName);
            Name = "ReportItem";
            Size = new Size(325, 100);
            ResumeLayout(false);
        }

        #endregion
    }
}
