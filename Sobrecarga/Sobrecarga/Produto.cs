using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        //Atributos
        private string _nome;

        //Auto Properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
            
        }

        //Contrutor de 2 argumentos
        public Produto(string nome, double preco) : this() //reaproveitando a quantidade acima
        {
            _nome = nome;
            Preco = preco;
        }

        //Construtor de 3 argumento
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Encapsulamentos
        public string Nome
        {
            get { return _nome;  }
            set { 
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
