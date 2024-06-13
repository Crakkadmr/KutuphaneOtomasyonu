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
    public partial class Uyegirisi : Form
    {

        
        public Uyegirisi()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)


        {




            SQLiteConnection bag = new SQLiteConnection("Data Source=vt\\kutuphane2024.db3;Version=3;");
            bag.Open();
            string sql = "select * from uyeler where K_Ad=@t1 or KimlikNo=@t1 and Sifre=@t2";
            SQLiteCommand komut = new SQLiteCommand(bag);
            komut.CommandText = sql;
            komut.Parameters.AddWithValue("t1", Textbox1.Text);
            komut.Parameters.AddWithValue("t2", Textbox2.Text);
            SQLiteDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr[2].ToString();
                AnaForm aForm = new AnaForm();
                aForm.Show();
                this.Hide();
                aForm.toolStripStatusLabel1.Text = "ÜYE";


            }
            else
                label5.Text = "Kayit Yok";

            dr.Close();
            bag.Close();
        }

        private void Textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            //entere bastıgında algılasın 
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, e);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Kayitol k_form = new Kayitol();
            k_form.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
