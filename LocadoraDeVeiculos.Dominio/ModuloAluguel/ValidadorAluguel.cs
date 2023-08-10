namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public class ValidadorAluguel : AbstractValidator<Aluguel>, IValidadorAluguel
    {
        public ValidadorAluguel()
        {
            RuleFor(x => x.funcionario)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.cliente)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.condutor)
               .NotEmpty()
               .NotNull();

            RuleFor(x => x.grupoAutomovel)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.automovel)
               .NotEmpty()
               .NotNull();

            RuleFor(x => x.planoCobranca)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.dataLocacao)
                .GreaterThan(DateTime.Today);

            RuleFor(x => x.dataPrevistaDevolucao)
                .NotEmpty()
                .NotNull()
                .GreaterThan(x => x.dataLocacao);
        }
    }
}