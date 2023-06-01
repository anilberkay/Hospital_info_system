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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void txthkad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthksifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void mskhktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void mskhktelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txthksoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string TCNO;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskhktc.Text = TCNO;


            SqlCommand komutt = new SqlCommand("Select * from tbl_doktor where DoktorTC=@p1", bgl.baglanti());
            komutt.Parameters.AddWithValue("@p1", mskhktc.Text);
            SqlDataReader dr4 = komutt.ExecuteReader();
            while (dr4.Read())
            {
                txthkad.Text = dr4[1].ToString();
                txthksoyad.Text = dr4[2].ToString();
                comboBox1.Text = dr4[3].ToString();
                txthksifre.Text = dr4[5].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand günc = new SqlCommand("Update tbl_doktor set DoktorAd=@h1,DoktorSoyad=@h2,DoktorBrans=@h3,DoktorSifre=@h4 where DoktorTC=@h5", bgl.baglanti());
            günc.Parameters.AddWithValue("@h1", txthkad.Text);
            günc.Parameters.AddWithValue("@h2", txthksoyad.Text);
            günc.Parameters.AddWithValue("@h3", comboBox1.Text);
            günc.Parameters.AddWithValue("@h5", mskhktc.Text);
            günc.Parameters.AddWithValue("@h4", txthksifre.Text);
            günc.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi!");
        }
    }
}
