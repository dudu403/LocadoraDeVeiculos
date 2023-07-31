namespace LocadoraDeVeiculos.WinApp.ModuloCupomEParceiro
{
    public class ControladorCupomEParceiro : ControladorBase
    {
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxCupomEParceiro();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
