using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.WinFormsUI.Dialogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class AssetItemEdit : UserControl
    {
        public AssetItemEdit()
        {
            InitializeComponent();
            
        }
        public int AssetId { get; private set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Selected
        {
            get { return this.BackColor == Color.DarkTurquoise; 
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

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            try
            {
                var context = new SchoolLabDbContext();
                var a = context.Assets
                    .Include(x => x.Category)
                    .Include(x => x.StoredLocation)
                    .FirstOrDefault(x => x.Id == AssetId);

                if (a == null)
                {
                    MessageBox.Show(this, "Asset not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message =
                    $"{a.Name}\n" +
                    $"{a.Status}, {a.Condition}\n" +
                    $"{a.Category.Name}, {a.StoredLocation.Name}\n" +
                    $"Purchased On: {(a.DateOfPurchase == default ? "Unknown" : a.DateOfPurchase.ToString("yyyy-MM-dd"))}\n" +
                    $"{a.Description}";

                var dlg = new ShowInfoDialog(a.Name, message);
                DialogResult res = dlg.ShowDialog(this);
                if (res != DialogResult.OK) return;

                var input = dlg.DialogResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occurred while showing asset details:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
