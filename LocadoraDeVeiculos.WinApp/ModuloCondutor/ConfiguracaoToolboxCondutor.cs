namespace LocadoraDeVeiculos.WinApp.ModuloCondutor
{
    public class ConfiguracaoToolboxCondutor : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Condutor";
        public override string ToolTipInserir => "Inserir novo Condutor";
        public override string ToolTipEditar => "Editar um Condutor existente";
        public override string ToolTipExcluir => "Excluir um Condutor existente";

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}
