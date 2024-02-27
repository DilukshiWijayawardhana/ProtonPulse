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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            label7 = new Label();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Bold);
            label1.ForeColor = Color.Purple;
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
            label2.Location = new Point(46, 94);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(46, 149);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(46, 211);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 3;
            label4.Text = "Design";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(46, 270);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Color";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(237, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 36);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(237, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 36);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(237, 209);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(379, 34);
            textBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "White", "Black" });
            comboBox1.Location = new Point(237, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(379, 38);
            comboBox1.TabIndex = 10;
            // 
            // Insert
            // 
            Insert.BackColor = Color.FromArgb(128, 255, 255);
            Insert.Font = new Font("Segoe UI", 14F);
            Insert.ForeColor = SystemColors.InactiveCaptionText;
            Insert.Location = new Point(46, 570);
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
            dataGridView1.Location = new Point(95, 638);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1173, 390);
            dataGridView1.TabIndex = 12;
            dataGridView1.UseWaitCursor = true;
            // 
            // update
            // 
            update.BackColor = Color.Thistle;
            update.Font = new Font("Segoe UI", 14F);
            update.ForeColor = SystemColors.InactiveCaptionText;
            update.Location = new Point(202, 570);
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
            label6.Location = new Point(46, 385);
            label6.Name = "label6";
            label6.Size = new Size(121, 32);
            label6.TabIndex = 14;
            label6.Text = "Stock Size";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13F);
            textBox4.Location = new Point(237, 443);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(379, 36);
            textBox4.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(46, 330);
            label7.Name = "label7";
            label7.Size = new Size(64, 32);
            label7.TabIndex = 16;
            label7.Text = "Date";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(732, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 865);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13F);
            textBox5.Location = new Point(237, 381);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(379, 36);
            textBox5.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13F);
            dateTimePicker1.Font = new Font("Segoe UI", 13F);
            dateTimePicker1.Location = new Point(237, 326);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(379, 36);
            dateTimePicker1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(46, 447);
            label8.Name = "label8";
            label8.Size = new Size(191, 32);
            label8.TabIndex = 22;
            label8.Text = "Contact Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(46, 502);
            label9.Name = "label9";
            label9.Size = new Size(75, 32);
            label9.TabIndex = 23;
            label9.Text = "Gmail";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 13F);
            textBox6.Location = new Point(237, 498);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(379, 36);
            textBox6.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.InactiveCaptionText;
            button1.Location = new Point(490, 570);
            button1.Name = "button1";
            button1.Size = new Size(126, 48);
            button1.TabIndex = 25;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1313, 961);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(update);
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
            DoubleBuffered = true;
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "ProductManagementPage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private Button button1;
    }
}
