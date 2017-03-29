namespace Views
{
    partial class frmListagemCarros
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
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListaCarros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarros
            // 
            this.dgvCarros.AllowUserToAddRows = false;
            this.dgvCarros.AllowUserToDeleteRows = false;
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Ano});
            this.dgvCarros.Location = new System.Drawing.Point(12, 47);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.ReadOnly = true;
            this.dgvCarros.Size = new System.Drawing.Size(423, 212);
            this.dgvCarros.TabIndex = 1;
            this.dgvCarros.SelectionChanged += new System.EventHandler(this.dgvCarros_SelectionChanged);
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // lblListaCarros
            // 
            this.lblListaCarros.AutoSize = true;
            this.lblListaCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCarros.Location = new System.Drawing.Point(12, 19);
            this.lblListaCarros.Name = "lblListaCarros";
            this.lblListaCarros.Size = new System.Drawing.Size(261, 25);
            this.lblListaCarros.TabIndex = 2;
            this.lblListaCarros.Text = "Lista de Carros Cadastrados";
            // 
            // frmListagemCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 284);
            this.Controls.Add(this.lblListaCarros);
            this.Controls.Add(this.dgvCarros);
            this.Name = "frmListagemCarros";
            this.Text = "frmListagemCarros";
            this.Load += new System.EventHandler(this.frmListagemCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.Label lblListaCarros;
    }
}