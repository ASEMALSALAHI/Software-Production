using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Yazılımyapımı
{
    public partial class sifremiunuttumFrm : Form
    {
        public sifremiunuttumFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        private void cikisBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaekran formana = new frmAnaekran();
           formana.Show();
        }

        private void uyeolBttn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select *From  ogrenci where mail=@email AND cevap=@cevap";
                SqlParameter prm1 = new SqlParameter("email", emailTxtbox.Text.Trim());
                SqlParameter prm2 = new SqlParameter("cevap", cevapTxtbox.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand command = new SqlCommand("select *from ogrenci where mail=@email like '" + emailTxtbox.Text + "'insert into ogrenci sifre value('" + sifreTxtbox+"')", baglanti);
                  
                    baglanti.Close();
                    
                    MessageBox.Show("şifre değiştirildi");

                }
                else
                {
                    MessageBox.Show("kullanıcı1 adı veya cevabı yanlış girdiniz");
                }
                baglanti.Close();



            }
            catch (Exception)
            {
                MessageBox.Show("kullanıcı2 adı veya şifreyi yanlış girdiniz");

            }
        }

        private void sifremiunuttumFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
