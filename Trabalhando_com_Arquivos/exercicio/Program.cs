using System;
using System.IO;
using System.Globalization;
using exercicio.Entities;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Adyel\Documents\Repositórios\Curso-C-Sharp\Trabalhando_com_Arquivos\exercicio\n.csv";
            string[] lines = File.ReadAllLines(sourcePath);

            string sourceDirPath = Path.GetDirectoryName(sourcePath);
            string targetDirPath = sourceDirPath + @"\out";
            string targetFilePath = targetDirPath + @"\summary.csv";

            Directory.CreateDirectory(targetDirPath);

            using(StreamWriter sw = File.AppendText(targetFilePath))
            {
                foreach(string line in lines)
                {
                    string[] field = line.Split(',');
                    string name = field[0];
                    double price = double.Parse(field[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(field[2]);

                    Product prod = new Product(name, price, quantity);
                    sw.WriteLine(prod.Name + " | " + prod.TotalValue().ToString("F2", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
