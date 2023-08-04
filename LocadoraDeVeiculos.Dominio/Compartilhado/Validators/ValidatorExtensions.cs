namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
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

        public static IRuleBuilderOptions<T, string> VerificaFormatoEmail<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new FormatoEmailValidator<T>());
        }

        public static IRuleBuilderOptions<T, string> VerificaFormatoCpf<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new FormatoCpfValidator<T>());
        }

        public static IRuleBuilderOptions<T, string> VerificaFormatoCnpj<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new FormatoCnpjValidator<T>());
        }

        public static IRuleBuilderOptions<T, string> VerificaFormatoTelefone<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new FormatoTelefoneValidator<T>());
        }

        public static IRuleBuilderOptions<T, decimal> SemValoresNegativos<T>(this IRuleBuilder<T, decimal> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NaoPodeValoresNegativosValidator<T>());
        }
    }
}
