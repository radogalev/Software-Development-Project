using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.WinFormsUI.Dialogs;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class ReportItem : UserControl
    {
        private readonly User _currentUser;

        public ReportItem(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            lblName.Click += (s, e) => this.OnClick(e);
            lblName.DoubleClick += (s, e) => this.OnDoubleClick(e);
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
            lblName.Text = $"Damage Report #{report.Id}\n{(report.BorrowedAsset?.Name ?? "Asset")}";
        }

        protected override void OnDoubleClick(EventArgs e)
        {

            base.OnDoubleClick(e);

            try
            {
                using var context = new SchoolLabDbContext();
                var r = context.DamageReports
                        .Include(x => x.BorrowedAsset)
                        .Include(x => x.ReportedBy)
                        .Include(x => x.RepairedBy)
                        .FirstOrDefault(x => x.Id == ReportId);

                if (r == null)
                {
                    MessageBox.Show(this, "Report not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message =
                    $"Report Id: {r.Id}\n" +
                    $"Asset: {(r.BorrowedAsset?.Name ?? "Unknown")}\n" +
                    $"Reported By: {(r.ReportedBy?.Username ?? "Unknown")}\n" +
                    $"Repaired By: {(r.RepairedBy?.Username ?? "Not repaired")}\n" +
                    $"Date: {r.DateReported:yyyy-MM-dd}\n" +
                    $"Description: {r.Description}\n";

                if (_currentUser.Role is UserRole.Administrator or UserRole.LabAssistant)
                {
                    using var dlg = new EditDamageReportDialog($"Damage Report #{r.Id}", message, r.RepairedById);
                    DialogResult res = dlg.ShowDialog(this);
                    if (res != DialogResult.OK) return;

                    r.RepairedById = dlg.SelectedRepairedById;
                    context.SaveChanges();
                }
                else
                {
                    using var dlg = new ShowInfoDialog($"Damage Report #{r.Id}", message);
                    dlg.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occurred while showing report details:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
