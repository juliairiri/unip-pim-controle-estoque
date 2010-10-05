using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;
using Logica;

namespace Servico
{
    public class Servico : IServico
    {
        #region Operações do Usuário

        public Entidades.Usuario ObterUsuarioPorCodigo(string codigo)
        {
            return Logica.Usuario.ObterUsuarioPorCodigo(codigo);
        }

        public void InserirUsuario(ref Entidades.Usuario usuario)
        {
            Logica.Usuario.Inserir(ref usuario);
        }

        public void AlterarUsuario(ref Entidades.Usuario usuario)
        {
            Logica.Usuario.Alterar(ref usuario);
        }

        #endregion
    }
}
