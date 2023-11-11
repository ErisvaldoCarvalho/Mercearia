using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormMBuscarModelo : Form
    {
        internal IBLL bLL;
        public FormMBuscarModelo()
        {
            InitializeComponent();
        }
        public FormMBuscarModelo(IBLL _bLL, bool _selecionarRegistro = false)
        {
            InitializeComponent();
            bLL = _bLL;
            buttonSelecionar.Visible = _selecionarRegistro;
        }
        public FormMBuscarModelo(bool _selecionarRegistro = false)
        {
            InitializeComponent();
            buttonSelecionar.Visible = _selecionarRegistro;
        }
        private void textBoxBuscarPor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Inserir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Alterar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public virtual void Inserir()
        {
            using (FormMCadastroGenerico frm = new FormMCadastroGenerico())
            {
                frm.ShowDialog();
            }
        }
        public virtual void Buscar()
        {
            if (comboBoxBuscarPor.SelectedIndex == comboBoxBuscarPor.Items.Count - 1)
                bindingSourceBusca.DataSource = bLL.BuscarTodos();
            else
                bindingSourceBusca.DataSource = bLL.BuscarPorCampo(Constantes.Unverbose(comboBoxBuscarPor.Text), textBoxBuscarPor.Text);
        }
        public virtual void Alterar()
        {
            IEntidade entidade = (IEntidade)bindingSourceBusca.Current;

            if (entidade != null && int.TryParse(entidade.Id.ToString(), out int entityId))
            {
                using (FormMCadastroGenerico frm = new FormMCadastroGenerico(entityId))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                throw new Exception("Erro ao tentar pegar o Id da Entidade.") { Data = { { "Id", 1050 } } };
            }
        }
        private void Excluir()
        {
            IEntidade entidade = (IEntidade)bindingSourceBusca.Current;

            if (entidade != null && int.TryParse(entidade.Id.ToString(), out int entityId))
                bLL.Excluir(entityId);
            else
                throw new Exception("Erro ao tentar pegar o Id da Entidade.") { Data = { { "Id", 1051 } } };
        }
    }
}
