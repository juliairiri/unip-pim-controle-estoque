using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dados
{
    public static class Conversao
    {
        static IDbCommand s_comandoInserir;
        static IDbCommand s_comandoAlterar;

        public static void Inserir(ref Entidades.Conversao Conversao)
        {
            if (s_comandoInserir == null)
            {
                s_comandoInserir = Conexao.ObterConexao().CreateCommand();

                s_comandoInserir.CommandText = @"INSERT INTO Conversoes (Produto, UnidadeOrigem, UnidadeDestino, Fator, Inativo) 
                                                 VALUES (@produto, @unidadeOrigem, @unidadeDestino, @fator, @inativo)";
                s_comandoInserir.CommandType = CommandType.Text;
                s_comandoInserir.Prepare();
            }
            else
            {
                if (s_comandoInserir.Connection.State != ConnectionState.Open)
                    s_comandoInserir.Connection.Open();
            }

            AdicionarParametros(ref s_comandoInserir, Conversao);

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

        public static void Alterar(ref Entidades.Conversao Conversao)
        {
            if (s_comandoAlterar == null)
            {
                s_comandoAlterar = Conexao.ObterConexao().CreateCommand();

                s_comandoAlterar.CommandText = @"UPDATE Conversoes 
                                                 SET Fator = @fator, Inativo = @inativo 
                                                 WHERE Produto = @Produto 
                                                       AND UnidadeOrigem = @unidadeOrigem 
                                                       AND UnidadeDestino = @unidadeDestino";
                s_comandoAlterar.CommandType = CommandType.Text;
                s_comandoAlterar.Prepare();
            }
            else
            {
                if (s_comandoAlterar.Connection.State != ConnectionState.Open)
                    s_comandoAlterar.Connection.Open();
            }

            AdicionarParametros(ref s_comandoAlterar, Conversao);

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

        private static void AdicionarParametros(ref IDbCommand comando, Entidades.Conversao conversao)
        {
            IDbDataParameter parametro;

            comando.Parameters.Clear();

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@produto";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = conversao.Produto;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@unidadeOrigem";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = conversao.UnidadeOrigem;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@unidadeDestino";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = conversao.UnidadeDestino;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@fator";
            parametro.DbType = DbType.Double;
            parametro.Size = 18;
            parametro.Precision = 6;
            parametro.Value = conversao.Fator;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@inativo";
            parametro.DbType = DbType.Boolean;
            parametro.Value = conversao.Inativo;
            comando.Parameters.Add(parametro);
        }

        private static void PreencherEntidade(ref Entidades.Conversao Conversao, IDataReader dados)
        {
            if (Conversao == null)
                Conversao = new Entidades.Conversao();

            float fator;

            if (float.TryParse(dados["Fator"].ToString(), out fator))
                fator = 0;

            Conversao.Produto = dados["Produto"].ToString();
            Conversao.UnidadeOrigem = dados["UnidadeOrigem"].ToString();
            Conversao.UnidadeDestino = dados["UnidadeDestino"].ToString();
            Conversao.Fator = fator;            
            Conversao.Inativo = (dados["Inativo"].ToString() == "0") ? false : true;
        }
    }
}
