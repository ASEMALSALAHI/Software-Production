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

/*Kullandığımız isim alanlarını Using anahtar kelimesi ile tanımladık.*/

namespace Yazılımyapımı
{
    public partial class frmSinavSorumlu : Form
    {
        int a;
        public frmSinavSorumlu()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=.;Initial Catalog=yazılımyapımı;Integrated Security=True;");
        SqlConnection baglan = new SqlConnection(constring);
        string imgeLocation = "";
        string cevap = "";
        string cevap_guncelle = "";
        string imgeLocation1 = "";
        OpenFileDialog dialog = new OpenFileDialog();
        //private string imgloc="";
        int soru_id_guncelle;
        int id;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                cevap = "A";
            }
            else if (radioButtonB.Checked)
            {
                cevap = "B";
            }
            else if (radioButtonC.Checked)
            {
                cevap = "C";
            }
            else { cevap = "D"; }

            Byte[] images = null;
            FileStream stream = new FileStream(imgeLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string Rez = "INSERT INTO  soru_tbl(soru_photo,soru_cevap,soru_puan,konu_adi) Values(@photo,@cevap,@puan,@konu)";

                    SqlCommand komut1 = new SqlCommand(Rez, baglan);
                    komut1.Parameters.AddWithValue("@photo", @images);
                    komut1.Parameters.AddWithValue("@cevap", cevap);
                    komut1.Parameters.AddWithValue("@puan", textBoxpuan.Text);
                    komut1.Parameters.AddWithValue("@konu", comboBox1.SelectedItem);


                    komut1.ExecuteNonQuery();

                    MessageBox.Show("Kaydınız yapılmıştır.");
                    sil();
                    baglan.Close();
                    sorular_getir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata" + hata.Message);

            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
            dialog.Filter = "png files (*.png)|*.png|jpg files(*.jpg)|*.jpg|All file (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgeLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgeLocation;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSinavSorumlu_Load(object sender, EventArgs e)
        {
            sorular_getir();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            byte[] imagData = (byte[])dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            MemoryStream ms = new MemoryStream(imagData);
            pictureBox2.Image = Image.FromStream(ms);
            soru_id_guncelle = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;





        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dialog.Filter = "png files (*.png)|*.png|jpg files(*.jpg)|*.jpg|All file (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgeLocation1 = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgeLocation1;

            }
            baglan.Close();

        }

        public void sorular_getir()
        {
            DataTable dt = new DataTable();
            baglan.Open();
            string string_Queryable = "select * from soru_tbl";
            SqlCommand comma = new SqlCommand(string_Queryable, baglan);
            SqlDataReader rdr = comma.ExecuteReader();
            dt.Load(rdr);
            baglan.Close();
            dataGridView1.DataSource = dt;
        }
        public void sil()
        {
            textBoxpuan.Clear();
            imgeLocation = "";
            comboBox1.SelectedIndex = -1;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
            pictureBox1.Invalidate();
            pictureBox1.Image = null;
        }
        public void Soru_guncella_sil()
        {
            textBox1.Clear();
            imgeLocation = "";
            comboBox2.SelectedIndex = -1;
            cevap_guncelleA.Checked = false;
            cevap_guncelleB.Checked = false;
            cevap_guncelleC.Checked = false;
            cevap_guncelleD.Checked = false;
            pictureBox2.Invalidate();
            pictureBox2.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cevap_guncelleA.Checked)
            {
                cevap_guncelle = "A";
            }
            else if (cevap_guncelleB.Checked)
            {
                cevap_guncelle = "B";
            }
            else if (cevap_guncelleC.Checked)
            {
                cevap_guncelle = "C";
            }
            else { cevap_guncelle = "D"; }

            Byte[] imagess = null;
            FileStream streams = new FileStream(imgeLocation1, FileMode.Open, FileAccess.Read);
            BinaryReader brss = new BinaryReader(streams);
            imagess = brss.ReadBytes((int)streams.Length);
            baglan.Open();
            string Rezz = "update  soru_tbl set soru_photo=@photo,soru_cevap=@cevap,soru_puan=@puan,konu_adi=@konu where Id=@id  ";

            SqlCommand komut2 = new SqlCommand(Rezz, baglan);
            komut2.Parameters.AddWithValue("@id", soru_id_guncelle);
            komut2.Parameters.AddWithValue("@photo", @imagess);//@images
            komut2.Parameters.AddWithValue("@cevap", cevap_guncelle);
            komut2.Parameters.AddWithValue("@puan", textBox1.Text);
            komut2.Parameters.AddWithValue("@konu", comboBox2.SelectedItem);


            komut2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kaydınız yapılmıştır.");
            sorular_getir();
            Soru_guncella_sil();
        }
    }
}
