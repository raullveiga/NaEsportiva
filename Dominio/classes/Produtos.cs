using System;
using Repositorio;

namespace Dominio.classes
{
    public class Produtos : Fornecedores
    {

        public string Nome { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoCompra { get; set; }
        public string Unidade { get; set; }
        public DateTime Data { get; set; }

        public Produtos()
        {
        }

        public Produtos(string nome, double precoVenda, double precoCompra, string unidade, Fornecedores fornecedor , DateTime data)
        {
            this.Nome = nome;
            this.PrecoVenda = precoVenda;
            this.PrecoCompra = precoCompra;
            this.Unidade = unidade;

        }
        



    }
}