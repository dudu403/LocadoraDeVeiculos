namespace LocadoraDeVeiculos.WinApp.ModuloTaxaEServico
{
    public class ConfiguracaoToolboxTaxaEServico : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Taxas e Serviços";
        public override string ToolTipInserir => "Configurar uma nova taxa ou serviço";
        public override string ToolTipEditar => "Editar uma taxa ou serviço existente";
        public override string ToolTipExcluir => "Excluir uma taxa ou serviço existente";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
