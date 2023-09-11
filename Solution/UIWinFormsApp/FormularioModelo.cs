using BLL;
using Models;

namespace UIWinFormsApp
{
    public class FormularioModelo
    {
        public int Id { get; internal set; }
        public string Titulo { get; set; }
        public IBLL BLL { get; set; }
        public Models.IEntidade Entidade { get; set; }
        public IEntidade InnerEntidade { get; set; }
        public string LabelDescricao { get; internal set; }
        public string LabelInnerDescricao { get; internal set; }

        public FormularioModelo(IBLL _bLL, IEntidade _entidade, string _titulo = "", string _labelDescricao = "Descrição", string _labelInnerDescricao = "Descrição", int _id = 0, IEntidade _innerEntidade = null)
        {
            Id = _id;
            Titulo = _titulo;
            BLL = _bLL;
            Entidade = _entidade;
            InnerEntidade = _innerEntidade;
            LabelDescricao = _labelDescricao;
            LabelInnerDescricao = _labelInnerDescricao;
        }
    }
}
