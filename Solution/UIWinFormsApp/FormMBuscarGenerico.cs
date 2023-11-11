using BLL;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Models;

namespace UIWinFormsApp
{
    public partial class FormMBuscarGenerico : FormMBuscarModelo
    {
        public FormMBuscarGenerico(IBLL _bLL):base(_bLL)
        {
            InitializeComponent();
        }
    }
}
