namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class AddDamageReportDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox Asset_cbox;
        private System.Windows.Forms.ComboBox ReportedBy_cbox;
        private System.Windows.Forms.TextBox Description_txt;
        private System.Windows.Forms.DateTimePicker Date_pick;
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
            ReportedBy_cbox = new ComboBox();
            Description_txt = new TextBox();
            Date_pick = new DateTimePicker();
            Save_btn = new Button();
            Cancel_btn = new Button();
            labelAsset = new Label();
            labelReported = new Label();
            labelDesc = new Label();
            labelDate = new Label();
            repairedBy_cbox = new ComboBox();
            loan_cbox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Asset_cbox
            // 
            Asset_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            Asset_cbox.Font = new Font("Segoe UI", 11F);
            Asset_cbox.FormattingEnabled = true;
            Asset_cbox.Location = new Point(12, 32);
            Asset_cbox.Name = "Asset_cbox";
            Asset_cbox.Size = new Size(179, 33);
            Asset_cbox.TabIndex = 0;
            // 
            // ReportedBy_cbox
            // 
            ReportedBy_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            ReportedBy_cbox.Font = new Font("Segoe UI", 11F);
            ReportedBy_cbox.FormattingEnabled = true;
            ReportedBy_cbox.Location = new Point(12, 95);
            ReportedBy_cbox.Name = "ReportedBy_cbox";
            ReportedBy_cbox.Size = new Size(179, 33);
            ReportedBy_cbox.TabIndex = 1;
            // 
            // Description_txt
            // 
            Description_txt.Location = new Point(12, 158);
            Description_txt.Multiline = true;
            Description_txt.Name = "Description_txt";
            Description_txt.Size = new Size(378, 100);
            Description_txt.TabIndex = 2;
            // 
            // Date_pick
            // 
            Date_pick.Location = new Point(160, 264);
            Date_pick.Name = "Date_pick";
            Date_pick.Size = new Size(230, 27);
            Date_pick.TabIndex = 3;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(12, 297);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 30);
            Save_btn.TabIndex = 4;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(315, 297);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(75, 30);
            Cancel_btn.TabIndex = 5;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // labelAsset
            // 
            labelAsset.AutoSize = true;
            labelAsset.Font = new Font("Segoe UI", 11F);
            labelAsset.Location = new Point(12, 4);
            labelAsset.Name = "labelAsset";
            labelAsset.Size = new Size(60, 25);
            labelAsset.TabIndex = 0;
            labelAsset.Text = "Asset:";
            // 
            // labelReported
            // 
            labelReported.AutoSize = true;
            labelReported.Font = new Font("Segoe UI", 11F);
            labelReported.Location = new Point(12, 68);
            labelReported.Name = "labelReported";
            labelReported.Size = new Size(117, 25);
            labelReported.TabIndex = 1;
            labelReported.Text = "Reported by:";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Segoe UI", 11F);
            labelDesc.Location = new Point(12, 130);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(112, 25);
            labelDesc.TabIndex = 2;
            labelDesc.Text = "Description:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 11F);
            labelDate.Location = new Point(12, 264);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(133, 25);
            labelDate.TabIndex = 3;
            labelDate.Text = "Date reported:";
            // 
            // repairedBy_cbox
            // 
            repairedBy_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            repairedBy_cbox.Font = new Font("Segoe UI", 11F);
            repairedBy_cbox.FormattingEnabled = true;
            repairedBy_cbox.Location = new Point(211, 95);
            repairedBy_cbox.Name = "repairedBy_cbox";
            repairedBy_cbox.Size = new Size(179, 33);
            repairedBy_cbox.TabIndex = 6;
            // 
            // loan_cbox
            // 
            loan_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            loan_cbox.Font = new Font("Segoe UI", 11F);
            loan_cbox.FormattingEnabled = true;
            loan_cbox.Location = new Point(211, 32);
            loan_cbox.Name = "loan_cbox";
            loan_cbox.Size = new Size(179, 33);
            loan_cbox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(197, 67);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 8;
            label1.Text = "Repaired by (optional):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(211, 4);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 9;
            label2.Text = "Loan (optional):";
            // 
            // AddDamageReportDialog
            // 
            ClientSize = new Size(402, 339);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loan_cbox);
            Controls.Add(repairedBy_cbox);
            Controls.Add(labelAsset);
            Controls.Add(labelReported);
            Controls.Add(labelDesc);
            Controls.Add(labelDate);
            Controls.Add(Cancel_btn);
            Controls.Add(Save_btn);
            Controls.Add(Date_pick);
            Controls.Add(Description_txt);
            Controls.Add(ReportedBy_cbox);
            Controls.Add(Asset_cbox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddDamageReportDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAsset;
        private Label labelReported;
        private Label labelDesc;
        private Label labelDate;
        private ComboBox repairedBy_cbox;
        private ComboBox comboBox1;
        private ComboBox loan_cbox;
        private Label label1;
        private Label label2;
    }
}
