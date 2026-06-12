using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Dialogs;
using System.ComponentModel;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class AssetItem : UserControl
    {
        private User _currentUser;
        private readonly IAssetService? _assetService;
        public AssetItem(User currentUser, IAssetService? assetService = null)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _assetService = assetService;

            lblName.Click += (s, e) => this.OnClick(e);
            lblName.DoubleClick += (s, e) => this.OnDoubleClick(e);
        }
        public int AssetId { get; private set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Selected
        {
            get
            {
                return this.BackColor == Color.DarkTurquoise;
            }
            set { this.BackColor = value ? Color.DarkTurquoise : Color.PaleTurquoise; }
        }

        public void Bind(Asset asset)
        {
            if (asset == null) return;
            AssetId = asset.Id;
            lblName.Text = asset.Name;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override async void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            try
            {
                using var context = new SchoolLabDbContext();
                var a = context.Assets
                    .Include(x => x.Category)
                    .Include(x => x.StoredLocation)
                    .FirstOrDefault(x => x.Id == AssetId);

                if (a == null)
                {
                    MessageBox.Show(this, "Asset not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_currentUser.Role == UserRole.Viewer)
                {
                    string message =
                        $"{a.Name}\n" +
                        $"{a.Status}, {a.Condition}\n" +
                        $"{a.Category.Name}, {a.StoredLocation.Name}\n" +
                        $"Purchased On: {(a.DateOfPurchase == default ? "Unknown" : a.DateOfPurchase.ToString("yyyy-MM-dd"))}\n" +
                        $"{a.Description}";

                    var dlg = new ShowInfoDialog(a.Name, message);
                    dlg.ShowDialog(this);
                }
                else
                {
                    string message =
                        $"{a.Name}\n" +
                        //$"{a.Status}, {a.Condition}\n" +
                        //$"{a.Category.Name}, {a.StoredLocation.Name}\n" +
                        $"Purchased On: {(a.DateOfPurchase == default ? "Unknown" : a.DateOfPurchase.ToString("yyyy-MM-dd"))}\n" +
                        $"{a.Description}";
                    AssetStatus status = a.Status;
                    AssetCondition condition = a.Condition;
                    int storedLocationId = a.StoredLocation.Id;
                    int categoryId = a.CategoryId;
                    var dlg = new ShowInfoDialogEdit(a.Name, message, status, condition, storedLocationId, categoryId);


                    DialogResult res = dlg.ShowDialog(this);
                    if (res != DialogResult.OK) return;

                    var input = dlg.Result;
                    if (input == null) return;

                    await ProcessEdit(input, a);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occurred while showing asset details:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ProcessEdit(EditResult res, Asset a)
        {
            a.Status = res.Status;
            a.Condition = res.Condition;

            a.LocationId = res.Location.Id;
            a.CategoryId = res.Category.Id;

            if (_assetService != null)
            {
                await _assetService.UpdateAssetAsync(a);
                return;
            }

            try
            {
                using var context = new SchoolLabDbContext();
                var existing = await context.Assets
                    .FirstOrDefaultAsync(x => x.Id == a.Id);

                if (existing == null)
                {

                    return;
                }

                existing.Status = a.Status;
                existing.Condition = a.Condition;
                existing.LocationId = a.LocationId;
                existing.CategoryId = a.CategoryId;

                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to update asset: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
