using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceBusca.DataSource = new UsuarioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceBusca.DataSource = new UsuarioBLL().BuscarPorNomeUsuario(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceBusca.DataSource = new UsuarioBLL().BuscarTodos();
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
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Você deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Usuario)bindingSourceBusca.Current).Id;
                new UsuarioBLL().Excluir(id);
                bindingSourceBusca.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarUsuario frm = new FormCadastrarUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (bindingSourceBusca.Count == 0)
            {
                MessageBox.Show("Não existe registro para ser alterado.");
                return;
            }

            int id = ((Usuario)bindingSourceBusca.Current).Id;

            using (FormCadastrarUsuario frm = new FormCadastrarUsuario(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = comboBoxBuscarPor.Items.Count - 1;
        }
    }
}
