using System;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 0;
            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Prod[] vet = new Prod[n];

            for(int i = 0; i < n; i++) {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                double preco = double.Parse(Console.ReadLine());
                vet[i] = new Prod{ Nome = nome, Preco = preco};
                S = S + vet[i].Preco;
            }
            Console.WriteLine((S/n).ToString("F2"));
        }
    }
}
