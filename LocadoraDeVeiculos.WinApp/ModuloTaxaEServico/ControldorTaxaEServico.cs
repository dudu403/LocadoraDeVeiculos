namespace LocadoraDeVeiculos.WinApp.ModuloTaxaEServico
{
    public class ControladorTaxaEServico : ControladorBase
    {
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxTaxaEServico();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
