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
    public partial class Facturar : Form
    {
        public Facturar()
        {
            InitializeComponent();
        }
        int a = 0, b = 0;

        private void Fecha_Tick(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregaelembtn_Click(object sender, EventArgs e)
        {
            
            if (Producombbox.Text == "Electrodomesticos") {
                ListViewGroup Codigo1 = new ListViewGroup("1", HorizontalAlignment.Left);
                ListViewItem item = new ListViewItem("Nevera", Codigo1);
                item.SubItems.Add(Cantidadtxt.Text);
                a = 25000 * int.Parse(Cantidadtxt.Text);
                string str = a.ToString();
                item.SubItems.Add(str);
                listView1.Items.Add(item);
                Cantidadtxt.Clear();
            }
            b = a;
            if (Producombbox.Text == "Computadores")
            {
                ListViewGroup Codigo1 = new ListViewGroup("2", HorizontalAlignment.Left);
                ListViewItem item = new ListViewItem("Portatil Lenovo", Codigo1);
                item.SubItems.Add(Cantidadtxt.Text);
                a = 20000 * int.Parse(Cantidadtxt.Text);
                string str = a.ToString();
                item.SubItems.Add(str);
                listView1.Items.Add(item);
                Cantidadtxt.Clear();
            }
            b = b + a;
            if (Producombbox.Text == "Tarjeta Madre")
            {
                ListViewGroup Codigo1 = new ListViewGroup("3", HorizontalAlignment.Left);
                ListViewItem item = new ListViewItem("Tarjeta Madre ASUS", Codigo1);
                item.SubItems.Add(Cantidadtxt.Text);
                a = 30000 * int.Parse(Cantidadtxt.Text);
                string str = a.ToString();
                item.SubItems.Add(str);
                listView1.Items.Add(item);
                Cantidadtxt.Clear();
            }
            b = b + a;
            if (Producombbox.Text == "Pantallas")
            {
                ListViewGroup Codigo1 = new ListViewGroup("4", HorizontalAlignment.Left);
                ListViewItem item = new ListViewItem("Pantalla Samsung", Codigo1);
                item.SubItems.Add(Cantidadtxt.Text);
                a = 35000 * int.Parse(Cantidadtxt.Text);
                string str = a.ToString();
                item.SubItems.Add(str);
                listView1.Items.Add(item);
                Cantidadtxt.Clear();
            }
            b = b + a;
        }

        private void Cantidadtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ttotfacturlbl_Click(object sender, EventArgs e)
        {

        }

        private void Terminfacturabtn_Click(object sender, EventArgs e)
        {
            string str = b.ToString();
            if (str!=null) { Facturatxt.Text=str; }
        }

        private void Facturalbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Facturatxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
