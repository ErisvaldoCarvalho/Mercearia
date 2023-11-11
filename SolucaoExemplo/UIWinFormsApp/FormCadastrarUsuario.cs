using BLL;
using Models;
using System.Security.Cryptography;

namespace UIWinFormsApp
{
    public partial class FormCadastrarUsuario : Form
    {
        int id;
        public FormCadastrarUsuario(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = (Usuario)bindingSourceCadastro.Current;
                if (textBoxSenha.Text != Constantes.SenhaParaExibicao)
                    usuario.Senha = textBoxSenha.Text;

                new UsuarioBLL().Salvar(usuario, textBoxConfirmacaoSenha.Text);
                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastrarUsuario_Load(object sender, EventArgs e)
        {
            if (id == 0)
                bindingSourceCadastro.AddNew();
            else
            {
                bindingSourceCadastro.DataSource = new UsuarioBLL().BuscarPorId(id);
                textBoxSenha.Text = Constantes.SenhaParaExibicao;
                textBoxConfirmacaoSenha.Text = textBoxSenha.Text;
            }
        }
    }
}