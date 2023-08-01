namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel
{
    public class ConfiguracaoToolboxGrupoAutomovel : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Grupos de Automoveis";
        public override string ToolTipInserir => "Configurar novo grupo de automovel";
        public override string ToolTipEditar => "Editar um grupo de automovel existente";
        public override string ToolTipExcluir => "Excluir um grupo de automovel existente";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
