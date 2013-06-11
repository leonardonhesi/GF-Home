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


namespace OFX.Formularios
{
    public partial class frmExtrato : Form
    {
        public frmExtrato()
        {
            InitializeComponent();
        }

        //Função carrega o combo com as contas cadastradas
        private void carregaComboConta()
        {

            using (var objGerenciador = new dbGerenciadorEntities())
            {

                var qConta = from conta in objGerenciador.Conta
                             select conta;
                var ListaConta = qConta.ToList();


                cmbContaExtrato.DataSource = ListaConta;
                cmbContaExtrato.DisplayMember = "numero";
                cmbContaExtrato.ValueMember = "numero";


            }
        }

        //Função para obter o extrato
        public object carregagrid()
        {
            try
            {
                //Carrega as variaveis utilizadas nas consultas
                DateTime dtaInicial = Convert.ToDateTime(dtpInicial.Text).Date;
                DateTime dtaFinal = Convert.ToDateTime(dtpFinal.Text).Date;

                //Lista que serpa retornada caso exista lançamento
                List<object> listaRetorno = new List<object>();

                //Obtem o saldo inicial da conta
                using (var objGerenciador = new dbGerenciadorEntities())
                {
                    int nrConta = Convert.ToInt32(cmbContaExtrato.SelectedValue);

                    var saldo = (from conta in objGerenciador.Conta
                                 where (conta.numero == nrConta)
                                 select conta.saldo).First();

                    //Define a label com o valor do saldo anterior  
                    lblSaldoInicial.Text = string.Format("{0:C}", saldo);


                    //Obtem todos os lançamentos com as datas menores a data incial do filtro
                    //Obtendo o saldo anterior
                    using (var objSaldoAnterior = new dbGerenciadorEntities())
                    {

                        var qSaldoAnterior = from sMovimento in objSaldoAnterior.Movimento
                                             where (sMovimento.data < dtaInicial)
                                             orderby sMovimento.data
                                             select sMovimento;
                        var ListaSaldoAnterior = qSaldoAnterior.ToList();


                        //Percorre os movimentos atualizando o saldo obtido da conta em questão
                        foreach (Movimento calcSaldoInicial in ListaSaldoAnterior)
                        {
                            //Esta variavel será o saldo inicial do periodo selecionado
                            saldo += calcSaldoInicial.valor;

                        }


                        //Obtem os lançamentos de acordo com a conta a data inicial e final
                        using (var objObtemMovimento = new dbGerenciadorEntities())
                        {
                            var queryMovimento = (from movimento in objObtemMovimento.Movimento
                                                  where (movimento.conta == nrConta &&
                                                  movimento.data <= dtaFinal && movimento.data >= dtaInicial)
                                                  orderby movimento.data
                                                  select movimento).ToList();


                            //Percorre os movimentos filtrados criando objetos personalizados 
                            foreach (Movimento calculoFinal in queryMovimento)
                            {

                                saldo += calculoFinal.valor;

                                var objRetorno = new

                                 {

                                     calculoFinal.data,
                                     calculoFinal.numero,
                                     calculoFinal.descricao,
                                     calculoFinal.valor,
                                     saldo

                                 };
                                
                                //Define label com o saldo final
                                lblSaldoFinal.Text = string.Format("{0:C}", saldo);
                                
                                //Adiciona na lista de retorno  
                                listaRetorno.Add(objRetorno);

                            }



                            if (listaRetorno.Count != 0)
                            {
                                return listaRetorno;
                            }

                            else
                            {
                                List<Titulo> lstVazia = new List<Titulo>();
                                return lstVazia;
                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                List<Titulo> lstVazia = new List<Titulo>();
                MessageBox.Show("Erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                return lstVazia;

            }




        }

        //Load do form
        private void frmExtrato_Load(object sender, EventArgs e)
        {
            //Carrega as datas atuais
            dtpInicial.Value = DateTime.Now.Date;
            dtpFinal.Value = DateTime.Now.Date;
            carregaComboConta();
        }

        //Botão pesquisa
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (Convert.ToDateTime(dtpFinal.Text) < Convert.ToDateTime(dtpInicial.Text))
            {
                //Data final não pode se menor que data Inicial
                MessageBox.Show("Data final não pode ser menor que a data Inicial !", "Aviso");

            }
            else
            {

                //Realiza os procedimentos para carregar o grid
                dtgExtrato.AutoGenerateColumns = false;
                dtgExtrato.DataSource = carregagrid();
                dtgExtrato.Columns[3].DefaultCellStyle.Format = "C";
                dtgExtrato.Columns[4].DefaultCellStyle.Format = "C";
            }

        }
    }
}
