namespace LocadoraDeVeiculos.WinApp.ModuloFuncionario
{
    public class ConfiguracaoToolboxFuncionario : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Funcionario";

        public virtual string ToolTipInserir { get { return "Inserir novo Funcionario"; } }

        public virtual string ToolTipEditar { get { return "Editar um Funcionario existente"; } }

        public virtual string ToolTipExcluir { get { return "Excluir um Funcionario existente"; } }

        public override bool InserirHabilitado => true;
        public override bool InserirVisivel => true;
        public override bool EditarHabilitado => true;
        public override bool EditarVisivel => true;
        public override bool ExcluirHabilitado => true;
        public override bool ExcluirVisivel => true;
    }
}