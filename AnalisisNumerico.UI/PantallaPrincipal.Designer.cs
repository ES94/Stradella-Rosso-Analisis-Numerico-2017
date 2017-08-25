namespace AnalisisNumerico.UI
{
    partial class PantallaPrincipal
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
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.btnReglaFalsa = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Location = new System.Drawing.Point(89, 66);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(246, 80);
            this.btnBiseccion.TabIndex = 0;
            this.btnBiseccion.Text = "BISECCION";
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.Location = new System.Drawing.Point(383, 66);
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Size = new System.Drawing.Size(246, 80);
            this.btnReglaFalsa.TabIndex = 1;
            this.btnReglaFalsa.Text = "REGLA FALSA";
            this.btnReglaFalsa.UseVisualStyleBackColor = true;
            this.btnReglaFalsa.Click += new System.EventHandler(this.btnReglaFalsa_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.Location = new System.Drawing.Point(89, 191);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(246, 80);
            this.btnTangente.TabIndex = 2;
            this.btnTangente.Text = "TANGENTE";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(696, 381);
            this.Controls.Add(this.btnTangente);
            this.Controls.Add(this.btnReglaFalsa);
            this.Controls.Add(this.btnBiseccion);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis Numérico";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.Button btnReglaFalsa;
        private System.Windows.Forms.Button btnTangente;
    }
}

