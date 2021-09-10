using CriptoHub.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CriptoHub
{
    public partial class Home : Form
    {
        private Form FormularioAtual;
        public Home()
        {
            InitializeComponent();
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        public Home (string Nome)
        {
            InitializeComponent();
            lbNome.Text = Nome; // variavel que irá receber o usuario logado
        }
        private void AbrirFormulario(Form Formulario)
        {
            if (FormularioAtual != null)
            {
                FormularioAtual.Close();
            }
            FormularioAtual = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Formulario);
            panelDesktop.Tag = Formulario;
            Formulario.BringToFront();
            Formulario.Show(); 
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            TelaLogin j1 = new TelaLogin();
            j1.Show();
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btContratos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Contratos());
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Clientes());
        }

        private void btLocatarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Locatarios());
        }

        private void btImoveis_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Imoveis());
        }

        private void HoraData_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToShortTimeString();
            lbData.Text = DateTime.Now.ToLongDateString();
        }

        private void btFeedback_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FeedBack());
        }

        private void btSuporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software já está atualizado!", "Suporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

