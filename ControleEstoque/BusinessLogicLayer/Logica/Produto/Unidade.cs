using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Utilidades;

namespace Logica
{
    public static class Unidade
    {
        public static Entidades.Unidade ObterUnidadePorCodigo(string codigo)
        {
            return Dados.Unidade.ObterUnidadePorCodigo(codigo);
        }

        public static Entidades.Unidade[] ObterListaUnidades()
        {
            return Dados.Unidade.ObterListaUnidades();
        }

        public static void Inserir(ref Entidades.Unidade unidade)
        {
            if (unidade == null)
                throw new Exception("Unidade não informada para Inclusão");

            if (string.IsNullOrEmpty(unidade.Codigo))
                throw new Exception("Por favor informe o Código da Unidade");

            if (string.IsNullOrEmpty(unidade.Descricao))
                throw new Exception("Por favor informe a Descrição da Unidade");

            try
            {
                Dados.Unidade.Inserir(ref unidade);
            }
            catch (Exception ex)
            {
                Log.ToFile("Unidade.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Inclusão da Unidade de Medida");
            }
        }

        public static void Alterar(ref Entidades.Unidade unidade)
        {
            if (unidade == null)
                throw new Exception("Unidade não informada para Alteração");

            if (string.IsNullOrEmpty(unidade.Descricao))
                throw new Exception("Por favor informe a Descrição da Unidade");

            try
            {
                Dados.Unidade.Alterar(ref unidade);
            }
            catch (Exception ex)
            {
                Log.ToFile("Unidade.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Alteração da Unidade de Medida");
            }
        }
    }
}
