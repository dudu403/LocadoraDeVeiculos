namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    public class ConfiguracaoToolboxCupom : ConfiguracaoToolboxBase 
    {
        public override string TipoCadastro => "Cadastro de Cupom";
        public override string ToolTipInserir => "Inserir novo cupom";
        public override string ToolTipEditar => "Editar um cupom existente";
        public override string ToolTipExcluir => "Excluir um cupom existente";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
