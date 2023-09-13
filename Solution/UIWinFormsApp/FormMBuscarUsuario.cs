using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormMBuscarUsuario : FormMBuscarModelo
    {
        public Usuario Usuario;
        public FormMBuscarUsuario()
        {
            InitializeComponent();
        }
        public FormMBuscarUsuario(bool _selecionarRegistro = false) : base(_selecionarRegistro)
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void Buscar()
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceBusca.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceBusca.DataSource = new UsuarioBLL().BuscarTodos();
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
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceBusca.Count == 0)
                    throw new Exception("Não existe registro para ser excluído") { Data = { { "Id", 1003 } } };

                if (MessageBox.Show("Deseja realmente excluir este registro?", Constantes.NomeDoSistema, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                new UsuarioBLL().Excluir(((Usuario)bindingSourceBusca.Current).Id);
                bindingSourceBusca.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMBuscarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                    if (bindingSourceBusca.Count == 0)
                        throw new Exception("Não existe registro para ser selecionado!") { Data = { { "Id", 1004 } } };

                    Usuario = (Usuario)bindingSourceBusca.Current;
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormMCadastroUsuario frm = new FormMCadastroUsuario())
                {
                    frm.ShowDialog();
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
                if (bindingSourceBusca.Count == 0)
                    throw new Exception("Não existe registro para ser alterado!") { Data = { { "Id", 1006 } } };

                using (FormMCadastroUsuario frm = new FormMCadastroUsuario(((Usuario)bindingSourceBusca.Current).Id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}