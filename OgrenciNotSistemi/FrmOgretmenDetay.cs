using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string numara;

        
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            SqlCommand command = new SqlCommand("select * from TblOgretmen where OgretmenNumara=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();


            
        }

        private void btlList_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TblOgrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TblOgrenci (OgrAd,OgrSoyad,Numara,Sifre,Sınıf) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSOyad.Text);
            command.Parameters.AddWithValue("@p3", txtNumara.Text);
            command.Parameters.AddWithValue("@p4", txtSifre.Text);
            command.Parameters.AddWithValue("@p5", txtSınıf.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
