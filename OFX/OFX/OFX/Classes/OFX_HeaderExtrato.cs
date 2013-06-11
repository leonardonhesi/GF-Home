using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OFX.OFX.Classes
{
    class OFX_HeaderExtrato
    {
        private String status;
        private String idioma;
        private DateTime dataServidor;
        private String nomeBanco;

        public OFX_HeaderExtrato()
        {
        }

        public OFX_HeaderExtrato(String status, String idioma, DateTime dataServidor, String nomeBanco)
        {
            this.status = status;
            this.idioma = idioma;
            this.dataServidor = dataServidor;
            this.nomeBanco = nomeBanco;
        }

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public String Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }

        public DateTime DataServidor
        {
            get { return dataServidor; }
            set { dataServidor = value; }
        }

        public String NomeBanco
        {
            get { return nomeBanco; }
            set { nomeBanco = value; }
        }

    }
}
