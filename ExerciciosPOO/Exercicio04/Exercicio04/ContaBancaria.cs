using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class ContaBancaria
    { 
        private string _nome;
        private readonly double _valor;
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
            return _saldo += valor;
        }

        public double Saque(double valor)
        {
            return _saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Dados da conta atualizados: \nConta " 
                + Conta + ", "
                + "Titular: " + _nome + ", Saldo: $" + _saldo.ToString("F2");
        }
    }
}
