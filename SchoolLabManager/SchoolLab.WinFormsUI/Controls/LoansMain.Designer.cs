namespace SchoolLab.WinFormsUI.Controls
{
    partial class LoansMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLoans;

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
            this.flowLayoutPanelLoans = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelLoans
            // 
            this.flowLayoutPanelLoans.AutoScroll = true;
            this.flowLayoutPanelLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLoans.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLoans.Name = "flowLayoutPanelLoans";
            this.flowLayoutPanelLoans.Size = new System.Drawing.Size(600, 400);
            this.flowLayoutPanelLoans.TabIndex = 0;
            // 
            // LoansMain
            // 
            this.Controls.Add(this.flowLayoutPanelLoans);
            this.Name = "LoansMain";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
