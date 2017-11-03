namespace AnalisisNumerico.UI
{
    partial class RegInterIngresoDatos
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
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.lblCoorX = new System.Windows.Forms.Label();
            this.lblCoorY = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantPts = new System.Windows.Forms.TextBox();
            this.lblCantPts = new System.Windows.Forms.Label();
            this.btnLimpiarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Location = new System.Drawing.Point(12, 85);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.Size = new System.Drawing.Size(260, 334);
            this.dgvPuntos.TabIndex = 0;
            // 
            // lblCoorX
            // 
            this.lblCoorX.AutoSize = true;
            this.lblCoorX.Location = new System.Drawing.Point(72, 69);
            this.lblCoorX.Name = "lblCoorX";
            this.lblCoorX.Size = new System.Drawing.Size(14, 13);
            this.lblCoorX.TabIndex = 1;
            this.lblCoorX.Text = "X";
            // 
            // lblCoorY
            // 
            this.lblCoorY.AutoSize = true;
            this.lblCoorY.Location = new System.Drawing.Point(177, 69);
            this.lblCoorY.Name = "lblCoorY";
            this.lblCoorY.Size = new System.Drawing.Size(14, 13);
            this.lblCoorY.TabIndex = 2;
            this.lblCoorY.Text = "Y";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(197, 34);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(116, 34);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantPts
            // 
            this.txtCantPts.Location = new System.Drawing.Point(10, 36);
            this.txtCantPts.Name = "txtCantPts";
            this.txtCantPts.Size = new System.Drawing.Size(100, 20);
            this.txtCantPts.TabIndex = 5;
            // 
            // lblCantPts
            // 
            this.lblCantPts.AutoSize = true;
            this.lblCantPts.Location = new System.Drawing.Point(10, 17);
            this.lblCantPts.Name = "lblCantPts";
            this.lblCantPts.Size = new System.Drawing.Size(102, 13);
            this.lblCantPts.TabIndex = 6;
            this.lblCantPts.Text = "Cantidad de puntos:";
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(197, 426);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarGrilla.TabIndex = 7;
            this.btnLimpiarGrilla.Text = "Limpiar grilla";
            this.btnLimpiarGrilla.UseVisualStyleBackColor = true;
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // RegInterIngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.btnLimpiarGrilla);
            this.Controls.Add(this.lblCantPts);
            this.Controls.Add(this.txtCantPts);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCoorY);
            this.Controls.Add(this.lblCoorX);
            this.Controls.Add(this.dgvPuntos);
            this.Name = "RegInterIngresoDatos";
            this.Text = "RegInterIngresoDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.Label lblCoorX;
        private System.Windows.Forms.Label lblCoorY;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCantPts;
        private System.Windows.Forms.Label lblCantPts;
        private System.Windows.Forms.Button btnLimpiarGrilla;
    }
}