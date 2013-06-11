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
    public partial class frmDashBoard : Form
    {

        public frmDashBoard()
        {
            InitializeComponent();
        }
        //Função que retorna list com os titulos vencidos
        public object carregaVencidos()
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    DateTime hoje = DateTime.Now.Date;
                    var query = from conv in objGerenciador.Titulo
                                join convRel in objGerenciador.Relacao on
                                conv.relacao equals convRel.id
                                where (conv.vencimento < hoje && conv.baixado == null) //Menores que hoje e não baixados
                                select new
                                {

                                    conv.vencimento,
                                    relacao = (convRel.Nome),
                                    conv.valor,
                                    conv.natureza,
                                    conv.descricao,

                                };


                    var ListaFinal = query.ToList();

                    if (ListaFinal.Count != 0)
                    {
                        return ListaFinal;
                    }

                    else
                    {
                        //Devolve uma lista vazia
                        List<Titulo> lstVazia = new List<Titulo>();
                        return lstVazia;
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

        //Função que retorna list com os titulos a vencer data atual até 5 dias
        public object carregaProximosVctos()
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    DateTime dtFinal = DateTime.Now.AddDays(6).Date;
                    DateTime dtHoje = DateTime.Now.Date;

                    var query = from conv in objGerenciador.Titulo
                                join convRel in objGerenciador.Relacao on
                                conv.relacao equals convRel.id
                                where (conv.vencimento >= dtHoje && conv.vencimento < dtFinal
                                && conv.tipo == "FORNECEDOR" && conv.baixado == null)

                                select new
                                {
                                    conv.vencimento,
                                    relacao = (convRel.Nome),
                                    conv.valor

                                };




                    var ListaFinal = query.ToList();

                    if (ListaFinal.Count != 0)
                    {
                        return ListaFinal;
                    }

                    else
                    {
                        List<Titulo> lstVazia = new List<Titulo>();
                        return lstVazia;
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

        //Função que retorna lista com o titulos a receber data atual até 5 dias
        public object carregaProximoRctos()
        {

            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    DateTime dtFinal = DateTime.Now.AddDays(6).Date;
                    DateTime hoje = DateTime.Now.Date;
                    var query = from conv in objGerenciador.Titulo
                                join convRel in objGerenciador.Relacao on
                                conv.relacao equals convRel.id
                                where (conv.vencimento >= hoje && conv.vencimento < dtFinal
                                && conv.tipo == "CLIENTE" && conv.baixado == null)

                                select new
                                {
                                    conv.vencimento,
                                    relacao = (convRel.Nome),
                                    conv.valor

                                };

                    var ListaFinal = query.ToList();

                    if (ListaFinal.Count != 0)
                    {
                        return ListaFinal;
                    }

                    else
                    {
                        List<Titulo> lstVazia = new List<Titulo>();
                        return lstVazia;
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

        //Obtem as estimativas de saldo diponivel considerando os titulos
        public void calculaSaldo()
        {
            decimal somaSaldo = 0;
            decimal somaTituloMes = 0;
            decimal somaTituloAno = 0;

            //Percorre o saldo das contas no datagridview
            foreach (DataGridViewRow linha in dtgSaldoContas.Rows)
            {

                somaSaldo = somaSaldo + Convert.ToDecimal(linha.Cells[4].Value);

            }



            //Obtem o valor dos titulos de um mês
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                DateTime umMes = DateTime.Now.AddMonths(1).Date;

                var qTituloMes = from tituloMes in objGerenciador.Titulo
                                 where (tituloMes.vencimento <= umMes && tituloMes.baixado == null)
                                 select tituloMes.valor;
                var ListaTituloMes = qTituloMes.ToList();

                if (ListaTituloMes.Count != 0)
                {
                    foreach (Decimal tit in ListaTituloMes)
                    {
                        somaTituloMes += tit;

                    }
                }
            }

            //Obtem o valor dos titulos de um ano
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                DateTime umAno = DateTime.Now.AddYears(1).Date;

                var qTituloAno = from tituloAno in objGerenciador.Titulo
                                 where (tituloAno.vencimento <= umAno && tituloAno.baixado == null)
                                 select tituloAno.valor;
                var ListaTituloAno = qTituloAno.ToList();

                if (ListaTituloAno.Count != 0)
                {

                    foreach (Decimal tit in ListaTituloAno)
                    {
                        somaTituloAno += tit;

                    }

                }
            }


            lblProximo.Text = string.Format("{0:C}", (somaSaldo + somaTituloMes));
            lblAno.Text = string.Format("{0:C}", (somaSaldo + somaTituloAno));
        }

        //Função que retorna os saldos das contas
        public List<object> saldoContas()
        {
            //Lista guarda as contas e os saldos ela que será retornada
            List<object> saldoContas = new List<object>();

            using (var objGerenciador = new dbGerenciadorEntities())
            {
                //Selecionar todas as contas
                var contas = from conta in objGerenciador.Conta
                             select conta;
                var ListaContas = contas.ToList();

                //Verifica se retornou alguma conta
                if (ListaContas.Count != 0)
                {

                    //Percorre cada conta
                    foreach (Conta loopConta in ListaContas)
                    {

                        //Obtem numero do banco

                        //Variavel que obtem o numero do banco
                        int bancoNome;

                        using (var objNumeroBanco = new dbGerenciadorEntities())
                        {
                            var queryNomeBanco = from nomeBanco in objNumeroBanco.Banco
                                                 join agencia in objNumeroBanco.Agencia on
                                                 nomeBanco.numero equals agencia.banco
                                                 where (agencia.numero == loopConta.agencia)
                                                 select nomeBanco.numero;

                            var listaNome = queryNomeBanco.ToList();
                            bancoNome = listaNome[0];

                        }


                        //Verifica se a conta tem movimento
                        using (var objTemMovimento = new dbGerenciadorEntities())
                        {

                            var query = from mov in objTemMovimento.Movimento
                                        where (mov.conta == loopConta.numero)
                                        select mov;
                            var ListaTemMovimento = query.ToList();

                            //Se tiver movimento
                            if (ListaTemMovimento.Count != 0)
                            {


                                //Começo quando tem movimento
                                using (var objSaldoConta = new dbGerenciadorEntities())
                                {
                                    //Obter saldos das contas

                                    var querySaldo = from movimento in objSaldoConta.Movimento
                                                     where (movimento.conta == loopConta.numero)
                                                     group movimento.valor by movimento.conta into tSaldo

                                                     select new
                                                     {
                                                         banco = bancoNome,
                                                         loopConta.agencia,
                                                         loopConta.numero,
                                                         loopConta.descricao,
                                                         saldo = (loopConta.saldo + tSaldo.Sum(movimento => movimento))

                                                     };

                                    saldoContas.Add(querySaldo.First());

                                }//Fim quando tem movimento    
                            }
                            //Quando a conta não tem movimento devolve o saldo
                            else
                            {
                                var retornoPadrao = new
                                {
                                    banco = bancoNome,
                                    loopConta.agencia,
                                    loopConta.numero,
                                    loopConta.descricao,
                                    loopConta.saldo

                                };

                                saldoContas.Add(retornoPadrao);

                            }

                        }

                    }
                }//Fim do if que verifica as contas(se existem)
            }//Fim primeiro using

            return saldoContas;

        }

        //Carrega/Atualiza todos os grids do formulario
        private void carregaGrids()
        {
            //Carrega datagrid Vencidos
            dtgAtrasados.AutoGenerateColumns = false;
            dtgAtrasados.DataSource = carregaVencidos();
            dtgAtrasados.Columns[2].DefaultCellStyle.Format = "C";

            //Carrega datagrid Proximos vencimento
            dtgPagamentos.AutoGenerateColumns = false;
            dtgPagamentos.DataSource = carregaProximosVctos();
            dtgPagamentos.Columns[2].DefaultCellStyle.Format = "C";

            //Carrega datagrid Proximos recebimentos
            dtgRecebimentos.AutoGenerateColumns = false;
            dtgRecebimentos.DataSource = carregaProximoRctos();
            dtgRecebimentos.Columns[2].DefaultCellStyle.Format = "C";

            //Carrega os saldos sas contas
            dtgSaldoContas.AutoGenerateColumns = false;
            try
            {
                dtgSaldoContas.DataSource = saldoContas();
                dtgSaldoContas.Columns[4].DefaultCellStyle.Format = "C";
                //Carrega saldo total considerando titulos
                calculaSaldo();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        //Carrega o formulario
        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            carregaGrids();
        }

        //Botão que atualiza os grids sem precisar fechar e abrir o formulario
        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            carregaGrids();
        }



    }
}
