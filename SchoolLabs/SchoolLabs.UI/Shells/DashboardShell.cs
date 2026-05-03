using SchoolLabs.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabs.UI.Shells
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            Welcome_lbl.Text = $"Welcome,\n{username}!";
            AssetListHolder hold = new AssetListHolder();
            ControlHolder_pnl.Controls.Add(hold);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
