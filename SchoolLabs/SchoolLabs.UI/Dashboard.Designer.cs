namespace SchoolLabs.UI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            Asetname = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(242, 47);
            label1.Name = "label1";
            label1.Size = new Size(131, 33);
            label1.TabIndex = 0;
            label1.Text = "Welcome, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "username";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(277, 105);
            label3.Name = "label3";
            label3.Size = new Size(197, 30);
            label3.TabIndex = 2;
            label3.Text = "Role: Administrator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 512);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(115, 176);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 4;
            button1.Text = "Assets";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(267, 176);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 5;
            button2.Text = "Loans";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(404, 176);
            button3.Name = "button3";
            button3.Size = new Size(102, 38);
            button3.TabIndex = 6;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(563, 176);
            button4.Name = "button4";
            button4.Size = new Size(101, 38);
            button4.TabIndex = 7;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Asetname });
            dataGridView1.Location = new Point(115, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 239);
            dataGridView1.TabIndex = 8;
            // 
            // Asetname
            // 
            Asetname.HeaderText = "Column1";
            Asetname.Name = "Asetname";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 628);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Form1";
            Load += this.Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Asetname;
    }
}