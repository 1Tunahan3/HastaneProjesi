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

namespace HastaneProjesi
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcno;
        SqlBaglanti bgl=new SqlBaglanti();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno;
            SqlCommand komut=new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTelNo.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut4=new SqlCommand("UPDATE Tbl_Hastalar Set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", txtAd.Text);
            komut4.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut4.Parameters.AddWithValue("@p3", mskTelNo.Text);
            komut4.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut4.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut4.Parameters.AddWithValue("@p6", mskTc.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başarıyla Güncellendi");
        }
    }
}
