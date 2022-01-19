using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int nquartos;
            double preco;
            string[] vet = Console.ReadLine().Split(' ');

            nome = Console.ReadLine();
            nquartos = int.Parse(Console.ReadLine());
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome completo: " + nome);
            Console.WriteLine("Quantos quartos tem na sua casa?" + nquartos);
        }
    }
}
