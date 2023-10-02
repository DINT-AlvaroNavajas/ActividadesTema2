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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calcularButton.IsEnabled = false;
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(operando1TextBox.Text);
            int num2 = int.Parse(operando2TextBox.Text);
            string operacion = operadorTextBox.Text;

            switch (operacion)
            {
                case "+":
                    resultadoTextBox.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    resultadoTextBox.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    resultadoTextBox.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    resultadoTextBox.Text = (num1 / num2).ToString();
                    break;
                default:
                    resultadoTextBox.Text = "Operacion no válida";
                    break;
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = string.Empty;
            operando2TextBox.Text = string.Empty;
            operadorTextBox.Text = string.Empty;
            resultadoTextBox.Text = string.Empty;
            calcularButton.IsEnabled = true;
        }

        private void OperadorTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            calcularButton.IsEnabled = true;
        }
    }
}
