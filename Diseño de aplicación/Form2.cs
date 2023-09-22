using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_de_aplicación
{
    public partial class Menu_de_sistema : Form
    {
        public Menu_de_sistema()
        {
            InitializeComponent();
        }
        
        private void Menu_de_sistema_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Consultarbtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Productos")
            {
                Form5 pagsig = new Form5();
                pagsig.Show();
                this.Close();
            }

            if (comboBox1.Text == "Facturar")
            {
                Facturar pagsig = new Facturar();
                pagsig.Show();
                this.Close();
            }
        }
    }
}
