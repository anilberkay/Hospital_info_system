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
    public partial class Hastagiris : Form
    {
        public Hastagiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi sb1 = new sqlbaglantisi();
        private void hkayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
            
        }

        private void hgiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where HastaTC=@b1 and HastaSifre=@b2", sb1.baglanti());
            komut.Parameters.AddWithValue("@b1", msktc.Text);
            komut.Parameters.AddWithValue("@b2", txthsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmHastaDetay fb = new FrmHastaDetay();
                fb.tc = msktc.Text;
                fb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            sb1.baglanti().Close();



        }
    }
}
