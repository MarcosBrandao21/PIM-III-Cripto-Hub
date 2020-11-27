namespace CriptoHub.Forms
{
    partial class ApagarLocatarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApagarLocatarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbBuscarLocatarios = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdClientes = new System.Windows.Forms.TextBox();
            this.pbRetornar = new System.Windows.Forms.PictureBox();
            this.pbRemover = new System.Windows.Forms.PictureBox();
            this.dgLocatarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarLocatarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetornar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocatarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBuscarLocatarios
            // 
            this.pbBuscarLocatarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBuscarLocatarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarLocatarios.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarLocatarios.Image")));
            this.pbBuscarLocatarios.Location = new System.Drawing.Point(124, 70);
            this.pbBuscarLocatarios.Name = "pbBuscarLocatarios";
            this.pbBuscarLocatarios.Size = new System.Drawing.Size(90, 31);
            this.pbBuscarLocatarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarLocatarios.TabIndex = 83;
            this.pbBuscarLocatarios.TabStop = false;
            this.pbBuscarLocatarios.Click += new System.EventHandler(this.pbBuscarLocatarios_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(29, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 82;
            // 
            // tbIdClientes
            // 
            this.tbIdClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbIdClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdClientes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdClientes.Location = new System.Drawing.Point(29, 79);
            this.tbIdClientes.Name = "tbIdClientes";
            this.tbIdClientes.Size = new System.Drawing.Size(177, 14);
            this.tbIdClientes.TabIndex = 81;
            this.tbIdClientes.Text = "Busque por Id...";
            this.tbIdClientes.Click += new System.EventHandler(this.tbIdClientes_Click);
            // 
            // pbRetornar
            // 
            this.pbRetornar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRetornar.Image = ((System.Drawing.Image)(resources.GetObject("pbRetornar.Image")));
            this.pbRetornar.Location = new System.Drawing.Point(264, 184);
            this.pbRetornar.Name = "pbRetornar";
            this.pbRetornar.Size = new System.Drawing.Size(90, 31);
            this.pbRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRetornar.TabIndex = 80;
            this.pbRetornar.TabStop = false;
            this.pbRetornar.Click += new System.EventHandler(this.pbRetornar_Click);
            // 
            // pbRemover
            // 
            this.pbRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemover.Image = ((System.Drawing.Image)(resources.GetObject("pbRemover.Image")));
            this.pbRemover.Location = new System.Drawing.Point(383, 185);
            this.pbRemover.Name = "pbRemover";
            this.pbRemover.Size = new System.Drawing.Size(90, 31);
            this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemover.TabIndex = 79;
            this.pbRemover.TabStop = false;
            this.pbRemover.Click += new System.EventHandler(this.pbRemover_Click);
            // 
            // dgLocatarios
            // 
            this.dgLocatarios.AllowUserToOrderColumns = true;
            this.dgLocatarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgLocatarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLocatarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgLocatarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLocatarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLocatarios.ColumnHeadersHeight = 30;
            this.dgLocatarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLocatarios.EnableHeadersVisualStyles = false;
            this.dgLocatarios.Location = new System.Drawing.Point(31, 107);
            this.dgLocatarios.Name = "dgLocatarios";
            this.dgLocatarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgLocatarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgLocatarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLocatarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLocatarios.Size = new System.Drawing.Size(442, 72);
            this.dgLocatarios.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 77;
            this.label1.Text = "Apagar (Locatarios)";
            // 
            // ApagarLocatarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 231);
            this.Controls.Add(this.pbBuscarLocatarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIdClientes);
            this.Controls.Add(this.pbRetornar);
            this.Controls.Add(this.pbRemover);
            this.Controls.Add(this.dgLocatarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApagarLocatarios";
            this.Text = "ApagarLocatarios";
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarLocatarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetornar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocatarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBuscarLocatarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIdClientes;
        private System.Windows.Forms.PictureBox pbRetornar;
        private System.Windows.Forms.PictureBox pbRemover;
        private System.Windows.Forms.DataGridView dgLocatarios;
        private System.Windows.Forms.Label label1;
    }
}