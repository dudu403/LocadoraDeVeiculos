using LocadoraDeVeiculos.Dominio.Compartilhado.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor
{
    public class ValidadorCondutor : AbstractValidator<Condutor>, IValidadorCondutor
    {
        public ValidadorCondutor()
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.telefone)
                .VerificaFormatoTelefone();

            RuleFor(x => x.email)
                .NotEmpty()
                .NotNull()
                .VerificaFormatoEmail();

            RuleFor(x => x.cpf)
                .Empty();

            RuleFor(x => x.cnh)
                .NotNull()
                .NaoPodeCaracteresEspeciais()
                .Empty();

            RuleFor(x => x.validadeCnh)
               .NotEmpty()
               .NotNull()
               .GreaterThan(DateTime.Today);
        }

    }
}
