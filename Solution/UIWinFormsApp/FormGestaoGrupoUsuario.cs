using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormGestaoGrupoUsuario : FormMCadastroModelo
    {
        public FormGestaoGrupoUsuario()
        {
            InitializeComponent();
        }

        private void textBoxFiltrarGrupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.Filter = $"Descricao LIKE '%{textBoxFiltrarGrupo.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormGestaoGrupoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                    new GrupoUsuarioBLL().Alterar((GrupoUsuario)bindingSourceCadastro.Current);

                    MessageBox.Show("Registro salvo com sucesso!");
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void FormGestaoGrupoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.DataSource = new GrupoUsuarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}