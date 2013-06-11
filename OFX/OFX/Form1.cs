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

namespace OFX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlgAbrirArquivo.Filter = "Arquivos OFX (*.ofx)|*.ofx";
            if (dlgAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                String nomeArquivo = dlgAbrirArquivo.FileName;

                try
                {

                    OFX_Extrato extrato = ofxtoXml.Parser.getExtrato(nomeArquivo);
                    if (extrato != null)
                    {
                        //Obtemos todas as transações do arquivo de extrato
                        ArrayList transacoes = extrato.Movimento;
                        DateTime dataBase = extrato.DataInicio;


                        foreach (OFX_Movimento transacao in transacoes)
                        {

                            String mostrar;
                            mostrar = "";

                            mostrar += "DATA:  ";
                            mostrar += transacao.Data;
                            mostrar += Environment.NewLine;
                            mostrar += Environment.NewLine;
                            mostrar += "DESCRIÇÂO:  ";
                            mostrar += transacao.Descricao;
                            mostrar += Environment.NewLine;
                            mostrar += Environment.NewLine;
                            mostrar += "VALOR:  R$ ";
                            mostrar += Convert.ToString(Convert.ToDecimal(transacao.Valor));

                            MessageBox.Show(Convert.ToString(mostrar));


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "OFX Parser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /* CONSULTA
                
                 using (var objGerenciador = new dbGerenciadorEntities())
              {
                  List<Gerenciador.Data.Natureza> ob = new List<Gerenciador.Data.Natureza>();
                  var query = from conv in objGerenciador.Natureza 
                  //where conv.nome == "Energia Eletrica"
                  select conv;
                  var ListaFinal = query.ToList();
                  
               }
            */

            /* INCLUIR
             
              Gerenciador.Data.dbGerenciadorEntities objGerenciador = new Gerenciador.Data.dbGerenciadorEntities();
              var objBanco = new Gerenciador.Data.Banco();

              objBanco.numero = 237;
              objBanco.descricao = "Bradesco";
              objGerenciador.AddToBanco(objBanco);
              objGerenciador.SaveChanges();
            
          */

            /* ALTERAR
            
            using (var objGerenciador = new dbGerenciadorEntities())
            {

                
               var objBanco = new Gerenciador.Data.Banco ();
               objBanco = (from conv in objGerenciador.Banco
                              where conv.numero == 237
                              select conv).First();
                
                objBanco.descricao = "Banco Bradesco";
                objGerenciador.SaveChanges();

            }
            */
        }
    }
}
