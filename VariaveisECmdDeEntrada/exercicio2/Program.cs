using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa:");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço deum produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu último nome, idade e altura:");
            string[] v = Console.ReadLine().Split(' ');
            string unome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);
            
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(unome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
