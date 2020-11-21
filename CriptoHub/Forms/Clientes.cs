using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CriptoHub.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            /*DBSeleciona db = new DBSeleciona();
            string Query = "SELECT ID, NAME, EMAIL, CPF FROM USERS ORDER BY ID ASC";
            db.ExecutarSelecaoNoBanco(Query);*/

            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, NAME, EMAIL, CPF FROM USERS ORDER BY ID ASC";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt); 
            dgClientes.DataSource = dt;
        }

        private void pbBuscarIdClientes_Click(object sender, EventArgs e)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, NAME, EMAIL, CPF FROM USERS WHERE ID =" + tbIdClientes.Text;
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgClientes.DataSource = dt;
        }

        private void pbBuscarNomeClientes_Click(object sender, EventArgs e)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, NAME, EMAIL, CPF FROM USERS WHERE NAME ='" + tbNomeClientes.Text + "'";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgClientes.DataSource = dt;
        }

        private void tbNomeClientes_Click(object sender, EventArgs e)
        {
            tbNomeClientes.Text = "";
        }

        private void tbIdClientes_Click(object sender, EventArgs e)
        {
            tbIdClientes.Text = "";
        }
    }
}
