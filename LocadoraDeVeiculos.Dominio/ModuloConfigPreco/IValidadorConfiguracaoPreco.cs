namespace LocadoraDeVeiculos.Dominio.ModuloConfigPreco
{
    public interface IValidadorConfiguracaoPreco
    {
        public ValidationResult Validate(ConfiguracaoPreco instance);
    }
}