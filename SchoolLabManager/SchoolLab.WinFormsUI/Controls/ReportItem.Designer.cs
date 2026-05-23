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
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Report";
            // 
            // ReportItem
            // 
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblName);
            this.Name = "ReportItem";
            this.Size = new System.Drawing.Size(250, 40);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
