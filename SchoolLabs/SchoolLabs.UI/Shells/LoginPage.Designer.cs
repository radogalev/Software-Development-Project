namespace SchoolLabs.UI
{
    partial class LoginPage
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
            label1 = new Label();
            label2 = new Label();
            username_txt = new TextBox();
            password_txt = new TextBox();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            showPass_chk = new CheckBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(43, 129);
            label1.Name = "label1";
            label1.Size = new Size(133, 31);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(43, 188);
            label2.Name = "label2";
            label2.Size = new Size(126, 31);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // username_txt
            // 
            username_txt.Location = new Point(182, 128);
            username_txt.Margin = new Padding(3, 4, 3, 4);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(179, 27);
            username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(182, 187);
            password_txt.Margin = new Padding(3, 4, 3, 4);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(179, 27);
            password_txt.TabIndex = 3;
            password_txt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 18);
            label3.Name = "label3";
            label3.Size = new Size(187, 47);
            label3.TabIndex = 5;
            label3.Text = "SchoolLab";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(43, 86);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 7;
            label5.Text = "Log into your account";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(141, 286);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 8;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(showPass_chk);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(username_txt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(179, 93);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 381);
            panel1.TabIndex = 9;
            // 
            // showPass_chk
            // 
            showPass_chk.AutoSize = true;
            showPass_chk.Location = new Point(343, 250);
            showPass_chk.Name = "showPass_chk";
            showPass_chk.Size = new Size(18, 17);
            showPass_chk.TabIndex = 10;
            showPass_chk.UseVisualStyleBackColor = true;
            showPass_chk.CheckedChanged += showPass_chk_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 238);
            label6.Name = "label6";
            label6.Size = new Size(182, 31);
            label6.TabIndex = 9;
            label6.Text = "Show Password: ";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(758, 567);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginPage";
            Text = "LoginPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_txt;
        private TextBox password_txt;
        private Label label3;
        private Label label5;
        private Button button1;
        private Panel panel1;
        private Label label6;
        private CheckBox showPass_chk;
    }
}