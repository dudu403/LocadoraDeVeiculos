namespace LocadoraDeVeiculos.Dominio.ModuloConfigPreco
{
    public interface IRepositorioConfiguracaoPreco 
    {
        void GravarConfiguracaoPrecoEmArquivoJson(ConfiguracaoPreco configuracaoPreco);
        ConfiguracaoPreco ObterConfiguracaoPreco();        
    }
}
