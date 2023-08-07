namespace LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro
{
    public interface IRepositorioCupom : IRepositorio<Cupom>
    {
        Cupom SelecionarPorNome(string nome);
    }
}
