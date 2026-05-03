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
        public AssetListBox(string name, LoanedStatus status)
        {
            InitializeComponent();
            Name_lbl.Text = name;
            Status_lbl.Text = status.ToString();
        }
    }
}
