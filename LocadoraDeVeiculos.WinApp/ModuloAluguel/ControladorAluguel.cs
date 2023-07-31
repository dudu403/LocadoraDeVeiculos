namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxAluguel();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
