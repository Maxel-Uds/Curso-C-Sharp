using System;
using System.Collections.Generic;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionarios> lista = new List<Funcionarios>();
            Console.WriteLine();

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                lista.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o Id do funcionário para aumentar o salario: ");
            int IdSearch = int.Parse(Console.ReadLine());
            Funcionarios emp = lista.Find(x => x.Id == IdSearch);

            if(emp != null) {
                Console.Write("Digite a porcentagem para aumentar o salario: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.AumentarSalario(porcentagem);
                Console.WriteLine();
            }
            else {
                Console.WriteLine("Essa Id não foi encontrada!");
                Console.WriteLine();
            }

            Console.WriteLine("Lista atualizada de empregados: ");
            foreach(Funcionarios obj in lista) {
                Console.WriteLine(obj);
            }

        }
    }
}
