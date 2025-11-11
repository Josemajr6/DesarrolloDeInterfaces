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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuNuevo_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Has elegido: Nuevo");
        }

        private void MenuAbrir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido: Abrir");
        }

        private void MenuGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido: Guardar");
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
     
            MessageBox.Show("Cerrando la aplicación...");


            this.Close();
        }


        private void MenuCortar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido: Cortar");
        }

        private void MenuCopiar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has elegido: Copiar");
        }

        private void MenuPegar_Click(object sender, RoutedEventArgs e)
        {
  
            MessageBox.Show("Has elegido: Pegar");
        }
    }
}