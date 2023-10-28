using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormMCadastroCategoriaProduto : FormMCadastroModelo
    {
        public FormMCadastroCategoriaProduto(int _id = 0)
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
