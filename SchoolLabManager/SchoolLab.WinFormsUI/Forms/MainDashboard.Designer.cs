using SchoolLab.Core;
using SchoolLab.Data;
using SchoolLab.Data.Migrations;
namespace SchoolLab.WinFormsUI.Forms
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            Navigation = new GroupBox();
            btnActionTwo = new Button();
            btnActionOne = new Button();
            btnManageUsers = new Button();
            btnManageReports = new Button();
            btnManageLoans = new Button();
            btnManageAssets = new Button();
            btnLogout = new Button();
            lblWelcomeName = new Label();
            lblWelcomeRole = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MainControl_pnl = new FlowLayoutPanel();
            label1 = new Label();
            Navigation.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Navigation
            // 
            Navigation.BackColor = Color.LightSkyBlue;
            Navigation.Controls.Add(btnActionTwo);
            Navigation.Controls.Add(btnActionOne);
            Navigation.Controls.Add(btnManageUsers);
            Navigation.Controls.Add(btnManageReports);
            Navigation.Controls.Add(btnManageLoans);
            Navigation.Controls.Add(btnManageAssets);
            Navigation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Navigation.Location = new Point(0, 52);
            Navigation.Margin = new Padding(3, 4, 3, 4);
            Navigation.Name = "Navigation";
            Navigation.Padding = new Padding(3, 4, 3, 4);
            Navigation.Size = new Size(202, 544);
            Navigation.TabIndex = 0;
            Navigation.TabStop = false;
            Navigation.Text = "Navigation";
            // 
            // btnActionTwo
            // 
            btnActionTwo.AutoSize = true;
            btnActionTwo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActionTwo.BackColor = SystemColors.InactiveCaption;
            btnActionTwo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActionTwo.Location = new Point(14, 502);
            btnActionTwo.Margin = new Padding(3, 4, 3, 4);
            btnActionTwo.Name = "btnActionTwo";
            btnActionTwo.Size = new Size(78, 38);
            btnActionTwo.TabIndex = 7;
            btnActionTwo.Text = "Delete";
            btnActionTwo.UseVisualStyleBackColor = false;
            btnActionTwo.Click += btnActionTwo_Click_1;
            // 
            // btnActionOne
            // 
            btnActionOne.AutoSize = true;
            btnActionOne.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActionOne.BackColor = SystemColors.InactiveCaption;
            btnActionOne.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActionOne.Location = new Point(137, 502);
            btnActionOne.Margin = new Padding(3, 4, 3, 4);
            btnActionOne.Name = "btnActionOne";
            btnActionOne.Size = new Size(59, 38);
            btnActionOne.TabIndex = 6;
            btnActionOne.Text = "Add";
            btnActionOne.UseVisualStyleBackColor = false;
            btnActionOne.Click += btnActionOne_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.AutoSize = true;
            btnManageUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManageUsers.BackColor = SystemColors.InactiveCaption;
            btnManageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageUsers.Location = new Point(14, 195);
            btnManageUsers.Margin = new Padding(3, 4, 3, 4);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(145, 38);
            btnManageUsers.TabIndex = 4;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click_1;
            // 
            // btnManageReports
            // 
            btnManageReports.AutoSize = true;
            btnManageReports.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManageReports.BackColor = SystemColors.InactiveCaption;
            btnManageReports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageReports.Location = new Point(14, 145);
            btnManageReports.Margin = new Padding(3, 4, 3, 4);
            btnManageReports.Name = "btnManageReports";
            btnManageReports.Size = new Size(165, 38);
            btnManageReports.TabIndex = 2;
            btnManageReports.Text = "Manage Reports";
            btnManageReports.UseVisualStyleBackColor = false;
            btnManageReports.Click += btnManageReports_Click;
            // 
            // btnManageLoans
            // 
            btnManageLoans.AutoSize = true;
            btnManageLoans.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManageLoans.BackColor = SystemColors.InactiveCaption;
            btnManageLoans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageLoans.Location = new Point(14, 96);
            btnManageLoans.Margin = new Padding(3, 4, 3, 4);
            btnManageLoans.Name = "btnManageLoans";
            btnManageLoans.Size = new Size(148, 38);
            btnManageLoans.TabIndex = 1;
            btnManageLoans.Text = "Manage Loans";
            btnManageLoans.UseVisualStyleBackColor = false;
            btnManageLoans.Click += btnManageLoans_Click;
            // 
            // btnManageAssets
            // 
            btnManageAssets.AutoSize = true;
            btnManageAssets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManageAssets.BackColor = SystemColors.InactiveCaption;
            btnManageAssets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageAssets.Location = new Point(14, 47);
            btnManageAssets.Margin = new Padding(3, 4, 3, 4);
            btnManageAssets.Name = "btnManageAssets";
            btnManageAssets.Size = new Size(152, 38);
            btnManageAssets.TabIndex = 0;
            btnManageAssets.Text = "Manage Assets";
            btnManageAssets.UseVisualStyleBackColor = false;
            btnManageAssets.Click += btnManageAssets_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = SystemColors.InactiveCaption;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(817, 558);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(85, 38);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcomeName
            // 
            lblWelcomeName.AutoSize = true;
            lblWelcomeName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeName.Location = new Point(416, 9);
            lblWelcomeName.Name = "lblWelcomeName";
            lblWelcomeName.Size = new Size(149, 41);
            lblWelcomeName.TabIndex = 1;
            lblWelcomeName.Text = "Welcome,";
            // 
            // lblWelcomeRole
            // 
            lblWelcomeRole.AutoSize = true;
            lblWelcomeRole.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeRole.Location = new Point(8, 19);
            lblWelcomeRole.Name = "lblWelcomeRole";
            lblWelcomeRole.Size = new Size(84, 32);
            lblWelcomeRole.TabIndex = 2;
            lblWelcomeRole.Text = "Admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblWelcomeRole);
            panel1.Location = new Point(0, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 599);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(209, 4);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(706, 595);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // MainControl_pnl
            // 
            MainControl_pnl.Location = new Point(211, 54);
            MainControl_pnl.Margin = new Padding(3, 4, 3, 4);
            MainControl_pnl.Name = "MainControl_pnl";
            MainControl_pnl.Size = new Size(700, 502);
            MainControl_pnl.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 560);
            label1.Name = "label1";
            label1.Size = new Size(170, 41);
            label1.TabIndex = 8;
            label1.Text = "*Double click an item for more info.";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(914, 600);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(lblWelcomeName);
            Controls.Add(MainControl_pnl);
            Controls.Add(Navigation);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainDashboard";
            Text = "MainDashboard";
            Load += MainDashboard_Load;
            Navigation.ResumeLayout(false);
            Navigation.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Navigation;
        private Button btnManageAssets;
        private Label lblWelcomeName;
        private Label lblWelcomeRole;
        private Button btnActionOne;
        private Button btnManageUsers;
        private Button btnManageReports;
        private Button btnManageLoans;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel MainControl_pnl;
        private Button btnActionTwo;
        private Label label1;
        private Button btnLogout;
    }
}
