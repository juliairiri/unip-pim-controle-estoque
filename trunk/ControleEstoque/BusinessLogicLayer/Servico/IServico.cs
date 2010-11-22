using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Dados;
using Entidades;
using System.Data;  

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

        #region Operações com a Unidade de Pesos e Medidas

        [OperationContract]
        Entidades.Unidade ObterUnidadePorCodigo(string codigo);

        [OperationContract]
        Entidades.Unidade[] ObterListaUnidades();

        [OperationContract]
        void InserirUnidade(ref Entidades.Unidade usuario);

        [OperationContract]
        void AlterarUnidade(ref Entidades.Unidade usuario);

        #endregion

        #region Operações com o Produto

        [OperationContract]
        Entidades.Produto ObterProdutoPorCodigo(string codigo);

        [OperationContract]
        void InserirProduto(ref Entidades.Produto produto);

        [OperationContract]
        void AlterarProduto(ref Entidades.Produto produto);

        #endregion

        #region Operações com Local de Estoque

        [OperationContract]
        Entidades.LocalEstoque ObterLocalEstoquePorCodigo(string codigo);

        [OperationContract]
        void InserirLocalEstoque(ref Entidades.LocalEstoque local);

        [OperationContract]
        void AlterarLocalEstoque(ref Entidades.LocalEstoque local);

        #endregion
    }
}
