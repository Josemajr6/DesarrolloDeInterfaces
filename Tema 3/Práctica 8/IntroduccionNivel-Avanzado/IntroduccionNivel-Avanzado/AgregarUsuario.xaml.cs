using System.Windows;

using System.Windows;

namespace IntroduccionNivel_Avanzado
{
    public partial class AgregarUsuario : Window
    {
        // CORREGIDO: Inicializamos con string.Empty para evitar advertencias
        public string NombreUsuario { get; private set; } = string.Empty;
        public string EdadUsuario { get; private set; } = string.Empty;

        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbEdad.Text))
            {
                MessageBox.Show("Por favor, rellena ambos campos.");
                return;
            }

            NombreUsuario = tbNombre.Text;
            EdadUsuario = tbEdad.Text;

            this.DialogResult = true;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}