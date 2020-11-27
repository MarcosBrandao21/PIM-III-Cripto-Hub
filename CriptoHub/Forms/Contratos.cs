using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CriptoHub
{
    public partial class Contratos : Form
    {
        public Contratos()
        {
            InitializeComponent();
        }

        private void Contratos_Load(object sender, EventArgs e)
        {

        }

        private void pbListagemDados_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pbDesenvolvimento_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pbValidacao_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
