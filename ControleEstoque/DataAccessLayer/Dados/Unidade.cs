using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;

namespace Dados
{
    public static class Unidade
    {
        static IDbCommand s_comandoObterUnidadePorCodigo;
        static IDbCommand s_comandoInserir;
        static IDbCommand s_comandoAlterar;

        public static Entidades.Unidade ObterUnidadePorCodigo(string codigo)
        {
            Entidades.Unidade unidade = null;
            IDataReader dados;

            if (s_comandoObterUnidadePorCodigo == null)
            {
                s_comandoObterUnidadePorCodigo = Conexao.ObterConexao().CreateCommand();

                s_comandoObterUnidadePorCodigo.CommandText = "SELECT * FROM UNIDADES WHERE CODIGO = @codigo";
                s_comandoObterUnidadePorCodigo.CommandType = CommandType.Text;
                s_comandoObterUnidadePorCodigo.Prepare();
            }
            else
            {
                if (s_comandoObterUnidadePorCodigo.Connection.State != ConnectionState.Open)
                    s_comandoObterUnidadePorCodigo.Connection.Open();
            }

            s_comandoObterUnidadePorCodigo.Parameters.Clear();

            IDbDataParameter parametro = s_comandoObterUnidadePorCodigo.CreateParameter();
            parametro.ParameterName = "codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = codigo;

            s_comandoObterUnidadePorCodigo.Parameters.Add(parametro);

            try
            {
                dados = s_comandoObterUnidadePorCodigo.ExecuteReader();

                if (dados != null && dados.Read())
                    PreencherEntidade(ref unidade, dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoObterUnidadePorCodigo.Connection.Close();
            }

            return unidade;
        }

        public static void Inserir(ref Entidades.Unidade unidade)
        {
            if (s_comandoInserir == null)
            {
                s_comandoInserir = Conexao.ObterConexao().CreateCommand();

                s_comandoInserir.CommandText = "INSERT INTO UNIDADES (CODIGO, DESCRICAO) VALUES (@codigo, @descricao)";
                s_comandoInserir.CommandType = CommandType.Text;
                s_comandoInserir.Prepare();
            }
            else
            {
                if (s_comandoInserir.Connection.State != ConnectionState.Open)
                    s_comandoInserir.Connection.Open();
            }

            AdicionarParametros(ref s_comandoInserir, unidade);

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

        public static void Alterar(ref Entidades.Unidade unidade)
        {
            if (s_comandoAlterar == null)
            {
                s_comandoAlterar = Conexao.ObterConexao().CreateCommand();

                s_comandoAlterar.CommandText = "UPDATE UNIDADES SET DESCRICAO = @descricao, INATIVO = @inativo WHERE CODIGO = @codigo";
                s_comandoAlterar.CommandType = CommandType.Text;
                s_comandoAlterar.Prepare();
            }
            else
            {
                if (s_comandoAlterar.Connection.State != ConnectionState.Open)
                    s_comandoAlterar.Connection.Open();
            }

            AdicionarParametros(ref s_comandoAlterar, unidade);

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

        private static void AdicionarParametros(ref IDbCommand comando, Entidades.Unidade unidade)
        {
            IDbDataParameter parametro;

            comando.Parameters.Clear();

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = unidade.Codigo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@descricao";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = unidade.Descricao;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@inativo";
            parametro.DbType = DbType.Boolean;
            parametro.Value = unidade.Inativo;
            comando.Parameters.Add(parametro);
        }

        private static void PreencherEntidade(ref Entidades.Unidade unidade, IDataReader dados)
        {
            if (unidade == null)
                unidade = new Entidades.Unidade();

            unidade.Codigo = dados["Codigo"].ToString();
            unidade.Descricao = dados["Descricao"].ToString();
            unidade.Inativo = (dados["Inativo"].ToString() == "0") ? false : true;
        }

    }
}
