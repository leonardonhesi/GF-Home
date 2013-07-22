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
using OFX.Formularios.Cadastros;


namespace OFX.Formularios
{
    public partial class frmManterContas : Form
    {
        public frmManterContas()
        {
            InitializeComponent();
        }

        //Devolve uma lista com os bancos cadastrados
        public List<Banco> gridBanco()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                var qBanco = from banco in objGerenciador.Banco
                             select banco;

                var ListaBanco = qBanco.ToList();

                //Verifica se houve retorno
                if (ListaBanco.Count == 0)
                {
                    //Não tem banco devolve lista em branco
                    List<Banco> listaVazia = new List<Banco>();
                    return listaVazia;
                }

                else
                {
                    return ListaBanco;
                }
            }




        }

        //Devolve uma lista com as agências cadastradas
        public List<Agencia> gridAgencia()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                var qAgencia = from pAgencia in objGerenciador.Agencia
                               select pAgencia;

                var ListaAgencia = qAgencia.ToList();

                //Verifica se houve retorno
                if (ListaAgencia.Count == 0)
                {
                    //Não tem banco devolve lista em branco
                    List<Agencia> listaVazia = new List<Agencia>();
                    return listaVazia;
                }

                else
                {
                    return ListaAgencia;
                }

            }

        }

        //Devolve uma lista com as contas cadastradas
        public List<Conta> gridConta()
        {

            using (var objGerenciador = new dbGerenciadorEntities())
            {
                var qConta = from pConta in objGerenciador.Conta
                             select pConta;

                var ListaConta = qConta.ToList();

                //Verifica se houve retorno
                if (ListaConta.Count == 0)
                {
                    //Não tem banco devolve lista em branco
                    List<Conta> listaVazia = new List<Conta>();
                    return listaVazia;
                }

                else
                {
                    return ListaConta;
                }

            }



        }

        //Carrega os grids
        public void carregaGrids()
        {
            dtgBanco.AutoGenerateColumns = false;
            dtgAgencia.AutoGenerateColumns = false;
            dtgConta.AutoGenerateColumns = false;

            dtgBanco.DataSource = gridBanco();
            dtgAgencia.DataSource = gridAgencia();
            dtgConta.DataSource = gridConta();
            dtgConta.Columns[3].DefaultCellStyle.Format = "C";
        }

        //Carrega o load do form
        private void frmManterContas_Load(object sender, EventArgs e)
        {
            carregaGrids();

        }

        //Botão incluir da Conta
        private void btnIncluirConta_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadConta>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Contas já está aberto!", "Aviso");
            }
            else
            {
                frmCadConta menuCadContas = new frmCadConta();
                menuCadContas.ShowDialog();
                carregaGrids();
            }
        }

        //Editar Banco
        private void btnEditarBanco_Click(object sender, EventArgs e)
        {
            frmCadBanco editarBanco = new frmCadBanco();
            
            foreach (DataGridViewRow linha in dtgBanco.SelectedRows)
            {
                editarBanco.Descricao = Convert.ToString(linha.Cells[1].Value);
                editarBanco.Numero = Convert.ToInt32(linha.Cells[0].Value);
            }

            editarBanco.Altera = true;

            try
            {
                editarBanco.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            
            }
            carregaGrids();
        
        }

        //Editar agência
        private void btnEditarAgencia_Click(object sender, EventArgs e)
        {
            frmCadAgencia editarAgencia = new frmCadAgencia("");

            foreach (DataGridViewRow linha in dtgAgencia.SelectedRows)
            {
                editarAgencia.NumeroAG = Convert.ToInt32(linha.Cells[0].Value);
                editarAgencia.NumeroBanco = Convert.ToInt32(linha.Cells[1].Value);
                editarAgencia.Descragencia = Convert.ToString(linha.Cells[2].Value);
            }

            editarAgencia.Alterar = true;

            try
            {
                editarAgencia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
            carregaGrids();

        }

        //Excluir Banco
        private void btnExcluirBanco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir o banco selecionado?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow linha in dtgBanco.SelectedRows)
                    {
                        int idBanco = Convert.ToInt32(linha.Cells[0].Value);

                        using (var objGerenciador = new dbGerenciadorEntities())
                        {
                            var mensagem = (from deleteBanco in objGerenciador.Banco
                                            where (deleteBanco.numero == idBanco)
                                            select deleteBanco).First();

                            objGerenciador.DeleteObject(mensagem);
                            objGerenciador.SaveChanges();
                            carregaGrids();
                            MessageBox.Show("Banco excluido!", "Aviso");

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Aviso");

                }
            }
        }

        //Excluir Agência
        private void btnExcluirAgencia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir a agência selecionado?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow linha in dtgAgencia.SelectedRows)
                    {
                        int idAgencia = Convert.ToInt32(linha.Cells[0].Value);

                        using (var objGerenciador = new dbGerenciadorEntities())
                        {
                            var mensagem = (from deleteAgencia in objGerenciador.Agencia
                                            where (deleteAgencia.numero == idAgencia)
                                            select deleteAgencia).First();

                            objGerenciador.DeleteObject(mensagem);
                            objGerenciador.SaveChanges();
                            carregaGrids();
                            MessageBox.Show("Agência excluida!", "Aviso");

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Aviso");

                }
            }
        }

        //Excluir conta
        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir a conta selecionado?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {

                    foreach (DataGridViewRow linha in dtgConta.SelectedRows)
                    {
                        int idConta = Convert.ToInt32(linha.Cells[0].Value);

                        using (var objGerenciador = new dbGerenciadorEntities())
                        {
                            var mensagem = (from deleteConta in objGerenciador.Conta
                                            where (deleteConta.numero == idConta)
                                            select deleteConta).First();

                            objGerenciador.DeleteObject(mensagem);
                            objGerenciador.SaveChanges();
                            carregaGrids();
                            MessageBox.Show("Conta excluida!", "Aviso");

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message , "Aviso");

                }
            }


        }



    }
}