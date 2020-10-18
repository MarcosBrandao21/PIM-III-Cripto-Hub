using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace CriptoHub
{
    public partial class TelaLogin : Form
    {
        //Referencia da conexão

        SqlConnection Conexao = new SqlConnection(@"Data Source=LAPTOP-O50L6FC1\MSSQLSERVER02;Initial Catalog=CRIPTOHUB;Integrated Security=True");
        public TelaLogin()
        {
            InitializeComponent();
            txtNomeAdm.Select();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Preciso arrumar a conexao com DB
            Conexao.Open(); //Abrir a conexao
            string query = "SELECT * FROM USERS_ADM WHERE NAME = '" + txtNomeAdm.Text + "' AND PASSWORD = '" + txtSenhaAdm.Text + '"';
            SqlDataAdapter dp = new SqlDataAdapter(query,Conexao);
            DataTable dt = new DataTable();
            //dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                Home j2 = new Home();
                j2.Show();
                this.Hide();
                Conexao.Close();
            }
           
            else
            {
                MessageBox.Show("Usuario ou Password incorreto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeAdm.Text = ""; // limpa as textbox depois de serem verificadas
                txtSenhaAdm.Text = "";
                txtNomeAdm.Select(); //cursor ira sinalizar a primeira txtbox
            }


            
        }
    }
}
