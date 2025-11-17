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
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            private void MenuOpcion1_1_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Has elegido: Sub-opción 1.1");
            }

            private void MenuOpcion1_2_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Has elegido: Sub-opción 1.2");
            }
            private void MenuOpcion1_3_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Has elegido: Sub-opción 1.3");
            }

            private void MenuOpcion1_4_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Has elegido: Sub-opción 1.4");
            }

            private void MenuOpcion2_1_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Has elegido: Sub-opción 2.1");
            }
            private void MenuOpcion2_2_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Has elegido: Sub-opción 2.2");
            }
            private void MenuOpcion2_3_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Has elegido: Sub-opción 2.3");
            }
        }
    }