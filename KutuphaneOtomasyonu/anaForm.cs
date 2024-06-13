using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void anaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == ("ÜYE"))
            {
                MessageBox.Show("Bu bölüme giremezsiniz!", "Erişim Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kitapEkle k_Ekle = new kitapEkle();
                k_Ekle.MdiParent = this;
                k_Ekle.Show();
            }

        }

        private void kitapTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == ("ÜYE"))
            {
                MessageBox.Show("Bu bölüme giremezsiniz!", "Erişim Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kitaTuru ktur = new kitaTuru();
                ktur.MdiParent = this;
                ktur.Show();
            }
        }

        private void üyelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == ("ÜYE"))
            {
                MessageBox.Show("Bu bölüme giremezsiniz!", "Erişim Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Uyeduzenleme klduz = new Uyeduzenleme();
                klduz.MdiParent = this;
                klduz.Show();
            }
        }

        private void kitapAraDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitaplistele frm = new Kitaplistele();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ödünçVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oduncVerAl oform = new oduncVerAl();
            oform.MdiParent = this;
            oform.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciDuzenle kform=new kullaniciDuzenle();
            kform.MdiParent = this;
            kform.Show();
        }
    }
}
        



