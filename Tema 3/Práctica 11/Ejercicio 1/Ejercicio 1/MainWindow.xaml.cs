
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

namespace Ejercicio_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRojo_Click(object sender, RoutedEventArgs e)
        {
            bordeBotones.BorderBrush = Brushes.Red;
        }

        private void btnNaranja_Click(object sender, RoutedEventArgs e)
        {
            bordeBotones.BorderBrush = Brushes.Orange;
        }

        private void btnVerde_Click(object sender, RoutedEventArgs e)
        {
            bordeBotones.BorderBrush = Brushes.Green;
        }
    }
}