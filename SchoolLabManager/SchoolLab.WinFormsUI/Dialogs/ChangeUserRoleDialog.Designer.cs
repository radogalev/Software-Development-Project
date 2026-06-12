namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class ChangeUserRoleDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelRole;
        private ComboBox UserRols_cbox;
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
            labelRole = new Label();
            UserRols_cbox = new ComboBox();
            Save_btn = new Button();
            Cancel_btn = new Button();
            SuspendLayout();
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 11F);
            labelRole.Location = new Point(12, 18);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(54, 25);
            labelRole.TabIndex = 0;
            labelRole.Text = "Role:";
            // 
            // UserRols_cbox
            // 
            UserRols_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            UserRols_cbox.Font = new Font("Segoe UI", 11F);
            UserRols_cbox.FormattingEnabled = true;
            UserRols_cbox.Location = new Point(82, 15);
            UserRols_cbox.Name = "UserRols_cbox";
            UserRols_cbox.Size = new Size(181, 33);
            UserRols_cbox.TabIndex = 1;
            // 
            // Save_btn
            // 
            Save_btn.Font = new Font("Segoe UI", 11F);
            Save_btn.Location = new Point(12, 72);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(88, 34);
            Save_btn.TabIndex = 2;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.DialogResult = DialogResult.Cancel;
            Cancel_btn.Font = new Font("Segoe UI", 11F);
            Cancel_btn.Location = new Point(175, 72);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(88, 34);
            Cancel_btn.TabIndex = 3;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // ChangeUserRoleDialog
            // 
            ClientSize = new Size(282, 122);
            Controls.Add(Cancel_btn);
            Controls.Add(Save_btn);
            Controls.Add(UserRols_cbox);
            Controls.Add(labelRole);
            Name = "ChangeUserRoleDialog";
            Text = "Change Role";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
