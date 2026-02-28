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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string numara;
        

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            SqlCommand command = new SqlCommand("select * from TblOgrenci where Numara=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand command2 = new SqlCommand("SELECT \r\n    o.OgrAd,\r\n    o.OgrSoyad,\r\n    d.DersAdi,\r\n    n.Vize,\r\n    n.Final,\r\n    n.Ortalama,\r\n\tn.Durum\r\nFROM TblNotlar n\r\nINNER JOIN TblOgrenci o ON n.OgrenciId = o.OgrId\r\nINNER JOIN TblDers d ON n.DersId = d.DersId;", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TblOgrenci set sifre=@p1 where Numara=@p2", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtPasswordUpdate.Text);
            command.Parameters.AddWithValue("@p2", mskOgrNumara.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Güncelleme Yapıldı");
        }
    }
}
