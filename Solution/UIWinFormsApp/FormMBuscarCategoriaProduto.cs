using BLL;

namespace UIWinFormsApp
{
    public partial class FormMBuscarCategoriaProduto : FormMBuscarModelo
    {
        public FormMBuscarCategoriaProduto()
        {
            InitializeComponent();
        }
        public override void Buscar()
        {
            try
            {
                if (comboBoxBuscarPor.SelectedIndex != comboBoxBuscarPor.Items.Count - 1)
                    bindingSourceBusca.DataSource = new CategoriaProdutoBLL().BuscarPorNomeCampo(comboBoxBuscarPor.Text);
                else
                    bindingSourceBusca.DataSource = new CategoriaProdutoBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
