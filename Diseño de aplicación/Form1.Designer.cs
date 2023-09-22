namespace Diseño_de_aplicación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Titulolbl = new System.Windows.Forms.Label();
            this.Usuariolbl = new System.Windows.Forms.Label();
            this.Contraseñalbl = new System.Windows.Forms.Label();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.Ingresarbtn = new System.Windows.Forms.Button();
            this.Registrarselinklbl = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolbl
            // 
            this.Titulolbl.AutoSize = true;
            this.Titulolbl.BackColor = System.Drawing.Color.Transparent;
            this.Titulolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Titulolbl.Location = new System.Drawing.Point(259, 204);
            this.Titulolbl.Name = "Titulolbl";
            this.Titulolbl.Size = new System.Drawing.Size(282, 31);
            this.Titulolbl.TabIndex = 0;
            this.Titulolbl.Text = "Sistema de Facturas";
            this.Titulolbl.Click += new System.EventHandler(this.Titulolbl_Click);
            // 
            // Usuariolbl
            // 
            this.Usuariolbl.AutoSize = true;
            this.Usuariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariolbl.Location = new System.Drawing.Point(240, 275);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(79, 24);
            this.Usuariolbl.TabIndex = 1;
            this.Usuariolbl.Text = "Usuario:";
            this.Usuariolbl.Click += new System.EventHandler(this.Usuariolbl_Click);
            // 
            // Contraseñalbl
            // 
            this.Contraseñalbl.AutoSize = true;
            this.Contraseñalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñalbl.Location = new System.Drawing.Point(208, 311);
            this.Contraseñalbl.Name = "Contraseñalbl";
            this.Contraseñalbl.Size = new System.Drawing.Size(111, 24);
            this.Contraseñalbl.TabIndex = 2;
            this.Contraseñalbl.Text = "Contraseña:";
            this.Contraseñalbl.Click += new System.EventHandler(this.Contraseñalbl_Click);
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(335, 279);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(215, 20);
            this.Usuariotxt.TabIndex = 3;
            this.Usuariotxt.TextChanged += new System.EventHandler(this.Usuariotxt_TextChanged);
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Location = new System.Drawing.Point(335, 315);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.Size = new System.Drawing.Size(215, 20);
            this.Contraseñatxt.TabIndex = 4;
            this.Contraseñatxt.TextChanged += new System.EventHandler(this.Contraseñatxt_TextChanged);
            // 
            // Ingresarbtn
            // 
            this.Ingresarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresarbtn.Location = new System.Drawing.Point(335, 437);
            this.Ingresarbtn.Name = "Ingresarbtn";
            this.Ingresarbtn.Size = new System.Drawing.Size(155, 41);
            this.Ingresarbtn.TabIndex = 5;
            this.Ingresarbtn.Text = "Iniciar Sesión";
            this.Ingresarbtn.UseVisualStyleBackColor = true;
            this.Ingresarbtn.Click += new System.EventHandler(this.Ingresarbtn_Click);
            // 
            // Registrarselinklbl
            // 
            this.Registrarselinklbl.AutoSize = true;
            this.Registrarselinklbl.Location = new System.Drawing.Point(377, 408);
            this.Registrarselinklbl.Name = "Registrarselinklbl";
            this.Registrarselinklbl.Size = new System.Drawing.Size(55, 13);
            this.Registrarselinklbl.TabIndex = 6;
            this.Registrarselinklbl.TabStop = true;
            this.Registrarselinklbl.Text = "Registrate";
            this.Registrarselinklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registrarselinklbl_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(351, 351);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(116, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "¿Olvido la contraseña?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(330, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido :D";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño_de_aplicación.Properties.Resources.logo_chimu;
            this.pictureBox1.Location = new System.Drawing.Point(54, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(2, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Generador de Recibos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "El Chimuelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(356, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "¿No tienes cuenta?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(785, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.Registrarselinklbl);
            this.Controls.Add(this.Ingresarbtn);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.Contraseñalbl);
            this.Controls.Add(this.Usuariolbl);
            this.Controls.Add(this.Titulolbl);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema de información";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolbl;
        private System.Windows.Forms.Label Usuariolbl;
        private System.Windows.Forms.Label Contraseñalbl;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.TextBox Contraseñatxt;
        private System.Windows.Forms.Button Ingresarbtn;
        private System.Windows.Forms.LinkLabel Registrarselinklbl;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

