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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

  
        private void BtnAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (tabControl.SelectedIndex > 0)
            {
                tabControl.SelectedIndex--;
            }
        }

     
        private void BtnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (tabControl.SelectedIndex < tabControl.Items.Count - 1)
            {
                tabControl.SelectedIndex++;
            }
        }


        private void BtnSeleccionado_Click(object sender, RoutedEventArgs e)
        {
            TabItem tabActual = (TabItem) tabControl.SelectedItem;

            MessageBox.Show("Has seleccionado la opción de " + tabActual.Header);
        }
    }
}