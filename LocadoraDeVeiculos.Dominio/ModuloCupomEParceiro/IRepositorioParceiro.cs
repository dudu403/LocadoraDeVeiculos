namespace LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro
{
    public interface IRepositorioParceiro : IRepositorio<Parceiro>
    {
        Parceiro SelecionarPorNome(string nome);
    }
}
