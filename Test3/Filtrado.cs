using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test3
{
    public partial class Filtrado : Form
    {
        public Filtrado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnhordoc_Click(object sender, EventArgs e)
        {
            Form horarios = new Horarios(txtidconsulta.Text,1);
            horarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
