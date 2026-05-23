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
            this.Asset_cbox = new System.Windows.Forms.ComboBox();
            this.ReportedBy_cbox = new System.Windows.Forms.ComboBox();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.Date_pick = new System.Windows.Forms.DateTimePicker();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Asset_cbox
            // 
            this.Asset_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Asset_cbox.FormattingEnabled = true;
            this.Asset_cbox.Location = new System.Drawing.Point(12, 12);
            this.Asset_cbox.Name = "Asset_cbox";
            this.Asset_cbox.Size = new System.Drawing.Size(360, 24);
            this.Asset_cbox.TabIndex = 0;
            // labelAsset
            var labelAsset = new System.Windows.Forms.Label();
            labelAsset.AutoSize = true;
            labelAsset.Location = new System.Drawing.Point(12, -2);
            labelAsset.Name = "labelAsset";
            labelAsset.Size = new System.Drawing.Size(44, 17);
            labelAsset.Text = "Asset:";
            this.Controls.Add(labelAsset);
            // 
            // ReportedBy_cbox
            // 
            this.ReportedBy_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportedBy_cbox.FormattingEnabled = true;
            this.ReportedBy_cbox.Location = new System.Drawing.Point(12, 42);
            this.ReportedBy_cbox.Name = "ReportedBy_cbox";
            this.ReportedBy_cbox.Size = new System.Drawing.Size(360, 24);
            this.ReportedBy_cbox.TabIndex = 1;
            // labelReportedBy
            var labelReported = new System.Windows.Forms.Label();
            labelReported.AutoSize = true;
            labelReported.Location = new System.Drawing.Point(12, 26);
            labelReported.Name = "labelReportedBy";
            labelReported.Size = new System.Drawing.Size(78, 17);
            labelReported.Text = "Reported by:";
            this.Controls.Add(labelReported);
            // 
            // Description_txt
            // 
            this.Description_txt.Location = new System.Drawing.Point(12, 72);
            this.Description_txt.Multiline = true;
            this.Description_txt.Name = "Description_txt";
            this.Description_txt.Size = new System.Drawing.Size(360, 100);
            this.Description_txt.TabIndex = 2;
            // labelDescription
            var labelDesc = new System.Windows.Forms.Label();
            labelDesc.AutoSize = true;
            labelDesc.Location = new System.Drawing.Point(12, 56);
            labelDesc.Name = "labelDescription";
            labelDesc.Size = new System.Drawing.Size(83, 17);
            labelDesc.Text = "Description:";
            this.Controls.Add(labelDesc);
            // 
            // Date_pick
            // 
            this.Date_pick.Location = new System.Drawing.Point(12, 178);
            this.Date_pick.Name = "Date_pick";
            this.Date_pick.Size = new System.Drawing.Size(360, 22);
            this.Date_pick.TabIndex = 3;
            // labelDate
            var labelDate = new System.Windows.Forms.Label();
            labelDate.AutoSize = true;
            labelDate.Location = new System.Drawing.Point(12, 162);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(90, 17);
            labelDate.Text = "Date reported:";
            this.Controls.Add(labelDate);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(12, 206);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 30);
            this.Save_btn.TabIndex = 4;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(297, 206);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 30);
            this.Cancel_btn.TabIndex = 5;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // AddDamageReportDialog
            // 
            this.ClientSize = new System.Drawing.Size(384, 248);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Date_pick);
            this.Controls.Add(this.Description_txt);
            this.Controls.Add(this.ReportedBy_cbox);
            this.Controls.Add(this.Asset_cbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDamageReportDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
