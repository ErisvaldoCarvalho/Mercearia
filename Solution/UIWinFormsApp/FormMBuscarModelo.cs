namespace UIWinFormsApp
{
    public partial class FormMBuscarModelo : Form
    {
        public FormMBuscarModelo()
        {
            InitializeComponent();
        }

        public virtual void Buscar()
        {
            throw new NotImplementedException();
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

        private void FormMBuscarModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
