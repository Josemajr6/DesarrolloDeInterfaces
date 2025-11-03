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

namespace Ejercicio_3
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

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            // Recogemos los datos de los txtBox y creamos el string con el mensaje y el título
            string nombre = txtNombre.Text;
            string email = txtCorreo.Text;
            string mensaje = txtMensaje.Text;

            string textoDelMensaje = "El usuario " + nombre + " con email " + email + " envía el mensaje: " + mensaje;
            string titulo = "Datos del Formulario";

            // Mostramos el MessageBox con título, texto, botón OK e icono de Información
            MessageBox.Show(textoDelMensaje, titulo, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}