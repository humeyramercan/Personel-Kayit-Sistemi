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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7DC3V2IB;Initial Catalog=PersonelVeriTabani1;Integrated Security=True");
        private void Grafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select Sehir,Count(*) from Personel_Tablo group by Sehir", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                SehirlerChart.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Meslek,Avg(Maas) from Personel_Tablo group by Meslek", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while(dr2.Read())
            {
                MeslekMaasChart.Series["Meslek-Ort Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }
    }
}
