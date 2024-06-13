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
using System.Diagnostics.Eventing.Reader;

namespace KutuphaneOtomasyonu
{
    public partial class Kitaplistele : Form
    {
        public Kitaplistele()
        {
            InitializeComponent();
        }
        SQLiteConnection baglanti = new SQLiteConnection("Data Source=vt\\kutuphane2024.db3;Version=3;");

        private void Kitaplistele_Load(object sender, EventArgs e)
        {
            listele();
            comboBox1.SelectedItem = 2;
        }
        private void listele()
        {
            baglanti.Open();
            string sql = "select * from kitaplar";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "kitaplar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kitaplar";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
            textBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select * from kitaplar where " + comboBox1.Text + " like '" + textBox1.Text + "%'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "kitaplar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kitaplar";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string yol = System.Windows.Forms.Application.StartupPath + "\\resimler\\";
            string resimAd = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string yol_ad = yol + resimAd;
            if (File.Exists(yol_ad) == true)

                pictureBox1.Image = Image.FromFile(yol_ad);

            else pictureBox1.Image = null;


            int str = dataGridView1.CurrentRow.Index;
            if (özetiGösterToolStripMenuItem.Checked)
            {
                string icindekiler = dataGridView1.Rows[str].Cells[5].Value.ToString();
                 textBox2.Text = icindekiler;

            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show("Önce bir kayıt seçin", "Uyarı");
                return;
            }
            string kitapAd = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string mesaj = "id=" + label3.Text + " olan " + kitapAd + " isimli kitap silinsin mi?";
            DialogResult snc = MessageBox.Show(mesaj, "uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (snc == DialogResult.OK)
            {
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kitaplar where id=" + int.Parse(label3.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
        }

        private void özetiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                MessageBox.Show("Önce bir kayıt seçin", "Uyarı");
                return;
            }
            int str = dataGridView1.CurrentRow.Index;
            if (!özetiGösterToolStripMenuItem.Checked)
            {
                özetiGösterToolStripMenuItem.Checked = true;
                string icindekiler = dataGridView1.Rows[str].Cells[5].Value.ToString();
                textBox2.Text = icindekiler;
                textBox2.Dock = DockStyle.Fill;
                groupBox1.Text = icindekiler;

            }
            else
            {
                özetiGösterToolStripMenuItem.Checked = false;
                textBox2.Dock = DockStyle.None;
                groupBox1.Text = "Kitap Ara";
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapDuzenle frm = new();
            frm.MdiParent = frm.MdiParent;
            frm.kitapId =int.Parse(label3.Text);
            frm.Show();
        }

        private void Kitaplistele_Activated(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) { return; }
            saveFileDialog1.Filter = "CSV file (*.csv|*.csv| All Files (*.*)|*.*";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string yol=saveFileDialog1.FileName;
                try
                {
                    int columnCount = dataGridView1.Columns.Count;
                    string[] outputCsv = new string[dataGridView1.Rows.Count];

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            outputCsv[i] += dataGridView1.Rows[i].Cells[j].Value.ToString().Replace(Environment.NewLine, " ") + ";";
                        }
                        outputCsv[i] = outputCsv[i].Remove(outputCsv[i].Length - 1);
                          
                    }
                    System.IO.File.WriteAllLines(yol, outputCsv, Encoding.UTF8);
                    MessageBox.Show("Veriler Kaydedildi!!!", "Bilgi");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                }   
            }
        }
    }
}

