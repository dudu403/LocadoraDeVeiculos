namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public class ValidadorAluguel : AbstractValidator<Aluguel>, IValidadorAluguel
    {
        public ValidadorAluguel()
        {
            //RuleFor(x => x.Nome)
            //    .NotEmpty()
            //    .NotNull()
            //    .MinimumLength(3)
            //    .NaoPodeCaracteresEspeciais();
        }
    }
}