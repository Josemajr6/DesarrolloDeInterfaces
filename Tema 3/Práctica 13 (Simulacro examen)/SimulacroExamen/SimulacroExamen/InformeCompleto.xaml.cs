using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SimulacroExamen
{
    /// <summary>
    /// Lógica de interacción para InformeCompleto.xaml
    /// </summary>
    public partial class InformeCompleto : Window
    {
        private string conexion = "server=localhost; port=3306; database=pruebawpf; uid=root; pwd=password";

        public InformeCompleto()
        {
            InitializeComponent();

            string sql = "SELECT * from informes";

            try
            {
                MySqlConnection connection = new MySqlConnection(conexion);
                connection.Open();

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                dgInformes.ItemsSource = tabla.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido con error con la DB. Más info:\n" + ex);
            } 
        }
    }
}
