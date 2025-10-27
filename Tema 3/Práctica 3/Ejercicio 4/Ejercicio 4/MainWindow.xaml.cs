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

namespace Ejercicio_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool cambiada = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CambiarImagen_Click(object sender, RoutedEventArgs e)
        {
            if (!cambiada)
            {
               Imagen.Source = new BitmapImage(new Uri("Assets/Foto 2.png", UriKind.Relative));
               cambiada = true;
            }
            else
            {
                Imagen.Source = new BitmapImage(new Uri("Assets/Foto 1.png", UriKind.Relative));
                cambiada = false;
            }
            
        }
    }
}