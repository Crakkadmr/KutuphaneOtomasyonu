namespace KutuphaneOtomasyonu
{
    partial class oduncVerAl
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
            label5 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 52);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 1;
            label2.Text = "Üye Kimlik No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 83);
            label3.Name = "label3";
            label3.Size = new Size(87, 17);
            label3.TabIndex = 2;
            label3.Text = "Veriliş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 114);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 3;
            label4.Text = "Teslim Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 145);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 4;
            label5.Text = "Açıklama";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 356);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teslim Edilmeyen Kitaplar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(601, 332);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(432, 12);
            button1.Name = "button1";
            button1.Size = new Size(151, 73);
            button1.TabIndex = 1;
            button1.Text = "Ödünç Ver";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(432, 91);
            button2.Name = "button2";
            button2.Size = new Size(151, 71);
            button2.TabIndex = 2;
            button2.Text = "Teslim Al";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 25);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 25);
            textBox2.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(119, 74);
            maskedTextBox1.Mask = "00/00/0000 90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(283, 25);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(119, 106);
            maskedTextBox2.Mask = "00/00/0000 90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(283, 25);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 154);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 103);
            textBox3.TabIndex = 8;
            // 
            // oduncVerAl
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 616);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(groupBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Name = "oduncVerAl";
            Text = "oduncVerAl";
            Load += oduncVerAl_Load;
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox3;
    }
}