﻿using System;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            
            Banco b = new Banco(nome, conta);
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();
            if (resp == "s") {
                Console.Write("Entre com o valor do depósito inicial: ");
                double pdeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b.PrimeiroDepos(pdeposito);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);
            Console.WriteLine();

            Console.Write("Entre com o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(b);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(b);
        }
    }
}
