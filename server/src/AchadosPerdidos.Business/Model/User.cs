using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Business.Model
{
    public class User
    {
        private string _name;
        public string Name {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Nome é um campo obrigatório");
                this._name = value;
            }
        }

        private string _fone;
        public string Fone {
            get { return _fone; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Telefone é um campo obrigatório");
                this._fone = value;
            }
        }

        private string _mail;
        public string Mail {
            get {return _mail; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("E-mail é um campo obrigatório");
                this._mail = value;
            }
        }

        private string _cpf;
        public string CPF {
            get {return _cpf; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("CPF é um campo obrigatório");
                this._cpf = value;
            }
        }

        private string _password;
        public string Password {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Senha é um campo obrigatório");
                this._password = value;
            }
        }

    }
}
