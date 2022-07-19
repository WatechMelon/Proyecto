namespace Vista.Huerta
{
    partial class HuertaE
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
            this.comboTam = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.datePlantas = new System.Windows.Forms.DateTimePicker();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtMetas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboEspecie2 = new System.Windows.Forms.ComboBox();
            this.comboEspecie4 = new System.Windows.Forms.ComboBox();
            this.comboEspecie3 = new System.Windows.Forms.ComboBox();
            this.comboEspecie1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboTam
            // 
            this.comboTam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTam.FormattingEnabled = true;
            this.comboTam.Items.AddRange(new object[] {
            "Pequeña",
            "Mediana"});
            this.comboTam.Location = new System.Drawing.Point(142, 15);
            this.comboTam.Name = "comboTam";
            this.comboTam.Size = new System.Drawing.Size(200, 21);
            this.comboTam.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(28, 303);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // datePlantas
            // 
            this.datePlantas.Location = new System.Drawing.Point(142, 249);
            this.datePlantas.Name = "datePlantas";
            this.datePlantas.Size = new System.Drawing.Size(200, 20);
            this.datePlantas.TabIndex = 3;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Siembra",
            "Emergencia",
            "Vegetativo",
            "Reproductivo",
            "Madurez"});
            this.comboEstado.Location = new System.Drawing.Point(142, 174);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(200, 21);
            this.comboEstado.TabIndex = 4;
            this.comboEstado.Text = "Seleccionar Estado";
            // 
            // txtMetas
            // 
            this.txtMetas.Location = new System.Drawing.Point(186, 212);
            this.txtMetas.Name = "txtMetas";
            this.txtMetas.Size = new System.Drawing.Size(156, 20);
            this.txtMetas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Plantacion *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meta Cultivos (En KG) *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tamaño de la huerta *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado del Cultivo *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Especie 1 *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Especie 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Especie 4 (Huertas Medianas)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Especie 3";
            // 
            // comboEspecie2
            // 
            this.comboEspecie2.FormattingEnabled = true;
            this.comboEspecie2.Items.AddRange(new object[] {
            "Apio     ",
            "Porotov  ",
            "Lechuga  ",
            "Acelga   ",
            "Ajo      ",
            "Berenjena",
            "Betarraga",
            "Cebollin ",
            "Cebolla  ",
            "Choclo   ",
            "Frutilla ",
            "Papa     ",
            "Poroto   ",
            "Repollo  ",
            "Tomate   ",
            "Zanahoria",
            "Habas    ",
            "Arvejas  ",
            "Pimenton "});
            this.comboEspecie2.Location = new System.Drawing.Point(186, 75);
            this.comboEspecie2.Name = "comboEspecie2";
            this.comboEspecie2.Size = new System.Drawing.Size(156, 21);
            this.comboEspecie2.TabIndex = 18;
            this.comboEspecie2.Text = "Elegir Especie";
            // 
            // comboEspecie4
            // 
            this.comboEspecie4.FormattingEnabled = true;
            this.comboEspecie4.Items.AddRange(new object[] {
            "Apio     ",
            "Porotov  ",
            "Lechuga  ",
            "Acelga   ",
            "Ajo      ",
            "Berenjena",
            "Betarraga",
            "Cebollin ",
            "Cebolla  ",
            "Choclo   ",
            "Frutilla ",
            "Papa     ",
            "Poroto   ",
            "Repollo  ",
            "Tomate   ",
            "Zanahoria",
            "Habas    ",
            "Arvejas  ",
            "Pimenton "});
            this.comboEspecie4.Location = new System.Drawing.Point(186, 129);
            this.comboEspecie4.Name = "comboEspecie4";
            this.comboEspecie4.Size = new System.Drawing.Size(156, 21);
            this.comboEspecie4.TabIndex = 19;
            this.comboEspecie4.Text = "Elegir Especie";
            // 
            // comboEspecie3
            // 
            this.comboEspecie3.FormattingEnabled = true;
            this.comboEspecie3.Items.AddRange(new object[] {
            "Apio     ",
            "Porotov  ",
            "Lechuga  ",
            "Acelga   ",
            "Ajo      ",
            "Berenjena",
            "Betarraga",
            "Cebollin ",
            "Cebolla  ",
            "Choclo   ",
            "Frutilla ",
            "Papa     ",
            "Poroto   ",
            "Repollo  ",
            "Tomate   ",
            "Zanahoria",
            "Habas    ",
            "Arvejas  ",
            "Pimenton "});
            this.comboEspecie3.Location = new System.Drawing.Point(186, 102);
            this.comboEspecie3.Name = "comboEspecie3";
            this.comboEspecie3.Size = new System.Drawing.Size(156, 21);
            this.comboEspecie3.TabIndex = 20;
            this.comboEspecie3.Text = "Elegir Especie";
            // 
            // comboEspecie1
            // 
            this.comboEspecie1.FormattingEnabled = true;
            this.comboEspecie1.Items.AddRange(new object[] {
            "Apio     ",
            "Porotov  ",
            "Lechuga  ",
            "Acelga   ",
            "Ajo      ",
            "Berenjena",
            "Betarraga",
            "Cebollin ",
            "Cebolla  ",
            "Choclo   ",
            "Frutilla ",
            "Papa     ",
            "Poroto   ",
            "Repollo  ",
            "Tomate   ",
            "Zanahoria",
            "Habas    ",
            "Arvejas  ",
            "Pimenton "});
            this.comboEspecie1.Location = new System.Drawing.Point(186, 48);
            this.comboEspecie1.Name = "comboEspecie1";
            this.comboEspecie1.Size = new System.Drawing.Size(156, 21);
            this.comboEspecie1.TabIndex = 21;
            this.comboEspecie1.Text = "Elegir Especie";
            // 
            // HuertaE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(364, 351);
            this.Controls.Add(this.comboEspecie1);
            this.Controls.Add(this.comboEspecie3);
            this.Controls.Add(this.comboEspecie4);
            this.Controls.Add(this.comboEspecie2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetas);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.datePlantas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboTam);
            this.MaximizeBox = false;
            this.Name = "HuertaE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HuertaE";
            this.Load += new System.EventHandler(this.HuertaE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTam;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker datePlantas;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtMetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboEspecie2;
        private System.Windows.Forms.ComboBox comboEspecie4;
        private System.Windows.Forms.ComboBox comboEspecie3;
        private System.Windows.Forms.ComboBox comboEspecie1;
    }
}