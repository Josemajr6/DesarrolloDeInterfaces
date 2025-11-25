using System.Windows;

namespace Ejercicio_4
{
    public partial class MainWindow : Window
    {
        Empleado[] listaEmpleados = new Empleado[15];
        int totalEmpleados = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAlta_Click(object sender, RoutedEventArgs e)
        {
            if (EsAdmin())
            {
                if (totalEmpleados < 15)
                {
                    string nombre = PedirDato("Nombre del empleado:");
                    string salarioStr = PedirDato("Salario base:");

                    if (nombre != "" && double.TryParse(salarioStr, out double salario))
                    {
                        listaEmpleados[totalEmpleados] = new Empleado(nombre, salario);
                        totalEmpleados++;
                        MessageBox.Show("Empleado dado de alta correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("La lista de empleados está llena");
                }
            }
        }

        private void BtnTotalHoras_Click(object sender, RoutedEventArgs e)
        {
            if (EsAdmin())
            {
                int totalHoras = 0;
                for (int i = 0; i < totalEmpleados; i++)
                {
                    totalHoras += listaEmpleados[i].numHorasExtra;
                }
                txtSalida.Text = "TOTAL HORAS EXTRAS: " + totalHoras;
            }
        }

        private void BtnInforme_Click(object sender, RoutedEventArgs e)
        {
            if (EsAdmin())
            {
                txtSalida.Text = "--- INFORME COMPLETO ---\n\n";

                for (int i = 0; i < totalEmpleados; i++)
                {
                    Empleado emp = listaEmpleados[i];
                    txtSalida.Text += "Nombre: " + emp.nombre + "\n";
                    txtSalida.Text += "Salario Base: " + emp.salarioSinExtras + "\n";
                    txtSalida.Text += "Horas Extras: " + emp.numHorasExtra + "\n";
                    txtSalida.Text += "TOTAL: " + emp.CalculaSalarioTotal() + "\n";
                    txtSalida.Text += "-----------------------------\n";
                }
            }
        }

        private void BtnInsertarHora_Click(object sender, RoutedEventArgs e)
        {
            string nombre = PedirDato("Introduce tu nombre:");

            Empleado encontrado = null;
            for (int i = 0; i < totalEmpleados; i++)
            {
                if (listaEmpleados[i].nombre == nombre)
                {
                    encontrado = listaEmpleados[i];
                    break;
                }
            }

            if (encontrado != null)
            {
                string horasStr = PedirDato("¿Cuántas horas extras?");
                if (int.TryParse(horasStr, out int horas))
                {
                    encontrado.HaceHoraExtra(horas);
                    MessageBox.Show("Horas añadidas");
                }
                else
                {
                    MessageBox.Show("Número no válido");
                }
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
        }

        private string PedirDato(string mensaje)
        {
            VentanaEntrada ventana = new VentanaEntrada(mensaje);
            if (ventana.ShowDialog() == true)
            {
                return ventana.txtDato.Text;
            }
            return "";
        }

        private bool EsAdmin()
        {
            string pass = PedirDato("Contraseña de Administrador:");
            if (pass == "1234")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }
        }
    }
}