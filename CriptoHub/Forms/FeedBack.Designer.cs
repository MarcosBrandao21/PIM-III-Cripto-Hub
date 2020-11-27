namespace CriptoHub.Forms
{
    partial class FeedBack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedBack));
            this.lbImoveis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPara = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnexo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbProcurar = new System.Windows.Forms.PictureBox();
            this.pbEnviar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbImoveis
            // 
            this.lbImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbImoveis.AutoSize = true;
            this.lbImoveis.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImoveis.Location = new System.Drawing.Point(83, 43);
            this.lbImoveis.Name = "lbImoveis";
            this.lbImoveis.Size = new System.Drawing.Size(236, 36);
            this.lbImoveis.TabIndex = 26;
            this.lbImoveis.Text = "Fornecer FeedBack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(115, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Para";
            // 
            // tbPara
            // 
            this.tbPara.BackColor = System.Drawing.SystemColors.Control;
            this.tbPara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPara.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPara.Location = new System.Drawing.Point(116, 120);
            this.tbPara.MaxLength = 255;
            this.tbPara.Name = "tbPara";
            this.tbPara.ReadOnly = true;
            this.tbPara.Size = new System.Drawing.Size(577, 19);
            this.tbPara.TabIndex = 28;
            this.tbPara.Text = "contato@criptohub.com";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(118, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 1);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(117, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cc";
            // 
            // tbCc
            // 
            this.tbCc.BackColor = System.Drawing.SystemColors.Control;
            this.tbCc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCc.Location = new System.Drawing.Point(118, 169);
            this.tbCc.MaxLength = 255;
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(577, 19);
            this.tbCc.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(120, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 1);
            this.panel1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(117, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Anexar Ficheiro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbAnexo
            // 
            this.tbAnexo.BackColor = System.Drawing.SystemColors.Control;
            this.tbAnexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnexo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnexo.Location = new System.Drawing.Point(120, 231);
            this.tbAnexo.MaxLength = 255;
            this.tbAnexo.Name = "tbAnexo";
            this.tbAnexo.Size = new System.Drawing.Size(577, 19);
            this.tbAnexo.TabIndex = 34;
            this.tbAnexo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(121, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 1);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(115, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Assunto";
            // 
            // tbAssunto
            // 
            this.tbAssunto.BackColor = System.Drawing.SystemColors.Control;
            this.tbAssunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAssunto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAssunto.Location = new System.Drawing.Point(116, 308);
            this.tbAssunto.MaxLength = 255;
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.Size = new System.Drawing.Size(577, 19);
            this.tbAssunto.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(118, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 1);
            this.panel4.TabIndex = 36;
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMensagem.Location = new System.Drawing.Point(118, 367);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(583, 102);
            this.rtbMensagem.TabIndex = 39;
            this.rtbMensagem.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(119, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Mensagem";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbProcurar
            // 
            this.pbProcurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProcurar.Image = ((System.Drawing.Image)(resources.GetObject("pbProcurar.Image")));
            this.pbProcurar.Location = new System.Drawing.Point(605, 256);
            this.pbProcurar.Name = "pbProcurar";
            this.pbProcurar.Size = new System.Drawing.Size(90, 31);
            this.pbProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProcurar.TabIndex = 43;
            this.pbProcurar.TabStop = false;
            this.pbProcurar.Click += new System.EventHandler(this.pbProcurar_Click);
            // 
            // pbEnviar
            // 
            this.pbEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEnviar.Image = ((System.Drawing.Image)(resources.GetObject("pbEnviar.Image")));
            this.pbEnviar.Location = new System.Drawing.Point(605, 475);
            this.pbEnviar.Name = "pbEnviar";
            this.pbEnviar.Size = new System.Drawing.Size(90, 31);
            this.pbEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnviar.TabIndex = 44;
            this.pbEnviar.TabStop = false;
            this.pbEnviar.Click += new System.EventHandler(this.pbEnviar_Click);
            // 
            // FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 546);
            this.Controls.Add(this.pbEnviar);
            this.Controls.Add(this.pbProcurar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbMensagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAssunto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAnexo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPara);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbImoveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeedBack";
            this.Text = "FeedBack";
            this.Load += new System.EventHandler(this.FeedBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProcurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnviar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbImoveis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPara;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnexo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtbMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbProcurar;
        private System.Windows.Forms.PictureBox pbEnviar;
    }
}