namespace Diseño_de_aplicación
{
    partial class Facturar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturar));
            this.Facturalbl = new System.Windows.Forms.Label();
            this.Digi_corr_de_recupelbl = new System.Windows.Forms.Label();
            this.Fechalbl = new System.Windows.Forms.Label();
            this.Consultarbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Timer(this.components);
            this.Clienteslbl = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Producombbox = new System.Windows.Forms.ComboBox();
            this.Productolbl = new System.Windows.Forms.Label();
            this.Cantidadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Agregaelembtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Terminfacturabtn = new System.Windows.Forms.Button();
            this.Ttotfacturlbl = new System.Windows.Forms.Label();
            this.Facturatxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Facturalbl
            // 
            this.Facturalbl.AutoSize = true;
            this.Facturalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facturalbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.Facturalbl.Location = new System.Drawing.Point(301, 9);
            this.Facturalbl.Name = "Facturalbl";
            this.Facturalbl.Size = new System.Drawing.Size(223, 31);
            this.Facturalbl.TabIndex = 5;
            this.Facturalbl.Text = "Creación Factura";
            this.Facturalbl.Click += new System.EventHandler(this.Facturalbl_Click);
            // 
            // Digi_corr_de_recupelbl
            // 
            this.Digi_corr_de_recupelbl.AutoSize = true;
            this.Digi_corr_de_recupelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digi_corr_de_recupelbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.Digi_corr_de_recupelbl.Location = new System.Drawing.Point(125, 46);
            this.Digi_corr_de_recupelbl.Name = "Digi_corr_de_recupelbl";
            this.Digi_corr_de_recupelbl.Size = new System.Drawing.Size(93, 25);
            this.Digi_corr_de_recupelbl.TabIndex = 6;
            this.Digi_corr_de_recupelbl.Text = "Numero:";
            // 
            // Fechalbl
            // 
            this.Fechalbl.AutoSize = true;
            this.Fechalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.Fechalbl.Location = new System.Drawing.Point(394, 54);
            this.Fechalbl.Name = "Fechalbl";
            this.Fechalbl.Size = new System.Drawing.Size(101, 17);
            this.Fechalbl.TabIndex = 7;
            this.Fechalbl.Text = "Día de Factura";
            // 
            // Consultarbtn
            // 
            this.Consultarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultarbtn.Location = new System.Drawing.Point(23, 39);
            this.Consultarbtn.Name = "Consultarbtn";
            this.Consultarbtn.Size = new System.Drawing.Size(98, 29);
            this.Consultarbtn.TabIndex = 9;
            this.Consultarbtn.Text = "Buscar";
            this.Consultarbtn.UseVisualStyleBackColor = true;
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
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Menu principal";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(501, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 26);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Fecha
            // 
            this.Fecha.Enabled = true;
            this.Fecha.Tick += new System.EventHandler(this.Fecha_Tick);
            // 
            // Clienteslbl
            // 
            this.Clienteslbl.AutoSize = true;
            this.Clienteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clienteslbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.Clienteslbl.Location = new System.Drawing.Point(125, 81);
            this.Clienteslbl.Name = "Clienteslbl";
            this.Clienteslbl.Size = new System.Drawing.Size(96, 25);
            this.Clienteslbl.TabIndex = 12;
            this.Clienteslbl.Text = "Clientes:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Jose Luis",
            "Roberto Gomez",
            "Alberto Torres",
            "Hanna Buitrago"});
            this.comboBox2.Location = new System.Drawing.Point(221, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(294, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // Producombbox
            // 
            this.Producombbox.FormattingEnabled = true;
            this.Producombbox.Items.AddRange(new object[] {
            "Chaquetas",
            "Camisas",
            "Pantalones",
            "Zapatos"});
            this.Producombbox.Location = new System.Drawing.Point(235, 124);
            this.Producombbox.Name = "Producombbox";
            this.Producombbox.Size = new System.Drawing.Size(166, 21);
            this.Producombbox.TabIndex = 15;
            // 
            // Productolbl
            // 
            this.Productolbl.AutoSize = true;
            this.Productolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productolbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.Productolbl.Location = new System.Drawing.Point(125, 120);
            this.Productolbl.Name = "Productolbl";
            this.Productolbl.Size = new System.Drawing.Size(104, 25);
            this.Productolbl.TabIndex = 14;
            this.Productolbl.Text = "Producto:";
            // 
            // Cantidadtxt
            // 
            this.Cantidadtxt.Location = new System.Drawing.Point(235, 156);
            this.Cantidadtxt.Name = "Cantidadtxt";
            this.Cantidadtxt.Size = new System.Drawing.Size(166, 20);
            this.Cantidadtxt.TabIndex = 17;
            this.Cantidadtxt.TextChanged += new System.EventHandler(this.Cantidadtxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(125, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad:";
            // 
            // Agregaelembtn
            // 
            this.Agregaelembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregaelembtn.Location = new System.Drawing.Point(538, 139);
            this.Agregaelembtn.Name = "Agregaelembtn";
            this.Agregaelembtn.Size = new System.Drawing.Size(202, 37);
            this.Agregaelembtn.TabIndex = 18;
            this.Agregaelembtn.Text = "Agregar elementos";
            this.Agregaelembtn.UseVisualStyleBackColor = true;
            this.Agregaelembtn.Click += new System.EventHandler(this.Agregaelembtn_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Cantidad,
            this.Valor});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Silver;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(124, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(616, 128);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 173;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 168;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 230;
            // 
            // Terminfacturabtn
            // 
            this.Terminfacturabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminfacturabtn.Location = new System.Drawing.Point(124, 329);
            this.Terminfacturabtn.Name = "Terminfacturabtn";
            this.Terminfacturabtn.Size = new System.Drawing.Size(202, 37);
            this.Terminfacturabtn.TabIndex = 20;
            this.Terminfacturabtn.Text = "Sacar Factura";
            this.Terminfacturabtn.UseVisualStyleBackColor = true;
            this.Terminfacturabtn.Click += new System.EventHandler(this.Terminfacturabtn_Click);
            // 
            // Ttotfacturlbl
            // 
            this.Ttotfacturlbl.AutoSize = true;
            this.Ttotfacturlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ttotfacturlbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.Ttotfacturlbl.Location = new System.Drawing.Point(364, 339);
            this.Ttotfacturlbl.Name = "Ttotfacturlbl";
            this.Ttotfacturlbl.Size = new System.Drawing.Size(91, 20);
            this.Ttotfacturlbl.TabIndex = 21;
            this.Ttotfacturlbl.Text = "Precio Final";
            this.Ttotfacturlbl.Click += new System.EventHandler(this.Ttotfacturlbl_Click);
            // 
            // Facturatxt
            // 
            this.Facturatxt.Location = new System.Drawing.Point(472, 339);
            this.Facturatxt.Name = "Facturatxt";
            this.Facturatxt.Size = new System.Drawing.Size(255, 20);
            this.Facturatxt.TabIndex = 22;
            this.Facturatxt.TextChanged += new System.EventHandler(this.Facturatxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "CreacionFactura";
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 161);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(501, 536);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 24;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 770);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Facturatxt);
            this.Controls.Add(this.Ttotfacturlbl);
            this.Controls.Add(this.Terminfacturabtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Agregaelembtn);
            this.Controls.Add(this.Cantidadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Producombbox);
            this.Controls.Add(this.Productolbl);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Clienteslbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Consultarbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Fechalbl);
            this.Controls.Add(this.Digi_corr_de_recupelbl);
            this.Controls.Add(this.Facturalbl);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturar";
            this.Text = "Facturar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Facturalbl;
        private System.Windows.Forms.Label Digi_corr_de_recupelbl;
        private System.Windows.Forms.Label Fechalbl;
        private System.Windows.Forms.Button Consultarbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer Fecha;
        private System.Windows.Forms.Label Clienteslbl;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox Producombbox;
        private System.Windows.Forms.Label Productolbl;
        private System.Windows.Forms.TextBox Cantidadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Agregaelembtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.Button Terminfacturabtn;
        private System.Windows.Forms.Label Ttotfacturlbl;
        private System.Windows.Forms.TextBox Facturatxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
    }
}