﻿namespace CriptoHub.Forms
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btExportar = new System.Windows.Forms.PictureBox();
            this.tbNomeClientes = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbBuscarNomeClientes = new System.Windows.Forms.PictureBox();
            this.pbBuscarIdClientes = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdClientes = new System.Windows.Forms.TextBox();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarNomeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarIdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // btExportar
            // 
            this.btExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExportar.Image = ((System.Drawing.Image)(resources.GetObject("btExportar.Image")));
            this.btExportar.Location = new System.Drawing.Point(213, 45);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(101, 31);
            this.btExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btExportar.TabIndex = 2;
            this.btExportar.TabStop = false;
            // 
            // tbNomeClientes
            // 
            this.tbNomeClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNomeClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbNomeClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomeClientes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeClientes.Location = new System.Drawing.Point(93, 98);
            this.tbNomeClientes.Name = "tbNomeClientes";
            this.tbNomeClientes.Size = new System.Drawing.Size(177, 14);
            this.tbNomeClientes.TabIndex = 3;
            this.tbNomeClientes.Text = "Busque por dados na lista...";
            this.tbNomeClientes.Click += new System.EventHandler(this.tbNomeClientes_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(93, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 1);
            this.panel2.TabIndex = 4;
            // 
            // pbBuscarNomeClientes
            // 
            this.pbBuscarNomeClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBuscarNomeClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarNomeClientes.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarNomeClientes.Image")));
            this.pbBuscarNomeClientes.Location = new System.Drawing.Point(236, 89);
            this.pbBuscarNomeClientes.Name = "pbBuscarNomeClientes";
            this.pbBuscarNomeClientes.Size = new System.Drawing.Size(90, 31);
            this.pbBuscarNomeClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarNomeClientes.TabIndex = 5;
            this.pbBuscarNomeClientes.TabStop = false;
            this.pbBuscarNomeClientes.Click += new System.EventHandler(this.pbBuscarNomeClientes_Click);
            // 
            // pbBuscarIdClientes
            // 
            this.pbBuscarIdClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBuscarIdClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarIdClientes.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarIdClientes.Image")));
            this.pbBuscarIdClientes.Location = new System.Drawing.Point(611, 89);
            this.pbBuscarIdClientes.Name = "pbBuscarIdClientes";
            this.pbBuscarIdClientes.Size = new System.Drawing.Size(90, 31);
            this.pbBuscarIdClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarIdClientes.TabIndex = 8;
            this.pbBuscarIdClientes.TabStop = false;
            this.pbBuscarIdClientes.Click += new System.EventHandler(this.pbBuscarIdClientes_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(516, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 7;
            // 
            // tbIdClientes
            // 
            this.tbIdClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIdClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tbIdClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdClientes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdClientes.Location = new System.Drawing.Point(516, 98);
            this.tbIdClientes.Name = "tbIdClientes";
            this.tbIdClientes.Size = new System.Drawing.Size(177, 14);
            this.tbIdClientes.TabIndex = 6;
            this.tbIdClientes.Text = "Busque por Id...";
            this.tbIdClientes.Click += new System.EventHandler(this.tbIdClientes_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToOrderColumns = true;
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgClientes.ColumnHeadersHeight = 30;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgClientes.EnableHeadersVisualStyles = false;
            this.dgClientes.Location = new System.Drawing.Point(26, 137);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgClientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(597, 383);
            this.dgClientes.TabIndex = 9;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 546);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.pbBuscarIdClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbIdClientes);
            this.Controls.Add(this.pbBuscarNomeClientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbNomeClientes);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarNomeClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarIdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btExportar;
        private System.Windows.Forms.TextBox tbNomeClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbBuscarNomeClientes;
        private System.Windows.Forms.PictureBox pbBuscarIdClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIdClientes;
        private System.Windows.Forms.DataGridView dgClientes;
    }
}