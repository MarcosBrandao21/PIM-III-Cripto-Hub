using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace db
{
    public class Banco
    {
        public bool Login(string Login, string senha)
        {
            bool ret = false;


            //SqlConnection con = null; 
            SqlConnection Conexao = new SqlConnection(@"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True");
            Conexao.Open(); //Abrir a conexao
            string query = "SELECT * FROM USERS_ADM WHERE NAME = '" + Login + "' AND PASSWORD = " + senha;
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1) ret = true;
            Conexao.Close();
            return ret;
        }
    }
}
