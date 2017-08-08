namespace AnalisisNumerico.UI
{
    partial class UIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raícesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasDeEcuacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresiónEInterpolaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodosCerradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodosAbiertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglaFalsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raícesToolStripMenuItem,
            this.sistemasDeEcuacionesToolStripMenuItem,
            this.regresiónEInterpolaciónToolStripMenuItem,
            this.integraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raícesToolStripMenuItem
            // 
            this.raícesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.métodosCerradosToolStripMenuItem,
            this.métodosAbiertosToolStripMenuItem});
            this.raícesToolStripMenuItem.Name = "raícesToolStripMenuItem";
            this.raícesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.raícesToolStripMenuItem.Text = "Raíces";
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
            // métodosCerradosToolStripMenuItem
            // 
            this.métodosCerradosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bisecciónToolStripMenuItem,
            this.reglaFalsaToolStripMenuItem});
            this.métodosCerradosToolStripMenuItem.Name = "métodosCerradosToolStripMenuItem";
            this.métodosCerradosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.métodosCerradosToolStripMenuItem.Text = "Métodos cerrados";
            // 
            // métodosAbiertosToolStripMenuItem
            // 
            this.métodosAbiertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtonToolStripMenuItem,
            this.secanteToolStripMenuItem});
            this.métodosAbiertosToolStripMenuItem.Name = "métodosAbiertosToolStripMenuItem";
            this.métodosAbiertosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.métodosAbiertosToolStripMenuItem.Text = "Métodos abiertos";
            // 
            // bisecciónToolStripMenuItem
            // 
            this.bisecciónToolStripMenuItem.Name = "bisecciónToolStripMenuItem";
            this.bisecciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bisecciónToolStripMenuItem.Text = "Bisección";
            // 
            // reglaFalsaToolStripMenuItem
            // 
            this.reglaFalsaToolStripMenuItem.Name = "reglaFalsaToolStripMenuItem";
            this.reglaFalsaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reglaFalsaToolStripMenuItem.Text = "Regla Falsa";
            // 
            // newtonToolStripMenuItem
            // 
            this.newtonToolStripMenuItem.Name = "newtonToolStripMenuItem";
            this.newtonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newtonToolStripMenuItem.Text = "Newton";
            // 
            // secanteToolStripMenuItem
            // 
            this.secanteToolStripMenuItem.Name = "secanteToolStripMenuItem";
            this.secanteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.secanteToolStripMenuItem.Text = "Secante";
            // 
            // UIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UIPrincipal";
            this.Text = "Análisis Numérico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raícesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasDeEcuacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresiónEInterpolaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodosCerradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bisecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglaFalsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodosAbiertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secanteToolStripMenuItem;
    }
}

