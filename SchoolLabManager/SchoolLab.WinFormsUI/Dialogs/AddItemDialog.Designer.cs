namespace SchoolLab.WinFormsUI.Dialogs
{
    partial class AddItemDialog
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
            Name_txt = new TextBox();
            Serial_txt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PurchaseDate_pick = new DateTimePicker();
            Location_cbox = new ComboBox();
            Category_cbox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            Cancel_btn = new Button();
            Save_btn = new Button();
            Description_txt = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Asset Name:";
            // 
            // Name_txt
            // 
            Name_txt.Font = new Font("Segoe UI", 13F);
            Name_txt.Location = new Point(124, 6);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(148, 31);
            Name_txt.TabIndex = 1;
            // 
            // Serial_txt
            // 
            Serial_txt.Font = new Font("Segoe UI", 13F);
            Serial_txt.Location = new Point(140, 47);
            Serial_txt.Name = "Serial_txt";
            Serial_txt.Size = new Size(132, 31);
            Serial_txt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "Serial Number: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 4;
            label3.Text = "Purchase Date:";
            // 
            // PurchaseDate_pick
            // 
            PurchaseDate_pick.Location = new Point(140, 92);
            PurchaseDate_pick.Name = "PurchaseDate_pick";
            PurchaseDate_pick.Size = new Size(132, 23);
            PurchaseDate_pick.TabIndex = 5;
            // 
            // Location_cbox
            // 
            Location_cbox.Font = new Font("Segoe UI", 13F);
            Location_cbox.FormattingEnabled = true;
            Location_cbox.Location = new Point(149, 168);
            Location_cbox.Name = "Location_cbox";
            Location_cbox.Size = new Size(121, 31);
            Location_cbox.TabIndex = 6;
            // 
            // Category_cbox
            // 
            Category_cbox.Font = new Font("Segoe UI", 13F);
            Category_cbox.FormattingEnabled = true;
            Category_cbox.Location = new Point(149, 128);
            Category_cbox.Name = "Category_cbox";
            Category_cbox.Size = new Size(121, 31);
            Category_cbox.TabIndex = 7;
            Category_cbox.SelectedIndexChanged += Category_cbox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(3, 128);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 8;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(3, 174);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 9;
            label5.Text = "Stored Location:";
            // 
            // Cancel_btn
            // 
            Cancel_btn.AutoSize = true;
            Cancel_btn.DialogResult = DialogResult.Cancel;
            Cancel_btn.Font = new Font("Segoe UI", 13F);
            Cancel_btn.Location = new Point(12, 218);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(75, 35);
            Cancel_btn.TabIndex = 10;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            Save_btn.AutoSize = true;
            Save_btn.DialogResult = DialogResult.OK;
            Save_btn.Font = new Font("Segoe UI", 13F);
            Save_btn.Location = new Point(197, 218);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 35);
            Save_btn.TabIndex = 11;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Description_txt
            // 
            Description_txt.Font = new Font("Segoe UI", 13F);
            Description_txt.Location = new Point(292, 47);
            Description_txt.Multiline = true;
            Description_txt.Name = "Description_txt";
            Description_txt.Size = new Size(261, 206);
            Description_txt.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(292, 12);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 13;
            label6.Text = "Description:";
            // 
            // AddItemDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 261);
            Controls.Add(label6);
            Controls.Add(Description_txt);
            Controls.Add(Save_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Category_cbox);
            Controls.Add(Location_cbox);
            Controls.Add(PurchaseDate_pick);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Serial_txt);
            Controls.Add(Name_txt);
            Controls.Add(label1);
            Name = "AddItemDialog";
            Text = "Add Item";
            Load += AddItemDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Name_txt;
        private TextBox Serial_txt;
        private Label label2;
        private Label label3;
        private DateTimePicker PurchaseDate_pick;
        private ComboBox Location_cbox;
        private ComboBox Category_cbox;
        private Label label4;
        private Label label5;
        private Button Cancel_btn;
        private Button Save_btn;
        private TextBox Description_txt;
        private Label label6;
    }
}