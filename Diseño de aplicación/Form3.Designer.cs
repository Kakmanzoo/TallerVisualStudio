namespace Diseño_de_aplicación
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.Registrolbl = new System.Windows.Forms.Label();
            this.Digiusualbl = new System.Windows.Forms.Label();
            this.Digicontralbl = new System.Windows.Forms.Label();
            this.Repitacontralbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registrolbl
            // 
            this.Registrolbl.AutoSize = true;
            this.Registrolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Registrolbl.Location = new System.Drawing.Point(184, 97);
            this.Registrolbl.Name = "Registrolbl";
            this.Registrolbl.Size = new System.Drawing.Size(147, 39);
            this.Registrolbl.TabIndex = 0;
            this.Registrolbl.Text = "Registro";
            this.Registrolbl.Click += new System.EventHandler(this.Registrolbl_Click);
            // 
            // Digiusualbl
            // 
            this.Digiusualbl.AutoSize = true;
            this.Digiusualbl.Location = new System.Drawing.Point(116, 286);
            this.Digiusualbl.Name = "Digiusualbl";
            this.Digiusualbl.Size = new System.Drawing.Size(86, 13);
            this.Digiusualbl.TabIndex = 1;
            this.Digiusualbl.Text = "Digite un usuario";
            this.Digiusualbl.Click += new System.EventHandler(this.Digiusualbl_Click);
            // 
            // Digicontralbl
            // 
            this.Digicontralbl.AutoSize = true;
            this.Digicontralbl.Location = new System.Drawing.Point(91, 359);
            this.Digicontralbl.Name = "Digicontralbl";
            this.Digicontralbl.Size = new System.Drawing.Size(111, 13);
            this.Digicontralbl.TabIndex = 2;
            this.Digicontralbl.Text = "Digite una contraseña";
            this.Digicontralbl.Click += new System.EventHandler(this.Digicontralbl_Click);
            // 
            // Repitacontralbl
            // 
            this.Repitacontralbl.AutoSize = true;
            this.Repitacontralbl.Location = new System.Drawing.Point(97, 402);
            this.Repitacontralbl.Name = "Repitacontralbl";
            this.Repitacontralbl.Size = new System.Drawing.Size(105, 13);
            this.Repitacontralbl.TabIndex = 3;
            this.Repitacontralbl.Text = "Repita la contraseña";
            this.Repitacontralbl.Click += new System.EventHandler(this.Repitacontralbl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 352);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 395);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbtn.Location = new System.Drawing.Point(191, 442);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(109, 37);
            this.Guardarbtn.TabIndex = 7;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = true;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(114, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido al Sistema de Recibos :D";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño_de_aplicación.Properties.Resources.logo_chimu;
            this.pictureBox1.Location = new System.Drawing.Point(211, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(209, 316);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingresa un correo electronico";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(532, 537);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardarbtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Repitacontralbl);
            this.Controls.Add(this.Digicontralbl);
            this.Controls.Add(this.Digiusualbl);
            this.Controls.Add(this.Registrolbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Registrolbl;
        private System.Windows.Forms.Label Digiusualbl;
        private System.Windows.Forms.Label Digicontralbl;
        private System.Windows.Forms.Label Repitacontralbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
    }
}