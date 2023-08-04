using LocadoraDeVeiculos.Dominio.Compartilhado.Validators;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public class ValidadorAutomovel : AbstractValidator<Automovel>, IValidadorAutomovel
    {
        public ValidadorAutomovel()
        {
            RuleFor(x => x.quilometragem)
                .NotEmpty()
                .NotNull()
                .SemValoresNegativos();

            RuleFor(x => x.marca)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .PodeApenasLetras();

            RuleFor(x => x.modelo)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .PodeApenasLetras();

            RuleFor(x => x.cor)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .PodeApenasLetras();

            RuleFor(x => x.tipoCombustivel)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.capacidadeTanqueLitros)
                .NotEmpty()
                .NotNull()
                .SemValoresNegativos();
        }
    }
}