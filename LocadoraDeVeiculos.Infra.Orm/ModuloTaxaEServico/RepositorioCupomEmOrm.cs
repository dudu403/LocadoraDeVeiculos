using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloTaxaEServico
{
    public class RepositorioTaxaEServicoEmOrm : RepositorioBaseEmOrm<TaxaEServico>, IRepositorioTaxaEServico
    { 
        public RepositorioTaxaEServicoEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           
        
        }

        public TaxaEServico SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.nome == nome);
        }
    }
}
