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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi b = new sqlbaglantisi();
        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void hgiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Select * from tbl_sekreter where SekreterTC=@p1 and SekreterSifre=@p2", b.baglanti());
            komut4.Parameters.AddWithValue("@p2", txthsifre.Text);
            komut4.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut4.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay ne = new FrmSekreterDetay();
                ne.tc = msktc.Text.ToString();
                ne.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre!");
            }
        }
    }
}
