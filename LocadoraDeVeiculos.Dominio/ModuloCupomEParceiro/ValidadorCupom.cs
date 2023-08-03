using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro
{
    public class ValidadorCupom : AbstractValidator <Cupom>, IValidadorCupom
    {
        public ValidadorCupom() 
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.validade)
               .NotEmpty()
               .NotNull()
               .GreaterThan(DateTime.Today);

            RuleFor(x => x.valor)
              .NotEmpty()
              .NotNull();
        }
    }
}