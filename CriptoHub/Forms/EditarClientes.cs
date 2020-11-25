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
    public partial class EditarClientes : Form
    {
        public EditarClientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
           
            DBBase db = new DBBase();
            string Query = "UPDATE USERS SET NAME =" + "'" + tbNome.Text + "'" + ",BIRTH =" + "'" + mtbNascimento.Text + "'" + 
            ",CPF =" + "'" + tbCPF.Text + "'" + ",RG =" + "'" + tbRG.Text + "'" + ",SEXO =" + "'" + tbSexo.Text + "'" + 
            ",EMAIL =" + "'" + tbEmail.Text + "'" + ",PASSWORD =" + "'" + tbSenha.Text + "'" + 
            ",NAME_COMPANY =" + "'" + tbNomeEmpresa.Text + "'" + ",ID_REGISTRATION_STATUS =" + tbID.Text + "where ID =" + tbIDCliente.Text;

            db.ExecutarInstrucaoNaBase(Query);

            this.Close();
        }
    }
}
