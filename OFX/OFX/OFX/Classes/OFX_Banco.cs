using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OFX.OFX.Classes
{
    //Ao ler o arquivo OFX guardamos as informações de banco nesta classe
    class OFX_Banco
    {
        private int numero;
        private String nome;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public OFX_Banco(int numero, String name)
        {
            this.Numero = numero;
            this.nome = name;
        }
    }
}
