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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi b = new sqlbaglantisi();
        public string TCno;
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskhktc.Text = TCno;

            SqlCommand komut = new SqlCommand("Select * from tbl_hasta where HastaTC=@p1", b.baglanti());
            komut.Parameters.AddWithValue("@p1",mskhktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txthkad.Text = dr[1].ToString();
                txthksoyad.Text = dr[2].ToString();
                txthksifre.Text = dr[5].ToString();
                cmbhkcinsiyet.Text = dr[6].ToString();
                mskhktelefon.Text = dr[4].ToString();

            }
        }

        private void btn_bilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update tbl_hasta set HastaAd==@h1,HastaSoyad=@h2,HastaTelefon=@h3,HastaSifre=@h4,HastaCinsiyet=@h5 where HastaTC=@h6", b.baglanti());
            komut2.Parameters.AddWithValue("@h6", mskhktc.Text);
            komut2.Parameters.AddWithValue("@h1", txthkad.Text);
            komut2.Parameters.AddWithValue("@h2", txthksoyad.Text);
            komut2.Parameters.AddWithValue("@h3", mskhktelefon.Text);
            komut2.Parameters.AddWithValue("@h4", txthksifre.Text);
            komut2.Parameters.AddWithValue("@h5", cmbhkcinsiyet.Text);
            komut2.ExecuteNonQuery();
            b.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi!");
        }
    }
}
