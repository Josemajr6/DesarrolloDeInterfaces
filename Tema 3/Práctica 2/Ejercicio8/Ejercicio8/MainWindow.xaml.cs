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

namespace Ejercicio8
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

        private void TodoCheck_Check(object sender, EventArgs e)
        {
            bool newVal = (TodoCheck.IsChecked == true);
            di.IsChecked = newVal;
            sge.IsChecked = newVal;
            ad.IsChecked = newVal;
        }
        private void check(object sender, EventArgs e)
        {
            TodoCheck.IsChecked = null;
            if ((di.IsChecked == true) && (sge.IsChecked == true) && (ad.IsChecked == true))
            { TodoCheck.IsChecked = true; }
            if ((di.IsChecked == false) && (sge.IsChecked == false) && (ad.IsChecked == false))
            { TodoCheck.IsChecked = false; }
        }
    }
}