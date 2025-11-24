using System.Windows;

namespace Ejercicio_2
{
    public partial class MainWindow : Window
    {
        int[,] matriz;
        int dim;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInicializar_Click(object sender, RoutedEventArgs e)
        {
            dim = int.Parse(tbDimension.Text);
            matriz = new int[dim, dim];
            Random rnd = new Random();

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    matriz[i, j] = rnd.Next(0, 100);
                }
            }

            tbSalida.Text = "Matriz generada.";
        }

        private void btnImprimirMatriz_Click(object sender, RoutedEventArgs e)
        {
            string resultado = "";

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    resultado += matriz[i, j] + "\t";
                }
                resultado += "\n";
            }

            tbSalida.Text = resultado;
        }

        private void btnImprimirTraspuesta_Click(object sender, RoutedEventArgs e)
        {
            string resultado = "";

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    resultado += matriz[j, i] + "\t";
                }
                resultado += "\n";
            }

            tbSalida.Text = resultado;
        }
    }
}