namespace LocadoraDeVeiculos.Dominio.ModuloTaxaEServico
{
    public class TaxaEServico : EntidadeBase<TaxaEServico>
    {
        public string nome { get; set; }
        public decimal preco { get; set; }
        public TipoCustoEnum tipoDoCusto { get; set; }

        public override void AtualizarInformacoes(TaxaEServico registroAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}
