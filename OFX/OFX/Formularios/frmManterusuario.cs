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
    public partial class frmManterusuario : Form
    {
        public frmManterusuario()
        {
            InitializeComponent();
        }

        List<usuario> carregaUser()
        {

            try
            {
                using (var objGerenciador = new dbGerenciadorEntities())
                {

                    var query = from conv in objGerenciador.usuario
                                select conv;
                    var ListaFinal = query.ToList();

                    return ListaFinal;
                }

            }

            catch (Exception ex)
            {
                List<usuario> padrao = new List<usuario>();
                MessageBox.Show("Erro: " + ex.Message);
                return padrao;
            }
        
        
        }

        //Excluir o usuario
        private void btnExcluir_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Deseja mesmo excluir o usuario selecionado?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {

                    //Verifica se temos mais de uma conta (somente uma não exclui)
                    using (var objGerenciador1 = new dbGerenciadorEntities())
                    {
                        
                        var query = from conv in objGerenciador1.usuario
                                    select conv;
                        var ListaFinal = query.ToList();


                        if (ListaFinal.Count > 1)
                        {
                            foreach (DataGridViewRow linha in dtgUsuario.SelectedRows)
                            {
                                string idusuario = Convert.ToString(linha.Cells[0].Value);

                                using (var objGerenciador = new dbGerenciadorEntities())
                                {
                                    var mensagem = (from deleteUsuario in objGerenciador.usuario
                                                    where (deleteUsuario.nome == idusuario)
                                                    select deleteUsuario).First();

                                    objGerenciador.DeleteObject(mensagem);
                                    objGerenciador.SaveChanges();

                                    dtgUsuario.AutoGenerateColumns = false;
                                    dtgUsuario.DataSource = carregaUser();
                                    MessageBox.Show("Usuário excluido!", "Aviso");

                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Só existe uma conta de usuário cadastrada, para exclusão precisamos de no minimo 2 contas", "Aviso");  
                        
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Aviso");

                }
            }


        }

        //Load do formulario
        private void frmManterusuario_Load(object sender, EventArgs e)
        {
            dtgUsuario.AutoGenerateColumns = false;
            dtgUsuario.DataSource = carregaUser();
        }
    }
}
