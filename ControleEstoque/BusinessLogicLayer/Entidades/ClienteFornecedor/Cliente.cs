using System.Runtime.Serialization;

namespace Entidades
{
    public class Cliente : Pessoa
    {
        private long _codigo;
        [DataMember]
        public long Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private long _codigoFornecedor;
        [DataMember]
        public long CodigoFornecedor
        {
            get { return _codigoFornecedor; }
            set { _codigoFornecedor = value; }
        }
    }
}
