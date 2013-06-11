namespace OFX.Formularios.Cadastros
{
    partial class frmCadNatureza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadNatureza));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeNatureza = new System.Windows.Forms.TextBox();
            this.txtDescNatureza = new System.Windows.Forms.TextBox();
            this.btnCacelaNatureza = new System.Windows.Forms.Button();
            this.btnOkNatureza = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição:";
            // 
            // txtNomeNatureza
            // 
            this.txtNomeNatureza.Location = new System.Drawing.Point(92, 27);
            this.txtNomeNatureza.Name = "txtNomeNatureza";
            this.txtNomeNatureza.Size = new System.Drawing.Size(162, 20);
            this.txtNomeNatureza.TabIndex = 1;
            // 
            // txtDescNatureza
            // 
            this.txtDescNatureza.Location = new System.Drawing.Point(92, 74);
            this.txtDescNatureza.Name = "txtDescNatureza";
            this.txtDescNatureza.Size = new System.Drawing.Size(162, 20);
            this.txtDescNatureza.TabIndex = 1;
            // 
            // btnCacelaNatureza
            // 
            this.btnCacelaNatureza.Location = new System.Drawing.Point(27, 148);
            this.btnCacelaNatureza.Name = "btnCacelaNatureza";
            this.btnCacelaNatureza.Size = new System.Drawing.Size(75, 23);
            this.btnCacelaNatureza.TabIndex = 2;
            this.btnCacelaNatureza.Text = "Cancela";
            this.btnCacelaNatureza.UseVisualStyleBackColor = true;
            this.btnCacelaNatureza.Click += new System.EventHandler(this.btnCacelaNatureza_Click);
            // 
            // btnOkNatureza
            // 
            this.btnOkNatureza.Location = new System.Drawing.Point(179, 148);
            this.btnOkNatureza.Name = "btnOkNatureza";
            this.btnOkNatureza.Size = new System.Drawing.Size(75, 23);
            this.btnOkNatureza.TabIndex = 2;
            this.btnOkNatureza.Text = "Confirma";
            this.btnOkNatureza.UseVisualStyleBackColor = true;
            this.btnOkNatureza.Click += new System.EventHandler(this.btnOkNatureza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeNatureza);
            this.groupBox1.Controls.Add(this.btnCacelaNatureza);
            this.groupBox1.Controls.Add(this.btnOkNatureza);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescNatureza);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 202);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Natureza";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // frmCadNatureza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCadNatureza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Natureza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeNatureza;
        private System.Windows.Forms.TextBox txtDescNatureza;
        private System.Windows.Forms.Button btnCacelaNatureza;
        private System.Windows.Forms.Button btnOkNatureza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}