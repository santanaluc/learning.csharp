using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class ContaBancaria
    { 
        private string _nome;
        private double _valor;
        private double _saldo;
        public int Conta { get; set; }

        public ContaBancaria()
        {

        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                } else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }

        public double Deposito(double valor)
        {
            return _saldo = _valor + valor;
        }

        public double Saque(double valor)
        {
            return _saldo = _valor - valor;
        }

        public override string ToString()
        {
            return "Conta " 
                + Conta + ", "
                + "Titlar: " + _nome + ", Saldo: $" + _saldo;
        }
    }
}
