namespace ProtonPulse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            Insert = new Button();
            dataGridView1 = new DataGridView();
            update = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Bold);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(451, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 66);
            label1.TabIndex = 0;
            label1.Text = "ProtonPulse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(63, 152);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(66, 211);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(66, 268);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 3;
            label4.Text = "Design";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(66, 326);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Color";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(237, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 36);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(237, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 36);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(237, 266);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 34);
            textBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "White", "Black" });
            comboBox1.Location = new Point(237, 324);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(296, 38);
            comboBox1.TabIndex = 10;
            // 
            // Insert
            // 
            Insert.BackColor = Color.PaleTurquoise;
            Insert.Font = new Font("Segoe UI", 14F);
            Insert.ForeColor = SystemColors.InactiveCaptionText;
            Insert.Location = new Point(66, 431);
            Insert.Name = "Insert";
            Insert.Size = new Size(126, 48);
            Insert.TabIndex = 11;
            Insert.Text = "SAVE";
            Insert.UseVisualStyleBackColor = false;
            Insert.Click += Insert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(554, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(544, 365);
            dataGridView1.TabIndex = 12;
            dataGridView1.UseWaitCursor = true;
            // 
            // update
            // 
            update.BackColor = Color.Thistle;
            update.Font = new Font("Segoe UI", 14F);
            update.ForeColor = SystemColors.InactiveCaptionText;
            update.Location = new Point(207, 431);
            update.Name = "update";
            update.Size = new Size(126, 48);
            update.TabIndex = 13;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(66, 381);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 14;
            label6.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13F);
            textBox4.Location = new Point(237, 377);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 36);
            textBox4.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1192, 640);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(update);
            Controls.Add(dataGridView1);
            Controls.Add(Insert);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button Insert;
        private DataGridView dataGridView1;
        private Button update;
        private Label label6;
        private TextBox textBox4;
    }
}
