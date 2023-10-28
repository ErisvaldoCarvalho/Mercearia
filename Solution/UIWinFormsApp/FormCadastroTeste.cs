using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormCadastroTeste : FormMCadastroModelo
    {
        public FormCadastroTeste(int _id):base(_id)
        {
            InitializeComponent();
        }
        public override void CarregarDadosParaEditar()
        {
            bindingSourceCadastro.DataSource = new CategoriaProdutoBLL().BuscarPorId(Id);
        }
        public override void Salvar()
        {
            new CategoriaProdutoBLL().Salvar((CategoriaProduto)bindingSourceCadastro.Current);
        }
    }
}