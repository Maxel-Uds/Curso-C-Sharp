using System;
using System.Globalization;

namespace prgComOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x;
            x = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + x);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            x.AddProd(qte);

            Console.WriteLine("Dados atualizados: " + x);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            x.RemProd(qte);

            Console.WriteLine("Dados atualizados: " + x);

        }
    }
}
