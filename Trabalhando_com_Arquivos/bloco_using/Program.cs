using System;
using System.IO;

namespace bloco_using
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Adyel\Documents\Repositórios\Curso-C-Sharp\Trabalhando_com_Arquivos\bloco_using\file1.txt";

            using(FileStream fs = new FileStream(path, FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
