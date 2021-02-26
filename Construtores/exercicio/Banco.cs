using System.Globalization;

namespace exercicio
{
    public class Banco
    {
        public string Nome { get; private set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public Banco (string nome, int conta) {
            Nome = nome;
            Conta = conta;
        }

        public void PrimeiroDepos (double pdeposito){
            Saldo = pdeposito;
        }

        public void Deposito(double deposito) {
            Saldo = Saldo + deposito;
        }

        public void Saque(double saque) {
            Saldo = Saldo - (saque + 5.00);
        } 

        public override string ToString()
        {
            return "Conta " + Conta + ", Titualr: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}