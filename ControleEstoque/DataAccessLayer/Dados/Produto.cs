using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dados
{
    public static class Produto
    {
        static IDbCommand s_comandoObterProdutoPorCodigo;
        static IDbCommand s_comandoInserir;
        static IDbCommand s_comandoAlterar;

        public static Entidades.Produto ObterProdutoPorCodigo(string codigo)
        {
            Entidades.Produto Produto = null;
            IDataReader dados;

            if (s_comandoObterProdutoPorCodigo == null)
            {
                s_comandoObterProdutoPorCodigo = Conexao.ObterConexao().CreateCommand();

                s_comandoObterProdutoPorCodigo.CommandText = "SELECT * FROM Produtos WHERE Codigo = @codigo";
                s_comandoObterProdutoPorCodigo.CommandType = CommandType.Text;
                s_comandoObterProdutoPorCodigo.Prepare();
            }
            else
            {
                if (s_comandoObterProdutoPorCodigo.Connection.State != ConnectionState.Open)
                    s_comandoObterProdutoPorCodigo.Connection.Open();
            }

            s_comandoObterProdutoPorCodigo.Parameters.Clear();

            IDbDataParameter parametro = s_comandoObterProdutoPorCodigo.CreateParameter();
            parametro.ParameterName = "codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = codigo;

            s_comandoObterProdutoPorCodigo.Parameters.Add(parametro);

            try
            {
                dados = s_comandoObterProdutoPorCodigo.ExecuteReader();

                if (dados != null && dados.Read())
                    PreencherEntidade(ref Produto, dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoObterProdutoPorCodigo.Connection.Close();
            }

            return Produto;
        }

        public static void Inserir(ref Entidades.Produto produto)
        {
            if (s_comandoInserir == null)
            {
                s_comandoInserir = Conexao.ObterConexao().CreateCommand();

                s_comandoInserir.CommandText = @"INSERT INTO Produtos (Codigo, Descricao, UnidadeEstoque, UnidadeCompra, UnidadeVenda, UsuarioInclusao, DataInclusao, UsuarioAlteracao, DataAlteracao, Inativo) 
                                                 VALUES (@codigo, @descricao, @unidadeEstoque, @unidadeCompra, @unidadeVenda, @usuarioInclusao, @dataInclusao, @usuarioAlteracao, @dataAlteracao, @inativo)";
                s_comandoInserir.CommandType = CommandType.Text;
                s_comandoInserir.Prepare();
            }
            else
            {
                if (s_comandoInserir.Connection.State != ConnectionState.Open)
                    s_comandoInserir.Connection.Open();
            }

            AdicionarParametros(ref s_comandoInserir, produto);

            try
            {
                s_comandoInserir.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoInserir.Connection.Close();
            }
        }

        public static void Alterar(ref Entidades.Produto Produto)
        {
            if (s_comandoAlterar == null)
            {
                s_comandoAlterar = Conexao.ObterConexao().CreateCommand();

                s_comandoAlterar.CommandText = "UPDATE Produtos SET Descricao = @descricao, UnidadeEstoque = @unidadeEstoque, UnidadeCompra = @unidadeCompra, UnidadeVenda = @unidadeVenda, UsuarioAlteracao = @usuarioAlteracao, DataAlteracao = @dataAlteracao, Inativo = @inativo WHERE Codigo = @codigo";
                s_comandoAlterar.CommandType = CommandType.Text;
                s_comandoAlterar.Prepare();
            }
            else
            {
                if (s_comandoAlterar.Connection.State != ConnectionState.Open)
                    s_comandoAlterar.Connection.Open();
            }

            AdicionarParametros(ref s_comandoAlterar, Produto);

            try
            {
                s_comandoAlterar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoAlterar.Connection.Close();
            }
        }

        private static void AdicionarParametros(ref IDbCommand comando, Entidades.Produto Produto)
        {
            IDbDataParameter parametro;

            comando.Parameters.Clear();

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = Produto.Codigo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@descricao";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = Produto.Descricao;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@unidadeEstoque";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = Produto.UnidadeEstoque;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@unidadeCompra";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = Produto.UnidadeCompra;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@unidadeVenda";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = Produto.UnidadeVenda;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@usuarioInclusao";
            parametro.DbType = DbType.String;
            parametro.Size = 30;
            parametro.Value = Produto.UsuarioInclusao;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@dataInclusao";
            parametro.DbType = DbType.DateTime;
            parametro.Value = Produto.DataInclusao;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@usuarioAlteracao";
            parametro.DbType = DbType.String;
            parametro.Size = 30;
            parametro.Value = Produto.UsuarioInclusao;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@dataAlteracao";
            parametro.DbType = DbType.DateTime;
            parametro.Value = Produto.DataAlteracao;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@inativo";
            parametro.DbType = DbType.Boolean;
            parametro.Value = Produto.Inativo;
            comando.Parameters.Add(parametro);
        }

        private static void PreencherEntidade(ref Entidades.Produto Produto, IDataReader dados)
        {
            if (Produto == null)
                Produto = new Entidades.Produto();

            Produto.Codigo = dados["Codigo"].ToString();
            Produto.Descricao = dados["Descricao"].ToString();
            Produto.UnidadeEstoque = dados["UnidadeEstoque"].ToString();
            Produto.UnidadeCompra = dados["UnidadeCompra"].ToString();
            Produto.UnidadeVenda = dados["UnidadeVenda"].ToString();
            Produto.UsuarioInclusao = dados["UnidadeInclusao"].ToString();
            Produto.DataInclusao = Convert.ToDateTime(dados["DataInclusao"]);
            Produto.UsuarioAlteracao = dados["UnidadeAlteracao"].ToString();
            Produto.DataAlteracao = Convert.ToDateTime(dados["DataAlteracao"]);
            Produto.Inativo = (dados["Inativo"].ToString() == "0") ? false : true;
        }

    }
}
