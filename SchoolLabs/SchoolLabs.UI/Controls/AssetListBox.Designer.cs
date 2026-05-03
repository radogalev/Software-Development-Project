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
            Name_lbl.Location = new Point(10, 10);
            Name_lbl.Margin = new Padding(10);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(135, 28);
            Name_lbl.TabIndex = 0;
            Name_lbl.Text = "Name of asset";
            // 
            // Status_lbl
            // 
            Status_lbl.AutoSize = true;
            Status_lbl.Location = new Point(10, 72);
            Status_lbl.Name = "Status_lbl";
            Status_lbl.Size = new Size(58, 20);
            Status_lbl.TabIndex = 1;
            Status_lbl.Text = "Loaned";
            // 
            // Info_btn
            // 
            Info_btn.Location = new Point(78, 143);
            Info_btn.Name = "Info_btn";
            Info_btn.Size = new Size(94, 29);
            Info_btn.TabIndex = 2;
            Info_btn.Text = "More Info";
            Info_btn.UseVisualStyleBackColor = true;
            // 
            // AssetListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(Info_btn);
            Controls.Add(Status_lbl);
            Controls.Add(Name_lbl);
            Name = "AssetListBox";
            Size = new Size(175, 175);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_lbl;
        private Label Status_lbl;
        private Button Info_btn;
    }
}
