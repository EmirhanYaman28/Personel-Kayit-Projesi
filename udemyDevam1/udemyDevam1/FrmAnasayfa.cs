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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J3L7K2P\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        void temizle()
        {
            txtId.Text="";
            txtAd.Text="";
            txtSoyad.Text="";
            txtMeslek.Text="";
            mskMaas.Text="";
            cmbSehir.Text="";
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            txtAd.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet2.Tbl_Personel);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
                this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
                dataGridView1.DataSource = this.personelVeriTabaniDataSet1.Tbl_Personel;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerMeslek, PerDurum) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label1.Text="True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                label1.Text = "False";
            }

        }

        private void btnTemizilk_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "True")
            {
                radioButton1.Checked=true;
            }
            if (label1.Text == "False")
            {
                radioButton1.Checked=false;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1",txtId.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGun = new SqlCommand("Update Tbl_Personel Set PerAd=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaas=@p4,PerDurum=@p5,PerMeslek=@p6 Where Perid=@p7",baglanti);
            komutGun.Parameters.AddWithValue("@p1",txtAd.Text);
            komutGun.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komutGun.Parameters.AddWithValue("@p3",cmbSehir.Text);
            komutGun.Parameters.AddWithValue("@p4",mskMaas.Text);
            komutGun.Parameters.AddWithValue("@p5",label1.Text);
            komutGun.Parameters.AddWithValue("@p6",txtMeslek.Text);
            komutGun.Parameters.AddWithValue("@p7",txtId.Text);

            komutGun.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");
        }

        private void btnIstetik_Click(object sender, EventArgs e)
        {
            FrmIstatik frm = new FrmIstatik();
            frm.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }

        private void btnRapolar_Click(object sender, EventArgs e)
        {

        }
    }
}
