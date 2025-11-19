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
using System.Collections.Generic;


namespace IntroduccionNivel_Avanzado
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarUsuario ventanaRegistro = new AgregarUsuario();


            bool? resultado = ventanaRegistro.ShowDialog();

            if (resultado == true)
            {

                string nombreRecibido = ventanaRegistro.NombreUsuario;
                string edadRecibida = ventanaRegistro.EdadUsuario;


                string nuevoItem = nombreRecibido + "(" + edadRecibida + " años)";
                lbUsuarios.Items.Add(nuevoItem);
            }
        }


        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    
    }
}