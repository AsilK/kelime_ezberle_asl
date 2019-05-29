using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kelime_ezberle_d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti =
               new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asil\Desktop\SozlukDB\dbSozluk.accdb");
        

          Random rnd = new Random();
        int kitapSayisi = 2491;
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi = rnd.Next(1, kitapSayisi);


            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", sayi);

            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                txtIngilizce.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            txtTurkce.Focus();
            timer1.Start();
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if(txtTurkce.Text == lblCevap.Text )
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                txtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSüre.Text = sure.ToString();
            if (sure==0)
            {
                txtTurkce.Enabled = false;
                txtIngilizce.Enabled = false;
                timer1.Stop();
            }
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand ekle1 = new OleDbCommand("insert into sozluk (ingilizce, turkce) values (@p1,@p2)", baglanti);
            ekle1.Parameters.AddWithValue("@p1", txt_TurkceEkle.Text);
            ekle1.Parameters.AddWithValue("@p2", txt_IngilizceEkle.Text);
            ekle1.ExecuteNonQuery();
            baglanti.Close();
            kitapSayisi += 1;
            MessageBox.Show("Kelime Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }

        private void btn_KelimeSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand sil1 = new OleDbCommand("Delete From sozluk where id=@p1", baglanti);
            sil1.Parameters.AddWithValue("@p1", txtKelimeId.Text);
            sil1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kelime Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            kitapSayisi -= 1;
            
            
        }
    }
}
