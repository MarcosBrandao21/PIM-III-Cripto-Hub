namespace CriptoHub.Forms
{
    partial class Imoveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imoveis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbRemover = new System.Windows.Forms.PictureBox();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.dgImoveis = new System.Windows.Forms.DataGridView();
            this.pbBuscarIdImoveis = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdImoveis = new System.Windows.Forms.TextBox();
            this.pbBuscarCEPImoveis = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDadosImoveis = new System.Windows.Forms.TextBox();
            this.btExportar = new System.Windows.Forms.PictureBox();
            this.lbImoveis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImoveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarIdImoveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCEPImoveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRemover
            // 
            this.pbRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemover.Image = ((System.Drawing.Image)(resources.GetObject("pbRemover.Image")));
            this.pbRemover.Location = new System.Drawing.Point(672, 478);
            this.pbRemover.Name = "pbRemover";
            this.pbRemover.Size = new System.Drawing.Size(90, 31);
            this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemover.TabIndex = 36;
            this.pbRemover.TabStop = false;
            this.pbRemover.Click += new System.EventHandler(this.pbRemover_Click);
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("pbAdicionar.Image")));
            this.pbAdicionar.Location = new System.Drawing.Point(672, 402);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(90, 31);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdicionar.TabIndex = 35;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.pbAdicionar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(672, 365);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(90, 31);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEditar.TabIndex = 34;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // dgImoveis
            // 
            this.dgImoveis.AllowUserToOrderColumns = true;
            this.dgImoveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgImoveis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgImoveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgImoveis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgImoveis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgImoveis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgImoveis.ColumnHeadersHeight = 30;
            this.dgImoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgImoveis.EnableHeadersVisualStyles = false;
            this.dgImoveis.Location = new System.Drawing.Point(26, 128);
            this.dgImoveis.Name = "dgImoveis";
            this.dgImoveis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgImoveis.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgImoveis.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgImoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgImoveis.Size = new System.Drawing.Size(640, 383);
            this.dgImoveis.TabIndex = 33;
            // 
            // pbBuscarIdImoveis
            // 
            this.pbBuscarIdImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBuscarIdImoveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarIdImoveis.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarIdImoveis.Image")));
            this.pbBuscarIdImoveis.Location = new System.Drawing.Point(611, 80);
            this.pbBuscarIdImoveis.Name = "pbBuscarIdImoveis";
            this.pbBuscarIdImoveis.Size = new System.Drawing.Size(90, 31);
            this.pbBuscarIdImoveis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarIdImoveis.TabIndex = 32;
            this.pbBuscarIdImoveis.TabStop = false;
            this.pbBuscarIdImoveis.Click += new System.EventHandler(this.pbBuscarIdImoveis_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(516, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 31;
            // 
            // tbIdImoveis
            // 
            this.tbIdImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdImoveis.BackColor = System.Drawing.SystemColors.Control;
            this.tbIdImoveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdImoveis.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdImoveis.Location = new System.Drawing.Point(516, 89);
            this.tbIdImoveis.Name = "tbIdImoveis";
            this.tbIdImoveis.Size = new System.Drawing.Size(177, 14);
            this.tbIdImoveis.TabIndex = 30;
            this.tbIdImoveis.Text = "Busque por Id...";
            this.tbIdImoveis.Click += new System.EventHandler(this.tbIdImoveis_Click);
            // 
            // pbBuscarCEPImoveis
            // 
            this.pbBuscarCEPImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBuscarCEPImoveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarCEPImoveis.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarCEPImoveis.Image")));
            this.pbBuscarCEPImoveis.Location = new System.Drawing.Point(236, 80);
            this.pbBuscarCEPImoveis.Name = "pbBuscarCEPImoveis";
            this.pbBuscarCEPImoveis.Size = new System.Drawing.Size(90, 31);
            this.pbBuscarCEPImoveis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarCEPImoveis.TabIndex = 29;
            this.pbBuscarCEPImoveis.TabStop = false;
            this.pbBuscarCEPImoveis.Click += new System.EventHandler(this.pbBuscarCEPImoveis_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(93, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 1);
            this.panel2.TabIndex = 28;
            // 
            // tbDadosImoveis
            // 
            this.tbDadosImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDadosImoveis.BackColor = System.Drawing.SystemColors.Control;
            this.tbDadosImoveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDadosImoveis.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDadosImoveis.Location = new System.Drawing.Point(93, 89);
            this.tbDadosImoveis.Name = "tbDadosImoveis";
            this.tbDadosImoveis.Size = new System.Drawing.Size(177, 14);
            this.tbDadosImoveis.TabIndex = 27;
            this.tbDadosImoveis.Text = "Busque por CEP na lista...";
            this.tbDadosImoveis.Click += new System.EventHandler(this.tbDadosImoveis_Click);
            // 
            // btExportar
            // 
            this.btExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExportar.Image = ((System.Drawing.Image)(resources.GetObject("btExportar.Image")));
            this.btExportar.Location = new System.Drawing.Point(213, 36);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(101, 31);
            this.btExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExportar.TabIndex = 26;
            this.btExportar.TabStop = false;
            // 
            // lbImoveis
            // 
            this.lbImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbImoveis.AutoSize = true;
            this.lbImoveis.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImoveis.Location = new System.Drawing.Point(89, 36);
            this.lbImoveis.Name = "lbImoveis";
            this.lbImoveis.Size = new System.Drawing.Size(105, 36);
            this.lbImoveis.TabIndex = 25;
            this.lbImoveis.Text = "Imóveis";
            // 
            // Imoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 546);
            this.Controls.Add(this.pbRemover);
            this.Controls.Add(this.pbAdicionar);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.dgImoveis);
            this.Controls.Add(this.pbBuscarIdImoveis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIdImoveis);
            this.Controls.Add(this.pbBuscarCEPImoveis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbDadosImoveis);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.lbImoveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imoveis";
            this.Text = "Imoveis";
            this.Load += new System.EventHandler(this.Imoveis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImoveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarIdImoveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCEPImoveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRemover;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.DataGridView dgImoveis;
        private System.Windows.Forms.PictureBox pbBuscarIdImoveis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIdImoveis;
        private System.Windows.Forms.PictureBox pbBuscarCEPImoveis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDadosImoveis;
        private System.Windows.Forms.PictureBox btExportar;
        private System.Windows.Forms.Label lbImoveis;
    }
}