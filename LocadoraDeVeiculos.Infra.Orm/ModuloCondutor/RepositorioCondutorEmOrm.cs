using LocadoraDeVeiculos.Dominio.ModuloCondutor;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCondutor
{
    public class RepositorioCondutorEmOrm : RepositorioBaseEmOrm<Condutor>, IRepositorioCondutor
    { 
        public RepositorioCondutorEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }     
    }
}
