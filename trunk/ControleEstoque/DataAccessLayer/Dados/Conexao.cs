using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dados
{
    public static class Conexao
    {
        static string s_ParametrosConexao = @"Data Source=DANIEL-PC\desenv;Initial Catalog=ControleEstoque;Integrated Security=True";
        static IDbConnection s_Conexao;
        
        public static IDbConnection ObterConexao()
        {
            if (s_Conexao == null)
            {
                s_Conexao = new SqlConnection(s_ParametrosConexao);
            }

            if (s_Conexao.State != ConnectionState.Open)
                s_Conexao.Open();

            return s_Conexao;
        }
    }
}
