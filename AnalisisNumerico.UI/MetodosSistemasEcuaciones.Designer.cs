﻿namespace AnalisisNumerico.UI
{
    partial class MetodosSistemasEcuaciones
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
            this.btnGaussJordan = new System.Windows.Forms.Button();
            this.btnGaussSeide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGaussJordan
            // 
            this.btnGaussJordan.Location = new System.Drawing.Point(41, 48);
            this.btnGaussJordan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGaussJordan.Name = "btnGaussJordan";
            this.btnGaussJordan.Size = new System.Drawing.Size(204, 75);
            this.btnGaussJordan.TabIndex = 0;
            this.btnGaussJordan.Text = "GAUSS - JORDAN";
            this.btnGaussJordan.UseVisualStyleBackColor = true;
            this.btnGaussJordan.Click += new System.EventHandler(this.btnGaussJordan_Click);
            // 
            // btnGaussSeide
            // 
            this.btnGaussSeide.Location = new System.Drawing.Point(305, 48);
            this.btnGaussSeide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGaussSeide.Name = "btnGaussSeide";
            this.btnGaussSeide.Size = new System.Drawing.Size(204, 75);
            this.btnGaussSeide.TabIndex = 1;
            this.btnGaussSeide.Text = "GAUSS - SEIDEL";
            this.btnGaussSeide.UseVisualStyleBackColor = true;
            this.btnGaussSeide.Click += new System.EventHandler(this.btnGaussSeide_Click);
            // 
            // MetodosSistemasEcuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 170);
            this.Controls.Add(this.btnGaussSeide);
            this.Controls.Add(this.btnGaussJordan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MetodosSistemasEcuaciones";
            this.Text = "MetodosSistemasEcuaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGaussJordan;
        private System.Windows.Forms.Button btnGaussSeide;
    }
}