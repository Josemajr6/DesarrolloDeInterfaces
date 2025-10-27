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
    public partial class MainWindow : Window
    {
        private const string USUARIO_CORRECTO = "usuario";
        private const string PASS_CORRECTA = "usuario";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            
            string usuarioIntroducido = txtUsuario.Text;

        
            string passwordIntroducida = txtPassword.Password;

         
            if (usuarioIntroducido == USUARIO_CORRECTO && passwordIntroducida == PASS_CORRECTA)
            {
             
                MessageBox.Show("Inicio de sesión correcto. Bienvenido");
            }
            else
            {
          
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}