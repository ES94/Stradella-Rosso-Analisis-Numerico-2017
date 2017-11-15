using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Metodos;

namespace AnalisisNumerico.UI
{
    public partial class IntegracionIngresoDatos : Form
    {
        public IntegracionIngresoDatos(string metodo)
        {
            InitializeComponent();

            Metodo = metodo;
            Text += ": " + metodo;

            if (metodo == "Trapecio múltiple" || metodo == "Simpson 1/3 múltiple")
            {
                lblCantInt.Visible = true;
                txtCantInt.Visible = true;
            }
            else
            {
                lblCantInt.Visible = false;
                txtCantInt.Visible = false;
            }
        }

        private string Metodo;

        private void btnLimparValores_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtA.Clear();
            txtB.Clear();
            txtCantInt.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            int n = 0;

            if (Metodo == "Trapecio múltiple" || Metodo == "Simpson 1/3 múltiple")
            {
                n = Convert.ToInt32(txtCantInt.Text);
            }

            double resultado = 0;

            switch (Metodo)
            {
                case "Trapecio simple":
                    resultado = MetodosIntegNum.TrapecioSimple(a, b, txtFuncion.Text);

                    break;

                case "Trapecio múltiple":
                    resultado = MetodosIntegNum.TrapecioMultiple(txtFuncion.Text, a, b, n);

                    break;

                case "Simpson 1/3 simple":
                    resultado = MetodosIntegNum.Simpson1_3Simple(txtFuncion.Text, a, b);

                    break;

                case "Simpson 1/3 múltiple":
                    resultado = MetodosIntegNum.Simpson1_3Multiple(txtFuncion.Text, a, b, n);

                    break;
            }

            string mensaje = "Resutlado:\nArea = " + resultado;

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
