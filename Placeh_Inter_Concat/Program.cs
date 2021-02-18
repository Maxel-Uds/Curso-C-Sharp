using System;

namespace aula18
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade = 32;
           double saldo = 10.35784;
           string nome = "Maria";
            //Placeholder
           Console.WriteLine("{0} tem {1} anos e um saldo de {2:F2} reais", nome, idade, saldo);
           //Interpolação
           Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo.ToString("F2")} reais");
           //Concatenação
           Console.WriteLine(nome + " tem " + idade + " anos e um saldo de " + saldo.ToString("F2") + " reais");
        }
    }
}
