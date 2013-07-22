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
    public partial class frmCadBanco : Form
    {

        private int _numero;
        private String _descricao;
        private bool _altera;
        
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public String Descricao
        {

            get { return _descricao; }
            set { _descricao = value; }
        
        }
        public bool Altera
        {
            get { return _altera; }
         set { _altera = value;}
        
        }

       
        //Construtor padrão
        public frmCadBanco()
        {
            InitializeComponent();
            
            
            
        }

        //Confirmar gravação no banco
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Chamar a função de validação dos campos
            Validar valida = new Validar();
            if (valida.valCampoVazio(this.Controls) == true)
            {
                if (_altera == false)
                {
                    //Incluir
                    Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                    var objBanco = new Gerenciador.Data.Banco();

                    objBanco.numero = Convert.ToInt32(txtNumeroBanco.Text);
                    objBanco.descricao = txtNomeBanco.Text;
                    objGerenciador.AddToBanco(objBanco);
                    objGerenciador.SaveChanges();

                    MessageBox.Show("Banco Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                    this.Close();
                }
                
                    //Alterar
                else
                {
                    using (var objGerenciador = new dbGerenciadorEntities())
                    {


                        var objBanco = new Gerenciador.Data.Banco();
                        objBanco = (from conv in objGerenciador.Banco
                                    where conv.numero == _numero
                                    select conv).First();

                        objBanco.descricao = txtNomeBanco.Text ;
                        objBanco.numero = Convert.ToInt32(txtNumeroBanco.Text);
                        objGerenciador.SaveChanges();

                        MessageBox.Show("Banco Alterado com sucesso!", "Cadastro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                        this.Close();
                    }


                }

            }
        }

        //Cancelar fecha o formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Keypress Permite apenas numero no campo numero do banco
        private void txtNumeroBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtNumeroBanco);
        }

        //Load do form define se é alteração 
        private void frmCadBanco_Load(object sender, EventArgs e)
        {
            //Se vier para alterar já preenche os campos
            if (_altera == true)
            {
                txtNomeBanco.Text = _descricao;
                txtNumeroBanco.Text = Convert.ToString(_numero);
                btnConfirmar.Text = "Alterar";
            }

        }
    }
}
