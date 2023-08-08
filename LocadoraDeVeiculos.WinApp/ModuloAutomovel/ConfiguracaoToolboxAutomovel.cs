namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel
{
    public class ConfiguracaoToolboxAutomovel : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Automoveis";
        public override string ToolTipInserir => "Configurar novo automovel";
        public override string ToolTipEditar => "Editar um automovel existente";
        public override string ToolTipExcluir => "Excluir um automovel existente";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
