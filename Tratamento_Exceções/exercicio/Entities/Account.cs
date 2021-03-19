using System.Text;
using exercicio.Entities.Exceptions;

namespace exercicio.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > WithDrawLimit)
            {
                throw new DomainException("Saque não permitido: valor acima do limite de saque");
            }
            if(amount > Balance)
            {
                throw new DomainException("Saque não permitido: saldo insuficiente");
            }

            Balance -= amount;
        }
    }
}