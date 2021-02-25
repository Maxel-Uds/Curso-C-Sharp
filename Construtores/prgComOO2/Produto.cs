using System;
using System.Globalization;

namespace prgComOO2
{
    public class Produto
    {
        private string _nome;
        //Auto properties
        public double Preco { get; private set;}
        public int Quantidade { get; private set;}
        //Auto properties

        //Construtores
        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Construtores

        //Properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        //Properties

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
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}