using System;
using System.Globalization;


namespace exercicio1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, n, raio;
            n = 3.14159;

            Console.WriteLine("Digite um valor: ");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
            area = n * Math.Pow(raio,2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            
        }
    }
}
