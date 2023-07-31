namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel
{
    public class ContoladorAutomovel : ControladorBase
    {
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxAutomovel();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
