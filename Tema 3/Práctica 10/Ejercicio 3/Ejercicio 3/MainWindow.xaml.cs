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
    public partial class MainWindow : Window
    {

        List<string> listaTareas = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, RoutedEventArgs e)
        {

            AgregarTarea ventana = new AgregarTarea();


            if (ventana.ShowDialog() == true)
            {

                string texto = ventana.txtDescripcion.Text;

                if (texto != "")
                {
                    listaTareas.Add(texto);
                    MessageBox.Show("Tarea guardada");


                    btnMostrarPendientes_Click(sender, e);
                }
            }
        }


        private void btnMostrarSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (listaTareas.Count > 0)
            {
                MessageBox.Show("Te toca hacer: " + listaTareas[0]);
            }
            else
            {
                MessageBox.Show("No hay tareas");
            }
        }


        private void btnRealizarSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (listaTareas.Count > 0)
            {
                MessageBox.Show("Has hecho: " + listaTareas[0]);


                listaTareas.RemoveAt(0);


                btnMostrarPendientes_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No hay tareas para borrar");
            }
        }


        private void btnMostrarNTareas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tienes " + listaTareas.Count + " tareas");
        }


        private void btnMostrarPendientes_Click(object sender, RoutedEventArgs e)
        {

            txtSalida.Text = "";

            if (listaTareas.Count > 0)
            {
                txtSalida.Text = "Las tareas pendientes son:\n\n";


                foreach (string tarea in listaTareas)
                {
                    txtSalida.Text += tarea + "\n";
                }
            }
            else
            {
                txtSalida.Text = "Lista vacía";
            }
        }
    }
}