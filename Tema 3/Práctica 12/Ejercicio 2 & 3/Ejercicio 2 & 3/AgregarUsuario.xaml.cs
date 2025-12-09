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
    /// Lógica de interacción para AgregarUsuario.xaml
    /// </summary>
    public partial class AgregarUsuario : Window
    {
        private MySqlConnection connection;

        public AgregarUsuario(string conexion)
        {
            InitializeComponent();
            connection = new MySqlConnection(conexion);

        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {

            if (tbNombre.Text.Equals("") || tbApellidos.Text.Equals("") || tbEmail.Text.Equals("") || tbDireccion.Text.Equals(""))
            {
                MessageBox.Show("Error: Rellena correctamente los campos");
                return;
            }

            string sql = "insert into users (Name, Subname, Email, Direccion)  values ('"+ tbNombre.Text + "', '" + tbApellidos.Text + "', '" + tbEmail.Text + "', '" + tbDireccion.Text + "')";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(sql, connection);
                int filas = command.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("Se ha insertado al usuario");
                }
                else
                {
                    MessageBox.Show("No se ha podido insertar al usuario");
                }



                    connection.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

 
    }
}
