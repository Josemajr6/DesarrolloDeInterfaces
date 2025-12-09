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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ejercicio_2___3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string conexion = "server=localhost; port=3306; database=pruebawpf; uid=root; pwd=password";
        private MySqlConnection connection ;
        public MainWindow()
        {
            InitializeComponent();
            connection = new MySqlConnection(conexion);
        }

        private void btnConectar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                connection.Open();
                tbResConection.Text = "Se ha establecido la conexión con la base de datos";
            }
            catch(Exception ex)
            {
                tbResConection.Text = "Ha ocurrido un error " + ex;
            }
        }

        private void btnMostrarDatos_Click(object sender, RoutedEventArgs e)
        {
            MostrarDatos mostrarDatos = new MostrarDatos(conexion);
            mostrarDatos.Show();
        }

        private void btnInsertarDatos_Click(object sender, RoutedEventArgs e)
        {
            AgregarUsuario agregarDatos = new AgregarUsuario(conexion);
            agregarDatos.Show();
        }


    }
}