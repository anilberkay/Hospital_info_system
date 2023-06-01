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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi d = new sqlbaglantisi();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public string tc;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text= tc;
            // Ad Soyad

            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from tbl_sekreter where SekreterTC=@p1", d.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while(dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            d.baglanti().Close();

            // Branşları Çekme 

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select BransAd from tbl_brans",d.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            // Doktorları Çekme

            DataTable dt2 = new DataTable();
            SqlDataAdapter asd2 = new SqlDataAdapter("Select (DoktorAd+ ' ' + DoktorSoyad) as 'DoktorAdı',DoktorBrans From tbl_doktor", d.baglanti());
            asd2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Branşları cmbye çekme

            SqlCommand komut3 = new SqlCommand("Select BransAd from tbl_brans", d.baglanti());
            SqlDataReader dt3 = komut3.ExecuteReader();
            while (dt3.Read())
            {
                cmb_brans.Items.Add(dt3[0]);
            }


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("Insert into tbl_randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", d.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmb_brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komutkaydet.ExecuteNonQuery();
            d.baglanti().Close();
            MessageBox.Show("Randevu Kaydı Yapıldı!");
        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();

            SqlCommand komut5 = new SqlCommand("Select DoktorAd,DoktorSoyad from tbl_doktor where DoktorBrans=@d1", d.baglanti());
            komut5.Parameters.AddWithValue("@d1", cmb_brans.Text);
            SqlDataReader dt5 = komut5.ExecuteReader();
            while (dt5.Read())
            {
                cmb_doktor.Items.Add(dt5[0] + "" + dt5[1]);
            }
            d.baglanti().Close();
        }

        private void btn_duyuru_Click(object sender, EventArgs e)
        {
            SqlCommand komutolustur = new SqlCommand("Insert into tbl_duyuru (duyuru) values(@d1)", d.baglanti());
            komutolustur.Parameters.AddWithValue("@d1", rch_duyuru.Text);
            komutolustur.ExecuteNonQuery();
            d.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu!");
        }

        private void btn_doktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli dp = new FrmDoktorPaneli();
            dp.Show();
        }

        private void btn_branspanel_Click(object sender, EventArgs e)
        {
            FrmBrans fb = new FrmBrans();
            fb.Show();
        }

        private void btn_randevulistesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi df = new FrmRandevuListesi();
            df.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular dy = new FrmDuyurular();
            dy.Show();
        }
    }
}
