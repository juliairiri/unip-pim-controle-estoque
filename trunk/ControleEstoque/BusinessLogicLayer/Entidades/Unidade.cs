using System.Runtime.Serialization;

namespace Dados
{
    [DataContract]
    public class Unidade
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

        private bool _inativo;
        [DataMember]
        public bool Inativo
        {
            get { return _inativo; }
            set { _inativo = value; }
        }
    }
}
