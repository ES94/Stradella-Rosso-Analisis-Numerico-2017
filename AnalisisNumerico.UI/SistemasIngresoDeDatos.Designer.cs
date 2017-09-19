namespace AnalisisNumerico.UI
{
    partial class SistemasIngresoDeDatos
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
            this.GrillaEcuaciones = new System.Windows.Forms.DataGridView();
            this.lblCantidadVar = new System.Windows.Forms.Label();
            this.txtCantidadVariables = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEcuaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaEcuaciones
            // 
            this.GrillaEcuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEcuaciones.Location = new System.Drawing.Point(12, 90);
            this.GrillaEcuaciones.Name = "GrillaEcuaciones";
            this.GrillaEcuaciones.RowTemplate.Height = 24;
            this.GrillaEcuaciones.Size = new System.Drawing.Size(807, 415);
            this.GrillaEcuaciones.TabIndex = 0;
            this.GrillaEcuaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblCantidadVar
            // 
            this.lblCantidadVar.AutoSize = true;
            this.lblCantidadVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVar.Location = new System.Drawing.Point(25, 25);
            this.lblCantidadVar.Name = "lblCantidadVar";
            this.lblCantidadVar.Size = new System.Drawing.Size(271, 29);
            this.lblCantidadVar.TabIndex = 1;
            this.lblCantidadVar.Text = "Cantidad de Variables";
            // 
            // txtCantidadVariables
            // 
            this.txtCantidadVariables.Location = new System.Drawing.Point(318, 32);
            this.txtCantidadVariables.Name = "txtCantidadVariables";
            this.txtCantidadVariables.Size = new System.Drawing.Size(79, 22);
            this.txtCantidadVariables.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(459, 25);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // SistemasIngresoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 517);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadVariables);
            this.Controls.Add(this.lblCantidadVar);
            this.Controls.Add(this.GrillaEcuaciones);
            this.Name = "SistemasIngresoDeDatos";
            this.Text = "SistemasIngresoDeDatos";
            this.Load += new System.EventHandler(this.SistemasIngresoDeDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEcuaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaEcuaciones;
        private System.Windows.Forms.Label lblCantidadVar;
        private System.Windows.Forms.TextBox txtCantidadVariables;
        private System.Windows.Forms.Button btnAceptar;
    }
}