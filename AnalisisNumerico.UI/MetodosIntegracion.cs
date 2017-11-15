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
    public partial class MetodosIntegracion : Form
    {
        public MetodosIntegracion()
        {
            InitializeComponent();
        }

        private void btnIntegracion_Click(object sender, EventArgs e)
        {
            IntegracionIngresoDatos ventana = new IntegracionIngresoDatos((sender as Button).Text);
            ventana.Show();
        }
    }
}
