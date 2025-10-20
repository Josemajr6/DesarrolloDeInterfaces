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

namespace Ejercicio6
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

        private void Error_Click(object sender, RoutedEventArgs e)
        {

            // Creo un try ejecutar el código que va a fallar
            try
            {
                
                // Creo un array con 3 índices que son 0, 1 y 2
                int[] numeros = new int[3];

                // Intento asignar al índice 5 un valor que esto va a dar error
                numeros[5] = 10; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: El índice está fuera de los límites del array" );
            }



        }
    }
}