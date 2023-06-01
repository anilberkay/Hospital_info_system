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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable da = new DataTable();
            SqlDataAdapter km = new SqlDataAdapter("Select * From tbl_brans",bgl.baglanti());
            km.Fill(da);
            dataGridView1.DataSource = da;

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into tbl_brans (BransAd) values (@b1)", bgl.baglanti());
            kaydet.Parameters.AddWithValue("@b1", txt_soyad.Text);
            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydedildi!");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from tbl_brans where BransAd=@b3", bgl.baglanti());
            sil.Parameters.AddWithValue("@b3", txt_soyad.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand("update tbl_brans set BransAd=@b5 where Bransİd=@b6", bgl.baglanti());
            güncelle.Parameters.AddWithValue("@b5",txt_soyad.Text);
            güncelle.Parameters.AddWithValue("@b6", txt_ad.Text);
            güncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi!");
        }
    }
}
