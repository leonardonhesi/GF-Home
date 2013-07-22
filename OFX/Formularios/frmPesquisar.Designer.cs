namespace OFX.Formularios
{
    partial class frmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltroPesquisa = new System.Windows.Forms.ComboBox();
            this.grpVencimento = new System.Windows.Forms.GroupBox();
            this.grpValor = new System.Windows.Forms.GroupBox();
            this.grpNatureza = new System.Windows.Forms.GroupBox();
            this.grpRelacao = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesqVencimento = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.grpValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de Pesquisa";
            // 
            // cmbFiltroPesquisa
            // 
            this.cmbFiltroPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroPesquisa.FormattingEnabled = true;
            this.cmbFiltroPesquisa.Items.AddRange(new object[] {
            "Vencimento",
            "Valor",
            "Natureza",
            "Relação"});
            this.cmbFiltroPesquisa.Location = new System.Drawing.Point(170, 12);
            this.cmbFiltroPesquisa.Name = "cmbFiltroPesquisa";
            this.cmbFiltroPesquisa.Size = new System.Drawing.Size(109, 21);
            this.cmbFiltroPesquisa.TabIndex = 1;
            this.cmbFiltroPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpVencimento
            // 
            this.grpVencimento.Location = new System.Drawing.Point(12, 60);
            this.grpVencimento.Name = "grpVencimento";
            this.grpVencimento.Size = new System.Drawing.Size(142, 179);
            this.grpVencimento.TabIndex = 2;
            this.grpVencimento.TabStop = false;
            this.grpVencimento.Text = "Pesquisa Vencimento";
            // 
            // grpValor
            // 
            this.grpValor.Controls.Add(this.btnPesqVencimento);
            this.grpValor.Controls.Add(this.txtValor);
            this.grpValor.Controls.Add(this.lblValor);
            this.grpValor.Location = new System.Drawing.Point(170, 60);
            this.grpValor.Name = "grpValor";
            this.grpValor.Size = new System.Drawing.Size(160, 179);
            this.grpValor.TabIndex = 3;
            this.grpValor.TabStop = false;
            this.grpValor.Text = "Pesquisa Valor";
            // 
            // grpNatureza
            // 
            this.grpNatureza.Location = new System.Drawing.Point(355, 60);
            this.grpNatureza.Name = "grpNatureza";
            this.grpNatureza.Size = new System.Drawing.Size(147, 179);
            this.grpNatureza.TabIndex = 4;
            this.grpNatureza.TabStop = false;
            this.grpNatureza.Text = "Pesquisa Natureza";
            // 
            // grpRelacao
            // 
            this.grpRelacao.Location = new System.Drawing.Point(508, 60);
            this.grpRelacao.Name = "grpRelacao";
            this.grpRelacao.Size = new System.Drawing.Size(162, 179);
            this.grpRelacao.TabIndex = 5;
            this.grpRelacao.TabStop = false;
            this.grpRelacao.Text = "Pesquisa Relação";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 51);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(44, 44);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnPesqVencimento
            // 
            this.btnPesqVencimento.Location = new System.Drawing.Point(69, 115);
            this.btnPesqVencimento.Name = "btnPesqVencimento";
            this.btnPesqVencimento.Size = new System.Drawing.Size(75, 23);
            this.btnPesqVencimento.TabIndex = 2;
            this.btnPesqVencimento.Text = "Pesquisar";
            this.btnPesqVencimento.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vencimento",
            "Valor",
            "Natureza",
            "Relação"});
            this.comboBox1.Location = new System.Drawing.Point(301, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Vencimento",
            "Valor",
            "Natureza",
            "Relação"});
            this.comboBox2.Location = new System.Drawing.Point(430, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Vencimento",
            "Valor",
            "Natureza",
            "Relação"});
            this.comboBox3.Location = new System.Drawing.Point(561, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(109, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 273);
            this.Controls.Add(this.grpRelacao);
            this.Controls.Add(this.grpNatureza);
            this.Controls.Add(this.grpValor);
            this.Controls.Add(this.grpVencimento);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbFiltroPesquisa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.grpValor.ResumeLayout(false);
            this.grpValor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltroPesquisa;
        private System.Windows.Forms.GroupBox grpVencimento;
        private System.Windows.Forms.GroupBox grpValor;
        private System.Windows.Forms.GroupBox grpNatureza;
        private System.Windows.Forms.GroupBox grpRelacao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnPesqVencimento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}