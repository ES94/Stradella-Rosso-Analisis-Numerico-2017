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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblxi = new System.Windows.Forms.Label();
            this.lblxd = new System.Windows.Forms.Label();
            this.Graficador = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.lblTole = new System.Windows.Forms.Label();
            this.lblIter = new System.Windows.Forms.Label();
            this.ntxtIter = new Aga.Controls.NumericTextBox();
            this.txtTole = new System.Windows.Forms.TextBox();
            this.ntxtXd = new System.Windows.Forms.TextBox();
            this.ntxtXi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graficador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(323, 424);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(167, 44);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblxi
            // 
            this.lblxi.AutoSize = true;
            this.lblxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxi.Location = new System.Drawing.Point(24, 11);
            this.lblxi.Name = "lblxi";
            this.lblxi.Size = new System.Drawing.Size(21, 16);
            this.lblxi.TabIndex = 3;
            this.lblxi.Text = "XI";
            // 
            // lblxd
            // 
            this.lblxd.AutoSize = true;
            this.lblxd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxd.Location = new System.Drawing.Point(152, 11);
            this.lblxd.Name = "lblxd";
            this.lblxd.Size = new System.Drawing.Size(28, 16);
            this.lblxd.TabIndex = 4;
            this.lblxd.Text = "XD";
            // 
            // Graficador
            // 
            chartArea1.Name = "ChartArea1";
            this.Graficador.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graficador.Legends.Add(legend1);
            this.Graficador.Location = new System.Drawing.Point(20, 64);
            this.Graficador.Name = "Graficador";
            this.Graficador.Size = new System.Drawing.Size(761, 340);
            this.Graficador.TabIndex = 5;
            this.Graficador.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "F (X) =";
            // 
            // txtFunc
            // 
            this.txtFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunc.Location = new System.Drawing.Point(574, 30);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(117, 24);
            this.txtFunc.TabIndex = 8;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(706, 28);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 9;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // lblTole
            // 
            this.lblTole.AutoSize = true;
            this.lblTole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTole.Location = new System.Drawing.Point(284, 11);
            this.lblTole.Name = "lblTole";
            this.lblTole.Size = new System.Drawing.Size(83, 16);
            this.lblTole.TabIndex = 11;
            this.lblTole.Text = "Tolerancia";
            // 
            // lblIter
            // 
            this.lblIter.AutoSize = true;
            this.lblIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIter.Location = new System.Drawing.Point(390, 11);
            this.lblIter.Name = "lblIter";
            this.lblIter.Size = new System.Drawing.Size(150, 16);
            this.lblIter.TabIndex = 13;
            this.lblIter.Text = "Iteraciones Maximas";
            // 
            // ntxtIter
            // 
            this.ntxtIter.AllowDecimalSeparator = false;
            this.ntxtIter.AllowNegativeSign = false;
            this.ntxtIter.Location = new System.Drawing.Point(408, 30);
            this.ntxtIter.Name = "ntxtIter";
            this.ntxtIter.Size = new System.Drawing.Size(100, 20);
            this.ntxtIter.TabIndex = 12;
            // 
            // txtTole
            // 
            this.txtTole.Location = new System.Drawing.Point(269, 30);
            this.txtTole.Name = "txtTole";
            this.txtTole.Size = new System.Drawing.Size(109, 20);
            this.txtTole.TabIndex = 14;
            // 
            // ntxtXd
            // 
            this.ntxtXd.Location = new System.Drawing.Point(155, 30);
            this.ntxtXd.Name = "ntxtXd";
            this.ntxtXd.Size = new System.Drawing.Size(100, 20);
            this.ntxtXd.TabIndex = 15;
            // 
            // ntxtXi
            // 
            this.ntxtXi.Location = new System.Drawing.Point(27, 30);
            this.ntxtXi.Name = "ntxtXi";
            this.ntxtXi.Size = new System.Drawing.Size(100, 20);
            this.ntxtXi.TabIndex = 16;
            // 
            // RaicesIngresoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(809, 480);
            this.Controls.Add(this.ntxtXi);
            this.Controls.Add(this.ntxtXd);
            this.Controls.Add(this.txtTole);
            this.Controls.Add(this.lblIter);
            this.Controls.Add(this.ntxtIter);
            this.Controls.Add(this.lblTole);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graficador);
            this.Controls.Add(this.lblxd);
            this.Controls.Add(this.lblxi);
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
        private System.Windows.Forms.Label lblxi;
        private System.Windows.Forms.Label lblxd;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graficador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label lblTole;
        private System.Windows.Forms.Label lblIter;
        private Aga.Controls.NumericTextBox ntxtIter;
        private System.Windows.Forms.TextBox txtTole;
        private System.Windows.Forms.TextBox ntxtXd;
        private System.Windows.Forms.TextBox ntxtXi;
    }
}