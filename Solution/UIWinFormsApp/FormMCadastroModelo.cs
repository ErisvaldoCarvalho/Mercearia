using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormMCadastroModelo : Form
    {
        IBLL bLL;
        public int Id { get; set; }
        public FormMCadastroModelo()
        {
            InitializeComponent();
        }
        public FormMCadastroModelo(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        public FormMCadastroModelo(IBLL _bLL, int _id = 0)
        {
            InitializeComponent();
            Id = _id;
            bLL = _bLL;
        }

        private void FormMCadastroModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FormMCadastroModelo_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    bindingSourceCadastro.AddNew();
                else
                    CarregarDadosParaEditar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void CarregarDadosParaEditar()
        {
            bindingSourceCadastro.DataSource = bLL.BuscarPorId(Id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.EndEdit();
                Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public virtual void Salvar()
        {
            //bLL.Salvar((bLL.GetType())bindingSourceCadastro.Current);
        }
    }
}
