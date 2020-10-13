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


        //Construtor padrão (0 argumentos) 
        public Produto()
        {

        }

        //Contrutor de 2 argumentos
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            //Quantidade começará no valor 0 (por padrão)
        }

        //Construtor de 3 argumento
        public Produto(string nome, double preco, int quantidade)
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
