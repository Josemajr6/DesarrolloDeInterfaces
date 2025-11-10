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

        private void BtnSimple_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Buenas tardes");
        }

        private void BtnTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Buenas tardes", "Saludar");
        }

        private void BtnButtons_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿Quieres enviar un saludo?", "Botones", MessageBoxButton.YesNoCancel);
        }

        private void BtnResponse_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Desea guardar los cambios?", "Obtener Respuesta", MessageBoxButton.YesNo);
            MessageBox.Show("Has seleccionado: " + resultado.ToString(), "Respuesta");
        }

        private void BtnIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tengo el icono de información", "Icono", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnDefault_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿Vas a saludar?", "Opción por Defecto", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
        }
    }
}