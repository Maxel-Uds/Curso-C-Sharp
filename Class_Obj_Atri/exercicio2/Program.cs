using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.salario = double.Parse(Console.ReadLine());

            double media = (a.salario + b.salario)/2;

            Console.WriteLine("Salário médio: " + media.ToString("F2"));
        }
    }
}
