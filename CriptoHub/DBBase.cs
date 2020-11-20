using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CriptoHub
{
    class DBBase
    {
        public void ExecutarInstrucaoNaBase (string QuerySQL)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
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
