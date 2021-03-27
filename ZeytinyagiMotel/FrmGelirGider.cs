using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ZeytinyagiMotel
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P7OUVT3;Initial Catalog=zeytinyagimotel;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblPersonelmaas.Text = (personel * 2800).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasatoplam.Text) - (Convert.ToInt32(lblPersonelmaas.Text) + Convert.ToInt32(lblAlinanurunler1.Text) + Convert.ToInt32(lblAlinanurunler2.Text) + Convert.ToInt32(lblAlinanurunler3.Text) + Convert.ToInt32(lblFaturalar1.Text) + Convert.ToInt32(lblFaturalar2.Text) + Convert.ToInt32(lblFaturalar3.Text));
            lblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutatr
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasatoplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
            //gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlinanurunler1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();
            //içeçek
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlinanurunler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();
            //Atıştırmalık
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlinanurunler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFaturalar1.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            //internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();



        }
    }
}
