namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public class ConfiguracaoToolboxAluguel : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Aluguel";
        public override string ToolTipInserir => "Cadastrar um Aluguel";
        public override string ToolTipEditar => "Editar um Aluguel Existente";
        public override string ToolTipExcluir => "Excluir um Aluguel Existente";
        public override string ToolTipDevolver => "Realizar a Devolução de um Aluguel";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
        public override bool SeparadorVisivel2 => true;
        public override bool DevolverHabilitado => true;
        public override bool DevolverVisivel => true;
    }
}
