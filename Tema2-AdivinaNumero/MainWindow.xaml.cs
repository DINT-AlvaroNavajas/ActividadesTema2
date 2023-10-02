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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num = GeneraNumeroAleatorio();
        public MainWindow()
        {
            InitializeComponent();
        }

        public static int GeneraNumeroAleatorio()
        {
            Random rand = new Random();
            int aleatorio = rand.Next(0,100);
            return aleatorio;
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            pista_TextBlock.Text = "";
            if (int.Parse(numeroTextBox.Text) > num)
                pista_TextBlock.Text = "Te has pasado";
            if (int.Parse(numeroTextBox.Text) < num)
                pista_TextBlock.Text = "Te has quedado corto";
            if(int.Parse(numeroTextBox.Text) == num)
                pista_TextBlock.Text = "ACERTASTE!!!";
        }

        private void reiniciarButton_Click(Object sender, RoutedEventArgs e)
        {
            num = GeneraNumeroAleatorio();

            pista_TextBlock.Text = "";

            numeroTextBox.Text = "";
        }
    }
}
