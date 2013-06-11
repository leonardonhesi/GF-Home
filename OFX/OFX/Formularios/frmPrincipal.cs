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
using OFX.Classes;
using OFX.Formularios.Cadastros;



namespace OFX.Formularios
{
    public partial class frmPrincipal : Form
    {
        //Construtor classe
        public frmPrincipal()
        {

            InitializeComponent();
            
        }

        //Importar arquivo OFX - Inicio
        private void arquivoOFXToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //abiriOFX
            abiriOFX.Filter = "Arquivos OFX (*.ofx)|*.ofx";
            if (abiriOFX.ShowDialog() == DialogResult.OK)
            {
                String nomeArquivo = abiriOFX.FileName;

                try
                {

                    OFX_Extrato extrato = ofxtoXml.Parser.getExtrato(nomeArquivo);


                    if (extrato != null)
                    {

                        //Inicia a classe conciliação
                        Concilia cConcilia = new Concilia();
                        cConcilia.AgConta = extrato.Conta.nConta;
                        cConcilia.Movimentos = extrato.Movimento;

                        //Verifica se a conta do OFX existe no banco
                        if (cConcilia.verConta() == true)
                        {

                            //Conta existe verifica se a data dos lançamentos são menores que a
                            //data de criação do saldo da conta

                            if (cConcilia.verDtLancamento() == true)
                            {
                                //Inicia a conciliação
                                cConcilia.startConc();
                            }

                            else
                            {

                                MessageBox.Show("No arquivo OFX existem lançamentos anteriores a data do saldo inicial da conta", "Aviso");
                            }
                        }
                        else
                        {

                            MessageBox.Show("Conta não existe");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "  Verificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }


        }

        //Formulario de cadastro de Contas
        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmCadConta>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Contas já está aberto!", "Aviso");
            }
            else
            {
                frmCadConta menuCadContas = new frmCadConta();
                menuCadContas.MdiParent = this;
                menuCadContas.Show();
            }
        }

        //Formulario de cadastro Natureza
        private void naturezasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadNatureza>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Naturezas já está aberto!", "Aviso");
            }
            else
            {
                frmCadNatureza menuCadNatureza = new frmCadNatureza();
                menuCadNatureza.MdiParent = this;
                menuCadNatureza.Show();
            }
        }

        //Formulario de cadastro Relação
        private void relaçõesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadRelacao>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Relações já está aberto!", "Aviso");
            }
            else
            {
                frmCadRelacao menuCadRelacao = new frmCadRelacao();
                menuCadRelacao.MdiParent = this;
                menuCadRelacao.Show();
            }

        }

        //Cadastro de títulos
        private void títulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmCadTitulo>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Títulos já está aberto!", "Aviso");
            }
            else
            {
                frmCadTitulo menuCadTitulo = new frmCadTitulo(DateTime.Now);
                menuCadTitulo.MdiParent = this;
                menuCadTitulo.Show();
            }

        }

        //Mostra os titulos
        private void títulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmManterTitulo>().Count() > 0)
            {
                MessageBox.Show("Formulario de titulos já está aberto!", "Aviso");
            }
            else
            {
                frmManterTitulo telaManterTitulo = new frmManterTitulo();
                telaManterTitulo.MdiParent = this;
                telaManterTitulo.Show();
            }

        }

        //Mostra a DashBoard com os resumos
        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmDashBoard>().Count() > 0)
            {
                MessageBox.Show("DashBoard já está aberta!", "Aviso");
            }
            else
            {
                frmDashBoard telaDashBoard = new frmDashBoard();
                telaDashBoard.MdiParent = this;
                telaDashBoard.Show();
            }


        }

        //Devolve true ou false verificando se existe conta cadastrada 
        public bool temConta()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {

                var qContas = from contas in objGerenciador.Conta
                              select contas;
                var ListaFinal = qContas.ToList();

                if (ListaFinal.Count == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //Verifica se precisa do assistente de primeira execução
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Verifica se temos ao menos uma conta cadastrada

            if (temConta() == false)
            {
                //Se não tiver conta cadastrada oferece a oportunidade de cadastrar uma
                if (MessageBox.Show("Nenhuma conta está cadastrada, gostaria de cadastrar uma?", "Aviso", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Application.OpenForms.OfType<frmCadConta>().Count() > 0)
                    {
                        MessageBox.Show("Cadastro de Contas já está aberto!", "Aviso");
                    }
                    else
                    {
                        frmCadConta menuCadContas = new frmCadConta();
                        menuCadContas.MdiParent = this;
                        menuCadContas.Show();
                    }
                }

            }

            else
            {

                //Ao inciar já abre a tela de Manter Titulos
                frmManterTitulo manterTitulo = new frmManterTitulo();
                manterTitulo.MdiParent = this;
                manterTitulo.Show();
            }
        }

        //Abre o menu para exibir o extrato
        private void extratoPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExtrato>().Count() > 0)
            {
                MessageBox.Show("Extrato já está aberto!", "Aviso");
            }
            else
            {
                frmExtrato telaExtrato = new frmExtrato();
                telaExtrato.MdiParent = this;
                telaExtrato.Show();
            }
        }

        //Abre o menu totalizador por natureza
        private void relátorioNaturezazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTotalNatureza>().Count() > 0)
            {
                MessageBox.Show("Tela totalizadora de naturezas já está aberta!", "Aviso");
            }
            else
            {
                frmTotalNatureza telaTotalNatureza = new frmTotalNatureza();
                telaTotalNatureza.MdiParent = this;
                telaTotalNatureza.Show();
            }

        }

        //Abre o menu Fluxo de caixa
        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFluxoCaixa>().Count() > 0)
            {
                MessageBox.Show("Formulario fluxo de caixa já está aberto!", "Aviso");
            }
            else
            {
                frmFluxoCaixa telaFluxoCaixa = new frmFluxoCaixa();
                telaFluxoCaixa.MdiParent = this;
                telaFluxoCaixa.Show();
            }


        }

        //Abre o menu Sobre
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Sobre>().Count() > 0)
            {
                MessageBox.Show("Formulario sobre já está aberto!", "Aviso");
            }
            else
            {
                Sobre telaSobre = new Sobre();
                telaSobre.MdiParent = this;
                telaSobre.Show();
            }

        }

        //Abre o menu manutenção de contas
        private void contasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmManterContas>().Count() > 0)
            {
                MessageBox.Show("Formulario manutenção de contas já está aberto!", "Aviso");
            }
            else
            {
                frmManterContas telaManterContas = new frmManterContas();
                telaManterContas.MdiParent = this;
                telaManterContas.Show();
            }


        }
        
        //Abre o formulario para cadastrar e-mails
        private void cadastrarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadEmail>().Count() > 0)
            {
                MessageBox.Show("Formulario de cadastro de E-mail já está aberto!", "Aviso");
            }
            else
            {
                frmCadEmail telaCadEmail = new frmCadEmail();
                telaCadEmail.MdiParent = this;
                telaCadEmail.Show();
            }


        }

        //Abre o formulario de envio de e-mail
        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEnviaEmail>().Count() > 0)
            {
                MessageBox.Show("Formulario de cadastro de E-mail já está aberto!", "Aviso");
            }
            else
            {
                frmEnviaEmail telaEnvEmail = new frmEnviaEmail();
                telaEnvEmail.MdiParent = this;
                telaEnvEmail.Show();
            }


        }

        //Abre cadastro de usuarios
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmCadUsuario>().Count() > 0)
            {
                MessageBox.Show("Formulario de cadastro de Usuários já está aberto!", "Aviso");
            }
            else
            {
                frmCadUsuario telaCadUsuario = new frmCadUsuario();
                telaCadUsuario.MdiParent = this;
                telaCadUsuario.Show();
            }

        }

    }
}
