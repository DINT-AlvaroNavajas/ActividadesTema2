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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_Imagen
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

        private void opacidadAltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1;
        }

        private void opacidadMediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.5;
        }

        private void opacidadBajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.2;
        }

        private void RellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void uniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void RellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void SinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}
