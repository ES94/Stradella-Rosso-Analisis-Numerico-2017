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
        private List<Menu> ListaMenus;

        public MainWindow()
        {
            InitializeComponent();

            ListaMenus = new List<Menu>() { mnuRaices, mnuSistEcuaciones, mnuRegInter, mnuIntegracion };
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

        private void Selector(string nombreMenu)
        {
            foreach (Menu menu in this.ListaMenus)
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
    }
}
