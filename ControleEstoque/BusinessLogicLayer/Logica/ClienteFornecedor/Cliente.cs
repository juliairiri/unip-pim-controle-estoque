using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utilidades;

namespace Logica
{
    public class Cliente
    {
        public static Entidades.Cliente ObterClientePorCodigo(long codigo)
        {
            return Dados.Cliente.ObterClientePorCodigo(codigo);
        }

        public static void Inserir(ref Entidades.Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("Cliente não informado para Inclusão");

            try
            {
                Dados.Cliente.Inserir(ref cliente);
            }
            catch (Exception ex)
            {
                Log.ToFile("Cliente.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Inclusão do Cliente");
            }
        }

        public static void Alterar(ref Entidades.Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("Cliente não informado para Alteração");

            try
            {
                Dados.Cliente.Alterar(ref cliente);
            }
            catch (Exception ex)
            {
                Log.ToFile("Cliente.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Alteração do Cliente");
            }
        }
    }
}
