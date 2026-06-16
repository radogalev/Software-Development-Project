using System.ComponentModel;
namespace SchoolLab.WinFormsUI.Controls
{
    partial class LoanItem
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Loan";
            // 
            // LoanItem
            // 
            BackColor = Color.PaleTurquoise;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblName);
            Name = "LoanItem";
            Size = new Size(325, 100);
            Load += LoanItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
