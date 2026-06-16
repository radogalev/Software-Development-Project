using System.ComponentModel;
using System.Windows.Forms;
namespace SchoolLab.WinFormsUI.Controls
{
    partial class ReportsMain
    {
        private IContainer components = null;
        private TabControl tabControlReports = null;
        private TabPage tabDamageReports = null;
        private TabPage tabStatistics = null;
        private FlowLayoutPanel flowLayoutPanelReports = null;
        private Panel statisticsFilterPanel = null;
        private Label lblReportType = null;
        private ComboBox cmbReportType = null;
        private Label lblReportFilter = null;
        private ComboBox cmbReportFilter = null;
        private Button btnRefreshReport = null;
        private DataGridView dgvStatistics = null;

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
            this.tabControlReports = new TabControl();
            this.tabDamageReports = new TabPage();
            this.flowLayoutPanelReports = new FlowLayoutPanel();
            this.tabStatistics = new TabPage();
            this.dgvStatistics = new DataGridView();
            this.statisticsFilterPanel = new Panel();
            this.btnRefreshReport = new Button();
            this.cmbReportFilter = new ComboBox();
            this.lblReportFilter = new Label();
            this.cmbReportType = new ComboBox();
            this.lblReportType = new Label();
            this.tabControlReports.SuspendLayout();
            this.tabDamageReports.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.statisticsFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabDamageReports);
            this.tabControlReports.Controls.Add(this.tabStatistics);
            this.tabControlReports.Dock = DockStyle.Fill;
            this.tabControlReports.Location = new System.Drawing.Point(0, 0);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(700, 400);
            this.tabControlReports.TabIndex = 0;
            // 
            // tabDamageReports
            // 
            this.tabDamageReports.Controls.Add(this.flowLayoutPanelReports);
            this.tabDamageReports.Location = new System.Drawing.Point(4, 29);
            this.tabDamageReports.Name = "tabDamageReports";
            this.tabDamageReports.Padding = new Padding(3);
            this.tabDamageReports.Size = new System.Drawing.Size(692, 367);
            this.tabDamageReports.TabIndex = 0;
            this.tabDamageReports.Text = "Damage Reports";
            this.tabDamageReports.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelReports
            // 
            this.flowLayoutPanelReports.AutoScroll = true;
            this.flowLayoutPanelReports.Dock = DockStyle.Fill;
            this.flowLayoutPanelReports.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelReports.Name = "flowLayoutPanelReports";
            this.flowLayoutPanelReports.Size = new System.Drawing.Size(686, 361);
            this.flowLayoutPanelReports.TabIndex = 0;
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.dgvStatistics);
            this.tabStatistics.Controls.Add(this.statisticsFilterPanel);
            this.tabStatistics.Location = new System.Drawing.Point(4, 29);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(692, 367);
            this.tabStatistics.TabIndex = 1;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.AllowUserToResizeColumns = false;
            this.dgvStatistics.AllowUserToResizeRows = false;
            this.dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatistics.Dock = DockStyle.Fill;
            this.dgvStatistics.Location = new System.Drawing.Point(3, 63);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStatistics.RowHeadersWidth = 51;
            this.dgvStatistics.Size = new System.Drawing.Size(686, 301);
            this.dgvStatistics.TabIndex = 1;
            // 
            // statisticsFilterPanel
            // 
            this.statisticsFilterPanel.Controls.Add(this.btnRefreshReport);
            this.statisticsFilterPanel.Controls.Add(this.cmbReportFilter);
            this.statisticsFilterPanel.Controls.Add(this.lblReportFilter);
            this.statisticsFilterPanel.Controls.Add(this.cmbReportType);
            this.statisticsFilterPanel.Controls.Add(this.lblReportType);
            this.statisticsFilterPanel.Dock = DockStyle.Top;
            this.statisticsFilterPanel.Location = new System.Drawing.Point(3, 3);
            this.statisticsFilterPanel.Name = "statisticsFilterPanel";
            this.statisticsFilterPanel.Size = new System.Drawing.Size(686, 60);
            this.statisticsFilterPanel.TabIndex = 0;
            // 
            // btnRefreshReport
            // 
            this.btnRefreshReport.Location = new System.Drawing.Point(587, 15);
            this.btnRefreshReport.Name = "btnRefreshReport";
            this.btnRefreshReport.Size = new System.Drawing.Size(91, 31);
            this.btnRefreshReport.TabIndex = 4;
            this.btnRefreshReport.Text = "Refresh";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            this.btnRefreshReport.Click += new System.EventHandler(this.btnRefreshReport_Click);
            // 
            // cmbReportFilter
            // 
            this.cmbReportFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbReportFilter.FormattingEnabled = true;
            this.cmbReportFilter.Location = new System.Drawing.Point(421, 17);
            this.cmbReportFilter.Name = "cmbReportFilter";
            this.cmbReportFilter.Size = new System.Drawing.Size(160, 28);
            this.cmbReportFilter.TabIndex = 3;
            this.cmbReportFilter.SelectedIndexChanged += new System.EventHandler(this.cmbReportFilter_SelectedIndexChanged);
            // 
            // lblReportFilter
            // 
            this.lblReportFilter.AutoSize = true;
            this.lblReportFilter.Location = new System.Drawing.Point(366, 20);
            this.lblReportFilter.Name = "lblReportFilter";
            this.lblReportFilter.Size = new System.Drawing.Size(48, 20);
            this.lblReportFilter.TabIndex = 2;
            this.lblReportFilter.Text = "Filter:";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(95, 17);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(260, 28);
            this.cmbReportType.TabIndex = 1;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(5, 20);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(88, 20);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report type:";
            // 
            // ReportsMain
            // 
            this.Controls.Add(this.tabControlReports);
            this.Name = "ReportsMain";
            this.Size = new System.Drawing.Size(700, 400);
            this.tabControlReports.ResumeLayout(false);
            this.tabDamageReports.ResumeLayout(false);
            this.tabStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.statisticsFilterPanel.ResumeLayout(false);
            this.statisticsFilterPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
