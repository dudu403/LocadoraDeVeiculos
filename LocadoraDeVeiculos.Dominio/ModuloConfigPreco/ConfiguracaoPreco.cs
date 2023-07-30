namespace LocadoraDeVeiculos.Dominio.ModuloConfigPreco
{
    public class ConfiguracaoPreco : EntidadeBase<ConfiguracaoPreco>
    {
        public decimal precoGasolina { get; set; }
        public decimal precoDisel { get; set; }
        public decimal precoAlcool { get; set; }
        public decimal precoGas { get; set; }

        public override void AtualizarInformacoes(ConfiguracaoPreco registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
