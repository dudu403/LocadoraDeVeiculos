using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinApp.Compartilhado
{

    public delegate Result GravarRegistroDelegate<T>(T registro)
        where T : EntidadeBase<T>;

    public delegate Result GravarRegistroDelegate(ConfiguracaoPreco config);

}
