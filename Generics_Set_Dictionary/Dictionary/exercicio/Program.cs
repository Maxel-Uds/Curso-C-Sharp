using System;
using System.IO;
using System.Collections.Generic;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();

            Console.Write("Digite o caminho até o arquivo onde os dados da votação estão armazenados? ");
            string filePath = Console.ReadLine();

            using(StreamReader sr = File.OpenText(filePath))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string recordingCandidate = line[0];
                    int recordingVote = int.Parse(line[1]);

                    if(votes.ContainsKey(recordingCandidate))
                    {
                        votes[recordingCandidate] += recordingVote;
                    }
                    else
                    {
                        votes[recordingCandidate] = recordingVote;
                    }
                }
            }

            foreach(KeyValuePair<string, int> obj in votes)
            {
                Console.WriteLine(obj.Key + ": " + obj.Value);
            }
        }
    }
}
