namespace CriptoHub.Forms
{
    partial class ApagarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApagarClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.pbRemover = new System.Windows.Forms.PictureBox();
            this.pbRetornar = new System.Windows.Forms.PictureBox();
            this.pbBuscarIdClientes = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdClientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetornar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarIdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 36);
            this.label1.TabIndex = 45;
            this.label1.Text = "Apagar (Clientes)";
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToOrderColumns = true;
            this.dgClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClientes.ColumnHeadersHeight = 30;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgClientes.EnableHeadersVisualStyles = false;
            this.dgClientes.Location = new System.Drawing.Point(24, 111);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgClientes.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(442, 72);
            this.dgClientes.TabIndex = 52;
            // 
            // pbRemover
            // 
            this.pbRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemover.Image = ((System.Drawing.Image)(resources.GetObject("pbRemover.Image")));
            this.pbRemover.Location = new System.Drawing.Point(376, 189);
            this.pbRemover.Name = "pbRemover";
            this.pbRemover.Size = new System.Drawing.Size(90, 31);
            this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemover.TabIndex = 53;
            this.pbRemover.TabStop = false;
            this.pbRemover.Click += new System.EventHandler(this.pbRemover_Click);
            // 
            // pbRetornar
            // 
            this.pbRetornar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRetornar.Image = ((System.Drawing.Image)(resources.GetObject("pbRetornar.Image")));
            this.pbRetornar.Location = new System.Drawing.Point(257, 188);
            this.pbRetornar.Name = "pbRetornar";
            this.pbRetornar.Size = new System.Drawing.Size(90, 31);
            this.pbRetornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRetornar.TabIndex = 73;
            this.pbRetornar.TabStop = false;
            this.pbRetornar.Click += new System.EventHandler(this.pbRetornar_Click);
            // 
            // pbBuscarIdClientes
            // 
            this.pbBuscarIdClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBuscarIdClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarIdClientes.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarIdClientes.Image")));
            this.pbBuscarIdClientes.Location = new System.Drawing.Point(117, 74);
            this.pbBuscarIdClientes.Name = "pbBuscarIdClientes";
            this.pbBuscarIdClientes.Size = new System.Drawing.Size(90, 31);
            this.pbBuscarIdClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarIdClientes.TabIndex = 76;
            this.pbBuscarIdClientes.TabStop = false;
            this.pbBuscarIdClientes.Click += new System.EventHandler(this.pbBuscarIdClientes_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(22, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 75;
            // 
            // tbIdClientes
            // 
            this.tbIdClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbIdClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdClientes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdClientes.Location = new System.Drawing.Point(22, 83);
            this.tbIdClientes.Name = "tbIdClientes";
            this.tbIdClientes.Size = new System.Drawing.Size(177, 14);
            this.tbIdClientes.TabIndex = 74;
            this.tbIdClientes.Text = "Busque por Id...";
            this.tbIdClientes.Click += new System.EventHandler(this.tbIdClientes_Click);
            // 
            // ApagarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 231);
            this.Controls.Add(this.pbBuscarIdClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIdClientes);
            this.Controls.Add(this.pbRetornar);
            this.Controls.Add(this.pbRemover);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApagarClientes";
            this.Text = "ApagarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetornar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarIdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.PictureBox pbRemover;
        private System.Windows.Forms.PictureBox pbRetornar;
        private System.Windows.Forms.PictureBox pbBuscarIdClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIdClientes;
    }
}