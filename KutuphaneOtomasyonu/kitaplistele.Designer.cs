namespace KutuphaneOtomasyonu
{
    partial class Kitaplistele
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            özetiGösterToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Ara";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(546, 24);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(104, 23);
            textBox2.TabIndex = 14;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Logo_CSV_svg_90x90;
            button2.Location = new Point(479, 123);
            button2.Name = "button2";
            button2.Size = new Size(89, 90);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 12;
            label1.Text = "Alan Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 182);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 25);
            comboBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(12, 123);
            button1.Name = "button1";
            button1.Size = new Size(443, 47);
            button1.TabIndex = 6;
            button1.Text = "Bütün Kitapları Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 25);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 51);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 3;
            label2.Text = "Aranacak Veri";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(721, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.AccessibleDescription = "";
            contextMenuStrip1.AccessibleName = "";
            contextMenuStrip1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem, silToolStripMenuItem, özetiGösterToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(157, 70);
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(156, 22);
            düzenleToolStripMenuItem.Text = "Düzenle";
            düzenleToolStripMenuItem.Click += düzenleToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(156, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // özetiGösterToolStripMenuItem
            // 
            özetiGösterToolStripMenuItem.Name = "özetiGösterToolStripMenuItem";
            özetiGösterToolStripMenuItem.Size = new Size(156, 22);
            özetiGösterToolStripMenuItem.Text = "Özeti  Göster";
            özetiGösterToolStripMenuItem.Click += özetiGösterToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(997, 315);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Kitaplistele
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 553);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            Name = "Kitaplistele";
            Text = "kitaplistele";
            Activated += Kitaplistele_Activated;
            Load += Kitaplistele_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem özetiGösterToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
    }
}