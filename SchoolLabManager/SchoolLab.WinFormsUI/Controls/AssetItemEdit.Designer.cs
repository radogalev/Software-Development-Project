using System.ComponentModel;
namespace SchoolLab.WinFormsUI.Controls
{
    partial class AssetItemEdit
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
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(5, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 21);
            lblName.TabIndex = 0;
            lblName.Text = "AssetName";
            // 
            // AssetItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblName);
            Margin = new Padding(6);
            Name = "AssetItem";
            Padding = new Padding(2);
            Size = new Size(167, 148);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
    }
}
