namespace OFX.Formularios.Cadastros
{
    partial class frmCadAgencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAgencia));
            this.grpFrmCadBanco = new System.Windows.Forms.GroupBox();
            this.cmbBancoCadAgencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtDescAgencia = new System.Windows.Forms.TextBox();
            this.txtNumeroAgencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFrmCadBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFrmCadBanco
            // 
            this.grpFrmCadBanco.Controls.Add(this.cmbBancoCadAgencia);
            this.grpFrmCadBanco.Controls.Add(this.label3);
            this.grpFrmCadBanco.Controls.Add(this.btnCancelar);
            this.grpFrmCadBanco.Controls.Add(this.btnConfirmar);
            this.grpFrmCadBanco.Controls.Add(this.txtDescAgencia);
            this.grpFrmCadBanco.Controls.Add(this.txtNumeroAgencia);
            this.grpFrmCadBanco.Controls.Add(this.label2);
            this.grpFrmCadBanco.Controls.Add(this.label1);
            this.grpFrmCadBanco.Location = new System.Drawing.Point(12, 12);
            this.grpFrmCadBanco.Name = "grpFrmCadBanco";
            this.grpFrmCadBanco.Size = new System.Drawing.Size(268, 242);
            this.grpFrmCadBanco.TabIndex = 1;
            this.grpFrmCadBanco.TabStop = false;
            this.grpFrmCadBanco.Text = "Agência:";
            // 
            // cmbBancoCadAgencia
            // 
            this.cmbBancoCadAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBancoCadAgencia.FormattingEnabled = true;
            this.cmbBancoCadAgencia.Location = new System.Drawing.Point(90, 37);
            this.cmbBancoCadAgencia.Name = "cmbBancoCadAgencia";
            this.cmbBancoCadAgencia.Size = new System.Drawing.Size(161, 21);
            this.cmbBancoCadAgencia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Banco:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(23, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(176, 194);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtDescAgencia
            // 
            this.txtDescAgencia.Location = new System.Drawing.Point(90, 137);
            this.txtDescAgencia.MaxLength = 50;
            this.txtDescAgencia.Name = "txtDescAgencia";
            this.txtDescAgencia.Size = new System.Drawing.Size(161, 20);
            this.txtDescAgencia.TabIndex = 3;
            // 
            // txtNumeroAgencia
            // 
            this.txtNumeroAgencia.Location = new System.Drawing.Point(90, 86);
            this.txtNumeroAgencia.MaxLength = 10;
            this.txtNumeroAgencia.Name = "txtNumeroAgencia";
            this.txtNumeroAgencia.Size = new System.Drawing.Size(161, 20);
            this.txtNumeroAgencia.TabIndex = 2;
            this.txtNumeroAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroAgencia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // frmCadAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.grpFrmCadBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Agência";
            this.Load += new System.EventHandler(this.frmCadAgencia_Load);
            this.grpFrmCadBanco.ResumeLayout(false);
            this.grpFrmCadBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFrmCadBanco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtDescAgencia;
        private System.Windows.Forms.TextBox txtNumeroAgencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBancoCadAgencia;
        private System.Windows.Forms.Label label3;
    }
}