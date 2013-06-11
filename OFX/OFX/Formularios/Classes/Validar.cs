using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OFX.Formularios.Classes
{

    //Classe utilizada para validar os campos dos formulario impedindo campos vazios e 
    //permitindo somente numero em alguns campos
    
    public class Validar
    {
        //Verifica campo vazio
        //Recebe como parametro os controles do formulario
        public bool valCampoVazio(Control.ControlCollection valFormulario)
        {
            //Percorre os elementos do formulario 
            foreach (Control elemento in valFormulario)
            {
                //Se for textbox ja avalia
                if (elemento.GetType() == typeof(TextBox) && elemento.Name != "txtCodBar")
                {
                    

                        if (elemento.Text == "")
                        {

                            MessageBox.Show("Preencha todos os campos", "Aviso",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button3);
                            return false;
                        }
                    
                }
                //Se for groupBox
                if (elemento.GetType() == typeof(GroupBox))
                {
                    //Percorre os elementos do groupbox
                    foreach (Control groupElemento in elemento.Controls)
                    {
                        //qualquer elemento que não esteja preenchido dispara o alerta
                        if (groupElemento.Text == "" && groupElemento.Name != "txtCodBar")
                        {
                            MessageBox.Show("Preencha todos os campos", "Aviso",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button3);
                            return false;
                        }
                    }
                }

            }

            return true;
        }

        //Campos valores numericos
        public void valCampoNumero(KeyPressEventArgs e, TextBox txtBox)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
               (e.KeyChar != '-' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8)))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtBox.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }


    }
}
