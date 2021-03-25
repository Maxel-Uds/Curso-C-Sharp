using System;
using System.IO;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Adyel\Documents\Repositórios\Curso-C-Sharp\Trabalhando_com_Arquivos\exemplo1\file1.txt";
            string targetPath = @"C:\Users\Adyel\Documents\Repositórios\Curso-C-Sharp\Trabalhando_com_Arquivos\exemplo1\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
