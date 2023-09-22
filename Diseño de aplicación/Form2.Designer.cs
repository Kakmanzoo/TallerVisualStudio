namespace Diseño_de_aplicación
{
    partial class Menu_de_sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_de_sistema));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Consultarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Productos",
            "Clientes",
            "Facturar",
            "Inventario"});
            this.comboBox1.Location = new System.Drawing.Point(12, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Menu principal";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Consultarbtn
            // 
            this.Consultarbtn.BackColor = System.Drawing.Color.SeaGreen;
            this.Consultarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultarbtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Consultarbtn.Location = new System.Drawing.Point(173, 12);
            this.Consultarbtn.Name = "Consultarbtn";
            this.Consultarbtn.Size = new System.Drawing.Size(135, 50);
            this.Consultarbtn.TabIndex = 1;
            this.Consultarbtn.Text = "Consultar";
            this.Consultarbtn.UseVisualStyleBackColor = false;
            this.Consultarbtn.Click += new System.EventHandler(this.Consultarbtn_Click);
            // 
            // Menu_de_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(322, 80);
            this.Controls.Add(this.Consultarbtn);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_de_sistema";
            this.Text = "Menu_de_sistema";
            this.Load += new System.EventHandler(this.Menu_de_sistema_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Consultarbtn;
    }
}