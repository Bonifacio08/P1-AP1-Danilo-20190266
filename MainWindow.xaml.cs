using P1_AP1_Danilo_20190266.UI.Registro;
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

namespace P1_AP1_Danilo_20190266
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        VentanaRegistro VentanaRegistro = new VentanaRegistro();

        private void Aportes_Click(object sender, RoutedEventArgs e)
        {
            VentanaRegistro.Show();
        }

        private void Consultar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
