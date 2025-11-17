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

namespace IntroduccionNivelPrincipante
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

        private void enviarBoton_Click(object sender, RoutedEventArgs e)
        {
            string nombre = tbNombre.Text;

            if (nombre.Equals(""))
            {
                MessageBox.Show("Por favor, escribe tu nombre antes de continuar", "Introduce un nombre", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                SegundaVentana ventana = new SegundaVentana(nombre);
                ventana.ShowDialog();
            }

        }
    }
}