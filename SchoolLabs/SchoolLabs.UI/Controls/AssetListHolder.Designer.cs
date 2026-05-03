namespace SchoolLabs.UI.Controls
{
    partial class AssetListHolder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            AddAsset_btn_Temp = new Button();
            ListHolder_pnl = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // AddAsset_btn_Temp
            // 
            AddAsset_btn_Temp.Location = new Point(453, 373);
            AddAsset_btn_Temp.Name = "AddAsset_btn_Temp";
            AddAsset_btn_Temp.Size = new Size(94, 29);
            AddAsset_btn_Temp.TabIndex = 0;
            AddAsset_btn_Temp.Text = "button1";
            AddAsset_btn_Temp.UseVisualStyleBackColor = true;
            AddAsset_btn_Temp.Click += AddAsset_btn_Temp_Click;
            // 
            // ListHolder_pnl
            // 
            ListHolder_pnl.Location = new Point(9, 14);
            ListHolder_pnl.Name = "ListHolder_pnl";
            ListHolder_pnl.Size = new Size(538, 353);
            ListHolder_pnl.TabIndex = 1;
            ListHolder_pnl.Paint += ListHolder_pnl_Paint;
            // 
            // AssetListHolder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(ListHolder_pnl);
            Controls.Add(AddAsset_btn_Temp);
            Name = "AssetListHolder";
            Size = new Size(550, 405);
            ResumeLayout(false);
        }

        #endregion

        private Button AddAsset_btn_Temp;
        private FlowLayoutPanel ListHolder_pnl;
    }
}
