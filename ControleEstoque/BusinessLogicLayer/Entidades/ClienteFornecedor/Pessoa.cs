using System.Runtime.Serialization;

namespace Entidades
{
    public class Pessoa
    {
        private TipoPessoa _tipo;
        [DataMember]
        public TipoPessoa Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _nome;
        [DataMember]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _razaoSocial;
        [DataMember]
        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }

        private string _cpf;
        [DataMember]
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        private string _cnpj;
        [DataMember]
        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private string _logradouro;
        [DataMember]
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        private string _numero;
        [DataMember]
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _complemento;
        [DataMember]
        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        private string _bairro;
        [DataMember]
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _cidade;
        [DataMember]
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _estado;
        [DataMember]
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private string _cep;
        [DataMember]
        public string Cep
        {
            get { return _cep; }
            set { _cep = value; }
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
