using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCliente
{
    public class RepositorioClienteEmOrm : RepositorioBaseEmOrm<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }     
    }
}
