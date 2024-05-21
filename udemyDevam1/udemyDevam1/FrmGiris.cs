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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J3L7K2P\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kmt = new SqlCommand("Select * From Tbl_Yonetici Where KullaniciAdi=@p1 and Sifre=@p2",baglanti);

            kmt.Parameters.AddWithValue("@p1",txtKullaniciAd.Text);
            kmt.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader rdr = kmt.ExecuteReader();
            if (rdr.Read())
            {
                FrmAnasayfa frm = new FrmAnasayfa();
                frm.Show();
            }
            else
                MessageBox.Show("Hatalı Giriş");
            baglanti.Close();
        }
    }
}
