namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class AddUserDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Fullname_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Cancel_btn;

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
            Username_txt = new TextBox();
            Fullname_txt = new TextBox();
            Password_txt = new TextBox();
            Save_btn = new Button();
            Cancel_btn = new Button();
            labelUsername = new Label();
            labelFullname = new Label();
            labelPassword = new Label();
            label1 = new Label();
            UserRols_cbox = new ComboBox();
            SuspendLayout();
            // 
            // Username_txt
            // 
            Username_txt.Font = new Font("Segoe UI", 11F);
            Username_txt.Location = new Point(7, 37);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(260, 32);
            Username_txt.TabIndex = 0;
            // 
            // Fullname_txt
            // 
            Fullname_txt.Font = new Font("Segoe UI", 11F);
            Fullname_txt.Location = new Point(7, 100);
            Fullname_txt.Name = "Fullname_txt";
            Fullname_txt.Size = new Size(260, 32);
            Fullname_txt.TabIndex = 1;
            // 
            // Password_txt
            // 
            Password_txt.Font = new Font("Segoe UI", 11F);
            Password_txt.Location = new Point(7, 163);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(260, 32);
            Password_txt.TabIndex = 2;
            // 
            // Save_btn
            // 
            Save_btn.Font = new Font("Segoe UI", 11F);
            Save_btn.Location = new Point(7, 243);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(95, 30);
            Save_btn.TabIndex = 3;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Font = new Font("Segoe UI", 11F);
            Cancel_btn.Location = new Point(187, 243);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(83, 30);
            Cancel_btn.TabIndex = 4;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 11F);
            labelUsername.Location = new Point(10, 9);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(101, 25);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Font = new Font("Segoe UI", 11F);
            labelFullname.Location = new Point(7, 72);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(98, 25);
            labelFullname.TabIndex = 1;
            labelFullname.Text = "Full name:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 11F);
            labelPassword.Location = new Point(7, 135);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(95, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 198);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 5;
            label1.Text = "Role: ";
            // 
            // UserRols_cbox
            // 
            UserRols_cbox.FormattingEnabled = true;
            UserRols_cbox.Location = new Point(146, 201);
            UserRols_cbox.Name = "UserRols_cbox";
            UserRols_cbox.Size = new Size(121, 28);
            UserRols_cbox.TabIndex = 6;
            // 
            // AddUserDialog
            // 
            ClientSize = new Size(288, 285);
            Controls.Add(UserRols_cbox);
            Controls.Add(label1);
            Controls.Add(labelUsername);
            Controls.Add(labelFullname);
            Controls.Add(labelPassword);
            Controls.Add(Cancel_btn);
            Controls.Add(Save_btn);
            Controls.Add(Password_txt);
            Controls.Add(Fullname_txt);
            Controls.Add(Username_txt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddUserDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelFullname;
        private Label labelPassword;
        private Label label1;
        private ComboBox UserRols_cbox;
    }
}
