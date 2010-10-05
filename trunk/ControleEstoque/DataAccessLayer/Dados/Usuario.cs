using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;

namespace Dados
{
    public static class Usuario
    {
        static IDbCommand s_comandoObterUsuarioPorCodigo;
        static IDbCommand s_comandoInserir;
        static IDbCommand s_comandoAlterar;
        static IDbCommand s_comandoDeletar;

        public static Entidades.Usuario ObterUsuarioPorCodigo(string codigo)
        {
            Entidades.Usuario usuario = null;
            IDataReader dados;

            if (s_comandoObterUsuarioPorCodigo == null)
            {
                s_comandoObterUsuarioPorCodigo = Conexao.ObterConexao().CreateCommand();

                s_comandoObterUsuarioPorCodigo.CommandText = "SELECT * FROM USUARIOS WHERE CODIGO = @codigo";
                s_comandoObterUsuarioPorCodigo.CommandType = CommandType.Text;
            }
            else
            {
                if (s_comandoObterUsuarioPorCodigo.Connection.State != ConnectionState.Open)
                    s_comandoObterUsuarioPorCodigo.Connection.Open();
            }

            s_comandoObterUsuarioPorCodigo.Parameters.Clear();

            IDbDataParameter parametro = s_comandoObterUsuarioPorCodigo.CreateParameter();
            parametro.ParameterName = "codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 30;
            parametro.Value = codigo;

            s_comandoObterUsuarioPorCodigo.Parameters.Add(parametro);

            try
            {
                dados = s_comandoObterUsuarioPorCodigo.ExecuteReader();

                if (dados != null && dados.Read())
                    PreencherEntidade(ref usuario, dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoDeletar.Connection.Close();
            }

            return usuario;
        }

        public static void Inserir(ref Entidades.Usuario usuario)
        {
            if (s_comandoInserir == null)
            {
                s_comandoInserir = Conexao.ObterConexao().CreateCommand();

                s_comandoInserir.CommandText = "INSERT INTO USUARIOS (CODIGO, ATIVO, NOME, SENHA) VALUES (@codigo, @ativo, @nome, @senha)";
                s_comandoInserir.CommandType = CommandType.Text;
            }
            else
            {
                if (s_comandoInserir.Connection.State != ConnectionState.Open)
                    s_comandoInserir.Connection.Open();
            }

            AdicionarParametros(ref s_comandoInserir, usuario, true);

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
                s_comandoDeletar.Connection.Close();
            }
        }

        public static void Alterar(ref Entidades.Usuario usuario)
        {
            if (s_comandoAlterar == null)
            {
                s_comandoAlterar = Conexao.ObterConexao().CreateCommand();

                s_comandoAlterar.CommandText = "UPDATE USUARIOS SET ATIVO = @ativo, NOME = @nome, SENHA = @senha WHERE CODIGO = @codigo";
                s_comandoAlterar.CommandType = CommandType.Text;
            }
            else
            {
                if (s_comandoAlterar.Connection.State != ConnectionState.Open)
                    s_comandoAlterar.Connection.Open();
            }

            AdicionarParametros(ref s_comandoAlterar, usuario, false);

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
                s_comandoDeletar.Connection.Close();
            }
        }

        public static void Deletar(Entidades.Usuario usuario)
        {
            if (s_comandoDeletar == null)
            {
                s_comandoDeletar = Conexao.ObterConexao().CreateCommand();

                s_comandoDeletar.CommandText = "DELETE FROM USUARIOS WHERE CODIGO = @codigo";
                s_comandoDeletar.CommandType = CommandType.Text;
            }
            else
            {
                if (s_comandoDeletar.Connection.State != ConnectionState.Open)
                    s_comandoDeletar.Connection.Open();
            }

            s_comandoDeletar.Parameters.Clear();

            IDbDataParameter parametro = s_comandoDeletar.CreateParameter();

            parametro.ParameterName = "codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 30;
            parametro.Value = usuario.Codigo;

            s_comandoDeletar.Parameters.Add(parametro);

            try
            {
                s_comandoDeletar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoDeletar.Connection.Close();
            }
        }

        private static void AdicionarParametros(ref IDbCommand comando, Entidades.Usuario usuario, bool inclusao)
        {
            IDbDataParameter parametro;

            comando.Parameters.Clear();

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigo";
            parametro.DbType = DbType.String;
            parametro.Size = 30;
            parametro.Value = usuario.Codigo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@ativo";
            parametro.DbType = DbType.Boolean;
            parametro.Value = usuario.Ativo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@nome";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = usuario.Nome;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@senha";
            parametro.DbType = DbType.String;
            parametro.Size = 1024;
            parametro.Value = usuario.Senha;
            comando.Parameters.Add(parametro);
        }

        private static void PreencherEntidade(ref Entidades.Usuario usuario, IDataReader dados)
        {
            if (usuario == null)
                usuario = new Entidades.Usuario();

            usuario.Codigo = dados["Codigo"].ToString();
            usuario.Ativo = (dados["Ativo"].ToString() == "0") ? false : true;
            usuario.Nome = dados["Nome"].ToString();
            usuario.Senha = dados["Senha"].ToString();
        }
    }
}
