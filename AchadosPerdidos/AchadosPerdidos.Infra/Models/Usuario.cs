using AchadosPerdidos.Infra.ExtensionMethods;
using System;

namespace AchadosPerdidos.Infra.Models
{
    public class Usuario
    {

        public Usuario(string nome, string sobrenome, string telefone, string email,
            DateTime dataNascimento)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("Nome Inválido!");

            if (string.IsNullOrEmpty(sobrenome)) throw new Exception("Sobrenome Inválido!");

            if (string.IsNullOrEmpty(telefone)) throw new Exception("Telefone Inválido!");

            if (string.IsNullOrEmpty(email)) throw new Exception("E-mail Inválido!");

            int idade = dataNascimento.CalcularIdade();

            if (idade < 18)
                throw new Exception("Idade Inválida!");

            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
            DadaNascimento = dataNascimento;
        }

        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime DadaNascimento { get; set; }

        public bool Administrador { get; set; }
    }
}
