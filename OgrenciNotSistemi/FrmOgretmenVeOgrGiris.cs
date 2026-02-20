using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            FrmSistemeGiris frm = new FrmSistemeGiris();
            frm.Show();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            FrmSistemeGiris frm = new FrmSistemeGiris();
            frm.Show();
        }
    }
}
