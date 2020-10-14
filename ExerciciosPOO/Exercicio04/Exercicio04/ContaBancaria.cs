using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class ContaBancaria
    { 
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public int Conta { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Conta = numero;
            Nome = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        /*public string Nome
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
        }*/

        public double Deposito(double valor)
        {
            return Saldo += valor;
        }

        public double Saque(double valor)
        {
            return Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Dados da conta atualizados: \nConta " 
                + Conta + ", "
                + "Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2");
        }
    }
}
