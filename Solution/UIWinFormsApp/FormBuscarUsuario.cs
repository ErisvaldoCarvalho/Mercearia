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
    public partial class FormBuscarUsuario : FormBuscarModelo
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            switch (comboBoxBuscarPor.SelectedIndex)
            {
                case 0:
                    bindingSourceBusca.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                    break;
                case 1:
                    bindingSourceBusca.DataSource = new UsuarioBLL().BuscarPorNomeUsuario(textBoxBuscarPor.Text);
                    break;
                case 2:
                    bindingSourceBusca.DataSource = new UsuarioBLL().BuscarTodos();
                    break;
                default:
                    break;
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroUsuario frm = new FormCadastroUsuario(((Usuario)bindingSourceBusca.Current).Id))
                {
                    frm.ShowDialog();
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
                using (FormCadastroUsuario frm = new FormCadastroUsuario())
                {
                    frm.ShowDialog();
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
                if (MessageBox.Show("Deseja realmente excluir esse registro?",Constantes.NomeDoSistema, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                new UsuarioBLL().Excluir(((Usuario)bindingSourceBusca.Current).Id);
                bindingSourceBusca.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
