using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gerenciador.Data;
using OFX.Formularios.Cadastros;
using System.Net.Mail;
using System.Net;
using OFX.Formularios.Classes;

namespace OFX.Formularios
{
    public partial class frmEnviaEmail : Form
    {
        public frmEnviaEmail()
        {
            InitializeComponent();

            //Acerta campos de data
            dtpIncio.Value = DateTime.Now.Date;
            dtpFinal.Value = DateTime.Now.Date;

        }

        //Carrega o combo com as contas de e-mail de destino
        public void carregaConta()
        {

            using (var objGerenciador = new dbGerenciadorEntities())
            {

                var qEmail = from rEmail in objGerenciador.email
                             select rEmail;
                var ListaEmail = qEmail.ToList();

                //Verifica se tem retorno
                if (ListaEmail.Count == 0)
                {
                    //Se não tiver retorno abre o formulario de cadastro
                    if (MessageBox.Show("Nenhum email está cadastrada" + Environment.NewLine +
                                      "Gostaria de cadastrar agora?", "Aviso", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadEmail cadEmail = new frmCadEmail();
                        cadEmail.ShowDialog();
                        carregaConta();
                    }
                }

                else
                {
                    //Se tiver o banco preenche combobox

                    cmbDestEmail.DataSource = ListaEmail;
                    cmbDestEmail.DisplayMember = "email";
                    cmbDestEmail.ValueMember = "email1";

                }
            }



        }

        //Load do formualario
        private void frmEnviaEmail_Load(object sender, EventArgs e)
        {
            carregaConta();

        }

        //Envia o e-mail
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpFinal.Text) < Convert.ToDateTime(dtpIncio.Text))
            {
                MessageBox.Show("Data final menor que data inicial!", "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);


            }

            else
            {

                try
                {
                    //Obtem os dados da conta selecionada
                    using (var objGerenciador = new dbGerenciadorEntities())
                    {

                        var qdadosEmail = from conv in objGerenciador.email
                                          where conv.email1 == cmbDestEmail.Text
                                          select new
                                          {
                                              conv.email1,
                                              conv.smtp,
                                              conv.porta,
                                              conv.senha

                                          };

                        var ListaDados = qdadosEmail.ToList();

                        if (ListaDados.Count != 0)
                        {

                            //Informações para envio ( Começa o envio )
                            ggRt04 val = new ggRt04();
                            SmtpClient client = new SmtpClient();
                            client.Host = ListaDados[0].smtp;
                            client.Port = ListaDados[0].porta;
                            client.EnableSsl = false;
                            client.Credentials = new NetworkCredential(ListaDados[0].email1, val.retornaSaldo(ListaDados[0].senha));

                            MailMessage mensagem = new MailMessage();
                            mensagem.Sender = new MailAddress(ListaDados[0].email1, "Gerenciador Financeiro");
                            mensagem.From = new MailAddress(ListaDados[0].email1, "Gerenciador Financeiro");
                            mensagem.To.Add(new MailAddress(ListaDados[0].email1, "Gerenciador Financeiro"));
                            mensagem.Subject = Convert.ToString("Pagamentos de:  " + dtpIncio.Text + "  até:   " + dtpFinal.Text);

                            //Monta o corpo do email apos validar colocar em uma função separada
                            using (var objGerenciador1 = new dbGerenciadorEntities())
                            {
                                DateTime inicio = dtpIncio.Value;
                                DateTime final = dtpFinal.Value;
                                string body = "<h1>Contas á pagar</h1> <p> </p> <table border=1><tr>";
                                body += "<td><b>VENCIMENTO</b></td><td><b>FORNECEDOR</b></td><td><b>NATUREZA</b></td>";
                                body += "<td><b>VALOR</b></td> <td><b>COD.BARRAS</b></td> <td><b>DESCRIÇÂO</b></td> </tr>";

                                //Busca os titulos no periodo filtrado
                                var qTitulo = from cTitulo in objGerenciador1.Titulo
                                              join cRelacao in objGerenciador1.Relacao on
                                              cTitulo.relacao equals cRelacao.id
                                              orderby cTitulo.vencimento
                                              where (cTitulo.vencimento >= inicio && cTitulo.vencimento <= final && cTitulo.baixado == null)
                                              select new
                                              {

                                                  cTitulo.vencimento,
                                                  cRelacao.Nome,
                                                  cTitulo.natureza,
                                                  cTitulo.valor,
                                                  cTitulo.descricao,
                                                  cTitulo.codigoBarras

                                              };


                                var ListaFinal = qTitulo.ToList();

                                if (ListaFinal.Count != 0)
                                {
                                    //Percorre os titulos
                                    foreach (var dados in ListaFinal)
                                    {
                                        //Algumas formatações nos valores
                                        string Valor = string.Format("{0:C}", dados.valor);
                                        string Vencimento = string.Format("{0:D}", dados.vencimento);

                                        //Acrescenta no corpo da mensagem
                                        body += Convert.ToString("<tr><td>" + Vencimento + "</td><td>" + dados.Nome + "</td><td>" + dados.natureza + "</td><td>"
                                                + Valor + "</td><td>" + dados.codigoBarras + "</td><td>" + dados.descricao + "</td></tr>");


                                    }
                                    body += "</table>";

                                    mensagem.Body = body;
                                    mensagem.IsBodyHtml = true;
                                    mensagem.Priority = MailPriority.High;

                                    //Envia a mensagem
                                    client.Send(mensagem);
                                    MessageBox.Show("E-mail enviado com sucesso!", "Aviso", MessageBoxButtons.OK,
                                                     MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    this.Close();
                                }

                                    //Quando retorno da lista de titulos zerada
                                else
                                {
                                    MessageBox.Show("Não existe titulos para o perido informado", "Aviso");
                                    this.Close();
                                }


                            }

                        }

                            //Caso não tenha conta e-mail
                        else
                        {
                            MessageBox.Show("Nenhuma conta de e-mail cadastrada", "Aviso");
                            this.Close();
                        }


                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);

                }
            }




        }

        //Fechar o formulario
        private void btnCancelarEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

