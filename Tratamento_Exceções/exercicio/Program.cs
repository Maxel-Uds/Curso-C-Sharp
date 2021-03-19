using System;
using exercicio.Entities;
using exercicio.Entities.Exceptions;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta:");
                Console.Write("Número: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string holder = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double withDrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withDrawLimit);
                Console.WriteLine();

                Console.Write("Digite um valor para saque: ");
                double amount = double.Parse(Console.ReadLine());
                acc.WithDraw(amount);
                Console.WriteLine("Saldo atualizado: " + acc.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
