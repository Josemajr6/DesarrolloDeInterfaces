using Microsoft.Win32; // Necesario para OpenFileDialog 
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging; // Necesario para BitmapImage
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio_2
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

        private void BtnCargarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen (*.png; *.jpeg; *.jpg)|*.png;*.jpeg;*.jpg|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                imgMostrar.Source = new BitmapImage (new Uri(filePath, UriKind.Absolute));
            }
        }
    }
}