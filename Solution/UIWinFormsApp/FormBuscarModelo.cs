using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormBuscarModelo : Form
    {
        public IEntidade Entidade { get; set; }
        public FormularioModelo FormularioModelo { get; set; }
        public IBLL BLL { get; set; }
        public IEntidade InnerEntidade { get; set; }
        public FormBuscarModelo()
        {
            InitializeComponent();
        }
        public FormBuscarModelo(FormularioModelo _formularioModelo = null)
        {
            InitializeComponent();

            if (_formularioModelo == null)
                return;

            FormularioModelo = _formularioModelo;
            BLL = _formularioModelo.BLL;
            Entidade = _formularioModelo.Entidade;
            labelTitulo.Text = _formularioModelo.Titulo;
            bindingSourceBusca.DataSource = Entidade;
            InnerEntidade = _formularioModelo.InnerEntidade;
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceBusca.Count == 0)
                    throw new Exception("Não existe registro para ser selecionado") { Data = { { "Id", 1003 } } };

                Entidade = (IEntidade)bindingSourceBusca.Current;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroModelo frm = new FormCadastroModelo(new FormularioModelo(new GrupoProdutoBLL(),
                new GrupoProduto(),
                "Cadastro de grupo de produto",
                "Grupo de produto",
                "Departamento de produto",
                0)))
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
