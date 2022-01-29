using System;

namespace diadasemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string dia;

            Console.WriteLine("Digite o número do dia da semana: ");

            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "valor inválido";
                    break;                      
            }
            Console.WriteLine("Dia da semana: " + dia);
        }
    }
}
