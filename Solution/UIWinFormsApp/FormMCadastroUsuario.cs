using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormMCadastroUsuario : FormMCadastroModelo
    {
        public FormMCadastroUsuario()
        {
            InitializeComponent();
        }
        public FormMCadastroUsuario(int _id = 0) : base(_id)
        {
            InitializeComponent();
        }
        private void FormMCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                    ((Usuario)bindingSourceCadastro.Current).Senha = textBoxSenha.Text;

                    if (Id == 0)
                        new UsuarioBLL().Inserir((Usuario)bindingSourceCadastro.Current, textBoxConfirmacaoSenha.Text);
                    else
                        new UsuarioBLL().Alterar((Usuario)bindingSourceCadastro.Current, textBoxConfirmacaoSenha.Text);

                    MessageBox.Show("Registro salvo com sucesso!");
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    bindingSourceCadastro.AddNew();
                else
                {
                    bindingSourceCadastro.DataSource = new UsuarioBLL().BuscarPorId(Id);
                    textBoxSenha.Text =
                    textBoxConfirmacaoSenha.Text = "************";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
