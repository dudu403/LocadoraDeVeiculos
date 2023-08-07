using LocadoraDeVeiculos.Dominio.ModuloCondutor;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCondutor
{
    public class RepositorioCondutorEmOrm : RepositorioBaseEmOrm<Condutor>, IRepositorioCondutor
    { 
        public RepositorioCondutorEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }  
        
        public Condutor SelecionarPorNome(string nome)
        {
            return registros.SingleOrDefault(x => x.nome == nome);
        }
    }
}
