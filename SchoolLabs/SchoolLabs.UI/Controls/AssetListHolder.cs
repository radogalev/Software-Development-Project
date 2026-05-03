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
        public AssetListHolder()
        {
            InitializeComponent();
        }

        private void AddAsset_btn_Temp_Click(object sender, EventArgs e)
        {
            AssetListBox box = new AssetListBox("TestItem", Core.Enums.LoanedStatus.Loaned);
            ListHolder_pnl.Controls.Add(box);
        }

        private void ListHolder_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
