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

namespace IntroduccionNivel_Intermedio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {

            string preciotb = tbPrecioOriginal.Text;

            if (preciotb.Trim() == "")
            {
                MessageBox.Show("El campo para introducir el precio no puede estar vacío.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return; 
            }

  
            double precioOriginal; 


            bool sePudoConvertir = double.TryParse(preciotb, out precioOriginal);


            if (sePudoConvertir == false)
            {
                MessageBox.Show("Por favor, introduce un número válido para el precio", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return; 
            }


            if (precioOriginal <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return; 
            }

            double porcentajeDescuento = 0;
            if (rb10.IsChecked == true)
            {
                porcentajeDescuento = 0.10;
            }
            else if (rb25.IsChecked == true)
            {
                porcentajeDescuento = 0.25;
            }
            else if (rb50.IsChecked == true)
            {
                porcentajeDescuento = 0.50;
            }
            else if (rb75.IsChecked == true)
            {
                porcentajeDescuento = 0.75;
            }

            SegundaVentana ventanaResultado = new SegundaVentana(precioOriginal, porcentajeDescuento);
            ventanaResultado.Show();
        }
    }
}