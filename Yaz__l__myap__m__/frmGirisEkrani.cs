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
    public partial class FrmGirisekrani : Form
    {
        public FrmGirisekrani()
        {
            InitializeComponent();
        }
       
        public frmOgrenciAnaEkran oae = new frmOgrenciAnaEkran();
        public ogrenci xogr = new ogrenci();
        public siinav sin = new siinav();
        public static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        
        private void Girisyap_Bttn_Click(object sender, EventArgs e)
        {
            try
            {




                baglanti.Open();
                
                string sql = "Select *From ogrenci where mail=@email AND sifre=@şifre";
                SqlParameter prm1 = new SqlParameter("email", email_Txtbox.Text.Trim());
                SqlParameter prm2 = new SqlParameter("şifre", sifreTxtbox.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    string sql11 = "Select id From ogrenci where mail=@email";
                    SqlCommand cmd = new SqlCommand(sql11, baglanti);
                    cmd.Parameters.AddWithValue("@email", email_Txtbox.Text.Trim());
                    xogr.id = (int)cmd.ExecuteScalar();


                    string sql12 = "Select adi From ogrenci where mail=@emaiil";
                    SqlCommand cmd12 = new SqlCommand(sql12, baglanti);
                    cmd12.Parameters.AddWithValue("@emaiil", email_Txtbox.Text.Trim());
                    xogr.adi = (string)cmd12.ExecuteScalar();


                    oae.ogrenc.adi = xogr.adi;
                    oae.ogrenc.id = xogr.id;
                    sin.yogr = xogr;
                    oae.Show();
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
        private void uyeolBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmUyeol uyeolForm1 = new frmUyeol();
            
            uyeolForm1.Show();
            

        }

        private void sifremiunuttumBttn_Click(object sender, EventArgs e)
        {
            sifremiunuttumFrm sifremiunuttumFrm= new sifremiunuttumFrm();
            sifremiunuttumFrm.Show();
            this.Hide();
        }

        private void CikisBttn_Click(object sender, EventArgs e)
        {
            frmAnaekran frmAnaekran = new frmAnaekran();
            frmAnaekran.Show();
            this.Hide();
        }

        private void FrmGirisekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
