namespace SchoolLab.WinFormsUI.Controls
{
    partial class ReportsMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControlReports = null;
        private System.Windows.Forms.TabPage tabDamageReports = null;
        private System.Windows.Forms.TabPage tabStatistics = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReports = null;
        private System.Windows.Forms.Panel statisticsFilterPanel = null;
        private System.Windows.Forms.Label lblReportType = null;
        private System.Windows.Forms.ComboBox cmbReportType = null;
        private System.Windows.Forms.Label lblReportFilter = null;
        private System.Windows.Forms.ComboBox cmbReportFilter = null;
        private System.Windows.Forms.Button btnRefreshReport = null;
        private System.Windows.Forms.DataGridView dgvStatistics = null;

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
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabDamageReports = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelReports = new System.Windows.Forms.FlowLayoutPanel();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.statisticsFilterPanel = new System.Windows.Forms.Panel();
            this.btnRefreshReport = new System.Windows.Forms.Button();
            this.cmbReportFilter = new System.Windows.Forms.ComboBox();
            this.lblReportFilter = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
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
            this.tabControlReports.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tabDamageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabDamageReports.Size = new System.Drawing.Size(692, 367);
            this.tabDamageReports.TabIndex = 0;
            this.tabDamageReports.Text = "Damage Reports";
            this.tabDamageReports.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelReports
            // 
            this.flowLayoutPanelReports.AutoScroll = true;
            this.flowLayoutPanelReports.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
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
            this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistics.Location = new System.Drawing.Point(3, 63);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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
            this.statisticsFilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.cmbReportFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
