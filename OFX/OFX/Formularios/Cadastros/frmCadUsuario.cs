using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OFX.Formularios.Classes;

namespace OFX.Formularios.Cadastros
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        //Cadastra Usuario
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Validar valida = new Validar();

            if (valida.valCampoVazio(this.Controls) == true)

            {
                if (txtsenhaUsuario.Text == txtRedigitarUsuario.Text)
                {

                    try
                    {

                        ggRt04 ver = new ggRt04();
                        Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                        var objUsuario = new Gerenciador.Data.usuario();

                        objUsuario.nome = txtNomeUsuario.Text;
                        objUsuario.senha = ver.somaSaldo(txtsenhaUsuario.Text);

                        objGerenciador.AddTousuario(objUsuario);
                        objGerenciador.SaveChanges();

                        MessageBox.Show("Usuário Cadastrado com sucesso!", "Aviso");
                        this.Close();
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro: " + ex.Message);

                    }
                }

                else
                { 
                  MessageBox.Show("Senhas não conferem, redigite","Aviso");
                
                }
            }


        }
        
        //Carrega o formulario para excluir a conta
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmManterusuario>().Count() > 0)
            {
                MessageBox.Show("Formulario sobre já está aberto!", "Aviso");
            }
            else
            {
                frmManterusuario manterUsuario = new frmManterusuario();
                manterUsuario.ShowDialog();
            }
        }

        //Fecha o formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
