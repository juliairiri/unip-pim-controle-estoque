using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Dados;
using Entidades;  

namespace Servico
{
    [ServiceContract]
    public interface IServico
    {
        #region Operações com o Usuário

        [OperationContract]
        Entidades.Usuario ObterUsuarioPorCodigo(string codigo);

        [OperationContract]
        Entidades.Usuario Autenticar(string codigo, string senha);

        [OperationContract]
        void AlterarSenha(ref Entidades.Usuario usuario, string senha);

        [OperationContract]
        void InserirUsuario(ref Entidades.Usuario usuario);

        [OperationContract]
        void AlterarUsuario(ref Entidades.Usuario usuario);

        [OperationContract]
        void DeletarUsuario(Entidades.Usuario usuario);

        #endregion
    }
}
