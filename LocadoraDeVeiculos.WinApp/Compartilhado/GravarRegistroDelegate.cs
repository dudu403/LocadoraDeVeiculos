using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.Compartilhado
{

    public delegate Result GravarRegistroDelegate<T>(T registro)
        where T : EntidadeBase<T>;    
    
}
