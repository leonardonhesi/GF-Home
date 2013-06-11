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
using OFX.Formularios.Classes;

namespace OFX.Formularios
{
    public partial class frmManterTitulo : Form
    {
        public frmManterTitulo()
        {
            InitializeComponent();
            //Adiciona o Botão para pesquisa por vencimento
            ToolStripControlHost btnvalorPesq = new ToolStripControlHost(btnValorPesq);
            toolStrip2.Items.Add(btnvalorPesq);

            //Adicionar o Datetimepicke no menu de pesquisas
            ToolStripControlHost dtPesqVencimento = new ToolStripControlHost(dtpVencimento);
            toolStrip4.Items.Add(dtPesqVencimento);

            //Adicionar o Botão pesquisa por data
            ToolStripControlHost btnVencimento = new ToolStripControlHost(btnPesqVencimento);
            toolStrip4.Items.Add(btnVencimento);

            //adicionar o Combobox pesquisa
            carregaComboNat();
            ToolStripControlHost cmbesqVencimento = new ToolStripControlHost(cmbNaturezaPesq);
            toolStrip3.Items.Add(cmbesqVencimento);

            //Adicionar o Botão pesquisa natureza
            ToolStripControlHost dtPesqVcto = new ToolStripControlHost(btnPesqNatureza);
            toolStrip3.Items.Add(dtPesqVcto);

        }

        //Função que carrega todos os titulos
        public object carregaTitulos()
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    DateTime hoje = DateTime.Now.Date;
                    var query = from conv in objGerenciador.Titulo
                                join convRel in objGerenciador.Relacao on
                                conv.relacao equals convRel.id
                                orderby conv.vencimento //descending
                                select new
                                {
                                    conv.id,
                                    conv.vencimento,
                                    conv.numero,
                                    relacao = (convRel.Nome),
                                    conv.natureza,
                                    conv.parcela,
                                    conv.valor,
                                    conv.descricao,
                                    conv.baixado,
                                    conv.dta_baixa,
                                    conv.conta_baixa,
                                    conv.codigoBarras

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

        //Atualiza o datagrid
        public void atualizaDtgrid()
        {
            //Apos atualiza a grid
            dtgTitulo.AutoGenerateColumns = false;
            dtgTitulo.DataSource = carregaTitulos();
            //Formatar dinheiro
            dtgTitulo.Columns[6].DefaultCellStyle.Format = "C";

        }

        //Load o combo Natureza menu pesquisa
        private void carregaComboNat()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {

                var query = from conv in objGerenciador.Natureza
                            select conv;
                var ListaNatureza = query.ToList();


                cmbNaturezaPesq.DataSource = ListaNatureza;
                cmbNaturezaPesq.DisplayMember = "nome";
                cmbNaturezaPesq.ValueMember = "nome";
            }


        }

        //Load do form
        private void frmManterTitulo_Load(object sender, EventArgs e)
        {
            atualizaDtgrid();

        }

        //Abre o formulario para cadastro de titulos 
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadTitulo>().Count() > 0)
            {
                MessageBox.Show("Cadastro de Títulos já está aberto!", "Aviso");
            }
            else
            {
                frmCadTitulo cadTitulo = new frmCadTitulo(DateTime.Now, 0, false);
                cadTitulo.ShowDialog();
                atualizaDtgrid();
                carregaComboNat();
            }
        }

        //Fecha o formulario
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Excluir o titulo selecionado
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (dtgTitulo.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Deseja mesmo excluir Titulo selecionado?", "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow linha in dtgTitulo.SelectedRows)
                        {
                            int idApagar = Convert.ToInt32(linha.Cells[0].Value);

                            using (var objGerenciador = new dbGerenciadorEntities())
                            {
                                var mensagem = (from deleteTitulo in objGerenciador.Titulo
                                                where (deleteTitulo.id == idApagar)
                                                select deleteTitulo).First();

                                objGerenciador.DeleteObject(mensagem);
                                objGerenciador.SaveChanges();

                                MessageBox.Show("Titulo excluido!", "Aviso");
                                atualizaDtgrid();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        //Altera o titulo
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            if (dtgTitulo.SelectedRows.Count != 0)
            {
                frmCadTitulo alteraTitulo = new frmCadTitulo(DateTime.Now, 0, true);


                foreach (DataGridViewRow linha in dtgTitulo.SelectedRows)
                {

                    alteraTitulo.Id = Convert.ToInt32(linha.Cells[0].Value);
                    alteraTitulo.DtVcto = Convert.ToDateTime(linha.Cells[1].Value);
                    alteraTitulo.Numero = Convert.ToInt32(linha.Cells[2].Value);
                    alteraTitulo.Relacao = Convert.ToString(linha.Cells[3].Value);
                    alteraTitulo.Natureza = Convert.ToString(linha.Cells[4].Value);
                    alteraTitulo.QtdParcela = Convert.ToInt32(linha.Cells[5].Value);
                    alteraTitulo.Valor = Convert.ToDecimal(linha.Cells[6].Value);
                    alteraTitulo.Descricao = Convert.ToString(linha.Cells[7].Value);
                    alteraTitulo.Baixado = Convert.ToBoolean(linha.Cells[8].Value);
                    if (Convert.ToString(linha.Cells[11].Value) != "")
                    {
                        alteraTitulo.CodBar = Convert.ToString(linha.Cells[11].Value);
                    }
                }

                alteraTitulo.ShowDialog();
                atualizaDtgrid();
            }
        }

        //Limpar o filtro datagrid
        private void toolStripButton1_Click(object sender, EventArgs e)
        {


            atualizaDtgrid();



        }

        //Realiza a pesquisa tendo como filtro o valor do selecionado no combo
        private void btnPesqNatureza_Click(object sender, EventArgs e)
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    var query = from conv in objGerenciador.Titulo
                                where conv.natureza == cmbNaturezaPesq.Text
                                select conv;
                    var ListaFinal = query.ToList();
                    dtgTitulo.DataSource = ListaFinal;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Realiza a pesquisa tendo como filtro a data selecionada DataTime
        private void btnPesqVencimento_Click(object sender, EventArgs e)
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {
                    DateTime dtPesq = Convert.ToDateTime(dtpVencimento.Text);


                    var query = from conv in objGerenciador.Titulo
                                where conv.vencimento == dtPesq
                                select conv;
                    var ListaFinal = query.ToList();
                    dtgTitulo.DataSource = ListaFinal;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        //Realiza a pesquisa tendo como filtro o valor selecionado
        private void btnValorPesq_Click(object sender, EventArgs e)
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {
                    Decimal valor_po = Convert.ToDecimal(txtValor.Text);
                    Decimal valor_ne = (Convert.ToDecimal(txtValor.Text) * -1);

                    var query = from conv in objGerenciador.Titulo
                                where (conv.valor == valor_po || conv.valor == valor_ne)
                                select conv;
                    var ListaFinal = query.ToList();
                    dtgTitulo.DataSource = ListaFinal;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        //Realiza a pesquisa avançada (Utilizando todos os termos definidos
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtValor.Text == "")
                {
                    using (var objGerenciador = new dbGerenciadorEntities())
                    {

                        DateTime dtPesq = Convert.ToDateTime(dtpVencimento.Text);
                        var query = from conv in objGerenciador.Titulo
                                    where conv.vencimento == dtPesq && conv.natureza == cmbNaturezaPesq.Text
                                    select conv;

                        var ListaFinal = query.ToList();
                        dtgTitulo.DataSource = ListaFinal;

                    }
                }

                else
                {
                    using (var objGerenciador = new dbGerenciadorEntities())
                    {

                        DateTime dtPesq = Convert.ToDateTime(dtpVencimento.Text);
                        Decimal valor_po = Convert.ToDecimal(txtValor.Text);
                        Decimal valor_ne = (Convert.ToDecimal(txtValor.Text) * -1);

                        var query = from conv in objGerenciador.Titulo

                                    where ((conv.valor == valor_po || conv.valor == valor_ne)
                                    && conv.vencimento == dtPesq && conv.natureza == cmbNaturezaPesq.Text)

                                    select conv;

                        var ListaFinal = query.ToList();
                        dtgTitulo.DataSource = ListaFinal;

                    }


                }
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        //Ao entrar no combo (Enter) carrega as informações das natureza
        private void cmbNaturezaPesq_Enter(object sender, EventArgs e)
        {
            carregaComboNat();
        }

        //Campo pesquisa por valor validar permitir somente numero
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }

        }

    }
}

