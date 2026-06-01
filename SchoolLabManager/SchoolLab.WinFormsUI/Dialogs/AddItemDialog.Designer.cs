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
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 0;
            label1.Text = "Asset Name:";
            // 
            // Name_txt
            // 
            Name_txt.Font = new Font("Segoe UI", 13F);
            Name_txt.Location = new Point(153, 6);
            Name_txt.Margin = new Padding(3, 4, 3, 4);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(169, 36);
            Name_txt.TabIndex = 1;
            // 
            // Serial_txt
            // 
            Serial_txt.Font = new Font("Segoe UI", 13F);
            Serial_txt.Location = new Point(172, 64);
            Serial_txt.Margin = new Padding(3, 4, 3, 4);
            Serial_txt.Name = "Serial_txt";
            Serial_txt.Size = new Size(150, 36);
            Serial_txt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(163, 30);
            label2.TabIndex = 3;
            label2.Text = "Serial Number: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(3, 120);
            label3.Name = "label3";
            label3.Size = new Size(155, 30);
            label3.TabIndex = 4;
            label3.Text = "Purchase Date:";
            // 
            // PurchaseDate_pick
            // 
            PurchaseDate_pick.Location = new Point(172, 123);
            PurchaseDate_pick.Margin = new Padding(3, 4, 3, 4);
            PurchaseDate_pick.Name = "PurchaseDate_pick";
            PurchaseDate_pick.Size = new Size(150, 27);
            PurchaseDate_pick.TabIndex = 5;
            // 
            // Location_cbox
            // 
            Location_cbox.Font = new Font("Segoe UI", 13F);
            Location_cbox.FormattingEnabled = true;
            Location_cbox.Location = new Point(184, 224);
            Location_cbox.Margin = new Padding(3, 4, 3, 4);
            Location_cbox.Name = "Location_cbox";
            Location_cbox.Size = new Size(138, 38);
            Location_cbox.TabIndex = 6;
            // 
            // Category_cbox
            // 
            Category_cbox.Font = new Font("Segoe UI", 13F);
            Category_cbox.FormattingEnabled = true;
            Category_cbox.Location = new Point(184, 171);
            Category_cbox.Margin = new Padding(3, 4, 3, 4);
            Category_cbox.Name = "Category_cbox";
            Category_cbox.Size = new Size(138, 38);
            Category_cbox.TabIndex = 7;
            Category_cbox.SelectedIndexChanged += Category_cbox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(3, 171);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 8;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(3, 232);
            label5.Name = "label5";
            label5.Size = new Size(169, 30);
            label5.TabIndex = 9;
            label5.Text = "Stored Location:";
            // 
            // Cancel_btn
            // 
            Cancel_btn.AutoSize = true;
            Cancel_btn.DialogResult = DialogResult.Cancel;
            Cancel_btn.Font = new Font("Segoe UI", 13F);
            Cancel_btn.Location = new Point(14, 291);
            Cancel_btn.Margin = new Padding(3, 4, 3, 4);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(87, 47);
            Cancel_btn.TabIndex = 10;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Save_btn
            // 
            Save_btn.AutoSize = true;
            Save_btn.DialogResult = DialogResult.OK;
            Save_btn.Font = new Font("Segoe UI", 13F);
            Save_btn.Location = new Point(225, 291);
            Save_btn.Margin = new Padding(3, 4, 3, 4);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(86, 47);
            Save_btn.TabIndex = 11;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Description_txt
            // 
            Description_txt.Font = new Font("Segoe UI", 13F);
            Description_txt.Location = new Point(380, 61);
            Description_txt.Margin = new Padding(3, 4, 3, 4);
            Description_txt.Multiline = true;
            Description_txt.Name = "Description_txt";
            Description_txt.Size = new Size(298, 273);
            Description_txt.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(380, 14);
            label6.Name = "label6";
            label6.Size = new Size(127, 30);
            label6.TabIndex = 13;
            label6.Text = "Description:";
            label6.Click += label6_Click;
            // 
            // AddItemDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 348);
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
            Margin = new Padding(3, 4, 3, 4);
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