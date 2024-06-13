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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneOtomasyonu
{
    public partial class Kayitol : Form
    {
        public Kayitol()
        {
            InitializeComponent();
        }

        SQLiteConnection bag = new("Data Source=vt\\kutuphane2024.db3;Version=3;");

        private void label6_Click(object sender, EventArgs e)
        {
            GirisEkrani giris_form = new GirisEkrani();
            giris_form.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (Textbox1.Text == "" || Textbox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Tüm bilgiler girilmelidir!", "Uyarı");
                return;
            }
            bag.Open();
            SQLiteCommand komut = new()
            {
                Connection = bag,
                CommandText = "insert into uyeler (Durum,KimlikNo,AdSoyad,K_Ad,Sifre,Mail,Telefon) " +
                    "values (@Durum,@t1,@t2,@t3,@t4,@t5,@t6)"
            };
            komut.Parameters.AddWithValue("Durum", "UYE");
            komut.Parameters.AddWithValue("t1", Textbox1.Text);
            komut.Parameters.AddWithValue("t2", Textbox2.Text);
            komut.Parameters.AddWithValue("t3", textBox3.Text);
            komut.Parameters.AddWithValue("t4", textBox4.Text);
            komut.Parameters.AddWithValue("t5", textBox5.Text);
            komut.Parameters.AddWithValue("t6", textBox6.Text);
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kayıt Eklendi", "Bilgi");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
