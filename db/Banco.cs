using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using DllConfiguracao;

namespace db
{
    public class Banco
    {
        public bool Login(string Login, string senha)
        {
            bool ret = false;

            //utiliza a DLL de configuração do appconfig, que armazena a string de conexão
            Configuracao configuracao = new Configuracao();

            string strConexao = configuracao.StrConfiguracao;
            string query = "SELECT * FROM USERS_ADM WHERE NAME = '" + Login + "' AND PASSWORD = " + senha;

            SqlDataAdapter dp = new SqlDataAdapter(query, strConexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);


            if (dt.Rows.Count == 1) ret = true;
            //Conexao.Close();
            return ret;
        }
    }
}
