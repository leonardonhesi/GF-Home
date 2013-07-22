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
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        //Carrega o grid
        public object carregagrid()
        {
            try
            {
                //Carrega as variaveis utilizadas nas consultas
                DateTime dtaInicial = Convert.ToDateTime(dtpInicial.Text).Date;
                DateTime dtaFinal = Convert.ToDateTime(dtpFinal.Text).Date;

                //Lista que será retornada caso exista lançamento
                List<object> listaRetorno = new List<object>();

                //Obtem o saldo inicial de todas as contas
                decimal saldo = 0;
                using (var objGerenciador = new dbGerenciadorEntities())
                {
                    
                    var saldoTodasContas = (from conta in objGerenciador.Conta
                                 select conta.saldo);
                    var ListaSaldoInicial = saldoTodasContas.ToList();

                    foreach (decimal sInicial in ListaSaldoInicial)
                    {

                        saldo += sInicial;
                    
                    }
                }
                
                
                
                //Obtem todos os lançamentos com as datas menores a data incial do filtro  
                using (var objSaldoAnterior = new dbGerenciadorEntities())
                {

                    var qSaldoAnterior = from sTitulo in objSaldoAnterior.Titulo
                                         where (sTitulo.vencimento < dtaInicial)
                                         orderby sTitulo.vencimento
                                         select sTitulo;
                    var ListaSaldoAnterior = qSaldoAnterior.ToList();


                    //Percorre os movimentos atualizando o saldo obtido da conta em questão
                    foreach (Titulo calcSaldoInicial in ListaSaldoAnterior)
                    {
                        //Esta variavel será o saldo inicial do periodo selecionado
                        saldo += calcSaldoInicial.valor;

                    }

                    //Define a label com o valor do saldo anterior  
                    lblSaldoInicial.Text = string.Format("{0:C}", saldo);


                    //Obtem os lançamentos de acordo com a conta a data inicial e final
                    using (var objObtemMovimento = new dbGerenciadorEntities())
                    {
                        var queryMovimento = (from titulo in objObtemMovimento.Titulo
                                              where (titulo.vencimento <= dtaFinal && titulo.vencimento >= dtaInicial)
                                              orderby titulo.vencimento
                                              select titulo).ToList();


                        //Percorre os movimentos filtrados criando objetos personalizados 
                        foreach (Titulo calculoFinal in queryMovimento)
                        {

                            saldo += calculoFinal.valor;

                            var objRetorno = new

                            {

                                calculoFinal.vencimento,
                                calculoFinal.numero,
                                calculoFinal.descricao,
                                calculoFinal.valor,
                                saldo

                            };

                            //Atualiza a situação saldo final
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
            catch (Exception ex)
            {
                List<Titulo> lstVazia = new List<Titulo>();
                MessageBox.Show("Erro: " + ex.Message);
                return lstVazia;

            }




        }

        //Load do formulario
        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            //Carrega as datas atuais
            dtpInicial.Value = DateTime.Now.Date;
            dtpFinal.Value = DateTime.Now.Date;

        }

        //Botão ok pesquisa
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpFinal.Text) < Convert.ToDateTime(dtpInicial.Text))
            {
                //Data final não pode se menor que data Inicial
                MessageBox.Show("Data final não pode ser menor que a data Inicial", "Aviso");

            }
            else
            {

                //Realiza os procedimentos para carregar o grid

                dtgFluxo.AutoGenerateColumns = false;
                dtgFluxo.DataSource = carregagrid();
                dtgFluxo.Columns[3].DefaultCellStyle.Format = "C";
                dtgFluxo.Columns[4].DefaultCellStyle.Format = "C";
            }

        }

    }
}
