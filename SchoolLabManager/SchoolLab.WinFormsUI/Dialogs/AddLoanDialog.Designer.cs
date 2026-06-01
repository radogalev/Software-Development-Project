namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class AddLoanDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox Asset_cbox;
        private System.Windows.Forms.ComboBox Borrower_cbox;
        private System.Windows.Forms.DateTimePicker DueDate_pick;
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
            Asset_cbox = new ComboBox();
            Borrower_cbox = new ComboBox();
            DueDate_pick = new DateTimePicker();
            Save_btn = new Button();
            Cancel_btn = new Button();
            labelAsset = new Label();
            labelBorrower = new Label();
            labelDue = new Label();
            SuspendLayout();
            // 
            // Asset_cbox
            // 
            Asset_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            Asset_cbox.FormattingEnabled = true;
            Asset_cbox.Location = new Point(12, 32);
            Asset_cbox.Name = "Asset_cbox";
            Asset_cbox.Size = new Size(260, 28);
            Asset_cbox.TabIndex = 0;
            // 
            // Borrower_cbox
            // 
            Borrower_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            Borrower_cbox.FormattingEnabled = true;
            Borrower_cbox.Location = new Point(9, 93);
            Borrower_cbox.Name = "Borrower_cbox";
            Borrower_cbox.Size = new Size(260, 28);
            Borrower_cbox.TabIndex = 1;
            // 
            // DueDate_pick
            // 
            DueDate_pick.Location = new Point(9, 147);
            DueDate_pick.Name = "DueDate_pick";
            DueDate_pick.Size = new Size(260, 27);
            DueDate_pick.TabIndex = 2;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(197, 180);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 30);
            Save_btn.TabIndex = 3;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(9, 180);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(75, 30);
            Cancel_btn.TabIndex = 4;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // labelAsset
            // 
            labelAsset.AutoSize = true;
            labelAsset.Location = new Point(11, 9);
            labelAsset.Name = "labelAsset";
            labelAsset.Size = new Size(47, 20);
            labelAsset.TabIndex = 0;
            labelAsset.Text = "Asset:";
            // 
            // labelBorrower
            // 
            labelBorrower.AutoSize = true;
            labelBorrower.Location = new Point(12, 70);
            labelBorrower.Name = "labelBorrower";
            labelBorrower.Size = new Size(73, 20);
            labelBorrower.TabIndex = 1;
            labelBorrower.Text = "Borrower:";
            // 
            // labelDue
            // 
            labelDue.AutoSize = true;
            labelDue.Location = new Point(9, 124);
            labelDue.Name = "labelDue";
            labelDue.Size = new Size(73, 20);
            labelDue.TabIndex = 2;
            labelDue.Text = "Due date:";
            // 
            // AddLoanDialog
            // 
            ClientSize = new Size(283, 222);
            Controls.Add(labelAsset);
            Controls.Add(labelBorrower);
            Controls.Add(labelDue);
            Controls.Add(Cancel_btn);
            Controls.Add(Save_btn);
            Controls.Add(DueDate_pick);
            Controls.Add(Borrower_cbox);
            Controls.Add(Asset_cbox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddLoanDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAsset;
        private Label labelBorrower;
        private Label labelDue;
    }
}
