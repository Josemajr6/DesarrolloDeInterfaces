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
    /// Lógica de interacción para NuevoParticipante.xaml
    /// </summary>
    public partial class NuevoParticipante : Window
    {
        public NuevoParticipante()
        {
            InitializeComponent();
            
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha insertado el participante");
        }

        
    }
}
