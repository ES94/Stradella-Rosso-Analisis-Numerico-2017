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
    }
}
