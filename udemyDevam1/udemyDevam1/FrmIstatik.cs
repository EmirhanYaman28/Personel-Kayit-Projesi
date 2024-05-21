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

namespace udemyDevam1
{
    public partial class FrmIstatik : Form
    {
        public FrmIstatik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J3L7K2P\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        private void FrmIstatik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("Select Count(*) From Tbl_Personel",baglanti);
            SqlDataReader dr = kmt1.ExecuteReader();
            while (dr.Read())
            {
                lblToplamPersonel.Text=dr[0].ToString();
            }
            baglanti.Close();

            //Evli Pwersonel Saroso
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=1",baglanti);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPersonel.Text=dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar Perdonel SAroso
            baglanti.Open();
            SqlCommand kmt3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerDurum=0",baglanti);
            SqlDataReader dr3 = kmt2.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPersonel.Text=dr3[0].ToString();
            }
            baglanti.Close();

            //Şehir Sarodo
            baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("Select Count(Distinct(PerSehir)) From Tbl_Personel",baglanti);
            SqlDataReader dr4 = kmt4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehir.Text=dr4[0].ToString();
            }
            baglanti.Close();

            //MAaş 
            baglanti.Open();
            SqlCommand kmt5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel",baglanti);
            SqlDataReader dr5 = kmt5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaas.Text=dr5[0].ToString();
            }
            baglanti.Close();

            //Ortalama
            baglanti.Open();
            SqlCommand kmt6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = kmt6.ExecuteReader();
            while (dr6.Read())
            {
                lblOertMaas.Text=dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
