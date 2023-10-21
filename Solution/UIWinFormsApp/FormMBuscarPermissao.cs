using BLL;

namespace UIWinFormsApp
{
    public partial class FormMBuscarPermissao : FormMBuscarModelo
    {
        public FormMBuscarPermissao()
        {
            InitializeComponent();
        }
        public override void Buscar()
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceBusca.DataSource = new PermissaoBLL().BuscarPorDescricao(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceBusca.DataSource = new PermissaoBLL().BuscarTodos();
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
    }
}
