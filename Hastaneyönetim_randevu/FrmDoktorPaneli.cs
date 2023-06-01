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

namespace Hastaneyönetim_randevu
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter asd2 = new SqlDataAdapter("Select * From tbl_doktor",bgl.baglanti() );
            asd2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            // Cmbye Branşları Çekme

            SqlCommand komut3 = new SqlCommand("Select BransAd from tbl_brans", bgl.baglanti());
            SqlDataReader dt3 = komut3.ExecuteReader();
            while (dt3.Read())
            {
                cmb_brans.Items.Add(dt3[0]);
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("Insert into (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre)values(@e1,@e2,@e3,@e4,@e5)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@e1", txt_ad.Text);
            komutkaydet.Parameters.AddWithValue("@e2", txt_soyad.Text);
            komutkaydet.Parameters.AddWithValue("@e3", cmb_brans.Text);
            komutkaydet.Parameters.AddWithValue("@e4", msk_tc.Text);
            komutkaydet.Parameters.AddWithValue("@e5", txt_sifre.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydedildi!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_ad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msk_tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from tbl_doktor where DoktorTC=@d1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@d1", msk_tc.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi!");
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("Update  tbl_doktor set DoktorAd=@f1,DoktorSoyad=@f2,DoktorBrans=@f3,DoktorSifre=@f5 where DoktorTC=@f6", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@f1", txt_ad.Text);
            komutgüncelle.Parameters.AddWithValue("@f2", txt_soyad.Text);
            komutgüncelle.Parameters.AddWithValue("@f3", cmb_brans.Text);
            komutgüncelle.Parameters.AddWithValue("@f6", msk_tc.Text);
            komutgüncelle.Parameters.AddWithValue("@f5", txt_sifre.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi!");
        }
    }
}
