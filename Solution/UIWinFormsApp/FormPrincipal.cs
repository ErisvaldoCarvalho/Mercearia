using BLL;

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
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormMBuscarProduto frm = new FormMBuscarProduto())
            {
                frm.ShowDialog();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormMBuscarCategoriaProduto frm = new FormMBuscarCategoriaProduto())
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