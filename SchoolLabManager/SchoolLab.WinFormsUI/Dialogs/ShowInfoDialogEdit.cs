using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.WinFormsUI.Helpers;
using System.Data;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class ShowInfoDialogEdit : Form
    {
        public EditResult? Result { get; private set; }
        public ShowInfoDialogEdit(string title, string message, AssetStatus status, AssetCondition condition, int storedLocationId, int categoryId)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            CancelButton = Cancel_btn;
            AcceptButton = Save_btn;

            this.Text = title;
            Info_lbl.Text = message;
            SetUpEditBoxes(storedLocationId, categoryId, status, condition);
        }
        public void SetUpEditBoxes(int storedLocationId, int categoryId, AssetStatus status, AssetCondition condition)
        {
            try
            {
                var ctx = new SchoolLabDbContext();

                var locations = ctx.Locations
                                   .OrderBy(l => l.Name)
                                   .Select(l => new LookupItem { Id = l.Id, Name = l.Name })
                                   .ToList();

                var categories = ctx.Categories
                                    .OrderBy(c => c.Name)
                                    .Select(c => new LookupItem { Id = c.Id, Name = c.Name })
                                    .ToList();


                Location_cbox.DataSource = locations;
                Location_cbox.DisplayMember = "Name";
                Location_cbox.ValueMember = "Id";
                Location_cbox.SelectedValue = storedLocationId;

                Category_cbox.DataSource = categories;
                Category_cbox.DisplayMember = "Name";
                Category_cbox.ValueMember = "Id";
                Category_cbox.SelectedValue = categoryId;

                condition_cbox.DataSource = Enum.GetValues(typeof(AssetCondition));
                condition_cbox.SelectedItem = condition;

                status_cbox.DataSource = Enum.GetValues(typeof(AssetStatus));
                status_cbox.SelectedItem = status;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine($"Failed to load locations/categories: {ex}");
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            int? selectedLocationId = Location_cbox.SelectedValue == null
            ? null
            : (int?)Convert.ToInt32(Location_cbox.SelectedValue);

            int? selectedCategoryId = Category_cbox.SelectedValue == null
            ? null
            : (int?)Convert.ToInt32(Category_cbox.SelectedValue);

            if (selectedLocationId == null || selectedCategoryId == null || status_cbox.SelectedItem == null || condition_cbox.SelectedItem == null)
            {
                MessageBox.Show(this, "Please select status, condition, category, and location.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            using var ctx = new SchoolLabDbContext();

            Result = new EditResult
            {
                Location = ctx.Locations.Where(x => x.Id == selectedLocationId).First(),
                Category = ctx.Categories.Where(x => x.Id == selectedCategoryId).First(),
                Status = (AssetStatus)status_cbox.SelectedItem,
                Condition = (AssetCondition)condition_cbox.SelectedItem
            };
        }
    }

    public class EditResult
    {
        public Location Location { get; init; } = null;
        public Category Category { get; init; } = null;
        public AssetStatus Status { get; init; }
        public AssetCondition Condition { get; init; }


    }
}
