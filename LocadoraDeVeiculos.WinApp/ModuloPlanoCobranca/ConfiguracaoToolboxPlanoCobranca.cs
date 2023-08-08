namespace LocadoraDeVeiculos.WinApp.ModuloPlanoCobranca
{
    public class ConfiguracaoToolboxPlanoCobranca : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Plano e Cobrança";

        public virtual string ToolTipInserir { get { return "Inserir novo Plano"; } }

        public virtual string ToolTipEditar { get { return "Editar um Plano existente"; } }

        public virtual string ToolTipExcluir { get { return "Excluir um Plano existente"; } }

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
