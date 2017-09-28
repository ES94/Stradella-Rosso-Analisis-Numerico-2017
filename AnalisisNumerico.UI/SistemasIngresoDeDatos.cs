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
        public SistemasIngresoDeDatos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SistemasIngresoDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Convert.ToInt32(btnAceptar.Text); i++)
            //{
            //    GrillaEcuaciones.ColumnAdded();
            //}
            //GrillaEcuaciones.ColumnCount = Convert.ToInt32(btnAceptar.Text);
            //GrillaEcuaciones.RowCount = Convert.ToInt32(btnAceptar.Text);

            for (int i = 0; i < Convert.ToInt32(txtCantidadVariables.Text); i++)
            {
                DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn();
                Columna.HeaderText = "A" +  (i + 1).ToString();
                GrillaEcuaciones.Columns.Add(Columna);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool tieneCampoFaltante = false;

            foreach (DataGridViewRow fila in GrillaEcuaciones.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value ==null && celda.Value.ToString() == "")
                    {
                        tieneCampoFaltante = true;
                    }
                }
            }

            if (GrillaEcuaciones.RowCount != 0 && !tieneCampoFaltante)
            {
                List<List<double>> matrizCoeficientes = new List<List<double>>();

                foreach (DataGridViewRow fila in GrillaEcuaciones.Rows)
                {
                    List<double> filaCoeficientes = new List<double>();

                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaCoeficientes.Add(Convert.ToDouble(celda.Value));
                    }

                    matrizCoeficientes.Add(filaCoeficientes);
                }

                List<double> vectorResultado = MetodosSistEcuaciones.GaussJordan(matrizCoeficientes);
                string mensaje = "";
                int indice = 0;

                foreach (double resultado in vectorResultado)
                {
                    indice++;
                    mensaje = string.Format("\nX{0} = {1}", indice, resultado);
                }

                MessageBox.Show("Resultado:" + mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mensaje = GrillaEcuaciones.RowCount != 0 ? "Rellene los campos faltantes." : "Cree una grilla para el ingreso de datos.";

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
