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
    public partial class FormMCadastroModelo : Form
    {
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
            throw new NotImplementedException();
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
            
        }
    }
}
