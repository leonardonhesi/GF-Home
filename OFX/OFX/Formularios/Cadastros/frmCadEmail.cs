using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OFX.OFX.Classes;
using System.Collections;
using Gerenciador.Data;
using System.Data.Entity;
using OFX.Formularios.Classes;
using System.Text.RegularExpressions;


namespace OFX.Formularios.Cadastros
{
    public partial class frmCadEmail : Form
    {
        public frmCadEmail()
        {
            InitializeComponent();
        }

        //Função para validar o e-mail
        public bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                //define a expressão regulara para validar o email
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                // testa o email com a expressão
                if (expressaoRegex.IsMatch(texto_Validar))
                {
                    // o email é valido
                    return true;
                }
                else
                {
                    // o email é inválido
                    MessageBox.Show("E-mail inválido verifique!", "Aviso", MessageBoxButtons.OK, 
                                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                   
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
        }

        public bool ValidaSenha()
        {
            if (txtSenha.Text == txtRptSenha.Text)
            {

                return true;
            }

            else
            {
                MessageBox.Show("Os campos de senha não são iguais verifique!", "Aviso", MessageBoxButtons.AbortRetryIgnore,
                                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);   
                return false;
            
            }

        }

        //Botão confirma gravação do e-mail
        private void btnOkEmail_Click(object sender, EventArgs e)
        {
             //Chamar a função de validação dos campos
            Validar valida = new Validar();
            
            //Valida o campos vazios o e-mail correto e a redigitação da senha
            if (valida.valCampoVazio(this.Controls) == true && ValidaEnderecoEmail(txtEmail.Text) == true && ValidaSenha() == true)
            {

                try
                {
                    ggRt04 pass = new ggRt04();
                    
                    
                    Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                    var objEmail = new Gerenciador.Data.email();

                    objEmail.email1 = txtEmail.Text;
                    objEmail.smtp = txtSmtp.Text;
                    objEmail.porta = Convert.ToInt32(txtPorta.Text);
                    objEmail.senha = pass.somaSaldo(txtSenha.Text);
                    objEmail.observacao = txtObs.Text;
                    
                    objGerenciador.AddToemail(objEmail);
                    objGerenciador.SaveChanges();

                    MessageBox.Show("Email cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, 
                                     MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.Message);
                
                }

            
            }
        
        
        }

        //Validar somente numero na porta
        private void txtPorta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtPorta);
        }

        //Menu editar
        private void editarEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmManterEmail>().Count() > 0)
            {
                MessageBox.Show("Formulario manutenção de emails já está aberto!", "Aviso");
            }
            else
            {
                frmManterEmail telaManterEmails = new frmManterEmail();
                telaManterEmails.ShowDialog();
            }

        }

        
    }
}
