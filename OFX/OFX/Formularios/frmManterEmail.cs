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

namespace OFX.Formularios
{
    public partial class frmManterEmail : Form
    {
        public frmManterEmail()
        {
            InitializeComponent();
        }

        //Atualiza grid
        public void atualizaGrid()
        {

            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    var qEmail = from conv in objGerenciador.email
                                 select new
                                 {
                                     conv.email1,
                                     conv.smtp,
                                     conv.porta


                                 };



                    var ListaEmail = qEmail.ToList();



                    dtgEmail.AutoGenerateColumns = false;
                    dtgEmail.DataSource = ListaEmail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);

            }

        
        }


        //Carrega os e-mails cadastrados
        private void frmManterEmail_Load(object sender, EventArgs e)
        {
            atualizaGrid();            
        
        }

        //Excluir o titulo selecionado
        private void btnExcluirEmail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir a  Conta selecionado?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {

                    foreach (DataGridViewRow linha in dtgEmail.SelectedRows)
                    {
                        string idApagar = Convert.ToString(linha.Cells[0].Value);

                        using (var objGerenciador = new dbGerenciadorEntities())
                        {
                            var mensagem = (from deleteEmail in objGerenciador.email
                                            where (deleteEmail.email1 == idApagar)
                                            select deleteEmail).First();

                            objGerenciador.DeleteObject(mensagem);
                            objGerenciador.SaveChanges();

                            MessageBox.Show("Conta excluida!", "Aviso");
                            atualizaGrid();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }
    }
}
