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

namespace Ejercicio_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        private int intentosRealizados = 0;
        private const int MAX_INTENTOS = 2;

        public MainWindow()
        {
            InitializeComponent();

            tbContador.Text = "Te quedan " + MAX_INTENTOS + " intentos";
        }

        private void Corregir_Click(object sender, RoutedEventArgs e)
        {
          
            if (rbCorrecta.IsChecked == true)
            {
                MessageBox.Show("Has acertado. Además de ser la que tiene mejor calidad, combina las otras tres.");

         
                btnCorregir.IsEnabled = false;
                panelRespuestas.IsEnabled = false;
                tbContador.Text = "Te quedan " + MAX_INTENTOS + " intentos";
            }
            else
            {
               
                intentosRealizados++; 
                int intentosRestantes = MAX_INTENTOS - intentosRealizados;

                if (intentosRestantes > 0)
                {
                   
                    MessageBox.Show("Respuesta incorrecta. Vuelve a intentarlo");
                   
                    tbContador.Text = "Te quedan " + intentosRestantes + " intentos";
                } 
                else
                {
                   
                    MessageBox.Show("Respuesta incorrecta. No tienes más intentos");
                    tbContador.Text = "No tienes mas intentos";

                  
                    btnCorregir.IsEnabled = false;
                    panelRespuestas.IsEnabled = false;
                    rbCorrecta.IsChecked = true; 
                }
            }
        }
    }
}