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
    public partial class FormMBuscarProduto : FormMBuscarModelo
    {
        public FormMBuscarProduto()
        {
            InitializeComponent();
            if (comboBoxBuscarPor.Items.Count > 0)
                comboBoxBuscarPor.SelectedIndex = 0;
            else
                throw new Exception("Você precisa inserir itens na comboBoxBuscarPor") { Data = { { "Id", -1 } } };

        }
        public override void Buscar()
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceBusca.DataSource = new ProdutoBLL().BuscarPorDescricao(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceBusca.DataSource = new ProdutoBLL().BuscarPorCodigoDeBarras(textBoxBuscarPor.Text);
                        break;
                    case 2:
                        bindingSourceBusca.DataSource = new ProdutoBLL().BuscarPorNomeMarca(textBoxBuscarPor.Text);
                        break;
                    case 3:
                        bindingSourceBusca.DataSource = new ProdutoBLL().BuscarPorNomeFornecedor(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceBusca.DataSource = new ProdutoBLL().BuscarTodos();
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
