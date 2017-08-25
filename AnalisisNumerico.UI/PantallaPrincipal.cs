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

        private void AbrirVentanaRaices(object sender, EventArgs e)
        {
            var win = RaicesIngresoDeDatos.ObtenerInstancia();
            
            win.Text += (sender as ToolStripMenuItem).Text;
            win.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaicesIngresoDeDatos Raiz = RaicesIngresoDeDatos.ObtenerInstancia();
            Raiz.Show();
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            RaicesIngresoDeDatos Raiz = RaicesIngresoDeDatos.ObtenerInstancia();
            Raiz.Show();
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            RaicesIngresoDeDatos Raiz = RaicesIngresoDeDatos.ObtenerInstancia();
            Raiz.Show();
        }
    }
}
