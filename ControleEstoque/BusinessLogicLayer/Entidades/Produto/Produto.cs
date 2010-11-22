using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class Produto
    {
        private string _codigo;
        [DataMember]
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _descricao;
        [DataMember]
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private string _unidadeEstoque;
        [DataMember]
        public string UnidadeEstoque
        {
            get { return _unidadeEstoque; }
            set { _unidadeEstoque = value; }
        }

        private string _unidadeCompra;
        [DataMember]
        public string UnidadeCompra
        {
            get { return _unidadeCompra; }
            set { _unidadeCompra = value; }
        }

        private string _unidadeVenda;
        [DataMember]
        public string UnidadeVenda
        {
            get { return _unidadeVenda; }
            set { _unidadeVenda = value; }
        }
        
        private string _usuarioInclusao;
        [DataMember]
        public string UsuarioInclusao
        {
            get { return _usuarioInclusao; }
            set { _usuarioInclusao = value; }
        }
        
        private DateTime _dataInclusao;
        [DataMember]
        public DateTime DataInclusao
        {
            get { return _dataInclusao; }
            set { _dataInclusao = value; }
        }

        private string _usuarioAlteracao;
        [DataMember]
        public string UsuarioAlteracao
        {
            get { return _usuarioAlteracao; }
            set { _usuarioAlteracao = value; }
        }

        private DateTime _dataAlteracao;
        [DataMember]
        public DateTime DataAlteracao
        {
            get { return _dataAlteracao; }
            set { _dataAlteracao = value; }
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
