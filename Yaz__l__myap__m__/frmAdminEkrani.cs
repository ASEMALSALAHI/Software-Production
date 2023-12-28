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

/*Kullandığımız isim alanlarını Using anahtar sözcüğü ile tanımladık.*/

namespace Yazılımyapımı
{
    public partial class frmAdminEkrani : Form
    {
        public frmAdminEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        private void girisyap_Bttn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select *From admin where  adminemail=@adminemail AND adminsifre=@adminsifre";
                SqlParameter prm1 = new SqlParameter("adminemail", email_Txtbox.Text.Trim());
                SqlParameter prm2 = new SqlParameter("adminsifre", sifreTxtbox.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmAdminAnaEkrani fane = new frmAdminAnaEkrani();

                    fane.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifreyi yanlış girdiniz");
                }
                baglanti.Close();



            }
            catch (Exception)
            {
                MessageBox.Show("kullanıcı adı veya şifreyi yanlış girdiniz");

            }
        }

        private void CıkısBttn_Click(object sender, EventArgs e)
        {

            frmAnaekran frmAnaekran = new frmAnaekran();
            frmAnaekran.Show();
            this.Hide();
        }

        private void frmAdminEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
