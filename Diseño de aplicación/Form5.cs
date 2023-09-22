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
    public partial class Form5 : Form
    {

        
        

        public Form5()
        {
            InitializeComponent();
        }


        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Consultarbtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Menu principal")
            {
                Menu_de_sistema pagsig = new Menu_de_sistema();
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            if (Codigotxt.Text!=null) { Producombbox.Text = Codigotxt.Text; }
            
            
            MessageBox.Show("Datos guardados");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (Producombbox.Text == "Electodomesticos")
            {
                ListViewGroup Codigo1 = new ListViewGroup("1", HorizontalAlignment.Left);

                ListViewItem item = new ListViewItem("159", Codigo1);
                item.SubItems.Add("Nevera");
                item.SubItems.Add("25,000");
                item.SubItems.Add("10");
                listView1.Items.Add(item);
            }

            if (Producombbox.Text == "Computadores")
            {
                ListViewGroup Codigo2 = new ListViewGroup("2", HorizontalAlignment.Left);

                ListViewItem item = new ListViewItem("260", Codigo2);
                item.SubItems.Add("Computador");
                item.SubItems.Add("20,000");
                item.SubItems.Add("20");
                listView1.Items.Add(item);
            }
            
            if (Producombbox.Text == "Pantalones")
            {
                ListViewGroup Codigo3 = new ListViewGroup("3", HorizontalAlignment.Left);

                ListViewItem item = new ListViewItem("371", Codigo3);
                item.SubItems.Add("Pantalon");
                item.SubItems.Add("30,000");
                item.SubItems.Add("30");
                listView1.Items.Add(item);
            }
            
            if (Producombbox.Text == "Monitores")
            {
                ListViewGroup Codigo4 = new ListViewGroup("4", HorizontalAlignment.Left);

                ListViewItem item = new ListViewItem("482", Codigo4);
                item.SubItems.Add("Pantalla SAMSUNG 75'");
                item.SubItems.Add("35,000");
                item.SubItems.Add("25");
                listView1.Items.Add(item);
            }
            
            if (Producombbox.Text == Codigotxt.Text)
            {
                ListViewGroup Codigo5 = new ListViewGroup("5", HorizontalAlignment.Left);

                ListViewItem item = new ListViewItem(Codigotxt.Text, Codigo5);
                item.SubItems.Add(Dscripciontxt.Text);
                item.SubItems.Add(Valortxt.Text);
                item.SubItems.Add(Cantidadtxt.Text);
                listView1.Items.Add(item);
            }
            
            if (Producombbox.Text == Modcodtxt.Text)
            {
                ListViewGroup Codigo6 = new ListViewGroup("6", HorizontalAlignment.Left);

                ListViewItem item = new ListViewItem(Modcodtxt.Text, Codigo6);
                item.SubItems.Add(Moddesctxt.Text);
                item.SubItems.Add(Modvaltxt.Text);
                item.SubItems.Add(Modcanttxt.Text);
                listView1.Items.Add(item);
            }
        }
        private void Limpiarbtn_Click(object sender, EventArgs e)
        {
            Codigotxt.Clear();
            Dscripciontxt.Clear();
            Valortxt.Clear();
            Cantidadtxt.Clear();
        }

        private void Codigotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dscripciontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cantidadtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Producombbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modificarbtn_Click(object sender, EventArgs e)
        {
            if (Modcodtxt.Text != null) { Producombbox.Text = Modcodtxt.Text; }
            MessageBox.Show("Datos modificados");
        }

        private void Modcodtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Moddesctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modvaltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modcanttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consuproductabpage_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modcodtxt.Clear();
            Moddesctxt.Clear();
            Modvaltxt.Clear();
            Modcanttxt.Clear();
            
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos se eliminaron");
        }

        private void Ingreprodutabpage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
