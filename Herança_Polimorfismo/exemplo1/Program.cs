using System;
using exemplo1.Entities;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
           Account acc1 = new Account(1001, "Alex",500.00);
           Account acc2 = new SavingsAccount(2001, "Maria", 500.00, 0.1);

           acc1.WithDraw(10);
           acc2.WithDraw(10);

           Console.WriteLine(acc1.Number + ", " + acc1.Holder + ", " + acc1.Balance);
           Console.WriteLine(acc2.Number + ", " + acc2.Holder + ", " + acc2.Balance);
        }
    }
}
