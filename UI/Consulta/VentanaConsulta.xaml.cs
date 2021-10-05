using P1_AP1_Danilo_20190266.BLL;
using P1_AP1_Danilo_20190266.Entidades;
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

namespace P1_AP1_Danilo_20190266.UI.Consulta
{
    /// <summary>
    /// Interaction logic for VentanaConsulta.xaml
    /// </summary>
    public partial class VentanaConsulta : Window
    {
        public VentanaConsulta()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();
            if (TextBuscar.Text.Trim().Length > 0)
            {
                switch (Filtro.SelectedIndex)
                {
                    case 0:
                        listado = AportesBLL.GetList(e => e.Persona.ToLower().Contains(TextBuscar.Text.ToLower()));
                        break;
                    case 1:
                        listado = AportesBLL.GetList(e => e.Concepto.ToLower().Contains(TextBuscar.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(c => true);

            }
            if (FechaInicio.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date >= FechaInicio.SelectedDate);
            if (FechaFinal.SelectedDate != null)
                listado = AportesBLL.GetList(c => c.Fecha.Date <= FechaFinal.SelectedDate);

            Tabla.ItemsSource = null;
            Tabla.ItemsSource = listado;

            int x = listado.Count;
            int y = listado.Sum(a => a.Monto);

            TextConteo.Text = Convert.ToString(x);
            TextTotal.Text = Convert.ToString(y);
        }
    }
}
