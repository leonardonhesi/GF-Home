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

namespace OFX.Formularios.Cadastros
{
    public partial class frmCadRelacao : Form
    {
        //Construtor padrão
        public frmCadRelacao()
        {
            InitializeComponent();
        }

        //Confirma cadastro da relação
        private void btnOkRelacao_Click(object sender, EventArgs e)
        {
            //Validar campos preechidos
            //Função de validação
            Validar valida = new Validar();
            if (valida.valCampoVazio(this.Controls) == true)
            {

                //Verificar se a relação já existe
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    var query = from conv in objGerenciador.Relacao
                                where (conv.Nome == txtNomeRelacao.Text && conv.Tipo == cmbTipoRelacao.Text)
                                select conv;
                    var ListaFinal = query.ToList();

                    //Se não  tiver cadastrada realiza o cadastro
                    if (ListaFinal.Count == 0)
                    {

                        Gerenciador.Data.dbGerenciadorEntities objGerenciador1 = new Gerenciador.Data.dbGerenciadorEntities();
                        var objRelacao = new Gerenciador.Data.Relacao();
                        objRelacao.Nome = txtNomeRelacao.Text;
                        objRelacao.Tipo = cmbTipoRelacao.Text;
                        objGerenciador1.AddToRelacao(objRelacao);
                        objGerenciador1.SaveChanges();
                        MessageBox.Show("Relação cadastrada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                         MessageBoxDefaultButton.Button1);
                        txtNomeRelacao.Text = "";
                        txtNomeRelacao.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Relação já cadastrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                         MessageBoxDefaultButton.Button1);
                        txtNomeRelacao.Text = "";

                    }

                }

            }
        }

        //Fecha o formulario
        private void btnCancelaRelacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
