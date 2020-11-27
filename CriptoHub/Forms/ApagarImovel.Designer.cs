namespace CriptoHub.Forms
{
    partial class ApagarImovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApagarImovel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbBuscarImoveis = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdImoveis = new System.Windows.Forms.TextBox();
            this.pbRetornar = new System.Windows.Forms.PictureBox();
            this.pbRemover = new System.Windows.Forms.PictureBox();
            this.dgImoveis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarImoveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetornar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBuscarImoveis
            // 
            this.pbBuscarImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBuscarImoveis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarImoveis.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarImoveis.Image")));
            this.pbBuscarImoveis.Location = new System.Drawing.Point(124, 70);
            this.pbBuscarImoveis.Name = "pbBuscarImoveis";
            this.pbBuscarImoveis.Size = new System.Drawing.Size(90, 31);
            this.pbBuscarImoveis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarImoveis.TabIndex = 90;
            this.pbBuscarImoveis.TabStop = false;
            this.pbBuscarImoveis.Click += new System.EventHandler(this.pbBuscarLocatarios_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(29, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 89;
            // 
            // tbIdImoveis
            // 
            this.tbIdImoveis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdImoveis.BackColor = System.Drawing.SystemColors.Control;
            this.tbIdImoveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdImoveis.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdImoveis.Location = new System.Drawing.Point(29, 79);
            this.tbIdImoveis.Name = "tbIdImoveis";
            this.tbIdImoveis.Size = new System.Drawing.Size(177, 14);
            this.tbIdImoveis.TabIndex = 88;
            this.tbIdImoveis.Text = "Busque por Id...";
            this.tbIdImoveis.Click += new System.EventHandler(this.tbIdImoveis_Click);
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
            this.pbRetornar.TabIndex = 87;
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
            this.pbRemover.TabIndex = 86;
            this.pbRemover.TabStop = false;
            this.pbRemover.Click += new System.EventHandler(this.pbRemover_Click);
            // 
            // dgImoveis
            // 
            this.dgImoveis.AllowUserToOrderColumns = true;
            this.dgImoveis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgImoveis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgImoveis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgImoveis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgImoveis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgImoveis.ColumnHeadersHeight = 30;
            this.dgImoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgImoveis.EnableHeadersVisualStyles = false;
            this.dgImoveis.Location = new System.Drawing.Point(31, 107);
            this.dgImoveis.Name = "dgImoveis";
            this.dgImoveis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgImoveis.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgImoveis.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgImoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgImoveis.Size = new System.Drawing.Size(442, 72);
            this.dgImoveis.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 84;
            this.label1.Text = "Apagar (Imóveis)";
            // 
            // ApagarImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 231);
            this.Controls.Add(this.pbBuscarImoveis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIdImoveis);
            this.Controls.Add(this.pbRetornar);
            this.Controls.Add(this.pbRemover);
            this.Controls.Add(this.dgImoveis);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApagarImovel";
            this.Text = "ApagarImovel";
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarImoveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetornar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgImoveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBuscarImoveis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIdImoveis;
        private System.Windows.Forms.PictureBox pbRetornar;
        private System.Windows.Forms.PictureBox pbRemover;
        private System.Windows.Forms.DataGridView dgImoveis;
        private System.Windows.Forms.Label label1;
    }
}