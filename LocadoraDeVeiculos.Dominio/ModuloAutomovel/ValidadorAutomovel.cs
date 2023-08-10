using LocadoraDeVeiculos.Dominio.Compartilhado.Validators;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public class ValidadorAutomovel : AbstractValidator<Automovel>, IValidadorAutomovel
    {
        public ValidadorAutomovel()
        {
            RuleFor(x => x.foto)
                .NotEmpty() 
                .NotNull()
                .VerificaTamanhoMax2MB();

            RuleFor(x => x.quilometragem)
                .NotEmpty()
                .NotNull()
                .SemValoresNegativosDecimal();

            RuleFor(x => x.grupoAutomovel)
               .NotEmpty()
               .NotNull();

            RuleFor(x => x.modelo)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.marca)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.cor)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .PodeApenasLetras();

            RuleFor(x => x.placa)
                .NotEmpty()
                .NotNull()
                .VerificaFormatoPlaca();

            RuleFor(x => x.tipoCombustivel)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.capacidadeTanqueLitros)
                .NotEmpty()
                .NotNull()
                .SemValoresNegativosDecimal();
        }
    }
}