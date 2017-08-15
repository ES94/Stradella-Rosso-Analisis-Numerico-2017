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
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Menu> listaMenus;
        private List<Menu> listaMenusInteg;

        public MainWindow()
        {
            InitializeComponent();

            listaMenus = new List<Menu>() { mnuRaices, mnuSistEcuaciones, mnuRegInter, mnuIntegracion };
            listaMenusInteg = new List<Menu>() { mnuSubIntegracion };
        }

        private void ItmRaices_Click(object sender, RoutedEventArgs e)
        {
            this.Selector(mnuRaices.Name);
        }

        private void ItmSistEcuaciones_Click(object sender, RoutedEventArgs e)
        {
            this.Selector(mnuSistEcuaciones.Name);
        }

        private void ItmRegInter_Click(object sender, RoutedEventArgs e)
        {
            this.Selector(mnuRegInter.Name);
        }

        private void ItmIntegracion_Click(object sender, RoutedEventArgs e)
        {
            this.Selector(mnuIntegracion.Name);
        }

        private void ItmSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ItmIntegracionTrapecios_Click(object sender, RoutedEventArgs e)
        {
            this.IntegSelector(itmIntegracionTrapecios.Name);
        }

        private void ItmIntegracionSimpson13_Click(object sender, RoutedEventArgs e)
        {
            this.IntegSelector(itmIntegracionSimpson13.Name);
        }

        private void ItmIntegracionSimpson38_Click(object sender, RoutedEventArgs e)
        {
            this.IntegSelector(itmIntegracionSimpson38.Name);
        }

        private void Selector(string nombreMenu)
        {
            if (nombreMenu != mnuIntegracion.Name)
            {
                mnuSubIntegracion.IsEnabled = false;
                mnuSubIntegracion.Visibility = Visibility.Hidden;
            }

            foreach (Menu menu in this.listaMenus)
            {
                if (menu.Name == nombreMenu)
                {
                    menu.IsEnabled = true;
                    menu.Visibility = Visibility.Visible;
                }
                else
                {
                    menu.IsEnabled = false;
                    menu.Visibility = Visibility.Hidden;
                }
            }
        }

        private void IntegSelector(string nombreBoton)
        {
            mnuSubIntegracion.IsEnabled = true;
            mnuSubIntegracion.Visibility = Visibility.Visible;

            if (nombreBoton == itmIntegracionSimpson38.Name)
            {
                itmSubIntegracionMultiple.IsEnabled = false;
                itmSubIntegracionMultiple.Visibility = Visibility.Hidden;
            }
            else
            {
                itmSubIntegracionMultiple.IsEnabled = true;
                itmSubIntegracionMultiple.Visibility = Visibility.Visible;
            }
        }
    }
}
