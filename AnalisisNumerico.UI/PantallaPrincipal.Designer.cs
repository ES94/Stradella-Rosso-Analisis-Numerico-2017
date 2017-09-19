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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.btnRaices = new System.Windows.Forms.Button();
            this.btnSistemasEcuaciones = new System.Windows.Forms.Button();
            this.btnRegresion = new System.Windows.Forms.Button();
            this.btnIntegraacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRaices
            // 
            this.btnRaices.BackColor = System.Drawing.Color.Black;
            this.btnRaices.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRaices.Location = new System.Drawing.Point(200, 28);
            this.btnRaices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRaices.Name = "btnRaices";
            this.btnRaices.Size = new System.Drawing.Size(328, 98);
            this.btnRaices.TabIndex = 1;
            this.btnRaices.Text = "RAÍCES DE FUNCIONES";
            this.btnRaices.UseVisualStyleBackColor = false;
            this.btnRaices.Click += new System.EventHandler(this.btnBiseccion_Click);
            // 
            // btnSistemasEcuaciones
            // 
            this.btnSistemasEcuaciones.BackColor = System.Drawing.Color.Black;
            this.btnSistemasEcuaciones.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistemasEcuaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSistemasEcuaciones.Location = new System.Drawing.Point(200, 154);
            this.btnSistemasEcuaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSistemasEcuaciones.Name = "btnSistemasEcuaciones";
            this.btnSistemasEcuaciones.Size = new System.Drawing.Size(328, 98);
            this.btnSistemasEcuaciones.TabIndex = 2;
            this.btnSistemasEcuaciones.Text = "SISTEMAS DE ECUACIONES";
            this.btnSistemasEcuaciones.UseVisualStyleBackColor = false;
            this.btnSistemasEcuaciones.Click += new System.EventHandler(this.btnSistemasEcuaciones_Click);
            // 
            // btnRegresion
            // 
            this.btnRegresion.BackColor = System.Drawing.Color.Black;
            this.btnRegresion.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegresion.Location = new System.Drawing.Point(200, 283);
            this.btnRegresion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresion.Name = "btnRegresion";
            this.btnRegresion.Size = new System.Drawing.Size(328, 98);
            this.btnRegresion.TabIndex = 3;
            this.btnRegresion.Text = "REGRESIÓN E INTERPOLACIÓN";
            this.btnRegresion.UseVisualStyleBackColor = false;
            // 
            // btnIntegraacion
            // 
            this.btnIntegraacion.BackColor = System.Drawing.Color.Black;
            this.btnIntegraacion.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegraacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIntegraacion.Location = new System.Drawing.Point(200, 411);
            this.btnIntegraacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIntegraacion.Name = "btnIntegraacion";
            this.btnIntegraacion.Size = new System.Drawing.Size(328, 98);
            this.btnIntegraacion.TabIndex = 4;
            this.btnIntegraacion.Text = "INTEGRACIÓN NUMÉRICA";
            this.btnIntegraacion.UseVisualStyleBackColor = false;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(763, 540);
            this.Controls.Add(this.btnIntegraacion);
            this.Controls.Add(this.btnRegresion);
            this.Controls.Add(this.btnSistemasEcuaciones);
            this.Controls.Add(this.btnRaices);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis Numérico";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaices;
        private System.Windows.Forms.Button btnSistemasEcuaciones;
        private System.Windows.Forms.Button btnRegresion;
        private System.Windows.Forms.Button btnIntegraacion;
    }
}

