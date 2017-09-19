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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            var scr = Screen.FromPoint(this.Location);

            this.Location = new Point(0, scr.WorkingArea.Top);
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            MetodosRaices FormRaiz = new MetodosRaices();
            FormRaiz.Show();
        }

        private void btnSistemasEcuaciones_Click(object sender, EventArgs e)
        {
            MetodosSistemasEcuaciones FormSis = new MetodosSistemasEcuaciones();
            FormSis.Show();
        }
    }
}
