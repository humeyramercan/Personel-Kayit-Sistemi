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
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7DC3V2IB;Initial Catalog=PersonelVeriTabani1;Integrated Security=True"); // baglanti adresimizi tanımladık
        private void girisButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Yonetici_Tablo where KullaniciAdi=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", kullaniciAdiTextBox.Text);
            komut.Parameters.AddWithValue("@p2", sifreTextBox.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                this.Hide();
                PersonelIslemleri frm = new PersonelIslemleri();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
