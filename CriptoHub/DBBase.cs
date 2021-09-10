using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DllConfiguracao;

namespace CriptoHub
{
    class DBBase
    {
        public void ExecutarInstrucaoNaBase (string QuerySQL)
        {

            Configuracao configuracao = new Configuracao();

            string strConxao = configuracao.StrConfiguracao;
            string Query = QuerySQL;

            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);

            try
            {
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                string erro = ex.Message;
                erro += "  !!!";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
