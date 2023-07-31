namespace LocadoraDeVeiculos.WinApp.ModuloConfigPreco
{
    public class ControladorConfigPreco : ControladorBase
    {
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxConfigPreco();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
