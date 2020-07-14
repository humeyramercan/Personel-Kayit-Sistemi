using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelKayitSistemi
{
    public partial class İstatistikler : Form
    {
        public İstatistikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7DC3V2IB;Initial Catalog=PersonelVeriTabani1;Integrated Security=True"); // baglanti adresimizi tanımladık
        private void İstatistikler_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count (*) from Personel_Tablo", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                ToplamPersonelLabel.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //Evli Personel Sayısı

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Personel_Tablo where MedeniHal=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                EvliPersonelLabel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar Personel Sayısı

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Personel_Tablo where MedeniHal=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                BekarPersonelLabel.Text = dr3[0].ToString();
            }
            baglanti.Close();


            //Sehir sayısı

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count (distinct(Sehir))from Personel_Tablo", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                SehirLabel.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maas

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Maas) from Personel_Tablo", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while(dr5.Read())
            {
                ToplamMaasLabel.Text = dr5[0].ToString();
            }
            baglanti.Close();


            //Ortalama Maas

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(Maas) from Personel_Tablo", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read())
            {
                OrtalamaMaasLabel.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
