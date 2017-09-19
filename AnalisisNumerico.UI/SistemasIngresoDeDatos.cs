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
    public partial class SistemasIngresoDeDatos : Form
    {
        public SistemasIngresoDeDatos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SistemasIngresoDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Convert.ToInt32(btnAceptar.Text); i++)
            //{
            //    GrillaEcuaciones.ColumnAdded();
            //}
            //GrillaEcuaciones.ColumnCount = Convert.ToInt32(btnAceptar.Text);
            //GrillaEcuaciones.RowCount = Convert.ToInt32(btnAceptar.Text);

            for (int i = 0; i < Convert.ToInt32(txtCantidadVariables.Text); i++)
            {
                DataGridViewTextBoxColumn Columna = new DataGridViewTextBoxColumn();
                Columna.HeaderText = "A" +  (i + 1).ToString();
                GrillaEcuaciones.Columns.Add(Columna);
            }
        }
    }
}
