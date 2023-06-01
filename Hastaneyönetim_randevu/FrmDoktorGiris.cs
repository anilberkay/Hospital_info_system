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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void hgiris_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("Select * from tbl_doktor where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            giris.Parameters.AddWithValue("@p1", msktc.Text);
            giris.Parameters.AddWithValue("@p2", txthsifre.Text);
            SqlDataReader dr1 = giris.ExecuteReader();
            if (dr1.Read())
            {
                FrmDoktorDetay dr = new FrmDoktorDetay();
                dr.tcno = msktc.Text;
                dr.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı TC veya Şifre!");
            }
            bgl.baglanti().Close();
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
