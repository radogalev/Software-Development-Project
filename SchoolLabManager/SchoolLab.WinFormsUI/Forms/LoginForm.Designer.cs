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
            Title_Lbl = new Label();
            label2 = new Label();
            username_txt = new TextBox();
            label3 = new Label();
            password_txt = new TextBox();
            lblError = new Label();
            login_btn = new Button();
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
            Title_Lbl.Location = new Point(30, 19);
            Title_Lbl.Name = "Title_Lbl";
            Title_Lbl.Size = new Size(277, 38);
            Title_Lbl.TabIndex = 0;
            Title_Lbl.Text = "SchoolLab Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(38, 97);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // username_txt
            // 
            username_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txt.Location = new Point(159, 96);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(145, 33);
            username_txt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(38, 141);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // password_txt
            // 
            password_txt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txt.Location = new Point(159, 138);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(143, 33);
            password_txt.TabIndex = 4;
            password_txt.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.Location = new Point(102, 373);
            lblError.Name = "lblError";
            lblError.Size = new Size(431, 30);
            lblError.TabIndex = 5;
            lblError.Text = "Error. Username and password do not match.";
            lblError.Visible = false;
            // 
            // login_btn
            // 
            login_btn.AutoSize = true;
            login_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(123, 214);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 40);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(showPass_chk);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(Title_Lbl);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(username_txt);
            panel1.Location = new Point(157, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 286);
            panel1.TabIndex = 7;
            // 
            // showPass_chk
            // 
            showPass_chk.AutoSize = true;
            showPass_chk.Location = new Point(287, 189);
            showPass_chk.Name = "showPass_chk";
            showPass_chk.Size = new Size(15, 14);
            showPass_chk.TabIndex = 8;
            showPass_chk.UseVisualStyleBackColor = true;
            showPass_chk.CheckedChanged += showPass_chk_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(38, 178);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 7;
            label1.Text = "Show Password: ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(663, 425);
            Controls.Add(lblError);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}