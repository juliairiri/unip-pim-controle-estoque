using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public static class Produto
    {
        public static Entidades.Produto ObterProdutoPorCodigo(string codigo)
        {
            return Dados.Produto.ObterProdutoPorCodigo(codigo);
        }

        public static void Inserir(ref Entidades.Produto produto)
        {
            if (produto == null)
                throw new Exception("Produto não informado para Inclusão");

            if (string.IsNullOrEmpty(produto.Codigo))
                throw new Exception("Por favor informe o Código do Produto");

            if (string.IsNullOrEmpty(produto.Descricao))
                throw new Exception("Por favor informe a Descrição do Produto");

            produto.UsuarioInclusao = Contexto.Usuario.Codigo;
            produto.DataInclusao = DateTime.Now;
            produto.UsuarioAlteracao = Contexto.Usuario.Codigo;
            produto.DataAlteracao = DateTime.Now;

            try
            {
                Dados.Produto.Inserir(ref produto);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a Inclusão do Produto");
            }
        }

        public static void Alterar(ref Entidades.Produto produto)
        {
            if (produto == null)
                throw new Exception("Produto não informado para Alteração");

            if (string.IsNullOrEmpty(produto.Descricao))
                throw new Exception("Por favor informe a Descrição do Produto");

            produto.UsuarioAlteracao = Contexto.Usuario.Codigo;
            produto.DataAlteracao = DateTime.Now;

            try
            {
                Dados.Produto.Alterar(ref produto);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a Alteração do Produto");
            }
        }

    }
}
