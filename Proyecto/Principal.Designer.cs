namespace Proyecto
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnRepartidor = new System.Windows.Forms.Button();
            this.btnHE = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRepartidor
            // 
            this.btnRepartidor.AccessibleName = "";
            this.btnRepartidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepartidor.Location = new System.Drawing.Point(246, 187);
            this.btnRepartidor.Name = "btnRepartidor";
            this.btnRepartidor.Size = new System.Drawing.Size(274, 112);
            this.btnRepartidor.TabIndex = 2;
            this.btnRepartidor.Text = "REPARTIDOR";
            this.btnRepartidor.UseVisualStyleBackColor = false;
            this.btnRepartidor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHE
            // 
            this.btnHE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHE.Location = new System.Drawing.Point(246, 305);
            this.btnHE.Name = "btnHE";
            this.btnHE.Size = new System.Drawing.Size(274, 112);
            this.btnHE.TabIndex = 3;
            this.btnHE.Text = "HUERTAS ECOLOGICAS";
            this.btnHE.UseVisualStyleBackColor = false;
            this.btnHE.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(246, 69);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(274, 112);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.button3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnHE);
            this.Controls.Add(this.btnRepartidor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRepartidor;
        private System.Windows.Forms.Button btnHE;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

