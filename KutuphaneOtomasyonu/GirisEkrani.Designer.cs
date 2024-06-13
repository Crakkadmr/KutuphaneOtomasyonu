namespace KutuphaneOtomasyonu
{
    partial class GirisEkrani
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
            Button2 = new Button();
            Button1 = new Button();
            label2 = new Label();
            Textbox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            Textbox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Button2
            // 
            Button2.BackColor = Color.White;
            Button2.Cursor = Cursors.Hand;
            Button2.FlatAppearance.BorderSize = 2;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.ForeColor = Color.FromArgb(128, 128, 255);
            Button2.Location = new Point(38, 267);
            Button2.Name = "Button2";
            Button2.Size = new Size(218, 28);
            Button2.TabIndex = 4;
            Button2.Text = "Çıkış";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += Button2_Click;
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(128, 128, 255);
            Button1.Cursor = Cursors.Hand;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(38, 224);
            Button1.Name = "Button1";
            Button1.Size = new Size(218, 28);
            Button1.TabIndex = 3;
            Button1.Text = "Giriş Yap";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 148);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 8;
            label2.Text = "Şifre";
            // 
            // Textbox1
            // 
            Textbox1.BackColor = Color.FromArgb(230, 231, 233);
            Textbox1.BorderStyle = BorderStyle.None;
            Textbox1.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox1.ForeColor = SystemColors.WindowText;
            Textbox1.Location = new Point(38, 107);
            Textbox1.Multiline = true;
            Textbox1.Name = "Textbox1";
            Textbox1.Size = new Size(218, 28);
            Textbox1.TabIndex = 0;
            Textbox1.Text = "Kadocan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(38, 87);
            label1.Name = "label1";
            label1.Size = new Size(184, 17);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Adı Veya Kimlik No";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(62, 9);
            label3.Name = "label3";
            label3.Size = new Size(169, 27);
            label3.TabIndex = 6;
            label3.Text = "KD Company";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Textbox2
            // 
            Textbox2.BackColor = Color.FromArgb(230, 231, 233);
            Textbox2.BorderStyle = BorderStyle.None;
            Textbox2.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox2.Location = new Point(38, 168);
            Textbox2.Multiline = true;
            Textbox2.Name = "Textbox2";
            Textbox2.PasswordChar = '*';
            Textbox2.Size = new Size(218, 28);
            Textbox2.TabIndex = 1;
            Textbox2.Text = "245381";
            Textbox2.KeyDown += Textbox2_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(1, 36);
            label4.Name = "label4";
            label4.Size = new Size(303, 27);
            label4.TabIndex = 10;
            label4.Text = "Kütüphane Otomasyonu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 326);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1, 374);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 12;
            label6.Text = "Kayıt Ol";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(219, 374);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 13;
            label7.Text = "Üye Girişi";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(100, 63);
            label8.Name = "label8";
            label8.Size = new Size(87, 17);
            label8.TabIndex = 14;
            label8.Text = "Admin Girişi";
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 400);
            ControlBox = false;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Textbox2);
            Controls.Add(label2);
            Controls.Add(Textbox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Textbox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
