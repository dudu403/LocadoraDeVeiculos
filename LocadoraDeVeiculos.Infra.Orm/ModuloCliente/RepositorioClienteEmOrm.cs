using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCliente
{
    public class RepositorioClienteEmOrm : RepositorioBaseEmOrm<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }

        public Cliente SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.nome == nome);
        }
    }
}
