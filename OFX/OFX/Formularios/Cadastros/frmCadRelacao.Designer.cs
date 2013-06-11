namespace OFX.Formularios.Cadastros
{
    partial class frmCadRelacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadRelacao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoRelacao = new System.Windows.Forms.ComboBox();
            this.txtNomeRelacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelaRelacao = new System.Windows.Forms.Button();
            this.btnOkRelacao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // cmbTipoRelacao
            // 
            this.cmbTipoRelacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRelacao.FormattingEnabled = true;
            this.cmbTipoRelacao.Items.AddRange(new object[] {
            "FORNECEDOR",
            "CLIENTE"});
            this.cmbTipoRelacao.Location = new System.Drawing.Point(74, 84);
            this.cmbTipoRelacao.Name = "cmbTipoRelacao";
            this.cmbTipoRelacao.Size = new System.Drawing.Size(170, 21);
            this.cmbTipoRelacao.TabIndex = 2;
            // 
            // txtNomeRelacao
            // 
            this.txtNomeRelacao.Location = new System.Drawing.Point(74, 34);
            this.txtNomeRelacao.Name = "txtNomeRelacao";
            this.txtNomeRelacao.Size = new System.Drawing.Size(170, 20);
            this.txtNomeRelacao.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelaRelacao);
            this.groupBox1.Controls.Add(this.btnOkRelacao);
            this.groupBox1.Controls.Add(this.txtNomeRelacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTipoRelacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedores/Clientes";
            // 
            // btnCancelaRelacao
            // 
            this.btnCancelaRelacao.Location = new System.Drawing.Point(25, 157);
            this.btnCancelaRelacao.Name = "btnCancelaRelacao";
            this.btnCancelaRelacao.Size = new System.Drawing.Size(75, 23);
            this.btnCancelaRelacao.TabIndex = 3;
            this.btnCancelaRelacao.Text = "Cancelar";
            this.btnCancelaRelacao.UseVisualStyleBackColor = true;
            this.btnCancelaRelacao.Click += new System.EventHandler(this.btnCancelaRelacao_Click);
            // 
            // btnOkRelacao
            // 
            this.btnOkRelacao.Location = new System.Drawing.Point(169, 157);
            this.btnOkRelacao.Name = "btnOkRelacao";
            this.btnOkRelacao.Size = new System.Drawing.Size(75, 23);
            this.btnOkRelacao.TabIndex = 4;
            this.btnOkRelacao.Text = "Confirmar";
            this.btnOkRelacao.UseVisualStyleBackColor = true;
            this.btnOkRelacao.Click += new System.EventHandler(this.btnOkRelacao_Click);
            // 
            // frmCadRelacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 266);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadRelacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores/Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoRelacao;
        private System.Windows.Forms.TextBox txtNomeRelacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelaRelacao;
        private System.Windows.Forms.Button btnOkRelacao;
    }
}