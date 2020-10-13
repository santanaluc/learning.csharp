using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        //Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        //Contrutor de 2 argumentos
        public Produto(string nome, double preco) : this() //reaproveitando a quantidade acima
        {
            Nome = nome;
            Preco = preco;
        }

        //Construtor de 3 argumento
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
            return Nome
                + ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
