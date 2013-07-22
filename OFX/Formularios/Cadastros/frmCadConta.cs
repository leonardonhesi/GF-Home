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
    public partial class frmCadConta : Form
    {
               
        public frmCadConta()
        {
            InitializeComponent();
        }

        //Load do formulario carrega todos os bancos no  cmbNumeroBanco caso
        //não tenha banco exibe formulario cadastro de banco frmCadBanco
        public void loadComboBanco()
        {
            //Realiza a busca no banco
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                var query = from conv in objGerenciador.Banco
                            select conv;
                var ListaBanco = query.ToList();

                //Verifica se tem retorno ( existe banco cadastrado )
                if (ListaBanco.Count == 0)
                {
                    //Se não tiver retorno oferece a oportunidade de cadastrar o banco
                    if (MessageBox.Show("Nenhum banco está cadastrado" + Environment.NewLine +
                                     "Gostaria de cadastrar um banco agora?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadBanco cadBanco = new frmCadBanco();
                        cadBanco.ShowDialog();
                        loadComboBanco();
                    }
                }

                else
                {
                    //Se tiver o banco preenche combobox
                    cmbNumeroBanco.DataSource = ListaBanco;
                    cmbNumeroBanco.DisplayMember = "numero";
                    cmbNumeroBanco.ValueMember = "numero";


                }
            }

        }

        //Carrega descrição do banco no textbox
        public void loadDescbanco()
        {
            //Preenche a descrição do banco
            using (var objGerenciador1 = new dbGerenciadorEntities())
            {
                int numeroBanco = Convert.ToInt32(cmbNumeroBanco.SelectedValue);


                var retDescr = (from nBanco in objGerenciador1.Banco
                                where nBanco.numero == numeroBanco
                                select nBanco.descricao).First();

                txtNomeBanco.Text = retDescr;

            }



        }

        //Carrega combo das agências baseado no banco se não existe exibe o frmCadAgencia
        public void loadComboAgencia()
        {
            //Realiza a busca no banco
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                int nBanco = Convert.ToInt32(cmbNumeroBanco.SelectedValue);

                var query = from conv in objGerenciador.Agencia
                            where conv.banco == nBanco
                            select conv;
                var ListaAgencia = query.ToList();

                //Verifica se tem retorno
                if (ListaAgencia.Count == 0)
                {
                    //Se não tiver retorno abre o formulario de cadastro

                    if (MessageBox.Show("Nenhuma Agência está cadastrada" + Environment.NewLine + " Gostaria de cadastrar uma agência agora?", "Aviso",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadAgencia cadAgencia = new frmCadAgencia(cmbNumeroBanco.SelectedValue.ToString());
                        cadAgencia.ShowDialog();
                        loadComboAgencia();
                    }
                }

                else
                {
                    //Se tiver o banco preenche combobox

                    cmbAgenciaNumero.DataSource = ListaAgencia;
                    cmbAgenciaNumero.DisplayMember = "numero";
                    cmbAgenciaNumero.ValueMember = "numero";


                }
            }


        }

        //Carrega descrição agencia
        public void loadDescAgencia()
        {
            //Preenche a descrição do banco
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                int numeroAgencia = Convert.ToInt32(cmbAgenciaNumero.SelectedValue);

                if (cmbAgenciaNumero.Text != "")
                {
                    var retDescr = (from nAgencia in objGerenciador.Agencia
                                    where nAgencia.numero == numeroAgencia
                                    select nAgencia.descricao).First();

                    txtAgenciaDescricao.Text = retDescr;
                }
            }

        }

        //Load do Formulario preenche combo do banco
        private void frmCadConta_Load(object sender, EventArgs e)
        {
           
                loadComboBanco();
            
            
        }

        //Eventos para atualização da descrição do banco de acordo com o numero do banco

        //Click botão Novo Banco ( CADASTRAR BANCO )
        private void btnNovoBanco_Click(object sender, EventArgs e)
        {
            frmCadBanco cadBanco = new frmCadBanco();
            cadBanco.ShowDialog();
            loadComboBanco();
        }

        //Atualiza combobox Agência de acordo com a conta
        private void cmbAgenciaNumero_Enter(object sender, EventArgs e)
        {
            loadComboAgencia();
        }

        //Nova Agência (CADASTRAR AGÊNCIA)
        private void btnNovaAgencia_Click(object sender, EventArgs e)
        {
            //Aqui passa parametro nome do banco se não tiver passa vazio que a classe trata
            frmCadAgencia cadAgencia = new frmCadAgencia(cmbNumeroBanco.SelectedValue.ToString());
            cadAgencia.ShowDialog();
            loadComboAgencia();

        }

        //Confirmar geral (GRAVAR A CONTA)
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Chama validação campos
            Validar valida = new Validar();
            if (valida.valCampoVazio(this.Controls) == true)
            {

                //Incluir
                Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                var objConta = new Gerenciador.Data.Conta();

                objConta.numero = Convert.ToInt32(txtNumeroConta.Text);
                objConta.agencia = Convert.ToInt32(cmbAgenciaNumero.SelectedValue);
                objConta.descricao = txtDescricaoConta.Text;
                objConta.saldo = Convert.ToDecimal(txtSaldoConta.Text);
                objConta.data_criacao = DateTime.Now.Date;
                objGerenciador.AddToConta(objConta);
                objGerenciador.SaveChanges();

                MessageBox.Show("Conta Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button2);
                this.Close();

            }
        }

        //Eventos para atualização da descrição da agência de acordo com o numero da agência
        private void cmbAgenciaNumero_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cmbAgenciaNumero.Text != "")
            {
                loadDescAgencia();
                txtAgenciaDescricao.Enabled = false;
            }
        }

        //Fecha o formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //KeyPress Numero conta permitir apenas numeros
        private void txtNumeroConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtNumeroConta);

        }

        //Ao confirmar seleção no combo atualiza a descrição
        private void cmbNumeroBanco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbNumeroBanco.Text != "")
            {
                loadDescbanco();
                txtNomeBanco.Enabled = false;
            }
        }

        //Ao sair  atualiza o campo descrição do banco
        private void cmbNumeroBanco_Leave(object sender, EventArgs e)
        {
            if (cmbNumeroBanco.Text != "")
            {
                loadDescbanco();
                txtNomeBanco.Enabled = false;
            }
        }

        //Ao sair  atualiza o campo descrição da agencia
        private void cmbAgenciaNumero_Leave(object sender, EventArgs e)
        {
            if (cmbAgenciaNumero.Text != "")
            {
                loadDescAgencia();
                txtAgenciaDescricao.Enabled = false;
            }

        }

        //Keypress do campo saldo inicial da conta (aceita somente numeros
        private void txtSaldoConta_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar valida = new Validar();
            valida.valCampoNumero(e, txtSaldoConta);

        }

    }
}
