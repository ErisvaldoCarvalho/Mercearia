using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormMCadastroGrupoUsuario : FormMCadastroModelo
    {
        public FormMCadastroGrupoUsuario(int _id = 0) : base(_id)
        {
            InitializeComponent();
        }

        private void FormMCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    bindingSourceCadastro.AddNew();
                else
                    bindingSourceCadastro.DataSource = new GrupoUsuarioBLL().BuscarPorId(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMCadastroGrupoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                    if (Id == 0)
                        new GrupoUsuarioBLL().Inserir((GrupoUsuario)bindingSourceCadastro.Current);
                    else
                        new GrupoUsuarioBLL().Alterar((GrupoUsuario)bindingSourceCadastro.Current);

                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
