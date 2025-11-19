using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Reflection; 

namespace Ejercicio_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarColores();
        }

        private void CargarColores()
        {

            cbColores.ItemsSource = typeof(Colors).GetProperties();
        }

        private void cbColores_CambioSeleccion(object sender, SelectionChangedEventArgs e)
        {

            if (cbColores.SelectedItem != null)
            {

                var propiedadColor = (PropertyInfo)cbColores.SelectedItem;


                var colorSeleccionado = (Color)propiedadColor.GetValue(null, null);

 
                this.Background = new SolidColorBrush(colorSeleccionado);
            }
        }
    }
}