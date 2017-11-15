namespace AnalisisNumerico.UI
{
    partial class MetodosIntegracion
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
            this.btnTrapecioSim = new System.Windows.Forms.Button();
            this.btnTrapecioMul = new System.Windows.Forms.Button();
            this.btnSimpson13Sim = new System.Windows.Forms.Button();
            this.btnSimpson13Mul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrapecioSim
            // 
            this.btnTrapecioSim.Location = new System.Drawing.Point(35, 22);
            this.btnTrapecioSim.Name = "btnTrapecioSim";
            this.btnTrapecioSim.Size = new System.Drawing.Size(204, 75);
            this.btnTrapecioSim.TabIndex = 0;
            this.btnTrapecioSim.Text = "Trapecio simple";
            this.btnTrapecioSim.UseVisualStyleBackColor = true;
            this.btnTrapecioSim.Click += new System.EventHandler(this.btnIntegracion_Click);
            // 
            // btnTrapecioMul
            // 
            this.btnTrapecioMul.Location = new System.Drawing.Point(35, 103);
            this.btnTrapecioMul.Name = "btnTrapecioMul";
            this.btnTrapecioMul.Size = new System.Drawing.Size(204, 75);
            this.btnTrapecioMul.TabIndex = 0;
            this.btnTrapecioMul.Text = "Trapecio múltiple";
            this.btnTrapecioMul.UseVisualStyleBackColor = true;
            this.btnTrapecioMul.Click += new System.EventHandler(this.btnIntegracion_Click);
            // 
            // btnSimpson13Sim
            // 
            this.btnSimpson13Sim.Location = new System.Drawing.Point(35, 184);
            this.btnSimpson13Sim.Name = "btnSimpson13Sim";
            this.btnSimpson13Sim.Size = new System.Drawing.Size(204, 75);
            this.btnSimpson13Sim.TabIndex = 0;
            this.btnSimpson13Sim.Text = "Simpson 1/3 simple";
            this.btnSimpson13Sim.UseVisualStyleBackColor = true;
            this.btnSimpson13Sim.Click += new System.EventHandler(this.btnIntegracion_Click);
            // 
            // btnSimpson13Mul
            // 
            this.btnSimpson13Mul.Location = new System.Drawing.Point(35, 265);
            this.btnSimpson13Mul.Name = "btnSimpson13Mul";
            this.btnSimpson13Mul.Size = new System.Drawing.Size(204, 75);
            this.btnSimpson13Mul.TabIndex = 0;
            this.btnSimpson13Mul.Text = "Simpson 1/3 múltiple";
            this.btnSimpson13Mul.UseVisualStyleBackColor = true;
            this.btnSimpson13Mul.Click += new System.EventHandler(this.btnIntegracion_Click);
            // 
            // MetodosIntegracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.btnSimpson13Mul);
            this.Controls.Add(this.btnSimpson13Sim);
            this.Controls.Add(this.btnTrapecioMul);
            this.Controls.Add(this.btnTrapecioSim);
            this.Name = "MetodosIntegracion";
            this.Text = "Integración numérica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrapecioSim;
        private System.Windows.Forms.Button btnTrapecioMul;
        private System.Windows.Forms.Button btnSimpson13Sim;
        private System.Windows.Forms.Button btnSimpson13Mul;
    }
}