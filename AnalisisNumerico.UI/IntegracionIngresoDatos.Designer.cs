namespace AnalisisNumerico.UI
{
    partial class IntegracionIngresoDatos
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
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtCantInt = new System.Windows.Forms.TextBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblCantInt = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimparValores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(134, 25);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 20);
            this.txtFuncion.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(134, 51);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(134, 77);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 0;
            // 
            // txtCantInt
            // 
            this.txtCantInt.Location = new System.Drawing.Point(134, 103);
            this.txtCantInt.Name = "txtCantInt";
            this.txtCantInt.Size = new System.Drawing.Size(100, 20);
            this.txtCantInt.TabIndex = 0;
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(13, 28);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(48, 13);
            this.lblFuncion.TabIndex = 1;
            this.lblFuncion.Text = "Función:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 54);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "a:";
            // 
            // lblCantInt
            // 
            this.lblCantInt.AutoSize = true;
            this.lblCantInt.Location = new System.Drawing.Point(13, 106);
            this.lblCantInt.Name = "lblCantInt";
            this.lblCantInt.Size = new System.Drawing.Size(115, 13);
            this.lblCantInt.TabIndex = 1;
            this.lblCantInt.Text = "Cantidad de intervalos:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(13, 80);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "b:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(347, 23);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimparValores
            // 
            this.btnLimparValores.Location = new System.Drawing.Point(332, 126);
            this.btnLimparValores.Name = "btnLimparValores";
            this.btnLimparValores.Size = new System.Drawing.Size(90, 23);
            this.btnLimparValores.TabIndex = 2;
            this.btnLimparValores.Text = "Limpiar valores";
            this.btnLimparValores.UseVisualStyleBackColor = true;
            this.btnLimparValores.Click += new System.EventHandler(this.btnLimparValores_Click);
            // 
            // IntegracionIngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.btnLimparValores);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCantInt);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.txtCantInt);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtFuncion);
            this.Name = "IntegracionIngresoDatos";
            this.Text = "Ingreso de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtCantInt;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblCantInt;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimparValores;
    }
}