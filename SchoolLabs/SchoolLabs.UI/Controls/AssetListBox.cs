using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLabs.Core.Enums;

namespace SchoolLabs.UI.Controls
{
    public partial class AssetListBox : UserControl
    {
        public event EventHandler MoreInfoClicked;

        public string AssetName
        {
            get => Name_lbl.Text;
            set => Name_lbl.Text = value;
        }

        public string StatusText
        {
            get => Status_lbl.Text;
            set => Status_lbl.Text = value;
        }

        public AssetListBox(string name, LoanedStatus status)
        {
            InitializeComponent();
            AssetName = name;
            StatusText = status.ToString();

            Info_btn.Click += Info_btn_Click;
        }

        private void Info_btn_Click(object? sender, EventArgs e)
        {
            MoreInfoClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
