using P1_AP1_Danilo_20190266.BLL;
using P1_AP1_Danilo_20190266.Entidades;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P1_AP1_Danilo_20190266.UI.Registro
{
    /// <summary>
    /// Interaction logic for VentanaRegistro.xaml
    /// </summary>
    public partial class VentanaRegistro : Window
    {
        private Aportes A = new Aportes();
        public VentanaRegistro()
        {
            InitializeComponent();
            this.DataContext = A;
        }

        public void Limpiar()
        {
            this.A = new Aportes();
            this.DataContext = A;
        }

        public bool Validar()
        {
            bool esValido = true;
            if (TextAporteID.Text.Length == 0 || Convert.ToInt32(TextAporteID.Text) == 0)
            {
                esValido = false;
                MessageBox.Show("Ingrese el Aporte ID", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TextPersona.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Ingrese el nombre de la Persona", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TextConcepto.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Ingrese el Concepto", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (Convert.ToInt32(TextMonto.Text) == 0)
            {
                esValido = false;
                MessageBox.Show("Ingrese el Monto", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;

        }

        private void BtnBuscar(object sender, RoutedEventArgs e)
        {
            if (TextAporteID.Text.Length == 0)
            {
                MessageBox.Show("La casilla Aporte ID esta vacia", "Fallo",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var aportes = AportesBLL.Buscar(Convert.ToInt32(TextAporteID.Text));

            if (aportes != null)
                this.A = aportes;
            else
            {
                this.A = new Aportes();
                MessageBox.Show("Este ID no existe", "Fallo",
                        MessageBoxButton.OK, MessageBoxImage.Error);
            }     
           
            this.DataContext = this.A;
        }

        private void BtnNuevo(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = AportesBLL.Guardar(A);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Error", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BtnEliminar(object sender, RoutedEventArgs e)
        {
            if (TextAporteID.Text.Length == 0)
            {
                MessageBox.Show("El ID esta vacio", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (AportesBLL.Eliminar(Convert.ToInt32(TextAporteID.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado", "Existe",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
