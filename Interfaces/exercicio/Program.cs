using System;
using exercicio.Entites;
using exercicio.Service;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as informações de contrato:");
            Console.Write("Número: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/aaaa): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Número de parcelas: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);
            ContractService service = new ContractService(new PayPal());
            service.ProcessContract(contract, months);

            Console.WriteLine();
            Console.WriteLine(contract);
        }
    }
}
