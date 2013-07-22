namespace OFX.Formularios
{
    partial class frmEnviaEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviaEmail));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestEmail = new System.Windows.Forms.ComboBox();
            this.dtpIncio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnCancelarEmail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviar Para:";
            // 
            // cmbDestEmail
            // 
            this.cmbDestEmail.FormattingEnabled = true;
            this.cmbDestEmail.Location = new System.Drawing.Point(289, 86);
            this.cmbDestEmail.Name = "cmbDestEmail";
            this.cmbDestEmail.Size = new System.Drawing.Size(175, 21);
            this.cmbDestEmail.TabIndex = 3;
            // 
            // dtpIncio
            // 
            this.dtpIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIncio.Location = new System.Drawing.Point(55, 19);
            this.dtpIncio.Name = "dtpIncio";
            this.dtpIncio.Size = new System.Drawing.Size(111, 20);
            this.dtpIncio.TabIndex = 1;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(55, 64);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(111, 20);
            this.dtpFinal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Até:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpIncio);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vencimentos";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(388, 142);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarEmail.TabIndex = 5;
            this.btnEnviarEmail.Text = "Enviar";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnCancelarEmail
            // 
            this.btnCancelarEmail.Location = new System.Drawing.Point(270, 142);
            this.btnCancelarEmail.Name = "btnCancelarEmail";
            this.btnCancelarEmail.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEmail.TabIndex = 4;
            this.btnCancelarEmail.Text = "Cancelar";
            this.btnCancelarEmail.UseVisualStyleBackColor = true;
            this.btnCancelarEmail.Click += new System.EventHandler(this.btnCancelarEmail_Click);
            // 
            // frmEnviaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 177);
            this.Controls.Add(this.btnCancelarEmail);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDestEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEnviaEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de E-mail";
            this.Load += new System.EventHandler(this.frmEnviaEmail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestEmail;
        private System.Windows.Forms.DateTimePicker dtpIncio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnCancelarEmail;
    }
}