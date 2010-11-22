using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dados
{
    public static class LocalEstoque
    {
        static IDbCommand s_comandoObterLocalEstoquePorCodigo;
        static IDbCommand s_comandoInserir;
        static IDbCommand s_comandoAlterar;

        public static Entidades.LocalEstoque ObterLocalEstoquePorCodigo(string codigo)
        {
            Entidades.LocalEstoque LocalEstoque = null;
            IDataReader dados;

            if (s_comandoObterLocalEstoquePorCodigo == null)
            {
                s_comandoObterLocalEstoquePorCodigo = Conexao.ObterConexao().CreateCommand();

                s_comandoObterLocalEstoquePorCodigo.CommandText = "SELECT * FROM LocaisEstoque WHERE Codigo = @codigo";
                s_comandoObterLocalEstoquePorCodigo.CommandType = CommandType.Text;
                s_comandoObterLocalEstoquePorCodigo.Prepare();
            }
            else
            {
                if (s_comandoObterLocalEstoquePorCodigo.Connection.State != ConnectionState.Open)
                    s_comandoObterLocalEstoquePorCodigo.Connection.Open();
            }

            s_comandoObterLocalEstoquePorCodigo.Parameters.Clear();

            IDbDataParameter parametro = s_comandoObterLocalEstoquePorCodigo.CreateParameter();
            parametro.ParameterName = "codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = codigo;

            s_comandoObterLocalEstoquePorCodigo.Parameters.Add(parametro);

            try
            {
                dados = s_comandoObterLocalEstoquePorCodigo.ExecuteReader();

                if (dados != null && dados.Read())
                    PreencherEntidade(ref LocalEstoque, dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoObterLocalEstoquePorCodigo.Connection.Close();
            }

            return LocalEstoque;
        }

        public static void Inserir(ref Entidades.LocalEstoque local)
        {
            if (s_comandoInserir == null)
            {
                s_comandoInserir = Conexao.ObterConexao().CreateCommand();

                s_comandoInserir.CommandText = @"INSERT INTO LocaisEstoques (Codigo, Descricao, Inativo) 
                                                 VALUES (@codigo, @descricao, @inativo)";
                s_comandoInserir.CommandType = CommandType.Text;
                s_comandoInserir.Prepare();
            }
            else
            {
                if (s_comandoInserir.Connection.State != ConnectionState.Open)
                    s_comandoInserir.Connection.Open();
            }

            AdicionarParametros(ref s_comandoInserir, local);

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

        public static void Alterar(ref Entidades.LocalEstoque LocalEstoque)
        {
            if (s_comandoAlterar == null)
            {
                s_comandoAlterar = Conexao.ObterConexao().CreateCommand();

                s_comandoAlterar.CommandText = "UPDATE LocaisEstoques SET Descricao = @descricao, Inativo = @inativo WHERE Codigo = @codigo";
                s_comandoAlterar.CommandType = CommandType.Text;
                s_comandoAlterar.Prepare();
            }
            else
            {
                if (s_comandoAlterar.Connection.State != ConnectionState.Open)
                    s_comandoAlterar.Connection.Open();
            }

            AdicionarParametros(ref s_comandoAlterar, LocalEstoque);

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

        private static void AdicionarParametros(ref IDbCommand comando, Entidades.LocalEstoque LocalEstoque)
        {
            IDbDataParameter parametro;

            comando.Parameters.Clear();

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = LocalEstoque.Codigo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@descricao";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = LocalEstoque.Descricao;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@inativo";
            parametro.DbType = DbType.Boolean;
            parametro.Value = LocalEstoque.Inativo;
            comando.Parameters.Add(parametro);
        }

        private static void PreencherEntidade(ref Entidades.LocalEstoque local, IDataReader dados)
        {
            if (local == null)
                local = new Entidades.LocalEstoque();

            local.Codigo = dados["Codigo"].ToString();
            local.Descricao = dados["Descricao"].ToString();
            local.Inativo = (dados["Inativo"].ToString() == "0") ? false : true;
        }
    }
}
