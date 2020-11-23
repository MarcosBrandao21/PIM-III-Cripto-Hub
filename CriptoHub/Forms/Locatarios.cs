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
    public partial class Locatarios : Form
    {
        public Locatarios()
        {
            InitializeComponent();

        }

        private void Locatarios_Load(object sender, EventArgs e)
        {
            /*string strConxao = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            string Query = "SELECT ID, NAME, EMAIL, CPF FROM USERS ORDER BY ID ASC";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgLocatarios.DataSource = dt;*/
        }


        // Arrumar Combo box
        private void comboboxclientes()
        {
            //comboBox1.Text = "Selecione o Cliente";
            String scon = @"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True";
            SqlConnection  con = new SqlConnection(scon);
            try
            {
                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String query = "select name from USERS";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            comboBox1.DataSource = null;
            da.Fill(dtResultado);
            comboBox1.DataSource = dtResultado;
            comboBox1.ValueMember = "NAME";
            comboBox1.DisplayMember = "USERS";
            comboBox1.SelectedItem = "";
            comboBox1.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboboxclientes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgLocatarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
