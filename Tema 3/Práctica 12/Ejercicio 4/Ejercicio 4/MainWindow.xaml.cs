using MySql.Data.MySqlClient;
using System.Data;
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
        private string conexion = "server=localhost; port=3306; database=pruebawpf; uid=root; pwd=password";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMostrarDatos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(conexion);

                string sql = "select * from clientes";

                MySqlCommand command = new MySqlCommand(sql, connection);

                DataTable table =  new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                dgDatos.ItemsSource = table.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex);
            }

        }

        private void btnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente(conexion);
            agregarCliente.Show();
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente(conexion);
            editarCliente.Show();
        }
    }
}