using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario
{
    public class RepositorioFuncionarioEmOrm : RepositorioBaseEmOrm<Funcionario>, IRepositorioFuncionario
    {
        private DbSet<Funcionario> funcionarios;
        private readonly LocadoraDeVeiculosDbContext dbContext;
    
        public RepositorioFuncionarioEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
            funcionarios = dbContext.Set<Funcionario>();
            this.dbContext = dbContext;
        }

        public Funcionario SelecionarFuncionarioPorNome(string nome)
        {
            return funcionarios.SingleOrDefault(x => x.nome == nome);
        }
    }
}
