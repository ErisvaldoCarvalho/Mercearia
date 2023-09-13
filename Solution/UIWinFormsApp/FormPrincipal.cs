using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                while (!new UsuarioBLL().ExisteUsuarioNoBanco())
                {
                    MessageBox.Show("Você precisa cadastrar o primeiro usuário!");

                    using (FormMCadastroUsuario frm = new FormMCadastroUsuario())
                    {
                        frm.ShowDialog();

                        if (frm.ShowDialog() == DialogResult.Cancel)
                            Application.Exit();
                    }
                }

                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!(bool)frm.Tag)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormMBuscarUsuario frm = new FormMBuscarUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormMBuscarGrupoUsuario frm = new FormMBuscarGrupoUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //using (FormBuscarModelo frm = new FormBuscarModelo(new FormularioModelo(new GrupoProdutoBLL(),
            //    new GrupoProduto(),
            //    "Cadastro de grupo de produto",
            //    "Grupo de produto",
            //    "Departamento de produto",
            //    0)))
            //{
            //    frm.ShowDialog();
            //}
        }
    }
}