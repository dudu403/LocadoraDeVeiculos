using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloConfigPreco
{
    public class RepositorioCupomEmOrm : RepositorioBaseEmOrm<Cupom>, IRepositorioCupom
    { 
        public RepositorioCupomEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }

        public Cupom SelecionarPorNome(string nome)
        {
            return registros.SingleOrDefault(x => x.nome == nome);
        }
    }
}
