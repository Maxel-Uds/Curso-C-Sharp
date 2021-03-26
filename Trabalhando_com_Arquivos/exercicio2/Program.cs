using System;
using System.IO;
using System.Globalization;
using exercicio2.Entities;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o caminho até o arquivo onde ficará guardado os dados da ordem: ");
                string filePath = @"" + Console.ReadLine();
                Console.Write("Quantas linhas terá o arquivo " + Path.GetFileName(filePath) + ": ");
                int n = int.Parse(Console.ReadLine());

                FileStream fs;
                StreamWriter origin;
                StreamWriter target;
                using( fs = new FileStream(filePath, FileMode.Open))
                {
                    using(origin = new StreamWriter(fs))
                    {
                        for(int i = 1; i <= n; i++)
                        {
                            Console.WriteLine($"Digite os dados do produto #{i} (nome,preço,quantidade):");
                            origin.WriteLine(Console.ReadLine());
                        }
                    }
                }
                string[] lines = File.ReadAllLines(filePath);//Usa-se sem instanciar

                Console.Write("Digite o caminho até o arquivo onde ficará guardado o resumo da ordem: ");
                string targetPath = @"" + Console.ReadLine(); 

                using(fs = new FileStream(targetPath, FileMode.Open))
                {
                    using(target = new StreamWriter(fs))
                    {
                        foreach(string line in lines)
                        {
                            string[] field = line.Split(',');
                            string name = field[0];
                            double price = double.Parse(field[1], CultureInfo.InvariantCulture);
                            int quantity = int.Parse(field[2]);

                            Product prod = new Product(name, price, quantity);

                            target.WriteLine(prod.Name.ToUpper() + ", " + prod.TotalValue().ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }

                Console.Clear();
                lines = File.ReadAllLines(filePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine();
                lines = File.ReadAllLines(targetPath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
