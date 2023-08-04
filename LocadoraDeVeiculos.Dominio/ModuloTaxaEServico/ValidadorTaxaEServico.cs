using LocadoraDeVeiculos.Dominio.Compartilhado.Validators;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxaEServico
{
    public class ValidadorTaxaEServico : AbstractValidator<TaxaEServico>, IValidadorTaxaEServico
    {
        public ValidadorTaxaEServico()
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .PodeApenasLetras()
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.preco)
               .NotEmpty()
               .NotNull()
               .SemValoresNegativos();

            RuleFor(x => x.tipoDoCusto)
               .NotEmpty()
               .NotNull();
        }
    }
}