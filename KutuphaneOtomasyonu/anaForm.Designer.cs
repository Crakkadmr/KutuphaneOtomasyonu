namespace KutuphaneOtomasyonu
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            kitaplarToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleToolStripMenuItem = new ToolStripMenuItem();
            kitapAraDüzenleSilToolStripMenuItem = new ToolStripMenuItem();
            kitapTürleriToolStripMenuItem = new ToolStripMenuItem();
            ödünçVerToolStripMenuItem = new ToolStripMenuItem();
            üyelerToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 488);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(140, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kitaplarToolStripMenuItem, kitapTürleriToolStripMenuItem, ödünçVerToolStripMenuItem, üyelerToolStripMenuItem, raporlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            kitaplarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kitapEkleToolStripMenuItem, kitapAraDüzenleSilToolStripMenuItem });
            kitaplarToolStripMenuItem.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            kitaplarToolStripMenuItem.Size = new Size(68, 21);
            kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapEkleToolStripMenuItem
            // 
            kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            kitapEkleToolStripMenuItem.Size = new Size(210, 22);
            kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            kitapEkleToolStripMenuItem.Click += kitapEkleToolStripMenuItem_Click;
            // 
            // kitapAraDüzenleSilToolStripMenuItem
            // 
            kitapAraDüzenleSilToolStripMenuItem.Name = "kitapAraDüzenleSilToolStripMenuItem";
            kitapAraDüzenleSilToolStripMenuItem.Size = new Size(210, 22);
            kitapAraDüzenleSilToolStripMenuItem.Text = "Kitap Ara/Düzenle/Sil";
            kitapAraDüzenleSilToolStripMenuItem.Click += kitapAraDüzenleSilToolStripMenuItem_Click;
            // 
            // kitapTürleriToolStripMenuItem
            // 
            kitapTürleriToolStripMenuItem.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            kitapTürleriToolStripMenuItem.Name = "kitapTürleriToolStripMenuItem";
            kitapTürleriToolStripMenuItem.Size = new Size(96, 21);
            kitapTürleriToolStripMenuItem.Text = "Kitap Türleri";
            kitapTürleriToolStripMenuItem.Click += kitapTürleriToolStripMenuItem_Click;
            // 
            // ödünçVerToolStripMenuItem
            // 
            ödünçVerToolStripMenuItem.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            ödünçVerToolStripMenuItem.Name = "ödünçVerToolStripMenuItem";
            ödünçVerToolStripMenuItem.Size = new Size(60, 21);
            ödünçVerToolStripMenuItem.Text = "Ödünç";
            ödünçVerToolStripMenuItem.Click += ödünçVerToolStripMenuItem_Click;
            // 
            // üyelerToolStripMenuItem
            // 
            üyelerToolStripMenuItem.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            üyelerToolStripMenuItem.Size = new Size(59, 21);
            üyelerToolStripMenuItem.Text = "Üyeler";
            üyelerToolStripMenuItem.Click += üyelerToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(137, 21);
            raporlarToolStripMenuItem.Text = "Bilgilerini Güncelle";
            raporlarToolStripMenuItem.Click += raporlarToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu";
            WindowState = FormWindowState.Maximized;
            FormClosing += anaForm_FormClosing;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kitaplarToolStripMenuItem;
        private ToolStripMenuItem kitapEkleToolStripMenuItem;
        private ToolStripMenuItem kitapAraDüzenleSilToolStripMenuItem;
        private ToolStripMenuItem kitapTürleriToolStripMenuItem;
        private ToolStripMenuItem ödünçVerToolStripMenuItem;
        private ToolStripMenuItem üyelerToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        public ToolStripStatusLabel toolStripStatusLabel1;
    }
}