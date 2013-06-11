using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gerenciador.Data;

namespace OFX.Formularios
{
    public partial class frmManterNatureza : Form
    {
        public frmManterNatureza()
        {
            InitializeComponent();
        }

        //Carrega o grid
        List<Natureza> carregaNat()
        {
            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    var query = from conv in objGerenciador.Natureza
                                select conv;
                    var ListaFinal = query.ToList();

                    return ListaFinal;
                }

            }

            catch (Exception ex)
            {
                List<Natureza> padrao = new List<Natureza>();
                MessageBox.Show("Erro: " + ex.Message);
                return padrao;
            }
        
        
        
        
        
        }
        
        //Load do formulario
        private void frmManterNatureza_Load(object sender, EventArgs e)
        {
            
                    dtgNatureza.AutoGenerateColumns = false;
                    dtgNatureza.DataSource = carregaNat();
            
        }

        //Excluir natureza
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo excluir o natureza selecionada?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {

                    //Verifica se temos mais de uma conta (somente uma não exclui)
                    using (var objGerenciador1 = new dbGerenciadorEntities())
                    {

                        var query = from conv in objGerenciador1.Natureza
                                    select conv;
                        var ListaFinal = query.ToList();


                        if (ListaFinal.Count > 0)
                        {
                            
                            foreach (DataGridViewRow linha in dtgNatureza.SelectedRows)
                            {
                                string idNat = Convert.ToString(linha.Cells[0].Value);

                                using (var objGerenciador = new dbGerenciadorEntities())
                                {
                                    var mensagem = (from deleteNat in objGerenciador.Natureza
                                                    where (deleteNat.nome == idNat)
                                                    select deleteNat).First();

                                    objGerenciador.DeleteObject(mensagem);
                                    objGerenciador.SaveChanges();

                                    dtgNatureza.AutoGenerateColumns = false;
                                    dtgNatureza.DataSource = carregaNat();
                                    MessageBox.Show("Natureza excluida!", "Aviso");

                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
