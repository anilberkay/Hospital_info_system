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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        sqlbaglantisi sb = new sqlbaglantisi();
        private void btn_hkayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_hasta (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@h1,@h2,@h3,@h4,@h5,@h6)", sb.baglanti());
            komut.Parameters.AddWithValue("@h1", txthkad.Text);
            komut.Parameters.AddWithValue("@h2",txthksoyad.Text);
            komut.Parameters.AddWithValue("@h3", mskhktc.Text);
            komut.Parameters.AddWithValue("@h4", mskhktelefon.Text);
            komut.Parameters.AddWithValue("@h5", txthksifre.Text);
            komut.Parameters.AddWithValue("@h6",cmbhkcinsiyet.Text);
            komut.ExecuteNonQuery();
            sb.baglanti().Close();
            MessageBox.Show("Hasta Kaydı Tamamlandı!");
        }
    }
}
