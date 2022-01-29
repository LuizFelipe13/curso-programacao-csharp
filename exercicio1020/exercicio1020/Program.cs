using System;

namespace exercicio1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, ano, meses, dias, resto;

            N = int.Parse(Console.ReadLine());

           

            ano = N / 365;
            resto = N % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
