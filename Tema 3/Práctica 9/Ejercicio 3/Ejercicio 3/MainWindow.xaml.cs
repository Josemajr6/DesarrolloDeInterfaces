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

namespace Ejercicio_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class User
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Mail { get; set; }
        public string Ciudad { get; set; }
    }

    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {

            List<User> users = new List<User>();
            users.Add(new User() { Nombre = "Pepe Cortés", Edad = 42, Mail = "pepe@gmail.com", Ciudad = "Madrid" });
            users.Add(new User() { Nombre = "Alfredo Rivas", Edad = 39, Mail = "alfredo@gmail.com", Ciudad = "Barcelona" });
            users.Add(new User() { Nombre = "Antonio Romero", Edad = 13, Mail = "antonio@gmail.com", Ciudad = "Sevilla" });
            users.Add(new User() { Nombre = "Ángela Nieves", Edad = 33, Mail = "angela@gmail.com", Ciudad = "Valencia" });


            this.lvUsers.ItemsSource = users;
        }


    }
}