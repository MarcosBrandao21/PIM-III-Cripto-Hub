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
    public partial class ApagarImovel : Form
    {
        public ApagarImovel()
        {
            InitializeComponent();
        }

        private void pbBuscarLocatarios_Click(object sender, EventArgs e)
        {
            string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = " select * from IMMOBILE WHERE ID =" + tbIdImoveis.Text;
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgImoveis.DataSource = dt;
        }

        private void pbRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBBase db = new DBBase();
                string Query = "DELETE IMMOBILE WHERE ID =" + tbIdImoveis.Text;
                db.ExecutarInstrucaoNaBase(Query);
                this.Close();
            }
        }

        private void pbRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbIdImoveis_Click(object sender, EventArgs e)
        {
            tbIdImoveis.Text = "";
        }
    }
}
