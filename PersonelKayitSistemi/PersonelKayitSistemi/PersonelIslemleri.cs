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
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7DC3V2IB;Initial Catalog=PersonelVeriTabani1;Integrated Security=True"); // baglanti adresimizi tanımladık

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabani1DataSet1.Personel_Tablo' table. You can move, or remove it, as needed.           
            
            this.personel_TabloTableAdapter.Fill(this.personelVeriTabani1DataSet1.Personel_Tablo);

        }
        string medeniHalKontrol;
        private void KAYDETbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel_Tablo (Ad,Soyad,Sehir,Maas,MedeniHal,Meslek) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", ADtextbox.Text);
            komut.Parameters.AddWithValue("@p2", SOYADtextbox.Text);
            komut.Parameters.AddWithValue("@p3", SEHIRcomboBox.Text);
            komut.Parameters.AddWithValue("@p4", MAASmaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p5", medeniHalKontrol);
            komut.Parameters.AddWithValue("@p6", MESLEKtextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.personel_TabloTableAdapter.Fill(this.personelVeriTabani1DataSet1.Personel_Tablo);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            IDtextbox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ADtextbox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            SOYADtextbox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();     
            SEHIRcomboBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MAASmaskedTextBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

                if (Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value)) 
                {
                    EVLIradioButton.Checked = true;
                }
                else if (Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value) == false) 
                {
                    BEKARradioButton.Checked = true;
                }

            MESLEKtextBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
           

           
        }

        private void EVLIradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(EVLIradioButton.Checked)
            {
                medeniHalKontrol = "true";
            }
           
        }
        private void BEKARradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BEKARradioButton.Checked)
            {
                medeniHalKontrol = "false";
            }
        }

        private void SILbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Personel_Tablo where Id=@p", baglanti);
            komut.Parameters.AddWithValue("@p", IDtextbox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.personel_TabloTableAdapter.Fill(this.personelVeriTabani1DataSet1.Personel_Tablo);
        }

        private void GUNCELLEbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personel_Tablo set Ad=@p1,Soyad=@p2,Sehir=@p3,Maas=@p4,MedeniHal=@p5,Meslek=@p6 where Id=@p7", baglanti);
            komut.Parameters.AddWithValue("@p7", IDtextbox.Text);
            komut.Parameters.AddWithValue("@p1", ADtextbox.Text);
            komut.Parameters.AddWithValue("@p2", SOYADtextbox.Text);
            komut.Parameters.AddWithValue("@p3", SEHIRcomboBox.Text);
            komut.Parameters.AddWithValue("@p4", MAASmaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p5", medeniHalKontrol);
            komut.Parameters.AddWithValue("@p6", MESLEKtextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.personel_TabloTableAdapter.Fill(this.personelVeriTabani1DataSet1.Personel_Tablo);
        }

        private void TEMIZLEbutton_Click(object sender, EventArgs e)
        {
            IDtextbox.Clear();
            ADtextbox.Clear();
            SOYADtextbox.Clear();
            SEHIRcomboBox.Text = "";
            MAASmaskedTextBox.Clear();
            EVLIradioButton.Checked = false;
            BEKARradioButton.Checked = false;
            MESLEKtextBox.Clear();
            ADtextbox.Focus();
        }

        private void ISTATISTIKbutton_Click(object sender, EventArgs e)
        {
            İstatistikler IstatistikFrm = new İstatistikler();
            IstatistikFrm.Show();

        }

        private void GRAFIKbutton_Click(object sender, EventArgs e)
        {
            Grafikler GrafikFrm = new Grafikler();
            GrafikFrm.Show();
        }

        
    }
}
