using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utilidades;

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
            
            // criptografar a senha digitada, nunca compara as senhas descriptografadas
            string senhaCriptografada = Utilidades.Criptografia.Criptografar(senha);

            // pesquisar o usuário
            Entidades.Usuario usuario = ObterUsuarioPorCodigo(codigo);

            // se não encontrou o usuário e o usuário pesquisado for "admin"
            // incluir o usuário administrador na base
            if (usuario == null && codigo == "admin")
            {
                Entidades.Usuario usuarioAdmin = new Entidades.Usuario();
                usuarioAdmin.Codigo = "admin";
                usuarioAdmin.Ativo = true;
                usuarioAdmin.Nome = "Administrador";
                usuarioAdmin.Senha = Utilidades.Criptografia.Criptografar("admin@01");

                Logica.Usuario.Inserir(ref usuarioAdmin);
            }

            // se não retorno a entidade é que não achou o usuário
            // ou se a senha não for igual retornar exceção
            if (usuario == null || usuario.Senha.Trim() != senhaCriptografada.Trim())
                throw new Exception("Usuário ou Senha inválidos");

            Contexto.Usuario = usuario;

            return usuario;
        }

        public static void AlterarSenha(ref Entidades.Usuario usuario, string senha)
        {
            if (string.IsNullOrEmpty(senha))
                throw new Exception("Por favor informe a Senha do Usuário");

            if (usuario.Codigo != "admin" && usuario.Codigo != Contexto.Usuario.Codigo)
                throw new Exception("Você não pode alterar a Senha de outro Usuário");

            usuario.Senha = Utilidades.Criptografia.Criptografar(senha);

            try
            {
                Logica.Usuario.Alterar(ref usuario);
            }
            catch (Exception ex)
            {
                Log.ToFile("Usuario.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar alterar a Senha do Usuário");
            }

        }

        public static void Inserir(ref Entidades.Usuario usuario)
        {
            if (usuario == null)
                throw new Exception("Usuário não informado para Inclusão");
            
            if (string.IsNullOrEmpty(usuario.Codigo))
                throw new Exception("Por favor informe o Código do Usuário");

            if (string.IsNullOrEmpty(usuario.Nome))
                throw new Exception("Por favor informe o Nome do Usuário");

            if (string.IsNullOrEmpty(usuario.Senha))
                usuario.Senha = Utilidades.Criptografia.Criptografar("1234");

            try
            {
                Dados.Usuario.Inserir(ref usuario);
            }
            catch (Exception ex)
            {
                Log.ToFile("Usuario.log", ex.Message + Environment.NewLine + ex.StackTrace);
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
                Log.ToFile("Usuario.log", ex.Message + Environment.NewLine + ex.StackTrace);
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
                Log.ToFile("Usuario.log", ex.Message + Environment.NewLine + ex.StackTrace);
                throw new Exception("Não foi possível realizar a Exclusão do Usuário");
            }
        }
    }
}
