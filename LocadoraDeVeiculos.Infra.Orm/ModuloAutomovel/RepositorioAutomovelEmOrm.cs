using LocadoraDeVeiculos.Dominio.ModuloAutomovel;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel
{
    public class RepositorioAutomovelEmOrm : RepositorioBaseEmOrm<Automovel>, IRepositorioAutomovel
    {
        public RepositorioAutomovelEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }     
    }
}
