using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KutuphaneOtomasyonu
{
    public partial class kitaTuru : Form
    {
        public kitaTuru()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=vt\\kutuphane2024.db3;Version=3;");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tür Adı Girmelisiniz!");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into kitapTurleri (Ad,Aciklama)" +
                    "values (@t1,@t2)";
                komut.Parameters.AddWithValue("t1", textBox1.Text);
                komut.Parameters.AddWithValue("t2", textBox2.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Kayıt Eklendi", "Bilgi");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Eklenemedi...\n" + ex.Message);

            }
            button1.Enabled = false;
        }
        private void listele()
        {
            baglanti.Open();
            string sql = "select * from kitapTurleri";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "kitapTurleri");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kitapTurleri";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();

        }

        private void kitaTuru_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show("Önce güncellenecek kaydı seçin", "Uyarı");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tür Adı Girmelisiniz!");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "update kitapTurleri set Ad=@t1, Aciklama=@t2" +
                    " where id =" + int.Parse(label3.Text);
                komut.Parameters.AddWithValue("t1", textBox1.Text);
                komut.Parameters.AddWithValue("t2", textBox2.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Kayıt Güncellendi", "Bilgi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Güncellenemedi...\n" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show("ÖNce silinecek kaydı seçin", "Uyarı");
                return;

            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kitapTurleri" +
                    " where id=" + int.Parse(label3.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Kayıt Silindi", "Bilgi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Silinemedi...\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
