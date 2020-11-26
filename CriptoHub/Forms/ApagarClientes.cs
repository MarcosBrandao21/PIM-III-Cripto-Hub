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
    public partial class ApagarClientes : Form
    {
        public ApagarClientes()
        {
            InitializeComponent();
        }

        private void pbBuscarIdClientes_Click(object sender, EventArgs e)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, NAME, BIRTH, CPF, RG, SEXO, EMAIL, NAME_COMPANY, ID_REGISTRATION_STATUS FROM USERS WHERE ID =" + tbIdClientes.Text;
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgClientes.DataSource = dt;
        }

        private void pbRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbIdClientes_Click(object sender, EventArgs e)
        {
            tbIdClientes.Text = "";
        }

        private void pbRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBBase db = new DBBase();
                string Query = "DELETE USERS WHERE ID =" + tbIdClientes.Text;
                db.ExecutarInstrucaoNaBase(Query);
                this.Close();
            }
        }
    }
}
