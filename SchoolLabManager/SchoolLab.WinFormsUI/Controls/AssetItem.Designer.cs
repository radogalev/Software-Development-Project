using System.ComponentModel;
namespace SchoolLab.WinFormsUI.Controls
{
    partial class AssetItem
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            lblName = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoEllipsis = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(3, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(319, 80);
            lblName.TabIndex = 0;
            lblName.Text = "Asset";
            // 
            // AssetItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AssetItem";
            Size = new Size(325, 100);
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
    }
}
