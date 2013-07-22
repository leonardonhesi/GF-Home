namespace OFX.Formularios.Cadastros
{
    partial class frmCadConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadConta));
            this.grpContaBanco = new System.Windows.Forms.GroupBox();
            this.btnNovoBanco = new System.Windows.Forms.Button();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.cmbNumeroBanco = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpContaAgencia = new System.Windows.Forms.GroupBox();
            this.btnNovaAgencia = new System.Windows.Forms.Button();
            this.txtAgenciaDescricao = new System.Windows.Forms.TextBox();
            this.cmbAgenciaNumero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpConta = new System.Windows.Forms.GroupBox();
            this.txtSaldoConta = new System.Windows.Forms.TextBox();
            this.txtDescricaoConta = new System.Windows.Forms.TextBox();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpContaBanco.SuspendLayout();
            this.grpContaAgencia.SuspendLayout();
            this.grpConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpContaBanco
            // 
            this.grpContaBanco.Controls.Add(this.btnNovoBanco);
            this.grpContaBanco.Controls.Add(this.txtNomeBanco);
            this.grpContaBanco.Controls.Add(this.cmbNumeroBanco);
            this.grpContaBanco.Controls.Add(this.label7);
            this.grpContaBanco.Controls.Add(this.label1);
            this.grpContaBanco.Location = new System.Drawing.Point(27, 29);
            this.grpContaBanco.Name = "grpContaBanco";
            this.grpContaBanco.Size = new System.Drawing.Size(403, 112);
            this.grpContaBanco.TabIndex = 0;
            this.grpContaBanco.TabStop = false;
            this.grpContaBanco.Text = "Banco:";
            // 
            // btnNovoBanco
            // 
            this.btnNovoBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoBanco.Location = new System.Drawing.Point(313, 83);
            this.btnNovoBanco.Name = "btnNovoBanco";
            this.btnNovoBanco.Size = new System.Drawing.Size(54, 23);
            this.btnNovoBanco.TabIndex = 10;
            this.btnNovoBanco.Text = "Novo...";
            this.btnNovoBanco.UseVisualStyleBackColor = true;
            this.btnNovoBanco.Click += new System.EventHandler(this.btnNovoBanco_Click);
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(91, 53);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(168, 20);
            this.txtNomeBanco.TabIndex = 2;
            // 
            // cmbNumeroBanco
            // 
            this.cmbNumeroBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNumeroBanco.FormattingEnabled = true;
            this.cmbNumeroBanco.Location = new System.Drawing.Point(91, 12);
            this.cmbNumeroBanco.Name = "cmbNumeroBanco";
            this.cmbNumeroBanco.Size = new System.Drawing.Size(168, 21);
            this.cmbNumeroBanco.TabIndex = 1;
            this.cmbNumeroBanco.SelectionChangeCommitted += new System.EventHandler(this.cmbNumeroBanco_SelectionChangeCommitted);
            this.cmbNumeroBanco.Leave += new System.EventHandler(this.cmbNumeroBanco_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // grpContaAgencia
            // 
            this.grpContaAgencia.Controls.Add(this.btnNovaAgencia);
            this.grpContaAgencia.Controls.Add(this.txtAgenciaDescricao);
            this.grpContaAgencia.Controls.Add(this.cmbAgenciaNumero);
            this.grpContaAgencia.Controls.Add(this.label3);
            this.grpContaAgencia.Controls.Add(this.label2);
            this.grpContaAgencia.Location = new System.Drawing.Point(27, 157);
            this.grpContaAgencia.Name = "grpContaAgencia";
            this.grpContaAgencia.Size = new System.Drawing.Size(403, 118);
            this.grpContaAgencia.TabIndex = 1;
            this.grpContaAgencia.TabStop = false;
            this.grpContaAgencia.Text = "Agência:";
            // 
            // btnNovaAgencia
            // 
            this.btnNovaAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaAgencia.Location = new System.Drawing.Point(313, 89);
            this.btnNovaAgencia.Name = "btnNovaAgencia";
            this.btnNovaAgencia.Size = new System.Drawing.Size(54, 23);
            this.btnNovaAgencia.TabIndex = 11;
            this.btnNovaAgencia.Text = "Novo...";
            this.btnNovaAgencia.UseVisualStyleBackColor = true;
            this.btnNovaAgencia.Click += new System.EventHandler(this.btnNovaAgencia_Click);
            // 
            // txtAgenciaDescricao
            // 
            this.txtAgenciaDescricao.Location = new System.Drawing.Point(91, 65);
            this.txtAgenciaDescricao.Name = "txtAgenciaDescricao";
            this.txtAgenciaDescricao.Size = new System.Drawing.Size(168, 20);
            this.txtAgenciaDescricao.TabIndex = 4;
            // 
            // cmbAgenciaNumero
            // 
            this.cmbAgenciaNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgenciaNumero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAgenciaNumero.FormattingEnabled = true;
            this.cmbAgenciaNumero.Location = new System.Drawing.Point(91, 26);
            this.cmbAgenciaNumero.Name = "cmbAgenciaNumero";
            this.cmbAgenciaNumero.Size = new System.Drawing.Size(168, 21);
            this.cmbAgenciaNumero.TabIndex = 3;
            this.cmbAgenciaNumero.SelectionChangeCommitted += new System.EventHandler(this.cmbAgenciaNumero_SelectionChangeCommitted_1);
            this.cmbAgenciaNumero.Enter += new System.EventHandler(this.cmbAgenciaNumero_Enter);
            this.cmbAgenciaNumero.Leave += new System.EventHandler(this.cmbAgenciaNumero_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero:";
            // 
            // grpConta
            // 
            this.grpConta.Controls.Add(this.txtSaldoConta);
            this.grpConta.Controls.Add(this.txtDescricaoConta);
            this.grpConta.Controls.Add(this.txtNumeroConta);
            this.grpConta.Controls.Add(this.label6);
            this.grpConta.Controls.Add(this.label5);
            this.grpConta.Controls.Add(this.label4);
            this.grpConta.Location = new System.Drawing.Point(27, 281);
            this.grpConta.Name = "grpConta";
            this.grpConta.Size = new System.Drawing.Size(403, 125);
            this.grpConta.TabIndex = 2;
            this.grpConta.TabStop = false;
            this.grpConta.Text = "Conta:";
            // 
            // txtSaldoConta
            // 
            this.txtSaldoConta.Location = new System.Drawing.Point(91, 84);
            this.txtSaldoConta.Name = "txtSaldoConta";
            this.txtSaldoConta.Size = new System.Drawing.Size(168, 20);
            this.txtSaldoConta.TabIndex = 7;
            this.txtSaldoConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoConta_KeyPress);
            // 
            // txtDescricaoConta
            // 
            this.txtDescricaoConta.Location = new System.Drawing.Point(91, 51);
            this.txtDescricaoConta.MaxLength = 50;
            this.txtDescricaoConta.Name = "txtDescricaoConta";
            this.txtDescricaoConta.Size = new System.Drawing.Size(168, 20);
            this.txtDescricaoConta.TabIndex = 6;
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(91, 21);
            this.txtNumeroConta.MaxLength = 10;
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(168, 20);
            this.txtNumeroConta.TabIndex = 5;
            this.txtNumeroConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroConta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(355, 426);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(253, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(474, 461);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpConta);
            this.Controls.Add(this.grpContaAgencia);
            this.Controls.Add(this.grpContaBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Conta";
            this.Load += new System.EventHandler(this.frmCadConta_Load);
            this.grpContaBanco.ResumeLayout(false);
            this.grpContaBanco.PerformLayout();
            this.grpContaAgencia.ResumeLayout(false);
            this.grpContaAgencia.PerformLayout();
            this.grpConta.ResumeLayout(false);
            this.grpConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpContaBanco;
        private System.Windows.Forms.GroupBox grpContaAgencia;
        private System.Windows.Forms.GroupBox grpConta;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.ComboBox cmbNumeroBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgenciaDescricao;
        private System.Windows.Forms.ComboBox cmbAgenciaNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldoConta;
        private System.Windows.Forms.TextBox txtDescricaoConta;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovoBanco;
        private System.Windows.Forms.Button btnNovaAgencia;
    }
}