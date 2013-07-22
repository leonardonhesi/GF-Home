namespace OFX.Formularios
{
    partial class frmConcilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConcilia));
            this.dtgConcilia = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Natureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOkConcilia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovimento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConcilia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConcilia
            // 
            this.dtgConcilia.AllowUserToAddRows = false;
            this.dtgConcilia.AllowUserToDeleteRows = false;
            this.dtgConcilia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgConcilia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.numero,
            this.Relacao,
            this.Relação,
            this.Parcela,
            this.Valor,
            this.Vencimento,
            this.Natureza,
            this.Descrição});
            this.dtgConcilia.Location = new System.Drawing.Point(6, 19);
            this.dtgConcilia.MultiSelect = false;
            this.dtgConcilia.Name = "dtgConcilia";
            this.dtgConcilia.RowHeadersWidth = 11;
            this.dtgConcilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConcilia.Size = new System.Drawing.Size(879, 166);
            this.dtgConcilia.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.Width = 69;
            // 
            // Relacao
            // 
            this.Relacao.DataPropertyName = "nome";
            this.Relacao.HeaderText = "Nome";
            this.Relacao.Name = "Relacao";
            this.Relacao.Width = 60;
            // 
            // Relação
            // 
            this.Relação.DataPropertyName = "tipo";
            this.Relação.HeaderText = "Relação";
            this.Relação.Name = "Relação";
            this.Relação.Width = 72;
            // 
            // Parcela
            // 
            this.Parcela.DataPropertyName = "parcela";
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.Width = 68;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 56;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "vencimento";
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.Width = 88;
            // 
            // Natureza
            // 
            this.Natureza.DataPropertyName = "natureza";
            this.Natureza.HeaderText = "Natureza";
            this.Natureza.Name = "Natureza";
            this.Natureza.Width = 75;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 80;
            // 
            // btnOkConcilia
            // 
            this.btnOkConcilia.Location = new System.Drawing.Point(800, 309);
            this.btnOkConcilia.Name = "btnOkConcilia";
            this.btnOkConcilia.Size = new System.Drawing.Size(97, 30);
            this.btnOkConcilia.TabIndex = 2;
            this.btnOkConcilia.Text = "Baixar";
            this.btnOkConcilia.UseVisualStyleBackColor = true;
            this.btnOkConcilia.Click += new System.EventHandler(this.btnOkConcilia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMovimento);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimento";
            // 
            // lblValor
            // 
            this.lblValor.Enabled = false;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(706, 41);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(129, 18);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Enabled = false;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(313, 41);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(334, 18);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // lblMovimento
            // 
            this.lblMovimento.AutoSize = true;
            this.lblMovimento.Enabled = false;
            this.lblMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimento.Location = new System.Drawing.Point(85, 41);
            this.lblMovimento.Name = "lblMovimento";
            this.lblMovimento.Size = new System.Drawing.Size(57, 20);
            this.lblMovimento.TabIndex = 1;
            this.lblMovimento.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgConcilia);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 196);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Título";
            // 
            // frmConcilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOkConcilia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConcilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Títulos X Movimentos";
            this.Load += new System.EventHandler(this.frmConcilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConcilia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConcilia;
        private System.Windows.Forms.Button btnOkConcilia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMovimento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Natureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
    }
}