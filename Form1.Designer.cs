namespace fondo_de_colores
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
            this.btnazul = new System.Windows.Forms.Button();
            this.btnnaranja = new System.Windows.Forms.Button();
            this.btnverde = new System.Windows.Forms.Button();
            this.btnmorado = new System.Windows.Forms.Button();
            this.btnamarillo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnazul
            // 
            this.btnazul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnazul.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnazul.Location = new System.Drawing.Point(658, 198);
            this.btnazul.Name = "btnazul";
            this.btnazul.Size = new System.Drawing.Size(105, 34);
            this.btnazul.TabIndex = 0;
            this.btnazul.Text = "Azul";
            this.btnazul.UseVisualStyleBackColor = true;
            this.btnazul.Click += new System.EventHandler(this.Btnazul_Click);
            // 
            // btnnaranja
            // 
            this.btnnaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnaranja.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnnaranja.Location = new System.Drawing.Point(658, 285);
            this.btnnaranja.Name = "btnnaranja";
            this.btnnaranja.Size = new System.Drawing.Size(105, 34);
            this.btnnaranja.TabIndex = 2;
            this.btnnaranja.Text = "Naranja";
            this.btnnaranja.UseVisualStyleBackColor = true;
            this.btnnaranja.Click += new System.EventHandler(this.Btnnaranja_Click);
            // 
            // btnverde
            // 
            this.btnverde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverde.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnverde.Location = new System.Drawing.Point(658, 334);
            this.btnverde.Name = "btnverde";
            this.btnverde.Size = new System.Drawing.Size(105, 34);
            this.btnverde.TabIndex = 3;
            this.btnverde.Text = "Verde";
            this.btnverde.UseVisualStyleBackColor = true;
            this.btnverde.Click += new System.EventHandler(this.Btnverde_Click);
            // 
            // btnmorado
            // 
            this.btnmorado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmorado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnmorado.Location = new System.Drawing.Point(658, 374);
            this.btnmorado.Name = "btnmorado";
            this.btnmorado.Size = new System.Drawing.Size(105, 38);
            this.btnmorado.TabIndex = 4;
            this.btnmorado.Text = "Morado";
            this.btnmorado.UseVisualStyleBackColor = true;
            this.btnmorado.Click += new System.EventHandler(this.Btnmorado_Click);
            // 
            // btnamarillo
            // 
            this.btnamarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnamarillo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnamarillo.Location = new System.Drawing.Point(658, 238);
            this.btnamarillo.Name = "btnamarillo";
            this.btnamarillo.Size = new System.Drawing.Size(105, 34);
            this.btnamarillo.TabIndex = 5;
            this.btnamarillo.Text = "Amarillo";
            this.btnamarillo.UseVisualStyleBackColor = true;
            this.btnamarillo.Click += new System.EventHandler(this.Btnamarillo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(283, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Escoge el color del fondo: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnamarillo);
            this.Controls.Add(this.btnmorado);
            this.Controls.Add(this.btnverde);
            this.Controls.Add(this.btnnaranja);
            this.Controls.Add(this.btnazul);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnazul;
        private System.Windows.Forms.Button btnnaranja;
        private System.Windows.Forms.Button btnverde;
        private System.Windows.Forms.Button btnmorado;
        private System.Windows.Forms.Button btnamarillo;
        private System.Windows.Forms.Label lblTitulo;
    }
}

