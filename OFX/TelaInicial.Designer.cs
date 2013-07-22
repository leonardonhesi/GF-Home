namespace OFX
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            this.pbInicial = new System.Windows.Forms.ProgressBar();
            this.tmrInicial = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbInicial
            // 
            this.pbInicial.Location = new System.Drawing.Point(32, 198);
            this.pbInicial.Name = "pbInicial";
            this.pbInicial.Size = new System.Drawing.Size(205, 23);
            this.pbInicial.TabIndex = 0;
            // 
            // tmrInicial
            // 
            this.tmrInicial.Enabled = true;
            this.tmrInicial.Interval = 32;
            this.tmrInicial.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OFX.Properties.Resources.Inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(268, 239);
            this.Controls.Add(this.pbInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbInicial;
        private System.Windows.Forms.Timer tmrInicial;
    }
}