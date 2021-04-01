using System;
using exercicio1.Entities;
using System.Collections.Generic;
using System.IO;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRegister> log = new HashSet<LogRegister>();

            Console.Write("Digite o caminho do arquivo: ");
            string filePath = @"" + Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(filePath))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');;
                        string name = line[0];
                        DateTime moment = DateTime.Parse(line[1]);
                        log.Add(new LogRegister(name, moment));
                    }
                }

                Console.WriteLine("Total de usuários: " + log.Count);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
