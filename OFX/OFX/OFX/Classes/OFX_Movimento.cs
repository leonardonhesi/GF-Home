using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OFX.OFX.Classes
{
    public class OFX_Movimento
    {
        private String tipo;
        private DateTime data;
        private double valor;
        private String id;
        private String descricao;
        private long checksum;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public long Checksum
        {
            get { return checksum; }
            set { checksum = value; }
        }


    }
}
