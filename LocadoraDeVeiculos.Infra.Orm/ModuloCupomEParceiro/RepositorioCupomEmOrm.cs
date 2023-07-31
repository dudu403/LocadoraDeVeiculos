using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloConfigPreco
{
    public class RepositorioCupomEmOrm : RepositorioBaseEmOrm<Cupom>, IRepositorioCupom
    { 
        public RepositorioCupomEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }     
    }
}
