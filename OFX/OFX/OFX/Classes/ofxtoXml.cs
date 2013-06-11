using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace OFX.OFX.Classes
{
    class ofxtoXml
    {
        public enum PartDateTime
        {
            DAY,
            MONTH,
            YEAR,
            HOUR,
            MINUTE,
            SECOND
        }

        public class Parser
        {
            // Transforma aquivo ofx em tags XML.
            // Retorna as tags XML em um objeto StringBuilder 
            private static StringBuilder translateToXML(String ofxOrigem)
            {
                StringBuilder resultado = new StringBuilder();
                int nivel = 0;
                String linha;

                if (!File.Exists(ofxOrigem))
                {
                    throw new FileNotFoundException("Arquivo OFX não encontrado : " + ofxOrigem);
                }

                StreamReader sr = File.OpenText(ofxOrigem);
                while ((linha = sr.ReadLine()) != null)
                {
                    linha = linha.Trim();

                    if (linha.StartsWith("</") && linha.EndsWith(">"))
                    {
                        addTabs(resultado, nivel, true);
                        nivel--;
                        resultado.Append(linha);
                    }
                    else if (linha.StartsWith("<") && linha.EndsWith(">"))
                    {
                        nivel++;
                        addTabs(resultado, nivel, true);
                        resultado.Append(linha);
                    }
                    else if (linha.StartsWith("<") && !linha.EndsWith(">"))
                    {
                        addTabs(resultado, nivel + 1, true);
                        resultado.Append(linha);
                        resultado.Append(returnFinalTag(linha));
                    }
                }
                sr.Close();

                return resultado;
            }

            // Retorna objeto Extrato com os dados do OFX.
            public static OFX_Extrato getExtrato(String ofxOrigem)
            {
                Boolean temTransacao = false;
                Boolean temCabecalho = false;
                Boolean temDadosConta = false;
                Boolean temDadosPrincipaisExtrato = false;

                // Transformar em arquivo XML
                exportToXML(ofxOrigem, ofxOrigem + ".xml");

                // Variáveis úteis para o Parse
                String elementoSendoLido = "";
                OFX_Movimento transacaoAtual = null;

                // Variávies utilizadas para a leitura do XML
                OFX_HeaderExtrato cabecalho = new OFX_HeaderExtrato();
                OFX_Conta conta = new OFX_Conta();

                OFX_Extrato extrato = new OFX_Extrato(cabecalho, conta, "");

                // Lendo o XML 
                XmlTextReader meuXml = new XmlTextReader(ofxOrigem + ".xml");
                try
                {
                    while (meuXml.Read())
                    {
                        if (meuXml.NodeType == XmlNodeType.EndElement)
                        {
                            switch (meuXml.Name)
                            {
                                case "STMTTRN":
                                    if (transacaoAtual != null)
                                    {
                                        extrato.addMovimento(transacaoAtual);
                                        transacaoAtual = null;
                                        temTransacao = true;
                                    }
                                    break;
                            }
                        }
                        if (meuXml.NodeType == XmlNodeType.Element)
                        {
                            elementoSendoLido = meuXml.Name;

                            switch (elementoSendoLido)
                            {
                                case "STMTTRN":
                                    transacaoAtual = new OFX_Movimento();
                                    break;
                            }
                        }
                        if (meuXml.NodeType == XmlNodeType.Text)
                        {
                            switch (elementoSendoLido)
                            {
                                case "DTSERVER":
                                    //cabecalho.DataServidor = convertOfxDateToDateTime(meuXml.Value);
                                    temCabecalho = true;
                                    break;
                                case "LANGUAGE":
                                    cabecalho.Idioma = meuXml.Value;
                                    temCabecalho = true;
                                    break;
                                case "ORG":
                                    cabecalho.NomeBanco = meuXml.Value;
                                    temCabecalho = true;
                                    break;
                                case "DTSTART":
                                    extrato.DataInicio = convertOfxDateToDateTime(meuXml.Value);
                                    temDadosPrincipaisExtrato = true;
                                    break;
                                case "DTEND":
                                    extrato.DataFinal = convertOfxDateToDateTime(meuXml.Value);
                                    temDadosPrincipaisExtrato = true;
                                    break;
                                case "BANKID":
                                    conta.Banco = new OFX_Banco(Convert.ToInt32(meuXml.Value), "");
                                    temDadosConta = true;
                                    break;
                                case "BRANCHID":
                                    conta.Agencia = meuXml.Value;
                                    temDadosConta = true;
                                    break;
                                case "ACCTID":
                                    conta.nConta = meuXml.Value;
                                    temDadosConta = true;
                                    break;
                                case "ACCTTYPE":
                                    conta.Tipo = meuXml.Value;
                                    temDadosConta = true;
                                    break;
                                case "TRNTYPE":
                                    transacaoAtual.Tipo = meuXml.Value;
                                    break;
                                case "DTPOSTED":
                                    transacaoAtual.Data = convertOfxDateToDateTime(meuXml.Value);
                                    break;
                                case "TRNAMT":
                                    transacaoAtual.Valor = Convert.ToDouble(meuXml.Value.Replace('.', ','));
                                    break;
                                case "FITID":
                                    transacaoAtual.Id = meuXml.Value;
                                    break;
                                case "CHECKNUM":
                                    transacaoAtual.Checksum = Convert.ToInt64(meuXml.Value);
                                    break;
                                case "MEMO":
                                    transacaoAtual.Descricao = meuXml.Value;
                                    break;
                            }
                        }
                    }
                }
                catch (XmlException ex)
                {
                    throw new OFXErros(Convert.ToString(ex.Message + "OFX Inválido!"));
                }
                finally
                {
                    meuXml.Close();
                }

                if ((temCabecalho == false) || (temDadosConta == false) || (temDadosPrincipaisExtrato == false))
                {
                    throw new OFXErros("OFX Inválido!");
                }

                return extrato;
            }

            // traduz um OFX para XML, Independente do conteudo.
            private static void exportToXML(String ofxOrigem, String novoXML)
            {
                if (System.IO.File.Exists(ofxOrigem))
                {
                    if (novoXML.ToLower().EndsWith(".xml"))
                    {

                        //Traduzir OFX para o Formato XML
                        StringBuilder ofxTranslated = translateToXML(ofxOrigem);

                        // Verifica se o arquivo existe
                        if (System.IO.File.Exists(novoXML))
                        {
                            System.IO.File.Delete(novoXML);
                        }

                        // Escrevendo no arquivos
                        StreamWriter sw = File.CreateText(novoXML);
                        sw.WriteLine(@"<?xml version=""1.0""?>");
                        sw.WriteLine(ofxTranslated.ToString());
                        sw.Close();
                    }
                    else
                    {
                        throw new ArgumentException("Nome XML inválido: " + novoXML);
                    }
                }
                else
                {
                    throw new FileNotFoundException("OFX arquivo não encontrado: " + ofxOrigem);
                }
            }

            // Retorna tag correta de fechamento
            private static String returnFinalTag(String conteudo)
            {
                String returnFinal = "";

                if ((conteudo.IndexOf("<") != -1) && (conteudo.IndexOf(">") != -1))
                {
                    int position1 = conteudo.IndexOf("<");
                    int position2 = conteudo.IndexOf(">");
                    if ((position2 - position1) > 2)
                    {
                        returnFinal = conteudo.Substring(position1, (position2 - position1) + 1);
                        returnFinal = returnFinal.Replace("<", "</");
                    }
                }

                return returnFinal;
            }

            // Adiciona tabs arquivo xml melhor identação.
            private static void addTabs(StringBuilder stringObject, int lengthTabs, bool newLine)
            {
                if (newLine)
                {
                    stringObject.AppendLine();
                }
                for (int j = 1; j < lengthTabs; j++)
                {
                    stringObject.Append("\t");
                }
            }

            // obtem pedaços de data
            private static int getPartOfOfxDate(String ofxDate, PartDateTime partDateTime)
            {
                int result = 0;

                if (partDateTime == PartDateTime.YEAR)
                {
                    result = Int32.Parse(ofxDate.Substring(0, 4));

                }
                else if (partDateTime == PartDateTime.MONTH)
                {
                    result = Int32.Parse(ofxDate.Substring(4, 2));

                } if (partDateTime == PartDateTime.DAY)
                {
                    result = Int32.Parse(ofxDate.Substring(6, 2));

                } if (partDateTime == PartDateTime.HOUR)
                {
                    if (ofxDate.Length >= 10)
                    {
                        result = Int32.Parse(ofxDate.Substring(8, 2));
                    }
                    else
                    {
                        result = 0;
                    }

                } if (partDateTime == PartDateTime.MINUTE)
                {
                    if (ofxDate.Length >= 12)
                    {
                        result = Int32.Parse(ofxDate.Substring(10, 2));
                    }
                    else
                    {
                        result = 0;
                    }

                } if (partDateTime == PartDateTime.SECOND)
                {
                    if (ofxDate.Length >= 14)
                    {
                        result = Int32.Parse(ofxDate.Substring(12, 2));
                    }
                    else
                    {
                        result = 0;
                    }

                }

                return result;
            }

            //Converte string de data do OFX para DateTime do objeto
            private static DateTime convertOfxDateToDateTime(String ofxDate)
            {
                int year = getPartOfOfxDate(ofxDate, PartDateTime.YEAR);
                int month = getPartOfOfxDate(ofxDate, PartDateTime.MONTH);
                int day = getPartOfOfxDate(ofxDate, PartDateTime.DAY);
                int hour = getPartOfOfxDate(ofxDate, PartDateTime.HOUR);
                int minute = getPartOfOfxDate(ofxDate, PartDateTime.MINUTE);
                int second = getPartOfOfxDate(ofxDate, PartDateTime.SECOND);
                return new DateTime(year, month, day, hour, minute, second);
            }
        }
    }
}
