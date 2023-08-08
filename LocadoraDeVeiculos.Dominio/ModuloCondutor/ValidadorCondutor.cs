using LocadoraDeVeiculos.Dominio.Compartilhado.Validators;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor
{
    public class ValidadorCondutor : AbstractValidator<Condutor>, IValidadorCondutor
    {
        public ValidadorCondutor()
        {
            RuleFor(x => x.cliente)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.email)
                .NotEmpty()
                .NotNull()
                .VerificaFormatoEmail();

            RuleFor(x => x.telefone)
                .VerificaFormatoTelefone();

            RuleFor(x => x.cpf)
                .VerificaFormatoCpf();

            RuleFor(x => x.cnh)
                .VerificaFormatoCnh();

            RuleFor(x => x.validadeCnh)
               .NotEmpty()
               .NotNull()
               .GreaterThan(DateTime.Today.AddDays(15));
        }
    }
}
