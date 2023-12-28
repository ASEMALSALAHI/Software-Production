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

namespace Yazılımyapımı
{
    public partial class frmAnaekran : Form
    {
        public frmAnaekran()
        {
            InitializeComponent();
        }

        private void UyegirisiBttn_Click(object sender, EventArgs e)
        {
            FrmGirisekrani frmgiris = new FrmGirisekrani();
            this.Hide();
            frmgiris.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminEkrani frmAdmin = new frmAdminEkrani();
            frmAdmin.Show();
        }
    }
}
