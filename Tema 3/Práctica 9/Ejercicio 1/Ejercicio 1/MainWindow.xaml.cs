using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1
{
    // Clase de datos (Propiedades en español)
    public class Tarea
    {
        public string NombreTarea { get; set; }
        public int ValorProgreso { get; set; }

        public override string ToString()
        {
            return NombreTarea;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarTareas();

            lbTareas.SelectionMode = SelectionMode.Single;
        }

        private void CargarTareas()
        {

            List<Tarea> listaTareas = new List<Tarea>
            {
                new Tarea { NombreTarea = "Complete this WPF tutorial", ValorProgreso = 75 },
                new Tarea { NombreTarea = "Learn C#", ValorProgreso = 85 },
                new Tarea { NombreTarea = "Wash the car", ValorProgreso = 20 }
            };
            lbTareas.ItemsSource = listaTareas;
        }

        private void BotonMostrarSeleccion_Click(object sender, RoutedEventArgs e)
        {
            if (lbTareas.SelectedItem is Tarea tareaSeleccionada)
            {
                MessageBox.Show($"Selected task: {tareaSeleccionada.NombreTarea} (Progress: {tareaSeleccionada.ValorProgreso}%)", "ListBox Selection");
            }
            else
            {
                MessageBox.Show("No task selected.", "ListBox Selection");
            }
        }

        private void BotonSeleccionarUltima_Click(object sender, RoutedEventArgs e)
        {
            if (lbTareas.Items.Count > 0)
            {
                lbTareas.SelectedIndex = lbTareas.Items.Count - 1;
                lbTareas.ScrollIntoView(lbTareas.SelectedItem);
            }
        }

        private void BotonSeleccionarSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (lbTareas.Items.Count > 0)
            {
                int siguienteIndice = lbTareas.SelectedIndex + 1;

                if (siguienteIndice < lbTareas.Items.Count)
                {
                    lbTareas.SelectedIndex = siguienteIndice;
                    lbTareas.ScrollIntoView(lbTareas.SelectedItem);
                }
             
                else if (lbTareas.SelectedIndex == -1)
                {
                    lbTareas.SelectedIndex = 0;
                    lbTareas.ScrollIntoView(lbTareas.SelectedItem);
                }
            }
        }

        private void BotonSeleccionarCsharp_Click(object sender, RoutedEventArgs e)
        {

            Tarea tareaCsharp = lbTareas.Items.OfType<Tarea>()
                .FirstOrDefault(t => t.NombreTarea.Contains("C#"));

            if (tareaCsharp != null)
            {
                lbTareas.SelectedItem = tareaCsharp;
                lbTareas.ScrollIntoView(tareaCsharp);
            }
            else
            {
                MessageBox.Show("Task 'Learn C#' not found.", "Error");
            }
        }

        private void BotonSeleccionarTodo_Click(object sender, RoutedEventArgs e)
        {

            if (lbTareas.SelectionMode == SelectionMode.Single)
            {
                MessageBox.Show("Selection mode changed to 'Extended' to allow selecting all items. Please click again.", "Mode Changed");
                lbTareas.SelectionMode = SelectionMode.Extended;
                return;
            }

            lbTareas.SelectAll();
        }
    }
}