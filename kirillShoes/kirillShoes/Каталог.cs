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

namespace kirillShoes
{
    public partial class Каталог : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter adapter = null;

        private DataTable table = null;

        public Каталог()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Каталог_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-LT8T67N;Initial Catalog=shoes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            sqlConnection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Product", sqlConnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
