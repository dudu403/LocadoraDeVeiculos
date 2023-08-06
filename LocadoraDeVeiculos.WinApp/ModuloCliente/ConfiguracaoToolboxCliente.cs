namespace LocadoraDeVeiculos.WinApp.ModuloCliente
{
    public class ConfiguracaoToolboxCliente : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Cliente";

        public virtual string ToolTipInserir { get { return "Inserir novo Cliente"; } }

        public virtual string ToolTipEditar { get { return "Editar um Cliente existente"; } }

        public virtual string ToolTipExcluir { get { return "Excluir um Cliente existente"; } }

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
