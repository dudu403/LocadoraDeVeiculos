using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCupomEParceiro
{
    public class RepositorioParceiroEmOrm : RepositorioBaseEmOrm<Parceiro>, IRepositorioParceiro
    { 
        public RepositorioParceiroEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        } 
        
        public Parceiro SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.nome == nome);
        }
    }
}
