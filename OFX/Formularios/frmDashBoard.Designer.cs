namespace OFX.Formularios
{
    partial class frmDashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgAtrasados = new System.Windows.Forms.DataGridView();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Natureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgSaldoContas = new System.Windows.Forms.DataGridView();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblProximo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgRecebimentos = new System.Windows.Forms.DataGridView();
            this.Vcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Receber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPagamentos = new System.Windows.Forms.DataGridView();
            this.Dt_Vcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtrasados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSaldoContas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecebimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgAtrasados);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Títulos Atrasados";
            // 
            // dtgAtrasados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dtgAtrasados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAtrasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAtrasados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vencimento,
            this.Relação,
            this.Valor,
            this.Natureza,
            this.Descrição});
            this.dtgAtrasados.Location = new System.Drawing.Point(6, 19);
            this.dtgAtrasados.MultiSelect = false;
            this.dtgAtrasados.Name = "dtgAtrasados";
            this.dtgAtrasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAtrasados.Size = new System.Drawing.Size(597, 178);
            this.dtgAtrasados.TabIndex = 0;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "vencimento";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            // 
            // Relação
            // 
            this.Relação.DataPropertyName = "relacao";
            this.Relação.HeaderText = "Relação";
            this.Relação.Name = "Relação";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Natureza
            // 
            this.Natureza.DataPropertyName = "natureza";
            this.Natureza.HeaderText = "Natureza";
            this.Natureza.Name = "Natureza";
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgSaldoContas);
            this.groupBox2.Location = new System.Drawing.Point(643, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo das Contas";
            // 
            // dtgSaldoContas
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.dtgSaldoContas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSaldoContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSaldoContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Banco,
            this.Agencia,
            this.Conta,
            this.Observação,
            this.Saldo});
            this.dtgSaldoContas.Location = new System.Drawing.Point(12, 19);
            this.dtgSaldoContas.MultiSelect = false;
            this.dtgSaldoContas.Name = "dtgSaldoContas";
            this.dtgSaldoContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSaldoContas.Size = new System.Drawing.Size(520, 178);
            this.dtgSaldoContas.TabIndex = 0;
            // 
            // Banco
            // 
            this.Banco.DataPropertyName = "banco";
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            // 
            // Agencia
            // 
            this.Agencia.DataPropertyName = "agencia";
            this.Agencia.HeaderText = "Agencia";
            this.Agencia.Name = "Agencia";
            // 
            // Conta
            // 
            this.Conta.DataPropertyName = "numero";
            this.Conta.HeaderText = "Conta";
            this.Conta.Name = "Conta";
            // 
            // Observação
            // 
            this.Observação.DataPropertyName = "descricao";
            this.Observação.HeaderText = "Observação";
            this.Observação.Name = "Observação";
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAno);
            this.groupBox3.Controls.Add(this.lblProximo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(754, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldo Total Dísponivel";
            // 
            // lblAno
            // 
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(224, 132);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(130, 13);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "label6";
            // 
            // lblProximo
            // 
            this.lblProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximo.Location = new System.Drawing.Point(224, 54);
            this.lblProximo.Name = "lblProximo";
            this.lblProximo.Size = new System.Drawing.Size(118, 13);
            this.lblProximo.TabIndex = 3;
            this.lblProximo.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Disponivel Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Disponivel Mês:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dtgRecebimentos);
            this.groupBox4.Controls.Add(this.dtgPagamentos);
            this.groupBox4.Location = new System.Drawing.Point(18, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(716, 215);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Próximos Vencimentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recebimentos (Proximos 5 dias)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagamentos (Proximos 5 dias)";
            // 
            // dtgRecebimentos
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.dtgRecebimentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRecebimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecebimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vcto,
            this.Cliente,
            this.Valor_Receber});
            this.dtgRecebimentos.Location = new System.Drawing.Point(361, 35);
            this.dtgRecebimentos.MultiSelect = false;
            this.dtgRecebimentos.Name = "dtgRecebimentos";
            this.dtgRecebimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecebimentos.Size = new System.Drawing.Size(349, 158);
            this.dtgRecebimentos.TabIndex = 0;
            // 
            // Vcto
            // 
            this.Vcto.DataPropertyName = "vencimento";
            this.Vcto.HeaderText = "Vcto";
            this.Vcto.Name = "Vcto";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "relacao";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Valor_Receber
            // 
            this.Valor_Receber.DataPropertyName = "valor";
            this.Valor_Receber.HeaderText = "Valor_Receber";
            this.Valor_Receber.Name = "Valor_Receber";
            // 
            // dtgPagamentos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dtgPagamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dt_Vcto,
            this.Fornecedor,
            this.Valor_Titulo});
            this.dtgPagamentos.Location = new System.Drawing.Point(6, 35);
            this.dtgPagamentos.MultiSelect = false;
            this.dtgPagamentos.Name = "dtgPagamentos";
            this.dtgPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPagamentos.Size = new System.Drawing.Size(349, 158);
            this.dtgPagamentos.TabIndex = 0;
            // 
            // Dt_Vcto
            // 
            this.Dt_Vcto.DataPropertyName = "vencimento";
            this.Dt_Vcto.HeaderText = "Dt_Vcto";
            this.Dt_Vcto.Name = "Dt_Vcto";
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "relacao";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // Valor_Titulo
            // 
            this.Valor_Titulo.DataPropertyName = "valor";
            this.Valor_Titulo.HeaderText = "Valor_Titulo";
            this.Valor_Titulo.Name = "Valor_Titulo";
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Location = new System.Drawing.Point(1106, 458);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(75, 23);
            this.btnAtualiza.TabIndex = 4;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 482);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtrasados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSaldoContas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecebimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgAtrasados;
        private System.Windows.Forms.DataGridView dtgSaldoContas;
        private System.Windows.Forms.DataGridView dtgPagamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgRecebimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Natureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Vcto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vcto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Receber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblProximo;
    }
}