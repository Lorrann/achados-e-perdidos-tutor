using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Infra.Models
{
    public class ObjetoPerdido
    {
        public ObjetoPerdido(string tipo, string marca, string cor, DateTime dataPerda)
        {
            Tipo = tipo;
            Marca = marca;
            Cor = cor;
            DataPerda = dataPerda;
        }

        public int IdObjeto { get; set; }

        private string _tipo;
        public string Tipo {
            get { return _tipo; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Tipo é um campo obrigatório!");
                this._tipo = value;
            }
        }

        private string _marca;
        public string Marca { get { return _marca; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Marca é um campo obrigatório!");
                this._marca = value;
            }
        }

        private string _cor;
        public string Cor { get { return _cor; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Cor é um campo obrigatório!");
                this._cor = value;
            }
        }

        public string Tamanho { get; set; }

        public string Nome { get; set; }

        private DateTime _dataPerda;
        public DateTime DataPerda { get {return _dataPerda; }
            set
            {
                if (value > DateTime.Now.Date) throw new Exception("Data invalida");
                this._dataPerda = value;
            }
        }

        public uint TempoPerdido {
            get
            {
                TimeSpan diferenca = DateTime.Now.Date - this.DataPerda.Date;

                return Convert.ToUInt32(diferenca.TotalDays);
            }
        }
    }
}
