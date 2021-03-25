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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P7OUVT3;Initial Catalog=zeytinyagimotel;Integrated Security=True");

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "109";
        }

        private void btnDoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dlu Odaları Gösterir");
        }

        private void btnBosoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);
            TimeSpan sonuc = buyukTarih - kucukTarih;
            label11.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,SoyAdi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)" +
                " values('"+txtAdi.Text+"','"+txtSoyadi.Text+"','"+cbxCinsiyet.Text + "','"+msktxtTelefon.Text+"','"+txtMail.Text+"','"+txtKimlikno.Text+"','"+txtOdano.Text+"','"+txtUcret.Text+"','"+dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"','"+dtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı");
        }
    }
}
//Data Source=DESKTOP-P7OUVT3;Initial Catalog=zeytinyagimotel;Integrated Security=True
