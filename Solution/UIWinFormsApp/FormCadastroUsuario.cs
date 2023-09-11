using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormCadastroUsuario : FormCadastroModelo
    {
        public FormCadastroUsuario(int _id = 0):base(_id)
        {
            InitializeComponent();
        }
        internal override object BuscarPorId()
        {
            return new UsuarioBLL().BuscarPorId(Id);
        }
        public override void FormCadastroModelo_Load(object sender, EventArgs e)
        {
            base.FormCadastroModelo_Load(sender, e);
        }

        internal override void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    new UsuarioBLL().Inserir((Usuario)bindingSourceCadastro.Current, textBox4.Text);
                else
                    new UsuarioBLL().Alterar((Usuario)bindingSourceCadastro.Current, textBox4.Text);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}