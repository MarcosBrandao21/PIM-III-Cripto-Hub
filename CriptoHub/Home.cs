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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            TelaLogin j1 = new TelaLogin();
            j1.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
