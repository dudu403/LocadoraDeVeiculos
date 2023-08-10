namespace LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca
{
    public class ValidadorPlanoCobranca : AbstractValidator <PlanoCobranca>, IValidadorPlanoCobranca
    {
        public ValidadorPlanoCobranca()
        {
            RuleFor(x => x.grupoAutomovel)
              .NotEmpty()
              .NotNull();

            RuleFor(x => x.tipoPlano)
              .NotEmpty()
              .NotNull()
              .Must((x, tipoPlano) => !x.grupoAutomovel.planosCobranca.Any(p => p.tipoPlano == tipoPlano))
              .WithMessage("Esse tipo de plano já está cadastrado para este grupo de automovel.");

            When(x => x.tipoPlano == TipoPlanoEnum.Cobrança_Km_Livre, () => {

                RuleFor(x => x.precoDiaria)
                .NotEmpty()
                .NotNull();

                RuleFor(x => x.precoPorKm)
                .Empty();

                RuleFor(x => x.kmDisponiveis)
               .Empty();

                RuleFor(x => x.precoPorKmExtrapolado)
               .Empty();
            });

            When(x => x.tipoPlano == TipoPlanoEnum.Cobrança_Controlada, () => {

                RuleFor(x => x.precoDiaria)
                .NotEmpty()
                .NotNull();

                RuleFor(x => x.precoPorKm)
                .Empty();

                RuleFor(x => x.precoPorKmExtrapolado)
                .NotEmpty()
                .NotNull();

                RuleFor(x => x.kmDisponiveis)
                .NotEmpty()
                .NotNull();
            }); 

            When(x => x.tipoPlano == TipoPlanoEnum.Cobrança_Diária, () => {

                RuleFor(x => x.precoDiaria)
                .NotEmpty()
                .NotNull();

                RuleFor(x => x.precoPorKm)
                .NotEmpty()
                .NotNull();

                RuleFor(x => x.kmDisponiveis)
                .Empty();

                RuleFor(x => x.precoPorKmExtrapolado)
                .Empty();
            });
        }
    }
}
