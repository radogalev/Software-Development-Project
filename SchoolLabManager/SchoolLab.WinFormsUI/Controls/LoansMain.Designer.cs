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
            flowLayoutPanelLoans = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelLoans
            // 
            flowLayoutPanelLoans.AutoScroll = true;
            flowLayoutPanelLoans.Dock = DockStyle.Fill;
            flowLayoutPanelLoans.Location = new Point(0, 0);
            flowLayoutPanelLoans.Name = "flowLayoutPanelLoans";
            flowLayoutPanelLoans.Size = new Size(700, 400);
            flowLayoutPanelLoans.TabIndex = 0;
            // 
            // LoansMain
            // 
            Controls.Add(flowLayoutPanelLoans);
            Name = "LoansMain";
            Size = new Size(700, 400);
            ResumeLayout(false);
        }

        #endregion
    }
}
