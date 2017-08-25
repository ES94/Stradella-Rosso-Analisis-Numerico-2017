using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class RaicesIngresoDeDatos : Form
    {
        private static RaicesIngresoDeDatos instancia = null;

        private RaicesIngresoDeDatos()
        {
            InitializeComponent();
        }

        public static RaicesIngresoDeDatos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new RaicesIngresoDeDatos();
            }

            return instancia;
        }

        private void RaicesIngresoDeDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ntxtXi.Text != "" && ntxtXd.Text != "")
            {
                double? Resultado = Metodos.MetodosRaices.Biseccion(Convert.ToDouble(ntxtXi.Text), Convert.ToDouble(ntxtXd.Text));
                if (Resultado == null)
                {
                    MessageBox.Show("No se halló la raiz.", "Metodos Raices", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La raiz es: " + Resultado, "Metodos Raices", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("¡Rellene todos los campos para continuar!", "Metodos Raices", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
