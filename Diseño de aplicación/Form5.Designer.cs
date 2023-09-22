
namespace Diseño_de_aplicación
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Consultarbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Gesti_de_produclbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ingreprodutabpage = new System.Windows.Forms.TabPage();
            this.Limpiarbtn = new System.Windows.Forms.Button();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.Cantidadtxt = new System.Windows.Forms.TextBox();
            this.Valortxt = new System.Windows.Forms.TextBox();
            this.Dscripciontxt = new System.Windows.Forms.TextBox();
            this.Codigotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigolbl = new System.Windows.Forms.Label();
            this.Consuproductabpage = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.Producombbox = new System.Windows.Forms.ComboBox();
            this.Productolbl = new System.Windows.Forms.Label();
            this.Modifiprodutabpage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Modificarbtn = new System.Windows.Forms.Button();
            this.Modcanttxt = new System.Windows.Forms.TextBox();
            this.Modvaltxt = new System.Windows.Forms.TextBox();
            this.Moddesctxt = new System.Windows.Forms.TextBox();
            this.Modcodtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Eliminproducttampage = new System.Windows.Forms.TabPage();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.ComboxProdu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Ingreprodutabpage.SuspendLayout();
            this.Consuproductabpage.SuspendLayout();
            this.Modifiprodutabpage.SuspendLayout();
            this.Eliminproducttampage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultarbtn
            // 
            this.Consultarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultarbtn.Location = new System.Drawing.Point(23, 39);
            this.Consultarbtn.Name = "Consultarbtn";
            this.Consultarbtn.Size = new System.Drawing.Size(98, 29);
            this.Consultarbtn.TabIndex = 3;
            this.Consultarbtn.Text = "Buscar";
            this.Consultarbtn.UseVisualStyleBackColor = true;
            this.Consultarbtn.Click += new System.EventHandler(this.Consultarbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Menu principal",
            "Clientes",
            "Facturar",
            "Inventario"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Menu principal";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Gesti_de_produclbl
            // 
            this.Gesti_de_produclbl.AutoSize = true;
            this.Gesti_de_produclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gesti_de_produclbl.Location = new System.Drawing.Point(206, 31);
            this.Gesti_de_produclbl.Name = "Gesti_de_produclbl";
            this.Gesti_de_produclbl.Size = new System.Drawing.Size(411, 37);
            this.Gesti_de_produclbl.TabIndex = 4;
            this.Gesti_de_produclbl.Text = "Configuración de productos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ingreprodutabpage);
            this.tabControl1.Controls.Add(this.Consuproductabpage);
            this.tabControl1.Controls.Add(this.Modifiprodutabpage);
            this.tabControl1.Controls.Add(this.Eliminproducttampage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 336);
            this.tabControl1.TabIndex = 5;
            // 
            // Ingreprodutabpage
            // 
            this.Ingreprodutabpage.BackColor = System.Drawing.Color.Bisque;
            this.Ingreprodutabpage.Controls.Add(this.Limpiarbtn);
            this.Ingreprodutabpage.Controls.Add(this.Guardarbtn);
            this.Ingreprodutabpage.Controls.Add(this.Cantidadtxt);
            this.Ingreprodutabpage.Controls.Add(this.Valortxt);
            this.Ingreprodutabpage.Controls.Add(this.Dscripciontxt);
            this.Ingreprodutabpage.Controls.Add(this.Codigotxt);
            this.Ingreprodutabpage.Controls.Add(this.label3);
            this.Ingreprodutabpage.Controls.Add(this.label2);
            this.Ingreprodutabpage.Controls.Add(this.label1);
            this.Ingreprodutabpage.Controls.Add(this.Codigolbl);
            this.Ingreprodutabpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingreprodutabpage.ForeColor = System.Drawing.Color.LimeGreen;
            this.Ingreprodutabpage.Location = new System.Drawing.Point(4, 34);
            this.Ingreprodutabpage.Name = "Ingreprodutabpage";
            this.Ingreprodutabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Ingreprodutabpage.Size = new System.Drawing.Size(743, 298);
            this.Ingreprodutabpage.TabIndex = 0;
            this.Ingreprodutabpage.Text = "Ingresar producto";
            this.Ingreprodutabpage.Click += new System.EventHandler(this.Ingreprodutabpage_Click);
            // 
            // Limpiarbtn
            // 
            this.Limpiarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbtn.Location = new System.Drawing.Point(417, 232);
            this.Limpiarbtn.Name = "Limpiarbtn";
            this.Limpiarbtn.Size = new System.Drawing.Size(109, 37);
            this.Limpiarbtn.TabIndex = 9;
            this.Limpiarbtn.Text = "Limpiar";
            this.Limpiarbtn.UseVisualStyleBackColor = true;
            this.Limpiarbtn.Click += new System.EventHandler(this.Limpiarbtn_Click);
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbtn.Location = new System.Drawing.Point(211, 232);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(109, 37);
            this.Guardarbtn.TabIndex = 8;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = true;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // Cantidadtxt
            // 
            this.Cantidadtxt.Location = new System.Drawing.Point(279, 169);
            this.Cantidadtxt.Name = "Cantidadtxt";
            this.Cantidadtxt.Size = new System.Drawing.Size(295, 22);
            this.Cantidadtxt.TabIndex = 7;
            this.Cantidadtxt.TextChanged += new System.EventHandler(this.Cantidadtxt_TextChanged);
            // 
            // Valortxt
            // 
            this.Valortxt.Location = new System.Drawing.Point(279, 129);
            this.Valortxt.Name = "Valortxt";
            this.Valortxt.Size = new System.Drawing.Size(295, 22);
            this.Valortxt.TabIndex = 6;
            this.Valortxt.TextChanged += new System.EventHandler(this.Valortxt_TextChanged);
            // 
            // Dscripciontxt
            // 
            this.Dscripciontxt.Location = new System.Drawing.Point(279, 83);
            this.Dscripciontxt.Name = "Dscripciontxt";
            this.Dscripciontxt.Size = new System.Drawing.Size(295, 22);
            this.Dscripciontxt.TabIndex = 5;
            this.Dscripciontxt.TextChanged += new System.EventHandler(this.Dscripciontxt_TextChanged);
            // 
            // Codigotxt
            // 
            this.Codigotxt.Location = new System.Drawing.Point(279, 42);
            this.Codigotxt.Name = "Codigotxt";
            this.Codigotxt.Size = new System.Drawing.Size(295, 22);
            this.Codigotxt.TabIndex = 4;
            this.Codigotxt.TextChanged += new System.EventHandler(this.Codigotxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto:";
            // 
            // Codigolbl
            // 
            this.Codigolbl.AutoSize = true;
            this.Codigolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigolbl.Location = new System.Drawing.Point(173, 39);
            this.Codigolbl.Name = "Codigolbl";
            this.Codigolbl.Size = new System.Drawing.Size(86, 25);
            this.Codigolbl.TabIndex = 0;
            this.Codigolbl.Text = "Codigo:";
            // 
            // Consuproductabpage
            // 
            this.Consuproductabpage.BackColor = System.Drawing.Color.DarkSalmon;
            this.Consuproductabpage.Controls.Add(this.listView1);
            this.Consuproductabpage.Controls.Add(this.button1);
            this.Consuproductabpage.Controls.Add(this.Producombbox);
            this.Consuproductabpage.Controls.Add(this.Productolbl);
            this.Consuproductabpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consuproductabpage.Location = new System.Drawing.Point(4, 34);
            this.Consuproductabpage.Name = "Consuproductabpage";
            this.Consuproductabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Consuproductabpage.Size = new System.Drawing.Size(743, 298);
            this.Consuproductabpage.TabIndex = 1;
            this.Consuproductabpage.Text = "Consultar producto";
            this.Consuproductabpage.Click += new System.EventHandler(this.Consuproductabpage_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nombre,
            this.Valor,
            this.Cantidad});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(67, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(616, 128);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 101;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 181;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 162;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 154;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Producombbox
            // 
            this.Producombbox.FormattingEnabled = true;
            this.Producombbox.Items.AddRange(new object[] {
            "Chaquetas",
            "Camisas",
            "Pantalones",
            "Zapatos"});
            this.Producombbox.Location = new System.Drawing.Point(235, 31);
            this.Producombbox.Name = "Producombbox";
            this.Producombbox.Size = new System.Drawing.Size(365, 24);
            this.Producombbox.TabIndex = 1;
            this.Producombbox.SelectedIndexChanged += new System.EventHandler(this.Producombbox_SelectedIndexChanged);
            // 
            // Productolbl
            // 
            this.Productolbl.AutoSize = true;
            this.Productolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productolbl.Location = new System.Drawing.Point(113, 26);
            this.Productolbl.Name = "Productolbl";
            this.Productolbl.Size = new System.Drawing.Size(116, 29);
            this.Productolbl.TabIndex = 0;
            this.Productolbl.Text = "Producto:";
            // 
            // Modifiprodutabpage
            // 
            this.Modifiprodutabpage.BackColor = System.Drawing.Color.Moccasin;
            this.Modifiprodutabpage.Controls.Add(this.button2);
            this.Modifiprodutabpage.Controls.Add(this.Modificarbtn);
            this.Modifiprodutabpage.Controls.Add(this.Modcanttxt);
            this.Modifiprodutabpage.Controls.Add(this.Modvaltxt);
            this.Modifiprodutabpage.Controls.Add(this.Moddesctxt);
            this.Modifiprodutabpage.Controls.Add(this.Modcodtxt);
            this.Modifiprodutabpage.Controls.Add(this.label5);
            this.Modifiprodutabpage.Controls.Add(this.label6);
            this.Modifiprodutabpage.Controls.Add(this.label7);
            this.Modifiprodutabpage.Controls.Add(this.label8);
            this.Modifiprodutabpage.Controls.Add(this.comboBox2);
            this.Modifiprodutabpage.Controls.Add(this.label4);
            this.Modifiprodutabpage.Location = new System.Drawing.Point(4, 34);
            this.Modifiprodutabpage.Name = "Modifiprodutabpage";
            this.Modifiprodutabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Modifiprodutabpage.Size = new System.Drawing.Size(743, 298);
            this.Modifiprodutabpage.TabIndex = 2;
            this.Modifiprodutabpage.Text = "Modificar producto";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(417, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modificarbtn
            // 
            this.Modificarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificarbtn.Location = new System.Drawing.Point(211, 246);
            this.Modificarbtn.Name = "Modificarbtn";
            this.Modificarbtn.Size = new System.Drawing.Size(109, 37);
            this.Modificarbtn.TabIndex = 16;
            this.Modificarbtn.Text = "Modificar";
            this.Modificarbtn.UseVisualStyleBackColor = true;
            this.Modificarbtn.Click += new System.EventHandler(this.Modificarbtn_Click);
            // 
            // Modcanttxt
            // 
            this.Modcanttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modcanttxt.Location = new System.Drawing.Point(269, 199);
            this.Modcanttxt.Name = "Modcanttxt";
            this.Modcanttxt.Size = new System.Drawing.Size(295, 22);
            this.Modcanttxt.TabIndex = 15;
            this.Modcanttxt.TextChanged += new System.EventHandler(this.Modcanttxt_TextChanged);
            // 
            // Modvaltxt
            // 
            this.Modvaltxt.BackColor = System.Drawing.SystemColors.Window;
            this.Modvaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modvaltxt.Location = new System.Drawing.Point(269, 159);
            this.Modvaltxt.Name = "Modvaltxt";
            this.Modvaltxt.Size = new System.Drawing.Size(295, 22);
            this.Modvaltxt.TabIndex = 14;
            this.Modvaltxt.TextChanged += new System.EventHandler(this.Modvaltxt_TextChanged);
            // 
            // Moddesctxt
            // 
            this.Moddesctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moddesctxt.Location = new System.Drawing.Point(269, 113);
            this.Moddesctxt.Name = "Moddesctxt";
            this.Moddesctxt.Size = new System.Drawing.Size(295, 22);
            this.Moddesctxt.TabIndex = 13;
            this.Moddesctxt.TextChanged += new System.EventHandler(this.Moddesctxt_TextChanged);
            // 
            // Modcodtxt
            // 
            this.Modcodtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modcodtxt.Location = new System.Drawing.Point(269, 72);
            this.Modcodtxt.Name = "Modcodtxt";
            this.Modcodtxt.Size = new System.Drawing.Size(295, 22);
            this.Modcodtxt.TabIndex = 12;
            this.Modcodtxt.TextChanged += new System.EventHandler(this.Modcodtxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Codigo:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Chaquetas",
            "Camisas",
            "Pantalones",
            "Zapatos"});
            this.comboBox2.Location = new System.Drawing.Point(226, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(362, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Producto:";
            // 
            // Eliminproducttampage
            // 
            this.Eliminproducttampage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Eliminproducttampage.Controls.Add(this.Eliminarbtn);
            this.Eliminproducttampage.Controls.Add(this.ComboxProdu);
            this.Eliminproducttampage.Controls.Add(this.label9);
            this.Eliminproducttampage.Location = new System.Drawing.Point(4, 34);
            this.Eliminproducttampage.Name = "Eliminproducttampage";
            this.Eliminproducttampage.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminproducttampage.Size = new System.Drawing.Size(743, 298);
            this.Eliminproducttampage.TabIndex = 3;
            this.Eliminproducttampage.Text = "Eliminar producto";
            this.Eliminproducttampage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbtn.Location = new System.Drawing.Point(308, 174);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(109, 37);
            this.Eliminarbtn.TabIndex = 17;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = true;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // ComboxProdu
            // 
            this.ComboxProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboxProdu.FormattingEnabled = true;
            this.ComboxProdu.Items.AddRange(new object[] {
            "Chaquetas",
            "Camisas",
            "Pantalones",
            "Zapatos"});
            this.ComboxProdu.Location = new System.Drawing.Point(249, 72);
            this.ComboxProdu.Name = "ComboxProdu";
            this.ComboxProdu.Size = new System.Drawing.Size(362, 24);
            this.ComboxProdu.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Producto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño_de_aplicación.Properties.Resources.logo_chimu;
            this.pictureBox1.Location = new System.Drawing.Point(703, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Gesti_de_produclbl);
            this.Controls.Add(this.Consultarbtn);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Form5";
            this.tabControl1.ResumeLayout(false);
            this.Ingreprodutabpage.ResumeLayout(false);
            this.Ingreprodutabpage.PerformLayout();
            this.Consuproductabpage.ResumeLayout(false);
            this.Consuproductabpage.PerformLayout();
            this.Modifiprodutabpage.ResumeLayout(false);
            this.Modifiprodutabpage.PerformLayout();
            this.Eliminproducttampage.ResumeLayout(false);
            this.Eliminproducttampage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Consultarbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Gesti_de_produclbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ingreprodutabpage;
        private System.Windows.Forms.TabPage Consuproductabpage;
        private System.Windows.Forms.TabPage Modifiprodutabpage;
        private System.Windows.Forms.TabPage Eliminproducttampage;
        private System.Windows.Forms.TextBox Cantidadtxt;
        private System.Windows.Forms.TextBox Valortxt;
        private System.Windows.Forms.TextBox Dscripciontxt;
        private System.Windows.Forms.TextBox Codigotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Codigolbl;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.Label Productolbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Producombbox;
        private System.Windows.Forms.Button Limpiarbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Modificarbtn;
        private System.Windows.Forms.TextBox Modcanttxt;
        private System.Windows.Forms.TextBox Modvaltxt;
        private System.Windows.Forms.TextBox Moddesctxt;
        private System.Windows.Forms.TextBox Modcodtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboxProdu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}