using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca
{
    public class ValidadorPlanoCobranca : AbstractValidator <PlanoCobranca>, IValidadorPlanoCobranca
    {
        public ValidadorPlanoCobranca()
        {
            RuleFor(x => x.precoDiaria)
             .NotEmpty()
             .NotNull();

            RuleFor(x => x.precoPorKmExtrapolado)
            .NotEmpty()
            .NotNull();

            RuleFor(x => x.precoPorKm)
            .NotEmpty()
            .NotNull();
        }
    }
}
