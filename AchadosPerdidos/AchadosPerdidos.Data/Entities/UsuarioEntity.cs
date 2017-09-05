using AchadosPerdidos.Infra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Data.Entities
{
    public class UsuarioEntity
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime DadaNascimento { get; set; }

        public bool Administrador { get; set; }

        public Usuario ToEntity()
        {
            return new Usuario(Nome, Sobrenome, Telefone, Email, DadaNascimento);
        }

    }
}
