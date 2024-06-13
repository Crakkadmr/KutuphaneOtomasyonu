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
    public partial class kitapEkle : Form
    {
        public kitapEkle()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=vt\\kutuphane2024.db3;Version=3;");


        private void KitapEkle_Load(object sender, EventArgs e)
        {
            kitapTurleriniGuncelle();
            autoComp_yer();
        }

        private void autoComp_yer()
        {
            baglanti.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT yer FROM kitaplar", baglanti);
            SQLiteDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                Collection.Add(dr.GetString(0));
            }
            textBox5.AutoCompleteCustomSource = Collection;
            dr.Close();
            baglanti.Close();
        }


        private void kitapTurleriniGuncelle()
        {
            comboBox1.Items.Clear();
            baglanti.Open();
            string sql = "select * from kitapTurleri";
            SQLiteCommand komut = new SQLiteCommand(baglanti)
            {
                CommandText = sql
            };

            SQLiteDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(1));
            }
            comboBox1.SelectedIndex = 0;
            dr.Close();
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitaTuru k_tur = new kitaTuru
            {
                MdiParent = this.MdiParent
            };
            k_tur.Show();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            kitapTurleriniGuncelle();
        }

        string hedefResimYolu = System.Windows.Forms.Application.StartupPath + "\\resimler\\";
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Önce Barkod ve Kitap Adını Girmelisiniz", "Uyarı");
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string resimAdYol = openFileDialog1.FileName;
                string resimAd = openFileDialog1.SafeFileName;
                string uzanti = Path.GetExtension(resimAd);

                string yeniResimAdi = textBox1.Text + "_" + textBox2.Text + uzanti;
                label8.Text = yeniResimAdi;
                string hedefResimYoluAdi = hedefResimYolu + yeniResimAdi;
                File.Copy(resimAdYol, hedefResimYoluAdi, true);
                if (File.Exists(hedefResimYoluAdi))
                {
                    pictureBox1.Image = Image.FromFile(hedefResimYoluAdi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Barkod,Kitap Adı ve Yazar Girilmeilidir!", "Uyarı");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new()
                {
                    Connection = baglanti,
                    CommandText = "insert into kitaplar (Barkod,Ad,Yazar,Turu,Icindekiler,Yer,Kimde,Resim) " +
                    "values (@t1,@t2,@t3,@cb1,@t4,@t5,@t6,@l8)"
                };
                komut.Parameters.AddWithValue("t1", textBox1.Text);
                komut.Parameters.AddWithValue("t2", textBox2.Text);
                komut.Parameters.AddWithValue("t3", textBox3.Text);
                komut.Parameters.AddWithValue("cb1", comboBox1.Text);
                komut.Parameters.AddWithValue("t4", textBox4.Text);
                komut.Parameters.AddWithValue("t5", textBox5.Text);
                komut.Parameters.AddWithValue("t6", textBox6.Text);
                komut.Parameters.AddWithValue("l8", label8.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                //MessageBox.Show("Kayıt Eklendi", "Bilgi");
                panel1.Dock = DockStyle.Fill;
                panel1.BringToFront();
                panel1.Visible = true;
                timer1.Interval = 1000;
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Eklenemedi...\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label8.Text = "";
            pictureBox1.Image = null;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Visible = false;
            timer1.Enabled = false;
            panel1.Dock = DockStyle.None;
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            if (textBox4.Dock != DockStyle.Fill)
            {
                textBox4.Dock = DockStyle.Fill;
                textBox4.BringToFront();
            }
            else
            {
                textBox4.Dock = DockStyle.None;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (groupBox1.Dock != DockStyle.Fill)
            {
                groupBox1.Dock = DockStyle.Fill;
                groupBox1.BringToFront();
            }
            else
            {
                groupBox1.Dock = DockStyle.None;
            }
        }
    }


}
