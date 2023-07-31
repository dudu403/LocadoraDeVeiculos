using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ModuloFuncionario
{
    public class ServicoFuncionario
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IContextoPersistencia contexto;
        public ServicoFuncionario(IRepositorioFuncionario repositorioFuncionario, IContextoPersistencia contexto)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.contexto = contexto;  
        }
    }
}
