using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Gerenciador.Data;
using System.Data.Entity;
using OFX.Formularios;
using OFX.OFX.Classes;
using System.Windows.Forms;
using OFX.Formularios.Cadastros;

namespace OFX.Classes
{
    class Concilia
    {
        private string agConta;
        private ArrayList movimentos;


        public String AgConta
        {
            get { return agConta; }
            set { agConta = value; }
        }

        public ArrayList Movimentos
        {
            get { return movimentos; }
            set { movimentos = value; }
        }

        List<frmConcilia.Conciliado> lstConciliado = new List<frmConcilia.Conciliado>();

        //Verifica se a conta do OFX existe (TRUE FALSE)
        public bool verConta()
        {

            using (var objGerenciador = new dbGerenciadorEntities())
            {
                //agência e conta vem em uma unica string agencia/conta fiz split para obter separado
                string[] split = agConta.Split('/');

                //Depois do split realiza a conversão para inteiro
                int agencia = Convert.ToInt32(split[0]);
                int conta = Convert.ToInt32(split[1]);

                var query = from conv in objGerenciador.Conta
                            where (conv.numero == conta && conv.agencia == agencia)
                            select conv;
                var ListaFinal = query.ToList();


                if (ListaFinal.Count == 0)
                {
                    return false;

                }
                else
                {

                    return true;
                }
            }


        }

        //Função para conciliar  
        public void startConc()
        {

            //Percorrer todos os movimentos
            foreach (OFX_Movimento mov in movimentos)
            {
                //Verificar se a data do movimento maior data atual evitando 
                //lançamentos futuros do extrato
                if (mov.Data.Date <= DateTime.Now.Date)
                {

                    //Verifica se já não existe o movimento evitando duplicidade
                    Decimal valor = Convert.ToDecimal(mov.Valor);

                    using (var objVerExiste = new dbGerenciadorEntities())
                    {
                        //FALTOU TESTAR - QUANDO INCLUIR MOVIMENTO
                        var query = from conv in objVerExiste.Movimento
                                    where (conv.data == mov.Data.Date && conv.valor == valor && conv.descricao == mov.Descricao)
                                    select conv;
                        var ListaFinal = query.ToList();

                        //Não tem duplicidade
                        if (ListaFinal.Count == 0)
                        {
                            using (var objPesqVctoValor = new dbGerenciadorEntities())
                            {
                                //Primeira pesquisa por Vencimento e Valor
                                var queryTitulo = from titulo in objPesqVctoValor.Titulo
                                                  join relacao in objPesqVctoValor.Relacao on
                                                      titulo.relacao equals relacao.id
                                                  where (titulo.vencimento == mov.Data.Date && titulo.valor == valor && titulo.baixado == null)
                                                  select new
                                                  {
                                                      titulo.id,
                                                      titulo.numero,
                                                      relacao.Nome,
                                                      titulo.tipo,
                                                      titulo.parcela,
                                                      titulo.valor,
                                                      titulo.vencimento,
                                                      titulo.natureza,
                                                      titulo.descricao
                                                  };

                                var ListaTitulos = queryTitulo.ToList();

                                //A primeira pesquisa retornou valor
                                if (ListaTitulos.Count != 0)
                                {
                                    //Exibe o formulario com todos os titulos encontrado possibilitando a baixa 
                                    frmConcilia.Conciliado passar = new frmConcilia.Conciliado();

                                    frmConcilia formConcilia = new frmConcilia(ListaTitulos, mov, ref passar);
                                    formConcilia.ShowDialog();

                                    //Obtem o numero da conta 
                                    string[] split = agConta.Split('/');
                                    //Depois do split realiza a conversão para inteiro
                                    int conta = Convert.ToInt32(split[1]);
                                    //Adiciona o numero da conta a classe conciliado
                                    passar.conta = conta;

                                    lstConciliado.Add(passar);
                                }

                                else
                                {

                                    using (var objPesqValor = new dbGerenciadorEntities())
                                    {
                                        //Se a primeira pesquisa não retornar vamos pesquisar apenas por valor que não tenha 
                                        //sida anteriormente baixados

                                        var queryTitulo_val = from titulo in objPesqValor.Titulo
                                                              join relacao in objPesqValor.Relacao on
                                                              titulo.relacao equals relacao.id
                                                              where titulo.valor == valor && titulo.baixado == null
                                                              select new
                                                              {
                                                                  titulo.id,
                                                                  titulo.numero,
                                                                  relacao.Nome,
                                                                  titulo.tipo,
                                                                  titulo.parcela,
                                                                  titulo.valor,
                                                                  titulo.vencimento,
                                                                  titulo.natureza,
                                                                  titulo.descricao
                                                              };

                                        var ListaTitulos_val = queryTitulo_val.ToList();


                                        //A primeira pesquisa retornou valor
                                        if (ListaTitulos_val.Count != 0)
                                        {


                                            //Exibe o formulario com todos os titulos encontrado possibilitando a baixa
                                            frmConcilia.Conciliado passar = new frmConcilia.Conciliado();
                                            frmConcilia formConcilia = new frmConcilia(ListaTitulos_val, mov, ref passar);
                                            formConcilia.ShowDialog();

                                            //Obtem o numero da conta
                                            string[] split = agConta.Split('/');
                                            //Depois do split realiza a conversão para inteiro
                                            int conta = Convert.ToInt32(split[1]);
                                            //Adiciona o numero da conta a classe conciliado
                                            passar.conta = conta;

                                            lstConciliado.Add(passar);

                                        }

                                        //Nenhuma pesquisa retornou agora precisamos cadastrar o titulo
                                        else
                                        {
                                            //Exibir Formulario para cadastrar ou editar Titulo 

                                            //Informações do movimento para cadastrar um titulo
                                            DateTime dtMovimento = mov.Data;
                                            Double vlMovimento = mov.Valor;

                                            MessageBox.Show("Título não encontrado:" + Environment.NewLine +
                                                "Data:  " + dtMovimento.Date + Environment.NewLine +
                                                "Valor:  " + vlMovimento + Environment.NewLine +
                                                "Descrição: " + mov.Descricao, "Titulo x Movimento", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                                            frmCadTitulo cadMovimento = new frmCadTitulo(dtMovimento, vlMovimento);
                                            cadMovimento.ShowDialog();
                                            //Apos abrir o formulario realiza de novo busca
                                            using (var objNovaPesq = new dbGerenciadorEntities())
                                            {
                                                //Primeira pesquisa por Vencimento e Valor
                                                var queryNovoTitulo = from titulo in objNovaPesq.Titulo
                                                                      join relacao in objNovaPesq.Relacao on
                                                                          titulo.relacao equals relacao.id
                                                                      where (titulo.vencimento == mov.Data.Date && titulo.valor == valor && titulo.baixado == null)
                                                                      select new
                                                                      {
                                                                          titulo.id,
                                                                          titulo.numero,
                                                                          relacao.Nome,
                                                                          titulo.tipo,
                                                                          titulo.parcela,
                                                                          titulo.valor,
                                                                          titulo.vencimento,
                                                                          titulo.natureza,
                                                                          titulo.descricao
                                                                      };

                                                var ListaNovosTitulos = queryNovoTitulo.ToList();

                                                //Verifica se houve retorno
                                                if (ListaNovosTitulos.Count != 0)
                                                {
                                                    //Exibe o formulario com todos os titulos encontrado possibilitando a baixa 
                                                    frmConcilia.Conciliado passar = new frmConcilia.Conciliado();

                                                    frmConcilia formConcilia = new frmConcilia(ListaNovosTitulos, mov, ref passar);
                                                    formConcilia.ShowDialog();

                                                    //Obtem o numero da conta 
                                                    string[] split = agConta.Split('/');
                                                    //Depois do split realiza a conversão para inteiro
                                                    int conta = Convert.ToInt32(split[1]);
                                                    //Adiciona o numero da conta a classe conciliado
                                                    passar.conta = conta;

                                                    lstConciliado.Add(passar);
                                                }


                                            }
                                        }
                                    }//Segundo using
                                }
                            }//Terceiro using
                        }

                        else
                        {

                            MessageBox.Show("O Movimento já está cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        }


                    }//using

                }


            }//Fim do foreach

            //Aqui verificar se a lstConciliado não é vazia se não for vazia 
            //loop na lista inserindo na tabela movimento e atualizando a tabela titulo

            if (lstConciliado.Count != 0)
            {
                MessageBox.Show("Vamos efetuar as alterações na base de dados", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                foreach (frmConcilia.Conciliado movBanco in lstConciliado)
                {
                    //Incluir as informações na tabela Movimento
                    Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                    var objMovimento = new Gerenciador.Data.Movimento();

                    objMovimento.data = movBanco.dtMovimento;
                    objMovimento.tipo = movBanco.tipo;
                    objMovimento.valor = Convert.ToDecimal(movBanco.vlBaixado);
                    objMovimento.numero = Convert.ToString(movBanco.numero);
                    objMovimento.descricao = movBanco.descricao;
                    objMovimento.conta = movBanco.conta;
                    objMovimento.id_titulo = movBanco.idTitulo;
                    objGerenciador.AddToMovimento(objMovimento);
                    objGerenciador.SaveChanges();

                    //Atualiza a tabela Titulo
                    using (var objUpdate = new dbGerenciadorEntities())
                    {

                        var objTitulo = new Gerenciador.Data.Titulo();

                        objTitulo = (from conv in objUpdate.Titulo
                                     where conv.id == movBanco.idTitulo
                                     select conv).First();

                        objTitulo.baixado = Convert.ToString(movBanco.baixado);
                        objTitulo.dta_baixa = movBanco.dtMovimento;
                        objTitulo.vlr_pagamento = Convert.ToDecimal(movBanco.vlBaixado);
                        objTitulo.conta_baixa = movBanco.conta;
                        objUpdate.SaveChanges();

                    }


                }//FIm loop da inclusão

                MessageBox.Show("Atualizações efetuadas com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }//Fim atualização banco de dados


        }

        //Função que verifica se a data lançamento é menor que a data de criação da conta
        public bool verDtLancamento()
        {
            foreach (OFX_Movimento mov in movimentos)
            {

                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    //agência e conta vem em uma unica string agencia/conta fiz split para obter separado
                    string[] split = agConta.Split('/');

                    //Depois do split realiza a conversão para inteiro
                    int conta = Convert.ToInt32(split[1]);

                    var query = from conv in objGerenciador.Conta
                                where conv.numero == conta
                                select conv.data_criacao;
                    var ListaFinal = query.ToList();

                    DateTime criacaoConta = Convert.ToDateTime(ListaFinal[0]);
                    //Verifica se a data do movimento é menor que a data dos movimentos
                    if (mov.Data < criacaoConta)
                    {
                        return false;

                    }



                }


            }

            return true;
        }
    }
}
