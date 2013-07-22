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
    public partial class frmCadNatureza : Form
    {
        //Construtor padrão
        public frmCadNatureza()
        {
            InitializeComponent();
        }

        //Incluir Naturezas
        private void btnOkNatureza_Click(object sender, EventArgs e)
        {
            //Validar campos preechidos
            //Função de validação
            Validar valida = new Validar();
            if (valida.valCampoVazio(this.Controls) == true)
            {

                Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                var objNatureza = new Gerenciador.Data.Natureza();

                objNatureza.nome = txtNomeNatureza.Text;
                objNatureza.descricao = txtDescNatureza.Text;
                objGerenciador.AddToNatureza(objNatureza);
                objGerenciador.SaveChanges();

                MessageBox.Show("Natureza cadastrada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button2);

                txtDescNatureza.Text = "";
                txtNomeNatureza.Text = "";
                txtNomeNatureza.Focus();
            }
        }
        //Fechar o formulario
        private void btnCacelaNatureza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Abre o formualario de natureza para edição 
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmManterNatureza>().Count() > 0)
            {
                MessageBox.Show("Formulario de cadastro de E-mail já está aberto!", "Aviso");
            }
            else
            {
                frmManterNatureza telaManterNat = new frmManterNatureza();
                telaManterNat.ShowDialog();
            }

        }
    }
}
