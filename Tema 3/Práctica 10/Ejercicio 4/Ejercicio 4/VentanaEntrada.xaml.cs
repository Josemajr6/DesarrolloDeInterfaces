using System.Windows;

namespace Ejercicio_4
{
    public partial class VentanaEntrada : Window
    {
  
        public VentanaEntrada(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true; 
        }
    }
}