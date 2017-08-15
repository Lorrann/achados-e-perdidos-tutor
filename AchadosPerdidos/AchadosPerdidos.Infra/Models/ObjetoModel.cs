using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Infra.Models
{
    public class ObjetoModel
    {
        public ObjetoModel(string tipo, string marca, string cor)
        {
            if (string.IsNullOrEmpty(tipo))
                throw new Exception("Tipo é um campo obrigatório!");

            if (string.IsNullOrEmpty(marca))
                throw new Exception("Marca é um campo obrigatório!");

            if (string.IsNullOrEmpty(cor))
                throw new Exception("Cor é um campo obrigatório!");

            Tipo = tipo;
            Marca = marca;
            Cor = cor;
        }

        public int IdObjeto { get; set; }

        public string Tipo { get; set; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public string Tamanho { get; set; }

        public string Nome { get; set; }
    }
}
