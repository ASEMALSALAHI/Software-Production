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
    public partial class frmUyeol : Form
    {

        SqlConnection connection = FrmGirisekrani.baglanti;

        public frmUyeol()
        {
            InitializeComponent();
        }
        
        static string constring = ("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        SqlConnection baglan = new SqlConnection(constring);
        private void cikisBttn_Click(object sender, EventArgs e)
        {
            frmAnaekran frmAnaekran = new frmAnaekran();
           frmAnaekran.Show();
            this.Hide();
        }

        private void uyeolBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                   
                    string Rez = "insert into ogrenci (adi,soyadi,mail,sifre,soru,cevap)values(@adi,@soyadi,@mail,@sifre,@soru,@cevap)";

                    SqlCommand komut = new SqlCommand(Rez, baglan);
                    komut.Parameters.AddWithValue("@adi", textBox1.Text);
                    komut.Parameters.AddWithValue("@soyadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@mail", emailTxtbox.Text);
                    komut.Parameters.AddWithValue("@sifre", sifreTxtbox.Text);
                    komut.Parameters.AddWithValue("@soru", soruCmbbox.Text);
                    komut.Parameters.AddWithValue("@cevap", cevapTxtbox.Text);


                    komut.ExecuteNonQuery();
                    
                    MessageBox.Show("Kaydınız yapılmıştır.");
                    FrmGirisekrani fge=new FrmGirisekrani();
                    fge.Show();
                    this.Hide();

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata" + hata.Message);

            }
        }

        private void frmUyeol_Load(object sender, EventArgs e)
        {

        }
    }
}
