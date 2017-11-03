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
    public partial class MetodosRegresionInterpolacion : Form
    {
        public MetodosRegresionInterpolacion()
        {
            InitializeComponent();
        }

        private void btnRegInter_Click(object sender, EventArgs e)
        {
            RegInterIngresoDatos ventana = new RegInterIngresoDatos((sender as Button).Text);
            ventana.Show();
        }
    }
}
