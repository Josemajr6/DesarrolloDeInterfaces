
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

namespace Ejercicio_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

  
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            byte r = (byte)slRojo.Value;
            byte g = (byte)slVerde.Value;
            byte b = (byte)slAzul.Value;


            Color colorActual = Color.FromRgb(r, g, b);
            VentanaPrincipal.Background = new SolidColorBrush(colorActual);
        }
    }
}
