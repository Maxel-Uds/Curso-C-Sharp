using System;
using exemplo1.Entities;
using System.Collections.Generic;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc1 = new Account(1001, "Alex",500.00); -> ocorre erro porque não se pode instanciar classe abstrata
            List<Account> list = new List<Account>(); //Mesmo a classe sendo abstrata, pode ser usada como tipo, por exemplo em uma lista e permite também ocorrer o polimorfismo

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            double Tot = 0;

            foreach(Account obj in list)
            {
                Tot += obj.Balance;
            }

            Console.WriteLine(Tot.ToString("F2"));
        }
    }
}
