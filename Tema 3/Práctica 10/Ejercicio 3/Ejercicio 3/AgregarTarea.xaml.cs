using System.Windows;

namespace Ejercicio_3
{
    public partial class AgregarTarea : Window
    {
        public AgregarTarea()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}