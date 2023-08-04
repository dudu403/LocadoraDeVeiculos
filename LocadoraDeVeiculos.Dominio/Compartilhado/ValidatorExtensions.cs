namespace LocadoraDeVeiculos.Dominio.Compartilhado
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilderOptions<T, string> NaoPodeCaracteresEspeciais<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NaoPodeCaracteresEspeciaisValidator<T>());
        }

        public static IRuleBuilderOptions<T, string> PodeApenasLetras<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new PodeApenasLetrasValidator<T>());
        }

        public static IRuleBuilderOptions<T, decimal> SemValoresNegativos<T>(this IRuleBuilder<T, decimal> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NaoPodeValoresNegativosValidator<T>());
        }
    }
}
