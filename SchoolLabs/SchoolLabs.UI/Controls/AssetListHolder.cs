using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabs.UI.Controls
{
    public partial class AssetListHolder : UserControl
    {
       
        private Panel Details_pnl;

        public AssetListHolder()
        {
            InitializeComponent();
        }

        private void AddAsset_btn_Temp_Click(object sender, EventArgs e)
        {
            AssetListBox box = new AssetListBox("TestItem", Core.Enums.AssetStatus.Borrowed)
            {
                Margin = new Padding(10)
            };

            
            box.MoreInfoClicked += Box_MoreInfoClicked;

            ListHolder_pnl.Controls.Add(box);
        }

        private void Box_MoreInfoClicked(object? sender, EventArgs e)
        {
            if (sender is AssetListBox box)
            {
                ShowDetails(box);
            }
        }

        private void EnsureDetailsPanel()
        {
            if (Details_pnl != null)
                return;

            // put the details panel into the right panel of the split container
            Details_pnl = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.LightGray,
                Visible = false,
                Padding = new Padding(8)
            };

            // MainSplit_sc was created in the designer; host details in its Panel2
            MainSplit_sc.Panel2.Controls.Add(Details_pnl);
            Details_pnl.BringToFront();
        }

        private void ShowDetails(AssetListBox box)
        {
            EnsureDetailsPanel();

            Details_pnl.Controls.Clear();

            var title = new Label
            {
                Text = box.AssetName,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(6, 0, 0, 0)
            };

            var status = new Label
            {
                Text = $"Status: {box.StatusText}",
                Dock = DockStyle.Top,
                Height = 28,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(6, 0, 0, 0)
            };

            var closeBtn = new Button
            {
                Text = "Close",
                Dock = DockStyle.Bottom,
                Height = 30
            };
            closeBtn.Click += (s, e) => Details_pnl.Visible = false;

            
            Details_pnl.Controls.Add(status);
            Details_pnl.Controls.Add(title);
            Details_pnl.Controls.Add(closeBtn);

            Details_pnl.Visible = true;
            Details_pnl.BringToFront();
        }

        private void ListHolder_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
