using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace OFX.OFX.Classes
{
    class OFX_Extrato
    {

        private OFX_HeaderExtrato headerExtrato;
        private OFX_Conta conta;
        private String status;
        private DateTime dataInicio;
        private DateTime dataFinal;
        private ArrayList movimento;
        
        public OFX_Extrato(OFX_HeaderExtrato headerExtrato, OFX_Conta conta,
            String status, DateTime dataInicio, DateTime dataFinal)
        {
            this.headerExtrato = headerExtrato;
            this.conta = conta;
            this.status = status;
            this.dataInicio = dataInicio;
            this.dataFinal = dataFinal;
        }

        public OFX_Extrato(OFX_HeaderExtrato headerExtrato, OFX_Conta conta,
            String status)
        {
            this.headerExtrato = headerExtrato;
            this.conta = conta;
            this.status = status;
        }

        public OFX_HeaderExtrato HeaderExtrato
        {
            get { return headerExtrato; }
            set { headerExtrato = value; }
        }

        public OFX_Conta Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public DateTime DataFinal
        {
            get { return dataFinal; }
            set { dataFinal = value; }
        }

        public ArrayList Movimento
        {
            get { return movimento; }
        }

        public OFX_HeaderExtrato Head
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public OFX_Conta Conta1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void addMovimento(OFX_Movimento movimento)
        {
            if (this.movimento == null)
            {
                this.movimento = new ArrayList();
            }
            this.movimento.Add(movimento);
        }
        

    }
}
