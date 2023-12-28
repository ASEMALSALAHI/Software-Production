using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılımyapımı
{
    public partial class frmOgrenciAnaEkran : Form
    {
        public frmOgrenciAnaEkran()
        {
            InitializeComponent();
        }
       public ogrenci ogrenc = new ogrenci();
       public frmOgrenciSonucEkrani ogrsonuc = new frmOgrenciSonucEkrani();




        private void button1_Click(object sender, EventArgs e)
        {
            siinav sn = new siinav();
            sn.yogr = ogrenc;
            sn.Show();
            this.Hide();
        }

        private void frmOgrenciAnaEkran_Load(object sender, EventArgs e)
        {
          
            label1.Text = ogrenc.adi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ogrsonuc.ogrson = ogrenc;
            ogrsonuc.Show();
           
        }
    }
}
