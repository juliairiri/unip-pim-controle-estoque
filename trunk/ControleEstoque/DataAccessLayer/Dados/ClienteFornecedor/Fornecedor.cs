using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dados
{
    public static class Fornecedor
    {
        static IDbCommand s_comandoObterFornecedorPorCodigo;
        static IDbCommand s_comandoInserir;
        static IDbCommand s_comandoAlterar;

        public static Entidades.Fornecedor ObterFornecedorPorCodigo(long codigo)
        {
            Entidades.Fornecedor unidade = null;
            IDataReader dados;

            if (s_comandoObterFornecedorPorCodigo == null)
            {
                s_comandoObterFornecedorPorCodigo = Conexao.ObterConexao().CreateCommand();

                s_comandoObterFornecedorPorCodigo.CommandText = "SELECT * FROM Fornecedores WHERE Codigo = @codigo";
                s_comandoObterFornecedorPorCodigo.CommandType = CommandType.Text;
                s_comandoObterFornecedorPorCodigo.Prepare();
            }
            else
            {
                if (s_comandoObterFornecedorPorCodigo.Connection.State != ConnectionState.Open)
                    s_comandoObterFornecedorPorCodigo.Connection.Open();
            }

            s_comandoObterFornecedorPorCodigo.Parameters.Clear();

            IDbDataParameter parametro = s_comandoObterFornecedorPorCodigo.CreateParameter();
            parametro.ParameterName = "codigo";
            parametro.DbType = DbType.Int64;
            parametro.Value = codigo;

            s_comandoObterFornecedorPorCodigo.Parameters.Add(parametro);

            try
            {
                dados = s_comandoObterFornecedorPorCodigo.ExecuteReader();

                if (dados != null && dados.Read())
                    PreencherEntidade(ref unidade, dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoObterFornecedorPorCodigo.Connection.Close();
            }

            return unidade;
        }

        public static void Inserir(ref Entidades.Fornecedor unidade)
        {
            if (s_comandoInserir == null)
            {
                s_comandoInserir = Conexao.ObterConexao().CreateCommand();

                s_comandoInserir.CommandText = @"INSERT INTO Fornecedores (Tipo, Nome, RazaoSocial, Cpf, Cnpj, Logradouro, Numero, Complemento, Bairro, Cidade, Estado, Inativo) 
                                                 VALUES (@tipo, @nome, @razaoSocial, @cpf, @cnpj, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @inativo)";
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

        public static void Alterar(ref Entidades.Fornecedor fornecedor)
        {
            if (s_comandoAlterar == null)
            {
                s_comandoAlterar = Conexao.ObterConexao().CreateCommand();

                s_comandoAlterar.CommandText = @"UPDATE Fornecedores 
                                                 SET CodigoCliente = @codigoCliente, 
                                                     Tipo = @tipo, 
                                                     Nome = @nome, 
                                                     RazaoSocial = @razaoSocial, 
                                                     Cpf = @cpf, 
                                                     Cnpj = @cnpj, 
                                                     Logradouro = @logradouro, 
                                                     Numero = @numero, 
                                                     Complemento = @complemento, 
                                                     Bairro = @bairro, 
                                                     Cidade = @cidade, 
                                                     Estado = @estado, 
                                                     Inativo = @inativo
                                                 WHERE Codigo = @codigo";

                s_comandoAlterar.CommandType = CommandType.Text;
                s_comandoAlterar.Prepare();
            }
            else
            {
                if (s_comandoAlterar.Connection.State != ConnectionState.Open)
                    s_comandoAlterar.Connection.Open();
            }

            AdicionarParametros(ref s_comandoAlterar, fornecedor);

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

        private static void AdicionarParametros(ref IDbCommand comando, Entidades.Fornecedor fornecedor)
        {
            IDbDataParameter parametro;

            comando.Parameters.Clear();

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigo";
            parametro.DbType = DbType.Int64;
            parametro.Value = fornecedor.Codigo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigoCliente";
            parametro.DbType = DbType.Int64;
            parametro.Value = fornecedor.CodigoCliente;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@tipo";
            parametro.DbType = DbType.SByte;
            parametro.Value = fornecedor.Tipo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@nome";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = fornecedor.Nome;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@razaoSocial";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = fornecedor.RazaoSocial;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@cpf";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = fornecedor.Cpf;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@cnpj";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = fornecedor.Cnpj;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@logradouro";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = fornecedor.Logradouro;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@numero";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = fornecedor.Numero;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@complemento";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = fornecedor.Complemento;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@bairro";
            parametro.DbType = DbType.String;
            parametro.Size = 50;
            parametro.Value = fornecedor.Bairro;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@cidade";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = fornecedor.Cidade;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@estado";
            parametro.DbType = DbType.String;
            parametro.Size = 2;
            parametro.Value = fornecedor.Estado;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@inativo";
            parametro.DbType = DbType.Boolean;
            parametro.Value = fornecedor.Inativo;
            comando.Parameters.Add(parametro);
        }

        private static void PreencherEntidade(ref Entidades.Fornecedor fornecedor, IDataReader dados)
        {
            if (fornecedor == null)
                fornecedor = new Entidades.Fornecedor();

            fornecedor.Codigo = long.Parse(dados["Codigo"].ToString());
            fornecedor.CodigoCliente = long.Parse(dados["CodigoCliente"].ToString());
            fornecedor.Tipo = (Entidades.TipoPessoa)dados["Tipo"];
            fornecedor.Nome = dados["Nome"].ToString();
            fornecedor.RazaoSocial = dados["RazaoSocial"].ToString();
            fornecedor.Cpf = dados["Cpf"].ToString();
            fornecedor.Cnpj = dados["Cnpj"].ToString();
            fornecedor.Logradouro = dados["Logradouro"].ToString();
            fornecedor.Numero = dados["Numero"].ToString();
            fornecedor.Complemento = dados["Complemento"].ToString();
            fornecedor.Bairro = dados["Bairro"].ToString();
            fornecedor.Cidade = dados["Cidade"].ToString();
            fornecedor.Estado = dados["Estado"].ToString();
            fornecedor.Inativo = (dados["Inativo"].ToString() == "0") ? false : true;
        }
    }
}
