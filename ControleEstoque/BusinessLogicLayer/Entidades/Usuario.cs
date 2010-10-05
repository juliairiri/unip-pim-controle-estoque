using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Usuario
    {
        private string _codigo;
        [DataMember]
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private bool _ativo;
        [DataMember]
        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        private string _nome;
        [DataMember]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _senha;
        [DataMember]
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

    }
}
