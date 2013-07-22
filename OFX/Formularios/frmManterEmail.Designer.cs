namespace OFX.Formularios
{
    partial class frmManterEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterEmail));
            this.dtgEmail = new System.Windows.Forms.DataGridView();
            this.btnExcluirEmail = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEmail
            // 
            this.dtgEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.SMTP,
            this.Porta});
            this.dtgEmail.Location = new System.Drawing.Point(12, 73);
            this.dtgEmail.MultiSelect = false;
            this.dtgEmail.Name = "dtgEmail";
            this.dtgEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmail.Size = new System.Drawing.Size(375, 181);
            this.dtgEmail.TabIndex = 0;
            // 
            // btnExcluirEmail
            // 
            this.btnExcluirEmail.Location = new System.Drawing.Point(312, 33);
            this.btnExcluirEmail.Name = "btnExcluirEmail";
            this.btnExcluirEmail.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEmail.TabIndex = 1;
            this.btnExcluirEmail.Text = "Excluir";
            this.btnExcluirEmail.UseVisualStyleBackColor = true;
            this.btnExcluirEmail.Click += new System.EventHandler(this.btnExcluirEmail_Click);
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email1";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // SMTP
            // 
            this.SMTP.DataPropertyName = "smtp";
            this.SMTP.HeaderText = "SMTP";
            this.SMTP.Name = "SMTP";
            // 
            // Porta
            // 
            this.Porta.DataPropertyName = "porta";
            this.Porta.HeaderText = "Porta";
            this.Porta.Name = "Porta";
            // 
            // frmManterEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 266);
            this.Controls.Add(this.btnExcluirEmail);
            this.Controls.Add(this.dtgEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManterEmail";
            this.Text = "E-mails";
            this.Load += new System.EventHandler(this.frmManterEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEmail;
        private System.Windows.Forms.Button btnExcluirEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porta;
    }
}