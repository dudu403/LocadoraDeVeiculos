using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloTaxaEServico
{
    public class RepositorioTaxaEServicoEmOrm : RepositorioBaseEmOrm<TaxaEServico>, IRepositorioTaxaEServico
    { 
        public RepositorioTaxaEServicoEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }     
    }
}
