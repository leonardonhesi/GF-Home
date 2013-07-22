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
using OFX.Formularios.Classes;

namespace OFX.Formularios.Cadastros
{
    public partial class frmCadTitulo : Form
    {
        //Atributos para passagem dos campos quando for utilizado para alterar um titulo
        private int _id;
        private int _numero;
        private String _relacao;
        private int _qtdParcela;
        private Decimal _valor;
        private DateTime _dtVcto;
        private String _natureza;
        private String _descricao;
        private Boolean _baixado;
        private string _codBar;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public String Relacao
        {
            get { return _relacao; }
            set { _relacao = value; }
        }
        public int QtdParcela
        {
            get { return _qtdParcela; }
            set { _qtdParcela = value; }
        }
        public Decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public DateTime DtVcto
        {
            get { return _dtVcto; }
            set { _dtVcto = value; }
        }
        public String Natureza
        {
            get { return _natureza; }
            set { _natureza = value; }
        }
        public String Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public Boolean Baixado
        {
            get { return _baixado; }
            set { _baixado = value; }

        }
        public string CodBar
        {
            get { return _codBar; }
            set { _codBar = value; }
        }

        //Fim atributos

        //Variavel de controle para (Incluir ou alterar) defina qual a função do objeto chamado
        public bool altera;

        //Variavel de controle para (Fechar ou reiniciar o formulario apos inclusão) utilizado quando a inclusão vem do OFX
        public bool vemOfx = false;

        //Construtor da Classe 
        public frmCadTitulo(DateTime dtMovimento, double vlMovimento = 0, bool alterar = false)
        {
            //Realizar o tratamento e diferenciar de onde vem as chamadas(Pelo OFX ou Manualmente) 
            InitializeComponent();
            dtpVctoTitulo.Value = dtMovimento;

            if (vlMovimento != 0)
            {
                //Tem valor de movimento chamada veio do OFX

                vemOfx = true; // Define que ao terminar de incluir o formulario deverá ser fechado e não reinicializado
                txtValorTitulo.Text = Convert.ToString(vlMovimento);
                txtValorTitulo.Enabled = false;
                dtpVctoTitulo.Enabled = false;
                txtParcelaTitulo.Text = Convert.ToString(1);
                txtParcelaTitulo.Enabled = false;
            }
            //Atribui a função do formulario na chamada atual
            altera = alterar;
        }

        //Carrega o form quando utilizado para Alterar o titulo
        public void loadAlterar()
        {
            //Se a chamada vier para alteração
            if (altera == true)
            {

                //Preencher os campos do formulario               
                txtNumeroTitulo.Text = Convert.ToString(_numero);
                cmbRelacaoTitulo.Text = _relacao;
                txtParcelaTitulo.Text = Convert.ToString(_qtdParcela);
                txtParcelaTitulo.Enabled = false; //desabilita alteração no campo numero de parcelas
                txtValorTitulo.Text = string.Format("{0:N}", _valor); //Formata como moeda
                dtpVctoTitulo.Text = Convert.ToString(_dtVcto);
                cmbNaturezaTitulo.Text =_natureza;
                txtDescricaoTitulo.Text = Convert.ToString(_descricao);
                if (_codBar != "")
                {
                    txtCodBar.Text = Convert.ToString(_codBar);
                }
                btnConfirmaTitulo.Text = "Alterar";//Muda o texto do botão

                //Se a alteração for de um titulo baixado não podemos alterar o valor nem vencimento
                //No futuro podemos ter relatórios de titulos atrasados etc...
                if (Baixado == true)
                {
                    txtValorTitulo.Enabled = false;
                    dtpVctoTitulo.Enabled = false;
                }

            }


        }

        //Carrega o combobox de relação
        private void loadcmbRelacao()
        {

            using (var objGerenciador = new dbGerenciadorEntities())
            {

                var qRelacao = from relacao in objGerenciador.Relacao
                               select relacao;
                var ListaRelacao = qRelacao.ToList();

                //Verifica se tem retorno
                if (ListaRelacao.Count == 0)
                {
                    //Se não tiver retorno abre o formulario de cadastro
                    if (MessageBox.Show("Nenhum relação está cadastrada" + Environment.NewLine +
                                      "Relação siginifica cadastrar fornecedores ou clientes." + Environment.NewLine +
                                      "Gostaria de cadastrar agora?", "Aviso", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadRelacao cadRelacao = new frmCadRelacao();
                        cadRelacao.ShowDialog();
                        loadcmbRelacao();
                    }
                }

                else
                {
                    //Se tiver o banco preenche combobox
                    cmbRelacaoTitulo.DataSource = ListaRelacao;
                    cmbRelacaoTitulo.DisplayMember = "nome";
                    cmbRelacaoTitulo.ValueMember = "id";

                }
            }



        }

        //Carrega o combobox da Natureza
        private void loadcmbNatureza()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {

                var qNatureza = from natureza in objGerenciador.Natureza
                                select natureza;
                var ListaNatureza = qNatureza.ToList();

                //Verifica se tem retorno
                if (ListaNatureza.Count == 0)
                {
                    //Se não tiver retorno abre o formulario de cadastro
                    if (MessageBox.Show("Nenhuma natureza está cadastrada" + Environment.NewLine +
                                      "Gostaria de cadastrar uma natureza agora?", "Aviso", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadNatureza cadNatureza = new frmCadNatureza();
                        cadNatureza.ShowDialog();
                        loadcmbNatureza();
                    }
                }

                else
                {
                    //Se tiver natureza cadastrada preenche combobox

                    cmbNaturezaTitulo.DataSource = ListaNatureza;
                    cmbNaturezaTitulo.DisplayMember = "nome";
                    cmbNaturezaTitulo.ValueMember = "nome";

                }
            }


        }

        //Carrega o tipo da relação (Fornecedor ou Cliente)
        private void loadTipo()
        {
            using (var objGerenciador = new dbGerenciadorEntities())
            {
                int relacao = Convert.ToInt32(cmbRelacaoTitulo.SelectedValue);

                var qRelacao = from tipo in objGerenciador.Relacao
                               where tipo.id == relacao
                               select tipo.Tipo;
                var ListaFinal = qRelacao.ToList();


                cmbTipoTitulo.DataSource = ListaFinal;
                cmbTipoTitulo.DisplayMember = "Tipo";

            }

        }

        //Load do form
        private void frmCadTitulo_Load(object sender, EventArgs e)
        {
            loadcmbRelacao();
            loadcmbNatureza();
            loadAlterar();
            loadTipo();

        }

        //Fecha o formulario
        private void btnCancelaTitulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Carrega os tipos da relação ( Fornecedor ou Cliente )
        private void cmbTipoTitulo_Enter(object sender, EventArgs e)
        {
            loadTipo();
        }

        //Carrega os tipos da relação ( Fornecedor ou Cliente )
        private void cmbTipoTitulo_Leave(object sender, EventArgs e)
        {
            loadTipo();
        }

        //Função prorroga o vencimento para o proximo dia util (Caso de cair fim semana )
        private DateTime fimSemana()
        {
            DateTime vencimento = new DateTime();
            
            vencimento = Convert.ToDateTime(dtpVctoTitulo.Text);

            //Joga para proximo dia util quando sabado ou domingo
            if (vencimento.DayOfWeek == DayOfWeek.Saturday)
            {
                return vencimento = vencimento.AddDays(2);

            }

            else if (vencimento.DayOfWeek == DayOfWeek.Sunday)
            {

               return vencimento = vencimento.AddDays(1);
            }

            return vencimento;
        }

        //Função Acerta o valor de acordo com a operação (Crédito ou Débito)
        private void acertaPosNeg()
        {
            //Acerta o valor titulo para negativo
            if (cmbTipoTitulo.Text == "FORNECEDOR" && (Convert.ToDecimal(txtValorTitulo.Text) > 0))
            {
                txtValorTitulo.Text = (Convert.ToString((Convert.ToDecimal(txtValorTitulo.Text) * -1)));

            }
            //Acerta o valor titulo para positivo
            if (cmbTipoTitulo.Text == "CLIENTE" && (Convert.ToDecimal(txtValorTitulo.Text) < 0))
            {
                txtValorTitulo.Text = (Convert.ToString((Convert.ToDecimal(txtValorTitulo.Text) * -1)));

            }

        }

        //Reload do form _ Para salvar um inclusão e limpar e posicionar a tela para a proxima inclusão
        private void reloadForm()
        {
            txtNumeroTitulo.Text = "";
            txtDescricaoTitulo.Text = "";
            txtCodBar.Text = "";
            txtValorTitulo.Text = "";
            txtParcelaTitulo.Text = "";
            loadcmbNatureza();
            loadcmbRelacao();
            txtNumeroTitulo.Focus();
            dtpVctoTitulo.Value = DateTime.Now;
        }

        //Confirmar inclusão
        private void btnConfirmaTitulo_Click(object sender, EventArgs e)
        {
            //Função de validação
            Validar valida = new Validar();
            if (valida.valCampoVazio(this.Controls) == true)
            {
                if (Convert.ToInt32(txtParcelaTitulo.Text) >= 1)
                {

                    //Carrega o tipo do titulo correto
                    loadTipo();

                    //Verifica se é para alterar ou para incluir

                    //ALTERAR
                    if (altera == true)
                    {
                        //Acerta o valor de acordo com a operação (Positivo ou Negativo)
                        acertaPosNeg();

                        //Prorroga Vencimento proximo dia util
                        DateTime alteraVencimento = fimSemana();

                        using (var objGerenciador = new dbGerenciadorEntities())
                        {

                            var objTitulo = new Gerenciador.Data.Titulo();
                            //Seleciona o registro a ser alterado pela sua ID
                            objTitulo = (from conv in objGerenciador.Titulo
                                         where conv.id == _id
                                         select conv).First();

                            //Alterações
                            objTitulo.numero = Convert.ToInt32(txtNumeroTitulo.Text);
                            objTitulo.relacao = Convert.ToInt32(cmbRelacaoTitulo.SelectedValue);
                            objTitulo.tipo = Convert.ToString(cmbTipoTitulo.Text);
                            objTitulo.qtd_parcela = Convert.ToInt32(txtParcelaTitulo.Text);
                            objTitulo.valor = Convert.ToDecimal(txtValorTitulo.Text);
                            objTitulo.vencimento = alteraVencimento;
                            objTitulo.parcela = Convert.ToInt32(txtParcelaTitulo.Text);
                            objTitulo.natureza = Convert.ToString(cmbNaturezaTitulo.SelectedValue);
                            objTitulo.descricao = txtDescricaoTitulo.Text;
                            objTitulo.codigoBarras = txtCodBar.Text;

                            //Grava no banco
                            objGerenciador.SaveChanges();

                            MessageBox.Show("Titulo Alterado com sucesso!", "Alterações", MessageBoxButtons.OK,
                                             MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                            //Apos alterar fecha ou reinicializa o formulario
                            if (vemOfx == true)
                            {
                                reloadForm();
                            }
                            else
                            {
                                this.Close();
                            }
                        }


                    }

                    //INCLUIR
                    else
                    {

                        //Verifica se o titulo já não esta cadastrado
                        using (var objGerenciador1 = new dbGerenciadorEntities())
                        {

                            int tituloNumero = Convert.ToInt32(txtNumeroTitulo.Text);
                            int relacaoNumero = Convert.ToInt32(cmbRelacaoTitulo.SelectedValue);
                            decimal valor = Convert.ToDecimal(txtValorTitulo.Text);
                            DateTime vcto = Convert.ToDateTime(dtpVctoTitulo.Text);

                            var query = from conv in objGerenciador1.Titulo
                                        where (conv.numero == tituloNumero && conv.relacao == relacaoNumero
                                        && conv.valor == valor && conv.vencimento == vcto)
                                        select conv;
                            var ListaBanco = query.ToList();

                            //Titulo não está cadastrado
                            if (ListaBanco.Count == 0)
                            {
                                //Acerta o valor de acordo com a operação (Positivo ou Negativo)
                                acertaPosNeg();

                                //Prorroga o titulo proximo dia util
                                DateTime vencimento = new DateTime();
                                vencimento = fimSemana();

                                //Realizar loop de acordo com numero de parcelas

                                int numeroParcelas = Convert.ToInt32(txtParcelaTitulo.Text);
                                for (int i = 0; i < numeroParcelas; i++)
                                {

                                    //Incluir
                                    Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
                                    var objTitulo = new Gerenciador.Data.Titulo();
                                    objTitulo.numero = Convert.ToInt32(txtNumeroTitulo.Text);
                                    objTitulo.relacao = Convert.ToInt32(cmbRelacaoTitulo.SelectedValue);
                                    objTitulo.tipo = Convert.ToString(cmbTipoTitulo.Text);
                                    objTitulo.qtd_parcela = Convert.ToInt32(txtParcelaTitulo.Text);
                                    objTitulo.valor = (Convert.ToDecimal(txtValorTitulo.Text) / numeroParcelas); // Valor total divido pelas parcelas
                                    objTitulo.vencimento = vencimento;
                                    objTitulo.parcela = (i + 1);//Incrementa a parcela
                                    objTitulo.natureza = Convert.ToString(cmbNaturezaTitulo.SelectedValue);
                                    objTitulo.descricao = txtDescricaoTitulo.Text;
                                    objTitulo.codigoBarras = txtCodBar.Text;

                                    //Realiza a inclusão    
                                    objGerenciador.AddToTitulo(objTitulo);
                                    objGerenciador.SaveChanges();

                                    //Incrementa mês
                                    vencimento = vencimento.AddMonths(1);

                                    //Joga para proximo dia util quando sabado ou domingo
                                    if (vencimento.DayOfWeek == DayOfWeek.Saturday)
                                    {
                                        vencimento = vencimento.AddDays(2);

                                    }

                                    else if (vencimento.DayOfWeek == DayOfWeek.Sunday)
                                    {

                                        vencimento = vencimento.AddDays(1);
                                    }



                                }

                                MessageBox.Show("Titulo Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button2);

                                //Verifica de onde vem OFX ou manual e da o tratamento
                                if (vemOfx == false)
                                {
                                    reloadForm();
                                }
                                else
                                {
                                    this.Close();
                                }
                            }


                            else
                            {
                                //Mensagem caso o titulo exista
                                MessageBox.Show("Titulo já existe verifique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                                MessageBoxDefaultButton.Button2);

                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Parcela não pode ser menor que 1", "Aviso");
                    txtParcelaTitulo.Text = "";
                    txtParcelaTitulo.Focus();
                }
            } 
        }

        //Chamada dos Menus

        //Cadastra Relação  
        private void relaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadRelacao menuRelacao = new frmCadRelacao();
            menuRelacao.ShowDialog();
            loadcmbRelacao();

        }

        //Cadastra Natureza 
        private void naturezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadNatureza menuNatureza = new frmCadNatureza();
            menuNatureza.ShowDialog();
            loadcmbNatureza();

        }

        //Cadastra Contas
        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadConta menuConta = new frmCadConta();
            menuConta.ShowDialog();
            loadcmbRelacao();
            loadAlterar();
            loadcmbNatureza();
            loadTipo();

        }

        //KeyPress TextBox Valor
        private void txtValorTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtValorTitulo);
        }

        //Keypress TextBox Numero titulo
        private void txtNumeroTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtNumeroTitulo);
        }

        //KeyPress TextBox Parcela
        private void txtParcelaTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtParcelaTitulo);
        }

        //KeyPress Validar o codigo de barras só numero
        private void txtCodBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar valida = new Validar();
            valida.valCampoNumero(e, txtCodBar);
        }

        //Quando deixa o campo parcela se for parcelado desabilita o campo codigo barras
        private void txtParcelaTitulo_Leave(object sender, EventArgs e)
        {
            if (txtParcelaTitulo.Text != "")
            {
                if (Convert.ToInt32(txtParcelaTitulo.Text) > 1)
                {

                    MessageBox.Show("Quando o titulo tem varias parcelas, temos que cadastrar os codigos de barras indivualmente", "Aviso");
                    txtCodBar.Enabled = false;

                }
                else if (Convert.ToInt32(txtParcelaTitulo.Text) == 1)
                {

                    txtCodBar.Enabled = true;

                }
            }
        }


    }
}
