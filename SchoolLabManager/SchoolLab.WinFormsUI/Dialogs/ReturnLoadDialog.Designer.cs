namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class ReturnLoadDialog
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
            Title_lbl = new Label();
            User_lbl = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            Cancel_btn = new Button();
            Save_btn = new Button();
            SuspendLayout();
            // 
            // Title_lbl
            // 
            Title_lbl.AutoSize = true;
            Title_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title_lbl.Location = new Point(12, 9);
            Title_lbl.Name = "Title_lbl";
            Title_lbl.Size = new Size(111, 21);
            Title_lbl.TabIndex = 0;
            Title_lbl.Text = "ITEM, NUmber";
            // 
            // User_lbl
            // 
            User_lbl.AutoSize = true;
            User_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_lbl.Location = new Point(12, 41);
            User_lbl.Name = "User_lbl";
            User_lbl.Size = new Size(111, 21);
            User_lbl.TabIndex = 1;
            User_lbl.Text = "User Borrower";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 5;
            label4.Text = "Return Condition:";
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(12, 125);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(75, 30);
            Cancel_btn.TabIndex = 9;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(93, 125);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 30);
            Save_btn.TabIndex = 10;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click_1;
            // 
            // ReturnLoadDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 173);
            Controls.Add(Save_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(User_lbl);
            Controls.Add(Title_lbl);
            Name = "ReturnLoadDialog";
            Text = "ReturnLoadDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_lbl;
        private Label User_lbl;
        private ComboBox comboBox1;
        private Label label4;
        private Button Cancel_btn;
        private Button Save_btn;
    }
}