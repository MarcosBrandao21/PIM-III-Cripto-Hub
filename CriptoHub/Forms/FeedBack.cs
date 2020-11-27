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
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }
        public void SendEmail()
        {
            /*System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            message.To.Add(tbPara.Text);

            message.CC.Add(tbCc.Text);

            System.Net.Mail.Attachment anexo = new System.Net.Mail.Attachment(tbAnexo.Text);

            message.Attachments.Add(anexo);

            message.Subject = tbAssunto.Text;

            message.From = new System.Net.Mail.MailAddress("marcosv2138@gmail.com");

            message.Body = rtbMensagem.Text;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

            smtp.Host = "smtp.gmail.com"; //servidor do gmail

            smtp.EnableSsl = true;

            smtp.Credentials = new System.Net.NetworkCredential("Marcos","1234");

            smtp.Send(message);
            */

            MessageBox.Show("Email enviado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FeedBack_Load(object sender, EventArgs e)
        {

        }


        private void pbProcurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbAnexo.Text = openFileDialog1.FileName;
        }

        private void pbEnviar_Click(object sender, EventArgs e)
        {
            SendEmail();
        }
    }
}
