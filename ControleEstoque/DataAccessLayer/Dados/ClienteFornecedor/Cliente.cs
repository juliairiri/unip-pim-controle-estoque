using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Dados
{
    public static class Cliente
    {
        static IDbCommand s_comandoObterClientePorCodigo;
        static IDbCommand s_comandoInserir;
        static IDbCommand s_comandoAlterar;

        public static Entidades.Cliente ObterClientePorCodigo(long codigo)
        {
            Entidades.Cliente unidade = null;
            IDataReader dados;

            if (s_comandoObterClientePorCodigo == null)
            {
                s_comandoObterClientePorCodigo = Conexao.ObterConexao().CreateCommand();

                s_comandoObterClientePorCodigo.CommandText = "SELECT * FROM Clientes WHERE Codigo = @codigo";
                s_comandoObterClientePorCodigo.CommandType = CommandType.Text;
                s_comandoObterClientePorCodigo.Prepare();
            }
            else
            {
                if (s_comandoObterClientePorCodigo.Connection.State != ConnectionState.Open)
                    s_comandoObterClientePorCodigo.Connection.Open();
            }

            s_comandoObterClientePorCodigo.Parameters.Clear();

            IDbDataParameter parametro = s_comandoObterClientePorCodigo.CreateParameter();
            parametro.ParameterName = "codigo";
            parametro.DbType = DbType.Int64;
            parametro.Value = codigo;

            s_comandoObterClientePorCodigo.Parameters.Add(parametro);

            try
            {
                dados = s_comandoObterClientePorCodigo.ExecuteReader();

                if (dados != null && dados.Read())
                    PreencherEntidade(ref unidade, dados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                s_comandoObterClientePorCodigo.Connection.Close();
            }

            return unidade;
        }

        public static void Inserir(ref Entidades.Cliente cliente)
        {
            if (s_comandoInserir == null)
            {
                s_comandoInserir = Conexao.ObterConexao().CreateCommand();

                s_comandoInserir.CommandText = @"INSERT INTO Clientes (Tipo, Nome, RazaoSocial, Cpf, Cnpj, Logradouro, Numero, Complemento, Bairro, Cidade, Estado, Cep, Inativo) 
                                                 VALUES (@tipo, @nome, @razaoSocial, @cpf, @cnpj, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @cep, @inativo)";
                s_comandoInserir.CommandType = CommandType.Text;
                s_comandoInserir.Prepare();
            }
            else
            {
                if (s_comandoInserir.Connection.State != ConnectionState.Open)
                    s_comandoInserir.Connection.Open();
            }

            AdicionarParametros(ref s_comandoInserir, cliente);

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

        public static void Alterar(ref Entidades.Cliente cliente)
        {
            if (s_comandoAlterar == null)
            {
                s_comandoAlterar = Conexao.ObterConexao().CreateCommand();

                s_comandoAlterar.CommandText = @"UPDATE Clientes 
                                                 SET CodigoFornecedor = @codigoFornecedor, 
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
                                                     Cep = @cep,
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

            AdicionarParametros(ref s_comandoAlterar, cliente);

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

        private static void AdicionarParametros(ref IDbCommand comando, Entidades.Cliente cliente)
        {
            IDbDataParameter parametro;

            comando.Parameters.Clear();

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigo";
            parametro.DbType = DbType.Int64;
            parametro.Value = cliente.Codigo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@codigoFornecedor";
            parametro.DbType = DbType.Int64;
            parametro.Value = cliente.CodigoFornecedor;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@tipo";
            parametro.DbType = DbType.SByte;
            parametro.Value = cliente.Tipo;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@nome";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = cliente.Nome;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@razaoSocial";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = cliente.RazaoSocial;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@cpf";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = cliente.Cpf;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@cnpj";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = cliente.Cnpj;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@logradouro";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = cliente.Logradouro;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@numero";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = cliente.Numero;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@complemento";
            parametro.DbType = DbType.String;
            parametro.Size = 20;
            parametro.Value = cliente.Complemento;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@bairro";
            parametro.DbType = DbType.String;
            parametro.Size = 50;
            parametro.Value = cliente.Bairro;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@cidade";
            parametro.DbType = DbType.String;
            parametro.Size = 100;
            parametro.Value = cliente.Cidade;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@estado";
            parametro.DbType = DbType.String;
            parametro.Size = 2;
            parametro.Value = cliente.Estado;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@cep";
            parametro.DbType = DbType.String;
            parametro.Size = 8;
            parametro.Value = cliente.Cep;
            comando.Parameters.Add(parametro);

            parametro = comando.CreateParameter();
            parametro.ParameterName = "@inativo";
            parametro.DbType = DbType.Boolean;
            parametro.Value = cliente.Inativo;
            comando.Parameters.Add(parametro);
        }

        private static void PreencherEntidade(ref Entidades.Cliente cliente, IDataReader dados)
        {
            if (cliente == null)
                cliente = new Entidades.Cliente();

            cliente.Codigo = long.Parse(dados["Codigo"].ToString());
            cliente.CodigoFornecedor = long.Parse(dados["CodigoFornecedor"].ToString());
            cliente.Tipo = (Entidades.TipoPessoa)dados["Tipo"];
            cliente.Nome = dados["Nome"].ToString();
            cliente.RazaoSocial = dados["RazaoSocial"].ToString();
            cliente.Cpf = dados["Cpf"].ToString();
            cliente.Cnpj = dados["Cnpj"].ToString();
            cliente.Logradouro = dados["Logradouro"].ToString();
            cliente.Numero = dados["Numero"].ToString();
            cliente.Complemento = dados["Complemento"].ToString();
            cliente.Bairro = dados["Bairro"].ToString();
            cliente.Cidade = dados["Cidade"].ToString();
            cliente.Estado = dados["Estado"].ToString();
            cliente.Inativo = (dados["Inativo"].ToString() == "0") ? false : true;
        }
    }
}
