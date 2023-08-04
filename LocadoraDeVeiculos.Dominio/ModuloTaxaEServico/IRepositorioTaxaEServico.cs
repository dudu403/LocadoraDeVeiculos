namespace LocadoraDeVeiculos.Dominio.ModuloTaxaEServico
{
    public interface IRepositorioTaxaEServico : IRepositorio<TaxaEServico>
    {
        TaxaEServico SelecionarPorNome(string nome);
    }
}
