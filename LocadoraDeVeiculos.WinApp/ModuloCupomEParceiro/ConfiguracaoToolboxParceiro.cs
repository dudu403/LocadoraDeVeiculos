namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    public class ConfiguracaoToolboxParceiro : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Parceiros";
        public override string ToolTipInserir => "Inserir novo parceiro";
        public override string ToolTipEditar => "Editar um parceiro existente";
        public override string ToolTipExcluir => "Excluir um parceiro existente";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
