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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean a = false, b = false;
        String contraseña = "abc123";
        String usuario = "Usuariowo";
        private void Usuariotxt_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Contraseñatxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Registrarselinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro pagsig = new Registro();
            pagsig.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 pagsig = new Form4();
            pagsig.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Titulolbl_Click(object sender, EventArgs e)
        {

        }

        private void Usuariolbl_Click(object sender, EventArgs e)
        {

        }

        private void Contraseñalbl_Click(object sender, EventArgs e)
        {

        }

        private void Ingresarbtn_Click(object sender, EventArgs e)
        {
           
            if (Usuariotxt.Text == usuario) { a = true; } 
            if (Contraseñatxt.Text == contraseña) { b = true; }
            if (a && b == true)
            {
                Menu_de_sistema pagsig = new Menu_de_sistema();
                pagsig.Show();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña digitada es incorrecta");
            }
        }
    }
}
