namespace Diseño_de_aplicación
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Recupcontralbl = new System.Windows.Forms.Label();
            this.Digi_corr_de_recupelbl = new System.Windows.Forms.Label();
            this.Digicorrrecutxt = new System.Windows.Forms.TextBox();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Recupcontralbl
            // 
            this.Recupcontralbl.AutoSize = true;
            this.Recupcontralbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recupcontralbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Recupcontralbl.Location = new System.Drawing.Point(37, 9);
            this.Recupcontralbl.Name = "Recupcontralbl";
            this.Recupcontralbl.Size = new System.Drawing.Size(425, 37);
            this.Recupcontralbl.TabIndex = 0;
            this.Recupcontralbl.Text = "Recuperacion de contraseña";
            // 
            // Digi_corr_de_recupelbl
            // 
            this.Digi_corr_de_recupelbl.AutoSize = true;
            this.Digi_corr_de_recupelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digi_corr_de_recupelbl.Location = new System.Drawing.Point(12, 62);
            this.Digi_corr_de_recupelbl.Name = "Digi_corr_de_recupelbl";
            this.Digi_corr_de_recupelbl.Size = new System.Drawing.Size(221, 20);
            this.Digi_corr_de_recupelbl.TabIndex = 1;
            this.Digi_corr_de_recupelbl.Text = "Digite correo de recuperacion:";
            // 
            // Digicorrrecutxt
            // 
            this.Digicorrrecutxt.Location = new System.Drawing.Point(246, 64);
            this.Digicorrrecutxt.Name = "Digicorrrecutxt";
            this.Digicorrrecutxt.Size = new System.Drawing.Size(205, 20);
            this.Digicorrrecutxt.TabIndex = 2;
            this.Digicorrrecutxt.TextChanged += new System.EventHandler(this.Digicorrrecutxt_TextChanged);
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbtn.Location = new System.Drawing.Point(185, 163);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(111, 40);
            this.Buscarbtn.TabIndex = 3;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(124, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿No tiene su correo electronico?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirma tu correo:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(503, 226);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.Digicorrrecutxt);
            this.Controls.Add(this.Digi_corr_de_recupelbl);
            this.Controls.Add(this.Recupcontralbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Recupcontralbl;
        private System.Windows.Forms.Label Digi_corr_de_recupelbl;
        private System.Windows.Forms.TextBox Digicorrrecutxt;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}