using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;
using SchoolLab.WinFormsUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class AddItemDialog : Form
    {
        public AssetInputResult? Result { get; private set; }
        public AddItemDialog()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = Save_btn;
            CancelButton = Cancel_btn;

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
                Location_cbox.SelectedIndex = -1;

                Category_cbox.DataSource = categories;
                Category_cbox.DisplayMember = "Name";
                Category_cbox.ValueMember = "Id";
                Category_cbox.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine($"Failed to load locations/categories: {ex}");
            }
        }

        private void AddItemDialog_Load(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_txt.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            var ctx = new SchoolLabDbContext();

            int? selectedLocationId = Location_cbox.SelectedValue == null
            ? null
            : (int?)Convert.ToInt32(Location_cbox.SelectedValue);

            int? selectedCategoryId = Category_cbox.SelectedValue == null
            ? null
            : (int?)Convert.ToInt32(Category_cbox.SelectedValue);


            Result = new AssetInputResult
            {
                Name = Name_txt.Text.Trim(),
                SerialNumber = Serial_txt.Text.Trim(),
                PurchaseDate = PurchaseDate_pick.Value.Date,
                Location = ctx.Locations.Where(x => x.Id == selectedLocationId).First(),
                Category = ctx.Categories.Where(x => x.Id == selectedCategoryId).First(),
                Description = Description_txt.Text
            };
        }

        private void Category_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Test:
            //label3.Text = Category_cbox.SelectedItem.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
