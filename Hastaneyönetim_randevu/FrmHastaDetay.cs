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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi d = new sqlbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {

            lblhtc.Text = tc;

            // Ad Soyad Çekme  
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from tbl_hasta where HastaTC=@p1", d.baglanti());
            komut.Parameters.AddWithValue("@p1", lblhtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblhadsoyad.Text = dr[0] + " " + dr[1];
            }
            d.baglanti().Close();

            // Randevuları Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From tbl_randevu where RandevuHastaTC="+tc, d.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From tbl_brans", d.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbhbrans.Items.Add(dr2[0]);
            }


        }

        private void cmbhbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doktorları Branşa Göre Çekme

            cmbhdoktorad.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from tbl_doktor where DoktorBrans=@p1", d.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbhbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbhdoktorad.Items.Add(dr3[0]+" " + dr3[1]);
            }
            d.baglanti().Close();

        }

        private void cmbhdoktorad_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable st = new DataTable();
            SqlDataAdapter asa = new SqlDataAdapter("Select * From tbl_randevu where RandevuBrans= '" + cmbhbrans.Text + "'"+" and RandevuDoktor='"+ cmbhdoktorad.Text+"' and RandevuDurum=0" , d.baglanti());
            asa.Fill(st);
            dataGridView2.DataSource = st;
        }

        private void lnkhbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = lblhtc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            

        }

        private void btn_hrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand güncel = new SqlCommand("Update tbl_randevu set RandevuDurum=1,RandevuHastaTC=@h1,HastaSikayet=@h2 where Randevuid=@h4", d.baglanti());
            güncel.Parameters.AddWithValue("@h1", lblhtc.Text);
            güncel.Parameters.AddWithValue("@h2", rchhsikayet.Text);
            güncel.Parameters.AddWithValue("@h4", txtid.Text);
            güncel.ExecuteNonQuery();
            d.baglanti().Close();
            MessageBox.Show("Randevu Alındı!");
        }
    }
}
