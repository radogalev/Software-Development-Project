namespace SchoolLabs.UI.Shells
{
    partial class Dashboard
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
            AssetsWindow_btn = new Button();
            LoansWindow_btn = new Button();
            UsersWindow_btn = new Button();
            ReportsWindow_btn = new Button();
            ControlHolder_pnl = new FlowLayoutPanel();
            LogOut_btn = new Button();
            Welcome_lbl = new Label();
            SuspendLayout();
            // 
            // AssetsWindow_btn
            // 
            AssetsWindow_btn.BackColor = SystemColors.ButtonHighlight;
            AssetsWindow_btn.Location = new Point(10, 96);
            AssetsWindow_btn.Margin = new Padding(3, 2, 3, 2);
            AssetsWindow_btn.Name = "AssetsWindow_btn";
            AssetsWindow_btn.Size = new Size(110, 40);
            AssetsWindow_btn.TabIndex = 0;
            AssetsWindow_btn.Text = "Assets";
            AssetsWindow_btn.UseVisualStyleBackColor = false;
            AssetsWindow_btn.Click += AssetsWindow_btn_Click;
            // 
            // LoansWindow_btn
            // 
            LoansWindow_btn.Location = new Point(10, 140);
            LoansWindow_btn.Margin = new Padding(3, 2, 3, 2);
            LoansWindow_btn.Name = "LoansWindow_btn";
            LoansWindow_btn.Size = new Size(110, 40);
            LoansWindow_btn.TabIndex = 1;
            LoansWindow_btn.Text = "Loans";
            LoansWindow_btn.UseVisualStyleBackColor = true;
            // 
            // UsersWindow_btn
            // 
            UsersWindow_btn.Location = new Point(10, 184);
            UsersWindow_btn.Margin = new Padding(3, 2, 3, 2);
            UsersWindow_btn.Name = "UsersWindow_btn";
            UsersWindow_btn.Size = new Size(110, 40);
            UsersWindow_btn.TabIndex = 2;
            UsersWindow_btn.Text = "Users";
            UsersWindow_btn.UseVisualStyleBackColor = true;
            // 
            // ReportsWindow_btn
            // 
            ReportsWindow_btn.BackColor = SystemColors.ButtonHighlight;
            ReportsWindow_btn.Location = new Point(10, 229);
            ReportsWindow_btn.Margin = new Padding(3, 2, 3, 2);
            ReportsWindow_btn.Name = "ReportsWindow_btn";
            ReportsWindow_btn.Size = new Size(110, 40);
            ReportsWindow_btn.TabIndex = 3;
            ReportsWindow_btn.Text = "Reports";
            ReportsWindow_btn.UseVisualStyleBackColor = false;
            // 
            // ControlHolder_pnl
            // 
            ControlHolder_pnl.Location = new Point(184, 9);
            ControlHolder_pnl.Margin = new Padding(3, 2, 3, 2);
            ControlHolder_pnl.Name = "ControlHolder_pnl";
            ControlHolder_pnl.Size = new Size(506, 320);
            ControlHolder_pnl.TabIndex = 4;
            // 
            // LogOut_btn
            // 
            LogOut_btn.BackColor = SystemColors.ButtonHighlight;
            LogOut_btn.Location = new Point(10, 304);
            LogOut_btn.Margin = new Padding(3, 2, 3, 2);
            LogOut_btn.Name = "LogOut_btn";
            LogOut_btn.Size = new Size(39, 26);
            LogOut_btn.TabIndex = 5;
            LogOut_btn.Text = "Exit";
            LogOut_btn.UseVisualStyleBackColor = false;
            // 
            // Welcome_lbl
            // 
            Welcome_lbl.AutoSize = true;
            Welcome_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome_lbl.Location = new Point(10, 9);
            Welcome_lbl.Name = "Welcome_lbl";
            Welcome_lbl.Size = new Size(156, 30);
            Welcome_lbl.TabIndex = 6;
            Welcome_lbl.Text = "Welcome, user";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(700, 338);
            Controls.Add(Welcome_lbl);
            Controls.Add(LogOut_btn);
            Controls.Add(ControlHolder_pnl);
            Controls.Add(ReportsWindow_btn);
            Controls.Add(UsersWindow_btn);
            Controls.Add(LoansWindow_btn);
            Controls.Add(AssetsWindow_btn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AssetsWindow_btn;
        private Button LoansWindow_btn;
        private Button UsersWindow_btn;
        private Button ReportsWindow_btn;
        private FlowLayoutPanel ControlHolder_pnl;
        private Button LogOut_btn;
        private Label Welcome_lbl;
    }
}