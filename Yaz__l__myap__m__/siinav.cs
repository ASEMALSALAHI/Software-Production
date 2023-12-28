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
using System.IO;
using System.Drawing.Imaging;

namespace Yazılımyapımı
{
    public partial class siinav : Form
    {
        int dakika = 0, saniye =10 ;
        public siinav()
        {
            InitializeComponent();
        }
        public ogrenci yogr = new ogrenci();
        public int x = 0;
        public int y = 0;
        public int z = 0;
        public int soru_id { get; set; }
        public int[] soru = new int[100];
        public int dogru_soru_sayisi { get; set; }
        public int yanlis_soru_sayisi { get; set; }
        public int bos_soru_sayisi { get; set; }
        public int soru_numara { get; set; }
        public int toplam_puan { get; set; }
        public int sinav_ogr_id { get; set; }
        public string sinav_ogr_adi { get; set; }
        string imgeLocation1 ="";
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = yazılımyapımı; Integrated Security = True;");
        SqlCommand comm;
        SqlCommand com2;
        SqlCommand com3;
        SqlDataReader red3;
        SqlCommand com;
        SqlCommand com1;
        SqlDataReader reder;
        SqlDataAdapter da;
        string secencevap;
      public  frmOgrenciAnaEkran ogranar = new frmOgrenciAnaEkran();
       
        public void sorular()
        {
            for (int i = 0; i < 10; i++)
            {
                com = new SqlCommand("SELECT TOP 1 soru_tbl.Id FROM soru_tbl ORDER BY NEWID()", conn);
                conn.Open();
                soru[i] = (int)com.ExecuteScalar();
                soru_numara++;
                conn.Close();
            }
        }

        private void siinav_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
           
            label3.Text = "0";
            timer1.Start(); timer2.Start();

            sinav_ogr_id = yogr.id;
            sinav_ogr_adi = yogr.adi;
            MessageBox.Show("Sevgili öğrencimiz: "+sinav_ogr_adi+"     başarılar dileriz" );
            label1.Text = yogr.adi;

            sorular();

            conn.Open();
            com1 = new SqlCommand("SELECT  soru_photo  from soru_tbl where ID=@id", conn);
            com1.Parameters.AddWithValue("@id", soru[x]);
            DataTable table = new DataTable();
            da = new SqlDataAdapter(com1);
            da.Fill(table);
            Byte[] img = (Byte[])table.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            conn.Close();
            conn.Open();
            com2 = new SqlCommand("SELECT soru_cevap  from soru_tbl where ID=@id", conn);
            com2.Parameters.AddWithValue("@id", soru[x]);
            secencevap = (string)com2.ExecuteScalar();
            conn.Close();
        }
        public void imggetir()
        {
            conn.Open();
            com1 = new SqlCommand("SELECT soru_photo,soru_cevap  from soru_tbl where ID=@id", conn);
            com1.Parameters.AddWithValue("@id", soru[x]);
            DataTable table = new DataTable();
            da = new SqlDataAdapter(com1);
            da.Fill(table);
            Byte[] img = (Byte[])table.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            conn.Close();


            conn.Open();
            com2 = new SqlCommand("SELECT soru_cevap  from soru_tbl where ID=@id", conn);
            com2.Parameters.AddWithValue("@id", soru[x]);
            secencevap = (string)com2.ExecuteScalar();
            conn.Close();
            x++;
            RadioButunSifirla();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (x < 10)
            {
                if (cevapA.Checked)
                {
                    if (cevapA.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else 
                    { 
                        yanlis_soru_sayisi++;
                    }
                }
                else if (cevapB.Checked)
                {
                    if (cevapB.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else
                    {
                        yanlis_soru_sayisi++; 
                    }
                }
                else if (cevapC.Checked)
                {
                    if (cevapC.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else 
                    {
                        yanlis_soru_sayisi++; 
                    }
                }
                else if (cevapD.Checked)
                {
                    if (cevapD.Text == secencevap)
                    {
                        dogru_soru_sayisi++;
                    }
                    else
                    {
                        yanlis_soru_sayisi++; 
                    }
                }
                else
                {
                    bos_soru_sayisi++;
                }
                toplam_puan = dogru_soru_sayisi * 10;




                //imggetir();
                conn.Open();
                com1 = new SqlCommand("SELECT soru_photo,soru_cevap  from soru_tbl where ID=@id", conn);
                com1.Parameters.AddWithValue("@id", soru[x]);
                DataTable table = new DataTable();
                da = new SqlDataAdapter(com1);
                da.Fill(table);

                Byte[] img = (Byte[])table.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                conn.Close();
                conn.Open();
                com2 = new SqlCommand("SELECT soru_cevap  from soru_tbl where ID=@id", conn);
                com2.Parameters.AddWithValue("@id", soru[x]);
                secencevap = (string)com2.ExecuteScalar();
                conn.Close();
                x++;
                RadioButunSifirla();
            }
            
            else
            {
                sinavbitir();   
            }
        }

        public void sinavbitir()
        {
            result();
            frmOgrenciAnaEkran foae1 = new frmOgrenciAnaEkran();
            foae1.ogrenc.adi = sinav_ogr_adi;
            foae1.ogrenc.id = sinav_ogr_id;
            foae1.Show();
            this.Hide();

        }

        public  void result()
        {
            conn.Open();
            string rez = "INSERT INTO sonuc(ogrenci_id,dogru_soru_sayisi,yanlis_soru_sayisi,bos_soru_sayisi,toplam_puan,ogrenci_adi) VALUES (@oid,@dogru,@yanlis,@bos,@puan,@ogrenciadi)";
            comm = new SqlCommand(rez, conn);
            comm.Parameters.AddWithValue("@oid", sinav_ogr_id);
            comm.Parameters.AddWithValue("@dogru", dogru_soru_sayisi);
            comm.Parameters.AddWithValue("@yanlis", yanlis_soru_sayisi);
            comm.Parameters.AddWithValue("@bos", bos_soru_sayisi);
            comm.Parameters.AddWithValue("@puan", toplam_puan);
            comm.Parameters.AddWithValue("@ogrenciadi", sinav_ogr_adi);
            comm.ExecuteNonQuery();
            conn.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dakika==0)
            {
                MessageBox.Show("Süreniz bitti sonuç ekranına yönlendiriliyorsunuz");
                sinavbitir();

            }
            label2.Text = dakika.ToString();
            dakika--;
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(saniye==0)
            {
                saniye = 60;
            }
            label3.Text = saniye.ToString();
            label2.Text = dakika.ToString();
            saniye--;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void  RadioButunSifirla()
        {
            cevapA.Checked = false;
            cevapB.Checked = false;
            cevapC.Checked = false;
            cevapD.Checked = false;

        }
    }
}
