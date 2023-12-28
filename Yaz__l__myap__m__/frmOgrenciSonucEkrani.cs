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
    public partial class frmOgrenciSonucEkrani : Form
    {
        public frmOgrenciSonucEkrani()
        {
            InitializeComponent();
        }
        public ogrenci ogrson = new ogrenci();

        private void frmOgrenciSonucEkrani_Load(object sender, EventArgs e)
        {
            
            
            SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = yazılımyapımı; Integrated Security = True;");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * from sonuc where ogrenci_id=@id", conn);
            comm.Parameters.AddWithValue("@id", ogrson.id);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            adapter.Fill(data);
            dataGridView1.DataSource = data;

            conn.Close();

        }

        private void CikisBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
