using LocadoraDeVeiculos.Dominio.ModuloAluguel;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAluguel
{
    public class RepositorioAluguelEmOrm : RepositorioBaseEmOrm<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {           

        }
      
        //public List<Aluguel> SelecionarTodos(bool incluirMaterias = false, bool incluirQuestoes = false)
        //{
        //    if (incluirMaterias && incluirQuestoes)
        //        return registros
        //                .Include(d => d.Materias)
        //                .ThenInclude(m => m.Questoes)
        //                .ToList();

        //    else if (incluirMaterias)
        //        return registros
        //                .Include(d => d.Materias)
        //        .ToList();

        //    return registros.ToList();
        //}
    }
}
