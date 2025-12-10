using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimulacroExamen
{
    /// <summary>
    /// Lógica de interacción para ModificarActividad.xaml
    /// </summary>
    public partial class ModificarActividad : Window
    {
        public ModificarActividad()
        {
            InitializeComponent();
        }

        private void btnSelFubol_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado fútbol");
        }

        private void btnSelBaloncesto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has seleccionado baloncesto");
        }
    }
}
