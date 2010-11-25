using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utilidades;

namespace Logica
{
    public class Fornecedor
    {
        public static Entidades.Fornecedor ObterFornecedorPorCodigo(long codigo)
        {
            return Dados.Fornecedor.ObterFornecedorPorCodigo(codigo);
        }

        public static void Inserir(ref Entidades.Fornecedor fornecedor)
        {
            if (fornecedor == null)
                throw new Exception("Fornecedor não informado para Inclusão");

            try
            {
                Dados.Fornecedor.Inserir(ref fornecedor);
            }
            catch (Exception ex)
            {
                Log.ToFile("Fornecedor.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Inclusão do Fornecedor");
            }
        }

        public static void Alterar(ref Entidades.Fornecedor fornecedor)
        {
            if (fornecedor == null)
                throw new Exception("Fornecedor não informado para Alteração");

            try
            {
                Dados.Fornecedor.Alterar(ref fornecedor);
            }
            catch (Exception ex)
            {
                Log.ToFile("Fornecedor.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Alteração do Fornecedor");
            }
        }
    }
}
