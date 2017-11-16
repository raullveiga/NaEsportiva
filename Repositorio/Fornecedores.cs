using Dominio.interfaces;
using Dominio.classes;
using System;

namespace Repositorio
{
    public class Fornecedores : IDominio
    {

        public PJ Empresa { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCadastro { get; set; }


        public Fornecedores(PJ empresa, string categoria, DateTime dataCadastro)
        {
            this.Empresa = empresa;
            this.Categoria = categoria;
            this.DataCadastro = dataCadastro;

        }

        public string Cadastrar()
        {
            throw new NotImplementedException();
        }

        public string Consultar()
        {
            throw new NotImplementedException();
        }
    }
}