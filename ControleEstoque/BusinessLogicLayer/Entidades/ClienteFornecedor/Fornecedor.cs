using System.Runtime.Serialization;

namespace Entidades
{
    public class Fornecedor : Pessoa
    {
        private long _codigo;
        [DataMember]
        public long Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private long _codigoCliente;
        [DataMember]
        public long CodigoCliente
        {
            get { return _codigoCliente; }
            set { _codigoCliente = value; }
        }        
    }
}
