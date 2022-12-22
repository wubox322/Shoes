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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            List<String> logins = new List<String>();
            List<String> passwords = new List<String>();
            Boolean avt = false;
            string str = "Data Source=DESKTOP-LT8T67N;Initial Catalog=shoes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str);
            string q = "SELECT login FROM Role";
            using (con)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    logins.Add(reader.GetString(0));
                }
                q = "SELECT password FROM Role";
                reader.Close();

                cmd = new SqlCommand(q, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    passwords.Add(reader.GetString(0));
                }
                reader.Close();
            }

            for (int i = 0; i <= logins.Count - 1; i++)
            {
                if (logins[i].Equals(textBox1.Text) && passwords[i].Equals(textBox2.Text))
                {
                    avt = true;
                }
                else textBox2.Text = "not true";
            }
            if (avt)
            {
                Главная_страница x = new Главная_страница();
                x.Show();
            }
        }
    }
}
    

