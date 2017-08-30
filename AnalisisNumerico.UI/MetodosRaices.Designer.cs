namespace AnalisisNumerico.UI
{
    partial class MetodosRaices
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
            this.gbxMetodosAbiertos = new System.Windows.Forms.GroupBox();
            this.btnSecante = new System.Windows.Forms.Button();
            this.btnTangente = new System.Windows.Forms.Button();
            this.gbxMetodosCerrados = new System.Windows.Forms.GroupBox();
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.btnReglaFalsa = new System.Windows.Forms.Button();
            this.gbxMetodosAbiertos.SuspendLayout();
            this.gbxMetodosCerrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMetodosAbiertos
            // 
            this.gbxMetodosAbiertos.Controls.Add(this.btnSecante);
            this.gbxMetodosAbiertos.Controls.Add(this.btnTangente);
            this.gbxMetodosAbiertos.Location = new System.Drawing.Point(12, 135);
            this.gbxMetodosAbiertos.Name = "gbxMetodosAbiertos";
            this.gbxMetodosAbiertos.Size = new System.Drawing.Size(543, 116);
            this.gbxMetodosAbiertos.TabIndex = 6;
            this.gbxMetodosAbiertos.TabStop = false;
            this.gbxMetodosAbiertos.Text = "Métodos Abiertos";
            // 
            // btnSecante
            // 
            this.btnSecante.Location = new System.Drawing.Point(277, 19);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(246, 80);
            this.btnSecante.TabIndex = 3;
            this.btnSecante.Text = "SECANTE";
            this.btnSecante.UseVisualStyleBackColor = true;
            this.btnSecante.Click += new System.EventHandler(this.btnSecante_Click);
            // 
            // btnTangente
            // 
            this.btnTangente.Location = new System.Drawing.Point(16, 19);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(246, 80);
            this.btnTangente.TabIndex = 2;
            this.btnTangente.Text = "TANGENTE";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // gbxMetodosCerrados
            // 
            this.gbxMetodosCerrados.Controls.Add(this.btnBiseccion);
            this.gbxMetodosCerrados.Controls.Add(this.btnReglaFalsa);
            this.gbxMetodosCerrados.Location = new System.Drawing.Point(12, 12);
            this.gbxMetodosCerrados.Name = "gbxMetodosCerrados";
            this.gbxMetodosCerrados.Size = new System.Drawing.Size(543, 116);
            this.gbxMetodosCerrados.TabIndex = 5;
            this.gbxMetodosCerrados.TabStop = false;
            this.gbxMetodosCerrados.Text = "Métodos Cerrados";
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Location = new System.Drawing.Point(16, 19);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(246, 80);
            this.btnBiseccion.TabIndex = 0;
            this.btnBiseccion.Text = "BISECCION";
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.btnBiseccion_Click);
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.Location = new System.Drawing.Point(277, 19);
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Size = new System.Drawing.Size(246, 80);
            this.btnReglaFalsa.TabIndex = 1;
            this.btnReglaFalsa.Text = "REGLA FALSA";
            this.btnReglaFalsa.UseVisualStyleBackColor = true;
            this.btnReglaFalsa.Click += new System.EventHandler(this.btnReglaFalsa_Click);
            // 
            // MetodosRaices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 263);
            this.Controls.Add(this.gbxMetodosAbiertos);
            this.Controls.Add(this.gbxMetodosCerrados);
            this.Name = "MetodosRaices";
            this.Text = "MetodosRaices";
            this.Load += new System.EventHandler(this.MetodosRaices_Load);
            this.gbxMetodosAbiertos.ResumeLayout(false);
            this.gbxMetodosCerrados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMetodosAbiertos;
        private System.Windows.Forms.Button btnSecante;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.GroupBox gbxMetodosCerrados;
        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.Button btnReglaFalsa;
    }
}