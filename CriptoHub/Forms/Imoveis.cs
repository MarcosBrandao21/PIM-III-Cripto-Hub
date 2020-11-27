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
    public partial class Imoveis : Form
    {
        public Imoveis()
        {
            InitializeComponent();
        }

        private void Imoveis_Load(object sender, EventArgs e)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, ID_USER, ADRESSES, NUMBER, CITY, CEP, VALUE_IMMOBILE FROM IMMOBILE ORDER BY ID ASC";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgImoveis.DataSource = dt;
        }

        private void pbBuscarCEPImoveis_Click(object sender, EventArgs e)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, ID_USER, ADRESSES, NUMBER, CITY, CEP, VALUE_IMMOBILE FROM IMMOBILE WHERE CEP =" + tbDadosImoveis.Text;
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgImoveis.DataSource = dt;
        }

        private void pbBuscarIdImoveis_Click(object sender, EventArgs e)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, ID_USER, ADRESSES, NUMBER, CITY, CEP, VALUE_IMMOBILE FROM IMMOBILE WHERE ID =" + tbIdImoveis.Text;
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgImoveis.DataSource = dt;
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            EditarImovel editarImovel = new EditarImovel();
            editarImovel.Show();
            this.Hide();
        }

        private void pbAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarImovel adicionarImovel = new AdicionarImovel();
            adicionarImovel.Show();
            this.Hide();
        }

        private void pbRemover_Click(object sender, EventArgs e)
        {
            ApagarImovel apagarImovel = new ApagarImovel();
            apagarImovel.Show();
            this.Hide();
        }

        private void tbDadosImoveis_Click(object sender, EventArgs e)
        {
            tbDadosImoveis.Text = "";
        }

        private void tbIdImoveis_Click(object sender, EventArgs e)
        {
            tbIdImoveis.Text = "";
        }
    }
}
