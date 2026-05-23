using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.WinFormsUI.Dialogs;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class ReportItem : UserControl
    {
        public ReportItem()
        {
            InitializeComponent();
        }

        public int ReportId { get; private set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool Selected
        {
            get { return this.BackColor == Color.DarkTurquoise; }
            set { this.BackColor = value ? Color.DarkTurquoise : Color.PaleTurquoise; }
        }

        public void Bind(DamageReport report)
        {
            if (report == null) return;
            ReportId = report.Id;
            lblName.Text = $"Report #{report.Id} - {(report.BorrowedAsset?.Name ?? "Asset")}";
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            try
            {
                using var context = new SchoolLabDbContext();
                var r = context.DamageReports.FirstOrDefault(x => x.Id == ReportId);

                if (r == null)
                {
                    MessageBox.Show(this, "Report not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message =
                    $"Report Id: {r.Id}\n" +
                    $"Asset: {(r.BorrowedAsset?.Name ?? "Unknown")}\n" +
                    $"Reported By: {(r.ReportedBy?.Username ?? "Unknown")}\n" +
                    $"Date: {r.DateReported:yyyy-MM-dd}\n" +
                    $"Description: {r.Description}\n";

                using var dlg = new ShowInfoDialog($"Damage Report #{r.Id}", message);
                dlg.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occurred while showing report details:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
