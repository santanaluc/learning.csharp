﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        //Atributos
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
            
        }

        //Contrutor de 2 argumentos
        public Produto(string nome, double preco) : this() //reaproveitando a quantidade acima
        {
            _nome = nome;
            _preco = preco;
        }

        //Construtor de 3 argumento
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Encapsulamentos
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome == null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        //Métodos
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ " +
                _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
