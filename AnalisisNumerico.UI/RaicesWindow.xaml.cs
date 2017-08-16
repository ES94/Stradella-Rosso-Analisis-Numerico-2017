
namespace AnalisisNumerico.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using AnalisisNumerico.Metodos;

    /// <summary>
    /// Lógica de interacción para RaicesWindow.xaml
    /// </summary>
    public partial class RaicesWindow : Window
    {
        private string botonPresionado;

        public RaicesWindow(string nombreBoton)
        {
            this.InitializeComponent();
            
            this.botonPresionado = nombreBoton;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if ((dblXI.Text != "") && (dblXF.Text != ""))
            {
                double? resultado = null;

                switch (botonPresionado)
                {
                    case "itmRaicesBiseccion":
                        resultado = MetodosRaices.Biseccion(Convert.ToDouble(dblXI.Text), Convert.ToDouble(dblXF.Text));
                        break;

                    case "itmRaicesReglaFalsa":
                        resultado = MetodosRaices.ReglaFalsa();
                        break;

                    case "itmRaicesNewton":
                        resultado = MetodosRaices.Newton();
                        break;

                    case "itmRaicesSecante":
                        resultado = MetodosRaices.Secante();
                        break;
                }

                MessageBox.Show("Resultado: " + (resultado == null ? "no se halló la raíz" : "la raíz es " + resultado.ToString()) + ".", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Falta suministrar datos en los campos.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
