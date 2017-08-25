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
            this.mnuPantallaPrincipal = new System.Windows.Forms.MenuStrip();
            this.raícesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBiseccion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReglaFalsa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTangente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSecante = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasDeEcuacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresiónEInterpolaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPantallaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPantallaPrincipal
            // 
            this.mnuPantallaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raícesToolStripMenuItem,
            this.sistemasDeEcuacionesToolStripMenuItem,
            this.regresiónEInterpolaciónToolStripMenuItem,
            this.integraciónToolStripMenuItem});
            this.mnuPantallaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPantallaPrincipal.Name = "mnuPantallaPrincipal";
            this.mnuPantallaPrincipal.Size = new System.Drawing.Size(584, 24);
            this.mnuPantallaPrincipal.TabIndex = 0;
            // 
            // raícesToolStripMenuItem
            // 
            this.raícesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBiseccion,
            this.btnReglaFalsa,
            this.btnTangente,
            this.btnSecante});
            this.raícesToolStripMenuItem.Name = "raícesToolStripMenuItem";
            this.raícesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.raícesToolStripMenuItem.Text = "Raíces";
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(152, 22);
            this.btnBiseccion.Text = "Bisección";
            this.btnBiseccion.Click += new System.EventHandler(this.AbrirVentanaRaices);
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Size = new System.Drawing.Size(152, 22);
            this.btnReglaFalsa.Text = "Regla falsa";
            this.btnReglaFalsa.Click += new System.EventHandler(this.AbrirVentanaRaices);
            // 
            // btnTangente
            // 
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(152, 22);
            this.btnTangente.Text = "Tangente";
            this.btnTangente.Click += new System.EventHandler(this.AbrirVentanaRaices);
            // 
            // btnSecante
            // 
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(152, 22);
            this.btnSecante.Text = "Secante";
            this.btnSecante.Click += new System.EventHandler(this.AbrirVentanaRaices);
            // 
            // sistemasDeEcuacionesToolStripMenuItem
            // 
            this.sistemasDeEcuacionesToolStripMenuItem.Name = "sistemasDeEcuacionesToolStripMenuItem";
            this.sistemasDeEcuacionesToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.sistemasDeEcuacionesToolStripMenuItem.Text = "Sistemas de ecuaciones";
            // 
            // regresiónEInterpolaciónToolStripMenuItem
            // 
            this.regresiónEInterpolaciónToolStripMenuItem.Name = "regresiónEInterpolaciónToolStripMenuItem";
            this.regresiónEInterpolaciónToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.regresiónEInterpolaciónToolStripMenuItem.Text = "Regresión e Interpolación";
            // 
            // integraciónToolStripMenuItem
            // 
            this.integraciónToolStripMenuItem.Name = "integraciónToolStripMenuItem";
            this.integraciónToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.integraciónToolStripMenuItem.Text = "Integración";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 24);
            this.Controls.Add(this.mnuPantallaPrincipal);
            this.MainMenuStrip = this.mnuPantallaPrincipal;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis Numérico";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            this.mnuPantallaPrincipal.ResumeLayout(false);
            this.mnuPantallaPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPantallaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem raícesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBiseccion;
        private System.Windows.Forms.ToolStripMenuItem btnReglaFalsa;
        private System.Windows.Forms.ToolStripMenuItem btnTangente;
        private System.Windows.Forms.ToolStripMenuItem btnSecante;
        private System.Windows.Forms.ToolStripMenuItem sistemasDeEcuacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresiónEInterpolaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integraciónToolStripMenuItem;
    }
}

