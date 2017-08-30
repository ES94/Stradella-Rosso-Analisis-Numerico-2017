using Microsoft.JScript;
using Microsoft.JScript.Vsa;
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
                    double? Resultado = Metodos.MetodosRaices.Biseccion(System.Convert.ToDouble(ntxtXi.Text), System.Convert.ToDouble(ntxtXd.Text));
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
                        double? Resultado = Metodos.MetodosRaices.ReglaFalsa(System.Convert.ToDouble(ntxtXi.Text), System.Convert.ToDouble(ntxtXd.Text));
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
                            double? Resultado = Metodos.MetodosRaices.Newton(System.Convert.ToDouble(ntxtXi.Text));
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
                                double? Resultado = Metodos.MetodosRaices.Secante(System.Convert.ToDouble(ntxtXi.Text), System.Convert.ToDouble(ntxtXd.Text));
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
        }

        private void ChartSeries()
        {
            Graficador.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Color = System.Drawing.Color.Blue,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true, 
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline,
            };
            for (int x = 0; x < 5; x++)
            {
                string ExpresionEvaluar = ReemplazarCaracter(txtFunc.Text, x);
                string ValorY = EvalExpression(ExpresionEvaluar);               
                series1.Points.AddXY(x, System.Convert.ToDouble(ValorY));
            }
            series1.LegendText = "y = " + txtFunc.Text;
            Graficador.Series.Add(series1);
        }
        private string ReemplazarCaracter(string Expresion, int val)
        {
            List<string> ListaExpresion = new List<string>();
            string ExpresionFinal = "";
            for (int i = 0; i < Expresion.Length; i++)
            {
                ListaExpresion.Add(Expresion[i].ToString());
            }

            for (int i = 0; i < ListaExpresion.Count; i++)
            {
                if (ListaExpresion[i] == "x" || ListaExpresion[i] == "X")
                {
                    ListaExpresion[i] = val.ToString();
                }
            }
            for (int i = 0; i < ListaExpresion.Count; i++)
            {
                ExpresionFinal = ExpresionFinal + ListaExpresion[i];
            }

            return ExpresionFinal;
        }

        private string EvalExpression(string expression)
        {
            VsaEngine engine = VsaEngine.CreateEngine();
            try
            {
                object o = Eval.JScriptEvaluate(expression, engine);
                return System.Convert.ToDouble(o).ToString();
            }
            catch
            {
                return "No se puede evaluar la expresión";
            }
            engine.Close();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            ChartSeries();
        }
     
    }
}
