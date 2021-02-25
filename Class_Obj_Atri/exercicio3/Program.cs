using System;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            x.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double nota = x.Media();

            if (nota >= 60.00) {
                Console.WriteLine("NOTA FINAL = " + nota.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else {
                double faltou = x.Falta(nota);
                Console.WriteLine("NOTA FINAL = " + nota.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + faltou.ToString("F2", CultureInfo.InvariantCulture) + " PONTO(S)");
            }

        }
    }
}
