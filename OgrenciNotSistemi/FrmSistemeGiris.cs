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
    public partial class FrmSistemeGiris : Form
    {
        public FrmSistemeGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmSistemeGiris_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select OgretmenNumara,sifre,Numara from "
        }
    }
}
