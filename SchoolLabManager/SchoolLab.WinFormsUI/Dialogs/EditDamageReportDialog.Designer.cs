namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class EditDamageReportDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label Info_lbl;
        private Label labelRepairedBy;
        private ComboBox repairedBy_cbox;
        private Button Save_btn;
        private Button Cancel_btn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Info_lbl = new Label();
            labelRepairedBy = new Label();
            repairedBy_cbox = new ComboBox();
            Save_btn = new Button();
            Cancel_btn = new Button();
            SuspendLayout();
            // 
            // Info_lbl
            // 
            Info_lbl.Font = new Font("Segoe UI", 11F);
            Info_lbl.Location = new Point(12, 9);
            Info_lbl.Name = "Info_lbl";
            Info_lbl.Size = new Size(360, 170);
            Info_lbl.TabIndex = 0;
            Info_lbl.Text = "Report info";
            // 
            // labelRepairedBy
            // 
            labelRepairedBy.AutoSize = true;
            labelRepairedBy.Font = new Font("Segoe UI", 11F);
            labelRepairedBy.Location = new Point(12, 193);
            labelRepairedBy.Name = "labelRepairedBy";
            labelRepairedBy.Size = new Size(113, 25);
            labelRepairedBy.TabIndex = 1;
            labelRepairedBy.Text = "Repaired by:";
            // 
            // repairedBy_cbox
            // 
            repairedBy_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            repairedBy_cbox.Font = new Font("Segoe UI", 11F);
            repairedBy_cbox.FormattingEnabled = true;
            repairedBy_cbox.Location = new Point(137, 190);
            repairedBy_cbox.Name = "repairedBy_cbox";
            repairedBy_cbox.Size = new Size(235, 33);
            repairedBy_cbox.TabIndex = 2;
            // 
            // Save_btn
            // 
            Save_btn.Font = new Font("Segoe UI", 11F);
            Save_btn.Location = new Point(12, 246);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(92, 34);
            Save_btn.TabIndex = 3;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.DialogResult = DialogResult.Cancel;
            Cancel_btn.Font = new Font("Segoe UI", 11F);
            Cancel_btn.Location = new Point(280, 246);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(92, 34);
            Cancel_btn.TabIndex = 4;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // EditDamageReportDialog
            // 
            ClientSize = new Size(384, 297);
            Controls.Add(Cancel_btn);
            Controls.Add(Save_btn);
            Controls.Add(repairedBy_cbox);
            Controls.Add(labelRepairedBy);
            Controls.Add(Info_lbl);
            Name = "EditDamageReportDialog";
            Text = "Edit Damage Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
