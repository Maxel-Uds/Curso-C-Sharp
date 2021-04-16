using System;
using System.Linq;
using System.Collections.Generic;

class MinhaClasse 
{
  public static void Main (string[] args) 
  {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    List<HashSet<string>> completa = new List<HashSet<string>>();

    for(int i = 1; i <= totalDeCasosDeTeste; i++)
    {
        string[] lista = Console.ReadLine().Split(' ');
        HashSet<string> conj = new HashSet<string>();

        foreach(string obj in lista)
        {
            conj.Add(obj);
        }

        completa.Add(conj);
    }
    
    foreach(HashSet<string> obj in completa)
    {
        var ordem = obj.OrderBy(item => item);
        foreach(string item in ordem)
        {
          Console.Write(item + " ");
        }
        Console.WriteLine();
    }
  }
}