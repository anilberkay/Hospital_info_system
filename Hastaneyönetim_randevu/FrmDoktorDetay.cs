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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcno;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcno;

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from tbl_doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                lbladsoyad.Text = dr2[0] +" "+ dr2[1];
            }
            bgl.baglanti().Close();

            // Doktor Randevu Çekme

            DataTable dt3 = new DataTable();
            SqlDataAdapter doktor = new SqlDataAdapter("Select * from tbl_randevu where RandevuDoktor='" + lbladsoyad.Text + "'", bgl.baglanti());
            doktor.Fill(dt3);
            dataGridView1.DataSource = dt3;


        }

        private void btn_bilgidüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle dr = new FrmDoktorBilgiDüzenle();
            dr.TCNO = lbltc.Text;
            dr.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular du = new FrmDuyurular();
            du.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
