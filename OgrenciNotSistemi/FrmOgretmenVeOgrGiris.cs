using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FrmGirisSayfası : Form
    {
        public FrmGirisSayfası()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            SqlCommand conn = new SqlCommand("select * from TblOgretmen where OgretmenNumara=@p1 and OgretmenSifre=@p2", bgl.baglanti());
            conn.Parameters.AddWithValue("@p1", mskOgretmenNumara.Text);
            conn.Parameters.AddWithValue("@p2", txtOgretmenSifre.Text);
            SqlDataReader dr = conn.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmenDetay frm = new FrmOgretmenDetay();
                frm.Show();
                MessageBox.Show("Sisteme Hoş Gelidiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara Ya Da Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }

        private void btnOgrenciGiriş_Click(object sender, EventArgs e)
        {
            SqlCommand conn = new SqlCommand("select * from TblOgrenci where Numara=@p1 and Sifre=@p2", bgl.baglanti());
            conn.Parameters.AddWithValue("@p1", mskOgrenciNumara.Text);
            conn.Parameters.AddWithValue("@p2", txtOgrenciSifre.Text);
            SqlDataReader dr = conn.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenciDetay frm = new FrmOgrenciDetay();
                frm.Show();
                MessageBox.Show("Sisteme Hoş Gelidiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara Ya Da Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }
    }
}
