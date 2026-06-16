using System.ComponentModel;
namespace SchoolLab.WinFormsUI.Controls
{
    partial class AsssetsMain
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
            flowLayoutPanelAssets = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelAssets
            // 
            flowLayoutPanelAssets.AutoScroll = true;
            flowLayoutPanelAssets.Dock = DockStyle.Fill;
            flowLayoutPanelAssets.Location = new Point(0, 0);
            flowLayoutPanelAssets.Name = "flowLayoutPanelAssets";
            flowLayoutPanelAssets.Size = new Size(700, 400);
            flowLayoutPanelAssets.TabIndex = 0;
            // 
            // AsssetsMain
            // 
            Controls.Add(flowLayoutPanelAssets);
            Name = "AsssetsMain";
            Size = new Size(700, 400);
            ResumeLayout(false);
        }

        #endregion
    }
}
