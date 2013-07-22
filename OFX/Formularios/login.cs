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
using OFX.Formularios.Cadastros;

namespace OFX.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Fecha o formulario
        private void btnfecharLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Verifica primeira inicialização
        public bool valExisteUsuario()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                var query = from conv in objGerenciador.usuario
                            select conv;
                var ListaFinal = query.ToList();

                if (ListaFinal.Count == 0)
                {
                    return false;

                }
            }
            return true;

        }

        //Confirma logitbm
        private void btnConfirmaLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    var qUsuario = from conv in objGerenciador.usuario
                                   where conv.nome == txtUsuario.Text
                                   select new
                                   {

                                       conv.nome,
                                       conv.senha

                                   };

                    var ListaFinal = qUsuario.ToList();


                    if (ListaFinal.Count == 0)
                    {
                        MessageBox.Show("Usuário ou senha invalidos", "Aviso");

                    }

                    else
                    {

                        //Verificar a senha em etapas com varias condições 
                        ggRt04 val = new ggRt04();

                        if (val.somaSaldo(txtSenha.Text) == ListaFinal[0].senha)
                        {

                            frmPrincipal inicia = new frmPrincipal();
                            this.Hide();
                            inicia.ShowDialog();
                            Application.Exit();



                        }

                        else
                        {

                            MessageBox.Show("Usuário ou senha invalidos", "Aviso");

                        }

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        //Load do formulario
        private void Login_Load(object sender, EventArgs e)
        {
            //Verifica se existe usuario cadastrado
            if (valExisteUsuario() == false)
            {
                if (MessageBox.Show("Nenhum usuario está cadastrado, gostaria de cadastrar agora?", "Aviso", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Application.OpenForms.OfType<frmCadUsuario>().Count() > 0)
                    {
                        MessageBox.Show("Formulario de cadastro de Usuários já está aberto!", "Aviso");
                    }
                    else
                    {
                        frmCadUsuario telaCadUsuario = new frmCadUsuario();
                        telaCadUsuario.MainMenuStrip.Enabled = false;
                        telaCadUsuario.ShowDialog();
                        if (valExisteUsuario() == false)
                        {
                            MessageBox.Show("Nenhum usuario está cadastrado", "Aviso");
                            this.Close();
                        }
                    }



                }
                else
                {

                    this.Close();
                }
            }

        }

        //Tratamento do enter chama evento do botão confirma

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConfirmaLogin.PerformClick();
            }
        }
    }
}
