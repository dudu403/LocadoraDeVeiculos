using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;

namespace LocadoraDeVeiculos.WinApp.Compartilhado
{

    public delegate Result GravarRegistroDelegate<T>(T registro)
        where T : EntidadeBase<T>;

    public delegate Result GravarRegistroDelegate(ConfiguracaoPreco config);

}
