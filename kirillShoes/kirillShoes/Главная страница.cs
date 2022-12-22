using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirillShoes
{
    public partial class Главная_страница : Form
    {
        public Главная_страница()
        {
            InitializeComponent();
        }

        private void Catalog_Click(object sender, EventArgs e)
        {
            Каталог x = new Каталог();
            x.Show();
        }
    }
}
