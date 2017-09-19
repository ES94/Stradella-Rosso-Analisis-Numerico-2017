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
    public partial class MetodosSistemasEcuaciones : Form
    {
        public MetodosSistemasEcuaciones()
        {
            InitializeComponent();
        }

        private void btnGaussJordan_Click(object sender, EventArgs e)
        {
            SistemasIngresoDeDatos IngresoDatos = new SistemasIngresoDeDatos();
            IngresoDatos.Show();
        }

        private void btnGaussSeide_Click(object sender, EventArgs e)
        {
            SistemasIngresoDeDatos IngresoDatos = new SistemasIngresoDeDatos();
            IngresoDatos.Show();
        }
    }
}
