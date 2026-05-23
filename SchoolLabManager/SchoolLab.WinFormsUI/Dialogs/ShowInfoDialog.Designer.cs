namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class ShowInfoDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cancel_btn = new Button();
            Info_lbl = new Label();
            SuspendLayout();
            // 
            // Cancel_btn
            // 
            Cancel_btn.AutoSize = true;
            Cancel_btn.BackColor = SystemColors.InactiveCaption;
            Cancel_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel_btn.Location = new Point(97, 218);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(75, 31);
            Cancel_btn.TabIndex = 0;
            Cancel_btn.Text = "Exit";
            Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Info_lbl
            // 
            Info_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Info_lbl.Location = new Point(12, 9);
            Info_lbl.Name = "Info_lbl";
            Info_lbl.Size = new Size(260, 206);
            Info_lbl.TabIndex = 1;
            Info_lbl.Text = "label1";
            // 
            // ShowInfoDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(284, 261);
            Controls.Add(Info_lbl);
            Controls.Add(Cancel_btn);
            Name = "ShowInfoDialog";
            Text = "ShowInfoDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel_btn;
        private Label Info_lbl;
    }
}