using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ejercicio_2___3
{
    /// <summary>
    /// Lógica de interacción para MostrarDatos.xaml
    /// </summary>
    public partial class MostrarDatos : Window
    {
        MySqlConnection connection;
        private List<Usuario> usuarios;

        public MostrarDatos(string connectionS)
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionS);
            usuarios = [];
            string sql = "SELECT * from users";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("idUsers");
                    string name = reader.GetString("Name");
                    string subname = reader.GetString("Subname");
                    string email = reader.GetString("Email");
                    string direccion = reader.GetString("Direccion");

                    usuarios.Add(new Usuario(id, name, subname, email, direccion));
                }

                dgDatos.ItemsSource = usuarios;
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Se ha producido un error: {ex}");
            }



        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
