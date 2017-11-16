using System;

namespace Dominio.classes {
    public class PF {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }

        public PF () { }

        public PF (int id, string cpf, string nome, string email, string telefone, DateTime dataCadastro, DateTime dataNascimento, Endereco endereco) {
            this.Id = id;
            this.Cpf = cpf;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.DataCadastro = dataCadastro;
            this.DataNascimento = dataNascimento;
            this.Endereco = endereco;

        }

    }
}