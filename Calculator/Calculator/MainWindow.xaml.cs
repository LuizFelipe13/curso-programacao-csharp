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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double ultimoNumero, resultado;
        SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();

            // resultadoLabel.Content = "14321";
            reset.Click += reset_Click;
            negativo.Click += negativo_Click;
            porcentagem.Click += porcentagem_Click;
            igual.Click += Igual_Click;
        }
        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            double novoNumero;
            if (double.TryParse(resultadoLabel.Content.ToString(), out novoNumero))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Adicao:
                        resultado = CalculoSimples.Somar(ultimoNumero, novoNumero);
                        break;
                    case SelectedOperator.Subtracao:
                        resultado = CalculoSimples.Subtrair(ultimoNumero, novoNumero);
                        break;
                    case SelectedOperator.Multiplicacao:
                        resultado = CalculoSimples.Multiplicar(ultimoNumero, novoNumero);
                        break;
                    case SelectedOperator.Divisao:
                        resultado = CalculoSimples.Dividir(ultimoNumero, novoNumero);
                        break;
                }
                resultadoLabel.Content = resultado.ToString();
            }

        }

        private void porcentagem_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadoLabel.Content.ToString(), out ultimoNumero))
            {
                ultimoNumero = ultimoNumero / 100;
                resultadoLabel.Content = ultimoNumero.ToString();
            }
        }

        private void negativo_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadoLabel.Content.ToString(), out ultimoNumero))
            {
                ultimoNumero = ultimoNumero * -1;
                resultadoLabel.Content = ultimoNumero.ToString();
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            resultadoLabel.Content = "0";

        }

        private void operacao_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultadoLabel.Content.ToString(), out ultimoNumero))
            {
                resultadoLabel.Content = "0";
            }
            if (sender == botaoMultiplicar)
                selectedOperator = SelectedOperator.Multiplicacao;
            if (sender == botaoDivisao)
                selectedOperator = SelectedOperator.Divisao;
            if (sender == botaoMais)
                selectedOperator = SelectedOperator.Adicao;
            if (sender == botaoMenos)
                selectedOperator = SelectedOperator.Subtracao;

        }

        private void ponto_Click(object sender, RoutedEventArgs e)
        {
            if (resultadoLabel.Content.ToString().Contains("."))
            {
                // Faz nada
            }
            else
            {
                resultadoLabel.Content = $"{resultadoLabel.Content}.";
            }
        }
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender == zero)
                selectedValue = 0;
            if (sender == um)
                selectedValue = 1;
            if (sender == dois)
                selectedValue = 2;
            if (sender == tres)
                selectedValue = 3;
            if (sender == quatro)
                selectedValue = 4;
            if (sender == cinco)
                selectedValue = 5;
            if (sender == seis)
                selectedValue = 6;
            if (sender == sete)
                selectedValue = 7;
            if (sender == oito)
                selectedValue = 8;
            if (sender == nove)
                selectedValue = 9;



            if (resultadoLabel.Content.ToString() == "0")
            {
                resultadoLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultadoLabel.Content = $"{resultadoLabel.Content}{selectedValue}";
            }
        }
     
    }
    public enum SelectedOperator
    {
        Adicao,
        Subtracao,
        Multiplicacao,
        Divisao
    }
    public class CalculoSimples
    {
        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
