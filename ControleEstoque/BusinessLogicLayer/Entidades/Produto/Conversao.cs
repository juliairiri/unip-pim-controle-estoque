using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Conversao
    {
        private string _produto;
        [DataMember]
        public string Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }

        private string _unidadeOrigem;
        [DataMember]
        public string UnidadeOrigem
        {
            get { return _unidadeOrigem; }
            set { _unidadeOrigem = value; }
        }

        private string _unidadeDestino;
        [DataMember]
        public string UnidadeDestino
        {
            get { return _unidadeDestino; }
            set { _unidadeDestino = value; }
        }

        private float _fator;
        [DataMember]
        public float Fator
        {
            get { return _fator; }
            set { _fator = value; }
        }

        private bool _inativo;
        [DataMember]
        public bool Inativo
        {
            get { return _inativo; }
            set { _inativo = value; }
        }
    }
}
