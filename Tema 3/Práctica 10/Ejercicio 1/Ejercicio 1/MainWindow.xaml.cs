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

namespace Ejercicio_1
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

        private void tbDNI_TextChanged(object sender, TextChangedEventArgs e)
        {
            string cadena = tbDNI.Text;
            if (cadena.Length == 8)
            {
                int DNI = int.Parse(cadena);
                int resto = DNI % 23;
                char[] letras = ['T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'];
                string resultado = "La letra del DNI es la " + letras[resto];
                tbResultado.Text = resultado;
            }
            else
            {
                tbResultado.Text = "Introduce un DNI";
            }

        }

    }
}
