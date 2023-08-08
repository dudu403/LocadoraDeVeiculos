using FluentValidation;
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

            //EXEMPLO
            //    When(customer => customer.IsPreferred, () => {
            //    RuleFor(customer => customer.CustomerDiscount).GreaterThan(0);
            //    RuleFor(customer => customer.CreditCardNumber).NotNull();
            //});

            //RuleFor(x => x.precoPorKmExtrapolado)
            //.NotEmpty()
            //.NotNull();

            //RuleFor(x => x.precoPorKm)
            //.NotEmpty()
            //.NotNull();

            //RuleFor(x => x.kmDisponiveis)
            //    .NotEmpty()
            //    .NotNull();

            RuleFor(x => x.tipoPlano)
              .NotEmpty()
              .NotNull();

            RuleFor(x=> x.grupoAutomovel)
              .NotEmpty()
              .NotNull();
        }
    }
}
