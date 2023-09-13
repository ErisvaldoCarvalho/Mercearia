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
    public partial class FormMBuscarGrupoUsuario : FormMBuscarModelo
    {
        public FormMBuscarGrupoUsuario(bool _selecionarRegistro = false) : base(_selecionarRegistro)
        {
            InitializeComponent();
        }
        public override void Buscar()
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceBusca.DataSource = new GrupoUsuarioBLL().BuscarPorDescricao(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceBusca.DataSource = new GrupoUsuarioBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormMCadastroGrupoUsuario frm = new FormMCadastroGrupoUsuario())
                {
                    frm.ShowDialog();
                    Buscar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormMCadastroGrupoUsuario frm = new FormMCadastroGrupoUsuario(((GrupoUsuario)bindingSourceBusca.Current).Id))
                {
                    frm.ShowDialog();
                    Buscar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceBusca.Count == 0)
                    throw new Exception("Não existe registro para ser excluído!") { Data = { { "Id", 1006 } } };

                if (MessageBox.Show("Deseja realmente excluir este registro?", Constantes.NomeDoSistema, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                new GrupoUsuarioBLL().Excluir(((GrupoUsuario)bindingSourceBusca.Current).Id);
                bindingSourceBusca.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
