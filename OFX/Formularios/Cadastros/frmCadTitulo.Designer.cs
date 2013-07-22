namespace OFX.Formularios.Cadastros
{
    partial class frmCadTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTitulo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpVctoTitulo = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoTitulo = new System.Windows.Forms.ComboBox();
            this.cmbRelacaoTitulo = new System.Windows.Forms.ComboBox();
            this.cmbNaturezaTitulo = new System.Windows.Forms.ComboBox();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.txtDescricaoTitulo = new System.Windows.Forms.TextBox();
            this.txtValorTitulo = new System.Windows.Forms.TextBox();
            this.txtParcelaTitulo = new System.Windows.Forms.TextBox();
            this.txtNumeroTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmaTitulo = new System.Windows.Forms.Button();
            this.btnCancelaTitulo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpVctoTitulo);
            this.groupBox1.Controls.Add(this.cmbTipoTitulo);
            this.groupBox1.Controls.Add(this.cmbRelacaoTitulo);
            this.groupBox1.Controls.Add(this.cmbNaturezaTitulo);
            this.groupBox1.Controls.Add(this.txtCodBar);
            this.groupBox1.Controls.Add(this.txtDescricaoTitulo);
            this.groupBox1.Controls.Add(this.txtValorTitulo);
            this.groupBox1.Controls.Add(this.txtParcelaTitulo);
            this.groupBox1.Controls.Add(this.txtNumeroTitulo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Título";
            // 
            // dtpVctoTitulo
            // 
            this.dtpVctoTitulo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVctoTitulo.Location = new System.Drawing.Point(531, 74);
            this.dtpVctoTitulo.Name = "dtpVctoTitulo";
            this.dtpVctoTitulo.Size = new System.Drawing.Size(102, 20);
            this.dtpVctoTitulo.TabIndex = 6;
            // 
            // cmbTipoTitulo
            // 
            this.cmbTipoTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTitulo.FormattingEnabled = true;
            this.cmbTipoTitulo.Items.AddRange(new object[] {
            "DEBITO",
            "CREDITO"});
            this.cmbTipoTitulo.Location = new System.Drawing.Point(531, 25);
            this.cmbTipoTitulo.Name = "cmbTipoTitulo";
            this.cmbTipoTitulo.Size = new System.Drawing.Size(102, 21);
            this.cmbTipoTitulo.TabIndex = 3;
            this.cmbTipoTitulo.Enter += new System.EventHandler(this.cmbTipoTitulo_Enter);
            this.cmbTipoTitulo.Leave += new System.EventHandler(this.cmbTipoTitulo_Leave);
            // 
            // cmbRelacaoTitulo
            // 
            this.cmbRelacaoTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelacaoTitulo.FormattingEnabled = true;
            this.cmbRelacaoTitulo.Location = new System.Drawing.Point(308, 26);
            this.cmbRelacaoTitulo.Name = "cmbRelacaoTitulo";
            this.cmbRelacaoTitulo.Size = new System.Drawing.Size(121, 21);
            this.cmbRelacaoTitulo.TabIndex = 2;
            // 
            // cmbNaturezaTitulo
            // 
            this.cmbNaturezaTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNaturezaTitulo.FormattingEnabled = true;
            this.cmbNaturezaTitulo.Location = new System.Drawing.Point(95, 135);
            this.cmbNaturezaTitulo.Name = "cmbNaturezaTitulo";
            this.cmbNaturezaTitulo.Size = new System.Drawing.Size(121, 21);
            this.cmbNaturezaTitulo.TabIndex = 7;
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(95, 184);
            this.txtCodBar.MaxLength = 100;
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(538, 20);
            this.txtCodBar.TabIndex = 9;
            this.txtCodBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBar_KeyPress);
            // 
            // txtDescricaoTitulo
            // 
            this.txtDescricaoTitulo.Location = new System.Drawing.Point(317, 136);
            this.txtDescricaoTitulo.MaxLength = 50;
            this.txtDescricaoTitulo.Name = "txtDescricaoTitulo";
            this.txtDescricaoTitulo.Size = new System.Drawing.Size(316, 20);
            this.txtDescricaoTitulo.TabIndex = 8;
            // 
            // txtValorTitulo
            // 
            this.txtValorTitulo.Location = new System.Drawing.Point(308, 76);
            this.txtValorTitulo.MaxLength = 10;
            this.txtValorTitulo.Name = "txtValorTitulo";
            this.txtValorTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtValorTitulo.TabIndex = 5;
            this.txtValorTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTitulo_KeyPress);
            // 
            // txtParcelaTitulo
            // 
            this.txtParcelaTitulo.Location = new System.Drawing.Point(95, 76);
            this.txtParcelaTitulo.MaxLength = 3;
            this.txtParcelaTitulo.Name = "txtParcelaTitulo";
            this.txtParcelaTitulo.Size = new System.Drawing.Size(128, 20);
            this.txtParcelaTitulo.TabIndex = 4;
            this.txtParcelaTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcelaTitulo_KeyPress);
            this.txtParcelaTitulo.Leave += new System.EventHandler(this.txtParcelaTitulo_Leave);
            // 
            // txtNumeroTitulo
            // 
            this.txtNumeroTitulo.Location = new System.Drawing.Point(95, 26);
            this.txtNumeroTitulo.MaxLength = 20;
            this.txtNumeroTitulo.Name = "txtNumeroTitulo";
            this.txtNumeroTitulo.Size = new System.Drawing.Size(128, 20);
            this.txtNumeroTitulo.TabIndex = 1;
            this.txtNumeroTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTitulo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "CodBarras:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Natureza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vencimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Qtd_Parcela:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Relação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // btnConfirmaTitulo
            // 
            this.btnConfirmaTitulo.Location = new System.Drawing.Point(579, 292);
            this.btnConfirmaTitulo.Name = "btnConfirmaTitulo";
            this.btnConfirmaTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaTitulo.TabIndex = 10;
            this.btnConfirmaTitulo.Text = "Confirma";
            this.btnConfirmaTitulo.UseVisualStyleBackColor = true;
            this.btnConfirmaTitulo.Click += new System.EventHandler(this.btnConfirmaTitulo_Click);
            // 
            // btnCancelaTitulo
            // 
            this.btnCancelaTitulo.Location = new System.Drawing.Point(468, 292);
            this.btnCancelaTitulo.Name = "btnCancelaTitulo";
            this.btnCancelaTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelaTitulo.TabIndex = 9;
            this.btnCancelaTitulo.Text = "Cancela";
            this.btnCancelaTitulo.UseVisualStyleBackColor = true;
            this.btnCancelaTitulo.Click += new System.EventHandler(this.btnCancelaTitulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relaçãoToolStripMenuItem,
            this.naturezaToolStripMenuItem,
            this.contasToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // relaçãoToolStripMenuItem
            // 
            this.relaçãoToolStripMenuItem.Name = "relaçãoToolStripMenuItem";
            this.relaçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.relaçãoToolStripMenuItem.Text = "Relação";
            this.relaçãoToolStripMenuItem.Click += new System.EventHandler(this.relaçãoToolStripMenuItem_Click);
            // 
            // naturezaToolStripMenuItem
            // 
            this.naturezaToolStripMenuItem.Name = "naturezaToolStripMenuItem";
            this.naturezaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.naturezaToolStripMenuItem.Text = "Natureza";
            this.naturezaToolStripMenuItem.Click += new System.EventHandler(this.naturezaToolStripMenuItem_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contasToolStripMenuItem.Text = "Contas";
            this.contasToolStripMenuItem.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
            // 
            // frmCadTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 349);
            this.Controls.Add(this.btnCancelaTitulo);
            this.Controls.Add(this.btnConfirmaTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCadTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Títulos";
            this.Load += new System.EventHandler(this.frmCadTitulo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNaturezaTitulo;
        private System.Windows.Forms.TextBox txtDescricaoTitulo;
        private System.Windows.Forms.TextBox txtValorTitulo;
        private System.Windows.Forms.TextBox txtNumeroTitulo;
        private System.Windows.Forms.DateTimePicker dtpVctoTitulo;
        private System.Windows.Forms.ComboBox cmbTipoTitulo;
        private System.Windows.Forms.ComboBox cmbRelacaoTitulo;
        private System.Windows.Forms.Button btnConfirmaTitulo;
        private System.Windows.Forms.Button btnCancelaTitulo;
        private System.Windows.Forms.TextBox txtParcelaTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.Label label9;
    }
}