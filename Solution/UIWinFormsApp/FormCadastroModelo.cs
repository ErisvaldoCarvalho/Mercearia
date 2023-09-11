using BLL;
using Models;

namespace UIWinFormsApp
{
    public partial class FormCadastroModelo : Form
    {
        public int Id { get; set; }
        public FormularioModelo FormularioModelo { get; set; }
        public IBLL BLL { get; set; }
        public IEntidade Entidade { get; set; }
        public IEntidade InnerEntidade { get; set; }

        public FormCadastroModelo(int _id)
        {
            InitializeComponent();
            Id = _id;
        }
        public FormCadastroModelo(FormularioModelo _formularioModelo)
        {
            InitializeComponent();
            Id = _formularioModelo.Id;
            BLL = _formularioModelo.BLL;
            Entidade = _formularioModelo.Entidade;
            labelTitulo.Text = _formularioModelo.Titulo;
            bindingSourceCadastro.DataSource = Entidade;
            InnerEntidade = _formularioModelo.InnerEntidade;
        }
        public virtual void FormCadastroModelo_Load(object sender, EventArgs e)
        {
            try
            {
                if (Id == 0)
                    bindingSourceCadastro.AddNew();
                else
                    bindingSourceCadastro.DataSource = BuscarPorId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal virtual object BuscarPorId()
        {
            return BLL.BuscarPorId(Id);
        }

        internal virtual void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.EndEdit();

                if (Id == 0)
                    BLL.Inserir((IEntidade)bindingSourceCadastro.Current);
                else
                    BLL.Alterar((IEntidade)bindingSourceCadastro.Current);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            using (FormBuscarModelo frm = new FormBuscarModelo())
            {
                frm.ShowDialog();
                if (frm.Entidade != null)
                    InnerEntidade = frm.Entidade;
            }
        }
    }
}