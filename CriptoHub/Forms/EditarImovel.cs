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
    public partial class EditarImovel : Form
    {
        public EditarImovel()
        {
            InitializeComponent();
        }

        private void pbRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
