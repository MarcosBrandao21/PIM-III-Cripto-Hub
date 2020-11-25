using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CriptoHub.Forms
{
    public partial class AdicionarCliente : Form
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void pbRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            DBBase db = new DBBase();
            string Query = "INSERT INTO USERS( NAME, BIRTH,CPF,RG,SEXO,EMAIL, PASSWORD, NAME_COMPANY, ID_REGISTRATION_STATUS)VALUES("
             + "'" + tbNome.Text + "'" + ",'" + mtbNascimento.Text + "'" + 
             ",'" + tbCPF.Text + "'" +  ",'" + tbRG.Text + "'" +  ",'" + tbSexo.Text + "'" +
             ",'" + tbEmail.Text + "'" + ",'" + tbSenha.Text + "'" +
             ",'" + tbNomeEmpresa.Text + "'," + tbID.Text + ")";

            db.ExecutarInstrucaoNaBase(Query);
            this.Close();
        }
    }
}
