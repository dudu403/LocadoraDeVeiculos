namespace LocadoraDeVeiculos.WinApp.ModuloConfigPreco
{
    public class ConfiguracaoToolboxConfigPreco : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Configuração de Preços";
        public override string ToolTipConfig => "Configurar preço dos combustíveis";

        public override bool ConfigVisivel => true;
        public override bool ConfigHabilitado => true;
    }
}
