namespace SchoolLab.WinFormsUI.Controls
{
    partial class UsersMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUsers;
        private System.Windows.Forms.Label lblAdministrators;
        private System.Windows.Forms.Label lblLabAssistants;
        private System.Windows.Forms.Label lblViewers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAdministrators;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLabAssistants;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelViewers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanelUsers = new TableLayoutPanel();
            lblAdministrators = new Label();
            lblLabAssistants = new Label();
            lblViewers = new Label();
            flowLayoutPanelAdministrators = new FlowLayoutPanel();
            flowLayoutPanelLabAssistants = new FlowLayoutPanel();
            flowLayoutPanelViewers = new FlowLayoutPanel();
            tableLayoutPanelUsers.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelUsers
            // 
            tableLayoutPanelUsers.ColumnCount = 3;
            tableLayoutPanelUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUsers.Controls.Add(lblAdministrators, 0, 0);
            tableLayoutPanelUsers.Controls.Add(lblLabAssistants, 1, 0);
            tableLayoutPanelUsers.Controls.Add(lblViewers, 2, 0);
            tableLayoutPanelUsers.Controls.Add(flowLayoutPanelAdministrators, 0, 1);
            tableLayoutPanelUsers.Controls.Add(flowLayoutPanelLabAssistants, 1, 1);
            tableLayoutPanelUsers.Controls.Add(flowLayoutPanelViewers, 2, 1);
            tableLayoutPanelUsers.Dock = DockStyle.Fill;
            tableLayoutPanelUsers.Location = new Point(0, 0);
            tableLayoutPanelUsers.Name = "tableLayoutPanelUsers";
            tableLayoutPanelUsers.RowCount = 2;
            tableLayoutPanelUsers.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelUsers.Size = new Size(700, 400);
            tableLayoutPanelUsers.TabIndex = 0;
            // 
            // lblAdministrators
            // 
            lblAdministrators.Dock = DockStyle.Fill;
            lblAdministrators.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdministrators.Location = new Point(3, 0);
            lblAdministrators.Name = "lblAdministrators";
            lblAdministrators.Size = new Size(227, 32);
            lblAdministrators.TabIndex = 0;
            lblAdministrators.Text = "Administrators";
            lblAdministrators.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLabAssistants
            // 
            lblLabAssistants.Dock = DockStyle.Fill;
            lblLabAssistants.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLabAssistants.Location = new Point(236, 0);
            lblLabAssistants.Name = "lblLabAssistants";
            lblLabAssistants.Size = new Size(227, 32);
            lblLabAssistants.TabIndex = 1;
            lblLabAssistants.Text = "Lab Assistants";
            lblLabAssistants.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblViewers
            // 
            lblViewers.Dock = DockStyle.Fill;
            lblViewers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblViewers.Location = new Point(469, 0);
            lblViewers.Name = "lblViewers";
            lblViewers.Size = new Size(228, 32);
            lblViewers.TabIndex = 2;
            lblViewers.Text = "Viewers";
            lblViewers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelAdministrators
            // 
            flowLayoutPanelAdministrators.AutoScroll = true;
            flowLayoutPanelAdministrators.Dock = DockStyle.Fill;
            flowLayoutPanelAdministrators.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelAdministrators.Location = new Point(3, 35);
            flowLayoutPanelAdministrators.Name = "flowLayoutPanelAdministrators";
            flowLayoutPanelAdministrators.Padding = new Padding(6);
            flowLayoutPanelAdministrators.Size = new Size(227, 362);
            flowLayoutPanelAdministrators.TabIndex = 3;
            flowLayoutPanelAdministrators.WrapContents = false;
            // 
            // flowLayoutPanelLabAssistants
            // 
            flowLayoutPanelLabAssistants.AutoScroll = true;
            flowLayoutPanelLabAssistants.Dock = DockStyle.Fill;
            flowLayoutPanelLabAssistants.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelLabAssistants.Location = new Point(236, 35);
            flowLayoutPanelLabAssistants.Name = "flowLayoutPanelLabAssistants";
            flowLayoutPanelLabAssistants.Padding = new Padding(6);
            flowLayoutPanelLabAssistants.Size = new Size(227, 362);
            flowLayoutPanelLabAssistants.TabIndex = 4;
            flowLayoutPanelLabAssistants.WrapContents = false;
            // 
            // flowLayoutPanelViewers
            // 
            flowLayoutPanelViewers.AutoScroll = true;
            flowLayoutPanelViewers.Dock = DockStyle.Fill;
            flowLayoutPanelViewers.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelViewers.Location = new Point(469, 35);
            flowLayoutPanelViewers.Name = "flowLayoutPanelViewers";
            flowLayoutPanelViewers.Padding = new Padding(6);
            flowLayoutPanelViewers.Size = new Size(228, 362);
            flowLayoutPanelViewers.TabIndex = 5;
            flowLayoutPanelViewers.WrapContents = false;
            // 
            // UsersMain
            // 
            Controls.Add(tableLayoutPanelUsers);
            Name = "UsersMain";
            Size = new Size(700, 400);
            tableLayoutPanelUsers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
