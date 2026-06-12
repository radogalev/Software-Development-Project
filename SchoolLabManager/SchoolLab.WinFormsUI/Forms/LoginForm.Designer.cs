namespace SchoolLab.WinFormsUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Title_Lbl = new Label();
            label2 = new Label();
            username_txt = new TextBox();
            label3 = new Label();
            password_txt = new TextBox();
            lblError = new Label();
            login_btn = new Button();
            register_btn = new Button();
            panel1 = new Panel();
            showPass_chk = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Title_Lbl
            // 
            Title_Lbl.Anchor = AnchorStyles.Top;
            Title_Lbl.AutoSize = true;
            Title_Lbl.Font = new Font("Segoe UI", 21F, FontStyle.Bold | FontStyle.Italic);
            Title_Lbl.Location = new Point(34, 25);
            Title_Lbl.Name = "Title_Lbl";
            Title_Lbl.Size = new Size(343, 47);
            Title_Lbl.TabIndex = 0;
            Title_Lbl.Text = "SchoolLab Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(43, 129);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // username_txt
            // 
            username_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txt.Location = new Point(182, 128);
            username_txt.Margin = new Padding(3, 4, 3, 4);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(165, 39);
            username_txt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(43, 188);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // password_txt
            // 
            password_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.Location = new Point(182, 184);
            password_txt.Margin = new Padding(3, 4, 3, 4);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(163, 39);
            password_txt.TabIndex = 4;
            password_txt.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.Location = new Point(117, 497);
            lblError.Name = "lblError";
            lblError.Size = new Size(550, 37);
            lblError.TabIndex = 5;
            lblError.Text = "Error. Username and password do not match.";
            lblError.Visible = false;
            // 
            // login_btn
            // 
            login_btn.AutoSize = true;
            login_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(141, 285);
            login_btn.Margin = new Padding(3, 4, 3, 4);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(107, 63);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // register_btn
            // 
            register_btn.AutoSize = true;
            register_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.Location = new Point(291, 339);
            register_btn.Margin = new Padding(3, 4, 3, 4);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(99, 38);
            register_btn.TabIndex = 9;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(showPass_chk);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(register_btn);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(Title_Lbl);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(username_txt);
            panel1.Location = new Point(179, 93);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 381);
            panel1.TabIndex = 7;
            // 
            // showPass_chk
            // 
            showPass_chk.AutoSize = true;
            showPass_chk.Location = new Point(328, 252);
            showPass_chk.Margin = new Padding(3, 4, 3, 4);
            showPass_chk.Name = "showPass_chk";
            showPass_chk.Size = new Size(18, 17);
            showPass_chk.TabIndex = 8;
            showPass_chk.UseVisualStyleBackColor = true;
            showPass_chk.CheckedChanged += showPass_chk_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(43, 237);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 7;
            label1.Text = "Show Password: ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(758, 567);
            Controls.Add(lblError);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_Lbl;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label lblError;
        private Button login_btn;
        private TextBox username_txt;
        private Panel panel1;
        private Label label1;
        private CheckBox showPass_chk;
        private TextBox password_txt;
        private Button register_btn;
    }
}
