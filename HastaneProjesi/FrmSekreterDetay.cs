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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string Tc;
        SqlBaglanti bgl=new SqlBaglanti();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = Tc;
            //İSİM ÇEKME

            SqlCommand komut=new SqlCommand("SELECT SekreterAdSoyad from Tbl_Sekreterler where SekreterTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //BRANŞ ÇEKME

            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("SELECT * FROM Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //DOKTORU SİSTEME ÇEKME

            DataTable dt1=new DataTable();
            SqlDataAdapter da1=new SqlDataAdapter("Select (DoktorAd + ' ' +DoktorSoyad) as 'Doktorlar ',DoktorBrans From Tbl_Doktorlar",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //BRANŞI COMBOBOX A ÇEKME
            SqlCommand komut5=new SqlCommand("select BransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr4 = komut5.ExecuteReader();
            while (dr4.Read())
            {
                cmbBrans.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet=new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut=new SqlCommand("select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm=new FrmDoktorPaneli();
            frm.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frm=new FrmBransPaneli();
            frm.Show();
        }

        private void btnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm=new FrmRandevuListesi();
            frm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm=new FrmDuyurular();
            frm.Show();
        }
    }
}
