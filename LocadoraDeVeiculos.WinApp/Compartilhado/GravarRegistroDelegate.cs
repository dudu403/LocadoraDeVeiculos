using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinApp.Compartilhado
{
    public delegate Result GravarRegistroDelegate<T>(T registro)
        where T : EntidadeBase<T>;
}
