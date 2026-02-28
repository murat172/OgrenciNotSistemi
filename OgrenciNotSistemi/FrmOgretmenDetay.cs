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

            SqlCommand command1 = new SqlCommand("SELECT \r\n    o.OgrAd,\r\n    o.OgrSoyad,\r\n    d.DersAdi,\r\n    n.Vize,\r\n    n.Final,\r\n    n.Ortalama,\r\n\tn.Durum\r\nFROM TblNotlar n\r\nINNER JOIN TblOgrenci o ON n.OgrenciId = o.OgrId\r\nINNER JOIN TblDers d ON n.DersId = d.DersId;", bgl.baglanti());
            SqlDataAdapter da1 = new SqlDataAdapter(command1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tblogrenci where OgrId=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1",txtOgrId.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Öğrenci Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TblOgrenci set OgrAd=@p1,OgrSoyad=@p2,Sifre=@p3,Sınıf=@p4 where Numara=@p5", bgl.baglanti());
            command.Parameters.AddWithValue("@p1",txtAd.Text);
            command.Parameters.AddWithValue("@p2",txtSOyad.Text);
            command.Parameters.AddWithValue("@p3",txtSifre.Text);
            command.Parameters.AddWithValue("@p4",txtSınıf.Text);
            command.Parameters.AddWithValue("@p5",txtNumara.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = bgl.baglanti())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM TblOgrenci WHERE OgrAd LIKE @p1",
                    conn);

                da.SelectCommand.Parameters.Add("@p1", SqlDbType.NVarChar)
                    .Value = "%" + txtAd.Text + "%";

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOgrId.Text = "";
            txtAd.Text = "";
            txtSOyad.Text = "";
            txtSınıf.Text = "";
            txtSifre.Text = "";
            txtNumara.Text = "";

        }

        private void btnAddNot_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(txtVize.Text);
            double final = Convert.ToDouble(txtFinal.Text);

            double ortalama = (vize * 0.4) + (final * 0.6);

            string durum = ortalama >= 50 ? "Geçti" : "Kaldı";

            SqlCommand command = new SqlCommand(
            "insert into TblNotlar (OgrenciId, DersId, vize, final, Ortalama,durum) values (@p1,@p2,@p3,@p4,@p5,@p6)",
            bgl.baglanti());

            command.Parameters.AddWithValue("@p1", txtOgrId.Text);
            command.Parameters.AddWithValue("@p2", txtDersId.Text);
            command.Parameters.AddWithValue("@p3", vize);
            command.Parameters.AddWithValue("@p4", final);
            command.Parameters.AddWithValue("@p5", ortalama);
            command.Parameters.AddWithValue("@p6", durum);

            command.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Notlar Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        
    }
}
