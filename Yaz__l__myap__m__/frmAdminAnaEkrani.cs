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
    public partial class frmAdminAnaEkrani : Form
    {
        public frmAdminAnaEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSinavSorumlu SS = new frmSinavSorumlu();
            SS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sonuc son = new sonuc();
            son.Show();
        }
    }
}
