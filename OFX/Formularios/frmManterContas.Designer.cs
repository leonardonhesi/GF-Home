namespace OFX.Formularios
{
    partial class frmManterContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterContas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirBanco = new System.Windows.Forms.Button();
            this.btnEditarBanco = new System.Windows.Forms.Button();
            this.dtgBanco = new System.Windows.Forms.DataGridView();
            this.NumeroBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriçãoBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluirAgencia = new System.Windows.Forms.Button();
            this.btnEditarAgencia = new System.Windows.Forms.Button();
            this.dtgAgencia = new System.Windows.Forms.DataGridView();
            this.NumeroAgência = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancoAgência = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancoDescrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExcluirConta = new System.Windows.Forms.Button();
            this.btnIncluirConta = new System.Windows.Forms.Button();
            this.dtgConta = new System.Windows.Forms.DataGridView();
            this.NumeroConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaAgência = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaDescrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBanco)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgencia)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirBanco);
            this.groupBox1.Controls.Add(this.btnEditarBanco);
            this.groupBox1.Controls.Add(this.dtgBanco);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bancos";
            // 
            // btnExcluirBanco
            // 
            this.btnExcluirBanco.Location = new System.Drawing.Point(143, 23);
            this.btnExcluirBanco.Name = "btnExcluirBanco";
            this.btnExcluirBanco.Size = new System.Drawing.Size(56, 23);
            this.btnExcluirBanco.TabIndex = 1;
            this.btnExcluirBanco.Text = "Excluir";
            this.btnExcluirBanco.UseVisualStyleBackColor = true;
            this.btnExcluirBanco.Click += new System.EventHandler(this.btnExcluirBanco_Click);
            // 
            // btnEditarBanco
            // 
            this.btnEditarBanco.Location = new System.Drawing.Point(43, 24);
            this.btnEditarBanco.Name = "btnEditarBanco";
            this.btnEditarBanco.Size = new System.Drawing.Size(56, 23);
            this.btnEditarBanco.TabIndex = 1;
            this.btnEditarBanco.Text = "Editar";
            this.btnEditarBanco.UseVisualStyleBackColor = true;
            this.btnEditarBanco.Click += new System.EventHandler(this.btnEditarBanco_Click);
            // 
            // dtgBanco
            // 
            this.dtgBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroBanco,
            this.DescriçãoBanco});
            this.dtgBanco.Location = new System.Drawing.Point(8, 71);
            this.dtgBanco.MultiSelect = false;
            this.dtgBanco.Name = "dtgBanco";
            this.dtgBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBanco.Size = new System.Drawing.Size(244, 328);
            this.dtgBanco.TabIndex = 0;
            // 
            // NumeroBanco
            // 
            this.NumeroBanco.DataPropertyName = "numero";
            this.NumeroBanco.HeaderText = "NumeroBanco";
            this.NumeroBanco.Name = "NumeroBanco";
            // 
            // DescriçãoBanco
            // 
            this.DescriçãoBanco.DataPropertyName = "descricao";
            this.DescriçãoBanco.HeaderText = "DescriçãoBanco";
            this.DescriçãoBanco.Name = "DescriçãoBanco";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluirAgencia);
            this.groupBox2.Controls.Add(this.btnEditarAgencia);
            this.groupBox2.Controls.Add(this.dtgAgencia);
            this.groupBox2.Location = new System.Drawing.Point(280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 405);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agências";
            // 
            // btnExcluirAgencia
            // 
            this.btnExcluirAgencia.Location = new System.Drawing.Point(197, 24);
            this.btnExcluirAgencia.Name = "btnExcluirAgencia";
            this.btnExcluirAgencia.Size = new System.Drawing.Size(56, 23);
            this.btnExcluirAgencia.TabIndex = 4;
            this.btnExcluirAgencia.Text = "Excluir";
            this.btnExcluirAgencia.UseVisualStyleBackColor = true;
            this.btnExcluirAgencia.Click += new System.EventHandler(this.btnExcluirAgencia_Click);
            // 
            // btnEditarAgencia
            // 
            this.btnEditarAgencia.Location = new System.Drawing.Point(74, 24);
            this.btnEditarAgencia.Name = "btnEditarAgencia";
            this.btnEditarAgencia.Size = new System.Drawing.Size(56, 23);
            this.btnEditarAgencia.TabIndex = 3;
            this.btnEditarAgencia.Text = "Editar";
            this.btnEditarAgencia.UseVisualStyleBackColor = true;
            this.btnEditarAgencia.Click += new System.EventHandler(this.btnEditarAgencia_Click);
            // 
            // dtgAgencia
            // 
            this.dtgAgencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroAgência,
            this.BancoAgência,
            this.BancoDescrição});
            this.dtgAgencia.Location = new System.Drawing.Point(5, 71);
            this.dtgAgencia.MultiSelect = false;
            this.dtgAgencia.Name = "dtgAgencia";
            this.dtgAgencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgencia.Size = new System.Drawing.Size(351, 328);
            this.dtgAgencia.TabIndex = 0;
            // 
            // NumeroAgência
            // 
            this.NumeroAgência.DataPropertyName = "numero";
            this.NumeroAgência.HeaderText = "NumeroAgência";
            this.NumeroAgência.Name = "NumeroAgência";
            // 
            // BancoAgência
            // 
            this.BancoAgência.DataPropertyName = "banco";
            this.BancoAgência.HeaderText = "BancoAgência";
            this.BancoAgência.Name = "BancoAgência";
            // 
            // BancoDescrição
            // 
            this.BancoDescrição.DataPropertyName = "descricao";
            this.BancoDescrição.HeaderText = "BancoDescrição";
            this.BancoDescrição.Name = "BancoDescrição";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExcluirConta);
            this.groupBox3.Controls.Add(this.btnIncluirConta);
            this.groupBox3.Controls.Add(this.dtgConta);
            this.groupBox3.Location = new System.Drawing.Point(643, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 405);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contas";
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.Location = new System.Drawing.Point(333, 23);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.Size = new System.Drawing.Size(56, 23);
            this.btnExcluirConta.TabIndex = 4;
            this.btnExcluirConta.Text = "Excluir";
            this.btnExcluirConta.UseVisualStyleBackColor = true;
            this.btnExcluirConta.Click += new System.EventHandler(this.btnExcluirConta_Click);
            // 
            // btnIncluirConta
            // 
            this.btnIncluirConta.Location = new System.Drawing.Point(227, 24);
            this.btnIncluirConta.Name = "btnIncluirConta";
            this.btnIncluirConta.Size = new System.Drawing.Size(56, 23);
            this.btnIncluirConta.TabIndex = 2;
            this.btnIncluirConta.Text = "Incluir";
            this.btnIncluirConta.UseVisualStyleBackColor = true;
            this.btnIncluirConta.Click += new System.EventHandler(this.btnIncluirConta_Click);
            // 
            // dtgConta
            // 
            this.dtgConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroConta,
            this.ContaAgência,
            this.ContaDescrição,
            this.ContaSaldo,
            this.DataCriação});
            this.dtgConta.Location = new System.Drawing.Point(11, 71);
            this.dtgConta.MultiSelect = false;
            this.dtgConta.Name = "dtgConta";
            this.dtgConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConta.Size = new System.Drawing.Size(604, 328);
            this.dtgConta.TabIndex = 0;
            // 
            // NumeroConta
            // 
            this.NumeroConta.DataPropertyName = "numero";
            this.NumeroConta.HeaderText = "NumeroConta";
            this.NumeroConta.Name = "NumeroConta";
            // 
            // ContaAgência
            // 
            this.ContaAgência.DataPropertyName = "agencia";
            this.ContaAgência.HeaderText = "AgênciaConta";
            this.ContaAgência.Name = "ContaAgência";
            // 
            // ContaDescrição
            // 
            this.ContaDescrição.DataPropertyName = "descricao";
            this.ContaDescrição.HeaderText = "DescriçãoConta";
            this.ContaDescrição.Name = "ContaDescrição";
            // 
            // ContaSaldo
            // 
            this.ContaSaldo.DataPropertyName = "saldo";
            this.ContaSaldo.HeaderText = "Saldo Inicial";
            this.ContaSaldo.Name = "ContaSaldo";
            // 
            // DataCriação
            // 
            this.DataCriação.DataPropertyName = "data_criacao";
            this.DataCriação.HeaderText = "DataCriação";
            this.DataCriação.Name = "DataCriação";
            // 
            // frmManterContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 429);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManterContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Contas";
            this.Load += new System.EventHandler(this.frmManterContas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBanco)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgencia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgBanco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgAgencia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriçãoBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroAgência;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoAgência;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoDescrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaAgência;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaDescrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriação;
        private System.Windows.Forms.Button btnExcluirBanco;
        private System.Windows.Forms.Button btnEditarBanco;
        private System.Windows.Forms.Button btnExcluirAgencia;
        private System.Windows.Forms.Button btnEditarAgencia;
        private System.Windows.Forms.Button btnExcluirConta;
        private System.Windows.Forms.Button btnIncluirConta;
    }
}