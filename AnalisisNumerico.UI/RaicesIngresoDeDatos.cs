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

        private RaicesIngresoDeDatos(string Metodo)
        {
            InitializeComponent();
            MetodoProveniente = Metodo;
            switch (MetodoProveniente)
            {
                case "Biseccion":
                    lblxi.Visible = true;
                    ntxtXi.Visible = true;
                    lblxd.Visible = true;
                    ntxtXd.Visible = true;
                    break;
                case "ReglaFalsa":
                    lblxi.Visible = true;
                    ntxtXi.Visible = true;
                    lblxd.Visible = true;
                    ntxtXd.Visible = true;
                    break;
                case "Tangente":
                    lblxi.Visible = true;
                    ntxtXi.Visible = true;
                    lblxd.Visible = false;
                    ntxtXd.Visible = false;
                    break;
                case "Secante":
                    lblxi.Visible = true;
                    ntxtXi.Visible = true;
                    lblxd.Visible = true;
                    ntxtXd.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public string MetodoProveniente { get; set; }

        public static RaicesIngresoDeDatos ObtenerInstancia(string Metodo)
        {
            if (instancia == null)
            {
                instancia = new RaicesIngresoDeDatos(Metodo);
            }
            return instancia;
        }

        private void RaicesIngresoDeDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (MetodoProveniente == "Biseccion")
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
            else
            {
                if (MetodoProveniente == "ReglaFalsa")
                {

                    if (ntxtXi.Text != "" && ntxtXd.Text != "")
                    {
                        double? Resultado = Metodos.MetodosRaices.ReglaFalsa(Convert.ToDouble(ntxtXi.Text), Convert.ToDouble(ntxtXd.Text));
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
                else
                {
                    if (MetodoProveniente == "Tangente")
                    {                     
                        if (ntxtXi.Text != "")
                        {
                            double? Resultado = Metodos.MetodosRaices.Newton(Convert.ToDouble(ntxtXi.Text));
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
                    else
                    {
                        if (MetodoProveniente == "Secante")
                        {

                            if (ntxtXi.Text != "" && ntxtXd.Text != "")
                            {
                                double? Resultado = Metodos.MetodosRaices.Secante(Convert.ToDouble(ntxtXi.Text), Convert.ToDouble(ntxtXd.Text));
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
            }
        }

        private void RaicesIngresoDeDatos_Load(object sender, EventArgs e)
        {
            lineChart1.LegendTitle = "Leyenda Grafico";
        }
    }
}
