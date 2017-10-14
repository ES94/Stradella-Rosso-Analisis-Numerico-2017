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
    public partial class SistemasIngresoDeDatos : Form
    {
        public SistemasIngresoDeDatos(string titulo, int opcion)
        {
            InitializeComponent();
            this.opcion = opcion;
            Text = "Ingreso de datos: " + titulo;
        }

        private int opcion;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SistemasIngresoDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantidadVariables.Text != String.Empty)
            {
                for (int i = 0; i < Convert.ToInt32(txtCantidadVariables.Text) + 1; i++)
                {
                    DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn();
                    if (i == (Convert.ToInt32(txtCantidadVariables.Text)))
                    {
                        Columna.HeaderText = "Resultado";
                    }
                    else
                    {
                        Columna.HeaderText = (i + 1).ToString();
                    }
                    GrillaEcuaciones.Columns.Add(Columna);
                }

                for (int i = 0; i < Convert.ToInt32(txtCantidadVariables.Text) - 1; i++)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    GrillaEcuaciones.Rows.Add(fila);
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool tieneCampoFaltante = false;

            for (int i = 0; i < GrillaEcuaciones.RowCount - 1; i++)
            {
                foreach (DataGridViewCell celda in GrillaEcuaciones.Rows[i].Cells)
                {
                    if (celda.Value == null || celda.Value.ToString() == "")
                    {
                        tieneCampoFaltante = true;
                    }
                }
            }

            if (GrillaEcuaciones.RowCount != 0 && !tieneCampoFaltante)
            {
                int n = GrillaEcuaciones.ColumnCount - 1;
                decimal[,] matrizCoeficientes = new decimal[n, n];
                decimal[] vectorIndependientes = new decimal[n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrizCoeficientes[j, i] = Convert.ToDecimal(GrillaEcuaciones[j, i].Value);
                    }

                    vectorIndependientes[i] = Convert.ToDecimal(GrillaEcuaciones[n, i].Value);
                }

                decimal[] vectorSolucion = opcion == 1 ? 
                    MetodosSistEcuaciones.GaussJordan(matrizCoeficientes, vectorIndependientes) :
                    MetodosSistEcuaciones.GaussSeidel(matrizCoeficientes, vectorIndependientes);
                string mensaje = "";
                int indice = 0;

                foreach (double resultado in vectorSolucion)
                {
                    indice++;
                    mensaje += string.Format("\nX{0} = {1}", indice, resultado);
                }

                MessageBox.Show("Resultado:" + mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mensaje = GrillaEcuaciones.RowCount != 0 ? "Rellene los campos faltantes." : "Cree una grilla para el ingreso de datos.";

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            GrillaEcuaciones.Rows.Clear();
            GrillaEcuaciones.Columns.Clear();
        }

        private void btnCalcDet_Click(object sender, EventArgs e)
        {
            bool tieneCampoFaltante = false;

            for (int i = 0; i < GrillaEcuaciones.RowCount - 1; i++)
            {
                foreach (DataGridViewCell celda in GrillaEcuaciones.Rows[i].Cells)
                {
                    if (celda.Value == null || celda.Value.ToString() == "")
                    {
                        tieneCampoFaltante = true;
                    }
                }
            }

            if (GrillaEcuaciones.RowCount != 0 && !tieneCampoFaltante)
            {
                int n = GrillaEcuaciones.ColumnCount - 1;
                double[,] matrizCoeficientes = new double[n, n];
                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrizCoeficientes[j, i] = Convert.ToDouble(GrillaEcuaciones[j, i].Value);
                    }
                }

                double resultado = MetodosSistEcuaciones.CalcularDeterminante(matrizCoeficientes);

                MessageBox.Show("Resultado:\nEl determinante es " + resultado + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mensaje = GrillaEcuaciones.RowCount != 0 ? "Rellene los campos faltantes." : "Cree una grilla para el ingreso de datos.";

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
