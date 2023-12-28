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
    public partial class sonuc : Form
    {
        public sonuc()
        {
            InitializeComponent();
        }

        private void sonuc_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = yazılımyapımı; Integrated Security = True;");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * from sonuc ", conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            adapter.Fill(data);
            dataGridView1.DataSource = data;
           

            conn.Close();

        }
    }
}
