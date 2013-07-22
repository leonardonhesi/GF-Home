using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OFX.OFX.Classes;
using OFX.Classes;
using System.Collections;
using Gerenciador.Data;
using System.Data.Entity;
using OFX.Formularios.Cadastros;


namespace OFX.Formularios
{
    public partial class frmTotalNatureza : Form
    {
        public frmTotalNatureza()
        {
            InitializeComponent();

            //Acerta as horas nos campos
            dtpInicial.Value = DateTime.Now.Date;
            dtpInicial.Value = DateTime.Now.Date;
        }

        //Carrega o combo Natureza
        private void carregaCmbNat()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {

                var query = from conv in objGerenciador.Natureza
                            select conv;
                var ListaNat = query.ToList();

                //Verifica se tem natureza cadastrada
                if (ListaNat.Count == 0)
                {
                    //Se não tiver informa e oferece oportunidade de cadastrar
                    if (MessageBox.Show("Nenhuma natureza está cadastrada" + Environment.NewLine + "Gostaria de cadastrar agora?", "Aviso",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadNatureza cadNatureza = new frmCadNatureza();
                        cadNatureza.ShowDialog();
                        carregaCmbNat();
                    }
                }

                else
                {
                    //Se tiver o banco preenche combobox


                    cmbNat.DataSource = ListaNat;
                    cmbNat.DisplayMember = "nome";
                    cmbNat.ValueMember = "nome";

                }
            }




        }

        //Devolve totais filtrados por nome natureza em periodo especifico
        private List<object> carregaFiltroNomePeriodoDTG()
        {
            //Obter as datas do periodo selecionado
            DateTime dtInicio = Convert.ToDateTime(dtpInicial.Text);
            DateTime dtFinal = Convert.ToDateTime(dtpFinal.Text);

            using (var objGerenciador = new dbGerenciadorEntities())
            {
                //Lista com o retorno
                List<object> retornoDtg = new List<object>();

                //Carregamos todas as natureza
                var qNatureza = from natureza in objGerenciador.Natureza
                                where (natureza.nome == cmbNat.Text)
                                select natureza;
                var ListaNatureza = qNatureza.ToList();

                //Percorremos todas as natureza
                foreach (Natureza loopNat in ListaNatureza)
                {
                    using (var objTituloNat = new dbGerenciadorEntities())
                    {
                        //Para cada natureza selecionamos todos os titulos e agrupamos 
                        //natureza por valor criando um novo objeto com nome natureza e total
                        var query = from titulo in objTituloNat.Titulo
                                    where (titulo.natureza == loopNat.nome && titulo.vencimento <= dtFinal
                                    && titulo.vencimento >= dtInicio)
                                    group titulo.valor by titulo.natureza into tNatureza
                                    select new
                                    {
                                        nome = (loopNat.nome),
                                        saldoNat = (tNatureza.Sum(titulo => titulo))

                                    };
                        //Se achou titulo para natureza
                        if (query.ToList().Count != 0)
                        {
                            //Devolve soma da natureza
                            retornoDtg.Add(query.First());
                        }
                        //Tem a natureza mas não tem titulo devolve valor natureza zerado
                        else
                        {
                            //cria o objeto natureza zerado
                            var retornoZero = new
                            {

                                nome = (loopNat.nome),
                                saldoNat = Convert.ToDecimal(0)
                            };
                            //Adiciona este objeto na lista
                            retornoDtg.Add(retornoZero);
                        }


                    }//Fim segundo using

                }//Fim foreach

                //devolvemos a lista
                return retornoDtg;
            }

        }

        //Devolve totais filtrados pelo nome da natureza
        private List<object> carregaFiltroNomeDTG()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                //Lista com o retorno
                List<object> retornoDtg = new List<object>();

                //Carregamos todas as natureza
                var qNatureza = from natureza in objGerenciador.Natureza
                                where (natureza.nome == cmbNat.Text)
                                select natureza;
                var ListaNatureza = qNatureza.ToList();

                //Percorremos todas as natureza
                foreach (Natureza loopNat in ListaNatureza)
                {
                    using (var objTituloNat = new dbGerenciadorEntities())
                    {
                        //Para cada natureza selecionamos todos os titulos e agrupamos 
                        //natureza por valor criando um novo objeto com nome natureza e total
                        var query = from titulo in objTituloNat.Titulo
                                    where (titulo.natureza == loopNat.nome)
                                    group titulo.valor by titulo.natureza into tNatureza
                                    select new
                                    {
                                        nome = (loopNat.nome),
                                        saldoNat = (tNatureza.Sum(titulo => titulo))

                                    };
                        //Se achou titulo para natureza
                        if (query.ToList().Count != 0)
                        {
                            //Devolve soma da natureza
                            retornoDtg.Add(query.First());
                        }
                        //Tem a natureza mas não tem titulo devolve valor natureza zerado
                        else
                        {
                            //cria o objeto natureza zerado
                            var retornoZero = new
                            {

                                nome = (loopNat.nome),
                                saldoNat = Convert.ToDecimal(0)
                            };
                            //Adiciona este objeto na lista
                            retornoDtg.Add(retornoZero);
                        }


                    }//Fim segundo using

                }//Fim foreach

                //devolvemos a lista
                return retornoDtg;
            }

        }

        //Devolve totais natureza filtro por periodo
        private List<object> carregatFiltroPeriodoDTG()
        {
            //Obter as datas do periodo selecionado
            DateTime dtInicio = Convert.ToDateTime(dtpInicial.Text);
            DateTime dtFinal = Convert.ToDateTime(dtpFinal.Text);

            using (var objGerenciador = new dbGerenciadorEntities())
            {
                //Lista com o retorno
                List<object> retornoDtg = new List<object>();

                //Carregamos todas as natureza
                var qNatureza = from natureza in objGerenciador.Natureza
                                select natureza;
                var ListaNatureza = qNatureza.ToList();

                //Percorremos todas as natureza
                foreach (Natureza loopNat in ListaNatureza)
                {
                    using (var objTituloNat = new dbGerenciadorEntities())
                    {
                        //Para cada natureza selecionamos todos os titulos e agrupamos 
                        //natureza por valor criando um novo objeto com nome natureza e total
                        var query = from titulo in objTituloNat.Titulo
                                    where (titulo.natureza == loopNat.nome && titulo.vencimento <= dtFinal
                                    && titulo.vencimento >= dtInicio)
                                    group titulo.valor by titulo.natureza into tNatureza
                                    select new
                                    {
                                        nome = (loopNat.nome),
                                        saldoNat = (tNatureza.Sum(titulo => titulo))

                                    };
                        //Se achou titulo para natureza
                        if (query.ToList().Count != 0)
                        {
                            //Devolve soma da natureza
                            retornoDtg.Add(query.First());
                        }
                        //Tem a natureza mas não tem titulo devolve valor natureza zerado
                        else
                        {
                            //cria o objeto natureza zerado
                            var retornoZero = new
                            {

                                nome = (loopNat.nome),
                                saldoNat = Convert.ToDecimal(0)
                            };
                            //Adiciona este objeto na lista
                            retornoDtg.Add(retornoZero);
                        }


                    }//Fim segundo using

                }//Fim foreach

                //devolvemos a lista
                return retornoDtg;
            }




        }

        //Devolve totais todas as natureza
        private List<object> carregaDTG()
        {

            using (var objGerenciador = new dbGerenciadorEntities())
            {
                //Lista com o retorno
                List<object> retornoDtg = new List<object>();

                //Carregamos todas as natureza
                var qNatureza = from natureza in objGerenciador.Natureza
                                select natureza;
                var ListaNatureza = qNatureza.ToList();

                //Percorremos todas as natureza
                foreach (Natureza loopNat in ListaNatureza)
                {
                    using (var objTituloNat = new dbGerenciadorEntities())
                    {
                        //Para cada natureza selecionamos todos os titulos e agrupamos 
                        //natureza por valor criando um novo objeto com nome natureza e total
                        var query = from titulo in objTituloNat.Titulo
                                    where (titulo.natureza == loopNat.nome)
                                    group titulo.valor by titulo.natureza into tNatureza
                                    select new
                                    {
                                        nome = (loopNat.nome),
                                        saldoNat = (tNatureza.Sum(titulo => titulo))

                                    };
                        //Se achou titulo para natureza
                        if (query.ToList().Count != 0)
                        {
                            //Devolve soma da natureza
                            retornoDtg.Add(query.First());
                        }
                        //Tem a natureza mas não tem titulo devolve valor natureza zerado
                        else
                        {
                            //cria o objeto natureza zerado
                            var retornoZero = new
                            {

                                nome = (loopNat.nome),
                                saldoNat = Convert.ToDecimal(0)
                            };
                            //Adiciona este objeto na lista
                            retornoDtg.Add(retornoZero);
                        }


                    }//Fim segundo using

                }//Fim foreach

                //devolvemos a lista
                return retornoDtg;
            }



        }

        //Load do formulario
        private void frmTotalNatureza_Load(object sender, EventArgs e)
        {
            carregaCmbNat();
            try
            {
                dtgNatureza.AutoGenerateColumns = false;
                dtgNatureza.DataSource = carregaDTG();
                dtgNatureza.Columns[1].DefaultCellStyle.Format = "C";
                //Atualiza o grafico
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart1.Series[0].Points.DataBindXY(carregaDTG(), "nome", carregaDTG(), "saldoNat");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Botão pesquisa natureza por periodo
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (Convert.ToDateTime(dtpFinal.Text) < Convert.ToDateTime(dtpInicial.Text))
            {
                //Data final não pode se menor que data Inicial
                MessageBox.Show("Data final não pode ser menor que a data Inicial", "Aviso");

            }
            else
            {
                //Carrega o grid

                dtgNatureza.DataSource = carregatFiltroPeriodoDTG();
                //Atualiza o grafico
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart1.Series[0].Points.DataBindXY(carregatFiltroPeriodoDTG(), "nome", carregatFiltroPeriodoDTG(), "saldoNat");


            }




        }

        //Botão que limpa os filtros
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dtgNatureza.AutoGenerateColumns = false;
                dtgNatureza.DataSource = carregaDTG();
                dtgNatureza.Columns[1].DefaultCellStyle.Format = "C";
                //Atualiza o grafico
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart1.Series[0].Points.DataBindXY(carregaDTG(), "nome", carregaDTG(), "saldoNat");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Botão pesquisa pelo nome da natureza
        private void button1_Click(object sender, EventArgs e)
        {

            dtgNatureza.DataSource = carregaFiltroNomeDTG();

            //Atualiza o grafico
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(carregaFiltroNomeDTG(), "nome", carregaFiltroNomeDTG(), "saldoNat");

        }

        //Pesquisa por nome de natureza em periodo especifico
        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpFinal.Text) < Convert.ToDateTime(dtpInicial.Text))
            {
                //Data final não pode se menor que data Inicial
                MessageBox.Show("Data final não pode ser menor que a data Inicial", "Aviso");

            }
            else
            {
                //Carrega o grid

                dtgNatureza.DataSource = carregaFiltroNomePeriodoDTG();

                //Atualiza o grafico
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart1.Series[0].Points.DataBindXY(carregaFiltroNomePeriodoDTG(), "nome", carregaFiltroNomePeriodoDTG(), "saldoNat");
            }


        }
    }
}