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
    public partial class MetodosRaices : Form
    {
        public MetodosRaices()
        {
            InitializeComponent();
        }

        string MetodoAEjecutar = "";

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            MetodoAEjecutar = "Biseccion";
            RaicesIngresoDeDatos Raiz = RaicesIngresoDeDatos.ObtenerInstancia(MetodoAEjecutar);
            Raiz.Show();
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            MetodoAEjecutar = "ReglaFalsa";
            RaicesIngresoDeDatos Raiz = RaicesIngresoDeDatos.ObtenerInstancia(MetodoAEjecutar);
            Raiz.Show();
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            MetodoAEjecutar = "Tangente";
            RaicesIngresoDeDatos Raiz = RaicesIngresoDeDatos.ObtenerInstancia(MetodoAEjecutar);
            Raiz.Show();
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            MetodoAEjecutar = "Secante";
            RaicesIngresoDeDatos Raiz = RaicesIngresoDeDatos.ObtenerInstancia(MetodoAEjecutar);
            Raiz.Show();
        }
    }
}
