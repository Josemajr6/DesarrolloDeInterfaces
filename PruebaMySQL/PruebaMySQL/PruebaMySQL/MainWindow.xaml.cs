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

namespace PruebaMySQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string connections = "Server=localhost;Database=PruebaWPF;User=root;Password=password";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnConectar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder resultados = new StringBuilder();
            resultados.AppendLine("------ DATOS DE CLIENTES ------");

            using (MySqlConnection connection = new MySqlConnection(connections))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT idUsers, name, subname FROM users";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("idUsers");
                                string nombre = reader.GetString("name");
                                string apellido;
                                if (reader.IsDBNull(reader.GetOrdinal("subname")))
                                {
                                    apellido = string.Empty;
                                }
                                else
                                {
                                    apellido = reader.GetString("subname");
                                }
                                resultados.AppendLine($"ID: {id}, Nombre: {nombre}, Apellidos: {apellido}");
                            }
                    }
                    if (resultados.Length <= 0)
                    {
                        resultados.AppendLine("No se encontraron datos");
                    }
                    tbResultado.Text = resultados.ToString();
                }
                catch (Exception ex)
                {
                    tbResultado.Text = $"ERROR al conectar con la BBDD{ex.Message}";
                }
            }
        }
    }
}