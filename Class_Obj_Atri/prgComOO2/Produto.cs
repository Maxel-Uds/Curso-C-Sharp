using System;
using System.Globalization;

namespace prgComOO2
{
    public class Produto
    {
       public string Nome;
       public double Preco;
       public int Quantidade;

        public double ValorTotal() {
            return Quantidade * Preco;
        }

        public void AddProd(int quantidade) {
           Quantidade = Quantidade + quantidade;
        }

        public void RemProd(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}