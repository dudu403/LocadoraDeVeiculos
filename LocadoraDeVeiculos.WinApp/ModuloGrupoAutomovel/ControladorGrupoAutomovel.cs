
namespace LocadoraDeVeiculos.WinApp.ModuloGrupoAutomovel
{
    public class ControladorGrupoAutomovel : ControladorBase
    {
        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxGrupoAutomovel();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
