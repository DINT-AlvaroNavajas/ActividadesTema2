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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_FormatoTexto
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

        private void TextoTextBlock_KeyUp(object sender, KeyEventArgs e)
        {
            textoTransformadoTextBlock.Text = textoTextBox.Text;
        }

        private void NegritaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (negritaCheckBox.IsChecked == true)
            {
                textoTransformadoTextBlock.FontWeight = FontWeights.Bold;
            }
            else
            {
                textoTransformadoTextBlock.FontWeight = FontWeights.Regular;
            }
        }

        private void CursivaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if(cursivaCheckBox.IsChecked == true)
            {
                textoTransformadoTextBlock.FontStyle = FontStyles.Italic;
            }
            else
            {
                textoTransformadoTextBlock.FontStyle = FontStyles.Normal;
            }
        }

        //private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    textoTransformadoTextBlock.Foreground = Brushes.Blue;
        //}

        //private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    textoTransformadoTextBlock.Foreground = Brushes.Red;
        //}

        //private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    textoTransformadoTextBlock.Foreground = Brushes.Green;
        //}
    }
}
