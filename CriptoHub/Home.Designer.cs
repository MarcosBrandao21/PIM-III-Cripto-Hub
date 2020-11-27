namespace CriptoHub
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btSuporte = new System.Windows.Forms.Button();
            this.btFeedback = new System.Windows.Forms.Button();
            this.btImoveis = new System.Windows.Forms.Button();
            this.btLocatarios = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btContratos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lbData = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HoraData = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AllowDrop = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btSuporte);
            this.panelMenu.Controls.Add(this.btFeedback);
            this.panelMenu.Controls.Add(this.btImoveis);
            this.panelMenu.Controls.Add(this.btLocatarios);
            this.panelMenu.Controls.Add(this.btClientes);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.btContratos);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lbNome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 566);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btSair
            // 
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btSair.Location = new System.Drawing.Point(25, 476);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(177, 27);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSuporte
            // 
            this.btSuporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSuporte.FlatAppearance.BorderSize = 0;
            this.btSuporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuporte.ForeColor = System.Drawing.SystemColors.Control;
            this.btSuporte.Location = new System.Drawing.Point(25, 434);
            this.btSuporte.Name = "btSuporte";
            this.btSuporte.Size = new System.Drawing.Size(177, 27);
            this.btSuporte.TabIndex = 12;
            this.btSuporte.Text = "Suporte";
            this.btSuporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuporte.UseVisualStyleBackColor = true;
            this.btSuporte.Click += new System.EventHandler(this.btSuporte_Click);
            // 
            // btFeedback
            // 
            this.btFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFeedback.FlatAppearance.BorderSize = 0;
            this.btFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFeedback.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFeedback.ForeColor = System.Drawing.SystemColors.Control;
            this.btFeedback.Location = new System.Drawing.Point(25, 401);
            this.btFeedback.Name = "btFeedback";
            this.btFeedback.Size = new System.Drawing.Size(177, 27);
            this.btFeedback.TabIndex = 11;
            this.btFeedback.Text = "Fornecer FeedBack";
            this.btFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFeedback.UseVisualStyleBackColor = true;
            this.btFeedback.Click += new System.EventHandler(this.btFeedback_Click);
            // 
            // btImoveis
            // 
            this.btImoveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImoveis.FlatAppearance.BorderSize = 0;
            this.btImoveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImoveis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImoveis.ForeColor = System.Drawing.SystemColors.Control;
            this.btImoveis.Location = new System.Drawing.Point(25, 327);
            this.btImoveis.Name = "btImoveis";
            this.btImoveis.Size = new System.Drawing.Size(177, 27);
            this.btImoveis.TabIndex = 10;
            this.btImoveis.Text = "Imóveis";
            this.btImoveis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImoveis.UseVisualStyleBackColor = true;
            this.btImoveis.Click += new System.EventHandler(this.btImoveis_Click);
            // 
            // btLocatarios
            // 
            this.btLocatarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocatarios.FlatAppearance.BorderSize = 0;
            this.btLocatarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocatarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocatarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btLocatarios.Location = new System.Drawing.Point(25, 294);
            this.btLocatarios.Name = "btLocatarios";
            this.btLocatarios.Size = new System.Drawing.Size(177, 27);
            this.btLocatarios.TabIndex = 9;
            this.btLocatarios.Text = "Locatários";
            this.btLocatarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLocatarios.UseVisualStyleBackColor = true;
            this.btLocatarios.Click += new System.EventHandler(this.btLocatarios_Click);
            // 
            // btClientes
            // 
            this.btClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClientes.FlatAppearance.BorderSize = 0;
            this.btClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btClientes.Location = new System.Drawing.Point(25, 263);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(177, 27);
            this.btClientes.TabIndex = 8;
            this.btClientes.Text = "Clientes";
            this.btClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClientes.UseVisualStyleBackColor = true;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "GERENCIAMENTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(12, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(12, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 1);
            this.panel3.TabIndex = 5;
            // 
            // btContratos
            // 
            this.btContratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContratos.FlatAppearance.BorderSize = 0;
            this.btContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContratos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContratos.ForeColor = System.Drawing.SystemColors.Control;
            this.btContratos.Location = new System.Drawing.Point(25, 176);
            this.btContratos.Name = "btContratos";
            this.btContratos.Size = new System.Drawing.Size(177, 27);
            this.btContratos.TabIndex = 4;
            this.btContratos.Text = "Contratos";
            this.btContratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btContratos.UseVisualStyleBackColor = true;
            this.btContratos.Click += new System.EventHandler(this.btContratos_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATIVIDADES";
            // 
            // lbNome
            // 
            this.lbNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNome.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNome.Location = new System.Drawing.Point(0, 87);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(220, 49);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome Funcionario";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.SystemColors.Control;
            this.BarraSuperior.Location = new System.Drawing.Point(220, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(789, 20);
            this.BarraSuperior.TabIndex = 1;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.panelDesktop.Controls.Add(this.lbData);
            this.panelDesktop.Controls.Add(this.lbHora);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Location = new System.Drawing.Point(220, 20);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(789, 546);
            this.panelDesktop.TabIndex = 2;
            // 
            // lbData
            // 
            this.lbData.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.Aqua;
            this.lbData.Location = new System.Drawing.Point(222, 359);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(373, 46);
            this.lbData.TabIndex = 3;
            this.lbData.Text = "Data";
            this.lbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHora
            // 
            this.lbHora.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lbHora.Location = new System.Drawing.Point(279, 284);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(260, 78);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Hora";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(322, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // HoraData
            // 
            this.HoraData.Enabled = true;
            this.HoraData.Tick += new System.EventHandler(this.HoraData_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1009, 566);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btContratos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSuporte;
        private System.Windows.Forms.Button btFeedback;
        private System.Windows.Forms.Button btImoveis;
        private System.Windows.Forms.Button btLocatarios;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer HoraData;
    }
}