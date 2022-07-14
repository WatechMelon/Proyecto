namespace Vista.Usuarios.Productos
{
    partial class Estaciones
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
            this.btnVerano = new System.Windows.Forms.Button();
            this.btnOtonio = new System.Windows.Forms.Button();
            this.btnPrimavera = new System.Windows.Forms.Button();
            this.btnInvierno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerano
            // 
            this.btnVerano.Location = new System.Drawing.Point(197, 76);
            this.btnVerano.Name = "btnVerano";
            this.btnVerano.Size = new System.Drawing.Size(167, 142);
            this.btnVerano.TabIndex = 0;
            this.btnVerano.Text = "Verano";
            this.btnVerano.UseVisualStyleBackColor = true;
            this.btnVerano.Click += new System.EventHandler(this.btnVerano_Click);
            // 
            // btnOtonio
            // 
            this.btnOtonio.Location = new System.Drawing.Point(370, 76);
            this.btnOtonio.Name = "btnOtonio";
            this.btnOtonio.Size = new System.Drawing.Size(167, 142);
            this.btnOtonio.TabIndex = 1;
            this.btnOtonio.Text = "Otoño";
            this.btnOtonio.UseVisualStyleBackColor = true;
            this.btnOtonio.Click += new System.EventHandler(this.btnOtonio_Click);
            // 
            // btnPrimavera
            // 
            this.btnPrimavera.Location = new System.Drawing.Point(370, 224);
            this.btnPrimavera.Name = "btnPrimavera";
            this.btnPrimavera.Size = new System.Drawing.Size(167, 142);
            this.btnPrimavera.TabIndex = 3;
            this.btnPrimavera.Text = "Primavera";
            this.btnPrimavera.UseVisualStyleBackColor = true;
            this.btnPrimavera.Click += new System.EventHandler(this.btnPrimavera_Click);
            // 
            // btnInvierno
            // 
            this.btnInvierno.Location = new System.Drawing.Point(197, 224);
            this.btnInvierno.Name = "btnInvierno";
            this.btnInvierno.Size = new System.Drawing.Size(167, 142);
            this.btnInvierno.TabIndex = 2;
            this.btnInvierno.Text = "Invierno";
            this.btnInvierno.UseVisualStyleBackColor = true;
            this.btnInvierno.Click += new System.EventHandler(this.btnInvierno_Click);
            // 
            // Estaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrimavera);
            this.Controls.Add(this.btnInvierno);
            this.Controls.Add(this.btnOtonio);
            this.Controls.Add(this.btnVerano);
            this.Name = "Estaciones";
            this.Text = "hola";
            this.Load += new System.EventHandler(this.Estaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerano;
        private System.Windows.Forms.Button btnOtonio;
        private System.Windows.Forms.Button btnPrimavera;
        private System.Windows.Forms.Button btnInvierno;
    }
}