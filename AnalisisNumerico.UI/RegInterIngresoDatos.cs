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
    public partial class RegInterIngresoDatos : Form
    {
        public RegInterIngresoDatos(string metodo)
        {
            Metodo = metodo;
            Text += ": " + metodo;

            InitializeComponent();
        }

        private string Metodo;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool tieneCampoFaltante = false;

            for (int i = 0; i < dgvPuntos.RowCount - 1; i++)
            {
                foreach (DataGridViewCell celda in dgvPuntos.Rows[i].Cells)
                {
                    if (celda.Value == null || celda.Value.ToString() == "")
                    {
                        tieneCampoFaltante = true;
                    }
                }
            }

            if (dgvPuntos.RowCount > 1 && !tieneCampoFaltante)
            {
                int n = dgvPuntos.RowCount - 1;
                List<Punto> listaPuntos = new List<Punto>(n);

                for (int i = 0; i < n; i++)
                {
                    double X = Convert.ToDouble(dgvPuntos[0, i].Value);
                    double Y = Convert.ToDouble(dgvPuntos[1, i].Value);

                    listaPuntos.Add(new Punto(X, Y));
                }

                List<double> resultados = new List<double>();

                if (Metodo == "REGRESIÓN LINEAL POR MÍNIMOS CUADRADOS")
                {
                    resultados = MetodosRegInterpolacion.RegLinealMinCuadrados(listaPuntos);
                }
                else if (Metodo == "REGRESIÓN POLINOMIAL POR MÍNIMOS CUADRADOS")
                {
                    resultados = MetodosRegInterpolacion.RegPoliMinCuadrados(listaPuntos);
                }
                else
                {
                    resultados = MetodosRegInterpolacion.InterpolacionLagrange();
                }

                string mensaje = "Resultados:";

                for (int i = 0; i < resultados.Count - 1; i++)
                {
                    mensaje += string.Format("\na{0} = {1}", i, resultados[i]);
                }

                mensaje += string.Format("\n\nNivel de ajuste: {0}%\nEl ajuste es {1}.", resultados[resultados.Count - 1], 
                    resultados[resultados.Count - 1] < 80 ? "POBRE" : "BUENO");

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string mensaje = tieneCampoFaltante ? "Debe completar todos los campos." : "Debe ingresar como mínimo 2 puntos como datos.";

                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantPts.Text != String.Empty)
            {
                for (int i = 0; i < 2; i++)
                {
                    DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn();

                    dgvPuntos.Columns.Add(Columna);
                }

                for (int i = 0; i < Convert.ToInt32(txtCantPts.Text) - 1; i++)
                {
                    DataGridViewRow fila = new DataGridViewRow();

                    dgvPuntos.Rows.Add(fila);
                }
            }
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            dgvPuntos.Rows.Clear();
            dgvPuntos.Columns.Clear();
        }
    }
}
