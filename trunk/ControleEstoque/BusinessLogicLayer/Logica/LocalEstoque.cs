using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utilidades;

namespace Logica
{
    public static class LocalEstoque
    {
        public static Entidades.LocalEstoque ObterLocalEstoquePorCodigo(string codigo)
        {
            return Dados.LocalEstoque.ObterLocalEstoquePorCodigo(codigo);
        }

        public static void Inserir(ref Entidades.LocalEstoque local)
        {
            if (local == null)
                throw new Exception("Local de Estoque não informado para Inclusão");

            if (string.IsNullOrEmpty(local.Codigo))
                throw new Exception("Por favor informe o Código do Local de Estoque");

            if (string.IsNullOrEmpty(local.Descricao))
                throw new Exception("Por favor informe a Descrição do Local");

            try
            {
                Dados.LocalEstoque.Inserir(ref local);
            }
            catch (Exception ex)
            {
                Log.ToFile("LocalEstoque.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Inclusão do Local de Estoque");
            }
        }

        public static void Alterar(ref Entidades.LocalEstoque local)
        {
            if (local == null)
                throw new Exception("Local de Estoque não informado para Alteração");

            if (string.IsNullOrEmpty(local.Descricao))
                throw new Exception("Por favor informe a Descrição do Local");

            try
            {
                Dados.LocalEstoque.Alterar(ref local);
            }
            catch (Exception ex)
            {
                Log.ToFile("LocalEstoque.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Alteração do Local de Estoque");
            }
        }
    }
}
