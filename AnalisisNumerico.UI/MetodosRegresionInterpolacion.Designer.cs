namespace AnalisisNumerico.UI
{
    partial class MetodosRegresionInterpolacion
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
            this.btnRegLinealMinCuad = new System.Windows.Forms.Button();
            this.btnRegPoliMinCuad = new System.Windows.Forms.Button();
            this.btnInterLagrange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegLinealMinCuad
            // 
            this.btnRegLinealMinCuad.Location = new System.Drawing.Point(68, 44);
            this.btnRegLinealMinCuad.Name = "btnRegLinealMinCuad";
            this.btnRegLinealMinCuad.Size = new System.Drawing.Size(204, 75);
            this.btnRegLinealMinCuad.TabIndex = 0;
            this.btnRegLinealMinCuad.Text = "Regresión lineal por mínimos cuadrados";
            this.btnRegLinealMinCuad.UseVisualStyleBackColor = true;
            this.btnRegLinealMinCuad.Click += new System.EventHandler(this.btnRegInter_Click);
            // 
            // btnRegPoliMinCuad
            // 
            this.btnRegPoliMinCuad.Location = new System.Drawing.Point(68, 164);
            this.btnRegPoliMinCuad.Name = "btnRegPoliMinCuad";
            this.btnRegPoliMinCuad.Size = new System.Drawing.Size(204, 75);
            this.btnRegPoliMinCuad.TabIndex = 1;
            this.btnRegPoliMinCuad.Text = "Regresión polinomial por mínimos cuadrados";
            this.btnRegPoliMinCuad.UseVisualStyleBackColor = true;
            this.btnRegPoliMinCuad.Click += new System.EventHandler(this.btnRegInter_Click);
            // 
            // btnInterLagrange
            // 
            this.btnInterLagrange.Location = new System.Drawing.Point(68, 282);
            this.btnInterLagrange.Name = "btnInterLagrange";
            this.btnInterLagrange.Size = new System.Drawing.Size(204, 75);
            this.btnInterLagrange.TabIndex = 2;
            this.btnInterLagrange.Text = "Interpolación de Lagrange";
            this.btnInterLagrange.UseVisualStyleBackColor = true;
            this.btnInterLagrange.Click += new System.EventHandler(this.btnRegInter_Click);
            // 
            // MetodosRegresionInterpolacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 409);
            this.Controls.Add(this.btnInterLagrange);
            this.Controls.Add(this.btnRegPoliMinCuad);
            this.Controls.Add(this.btnRegLinealMinCuad);
            this.Name = "MetodosRegresionInterpolacion";
            this.Text = "Regresion e Interpolación";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegLinealMinCuad;
        private System.Windows.Forms.Button btnRegPoliMinCuad;
        private System.Windows.Forms.Button btnInterLagrange;
    }
}