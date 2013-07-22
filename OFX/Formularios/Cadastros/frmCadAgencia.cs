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
    public partial class frmCadAgencia : Form
    {
        private int _numeroAG;
        private int _numeroBanco;
        private string _descrAgencia;
        private bool _altera;
        
        public int NumeroAG
        {
            get { return _numeroAG; }
            set { _numeroAG = value; }
        }
        public int NumeroBanco
        {
            get { return _numeroBanco; }
            set { _numeroBanco = value; }
        }
        public string Descragencia
        {
            get { return _descrAgencia; }
            set { _descrAgencia = value; }
        }
        public bool Alterar
        {
            get { return _altera; }
            set { _altera = value; }
        }


        //Novo construtor
        public frmCadAgencia(string Banco)
        {

            //Se tiver parametro carrega o combo com o banco
            InitializeComponent();

            if (Banco != "")
            {
                cmbBancoCadAgencia.Text = Banco;
                cmbBancoCadAgencia.Enabled = false;
            }

            //Se não tiver parametro carrega todos os bancos no combo
            else
            {

                loadcmbAgencia();
            }

        }

        //Carrega todos os bancos no combo
        public void loadcmbAgencia()
        {
            //Realiza a busca no banco
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                var qBanco = from banco in objGerenciador.Banco
                             select banco;

                var ListaBanco = qBanco.ToList();

                //Verifica se tem retorno
                if (ListaBanco.Count == 0)
                {
                    //Se não tiver retorno oferece oportunidade de cadastrar um banco
                    if (MessageBox.Show("Nenhum banco está cadastrado" + Environment.NewLine +
                                    "Gostaria de cadastrar o banco agora?", "Aviso",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                                    == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadBanco cadBanco = new frmCadBanco();
                        cadBanco.ShowDialog();
                        loadcmbAgencia();
                    }
                }

                else
                {
                    //Se tiver o banco preenche combobox com os nomes dos bancos
                    cmbBancoCadAgencia.DataSource = ListaBanco;
                    cmbBancoCadAgencia.DisplayMember = "numero";
                    cmbBancoCadAgencia.ValueMember = "numero";


                }
            }

        }

        //Confirma e grava agência no banco
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //Chamar a função de validação dos campos (validação centralizada em uma classe)
            Validar valida = new Validar();

            if (valida.valCampoVazio(this.Controls) == true)
            {

                //Incluir
                if (_altera == false)
                {

                    Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                    var objAgencia = new Gerenciador.Data.Agencia();

                    objAgencia.numero = Convert.ToInt32(txtNumeroAgencia.Text);
                    objAgencia.banco = Convert.ToInt32(cmbBancoCadAgencia.Text);
                    objAgencia.descricao = txtDescAgencia.Text;

                    objGerenciador.AddToAgencia(objAgencia);
                    objGerenciador.SaveChanges();

                    MessageBox.Show("Agência Cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                     MessageBoxDefaultButton.Button2);
                    this.Close();
                }
                //ALTERAR
                else
                {
                    using (var objGerenciador = new dbGerenciadorEntities())
                    {


                        var objAgencia = new Gerenciador.Data.Agencia();
                        objAgencia = (from conv in objGerenciador.Agencia
                                    where conv.numero == _numeroAG
                                    select conv).First();

                        objAgencia.numero = Convert.ToInt32(txtNumeroAgencia.Text) ;
                        objAgencia.banco = Convert.ToInt32(cmbBancoCadAgencia.Text);
                        objAgencia.descricao = txtDescAgencia.Text;
                        objGerenciador.SaveChanges();

                        MessageBox.Show("Agência alterada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                     MessageBoxDefaultButton.Button2);
                        this.Close();
                    }
                
                
                }
            }
        }

        //Fechar o formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //KeyPress - permitir apenas numeros no campo Numero da Agência
        private void txtNumeroAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chama a classe validação centralizada
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtNumeroAgencia);
        }

        //Load verifica se o formulario será para alteração
        private void frmCadAgencia_Load(object sender, EventArgs e)
        {
            if (_altera == true)
            {
                loadcmbAgencia();
                cmbBancoCadAgencia.Text = Convert.ToString(_numeroBanco);
                txtNumeroAgencia.Text = Convert.ToString(_numeroAG);
                txtDescAgencia.Text = _descrAgencia;
                btnConfirmar.Text = "Alterar";
            }
        }


    }
}
