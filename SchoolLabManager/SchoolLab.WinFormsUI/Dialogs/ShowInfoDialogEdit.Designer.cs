namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class ShowInfoDialogEdit
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
            Info_lbl = new Label();
            Save_btn = new Button();
            Cancel_btn = new Button();
            label5 = new Label();
            label4 = new Label();
            Category_cbox = new ComboBox();
            Location_cbox = new ComboBox();
            label1 = new Label();
            condition_cbox = new ComboBox();
            label2 = new Label();
            status_cbox = new ComboBox();
            SuspendLayout();
            // 
            // Info_lbl
            // 
            Info_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Info_lbl.Location = new Point(14, 12);
            Info_lbl.Name = "Info_lbl";
            Info_lbl.Size = new Size(297, 157);
            Info_lbl.TabIndex = 1;
            Info_lbl.Text = "label1";
            // 
            // Save_btn
            // 
            Save_btn.AutoSize = true;
            Save_btn.BackColor = SystemColors.InactiveCaption;
            Save_btn.DialogResult = DialogResult.OK;
            Save_btn.Font = new Font("Segoe UI", 13F);
            Save_btn.Location = new Point(225, 397);
            Save_btn.Margin = new Padding(3, 4, 3, 4);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(86, 47);
            Save_btn.TabIndex = 13;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = false;
            // 
            // Cancel_btn
            // 
            Cancel_btn.AutoSize = true;
            Cancel_btn.BackColor = SystemColors.InactiveCaption;
            Cancel_btn.DialogResult = DialogResult.Cancel;
            Cancel_btn.Font = new Font("Segoe UI", 13F);
            Cancel_btn.Location = new Point(14, 397);
            Cancel_btn.Margin = new Padding(3, 4, 3, 4);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(87, 47);
            Cancel_btn.TabIndex = 12;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(6, 341);
            label5.Name = "label5";
            label5.Size = new Size(169, 30);
            label5.TabIndex = 17;
            label5.Text = "Stored Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(6, 288);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 16;
            label4.Text = "Category:";
            // 
            // Category_cbox
            // 
            Category_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            Category_cbox.Font = new Font("Segoe UI", 13F);
            Category_cbox.FormattingEnabled = true;
            Category_cbox.Location = new Point(178, 280);
            Category_cbox.Margin = new Padding(3, 4, 3, 4);
            Category_cbox.Name = "Category_cbox";
            Category_cbox.Size = new Size(138, 38);
            Category_cbox.TabIndex = 15;
            // 
            // Location_cbox
            // 
            Location_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            Location_cbox.Font = new Font("Segoe UI", 13F);
            Location_cbox.FormattingEnabled = true;
            Location_cbox.Location = new Point(178, 333);
            Location_cbox.Margin = new Padding(3, 4, 3, 4);
            Location_cbox.Name = "Location_cbox";
            Location_cbox.Size = new Size(138, 38);
            Location_cbox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(6, 181);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 19;
            label1.Text = "Condition:";
            // 
            // condition_cbox
            // 
            condition_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            condition_cbox.Font = new Font("Segoe UI", 13F);
            condition_cbox.FormattingEnabled = true;
            condition_cbox.Location = new Point(178, 181);
            condition_cbox.Margin = new Padding(3, 4, 3, 4);
            condition_cbox.Name = "condition_cbox";
            condition_cbox.Size = new Size(138, 38);
            condition_cbox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(6, 231);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 21;
            label2.Text = "Status:";
            // 
            // status_cbox
            // 
            status_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
            status_cbox.Font = new Font("Segoe UI", 13F);
            status_cbox.FormattingEnabled = true;
            status_cbox.Location = new Point(178, 231);
            status_cbox.Margin = new Padding(3, 4, 3, 4);
            status_cbox.Name = "status_cbox";
            status_cbox.Size = new Size(138, 38);
            status_cbox.TabIndex = 20;
            // 
            // ShowInfoDialogEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(325, 457);
            Controls.Add(label2);
            Controls.Add(status_cbox);
            Controls.Add(label1);
            Controls.Add(condition_cbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Category_cbox);
            Controls.Add(Location_cbox);
            Controls.Add(Save_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(Info_lbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowInfoDialogEdit";
            Text = "ShowInfoDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Info_lbl;
        private Button Save_btn;
        private Button Cancel_btn;
        private Label label5;
        private Label label4;
        private ComboBox Category_cbox;
        private ComboBox Location_cbox;
        private Label label1;
        private ComboBox condition_cbox;
        private Label label2;
        private ComboBox status_cbox;
    }
}