using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do funcionário: ");
            Console.Write("Nome: ");
            Funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            Funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            Funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario.SalarioLiquido();

            Console.WriteLine("Funcionário" + Funcionario.Nome + ", $ " + Funcionario.SalarioLiqui.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario.AumentarSalario(porcentagem);
            
            Console.WriteLine("Dados atualizados: " + Funcionario.Nome + ", $ " + Funcionario.SalarioLiqui.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
