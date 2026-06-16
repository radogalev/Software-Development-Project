using System.ComponentModel;
namespace SchoolLab.WinFormsUI.Controls
{
    partial class LoansMain
    {
        private IContainer components = null;
        private Panel filterPanel;
        private Label lblStatusFilter;
        private ComboBox cmbStatusFilter;
        private FlowLayoutPanel flowLayoutPanelLoans;

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
            filterPanel = new Panel();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            flowLayoutPanelLoans = new FlowLayoutPanel();
            filterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(cmbStatusFilter);
            filterPanel.Controls.Add(lblStatusFilter);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 0);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(700, 48);
            filterPanel.TabIndex = 0;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new Font("Segoe UI", 11F);
            lblStatusFilter.Location = new Point(8, 11);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(105, 25);
            lblStatusFilter.TabIndex = 0;
            lblStatusFilter.Text = "Loan status:";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new Font("Segoe UI", 10F);
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(119, 10);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(175, 31);
            cmbStatusFilter.TabIndex = 1;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // flowLayoutPanelLoans
            // 
            flowLayoutPanelLoans.AutoScroll = true;
            flowLayoutPanelLoans.Dock = DockStyle.Fill;
            flowLayoutPanelLoans.Location = new Point(0, 48);
            flowLayoutPanelLoans.Name = "flowLayoutPanelLoans";
            flowLayoutPanelLoans.Size = new Size(700, 352);
            flowLayoutPanelLoans.TabIndex = 1;
            // 
            // LoansMain
            // 
            Controls.Add(flowLayoutPanelLoans);
            Controls.Add(filterPanel);
            Name = "LoansMain";
            Size = new Size(700, 400);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
