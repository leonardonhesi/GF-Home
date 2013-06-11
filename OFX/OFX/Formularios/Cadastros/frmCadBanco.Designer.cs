namespace OFX.Formularios.Cadastros
{
    partial class frmCadBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadBanco));
            this.grpFrmCadBanco = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.txtNumeroBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFrmCadBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFrmCadBanco
            // 
            this.grpFrmCadBanco.Controls.Add(this.btnCancelar);
            this.grpFrmCadBanco.Controls.Add(this.btnConfirmar);
            this.grpFrmCadBanco.Controls.Add(this.txtNomeBanco);
            this.grpFrmCadBanco.Controls.Add(this.txtNumeroBanco);
            this.grpFrmCadBanco.Controls.Add(this.label2);
            this.grpFrmCadBanco.Controls.Add(this.label1);
            this.grpFrmCadBanco.Location = new System.Drawing.Point(12, 12);
            this.grpFrmCadBanco.Name = "grpFrmCadBanco";
            this.grpFrmCadBanco.Size = new System.Drawing.Size(268, 197);
            this.grpFrmCadBanco.TabIndex = 0;
            this.grpFrmCadBanco.TabStop = false;
            this.grpFrmCadBanco.Text = "Banco:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(23, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(176, 156);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(90, 85);
            this.txtNomeBanco.MaxLength = 50;
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(161, 20);
            this.txtNomeBanco.TabIndex = 2;
            // 
            // txtNumeroBanco
            // 
            this.txtNumeroBanco.Location = new System.Drawing.Point(90, 29);
            this.txtNumeroBanco.MaxLength = 10;
            this.txtNumeroBanco.Name = "txtNumeroBanco";
            this.txtNumeroBanco.Size = new System.Drawing.Size(161, 20);
            this.txtNumeroBanco.TabIndex = 1;
            this.txtNumeroBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroBanco_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // frmCadBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.grpFrmCadBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Banco";
            this.Load += new System.EventHandler(this.frmCadBanco_Load);
            this.grpFrmCadBanco.ResumeLayout(false);
            this.grpFrmCadBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFrmCadBanco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.TextBox txtNumeroBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}