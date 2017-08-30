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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ntxtXi = new Aga.Controls.NumericTextBox();
            this.ntxtXd = new Aga.Controls.NumericTextBox();
            this.lblxi = new System.Windows.Forms.Label();
            this.lblxd = new System.Windows.Forms.Label();
            this.lineChart1 = new MindFusion.Charting.WinForms.LineChart();
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
            // lineChart1
            // 
            this.lineChart1.DateTimeFormat = null;
            this.lineChart1.LegendTitle = "Legend";
            this.lineChart1.Location = new System.Drawing.Point(34, 70);
            this.lineChart1.Name = "lineChart1";
            this.lineChart1.Padding = new System.Windows.Forms.Padding(5);
            this.lineChart1.ShowLegend = true;
            this.lineChart1.Size = new System.Drawing.Size(535, 275);
            this.lineChart1.SubtitleFontName = null;
            this.lineChart1.SubtitleFontSize = null;
            this.lineChart1.SubtitleFontStyle = null;
            this.lineChart1.TabIndex = 5;
            this.lineChart1.Text = "lineChart1";
            this.lineChart1.TitleFontName = null;
            this.lineChart1.TitleFontSize = null;
            this.lineChart1.TitleFontStyle = null;
            // 
            // RaicesIngresoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 421);
            this.Controls.Add(this.lineChart1);
            this.Controls.Add(this.lblxd);
            this.Controls.Add(this.lblxi);
            this.Controls.Add(this.ntxtXd);
            this.Controls.Add(this.ntxtXi);
            this.Controls.Add(this.btnCalcular);
            this.Name = "RaicesIngresoDeDatos";
            this.Text = "Ingreso de datos: ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RaicesIngresoDeDatos_FormClosed);
            this.Load += new System.EventHandler(this.RaicesIngresoDeDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private Aga.Controls.NumericTextBox ntxtXi;
        private Aga.Controls.NumericTextBox ntxtXd;
        private System.Windows.Forms.Label lblxi;
        private System.Windows.Forms.Label lblxd;
        private MindFusion.Charting.WinForms.LineChart lineChart1;
    }
}