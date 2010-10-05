using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;
using Dados;

namespace Logica
{
    public static class Usuario
    {
        public static Entidades.Usuario ObterUsuarioPorCodigo(string codigo)
        {
            return Dados.Usuario.ObterUsuarioPorCodigo(codigo);
        }

        public static void Inserir(ref Entidades.Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Codigo))
                throw new Exception("Por favor informe o Código do Usuário");

            if (string.IsNullOrEmpty(usuario.Nome))
                throw new Exception("Por favor informe o Nome do Usuário");

            usuario.Senha = Utilidades.Criptografia.Criptografar("1234");

            try
            {
                Dados.Usuario.Inserir(ref usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a Inclusão do Usuário");
            }
        }

        public static void Alterar(ref Entidades.Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))
                throw new Exception("Por favor informe o Nome do Usuário");

            try
            {
                Dados.Usuario.Alterar(ref usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a Alteração do Usuário");
            }
        }
    }
}
