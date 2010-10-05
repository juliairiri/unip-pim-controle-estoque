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

        public static Entidades.Usuario Autenticar(string codigo, string senha)
        {
            if (string.IsNullOrEmpty(codigo))
                throw new Exception("Por favor informe o Código do Usuário");

            if (string.IsNullOrEmpty(senha))
                throw new Exception("Por favor informe a Senha do Usuário");
            
            string mensagem = "Usuário ou Senha inválidos";
            // criptografar a senha digitada, nunca compara as senhas descriptografadas
            string senhaCriptografada = Utilidades.Criptografia.Criptografar(senha);

            // pesquisar o usuário
            Entidades.Usuario usuario = ObterUsuarioPorCodigo(codigo);

            // se não retorno a entidade é que não achou o usuário
            // ou se a senha não for igual retornar exceção
            if (usuario == null || usuario.Senha.Trim() != senhaCriptografada.Trim())
                throw new Exception(mensagem);

            return usuario;
        }

        public static void Inserir(ref Entidades.Usuario usuario)
        {
            if (usuario == null)
                throw new Exception("Usuário não informado para Inclusão");
            
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
            if (usuario == null)
                throw new Exception("Usuário não informado para Alteração");

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

        public static void Deletar(Entidades.Usuario usuario)
        {
            if (usuario == null)
                throw new Exception("Usuário não informado para Exclusão");

            try
            {
                Dados.Usuario.Deletar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a Exclusão do Usuário");
            }
        }
    }
}
