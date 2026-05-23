using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class ShowInfoDialog : Form
    {
        public ShowInfoDialog(string title, string message)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            CancelButton = Cancel_btn;
            this.Text = title;
            Info_lbl.Text = message;
        }
    }
}
