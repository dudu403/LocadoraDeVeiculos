using System.Drawing.Drawing2D;

namespace LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel
{
    public interface IRepositorioGrupoAutomovel : IRepositorio<GrupoAutomovel>
    {
        GrupoAutomovel SelecionarPorNome(string nome);
    }
}
