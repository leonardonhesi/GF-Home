using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OFX.OFX.Classes
{
    class OFX_Conta
    {
        //Informações da conta
        
        private OFX_Banco banco;
        private String agencia;
        private String nconta;
        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }

        public OFX_Banco Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        public String nConta
        {
            get { return nconta; }
            set { nconta = value; }
        }

        public OFX_Banco Banco1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


    }
}
