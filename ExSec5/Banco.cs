using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExSec5
{
    internal class Banco
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }

        public double Saldo { get; private set; }

        private double _deposito;

        public Banco(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        } 

        public Banco(string nome, int numero, double deposito):this(nome, numero)
        {
            _deposito = deposito;
        }
        public double Deposito
        {
            get { return _deposito; }
            set
            {
                if (value > 0)
                {
                    Saldo += value;
                }
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
