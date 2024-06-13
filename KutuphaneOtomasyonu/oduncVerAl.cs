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
    public partial class oduncVerAl : Form
    {
        public oduncVerAl()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=vt\\kutuphane2024.db3;Version=3;");
        private void oduncVerAl_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString();
            kitapIdleriGetir();
            uyeKimlikleriGetir();
            teslimedilmeyenKitaplariListele();
        }
        private void teslimedilmeyenKitaplariListele()
        {
            baglanti.Open();
            string sql = "select * from odunc where AlTar is null";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds=new DataSet();
            ds.Clear();
            da.Fill(ds,"odunc");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "odunc";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }
        private void uyeKimlikleriGetir()
        {
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand(baglanti);
            komut.CommandText = "select KimlikNo from uyeler";
            AutoCompleteStringCollection src=new AutoCompleteStringCollection();
            SQLiteDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                src.Add(dr[0].ToString());
            }
            dr.Close();
            baglanti.Close() ;
            textBox2.AutoCompleteCustomSource=src;
        }
        private void kitapIdleriGetir()
        {
            baglanti.Open() ;
            SQLiteCommand komut = new SQLiteCommand( baglanti);
            komut.CommandText = "select id from kitaplar";
            AutoCompleteStringCollection src= new AutoCompleteStringCollection();
            SQLiteDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                src.Add(dr[0].ToString());

            }
            dr.Close();
            baglanti.Close() ;
            textBox1.AutoCompleteCustomSource=src;
        }
    }
}
