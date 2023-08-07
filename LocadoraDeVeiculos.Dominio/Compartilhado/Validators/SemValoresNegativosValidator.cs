using FluentValidation;
using FluentValidation.Validators;

namespace LocadoraDeVeiculos.Dominio.Compartilhado.Validators
{
    public class NaoPodeValoresNegativosValidator1<T> : PropertyValidator<T, decimal>
    {
        public override string Name => "NaoPodeValoresNegativosDecimal";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve ser composto por apenas números positivos.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, decimal numero)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            if (numero <= 0)
                return false;
            else
                return true;
        }
    }

    public class NaoPodeValoresNegativosValidator2<T> : PropertyValidator<T, double>
    {
        public override string Name => "NaoPodeValoresNegativosDouble";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve ser composto por apenas números positivos.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, double numero)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            if (numero <= 0)
                return false;
            else
                return true;
        }
    }
}
