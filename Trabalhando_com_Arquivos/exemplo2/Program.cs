
using System;
using System.IO;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Adyel\Documents\Repositórios\Curso-C-Sharp\Trabalhando_com_Arquivos\exemplo2\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
                if(fs != null) fs.Close();
            }
        }
    }
}
