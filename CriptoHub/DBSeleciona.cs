using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DllConfiguracao;

namespace CriptoHub
{
    public class DBSeleciona
    {
        public DataTable ExecutarSelecaoNoBanco (string QuerySQL)
        {
            Configuracao configuracao = new Configuracao();

            string strConxao = configuracao.StrConfiguracao;
            string Query = QuerySQL;
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
