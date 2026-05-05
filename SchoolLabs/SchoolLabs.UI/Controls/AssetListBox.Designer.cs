namespace SchoolLabs.UI.Controls
{
    partial class AssetListBox
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
            Name_lbl = new Label();
            Status_lbl = new Label();
            Info_btn = new Button();
            SuspendLayout();
            // 
            // Name_lbl
            // 
            Name_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_lbl.Location = new Point(9, 8);
            Name_lbl.Margin = new Padding(9, 8, 9, 8);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(118, 21);
            Name_lbl.TabIndex = 0;
            Name_lbl.Text = "Name of asset";
            // 
            // Status_lbl
            // 
            Status_lbl.AutoSize = true;
            Status_lbl.Location = new Point(9, 54);
            Status_lbl.Name = "Status_lbl";
            Status_lbl.Size = new Size(46, 15);
            Status_lbl.TabIndex = 1;
            Status_lbl.Text = "Loaned";
            // 
            // Info_btn
            // 
            Info_btn.Location = new Point(65, 107);
            Info_btn.Margin = new Padding(3, 2, 3, 2);
            Info_btn.Name = "Info_btn";
            Info_btn.Size = new Size(82, 22);
            Info_btn.TabIndex = 2;
            Info_btn.Text = "More Info";
            Info_btn.UseVisualStyleBackColor = true;
            // 
            // AssetListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(Info_btn);
            Controls.Add(Status_lbl);
            Controls.Add(Name_lbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AssetListBox";
            Size = new Size(150, 131);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_lbl;
        private Label Status_lbl;
        private Button Info_btn;
    }
}
