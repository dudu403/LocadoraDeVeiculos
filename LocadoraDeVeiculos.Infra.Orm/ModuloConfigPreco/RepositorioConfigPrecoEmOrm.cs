using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloConfigPreco
{
    public class RepositorioConfigPrecoEmOrm : RepositorioBaseEmOrm<ConfiguracaoPreco>
    {
        public RepositorioConfigPrecoEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {

        }
    }
}
