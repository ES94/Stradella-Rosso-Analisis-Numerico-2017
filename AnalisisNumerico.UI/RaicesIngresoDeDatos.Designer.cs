namespace AnalisisNumerico.UI
{
    partial class RaicesIngresoDeDatos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ntxtXi = new Aga.Controls.NumericTextBox();
            this.ntxtXd = new Aga.Controls.NumericTextBox();
            this.lblxi = new System.Windows.Forms.Label();
            this.lblxd = new System.Windows.Forms.Label();
            this.Graficador = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graficador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(224, 365);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(167, 44);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ntxtXi
            // 
            this.ntxtXi.AllowDecimalSeparator = false;
            this.ntxtXi.AllowNegativeSign = false;
            this.ntxtXi.Location = new System.Drawing.Point(20, 27);
            this.ntxtXi.Name = "ntxtXi";
            this.ntxtXi.Size = new System.Drawing.Size(100, 20);
            this.ntxtXi.TabIndex = 1;
            // 
            // ntxtXd
            // 
            this.ntxtXd.AllowDecimalSeparator = false;
            this.ntxtXd.AllowNegativeSign = false;
            this.ntxtXd.Location = new System.Drawing.Point(168, 27);
            this.ntxtXd.Name = "ntxtXd";
            this.ntxtXd.Size = new System.Drawing.Size(100, 20);
            this.ntxtXd.TabIndex = 2;
            // 
            // lblxi
            // 
            this.lblxi.AutoSize = true;
            this.lblxi.Location = new System.Drawing.Point(31, 8);
            this.lblxi.Name = "lblxi";
            this.lblxi.Size = new System.Drawing.Size(17, 13);
            this.lblxi.TabIndex = 3;
            this.lblxi.Text = "XI";
            // 
            // lblxd
            // 
            this.lblxd.AutoSize = true;
            this.lblxd.Location = new System.Drawing.Point(190, 8);
            this.lblxd.Name = "lblxd";
            this.lblxd.Size = new System.Drawing.Size(22, 13);
            this.lblxd.TabIndex = 4;
            this.lblxd.Text = "XD";
            // 
            // Graficador
            // 
            chartArea2.Name = "ChartArea1";
            this.Graficador.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Graficador.Legends.Add(legend2);
            this.Graficador.Location = new System.Drawing.Point(20, 64);
            this.Graficador.Name = "Graficador";
            this.Graficador.Size = new System.Drawing.Size(582, 295);
            this.Graficador.TabIndex = 5;
            this.Graficador.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "F (X) =";
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(395, 27);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(117, 20);
            this.txtFunc.TabIndex = 8;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(527, 25);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 9;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // RaicesIngresoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 421);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graficador);
            this.Controls.Add(this.lblxd);
            this.Controls.Add(this.lblxi);
            this.Controls.Add(this.ntxtXd);
            this.Controls.Add(this.ntxtXi);
            this.Controls.Add(this.btnCalcular);
            this.Name = "RaicesIngresoDeDatos";
            this.Text = "Ingreso de datos: ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaicesIngresoDeDatos_FormClosed);
            this.Load += new System.EventHandler(this.RaicesIngresoDeDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graficador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private Aga.Controls.NumericTextBox ntxtXi;
        private Aga.Controls.NumericTextBox ntxtXd;
        private System.Windows.Forms.Label lblxi;
        private System.Windows.Forms.Label lblxd;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graficador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Button btnGraficar;
    }
}