using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Gerenciador.Data;
using System.Data.Entity;
using OFX.Classes;
using OFX.OFX.Classes;

namespace OFX.Formularios
{
    public partial class frmConcilia : Form
    {
        //Recebe os titulos encontrado nas buscar
        private object listaTitulos;
        //Recebe o movimento que estamos procurando nos titulos
        private OFX_Movimento movimento;

        //Classe para preencher a list de movimentos conciliados que serão gravados de uma só vez no banco
        public class Conciliado
        {
            public DateTime dtMovimento;
            public Boolean baixado;
            public Double vlBaixado;
            public Int32 idTitulo;
            public Int32 numero;
            public String descricao;
            public String tipo;
            public Int32 conta;

        }

        //Inicia um novo objeto da classe
        Conciliado dvConciliado = new Conciliado();

        //Construtor da classe  
        public frmConcilia(object ListaTitulos, OFX_Movimento pMovimento, ref Conciliado devolverConciliado)
        {
            InitializeComponent();
            this.listaTitulos = ListaTitulos;
            this.movimento = pMovimento;

            //Monta o grid e as labels
            dtgConcilia.AutoGenerateColumns = false;
            dtgConcilia.DataSource = ListaTitulos;
            dtgConcilia.Columns[5].DefaultCellStyle.Format = "C";
            lblMovimento.Text = Convert.ToString(pMovimento.Data.Day + "/" + pMovimento.Data.Month + "/" + pMovimento.Data.Year);
            lblDescricao.Text = Convert.ToString(pMovimento.Descricao);
            lblValor.Text = Convert.ToString(pMovimento.Valor);

            //Atribui o ponteiro a uma variavel local para ser alterada
            dvConciliado = devolverConciliado;

        }

        //Obtem todas as informações do Titulo selecionado e grava na lista que um ponteiro 
        //Que na classe Concilia será adicionado em uma lista que será gravada de uma vez no banco
        private void btnOkConcilia_Click(object sender, EventArgs e)
        {

            dvConciliado.vlBaixado = Convert.ToDouble(lblValor.Text);
            dvConciliado.dtMovimento = Convert.ToDateTime(lblMovimento.Text);
            dvConciliado.descricao = movimento.Descricao;
            dvConciliado.baixado = true;
            dvConciliado.tipo = movimento.Tipo;
            dvConciliado.numero = Convert.ToInt32(movimento.Id);

            //Percorre as celular e da linha selecionada
            foreach (DataGridViewRow linha in dtgConcilia.SelectedRows)
            {
                dvConciliado.idTitulo = Convert.ToInt32(linha.Cells[0].Value);


            }

            this.Close();
        }

        //Ao carregar o formulario iniciar o foco no datagrid 
        private void frmConcilia_Load(object sender, EventArgs e)
        {

            dtgConcilia.Focus();
        }



    }
}
