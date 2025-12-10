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

namespace SimulacroExamen
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

        private void NuevoParticipante(object sender, RoutedEventArgs e)
        {
            NuevoParticipante nuevoParticipante = new NuevoParticipante();
            nuevoParticipante.Show();

        }

        private void ModificarActividad(object sender, RoutedEventArgs e)
        {
            ModificarActividad modificarActividad = new ModificarActividad();
            modificarActividad.Show();

        }

        private void EliminarParticipante(object sender, RoutedEventArgs e)
        {
            EliminarParticipante eliminarParticipante = new EliminarParticipante();
            eliminarParticipante.Show();

        }

        private void InformeCompleto(object sender, RoutedEventArgs e)
        {
            InformeCompleto informeCompleto = new InformeCompleto();
            informeCompleto.Show();

        }
    }
}