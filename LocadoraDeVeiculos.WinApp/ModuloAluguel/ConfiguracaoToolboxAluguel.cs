namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public class ConfiguracaoToolboxAluguel : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Aluguel";
        public override string ToolTipInserir => "Inserir novo aluguel";
        public override string ToolTipEditar => "Editar um aluguel existente";
        public override string ToolTipExcluir => "Excluir um Aluguel existente";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
