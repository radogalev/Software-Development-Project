using SchoolLabs.UI.Shells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabs.UI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(username_txt.Text);

            // pri zatvarqne na dashboard prozoreca se zatvarq i tozi prozorec
            d.FormClosed += (s, args) => this.Close();

            d.Show();
            this.Hide();
        }

        private void showPass_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_chk.Checked)
            {
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
