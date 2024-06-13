using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomasyonu
{
    public partial class Uyeduzenleme : Form
    {
        public Uyeduzenleme()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=vt\\kutuphane2024.db3;Version=3;");
        private void uyeduzenleme_Load(object sender, EventArgs e)
        {
            {
                listele();

            }
        }

        private void listele()
        {
            baglanti.Open();

            string query1 = "SELECT * FROM kullanicilar";
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(query1, baglanti);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);


            string query2 = "SELECT * FROM uyeler";
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(query2, baglanti);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);


            DataTable ortakdt = new DataTable();


            foreach (DataColumn column in dt1.Columns)
            {
                ortakdt.Columns.Add(column.ColumnName, column.DataType);
            }


            foreach (DataColumn column in dt2.Columns)
            {
                if (!ortakdt.Columns.Contains(column.ColumnName))
                {
                    ortakdt.Columns.Add(column.ColumnName, column.DataType);
                }
            }

            foreach (DataRow row in dt1.Rows)
            {
                DataRow newRow = ortakdt.NewRow();
                foreach (DataColumn column in dt1.Columns)
                {
                    newRow[column.ColumnName] = row[column];
                }
                ortakdt.Rows.Add(newRow);
            }

            foreach (DataRow row in dt2.Rows)
            {
                DataRow newRow = ortakdt.NewRow();
                foreach (DataColumn column in dt2.Columns)
                {
                    if (ortakdt.Columns.Contains(column.ColumnName))
                    {
                        newRow[column.ColumnName] = row[column];
                    }
                }
                ortakdt.Rows.Add(newRow);
            }

            dataGridView1.DataSource = ortakdt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            baglanti.Close();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Ara("KimlikNo", textBox5.Text);
        }

        private void Ara(string alanAdi, string aranacakVeri)
        {
            baglanti.Open();
            string sql = "select * from kullanicilar  where " + alanAdi + " like '%" + aranacakVeri + "%'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "kullanicilar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kullanicilar";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Ara("AdSoyad", textBox7.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox4.Clear();
            textBox8.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)


        {


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Boş Yer Bırakılmamalıdır!", "Uyarı");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "update kullanicilar set KimlikNo=@t1,AdSoyad=@t2,K_Ad=@t3,Sifre=@t6,Mail=@t8,Telefon=@t4 where KimlikNo=@t5";
                komut.Parameters.AddWithValue("t1", textBox1.Text);
                komut.Parameters.AddWithValue("t2", textBox2.Text);
                komut.Parameters.AddWithValue("t3", textBox3.Text);
                komut.Parameters.AddWithValue("t6", textBox6.Text);
                komut.Parameters.AddWithValue("t8", textBox8.Text);
                komut.Parameters.AddWithValue("t4", textBox4.Text);
                komut.Parameters.AddWithValue("t5", long.Parse(textBox1.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Kayıt güncellendi", "Bilgi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Güncellenemedi...\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Önce Kayıt Seçin", "Uyarı");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kullanicilar where KimlikNo=" + long.Parse(textBox1.Text); ;
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Temizle tuşuna basıp girişleri temizleyin lütfen.", "Uyarı");
                return;
            }
            try
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into kullanicilar (KimlikNo,AdSoyad,K_Ad,Sifre,Mail,Telefon) " +
                        "values (@t1,@t2,@t3,@t4,@t5,@t6)";
                komut.Parameters.AddWithValue("t1", textBox1.Text);
                komut.Parameters.AddWithValue("t2", textBox2.Text);
                komut.Parameters.AddWithValue("t3", textBox3.Text);
                komut.Parameters.AddWithValue("t6", textBox6.Text);
                komut.Parameters.AddWithValue("t8", textBox8.Text);
                komut.Parameters.AddWithValue("t4", textBox4.Text);
                komut.Parameters.AddWithValue("t5", long.Parse(textBox1.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Kayıt güncellendi", "Bilgi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Eklenemedi\n" + ex.Message.ToString());
            }
        }

        
    }


}
